namespace NinjaTrader.NinjaScript
{
    public enum RealtimeErrorHandling : int
    {
        IgnoreAllErrors = 0,
        StopCancelClose = 1,
        StopCancelCloseIgnoreRejects = 2
    }
}
