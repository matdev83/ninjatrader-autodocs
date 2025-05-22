namespace NinjaTrader.Cbi.TradingServices
{
    public enum RejectReason : int
    {
        Default = 0,
        AccountClosed = 1,
        AdvancedTrailingStopUnsupported = 2,
        AnotherCommandPending = 3,
        BackMonthProhibited = 4,
        ExecutionProviderNotConfigured = 5,
        ExecutionProviderUnavailable = 6,
        InvalidContract = 7,
        InvalidPrice = 8,
        LiquidationOnly = 9,
        LiquidationOnlyBeforeExpiration = 10,
        MaxOrderQtyIsNotSpecified = 11,
        MaxOrderQtyLimitReached = 12,
        MaxPosLimitMisconfigured = 13,
        MaxPosLimitReached = 14,
        MaxTotalPosLimitReached = 15,
        MultipleAccountPlanRequired = 16,
        NoQuote = 17,
        NotEnoughLiquidity = 18,
        OtherExecutionRelated = 19,
        ParentRejected = 20,
        RiskCheckTimeout = 21,
        SessionClosed = 22,
        Success = 23,
        TooLate = 24,
        TradingLocked = 25,
        TrailingStopNonOrderQtyModify = 26,
        Unauthorized = 27,
        UnknownReason = 28,
        Unsupported = 29
    }
}
