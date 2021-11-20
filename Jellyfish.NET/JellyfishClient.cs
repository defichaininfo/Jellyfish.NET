using Jellyfish.API.Account;
using Jellyfish.API.Blockchain;
using Jellyfish.API.Governance;
using Jellyfish.API.ICXOrderBook;
using Jellyfish.API.Loan;
using Jellyfish.API.Masternode;
using Jellyfish.API.Mining;
using Jellyfish.API.Misc;
using Jellyfish.API.Net;
using Jellyfish.API.Oracle;
using Jellyfish.API.PoolPair;
using Jellyfish.API.RawTransaction;
using Jellyfish.API.Server;
using Jellyfish.API.SPV;
using Jellyfish.API.Token;
using Jellyfish.API.Wallet;
using Jellyfish.JsonRpc;

namespace Jellyfish;

public class JellyfishClient
{
    public Account Account { get; }
    public Blockchain Blockchain { get; }
    public Governance Governance { get; }
    public ICXOrderBook ICXOrderBook { get; }
    public Loan Loan { get; }
    public Masternode Masternode { get; }
    public Mining Mining { get; }
    public Misc Misc { get; }
    public Net Net { get; }
    public Oracle Oracle { get; }
    public PoolPair PoolPair { get; }
    public RawTransaction RawTransaction { get; }
    public Server Server { get; }
    public SPV SPV { get; }
    public Token Token { get; }
    public Wallet Wallet { get; }

    public JellyfishClient(string url, ClientOptions? options = null)
    {
        var client = new JsonRpcClient(url, options);

        Account = new Account(client);
        Blockchain = new Blockchain(client);
        Governance = new Governance(client);
        ICXOrderBook = new ICXOrderBook(client);
        Loan = new Loan(client);
        Masternode = new Masternode(client);
        Mining = new Mining(client);
        Misc = new Misc(client);
        Net = new Net(client);
        Oracle = new Oracle(client);
        PoolPair = new PoolPair(client);
        RawTransaction = new RawTransaction(client);
        Server = new Server(client);
        SPV = new SPV(client);
        Token = new Token(client);
        Wallet = new Wallet(client);
    }
}
