[Flags]
namespace NinjaTrader.Cbi
{
    public enum LogCategories
    {
        Ati = 1,
        Connection = 2,
        Default = 4,
        Execution = 8,
        NinjaScript = 16,
        Order = 32,
        Position = 64,
        Strategy = 128,
        Account = 65536,
        LicenseManagement = 262144,
        DB = 524288,
        System = 1048576,
        User = 2097152
    }
}
