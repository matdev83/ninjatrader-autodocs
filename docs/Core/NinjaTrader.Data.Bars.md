# Bars

Namespace: `NinjaTrader.Data`
Type: class

This documentation is generated from reflection scaffolding and may be incomplete.

## Properties
- `BarsProxyOnChart` (NinjaTrader.Data.Bars)
- `BarsPeriod` (NinjaTrader.Data.BarsPeriod)
- `BarsSeries` (NinjaTrader.Data.BarsSeries)
- `BarsSinceNewTradingDay` (int)
- `BarsType` (NinjaTrader.Data.BarsType)
- `Count` (int)
- `CurrentBar` (int)
- `DayCount` (int)
- `FromDate` (System.DateTime)
- `Instrument` (NinjaTrader.Cbi.Instrument)
- `IsDividendAdjusted` (bool)
- `IsFirstBarOfSession` (bool)
- `IsInReplayMode` (bool)
- `IsLastBarOfSession` (bool)
- `IsResetOnNewTradingDay` (bool)
- `IsRolloverAdjusted` (bool)
- `IsSplitAdjusted` (bool)
- `IsTickReplay` (bool)
- `LastBarTime` (System.DateTime)
- `LastPrice` (double)
- `PercentComplete` (double)
- `Item` (double)
- `TickCount` (int)
- `ToDate` (System.DateTime)
- `TotalTicks` (long)
- `TradingHours` (NinjaTrader.Data.TradingHours)

## Methods
- `GetBars(NinjaTrader.Cbi.Instrument instrument, NinjaTrader.Data.BarsPeriod barsPeriod, System.DateTime fromDateLocal, System.DateTime toDateLocal, NinjaTrader.Data.TradingHours tradingHours, bool isDividendAdjusted, bool isSplitAdjusted, bool isTickReplay, bool isResetOnNewTradingDay, LookupPolicies lookupPolicies, MergePolicy mergePolicy, bool isSubscribed, NinjaTrader.Core.IProgress progress, bool calculateRollovers, object state, System.Action<NinjaTrader.Data.Bars, ErrorCode, string, object> callback)` : void
- `GetBarsBack(NinjaTrader.Cbi.Instrument instrument, NinjaTrader.Data.BarsPeriod barsPeriod, int barsBack, System.DateTime toDateLocal, NinjaTrader.Data.TradingHours tradingHours, bool isDividendAdjusted, bool isSplitAdjusted, bool isTickReplay, bool isResetOnNewTradingDay, LookupPolicies lookupPolicies, MergePolicy mergePolicy, bool isSubscribed, NinjaTrader.Core.IProgress progress, object state, System.Action<NinjaTrader.Data.Bars, ErrorCode, string, object> callback)` : void
- `GetDayBar(int tradingDaysBack)` : NinjaTrader.Data.Bar
- `Save(void)` : void
- `SaveToFile(string path, char separator, NinjaTrader.Core.IProgress progress, bool showProgress)` : bool
- `Add(double open, double high, double low, double close, System.DateTime time, long volume, double bid, double ask)` : void
- `Add(double open, double high, double low, double close, System.DateTime time, long volume, double tickSize, bool isBar)` : void
- `Add(double open, double high, double low, double close, System.DateTime time, long volume, double tickSize, bool isBar, double bid, double ask)` : void
- `AddBar(double open, double high, double low, double close, System.DateTime time, long volume, double tickSizeIn, double bid, double ask)` : void
- `ClearCache(void)` : void
- `Dispose(void)` : void
- `GetAsk(int index)` : double
- `GetBar(System.DateTime time)` : int
- `GetBarTestString(int index)` : string
- `GetBarTestString(int index, bool ignoreIndex)` : string
- `GetBid(int index)` : double
- `GetClose(int index)` : double
- `GetHigh(int index)` : double
- `GetIndexByTime(void)` : int
- `GetSessionEndTime(int index)` : System.DateTime
- `GetLow(int index)` : double
- `GetNewBarsProxy(NinjaTrader.Data.Bars barsProxy)` : NinjaTrader.Data.Bars
- `GetOpen(int index)` : double
- `GetTime(int index)` : System.DateTime
- `GetValueAt(int barIndex)` : double
- `GetVolume(int index)` : long
- `IsEqualInstrumentBarsPeriod(NinjaTrader.Data.Bars barsRequested)` : bool
- `IsEqualBars(NinjaTrader.Data.Bars other)` : bool
- `IsFirstBarOfSessionByIndex(int index)` : bool
- `IsValidDataPoint(int barsAgo)` : bool
- `IsValidDataPointAt(int barIndex)` : bool
- `RemoveLastBar(void)` : void
- `ToChartString(void)` : string
- `ToString(void)` : string
- `AddTest(double open, double high, double low, double close, System.DateTime time, long volume, double tickSize, bool isBar)` : void
- `ClearBarsTestDictionary(void)` : void
