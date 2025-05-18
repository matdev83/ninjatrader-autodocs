namespace NinjaTrader.Cbi
{
    public enum Feature
    {
        AtmStrategies = 0,
        Bars1Minute = 1,
        BarsDaily = 2,
        BarsTick = 3,
        BarsTickIntraday = 4,
        ProvidesMarketDataSnapshot = 5,
        Dividends = 6,
        ExtendedExecutionsLookback = 7,
        ForceGtcForexOrders = 8,
        FundamentalData = 9,
        Hotlists = 11,
        MarketData = 12,
        MarketDepth = 13,
        MultipleConnectionsNotSupported = 14,
        NativeGtdOrders = 15,
        NativeOcoOrders = 16,
        News = 17,
        NoIndependentOcoOrders = 18,
        NoStableOrderId = 19,
        Order = 20,
        OrderChange = 21,
        OrdersCanBePlacedExternal = 22,
        Quotes1Minute = 23,
        QuotesDaily = 24,
        QuotesTick = 25,
        RequiresExactOrderAction = 26,
        ResolveInstrument = 27,
        CustomOrders = 28,
        StockOrdersByPosition = 29,
        Splits = 30,
        QueryOptionChain = 31,
        OcoNeedsManualCancellation = 32
    }
}
