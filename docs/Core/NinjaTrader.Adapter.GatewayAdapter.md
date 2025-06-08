# GatewayAdapter

Namespace: `NinjaTrader.Adapter`
Type: class

This documentation is generated from reflection scaffolding and may be incomplete.

## Properties
- `Adapters` (System.Collections.Generic.List<NinjaTrader.Adapter.GatewayAdapter>)
- `Connection` (NinjaTrader.Cbi.IConnection)

## Methods
- `Cancel(NinjaTrader.Cbi.Order[] orders)` : void
- `Change(NinjaTrader.Cbi.Order[] orders)` : void
- `Connect(NinjaTrader.Cbi.IConnection connection)` : void
- `Disconnect(void)` : void
- `OnAccountItemUpdate(object sender, NinjaTrader.Cbi.AccountItemEventArgs e)` : void
- `OnAccountRoll(object sender, NinjaTrader.Cbi.AccountRollEventArgs e)` : void
- `OnExecutionUpdate(object sender, NinjaTrader.Cbi.ExecutionEventArgs e)` : void
- `OnOrderUpdate(object sender, NinjaTrader.Cbi.OrderEventArgs e)` : void
- `Submit(NinjaTrader.Cbi.Order[] orders)` : void
- `SubscribeAccount(NinjaTrader.Cbi.Account account)` : void
- `SubscribeFundamentalData(NinjaTrader.Cbi.Instrument instrument, System.Action<FundamentalDataType, object> callback)` : void
- `SubscribeMarketData(NinjaTrader.Cbi.Instrument instrument, System.Action<MarketDataType, double, long, System.DateTime, long> callback)` : void
- `SubscribeMarketDepth(NinjaTrader.Cbi.Instrument instrument, System.Action<int, string, Operation, MarketDataType, double, long, System.DateTime> callback)` : void
- `SubscribeNews(void)` : void
- `UnsubscribeAccount(NinjaTrader.Cbi.Account account)` : void
- `UnsubscribeFundamentalData(NinjaTrader.Cbi.Instrument instrument)` : void
- `UnsubscribeMarketData(NinjaTrader.Cbi.Instrument instrument)` : void
- `UnsubscribeMarketDepth(NinjaTrader.Cbi.Instrument instrument)` : void
- `UnsubscribeNews(void)` : void
- `RequestBars(NinjaTrader.Data.IBars bars, System.Action<NinjaTrader.Data.IBars, ErrorCode, string> callback, NinjaTrader.Core.IProgress progress)` : void
- `RequestHotlistNames(System.Action<System.String[], ErrorCode, string> callback)` : void
- `ResolveInstrument(NinjaTrader.Cbi.Instrument instrument, System.Action<NinjaTrader.Cbi.Instrument, ErrorCode, string> callback)` : void
- `SubscribeHotlist(NinjaTrader.Data.Hotlist hotlist, System.Action callback)` : void
- `UnsubscribeHotlist(NinjaTrader.Data.Hotlist hotlist)` : void
