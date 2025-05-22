namespace NinjaTrader.Cbi
{
    public enum ErrorCode : int
    {
        NoError = 0,
        LogOnFailed = 1,
        OrderRejected = 3,
        UnableToCancelOrder = 5,
        UnableToChangeOrder = 6,
        UnableToSubmitOrder = 7,
        UserAbort = 8,
        OrderRejectedByRisk = 9,
        LoginExpired = 10,
        Panic = 18
    }
}
