# IAlertHost

Namespace: `NinjaTrader.NinjaScript`
Type: interface

This documentation is generated from reflection scaffolding and may be incomplete.

## Properties
- `ActiveInstruments` (System.Collections.Generic.IEnumerable<NinjaTrader.Cbi.Instrument>)
- `Alerts` (System.Collections.Generic.IList<NinjaTrader.NinjaScript.Alert>)
- `AlertHostType` (AlertHostType)
- `Workspace` (string)

## Methods
- `BuildAlertMessagePart(string variable, NinjaTrader.NinjaScript.AlertEventArgs e)` : string
- `UpdateAllAlerts(void)` : void
- `VerifyAlertActions(System.Collections.Generic.IEnumerable<NinjaTrader.NinjaScript.AlertAction> actions)` : bool
- `VerifyAlertConditions(System.Collections.Generic.IEnumerable<NinjaTrader.NinjaScript.AlertCondition> conditions)` : bool
