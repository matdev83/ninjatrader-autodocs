namespace NinjaTrader.Cbi
{
    public enum ScanConditionItemType : int
    {
        CandleStickPattern = 0,
        Exchanges = 1,
        FundamentalData = 2,
        Indicator = 3,
        LastPriceOfInstrument = 4,
        MarketData = 5,
        NetChange = 6,
        NetChangeMaxDown = 7,
        NetChangeMaxUp = 8,
        NewDailyHigh = 9,
        NewDailyLow = 10,
        NumericValue = 11
    }
}
