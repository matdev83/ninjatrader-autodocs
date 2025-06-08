# Position

Namespace: `NinjaTrader.Cbi`
Type: class

This documentation is generated from reflection scaffolding and may be incomplete.

## Properties
- `StatementDate` (System.DateTime)
- `UseFifo4AveragePrice` (bool)
- `Account` (NinjaTrader.Cbi.Account)
- `AveragePrice` (double)
- `FirstEntry` (NinjaTrader.Cbi.Execution)
- `Entries` (NinjaTrader.Cbi.Execution[])
- `Instrument` (NinjaTrader.Cbi.Instrument)
- `MarketPosition` (MarketPosition)
- `Quantity` (int)

## Methods
- `BreakEven(System.Collections.Generic.ICollection<NinjaTrader.Cbi.Order> orders)` : void
- `DbGet(NinjaTrader.Cbi.Account account)` : System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Position>
- `DbGet(NinjaTrader.Cbi.Account account, System.DateTime minDate, System.DateTime maxDate)` : System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Position>
- `ToString(void)` : string
- `AddExecution(NinjaTrader.Cbi.Execution execution, NinjaTrader.Cbi.SystemPerformance performance)` : void
- `Close(string signalName)` : System.Threading.Tasks.Task
- `Close(string signalName, string onBehalfOf)` : System.Threading.Tasks.Task
- `GetMarketPrice(void)` : double
- `GetUnrealizedProfitLoss(PerformanceUnit unit, double price)` : double
- `Reverse(TimeInForce tif, System.DateTime gtdDate)` : void
