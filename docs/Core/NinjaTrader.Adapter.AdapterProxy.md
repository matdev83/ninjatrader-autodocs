# AdapterProxy

Namespace: `NinjaTrader.Adapter`
Type: class

This documentation is generated from reflection scaffolding and may be incomplete.

## Properties
- `AssemblyName` (string)
- `Dispatcher` (System.Windows.Threading.Dispatcher)

## Methods
- `Cancel(NinjaTrader.Cbi.Order[] orders)` : void
- `Change(NinjaTrader.Cbi.Order[] orders)` : void
- `Connect(NinjaTrader.Cbi.IConnection connection)` : void
- `Disconnect(void)` : void
- `Dispose(void)` : void
- `QueryOptionChainAsync(NinjaTrader.Cbi.Instrument underlying)` : System.Threading.Tasks.Task<NinjaTrader.Adapter.InstrumentInfo[]>
- `RequestBars(NinjaTrader.Data.IBars bars, System.Action<NinjaTrader.Data.IBars, ErrorCode, string> callback, NinjaTrader.Core.IProgress progress)` : void
- `RequestHotlistNames(System.Action<System.String[], ErrorCode, string> callback)` : void
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
