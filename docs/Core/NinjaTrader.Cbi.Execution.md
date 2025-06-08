# Execution

Namespace: `NinjaTrader.Cbi`
Type: class

This documentation is generated from reflection scaffolding and may be incomplete.

## Properties
- `BarIndex` (int)
- `BarsInProgress` (int)
- `Id` (long)
- `IsEntry` (bool)
- `IsEntryStrategy` (bool)
- `IsExit` (bool)
- `IsExitStrategy` (bool)
- `IsInitialEntry` (bool)
- `IsLastExit` (bool)
- `IsSod` (bool)
- `ServerName` (string)
- `Order` (NinjaTrader.Cbi.Order)
- `Position` (int)
- `PositionStrategy` (int)
- `StatementDate` (System.DateTime)
- `Account` (NinjaTrader.Cbi.Account)
- `Commission` (double)
- `Exchange` (Exchange)
- `ExecutionId` (string)
- `Fee` (double)
- `Instrument` (NinjaTrader.Cbi.Instrument)
- `LotSize` (double)
- `MarketPosition` (MarketPosition)
- `MaxPrice` (double)
- `MinPrice` (double)
- `Name` (string)
- `OrderId` (string)
- `Price` (double)
- `Quantity` (int)
- `Rate` (double)
- `Slippage` (double)
- `Time` (System.DateTime)

## Methods
- `DbAdd(void)` : void
- `DbGet(NinjaTrader.Cbi.Account account, System.DateTime minTime, System.DateTime maxTime)` : System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Execution>
- `DbGet(NinjaTrader.Cbi.Account account, NinjaTrader.Cbi.Instrument instrument, System.DateTime minTime, System.DateTime maxTime)` : System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Execution>
- `DbRemove(void)` : void
- `DbRemoveAll(void)` : void
- `DbUpdateExecutions(NinjaTrader.Cbi.Account account, NinjaTrader.Cbi.Instrument instrument, System.DateTime time)` : void
- `Init(void)` : void
- `ToString(void)` : string
