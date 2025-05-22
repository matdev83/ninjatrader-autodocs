namespace NinjaTrader.Server
{
    public enum TSStopOrderHandling : int
    {
        SubmitAsIs = 0,
        Convert2StopLimit = 1,
        SubmitAsSimStop = 2
    }
}
