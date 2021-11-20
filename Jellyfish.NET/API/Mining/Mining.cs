using Jellyfish.API.Core;

namespace Jellyfish.API.Mining;

/// <summary>
/// Mining RPCs for DeFi Blockchain
/// </summary>
public class Mining
{
    private readonly IApiClient _client;

    public Mining(IApiClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns the estimated network hashes per second
    /// </summary>
    /// <param name="blocks">to estimate since last difficulty change.</param>
    /// <param name="height">to estimate at the time of the given height.</param>
    public async Task<int> GetNetworkHashesPerSecondAsync(int blocks = 120, int height = -1)
    {
        return await _client.CallAsync<int>("getnetworkhashps", blocks, height);
    }

    /// <summary>
    /// Get mining-related information
    /// </summary>
    public async Task<MiningInfo> GetMiningInfoAsync()
    {
        return await _client.CallAsync<MiningInfo>("getmininginfo");
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="confirmationTarget">in blocks (1 - 1008)</param>
    /// <param name="estimateMode">estimateMode of fees.</param>
    public async Task<SmartFeeEstimation> EstimateSmartFeeAsync(int confirmationTarget, EstimateMode estimateMode = EstimateMode.CONSERVATIVE)
    {
        return await _client.CallAsync<SmartFeeEstimation>("estimatesmartfee", confirmationTarget, estimateMode.ToString());
    }
}
