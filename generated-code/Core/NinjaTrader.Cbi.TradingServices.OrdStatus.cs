namespace NinjaTrader.Cbi.TradingServices
{
    public enum OrdStatus : int
    {
        Canceled = 0,
        Completed = 1,
        Expired = 2,
        Filled = 3,
        PendingCancel = 4,
        PendingNew = 5,
        PendingReplace = 6,
        Rejected = 7,
        Suspended = 8,
        Unknown = 9,
        Working = 10
    }
}
