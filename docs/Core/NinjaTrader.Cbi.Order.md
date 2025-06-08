# Order

Namespace: `NinjaTrader.Cbi`
Type: class

This documentation is generated from reflection scaffolding and may be incomplete.

## Properties
- `ClientId` (long)
- `Stopwatch` (System.Diagnostics.Stopwatch)
- `BacktestPassNumber` (long)
- `FromEntrySignal` (string)
- `HasOverfill` (bool)
- `IsLiveUntilCancelled` (bool)
- `IsTrackingConfigured` (bool)
- `OnBehalfOf` (string)
- `OrderEntry` (OrderEntry)
- `StatementDate` (System.DateTime)
- `IsTrackingEnabled` (bool)
- `IsBacktestOrder` (bool)
- `TrackingIndicator` (NinjaTrader.NinjaScript.IndicatorBase)
- `UserData` (System.Xml.Linq.XDocument)
- `Account` (NinjaTrader.Cbi.Account)
- `AverageFillPrice` (double)
- `CustomOrder` (NinjaTrader.Cbi.CustomOrder)
- `Filled` (int)
- `Gtd` (System.DateTime)
- `Id` (long)
- `Instrument` (NinjaTrader.Cbi.Instrument)
- `IsLimit` (bool)
- `IsMarket` (bool)
- `IsMarketIfTouched` (bool)
- `IsSimulatedStop` (bool)
- `IsLong` (bool)
- `IsShort` (bool)
- `IsStopMarket` (bool)
- `IsStopLimit` (bool)
- `LimitPrice` (double)
- `LimitPriceChanged` (double)
- `Name` (string)
- `Oco` (string)
- `OrderAction` (OrderAction)
- `OrderId` (string)
- `OrderState` (OrderState)
- `OrderType` (OrderType)
- `OrderTypeString` (string)
- `OrderUpdates` (System.Collections.Generic.IList<NinjaTrader.Cbi.OrderEventArgs>)
- `Quantity` (int)
- `QuantityChanged` (int)
- `StopPrice` (double)
- `StopPriceChanged` (double)
- `Time` (System.DateTime)
- `TimeInForce` (TimeInForce)

## Methods
- `ChangeQuantity(System.Collections.Generic.ICollection<NinjaTrader.Cbi.Order> orders, int newQuantity, QuantityModificationForStocks quantityModification, string onBehalfOf)` : void
- `DbGet(NinjaTrader.Cbi.Account account, System.DateTime minTime, System.DateTime maxTime)` : System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Order>
- `DbGet(string orderId)` : System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Order>
- `DbRemoveAll(void)` : void
- `GetOutstandingQuantity(System.Collections.Generic.ICollection<NinjaTrader.Cbi.Order> orders)` : int
- `Init(void)` : void
- `ToString(void)` : string
- `GetOwnerStrategy(void)` : NinjaTrader.NinjaScript.StrategyBase
- `GetOwnerServerStrategy(void)` : NinjaTrader.ServerAtm.ServerAtmStrategy
- `IsTerminalState(OrderState orderState)` : bool
- `Rewind(NinjaTrader.Cbi.IConnection connection, string message)` : void
