# Account

Namespace: `NinjaTrader.Cbi`
Type: class

This documentation is generated from reflection scaffolding and may be incomplete.

## Properties
- `LastTransactionsSum` (double)
- `SyncGW` (object)
- `Commission` (NinjaTrader.Cbi.Commission)
- `ConnectionStatus` (ConnectionStatus)
- `DailyLossLimit` (double)
- `FcmDate` (System.DateTime)
- `Fee` (NinjaTrader.Cbi.Fee)
- `LookbackDaysExecutions` (int)
- `LookbackDaysOrders` (int)
- `MarginMultiplier` (double)
- `MaxOrderSize` (int)
- `MaxPositionSize` (int)
- `MinimumCashValue` (double)
- `PrimaryUser` (NinjaTrader.Cbi.User)
- `Provider` (Provider)
- `Risk` (NinjaTrader.Cbi.Risk)
- `Transactions` (System.Collections.Generic.IList<NinjaTrader.Cbi.Transaction>)
- `UsersSerializable` (string)
- `AccountStatus` (AccountStatus)
- `All` (System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Account>)
- `Connection` (NinjaTrader.Cbi.Connection)
- `Denomination` (Currency)
- `DisplayName` (string)
- `ExecutionPositions` (NinjaTrader.Cbi.ExecutionPositions)
- `Executions` (System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Execution>)
- `Fcm` (string)
- `ForexLotSize` (int)
- `Id` (long)
- `IsAutoLiquidationEnabled` (bool)
- `LiquidationState` (LiquidationState)
- `Name` (string)
- `Orders` (System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Order>)
- `Positions` (System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Position>)
- `SimulatorInitialCash` (double)
- `SimulatorDelayExchange` (int)
- `SimulatorDelayInternet` (int)
- `ServerStrategies` (System.Collections.ObjectModel.Collection<NinjaTrader.ServerAtm.ServerAtmStrategy>)
- `Strategies` (System.Collections.ObjectModel.Collection<NinjaTrader.NinjaScript.StrategyBase>)

## Methods
- `RaiseAccountRoll(NinjaTrader.Cbi.AccountRollEventArgs e)` : void
- `AccountItemUpdateCallback(AccountItem itemType, Currency currency, double value, System.DateTime time)` : void
- `CancelAllOrders(NinjaTrader.Cbi.Instrument instrument)` : void
- `CreateOrder(NinjaTrader.Cbi.Instrument instrument, OrderAction action, OrderType orderType, TimeInForce timeInForce, int quantity, double limitPrice, double stopPrice, string oco, string name, NinjaTrader.Cbi.CustomOrder customOrder)` : NinjaTrader.Cbi.Order
- `CreateOrder(NinjaTrader.Cbi.Instrument instrument, OrderAction action, OrderType orderType, OrderEntry orderEntry, TimeInForce timeInForce, int quantity, double limitPrice, double stopPrice, string oco, string name, System.DateTime gtd, NinjaTrader.Cbi.CustomOrder customOrder)` : NinjaTrader.Cbi.Order
- `CreateOrder(NinjaTrader.Cbi.Instrument instrument, OrderAction action, OrderType orderType, OrderEntry orderEntry, TimeInForce timeInForce, int quantity, double limitPrice, double stopPrice, int filled, double averageFillPrice, OrderState initialOrderState, string initialOrderId, System.DateTime time, string oco, string name, System.DateTime gtd, string comment, System.DateTime statementDate, NinjaTrader.Cbi.CustomOrder customOrder, bool raiseOrderUpdate, long id)` : NinjaTrader.Cbi.Order
- `DbAdd(bool persist)` : void
- `DbGet(long id)` : NinjaTrader.Cbi.Account
- `DbGet(string name)` : NinjaTrader.Cbi.Account
- `DbReload(void)` : void
- `DbRemove(void)` : void
- `DbUpdate(void)` : void
- `ExecutionUpdateCallback(NinjaTrader.Cbi.Instrument instrument, string executionId, Exchange exchange, System.DateTime time, MarketPosition marketPosition, string orderId, int quantity, double price, double commission, double fee, bool isSod, System.DateTime statementDate, Operation operation)` : void
- `Flatten(System.Collections.Generic.ICollection<NinjaTrader.Cbi.Instrument> instruments)` : void
- `FlattenEverything(void)` : void
- `GetAccountItem(AccountItem itemType, Currency currency)` : NinjaTrader.Cbi.AccountItemEventArgs
- `GetExecution(long id)` : NinjaTrader.Cbi.Execution
- `GetPosition(long instrumentId)` : NinjaTrader.Cbi.Position
- `IsOrderTypeSupported(OrderType orderType)` : bool
- `OnConnectionStatus(ConnectionStatus status)` : void
- `OrderUpdateCallback(NinjaTrader.Cbi.Order order, string orderId, double limitPrice, double stopPrice, int quantity, double averageFillPrice, int filled, OrderState orderState, System.DateTime time, ErrorCode error, string comment, System.DateTime statementDate)` : void
- `QueueChange(NinjaTrader.Cbi.Order order, OrderState latestOrderState)` : void
- `RaiseAccountStatusUpdate(NinjaTrader.Cbi.AccountStatusEventArgs e)` : void
- `ResetSimulationAccount(bool clearTradeData)` : void
- `Restore(void)` : void
- `Roll(System.DateTime fcmDate, bool persist)` : void
- `SnapShotPersist(bool updateVersion)` : void
- `UpdateCashValue(bool reset)` : void
- `Cancel(System.Collections.Generic.IEnumerable<NinjaTrader.Cbi.Order> orders)` : void
- `CancelOrdersByOcoID(System.Collections.Generic.IEnumerable<NinjaTrader.Cbi.Order> orders, string traceText)` : void
- `Change(System.Collections.Generic.IEnumerable<NinjaTrader.Cbi.Order> orders)` : void
- `DbGet(string name, string fcm, bool forceDbQuery)` : NinjaTrader.Cbi.Account
- `FindOrderById(System.Collections.Generic.IList<NinjaTrader.Cbi.Order> orders, string orderId)` : NinjaTrader.Cbi.Order
- `Get(AccountItem itemType, Currency currency)` : double
- `GetOrder(long id)` : NinjaTrader.Cbi.Order
- `PositionUpdateCallback(NinjaTrader.Cbi.Instrument instrument, MarketPosition marketPosition, int quantity, double averagePrice, Operation operation)` : void
- `RaiseAccountLiquidationChanged(NinjaTrader.Cbi.AccountLiquidationEventArgs e)` : void
- `RaiseAccountItemUpdate(NinjaTrader.Cbi.AccountItemEventArgs e)` : void
- `RaiseAccountItemUpdateCallbacks(void)` : void
- `RaiseExecutionUpdate(NinjaTrader.Cbi.ExecutionEventArgs e)` : void
- `RaisePositionUpdate(NinjaTrader.Cbi.PositionEventArgs e)` : void
- `RaiseOrderUpdate(NinjaTrader.Cbi.OrderEventArgs e)` : void
- `Submit(System.Collections.Generic.IEnumerable<NinjaTrader.Cbi.Order> orders)` : void
- `ToString(void)` : string
- `UpdateAccountItems(System.DateTime now, bool force)` : void
