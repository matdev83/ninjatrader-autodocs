namespace NinjaTrader.FIX
{
    public enum MsgType : int
    {
        Undefined = 0,
        AccountDataReport = 1,
        AuthorizedAccountsReport = 2,
        BusinessRejectReason = 3,
        CollateralInquiryAck = 4,
        CollateralReport = 5,
        ExecutionReport = 6,
        Heartbeat = 7,
        Logon = 8,
        Logout = 9,
        MarketData = 10,
        OrderCancelReject = 11,
        OrderMassStatusRequestAck = 12,
        PositionReport = 13,
        Reject = 14,
        RequestForPositionsAck = 15,
        ResendRequest = 16,
        SequenceReset = 17,
        TestRequest = 18,
        TradingSessionStatus = 19
    }
}
