# ServerAtmStrategy

Namespace: `NinjaTrader.ServerAtm`
Type: class

This documentation is generated from reflection scaffolding and may be incomplete.

## Properties
- `Account` (NinjaTrader.Cbi.Account)
- `AtmSelector` (string)
- `Brackets` (NinjaTrader.ServerAtm.ServerBracket[])
- `CalculationMode` (ServerCalculationMode)
- `Enabled` (bool)
- `EntryQuantity` (int)
- `Instrument` (NinjaTrader.Cbi.Instrument)
- `MasterInstrument` (NinjaTrader.Cbi.MasterInstrument)
- `DisplayNameExtended` (string)
- `DisplayName` (string)
- `OrderIds` (System.Collections.Generic.HashSet<string>)
- `Orders` (System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Order>)
- `State` (State)
- `StrategyId` (long)
- `Template` (string)
- `Units` (string)

## Methods
- `Clone(void)` : object
- `CopyTo(NinjaTrader.ServerAtm.ServerAtmStrategy other)` : void
- `IsEqual(NinjaTrader.ServerAtm.ServerAtmStrategy strategy)` : bool
- `CloseStrategy(void)` : void
- `Reverse(AtmStrategySelectionMode mode, TimeInForce tif, System.DateTime expire)` : void
- `SetState(State state)` : void
- `ToConfigJson(void)` : System.Text.Json.Nodes.JsonObject
- `ToParamJson(OrderAction action)` : System.Text.Json.Nodes.JsonObject
