﻿namespace Jellyfish.Network;

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

    public static readonly string[] MainNetSkippedTxIds = {
        "ffcafd71820269ffe9cbecc12619154a3c5b272f1437d4e0242ff73d2bf09e4e",
        "4218d310d9a67b5e9a93d2a9ecf17bd70bda7a3670191efbc755b05c5fb8a6a4",
        "e189126e56b85e66144c93b7c2d91baaa2680aed62fed09d3ea954a995d0a8d1",
        "80c77656eaec77f893671e66bb2eefbbf73e141b65d8a5e1d151bc97fc9d2ef8",
        "a49e34c38fd899bab21fbb01e0bf77df916648b972992bfbf2867fd040261097",
        "fa28cb031aa4fdc88302e4c60f4abd9e3822bf5fc2e502fcd264b21b07b823f3",
        "9436003f88a641fbaafc6e00fe1bfb2ddd4ca304b55d458f593300f9ca2d3285",
        "31cc6209e24332464a7ac7adcfe93c247ca5a3c5b4f9acc340d133b158f95c39",
        "5587a6da89e32ba21823f2b4d7cf6cf7f0e3ec4f1e1b286ca311fce0665941df",
        "e80649287312ca0200fb057c1defa16015246164af690db9892c5c348b34c937",
        "95b399d9fb1ef3b63a5e0f0071204f6046022df2be95849918093a52c35a0c78",
        "d97aaefd4397824528132d91b9cab0e4c3abfc08c893be4cea02191cc18c5ded",
        "985f8d38d9aa6160be02933d36b6683eb47ebe2d4a7735d068de37781e7c614d",
        "35a07b93d238552a4f14294b7f791b2f8293a90ffe25344e55ef97a6008e07a0",
        "28d7798ed6c3f7d2fbf4cdcd30aff42035c6a154514263ffacd92f7de5db96b2",
        "0444d4825ee094e90ae94f88f19a5a0d1092fbb5d3d882a674ed07ccdb2eb1a7",
        "96d86ce92175c714a544f8f45fca08cc17e2f72cf6352b9cd930f152965277e7",
        "6f9c9383d72b4548c444ab7bd1159c70b62d16a34aeb49a84a646a35d30c726a",
        "681cffe5fc82e2fd544f61050f95f3d8b489de56b4fb48edf72cb4bc5e77bc70",
        "af7c6d1a872a5bfca3333b7eebf568091e4e471b81dd3f7bbc84e85ae5c480d8",
        "ecf1564390f291f73e0e399aaaa1deeb4ea43cde7777d6435b29d65800fe68f8",
        "dc554a7a4a29ad1023beff8e95d8b0d82adba69f5ee1332fd31312b49cc40c1c",
        "6480180d1fe751aa650e60f2b6c57a2fea77c97d5e6e8e2ee1316aa5d6b03b88",
        "009f8d084c01dfafb11ed86456629240ae71c0ca402f0c22e3b5ce59fa82d5e1",
        "a50abd1cb347b5740f87baec6df029951bf45b2d21df3120d7e915ee1d1ff182",
        "a87c7a281f4ac908caedbbd06111f4db7e2edae8a14a13b156458047b7747f86",
        "2ea0780ee8e987d45dd01840214a3a1840d88029bd679f940b36c80efb91a207",
        "cb28e755ff0e4590a6fd558129b5c61872da691140feced04d482b4c69eb344f",
        "a5fbe7163536e87d91c36f45b0975542c45fad7284c62cb2592548662dfe3796",
        "9c405cbed7db2d50e38592795f6fd5fd04923cf72b0cf601ef300547ff8adae0",
        "aa57e4eeaaa603262b8f87284b7b396900c5572587b85795a62b5ccd43fcee44",
        "4394684bfd9987f5321a3a32dae684aae76e7bd5949b360a1a0d70cbdf484ede",
        "b77e714aea068a5cd9a29d428529476ec06f268efb6ef81592768f172140c00d",
        "e8d67ff43e9316538cbae7c7328b0c8b5c9ffc20c7a727aed36d4d12d153de63",
        "8b092dd476b64f39b8bbdaee14ddf762df9117dc73eb3315c7b3536e39d9cc68",
        "7adc7c48e532fb00719346647d8125fc868699582c072fc92bd50f6e43ac4f52",
        "db1b1175e41b998e44c7c6743661b0a80c1633419681ae4d4e5cfef5fd5c538a",
        "60b3f187e94a003fb80bb13c6f4f13cea06eab3b2b353c282d0fba5317300eb1",
        "1aec8a6c95012b57008cdac7d195bbfa2fd6d656a61039f7fcb60410fe201aa4",
        "6c9e7811cb0445688bb596eaf2d217c307d76cb89b7346453d2a2807e7063eb4",
        "386322e8dc69d8d27acbd0ac855485d1dbacdc41617c0d22e6ebc893fa31a9cd",
        "4fa58b67d30847579414952e5ead0968f2318d8f39562e10fe5943ce31acb509",
        "5529972027b390820bac87825d00c8021751bcb6982b42e5ad8afc7e7c1bd4d7",
        "4e2170cb14a5aecec592166a8d550af22a0056706cf2b178edd9e01c8296ec66",
        "4dc1deee1d1ab15c0d36515c34def7bbec08ab75bdc31b628353f72418e0413a",
        "f6df01ac392911db4f7db20a36bdee8ff890e4cbb222308917cc85796ffef454",
        "bf0010e6d193e7cfbbdc37ebabdd9a44392faa5f96e5056a64c5393d0cf35c57",
        "d82a31354457546bd1f137bb969740d4f7e1b8c55eafbdb53668c94a59def865",
        "fc2f320fbd1fe0fa9cee42d77916bcbbed99d708a6179d46fe824b7d81a7d640",
        "bdcf70f61811407b1bece47c4d059c120f66271490b53cdaafa3969937d78fac",
        "84b89b3ebb27f421f0fb5aca8cb278cb4e923c60a5a7663500abb5d28ed94078",
        "f835245b51c96e7644a83e6cc25a97a01bf8937f8aaf07062922568df0ad5bf4",
        "711aa9bfd5e257ed96737f443c81be2f11dc293d382db07052651af1e9b23c20",
        "b235982686d53f7b3b320f82b9d2e0797a3e01118ce8eeecad001a36be86e71c",
        "e5bbe632a8f2de73b69076fc52fd4d5c34ce2ebbd5b764f34c3630716dda81de",
        "76a83f2249ce51e1a7bbaf5202b4d97d0b81444b1529fa8cb370dc3e804a7534",
        "0801761fcfe11c6e5308988e451759ff2ffa785850a1b926beba59ccd395c4d6",
        "d6683e99370460b684227a0e53d2808e28953c320f6dc727f5dccb310ce781c8",
        "9d37c6e758035a8fb666862d1e386439c023b0ce287ffac0cc3f3c6d9276173b",
        "0abc9dfde8b520373ed087d0e21587fcfde06099db2cb1397162c2aef7960a79",
        "bf8ea24e8b67d6a8b54f38d98e3931dbeb2a28fe1175e441a4a6e1e75182b063",
        "1b3e3a35fb203ddfdb59c234d11e4cdb2810358bc5d9b2f11347fe565d40dbc1",
        "0ab0b76352e2d865761f4c53037041f33e1200183d55cdf6b09500d6f16b7329",
        "c05c88e81acc4ceec896f023f881e3a2361168bc2c7d58c705b48c010a73e646",
        "d00a428dab82dd77ad1cd98aff19c2bc3e8ea66c12bb69840c01c3d5a9efeffd",
        "edc12f97ba7ef5adb5bfaa5bb23dd07845b0b82ae154114750d1f71097ec6d16",
        "e19a5096afbaa2813537ba4f58a0ceea8f995384fd4e060bfd275eab5aeb7c8b",
        "8c26822077d2067e4a1ddc1c60d63669c800167bff39d6125a359dbb49064a19",
        "288d0b2f3b53f664c7767dbd5a74753fd3770f380c7cbf336c24ce3b7ecd60ee",
        "75f08b3e30cd781acc0efeb785c37a3c95fc97e92429e84e8c8604dc356ee9e9",
        "061a3d67ec232b0a2a7da96bffb33db75bfb8e2a99c4fccd1ed154c150e7e6ba",
        "132f565363fb143d6d93386cacd23fcde80da586a1acad157821c4ef7d5404cf",
        "fabb98a77e9918bc3a7eaf8dfeb9be868a21f800d5eb765ecbb6214dd3cac1c9",
        "fa3e91f15bb99ff620301d0fd5f555bef82271098291f178318e39c7033d7000",
        "d320ddf6a776c7c8519f894627a635b86f67712c1f556f4283e27bad1a0cd3c6",
        "f7b010a21ea6e5a32b5dfb318df158423e386f5b6409ba3b39ef817fa3441c91",
        "4ed05f0b57c558bd649b9cee5bf26b9d8287d0c9cf55b87fcd3734c7d15b71df",
        "c26e803c660b8e75afb42e634ae98a8246b95d795f0e10706b9b446746aa65c3",
        "256080dbcdd79384641daaf1acdc4d98ada2418e363b8dcf4ffe264f5a98f768",
        "aa903d2a785e48d7d56cdb8cc045c7b217805ca8b39e75aeb92cf7d6d924bce6",
        "509fee1659ab82b5a98b9c6172c4530cc5cedf0116e13d96de3a4cfa9138f352",
        "820d04bdf2fe71ab37cdc3f2b9bd27329c39d0ecf17a01a4cbab145d65c673ce",
        "b9c5bd0dcc52e8ab625122246b23f364d1816fdd725573f14f4e4c4b23d5aae9",
        "d335014ef95af4c4b43560af2fbe6b7cb5cf7e418f33369de37f2d47ce14df14",
        "5bdfabdb059e3d5990e7e34104bb75db2567b1c4e7e70947390ab2eea13a7b79",
        "06582a883b4268ac889a88f4b118b7783be19d04955f73e4db3dedbf9e153da2",
        "b400a43760311d5c5d5cff76697e409c1f93736a52b2fcfc040ec72102177669",
        "43ce52b9cf9413d67833cf4ff218ed83f1577412b775e701de6c0a975877149d",
        "70e28ab44d09d20186f5d687bab0aa96c5c50bc9fc4df49656717f9461f8293a",
        "52a984f2e987775d1e6f573aa73b9fe29e3c53d99401b9252f47f3911a605835",
        "1433fc1db5c6b3f06d547d49335d0001661219bb71a3ebdb946fcbc700cc9118",
        "948e9ba6d053bfb6cd46f936e32ed68458cedb679a7ade9639c28fadb17894ee",
        "df6570476da12df2b0c872842c4c6db8b14995153d8c82acf1defce526788391",
        "01f90a6b8b32002198c31a2f1848594dc54936437391e708c7912229740c2ff7",
        "99306b726f16b5d71bd5f119fc544e4fb048690215a61d95a6ad0bd6130cc8ab",
        "eeed5a04aecf2eab3d25dfb36493f6658b16de92bc2a45a318d1cac9db0c49d6",
        "18e806b716f96a85f897d5eeb884ce5ffe814f4f059c143856362670f98efbfd",
        "1aa7f0435c287d1f7afb02418f0ec91a86cf7254b060dafbc721c3c2e84070ac",
        "7a8ffa4da5d1c39d42d28d61b8936d345ccdec6f1c8941bf6cf8a072b745a8bf",
        "d99d2dbc1a863b3635a41f5c2fb920a9bde40c316b5f2f339fb16837c2b2d2e3",
        "2ac7800b0bfe2df8781e92f013f9f23b7ac6f37c5417054bc6f31fe845c4f2ad",
        "dfc374165b8e4aad391cb3cb3572c483c813577804bdb702b011d93bb2ec9370",
        "b7147548e97017123da2515b5ea350ba4a22ddd65942d0778500bd8cb6cb8899",
        "588cc9c95b9f1ce65389b79d7da24c6f67e8651839073dd192528767be228bcf",
        "9a1d9b9489ae66af0ab222dc688ae1c0888825def98ea8393f960213471c18e5",
        "8ff534b441444245b891b7a6d0e412b190f2cef1b3c829c67748efdff62b88d8",
        "8140dd3a265de4ac57500b00ca50685d1e77ad9647a3ae3bb1f494fadfe21e4b",
        "29e7f896f333da8b06a9207948f28d4062d3050e9187ae34a98e53bc79e4d3e5",
        "123ac611e350aa2cfe125c5817fc53fb01ef82653623137318d0d154981a8cd4",
        "eb0522f3ef2b2c0dfb06089ad316fe15821d22fe39aafe1ab590a19c35b669ef",
        "bd8fce56da2295796189408b4f45890dcb96354700668a03a83b9cd5f278a97c",
        "3184a12cf00029214f37c836a93b829985419bc859e007e45f60837ac1ab143b",
        "d6ff9862aa08900591e4d93aa59558c689b6f123ba2a49dc5bc396b2859eb1c7",
        "d1e201c417fe9dd5d78a37f8177ac8aba2da52dc3e17cf9df81c74ee52ee4fa0",
        "ffbee4e013aae65a27b93d3fd454e7ee1215d9ff0901c103ca02120083994ebf",
        "5c31f86eeae9d06f181e524f9aa06b80ddb5424504ee45d6f516c91d9d2cf09e",
        "3a7c04eba93a9be69dbfda3ff42a527424de34b9a8fdfa34452426c0df9ef7f8",
        "5d5ad9adfe55114a4651a138d60e48f9e8a617b412525e72cc1bd3368ff9bbc3",
        "03fa1265fb8b26b571baf6dd95c5018e4b05f69942889948045fc603761a5b3a",
        "94707e6bf2e554f3ee3178f32cf1c7faa2b228e2f7f64638465f4f34b1688a5e",
        "a371f737969d5721e815c5b8f462f178f0c1138894ae675fd27390f6a6915928",
        "6478eaf3069bbd1c2352b9cb7d5d3316978dd56defc11df997542d88310969a0",
        "ce2f2ecb4a7480acbb7ed40ea40a23906f5528dd52c6cd7ed43c8b557b228fa7",
        "17a6e8df99fcaf396bf039f65dd2fad80d95493a6f77a22087a29eba2238f1fb",
        "ef3f52c7d4470093959c2cc206d5ec3e429cda400263b7e129a8eaaeb17dba7d",
        "5c34c639ba7bf651fb6ed2482f4d3f4f7da3241f6700606d4b5ad4584d989ce8",
        "7adbe577fc9f076bb42fc6d1e868d5ed92e67657babef2f2da0fdc8c793ee2df",
        "f426daa5da12162431328007d86c63695f7d21e89d66bb6d32b850df58fbada9",
        "812bcc962b5169fe46db31b36b9e91ccb018f7089b9e3e5aeba589dde0b0bab0",
        "fb6557bfe280cede8b5d4e1ae65838da70f36ab73862fffe16e567fbdb91b42b",
        "7d1878abb072569a0c9be0874de4aa12476f47be3441004af75e563dfd575d8f",
        "e9f10e2e06287c15291bf44ec3885ecf01c8412ff4ef7c0486688d5314c2feec",
        "d6353ab7516fbeb9acb10b420e62a3465da8d5f59061e0985f0eb7a6b7598e2c",
        "875a7a81bae526732cef14bd8a6ee550009dd6f90cd5220a747cd2b8c575ec8a",
        "2f8cb458f888ba9986d527d49f8d39f781004faa6aa85593cb5e7cb1defa12f5",
        "beff4e88f527995dfaf9fbf3bd49a90a1c6463fd5a90a9fdf78bac2811047df3",
        "06ecbca73dfedf0cb235d370e1a427b8fa0cc2bef922d06df5cbd50b589f992b",
        "5083598634a96a755b0d103b936470c2786e0c29f9ff42cd8f3cdae3c61528cb",
        "277bfe059dcd5f3f4a348b0d3074a91df25974ca1018aaa944bbe339ce05b969",
        "5af51fb4aae0a9ecca7a5065c132c1a9d4d328b73eddcd7cd447ef362b84da70",
        "157a14f72f2f109a182fec8ed951740218ae26d3a01c0c2240f2e7eccab9999e",
        "95de81aeb5440c1d7131a1ad73f17380049f02d9f554f95cb6b58a1214f4ea4e",
        "92cbb8851b926c043c2de871301d6c3b7a704ce5a38b345c508e249964d7dfed",
        "1a4cf7a044a77a2b13f805afaa676fd8e5495f06cd64e91ea7b022df1c04a820",
        "50c55370521bc26feaaf8a6e4586c4fe69cffefe275b70ebc06019f589ab1bea",
        "1a98f0e894f6e67880745e4f3479b5394d3ff52ec4b2f352c31f3ec1d96ca537",
        "09f8a8bd29a1fb018e5ad5220604ce27ede3b39b6e445b3a1a9bb4f7db6d6f7a",
        "e7edd6749d757fdd249b73df3869aab32b65ec14ad881637c3342c855861c59e",
        "3adc8cdfecbd3beb91f8b491cd188a021b2e7ed21b5d0356a5a1d3b3cc27f6fa",
        "978045603a6de7dbb184d9a382dd2d28d8317f4ecf5b5cd963b8ce4031c6c3cb",
        "ed1d1e8f48d5bc1fe4c01ea822d83b3eac7d831cfd36b2a5aaa990a59558ef95",
        "63999cc3e7b792bd4b67881d033b6cb7a6bed9527d52feb7ce1472f0727f6fd0",
        "03fd7081c9cf4d64e411bd5fb28126846a51824c9d09c88594bcc3f78e9b3592",
        "9be31bb296af4b7707ad5b6b5e1633103cb1fc9dfc7f72e1c441456416e9343c",
        "aedd9d98046589bf65eecf5e50a36edf0460966384e25976a541acbfa566caa8",
        "219795ea1ad60c6756122605162ffc296375ecf4e819c19d3bef9c05563dd2ef",
        "829286014c009a0019db9dada32abf06cb46f9add37de7f19cd10a1f864968b8",
        "94ad5ff7a9594ab49aa5935ca9027d76e945e0a5b8a807248ae688b5a2d64343",
        "cad0e3a95673aec32f0dc003f14c81be366e8c996f55ea9810a1ac32c99440c6",
        "622209d0116ec3b96de970d1a518030f5b42680190ccb12888c9cac62cd5b984",
        "95e1893be196cadd0ff74348d13d0b264297425076dfebd42bac6f4448d76b83",
        "4b9233212376ae74576641939cdd32577b8a982b4e7612ff83218996207c461c",
        "c5dd2b39accd01a6a94ea220c7774982b5b299a8c181cda755ea001baf733342",
        "c6d65947caeee0616a2f07bed8e8037c2e5707d6962a0017585f588e0d1fceaa",
        "1856799bff3fb09ff5f15048f0750c81db025b8719a7292f7aeaeb47ebe28d52",
        "ea25bd807290b1fe569bca2b332faa60e7b4ed96fa7389d2a6a124f7bfb512dc",
        "d78f7f438bc4f2a8ceacec17329b4a48103ea49252150cba641d9acdb4d6f4b1",
        "c6c422fdc2b22b8a540b56404b0fea444e9ba9510556f2520d7c3bb6301a27ab",
        "ca5d755250e6e21fa19a40378318c4fc1e8214b46807dee5167a5a0d08237f76",
        "8bfce5e34e5377e484854ccb7d782a0425f4251fc197a788bfb50a749098e0da",
        "38d6f1edb5d1ffd9dc4f016f3a8de96ca7479a79b5085ecacb7944aefb65ab87",
        "df92287851ad5b344963677d506557e71effcca6795cee74e8a8cf0025e7c40c",
        "40e831325e39b725c6ce398c590eedaa91d4e41736bfe5a9e45f6d41bc0bfacb",
        "96a9bb1896fccc97fb06400128a25b6e93d8fc47ba538963599421cdca20e08d",
        "2d543b981b45b9c63296a15acf5ce967fa5972dab279a9048ce2b9a72658f5a8",
        "36c4e9e7773454bd92eaff36d077e5da07a610a4ab3f89b5d2e73dde1eab729b",
        "78ed73b0370fdf229c2c6feb8eb9c8401e73e861b76065200cc0c7a2d98ff2e2",
        "d155250a08ccc1e0799b175e2ccf2a1f7c0cb670b57962aacf1092c7101ec7e6",
        "e0078962a2d434ef3fd3631584a19553809de6aab3329b86924e1c01014293f6",
        "eff1e9fcc6d1f5766427a1581724649dd9ab480f0aede615b02cfb8b76a9ac76",
        "908773fe4b11284c0e2dc64ad0dd343e32c72affebd49cfe36f1db7ac17c85d6",
        "de8aae7fcdef1b4edef0c348f3a65d24219194bc56681d71846cf5716b30a9f5",
        "35978e45b2a870b85976e4f556db8996d02b203fe4d5770ca9862fda96b168ce",
        "ab17ef14546a3d0eadaefdbf51c9368d5673de44b5541638506169ccb966044d",
        "4db941d19688e2c539687b7ea45b84dfda212f98e33d44ca0d4298acc637938e",
        "461b21ba1ac8a231bc6f0e0d0c5af8fecc9d4c3177a1abb03e7456bbb16a1f88",
        "1dc9821a64325a77fa0a561e33a66cd162b302c43290266a329f3825a426d7c5",
        "0cedc6ff163ff1f37e6d6090971fa97b7a84764e4cc419f860494bcf3dc64332",
        "8a329c4ed566f5599090e359c3eb6d8862232d3fea3407ad81c6bbf50a2bf1a6",
        "93fa0c70d4617331e8453fe593add9247cd183901038207a5bf4d20df70c78ca",
        "b587f2d5c377f440ddc2be3c3671108d6eb0a0fb446877859007401ac0b2abf6",
        "2c5fb421f908ac47ac166d9f1cc953668190a833c8809ee1cd447da1233dd7fd",
        "10bc24c667d06f94b2634b41e03e7f1a3d7f5c4934df8c191090378970b6dc3f",
        "27c31a3ae3c4246b8d940f107d70a374154906203b37dddd65779e17dde505ad",
        "361a4b3043695ec2be73d1120c3614376ccd0aba128bfc9a940638cfee9a9b23",
        "f6335610dce1ff2e8ea7769768469f99d31981b92cf9c9af130c267a6856eb75",
        "e1b480d98cdf41ea694b792eb94039ebe2ba6343597f2cb691c261c0ec4679d2",
        "b20892a7530c6da1e9835f23f9ca51351b412e39badc81189ec99cb8230f8ad2",
        "7a0a32f122c470b5f0932abde695a24f5ecbe7b74f9bb2b77bb7dcc1ac408cf6",
        "f3c7815a2bee014903640767e1bdbc02d99000b61d5a42f3b8fc589aa05e7888",
        "929c05d2684fa8e26e0ac2c3c5ac2e5657f60c7567f887f674e7b41aa2cfab80",
        "4cb8b86a4e8c60a227cdc0a3b43271c9e181e79d9f4193117f09aeb65e0d1c29",
        "8e958e4288e6f7fa47a36ced20f0fd5d89592321fc4f97b01e89d08086628ccc",
        "33f740882d3f5d9e2afd027958dbd8b32032e04adb4ae596e07390125158f3d3",
        "63211da6fd4b4e8ff533ce44edf6ada47ffb21d047a4033e4504fa34341798ca",
        "e256170cb22cfedad942b8008aedd15dd7a84927137af51aff313ec28b9b1bf8",
        "b4ae94a0098b7c32f29d7aaf3411d05cc9411ff9f64dbdd2b75d46dd54b3e1f1",
        "c91b4759aad11edd22bf8e46ff9a23149be8d5084c0b2012e88c2aa796a824e2",
        "a7f91cd66f653bb01b93139e8b34143164ef7b8c5600a571c1140a12580d3967",
        "fd00d352ba385f9e593a1282c6fb62582e55f5f8d3303fd7888ab85fb3716eeb",
        "19ed20cf54db296060368bda5ac4ae58e1470b9b90c565e95329ad289cc69fa5",
        "ed91a663c19bc1f74f465f26717bdf3671cf02036f6d1f5ef45964483ab746e6",
        "b7dfedfcee131def65c51aed3bdf27d1cd075fc53ce57759c8441353250c36f0",
        "57c855ab849e7371e968437e94948d2881c38ed8616c336e0d9782c54e955a71",
        "bb86c0621b2a056ad909d4ae8d3f8ad4f48791820b76234fed000aa3d19d93f2",
        "e2bbeb69cf34ad45c67db09dcf74c7d45c02e51982dddfb661edbde5e796f29f",
        "a8cb070f17d22587103416527404ba4a4a7e65e73b4de34fe7419e295e203344",
        "f54e138ec0392f42e036a944a8530e6855e710d6449145afe08669803287d3fb",
        "a9a0c1df293972d5e9a6542d8e8faa9161255f0b79e0956b02ecb057fd47bf48",
        "4a4983ac422bce3ada4d528a8caf3a86b2691d56964489c14236aff7d6203db7",
        "c4b684815bf64df9806307699619c6179afcf6124a4edbcd1a1616fe80a45def",
        "4d1c5585299c93e27bd8a9daaa70c4f0d73c567fc09611a67d01a795bae67dae",
        "75c4e427dc68b13b24e1d944f7192995bf64f31d6d54416c4c7388527e79ffe2",
        "3f658e7312e33eae2fbf13aaf40289363397db9fee494dab4c6873db7ff52fdd",
        "9d3445a8144c662c45617a2419234ffad8fac12fc16331659bb828e6600d4af0",
        "722eef4ac927c70886414c221eb51e737b3dd8280762e0fe8c246f1d0bcc20d1",
        "9f08929babed6484acfe78cbb3ca1443ef7ee24b08b76f7eacf13ff87a14a9a3",
        "2ac642d59056d6a84ddaf8ebbb057d2a21e39792aec3cde95f57a604c940838f",
        "9cced3a84b6ddae3f016e144f3708f4821eaf620c29bf42ca8203ddbf971049b",
        "b340faa755f66bc5726c09e7a7f9810db07a307ec6ebd3c01d39582ea306ae20",
        "84b536d7ce03eec38ef3d52d5799ca6b84778b3a558d3090d745f62369eaa7a7",
        "2b81ec9f2a03d5a40f125a6b7f725370bcb50254185c7563103a5a61030c3927",
        "53933f73b4ca96510db7cfceddb3cb98447dca20fb4fd2d3ea8fbd05dcfdddc5",
        "c287fe6d2586ddce466e7ff59cb0b8205fe734401cf42aa93cd5257ad51439f7",
        "60b1592300b31f11b05b73aeb1b77887ac9a2f24bb94d0ed5c18cab770eb8100",
        "faa830e9a8baee6660a8db62d05a34996e48beb748428bd2a004b5e17d896cce",
        "c152ce2b46b5e49508dc18938c2b8a575b3e001fa4397f13ea65554ca6f3a3d3",
        "cdfa1ad30596b60ab3f8a4fdb931530d1a96b9a176323d969d519ea7636b678d",
        "bf23fb3cd240215ca03e8d732ebfd9c4414d9da57aadadb2a60ae49ab4d3b35e",
        "22f644f1f763bb17aa11f3f3d23a5f41b501862941d9c2838c54d6f5ada7faf6",
        "7a41a5337902fd5fc0eb97fc7e75aca7f8dff38bc10a36c90f859f710d6e4a36",
        "957835f7767f2580d340c4039b2d1144993b9bd908be62db7c9cb80291f215c2",
        "cf3bf007426b200e1315fb650d6c8fcc544db1efe7723f5cba940c0c3fe4e9a4",
        "75d368aa68cb05409c46640938bc18e825b70ea7047481b6f03da5a6a7cbcc1b",
        "667ae4748eb46489dcda951c3d6dde00e6cf47cbb5b42f38ee772e480dfc567c",
        "3bfdbfe217b0aabeef2915a0915e47f6a09c28022c134bf29a0082935d7c4432",
        "8625b04ebe9e444f5a90d83ac8fd27c119756ad9f120984b8f06c92839e57bde",
        "79276bbe931838786f0c5eb1c4480e8418e4537e2968f41b1f18a094cc06631a",
        "be8083239c54aa5c421ca3da87a51837fd2c9e65b0be084b80c9ac72ea53a57f",
        "966f3a7b327614fb89c64204c79ef35a3246bfe8f5e44fb4b8da859d44f03dd3",
        "2a217ed1d535b5de810784af9640c66756ff819444eb8fa8a802b6399397dae9",
        "ad0c940caff402378d73eeacf7b55c05fc37804185c56ad1bb103aa21d29f85a",
        "6a5fe7712d01fd99ea0a50fb66a8610993ab7eeaaae3f9fa190409bd07557a56",
        "994205f817be06676c32b84d2fead2f60be8f622b3bd0e9e7869bec972994fd5",
        "432fbb3913bb16ce8479cca0e01fa97a3c04eae617735dbbb48c70a9d9faa0be",
        "343782f7647b1117f531832d1533e39ea564a7cb3cb86196430b16a863e154b1",
        "3140c8d7d29b4b75973d12c4d10b4a6e44c3e533ae8ab08c16a79703bd08ea8f",
        "2987cff1bf6b28603610e45cbc52213630e9ca4622945783d3187b961d8ae87f",
        "7a2941df71dd3d5215c31444924ed412d3401a1c2053ecdbf75692a789447e8b",
        "d5754cc668e6e05548dee85dd9908fb36b48fbe446276f281fa7c37363aa42d8",
        "0491bdd1148c092ea1be94806c72217321dd4d7902ea4adf4106814ff32f098a",
        "9ce7bd10d5eabe9db99472f1e4a0f1c0a4a3a1411f7e195bf269d4a3b30680ed",
        "4f5a896678477391b3ff5ab74980a05aba7ca00430b0d9045024d66fc6aeedad",
        "67aa62e5bcd4c205444e141379ac3a2e7ceb1ac36a5ec50d5cc02ab193d3426c",
        "0c4296687f5a2f6664579adb4afb106ba47ff915e2b63fe935f44d0dc9a25edd",
        "cee5e6eb2909701a0288151739fde30e0a2723b18ccd59aa7db5afd25a60d5a2",
        "c0468d09d74a0fb30ce5dfda7c53866e33e3e457ad742fca33807e37a1d27d0d",
        "0ef807072182cc5f030c3fab2be14b00bee1edbe9c7e5cb358b1126347fe1aaf",
        "d42c3c7c4bc3d7dfa80d1df4aa110368e6592254e6e6753bfa27a590b1374984",
        "8380fc35c16081ffbb6a023c989a9ad4d9644de4c8073d39e5d43b479f96e2cb",
        "444dd409031ddfa0b3ffcf92bee7e9f08bda1b9c193a755cdfc3954878d715d8",
        "a29a64be3e5f6948b1fea4fcf5d7d4ffd418b0dd18419536f453d95e79bd919c",
        "a27765c77fd9511f89728c7099c563c7da1ffba7e42c1ae674aae82985804721",
        "28d0d8925ad4b4df33a2fc7f6f21e39873a8f9d76a9a636ed2ad327259f7e5fc",
        "48b2c6ad69a190a2d95b22a2169f768502f15c936ba06f748e9777b8086a8963",
        "6182bb04e8eb98b629378998e01fa8c47629f27f134e14d7397efda6c74f88ac",
        "ae40b0bd14003a588df523c2837f0b05a4e0cc8157be010e4109b7526b34dd95",
        "34de8bdb2b03958ef3d81a744db7aa3f7f95cd112d0f53d63143f45f6de8bfe4",
        "23b55d16e7c48d0502d428e07574ff7ea928e44bf1442bca732b5927db2370a5",
        "9008838391ee77748d96ceebce05b02182aba985963a461f985d34ebefc0e9b8",
        "40d860046e0ac1163ce27af02fcf5b2280f7dbfb23eec29300d2ba4b9c9c693b",
        "a638f5c833734bd1a185c613c1559a5bb87b62dee5a4ada713a7e8c48bb39930",
        "e31a5f0e938b587742348ff003fe635e31f6113030d9e8f30d4e22ddc89144cd",
        "5cf6572465f3cfe67cb431e588cc4246f79f245001188dda15c4d85b4801321d",
        "6dc0bf6130add1e40bfe6311951a1a2fe602c8796d234a86b6aff4985ee27feb",
        "8a3b3dbcc386361f76841bbcdead026afa2a6c568e8e97c156fb849b6a465dc4",
        "320daeb9ccea9f34ee629136fbd55b07f222b9b3ce1f94987a7e20fed17206e5",
        "2f49861cd2e01b26c5a84ce4cee2438327761afee50a48c89d6d7b49018b7fcf",
        "e69c8cf076852b36e45e5be83218a3accf29094e4e9895b36aa56f9a10d284b4",
        "a8566fa6c2fec3f79f2611c1db9dbb25b856fedc9b3856008397b0f0178778b1",
        "b9200a2a81d114b953e3563d9856822753ba4b7703943b0df920352e4ad300d4",
        "31e319dcc4c3ec0f089e371d39a790b7e967896917c26926aac256954cbc52f9",
        "fbd3031cef8c0c8330f83153e9753313edfb899a170c20531d06ea9a45217856",
        "e563c3665885e9254e14440b42e3c2bf0eae51180571c3e2a2f8c99bc8a8fd83",
        "07288958348e0cc68880849818d806834e84b6541a622d1e952ed0a85efa2d98",
        "1fcd0987e064964e8796c3e297d6b8d6477ccca8dd37175bf3d0935161baf2b6",
        "df3f905163ab3d87e9867b18dec20fdc7301e1312761470fe7827f3c7a3db96a",
        "9de32735e458f45ebdcbb307321f693781b3f005cc375570ba5eb9bdad3cafb6",
        "a7fbca77957e7ae4b135dc04daced4b319bfe100bdb612b0d6c8fe330ca876c8",
        "9b2e6addb9131b2aa8d9d01bb4a3684a9980fa59ef8eb6ddbf9c8804b041f4ce",
        "a9481433389c5a2acdcab26e600e500c3709249dc14c01b7025de2719fdb68e2",
        "09dcb87aaca6537622c5c8125f39df290bd8343cd89b4c497046992634c147da",
        "537102a29f389fca9edf41239c62b332fe92a71527588182e893d46b5f2ae7cc",
        "c004039ccbe8bfa4625372d3c9754eb16e814a2a370c7e8bdf6021aeb9633963",
        "b1186a4e8caea3d1d0c06f4c00ee9fa386ae3f3b8a8dd92d1adae8aaf6462b1f",
        "88f4aca157bee6712046cf5efee0dec950c966ac32e68c4e51328411f48ddc42",
        "1e2688c6aff721fde920d60a838b5462dd4447e251581e7ca97a4fd7564be63a",
        "e716d47275fcec2ca23863880f9c21ff53fe74a87c30c23943e2b1b468352566",
        "ea0ee24c027c79c5a9fd9b47ae556e6aaddfe2b97e00fd855e91aee45cd064fd",
        "b7adfa74a8d03dc963202c231fa527ea6f9168afa6b6f0c8cc4fe0ec0f7baacd",
        "3807d25698eed478f6802982ad5bdbee3083bfa07253305f96e76bea6d9f5d7c",
        "9d04e40577c3ac00b0f66f4cbba694f01ddb0e56ca303160a8acce6b649675d3",
        "2c47612ef589a6f2b82ce23672f581aecb065640201df8d02a185e2de15635d0",
        "adf24254e91a47236003315e0b8c25fa5f86d5bbe5d35bd083a488e2b89a8c7a",
        "cca693215a23955ee155ff41fa4027523b05dd2e1afade1878ab171daed11078",
        "8692daae3b0608de881e01c86d8c1e45cba1f32996869ce8e6cf3b8f793a41f0",
        "398f15b36141ed45f0724b8e1060d3a67f28e4d99ae2c064d4d0fa8e8c720bf7",
        "d570289b50e3e8f57e70ed955b7b87992ffdb16f3bc4908a9a9425d0210a14d8",
        "5ae446d92abc358e0077b932494baf9983a31a27f548268390a2094e98985222",
        "16f423a7835fe2e2cfb869494e5bd43b25660452f62b377b69884a28b5a323c8",
        "88331376b5428f50a91b84af5edf56e438e59ebd2a83cd840c20f0ff966fbfff",
        "af9d12d94e4c3ae112f5cabeba7f6eba5105e1ba2c4f71f4fd90cb0f3f671ebc",
        "a3debcaa4d4b6d950822b0fb612a436278d23b305128972e9737aac0c703097f",
        "03753f72efd39aec75a3840a4acef16830ff9d25f41ddbc6d13c1dbf5cdb71ef",
        "17f1ae9c3247e556215929dcb383ba18aaac2ae9b6f3784ea7d738beff46cce5",
        "a0c43101293a4183f74a575b10384341e9a3e5106c21e3882dd42ba792f6beb6",
        "dccf54f2eb6e441304cbc4ceb659b936cd36fa75c70609bf31a4287b40d0df8a",
        "e9c9204781d9bf34edcd52eb222ae469f310c37b45e9d6b8e86017a81b54a889",
        "9f84dc532aef6865b04161a61bcaaa0371ccb22db5e92366f314e67d46b020ef",
        "e282255e252194f1fe94ea32e063020ad0ed7471ba3d959d71841251f545ec50",
        "8ee17d97bc69a166939da3a10815d207843861c949a64795a276b3b7e6d76cee",
        "51792977284ef54f288a9cb144ed0b0dab129146c5206e7c56c3e5b94058b1ba",
        "63c8831e07ce87543117ab11e4fda4ac7d10dcb2dbe0ed9a69e0035c3f010ded",
        "bc87d9b6d2dcd9d2ac6e86aacc394853f349214ba910d63588924232088d7a53",
        "ad9b8e4446a0326cea32e64346803c15595cdaa7eb48660b981db6ef3eafd168",
        "2e724245446b50e8e94adb0c7d6dac108324c7063646a07080c670e0842291f1",
        "938628f96d7e1bf5fada66b1681c8cf3731463451a66a9a792e099ca09f59910",
        "58484171dbe293667f81b76c6f0d493928a92543bf46076cc62de3d0d1ce02cf",
        "0863180da779d530ff5184908bc1ddd85910a5c643d1317fe0f3796f47eba414",
        "27273069347a23a4e5fee10346ab67813f99b8e09c3d31d4b1c4384fa6bed588",
        "f872f706976de4ebf97429946b83d7c1e0480496f26442d4253440a0f462ba82",
        "949c7243483d52b85e6ef058fe8814b5fd6b307a529fd34c07daa8eae5759770",
        "7a1001461506e3b5a4de3c3de74a1a838ab6b6d1530042ff9bd802e6bda90e91"
    };

    public static readonly string[] TestNetSkippedTxIds = {
        "6c8eaa51142b069305e07aea0ee247a467f1fc7d1378428005b8034e069e8cda",
        "9dbd8e2f2f331e0d314968baedaf49065e45fbd0316c95e8e1e02548437a76f4",
        "4f5f620484e5359eafb9fe799b568a59ca75202bfe6aa1546c54820c99889437",
        "b22fca714f70f68e45bef2babc5d7f0a1c81fd892ddfd347edb43cc80fc31db2",
        "08e864402d066cb7e0f65f587c2450c03f982f04b06728f455df0930a1f062dc",
        "a20faada80dc028a821cf5c3889071442fe7d5f1487e669e907512f060da86e7",
        "97cb98df139d608a79e277fe6edd4439867be032aa6463c13cab18de12632db3",
        "b90b85e05f58d73d339be4563bcbf6c9fd041a1ddf175538135fae96937453df",
        "af264140932d5ec7049639ae1d8d3453a307d6ed3272a7d12ead4d09370cca9c",
        "a65a1c2e37461c01e19f99675e448eb23b64d0dd1234547a30b45ebf5e9e7ba2",
        "dfd54905c6a323d92fd923a2fcc592e005fa8488e2f3774cb585f7fd33068433",
        "f5166734c9fe55d46325c2406454daddc698ff9d76491dff8e6553027d53878f",
        "e30ad732c4ec80946a9aef649e3eef521bf408f29539c0ff254b67272cc908ea"
    };

    public bool IsSkippedTxId(string txid, NetworkName network)
    {
        return network switch
        {
            NetworkName.MainNet => MainNetSkippedTxIds.Contains(txid),
            NetworkName.TestNet => TestNetSkippedTxIds.Contains(txid),
            _ => false
        };
    }
}
