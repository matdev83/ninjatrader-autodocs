[Flags]
namespace NinjaTrader.Cbi
{
    public enum TraceLevels
    {
        All = 268435455,
        None = 0,
        Bars = 1,
        Connect = 4,
        Database = 8,
        Gui = 16,
        Indicator = 32,
        ResolveInstrument = 64,
        MarketData = 128,
        MarketDepth = 256,
        Native = 512,
        News = 1024,
        Order = 2048,
        Strategy = 4096,
        Strict = 8192,
        Test = 16384,
        Timer = 32768,
        Server = 65536,
        Alerts = 131072,
        FundamentalData = 262144
    }
}
