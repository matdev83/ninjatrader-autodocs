namespace NinjaTrader.Cbi.TradingServices
{
    public enum ExecType
    {
        Canceled = 0,
        Completed = 1,
        DoneForDay = 2,
        Expired = 3,
        New = 4,
        OrderStatus = 5,
        PendingCancel = 6,
        PendingNew = 7,
        PendingReplace = 8,
        Rejected = 9,
        Replaced = 10,
        Stopped = 11,
        Suspended = 12,
        Trade = 13,
        TradeCancel = 14,
        TradeCorrect = 15
    }
}
