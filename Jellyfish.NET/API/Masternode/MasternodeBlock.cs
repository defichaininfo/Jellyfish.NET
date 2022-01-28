namespace Jellyfish.API.Masternode;

public class MasternodeBlock
{
    /// <summary>
    /// Masternode's id.
    /// </summary>
    public string? Id { get; init; }

    /// <summary>
    /// Masternode owner address.
    /// </summary>
    public string? OwnerAddress { get; init; }

    /// <summary>
    /// Masternode operator address.
    /// </summary>
    public string? OperatorAddress { get; init; }
}
