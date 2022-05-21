namespace Jellyfish.Network;

/// <summary>
/// All calculation are in satoshi.
/// 
/// This class cache all 1252 reductions block subsidies and milestones allowing instantaneous computation.
/// With very little memory footprint, 1252 x 2 BigNumber classes for both getSupply and getBlockSubsidy.
/// </summary>
public class BlockSubsidy
{
    private readonly decimal[] _reductionBlockSubsidies;
    private readonly decimal[] _reductionSupplyMilestones;
    private readonly CoinbaseSubsidyOptions _options;

    public BlockSubsidy(CoinbaseSubsidyOptions? options = null)
    {
        _options = options ?? Network.MainNetCoinbaseSubsidyOptions;
        _reductionBlockSubsidies = ComputeBlockReductionSubsidies();
        _reductionSupplyMilestones = ComputeReductionSupplyMilestones(_reductionBlockSubsidies);
    }

    /// <summary>
    /// DFI supply calculation up to a given height are done with the best effort.
    /// This does not take DFI burning into account.
    /// Fee burning, burn address, round-down burning, loan burning, etc. are all excluded.
    /// </summary>
    /// <returns>supply in satoshi up to given height</returns>
    private decimal GetSupply(int height)
    {
        ValidateHeight(height);

        if (height < _options.EunosHeight)
        {
            return GetPreEunosSupply(height);
        }
        return GetPostEunosSupply(height);
    }

    /// <returns>total block subsidy in satoshi at the given height</returns>
    private decimal GetBlockSubsidy(int height)
    {
        ValidateHeight(height);

        if (height == 0)
        {
            return _options.GenesisBlockSubsidy;
        }

        if (height < _options.EunosHeight)
        {
            return _options.PreEunosBlockSubsidy;
        }

        var reductionCount = (int)(((decimal)height - _options.EunosHeight) / _options.EmissionReductionInterval);
        if (_reductionBlockSubsidies.Length > reductionCount)
        {
            return _reductionBlockSubsidies[reductionCount];
        }

        return 0;
    }

    /// <summary>
    /// Calculate pre-eunos supply
    /// </summary>
    private decimal GetPreEunosSupply(int height)
    {
        var supply = _options.GenesisBlockSubsidy + _options.PreEunosBlockSubsidy * height;
        return supply;
    }

    /// <summary>
    /// Calculate post-eunos supply
    /// </summary>
    private decimal GetPostEunosSupply(int height)
    {
        var postEunosDiff = height - (_options.EunosHeight - 1);
        var reductionCount = (int)((decimal)postEunosDiff / _options.EmissionReductionInterval);
        var reductionRemainder = postEunosDiff % _options.EmissionReductionInterval;
        
        if (reductionCount >= _reductionBlockSubsidies.Length)
        {
            return _reductionSupplyMilestones[_reductionSupplyMilestones.Length - 1];
        }

        return _reductionSupplyMilestones[reductionCount] + _reductionBlockSubsidies[reductionCount] * reductionRemainder;
    }

    private decimal[] ComputeReductionSupplyMilestones(decimal[] reductionBlockSubsidies)
    {
        var preEunosTotalSupply = _options.PreEunosBlockSubsidy * (_options.EunosHeight - 1);
        var baseSupply = _options.GenesisBlockSubsidy + preEunosTotalSupply - _options.EunosFoundationBurn;

        var supplyMilestones = new List<decimal> { baseSupply };

        for (var i = 1; i < reductionBlockSubsidies.Length; i++)
        {
            var previousBlockSubsidy = reductionBlockSubsidies[i - 1];
            var previousMilestone = supplyMilestones[i - 1];
            supplyMilestones.Add(previousMilestone + previousBlockSubsidy * _options.EmissionReductionInterval);
        }

        return supplyMilestones.ToArray();
    }

    private decimal[] ComputeBlockReductionSubsidies()
    {
        var subsidyReductions = new List<decimal> { _options.EunosBaseBlockSubsidy };

        while(true)
        {
            var previousSubsidy = subsidyReductions[subsidyReductions.Count - 1];
            var amount = (int)(previousSubsidy * _options.EmissionReduction / 100000);
            if (amount == 0)
            {
                subsidyReductions.Add(0);
                break;
            }

            subsidyReductions.Add(previousSubsidy - amount);
        }

        return subsidyReductions.ToArray();
    }

    private void ValidateHeight(int height)
    {
        if (height <= 0)
        {
            throw new Exception("height must be positive");
        }
    }
}
