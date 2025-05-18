namespace NinjaTrader.FIX
{
    public enum ExecType
    {
        New = 48,
        PartialFill = 49,
        Fill = 50,
        DoneForDay = 51,
        Canceled = 52,
        Replace = 53,
        PendingCancel = 54,
        Stopped = 55,
        Rejected = 56,
        Suspended = 57,
        PendingNew = 65,
        Calculated = 66,
        Expired = 67,
        Restated = 68,
        PendingReplace = 69,
        Trade = 70,
        TradeCorrect = 71,
        TradeCancel = 72,
        OrderStatus = 73
    }
}
