# Jellyfish.NET

## Welcome to Jellyfish.NET

If you want to build a .NET application that operates on the DeFiChain, you have come to the right place!

But be warned: This project is huge and under active development. You can already use some parts of Jellyfish.NET, others not yet. If you want to contribute, feel free to do so, your help is appreciated.

## What is Jellyfish.NET?
This project is a .NET port of DeFiChain [Jellyfish](https://github.com/DeFiCh/jellyfish). It is used to communicate with a DeFiChain full node and contains tools and libraries to build .NET applications for the DeFiChain.

Its goal is to be roughly in sync with the APIs and features provided by the DeFiChain team to let .NET developers utilize its full potential.

Jellyfish.NET utilizes modern .NET technology and programming techniques. It is built on the newly released .NET 6 and C# 10 and supports nullable reference types. API methods follow a task-based approach with the `async`/`await` pattern.

## What is already complete and what isn't?
- You can already use all of the existing Jellyfish APIs. This also means that there is a functioning API client as well as JSON serialization support
- The APIs also include the upcoming decentralized stocks (Loan and Oracle APIs).
- Other library code, like transaction signing or wallet management is not yet ported but will be there in the future.
- It is also planned to provide Jellyfish.NET as a NuGet package for easier consumption.

## How to use Jellyfish.NET today
As a prerequisite, you have to have a DeFiChain full node running on your computer. You also have to set up an RPC username and password on that full node.

Then to use Jellyfish.NET, just check out the sources and add them to your solution. Reference the Jellyfish Assembly as seen in the Jellyfish.Sample project. From there, you only have to create a client and can start calling API methods!

```csharp
var client = new JellyfishClient("http://foo:bar@localhost:8554");
var prices = await client.Oracle.ListPricesAsync();
```

## License & Disclaimer

Like with the original Jellyfish project, by using Jellyfish.NET (this repo), you (the user) agree to be bound by [the terms of this license](https://github.com/defichaininfo/Jellyfish.NET/blob/main/LICENSE) (MIT License).
