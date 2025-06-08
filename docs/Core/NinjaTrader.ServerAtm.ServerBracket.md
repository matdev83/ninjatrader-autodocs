# ServerBracket

Namespace: `NinjaTrader.ServerAtm`
Type: class

This documentation is generated from reflection scaffolding and may be incomplete.

## Properties
- `AutoTrail` (NinjaTrader.Cbi.AutoTrailStep)
- `Quantity` (int)
- `StopLimit` (double)
- `StopLoss` (double)
- `StopLossType` (ServerStopLossType)
- `Target` (double)
- `Type` (int)
- `Instrument` (NinjaTrader.Cbi.Instrument)
- `BreakEvenPlus` (double)
- `BreakEvenTrigger` (double)
- `IsBreakeven` (bool)
- `IsStopLimit` (bool)
- `IsTrailing` (bool)

## Methods
- `Clone(void)` : object
- `IsEqual(NinjaTrader.ServerAtm.ServerBracket strategyBracket)` : bool
- `ToParamJson(NinjaTrader.Cbi.MasterInstrument masterInstrument, ServerCalculationMode mode, OrderAction action)` : System.Text.Json.Nodes.JsonObject
