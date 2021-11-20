using Newtonsoft.Json;

namespace Jellyfish.API.Wallet;

public class CreateWalletOptions
{
    [JsonProperty("blank")]
    public bool? IsBlank { get; init; }
    public string? PassPhrase { get; init; }
    public bool? AvoidReuse { get; init; }
}
