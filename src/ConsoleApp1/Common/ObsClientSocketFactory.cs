using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObsStrawket;
using ObsStrawket.DataTypes.Predefineds;

namespace ConsoleApp1.Common;

public class ObsClientSocketFactory
{
    public static IObsClientSocket Create()
    {
        
    }
}


public class ObsClient
{
    IObsClientSocketDisconnected 
}


public interface IObsClientSocket : IDisposable
{
    protected Uri Uri { get; }
    protected ObsClientSocket ObsClientSocket { get; }
}

public interface IObsClientSocketDisconnected : IObsClientSocket
{
    protected async Task<IObsClientSocket> ConnectAsync(Uri uri)
    {
        await ObsClientSocket.ConnectAsync(uri);
        return this;
    }
}

public interface IObsClientSocketConnected : IObsClientSocket
{
    Task<GetVersionResponse> GetVersionAsync() => ObsClientSocket.GetVersionAsync();
}
