# Connection

Namespace: `NinjaTrader.Cbi`
Type: class

This documentation is generated from reflection scaffolding and may be incomplete.

## Properties
- `Dispatcher` (System.Windows.Threading.Dispatcher)
- `FundamentalDataTypes` (FundamentalDataType[])
- `NewsProviders` (NewsProvider[])
- `Now` (System.DateTime)
- `PlaybackConnection` (NinjaTrader.Cbi.Connection)
- `UseFifo4AveragePrice` (bool)
- `UserEntitlement` (NinjaTrader.Cbi.IUserEntitlement)
- `AccountItems` (AccountItem[])
- `Accounts` (System.Collections.Generic.IList<NinjaTrader.Cbi.Account>)
- `Adapter` (NinjaTrader.Adapter.IAdapter)
- `ClientConnection` (NinjaTrader.Cbi.Connection)
- `Connections` (System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Connection>)
- `Currencies` (Currency[])
- `Features` (Feature[])
- `InstrumentTypes` (InstrumentType[])
- `MarketDataTypes` (MarketDataType[])
- `Options` (NinjaTrader.Cbi.ConnectOptions)
- `OrderTypes` (OrderType[])
- `PriceStatus` (ConnectionStatus)
- `Status` (ConnectionStatus)
- `TimeInForces` (TimeInForce[])
- `Trace` (NinjaTrader.Core.Trace)

## Methods
- `CancelAllOrders(void)` : void
- `Connect(NinjaTrader.Cbi.ConnectOptions options)` : NinjaTrader.Cbi.Connection
- `ConnectionStatusCallback(ConnectionStatus status, ConnectionStatus priceStatus, ErrorCode errorCode, string nativeError)` : void
- `CreateAccount(string accountName, string displayName, string fcm, Currency denomination, int forexLotSize, System.Action<NinjaTrader.Cbi.Account, ErrorCode, string, object> callback, object state)` : void
- `CreateOrder(NinjaTrader.Cbi.Account account, NinjaTrader.Cbi.Instrument instrument, OrderAction action, OrderType orderType, OrderEntry orderEntry, TimeInForce timeInForce, int quantity, double limitPrice, double stopPrice, int filled, double averageFillPrice, OrderState initialOrderState, string initialOrderId, System.DateTime time, string oco, string name, System.DateTime gtd, string comment, System.DateTime statementDate, System.Action<NinjaTrader.Cbi.Order, ErrorCode, string, object> callback, object state)` : void
- `Dispose(void)` : void
- `NewsCallback(string id, NewsProvider newsProvider, System.DateTime time, string headline, string newsText, System.Uri url)` : void
- `RecaptchaCallback(System.Action<bool, string> callback)` : void
- `ResolveInstrument(NinjaTrader.Cbi.Instrument instrument, System.Action<NinjaTrader.Cbi.Instrument, ErrorCode, string> callback)` : void
- `ResolveSymbol(string symbol, InstrumentType instrumentType, Exchange exchange, System.DateTime expiry, double strikePrice, OptionRight right, bool create, System.Action<NinjaTrader.Cbi.Instrument, ErrorCode, string, object> callback, object state)` : void
- `TimerCallback(System.DateTime localTime)` : void
- `AccountItemUpdateCallback(NinjaTrader.Cbi.Account account, AccountItem accountItem, Currency currency, double value, System.DateTime time)` : void
- `CreateVolatileInstrument(NinjaTrader.Adapter.InstrumentInfo instrumentInfo)` : void
- `DelayedDataCallback(NinjaTrader.Cbi.Instrument instrument)` : void
- `Disconnect(void)` : void
- `ExecutionUpdateCallback(NinjaTrader.Cbi.Account account, NinjaTrader.Cbi.Instrument instrument, string executionId, Exchange exchange, System.DateTime time, MarketPosition marketPosition, string orderId, int quantity, double price, double commission, double fee, bool sod, System.DateTime statementDate, Operation operation)` : void
- `LogCallback(System.Type resourceType, string name, System.Object[] args, LogLevel logLevel, LogCategories logCategory, NinjaTrader.Cbi.Account account)` : void
- `NotificationCallback(NinjaTrader.Cbi.Account account, long id, string text, System.DateTime timestamp, System.DateTime completed, bool emailSent, bool showAsPopup)` : void
- `OrderUpdateCallback(NinjaTrader.Cbi.Account account, NinjaTrader.Cbi.Order order, string orderId, double limitPrice, double stopPrice, int quantity, double averageFillPrice, int filled, OrderState orderState, System.DateTime time, ErrorCode errorCode, string comment, System.DateTime statementDate)` : void
- `PositionUpdateCallback(NinjaTrader.Cbi.Account account, NinjaTrader.Cbi.Instrument instrument, MarketPosition marketPosition, int quantity, double averagePrice, Operation operation)` : void
- `QueryOptionChainAsync(NinjaTrader.Cbi.Instrument underlying)` : System.Threading.Tasks.Task<NinjaTrader.Cbi.Instrument[]>
- `RaiseDelayedDataEvent(NinjaTrader.Cbi.DelayedDataArgs e)` : void
- `RaiseServerAtmStrategyUpdate(NinjaTrader.Cbi.ServerAtmStrategyUpdateArgs e)` : void
- `ServerAtmStrategyCallback(NinjaTrader.Cbi.Account account, NinjaTrader.Cbi.Instrument instrument, long strategyId, string name, ServerStrategyStatus status, string orderId, string errorMessage, System.DateTime time, Operation operation)` : void
- `TraceCallback(string message)` : void
