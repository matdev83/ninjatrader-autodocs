# BarsSeries

Namespace: `NinjaTrader.Data`
Type: class

This documentation is generated from reflection scaffolding and may be incomplete.

## Properties
- `IsInDownloadFromProvider` (bool)
- `BarsPeriod` (NinjaTrader.Data.BarsPeriod)
- `BarsType` (NinjaTrader.Data.BarsType)
- `Count` (int)
- `DayCount` (int)
- `EstimatedFutureBarTimeDiff` (int)
- `FirstTimeToFetch` (System.DateTime)
- `FromDate` (System.DateTime)
- `Id` (string)
- `Instrument` (NinjaTrader.Cbi.Instrument)
- `IsDisposed` (bool)
- `IsDividendAdjusted` (bool)
- `IsMarketDataBufferEnabled` (bool)
- `IsMarketDataSubscribed` (bool)
- `IsResetOnNewTradingDay` (bool)
- `IsRolloverAdjusted` (bool)
- `IsSplitAdjusted` (bool)
- `IsTickReplay` (bool)
- `LastBarTime` (System.DateTime)
- `LastPrice` (double)
- `OneTickOneVolume` (bool)
- `PercentComplete` (double)
- `LastTimeToFetch` (System.DateTime)
- `SyncRoot` (System.Threading.ReaderWriterLockSlim)
- `TickCount` (int)
- `TicksOnLastSecond` (int)
- `ToDate` (System.DateTime)
- `TotalTicks` (long)
- `TradingHours` (NinjaTrader.Data.TradingHours)

## Methods
- `CheckInstances(void)` : void
- `ClearCache(NinjaTrader.Cbi.Instrument instrument, System.DateTime firstData2Clear, bool clearReplayCache, BarsPeriodType? barsPeriodType)` : void
- `DeleteDbBars(NinjaTrader.Cbi.Instrument instrument, BarsPeriodType periodType, MarketDataType marketDataType, System.DateTime delFrom, System.DateTime delTo)` : void
- `DisposeBarsSeriesDictionary(void)` : void
- `DownloadFromProvider(System.Collections.ObjectModel.Collection<NinjaTrader.Data.Bars> barsRequested1, bool overwriteExistingData1, bool deleteDataAfter1, NinjaTrader.Core.IProgress progress1, NinjaTrader.Cbi.Connection newConnection1, bool showErrors1, bool isRescheduled, System.Action<bool> callback1)` : void
- `DownloadFromProviderReloadUI(System.Collections.ObjectModel.Collection<NinjaTrader.Data.Bars> barsRequested, NinjaTrader.Core.IProgress progress, System.Action downloadCallback)` : void
- `Load(void)` : System.DateTime
- `NeedsReloadOnConnect(NinjaTrader.Cbi.Connection newConnection)` : bool
- `Save(void)` : void
- `SaveToFile(string path, char separator, NinjaTrader.Core.IProgress progress, bool showProgress)` : bool
- `UnsubscribeInstruments(System.Collections.Generic.List<NinjaTrader.Cbi.Instrument> instruments)` : void
- `Add(NinjaTrader.Data.Bars bars, double open, double high, double low, double close, System.DateTime time, long volume, double tickSize, bool isBar)` : void
- `Add(NinjaTrader.Data.Bars bars, double open, double high, double low, double close, System.DateTime time, long volume, double tickSize, bool isBar, double bid, double ask)` : void
- `Clear(void)` : void
- `CountBarsSeriesInDictionary(void)` : int
- `Dispose(void)` : void
- `GetAsk(int index)` : double
- `GetBar(System.DateTime time)` : int
- `GetBid(int index)` : double
- `GetClose(int index)` : double
- `GetHigh(int index)` : double
- `GetSessionEndTime(int index)` : System.DateTime
- `GetIsFirstBarOfSession(int index)` : bool
- `GetLow(int index)` : double
- `GetOpen(int index)` : double
- `GetVolume(int index)` : long
- `GetTime(int index)` : System.DateTime
- `RemoveFromBegin(System.DateTime cutTime)` : void
- `RemoveFromEnd(System.DateTime cutTime)` : void
- `ToString(void)` : string
- `UpdateLocalDate2BarIndexCache(int minIdx)` : void
