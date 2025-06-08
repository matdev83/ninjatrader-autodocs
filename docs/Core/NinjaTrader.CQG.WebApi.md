# WebApi

Namespace: `NinjaTrader.CQG`
Type: class

This documentation is generated from reflection scaffolding and may be incomplete.

## Methods
- `Cancel(NinjaTrader.Cbi.Order[] orders)` : void
- `Change(NinjaTrader.Cbi.Order[] orders)` : void
- `Connect(NinjaTrader.Cbi.IConnection connection)` : void
- `Disconnect(void)` : void
- `Dispose(void)` : void
- `FromInstrument(NinjaTrader.Cbi.Instrument instrument)` : System.Threading.Tasks.Task<string>
- `QueryAllMasterInstrumentsAsync(NinjaTrader.Core.IProgress progress)` : System.Threading.Tasks.Task<NinjaTrader.Cbi.MasterInstrument[]>
- `QueryFuturesExpiriesAsync(NinjaTrader.Cbi.MetaDataRolloverInstrument[] rolloverInstruments, NinjaTrader.Core.IProgress progress)` : System.Threading.Tasks.Task
- `QueryPastExecutionsAsync(System.DateTime startDate, System.DateTime endDate, NinjaTrader.Cbi.TimePenalty penalty)` : System.Threading.Tasks.Task<System.Collections.Generic.List<NinjaTrader.Cbi.Execution>>
- `QueryPastOrdersAsync(System.DateTime startDate, System.DateTime endDate, bool retry, NinjaTrader.Cbi.TimePenalty penalty)` : System.Threading.Tasks.Task<System.Collections.Generic.List<NinjaTrader.Cbi.Order>>
- `QueryTradingHoursHolidaysAsync(NinjaTrader.Data.TradingHours[] tradingHours, NinjaTrader.Core.IProgress progress)` : System.Threading.Tasks.Task
- `QueryOptionChainAsync(NinjaTrader.Cbi.Instrument underlying)` : System.Threading.Tasks.Task<NinjaTrader.Adapter.InstrumentInfo[]>
- `RequestBars(NinjaTrader.Data.IBars bars, System.Action<NinjaTrader.Data.IBars, ErrorCode, string> callback, NinjaTrader.Core.IProgress progress)` : void
- `ResolveInstrument(NinjaTrader.Cbi.Instrument instrument, System.Action<NinjaTrader.Cbi.Instrument, ErrorCode, string> callback)` : void
- `Submit(NinjaTrader.Cbi.Order[] orders)` : void
- `SubscribeMarketData(NinjaTrader.Cbi.Instrument instrument, System.Action<MarketDataType, double, long, System.DateTime, long> callback)` : void
- `SubscribeMarketDepth(NinjaTrader.Cbi.Instrument instrument, System.Action<int, string, Operation, MarketDataType, double, long, System.DateTime> callback)` : void
- `ToDate(long milliSeconds)` : System.DateTime
- `ToDateTime(Google.Protobuf.Timestamp timestamp)` : System.DateTime
- `ToLong(System.DateTime date)` : long
- `ToInstrument(NinjaTrader.CQG.ProtoBuf.ContractMetadata contractMetadata)` : System.Threading.Tasks.Task<NinjaTrader.Cbi.Instrument>
- `ToTimestamp(System.DateTime utcTime)` : Google.Protobuf.Timestamp
- `UnsubscribeMarketData(NinjaTrader.Cbi.Instrument instrument)` : void
- `UnsubscribeMarketDepth(NinjaTrader.Cbi.Instrument instrument)` : void
- `SubscribeFundamentalData(NinjaTrader.Cbi.Instrument instrument, System.Action<FundamentalDataType, object> callback)` : void
- `UnsubscribeFundamentalData(NinjaTrader.Cbi.Instrument instrument)` : void
- `SubscribeAccount(NinjaTrader.Cbi.Account account)` : void
- `UnsubscribeAccount(NinjaTrader.Cbi.Account account)` : void
- `RequestHotlistNames(System.Action<System.String[], ErrorCode, string> callback)` : void
- `SubscribeHotlist(NinjaTrader.Data.Hotlist hotlist, System.Action callback)` : void
- `UnsubscribeHotlist(NinjaTrader.Data.Hotlist hotlist)` : void
- `SubscribeNews(void)` : void
- `UnsubscribeNews(void)` : void
