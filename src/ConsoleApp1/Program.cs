using ObsStrawket;

using var client = new ObsClientSocket();



await client.ConnectAsync(new Uri("ws://localhost:4455"));



var version = await client.GetVersionAsync();

Console.WriteLine($"Version: {version.ObsWebSocketVersion}");

