namespace Jellyfish.API.Net;

public class PeerInfo
{
    public int Id { get; init; }
    public string Addr { get; init; } = string.Empty;
    public string? AddrBind { get; init; }
    public string? AddrLocal { get; init; }
    public string Services { get; init; } = string.Empty;
    public bool RelayTxes { get; init; }
    public decimal LastSend { get; init; }
    public decimal LastRecv { get; init; }
    public decimal BytesSent { get; init; }
    public decimal BytesRecv { get; init; }
    public decimal ConnTime { get; init; }
    public decimal TimeOffset { get; init; }
    public decimal? PingTime { get; init; }
    public decimal? MinPing { get; init; }
    public decimal? PingWait { get; init; }
    public decimal Version { get; init; }
    public string SubVer { get; init; } = string.Empty;
    public bool Inbound { get; init; }
    public bool AddNode { get; init; }
    public int StartingHeight { get; init; }
    public decimal? BanScore { get; init; }
    public decimal? Synced_Headers { get; init; }
    public decimal? Synced_Blocks { get; init; }
    public decimal[] InFlight { get; init; } = Array.Empty<decimal>();
    public bool WhiteListed { get; init; }
    public string[] Permissions { get; init; } = Array.Empty<string>();
    public decimal MinFeeFilter { get; init; }
    public Dictionary<string, decimal> BytesSent_Per_Msg { get; init; } = new();
    public Dictionary<string, decimal> BytesRecv_Per_Msg { get; init; } = new();
}
