[Flags]
namespace NinjaTrader.Core
{
    public enum TraceLevels
    {
        None = 0,
        Bars = 1,
        Connect = 4,
        Database = 8,
        ResolveInstrument = 64,
        MarketData = 128,
        MarketDepth = 256,
        Native = 512,
        News = 1024,
        Order = 2048,
        Strict = 8192,
        Test = 16384,
        Timer = 32768,
        Server = 65536,
        FundamentalData = 262144,
        Hotlists = 1048576
    }
}
