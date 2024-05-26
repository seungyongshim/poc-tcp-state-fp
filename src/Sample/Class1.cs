using System.Net.NetworkInformation;

namespace Sample;

public class TcpConnection
{
    public TcpState1 State { get; internal set; }


    public TcpConnection()
    {
        State = TcpClosed.Instance;
    }

    public string Host { get; }
    public int Port { get; }
}

public class TcpClosed : TcpState1
{
    public static TcpClosed Instance { get; } = new TcpClosed();

    private TcpClosed()
    {
    }

    public override void ActiveOpen(TcpConnection connection) => base.ActiveOpen(connection);
}
