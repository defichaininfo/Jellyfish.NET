namespace Jellyfish.Network;

/// <summary>
/// Network specific DeFi configuration.
/// They can be found in DeFiCh/ain project in file chainparams.cpp, under base58Prefixes
/// </summary>
public class Network
{
    /// <summary>
    /// MainNet specific DeFi configuration.
    /// </summary>
    public static Network MainNet { get; } = new Network(NetworkName.MainNet, new("df"), new(0x0488b21e, 0x0488ade4), 0x80, 0x12, 0x5a);

    /// <summary>
    /// TestNet specific DeFi configuration.
    /// </summary>
    public static Network TestNet { get; } = new Network(NetworkName.TestNet, new("tf"), new(0x043587cf, 0x04358394), 0xef, 0xf, 0x80);

    /// <summary>
    /// RegTest specific DeFi configuration.
    /// </summary>
    public static Network RegTest { get; } = new Network(NetworkName.RegTest, new("bcrt"), new(0x043587cf, 0x04358394), 0xef, 0x6f, 0xc4);

    public NetworkName Name { get; }
    public Bech32 Bech32 { get; }
    public Bip32 Bip32 { get; }

    /// <summary>
    /// base58Prefixes.SECRET_KEY
    /// </summary>
    public int WifPrefix { get; }

    /// <summary>
    /// base58Prefixes.PUBKEY_ADDRESS
    /// </summary>
    public int PubKeyHashPrefix { get; }

    /// <summary>
    /// base58Prefixes.SCRIPT_ADDRESS
    /// </summary>
    public int ScriptHashPrefix { get; }

    /// <summary>
    /// For message signing.
    /// </summary>
    public string MessagePrefix { get; } = "\x15Defi Signed Message:\n";

    private Network(NetworkName name, Bech32 bech32, Bip32 bip32, int wifPrefix, int pubKeyHashPrefix, int scriptHashPrefix)
    {
        Name = name;
        Bech32 = bech32;
        Bip32 = bip32;
        WifPrefix = wifPrefix;
        PubKeyHashPrefix = pubKeyHashPrefix;
        ScriptHashPrefix = scriptHashPrefix;
    }

    /// <returns>Network specific DeFi configuration</returns>
    public Network GetNetwork(NetworkName name) => name switch
    {
        NetworkName.MainNet => MainNet,
        NetworkName.TestNet => TestNet,
        NetworkName.RegTest => RegTest,
        _ => throw new Exception($"{name} network not found")
    };

    public static MasterNodeKey[] RegTestFoundationKeys { get; } = new MasterNodeKey[]
    {
        new MasterNodeKey
        {
            Owner = new KeyPair
            {
                Address = "mwsZw8nF7pKxWH8eoKL9tPxTpaFkz7QeLU",
                PrivateKey = "cRiRQ9cHmy5evDqNDdEV8f6zfbK6epi9Fpz4CRZsmLEmkwy54dWz"
            },
            Operator = new KeyPair
            {
                Address = "mswsMVsyGMj1FzDMbbxw2QW3KvQAv2FKiy",
                PrivateKey = "cPGEaz8AGiM71NGMRybbCqFNRcuUhg3uGvyY4TFE1BZC26EW2PkC"
            }
        },
        new MasterNodeKey
        {
            Owner = new KeyPair
            {
                Address = "msER9bmJjyEemRpQoS8YYVL21VyZZrSgQ7",
                PrivateKey = "cSCmN1tjcR2yR1eaQo9WmjTMR85SjEoNPqMPWGAApQiTLJH8JF7W"
            },
            Operator = new KeyPair
            {
                Address = "mps7BdmwEF2vQ9DREDyNPibqsuSRZ8LuwQ",
                PrivateKey = "cVNTRYV43guugJoDgaiPZESvNtnfnUW19YEjhybihwDbLKjyrZNV"
            }
        },
        new MasterNodeKey
        {
            Owner = new KeyPair
            {
                Address = "myF3aHuxtEuqqTw44EurtVs6mjyc1QnGUS",
                PrivateKey = "cSXiqwTiYzECugcvCT4PyPKz2yKaTST8HowFVBBjccZCPkX6wsE9"
            },
            Operator = new KeyPair
            {
                Address = "mtbWisYQmw9wcaecvmExeuixG7rYGqKEU4",
                PrivateKey = "cPh5YaousYQ92tNd9FkiiS26THjSVBDHUMHZzUiBFbtGNS4Uw9AD"
            }
        },
        new MasterNodeKey
        {
            Owner = new KeyPair
            {
                Address = "mwyaBGGE7ka58F7aavH5hjMVdJENP9ZEVz",
                PrivateKey = "cVA52y8ABsUYNuXVJ17d44N1wuSmeyPtke9urw4LchTyKsaGDMbY"
            },
            Operator = new KeyPair
            {
                Address = "n1n6Z5Zdoku4oUnrXeQ2feLz3t7jmVLG9t",
                PrivateKey = "cV9tJBgAnSfFmPaC6fWWvA9StLKkU3DKV7eXJHjWMUENQ8cKJDkL"
            }
        },
        new MasterNodeKey
        {
            Owner = new KeyPair
            {
                Address = "mgsE1SqrcfUhvuYuRjqy6rQCKmcCVKNhMu",
                PrivateKey = "cRJyBuQPuUhYzN5F2Uf35958oK9AzZ5UscRfVmaRr8ktWq6Ac23u"
            },
            Operator = new KeyPair
            {
                Address = "mzqdipBJcKX9rXXxcxw2kTHC3Xjzd3siKg",
                PrivateKey = "cQYJ87qk39i3uFsXBZ2EkwdX1h72q1RQcX9V8X7PPydFPgujxrCy"
            }
        },
        new MasterNodeKey
        {
            Owner = new KeyPair
            {
                Address = "mud4VMfbBqXNpbt8ur33KHKx8pk3npSq8c",
                PrivateKey = "cPjeCNka7omVbKKfywPVQyBig9eopBHy6eJqLzrdJqMP4DXApkcb"
            },
            Operator = new KeyPair
            {
                Address = "mk5DkY4qcV6CUpuxDVyD3AHzRq5XK9kbRN",
                PrivateKey = "cV6Hjhutf11RvFHaERkp52QNynm2ifNmtUfP8EwRRMg6NaaQsHTe"
            }
        },
        new MasterNodeKey
        {
            Owner = new KeyPair
            {
                Address = "bcrt1qyrfrpadwgw7p5eh3e9h3jmu4kwlz4prx73cqny",
                PrivateKey = "cR4qgUdPhANDVF3bprcp5N9PNW2zyogDx6DGu2wHh2qtJB1L1vQj"
            },
            Operator = new KeyPair
            {
                Address = "bcrt1qmfvw3dp3u6fdvqkdc0y3lr0e596le9cf22vtsv",
                PrivateKey = "cVsa2wQvCjZZ54jGteQ8qiQbQLJQmZSBWriYUYyXbcaqUJFqK5HR"
            }
        },
        new MasterNodeKey
        {
            Owner = new KeyPair
            {
                Address = "bcrt1qyeuu9rvq8a67j86pzvh5897afdmdjpyankp4mu",
                PrivateKey = "cUX8AEUZYsZxNUh5fTS7ZGnF6SPQuTeTDTABGrp5dbPftCga2zcp"
            },
            Operator = new KeyPair
            {
                Address = "bcrt1qurwyhta75n2g75u2u5nds9p6w9v62y8wr40d2r",
                PrivateKey = "cUp5EVEjuAGpemSuejP36TWWuFKzuCbUJ4QAKJTiSSB2vXzDLsJW"
            }
        }
    };
}
