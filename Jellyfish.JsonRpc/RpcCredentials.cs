namespace Jellyfish.JsonRpc;

public class RpcCredentials
{
    public string User { get; }
    public string Password { get; }

    public RpcCredentials(string user, string password)
    {
        User = user;
        Password = password;
    }
}
