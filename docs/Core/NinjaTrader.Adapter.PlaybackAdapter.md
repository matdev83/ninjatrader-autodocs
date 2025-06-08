# PlaybackAdapter

Namespace: `NinjaTrader.Adapter`
Type: class

This documentation is generated from reflection scaffolding and may be incomplete.

## Properties
- `FromAvailableDataEst` (System.DateTime)
- `FromLocal` (System.DateTime)
- `IsSourceHistoricalData` (bool)
- `NowEst` (System.DateTime)
- `NowLocal` (System.DateTime)
- `PlaybackFromMode` (PlaybackFromMode)
- `SaveFromEstHistorical` (System.DateTime)
- `SaveFromEstMarketReplay` (System.DateTime)
- `SaveToEstHistorical` (System.DateTime)
- `SaveToEstMarketReplay` (System.DateTime)
- `ToAvailableDataEst` (System.DateTime)
- `FromEst` (System.DateTime)
- `IsAvailable` (bool)
- `PlaybackSpeed` (int)
- `ToEst` (System.DateTime)

## Methods
- `Connect(NinjaTrader.Cbi.IConnection connection)` : void
- `Disconnect(void)` : void
- `GetReplayMinMaxDates(string replayFile, System.DateTime& minDate, System.DateTime& maxDate)` : void
- `RecalculateDaylightSavings(void)` : void
- `ReloadAvailableData(bool isConnecting)` : void
- `Reset(System.DateTime targetTimeEst, System.Action<bool> callback)` : void
- `ResolveInstrument(NinjaTrader.Cbi.Instrument instrument, System.Action<NinjaTrader.Cbi.Instrument, ErrorCode, string> callback)` : void
- `SubscribeMarketData(NinjaTrader.Cbi.Instrument instrument, System.Action<MarketDataType, double, long, System.DateTime, long> callback)` : void
- `SubscribeMarketDepth(NinjaTrader.Cbi.Instrument instrument, System.Action<int, string, Operation, MarketDataType, double, long, System.DateTime> callback)` : void
- `SyncBars(NinjaTrader.Data.Bars bars, object state)` : void
- `UnsubscribeMarketData(NinjaTrader.Cbi.Instrument instrument)` : void
- `UnsubscribeMarketDepth(NinjaTrader.Cbi.Instrument instrument)` : void
- `RequestBars(NinjaTrader.Data.IBars bars, System.Action<NinjaTrader.Data.IBars, ErrorCode, string> callback, NinjaTrader.Core.IProgress progress)` : void
- `RequestHotlistNames(System.Action<System.String[], ErrorCode, string> callback)` : void
- `SubscribeAccount(NinjaTrader.Cbi.Account account)` : void
- `UnsubscribeAccount(NinjaTrader.Cbi.Account account)` : void
- `SubscribeHotlist(NinjaTrader.Data.Hotlist hotlist, System.Action callback)` : void
- `UnsubscribeHotlist(NinjaTrader.Data.Hotlist hotlist)` : void
- `SubscribeFundamentalData(NinjaTrader.Cbi.Instrument instrument, System.Action<FundamentalDataType, object> callback)` : void
- `UnsubscribeFundamentalData(NinjaTrader.Cbi.Instrument instrument)` : void
- `SubscribeNews(void)` : void
- `UnsubscribeNews(void)` : void
- `Cancel(NinjaTrader.Cbi.Order[] orders)` : void
- `Change(NinjaTrader.Cbi.Order[] orders)` : void
- `Submit(NinjaTrader.Cbi.Order[] orders)` : void
