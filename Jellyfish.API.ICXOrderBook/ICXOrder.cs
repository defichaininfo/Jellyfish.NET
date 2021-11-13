namespace Jellyfish.API.ICXOrderBook;

public class ICXOrder
{
    /// <summary>
    /// Symbol or id of selling token
    /// </summary>
    public string? TokenFrom { get; init; }

    /// <summary>
    /// Symbol or id of selling chain
    /// </summary>
    public string? ChainFrom { get; init; }

    /// <summary>
    /// Symbol or id of buying chain
    /// </summary>
    public string? ChainTo {  get; init; }

    /// <summary>
    /// Symbol or id of buying token
    /// </summary>
    public string? TokenTo { get; init; }

    /// <summary>
    /// Address of DFI token for fees and selling tokens in case of DFC/BTC order type
    /// </summary>
    public string? OwnerAddress { get; init; }

    /// <summary>
    /// pubkey which can claim external HTLC in case of EXT/DFC order type
    /// </summary>
    public string? ReceivePubKey { get; init; }

    /// <summary>
    /// tokenFrom coins amount
    /// </summary>
    public decimal AmountFrom { get; init; }

    /// <summary>
    /// Price per unit
    /// </summary>
    public decimal OrderPrice {  get; init; }

    /// <summary>
    /// Number of blocks until the order expires, default 2880 DFI blocks
    /// </summary>
    public int Expiry { get; init; } = 2880;
}
