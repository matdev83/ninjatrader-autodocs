namespace NinjaTrader.Cbi
{
    public enum ConnectionStatus : int
    {
        Disconnected = 0,
        Disconnecting = 1,
        ConnectionLost = 2,
        Connected = 3,
        Connecting = 4
    }
}
