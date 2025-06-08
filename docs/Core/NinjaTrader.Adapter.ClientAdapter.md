# ClientAdapter

Namespace: `NinjaTrader.Adapter`
Type: class

This documentation is generated from reflection scaffolding and may be incomplete.

## Properties
- `ApisBP` (System.Collections.Generic.List<NinjaTrader.Server.Api>)
- `Options` (NinjaTrader.Cbi.NTConnectOptions)

## Methods
- `Cancel(NinjaTrader.Cbi.Order[] orders)` : void
- `Change(NinjaTrader.Cbi.Order[] orders)` : void
- `Connect(NinjaTrader.Cbi.IConnection connection)` : void
- `Disconnect(void)` : void
- `RequestHotlistNames(System.Action<System.String[], ErrorCode, string> callback)` : void
- `RequestMarketReplay(NinjaTrader.Cbi.Instrument instrument, System.DateTime dateEst, System.Action<ErrorCode, string, object> callback, NinjaTrader.Core.IProgress progress, object state)` : void
- `ResolveInstrument(NinjaTrader.Cbi.Instrument instrument, System.Action<NinjaTrader.Cbi.Instrument, ErrorCode, string> callback)` : void
- `Submit(NinjaTrader.Cbi.Order[] orders)` : void
- `SubscribeAccount(NinjaTrader.Cbi.Account account)` : void
- `SubscribeFundamentalData(NinjaTrader.Cbi.Instrument instrument, System.Action<FundamentalDataType, object> callback)` : void
- `SubscribeHotlist(NinjaTrader.Data.Hotlist hotlist, System.Action callback)` : void
- `SubscribeMarketData(NinjaTrader.Cbi.Instrument instrument, System.Action<MarketDataType, double, long, System.DateTime, long> callback)` : void
- `SubscribeMarketDepth(NinjaTrader.Cbi.Instrument instrument, System.Action<int, string, Operation, MarketDataType, double, long, System.DateTime> callback)` : void
- `SubscribeNews(void)` : void
- `UnsubscribeAccount(NinjaTrader.Cbi.Account account)` : void
- `UnsubscribeFundamentalData(NinjaTrader.Cbi.Instrument instrument)` : void
- `UnsubscribeHotlist(NinjaTrader.Data.Hotlist hotlist)` : void
- `UnsubscribeMarketData(NinjaTrader.Cbi.Instrument instrument)` : void
- `UnsubscribeMarketDepth(NinjaTrader.Cbi.Instrument instrument)` : void
- `UnsubscribeNews(void)` : void
- `Dispose(void)` : void
- `QueryEntities(ApiCommand entityType, string queryProperty, string queryValue, bool? isEnabled)` : System.Threading.Tasks.Task<System.Xml.Linq.XDocument>
- `QueryReport(ReportCommand reportCommand, System.Xml.Linq.XDocument criteria)` : System.Threading.Tasks.Task<System.Xml.Linq.XDocument>
- `RequestBars(NinjaTrader.Data.IBars bars, System.Action<NinjaTrader.Data.IBars, ErrorCode, string> callback, NinjaTrader.Core.IProgress progress)` : void
