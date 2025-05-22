namespace NinjaTrader.Data
{
    public enum MarketDataScanType : int
    {
        AskPrice = 0,
        AskVolume = 1,
        BidPrice = 2,
        BidVolume = 3,
        LastPrice = 4,
        LastVolume = 5,
        DailyHighPrice = 6,
        DailyLowPrice = 7,
        DailyVolume = 8,
        LastClosePrice = 9,
        OpeningPrice = 10,
        OpenInterest = 11,
        SettlementPrice = 12
    }
}
