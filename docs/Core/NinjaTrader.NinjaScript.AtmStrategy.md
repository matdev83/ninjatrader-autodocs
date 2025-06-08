# AtmStrategy

Namespace: `NinjaTrader.NinjaScript`
Type: class

This documentation is generated from reflection scaffolding and may be incomplete.

## Properties
- `AtmSelector` (string)
- `ModifyInnerBracket` (bool)
- `ModifyNearestBracket` (bool)
- `OnBehalfOf` (string)
- `ReverseAtStopStrategyId` (long)
- `ReverseAtTargetStrategyId` (long)
- `ShadowStrategyStrategyId` (long)
- `ShadowTemplate` (string)
- `Brackets` (NinjaTrader.Cbi.Bracket[])
- `CalculationMode` (CalculationMode)
- `ChaseLimit` (double)
- `DisplayNameExtended` (string)
- `DisplayName` (string)
- `EntryQuantity` (int)
- `InitialEntryOrder` (NinjaTrader.Cbi.Order)
- `InitialTickSize` (double)
- `IsChase` (bool)
- `IsChaseIfTouched` (bool)
- `IsTargetChase` (bool)
- `ReverseAtStop` (bool)
- `ReverseAtTarget` (bool)
- `UseMitForProfit` (bool)
- `UseStopLimitForStopLossOrders` (bool)

## Methods
- `AddTarget(void)` : void
- `CloseStrategy(string signalName)` : void
- `GetStopOrders(int idx)` : System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Order>
- `GetTargetOrders(int idx)` : System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Order>
- `IsEqual(NinjaTrader.NinjaScript.AtmStrategy atmStrategy)` : bool
- `IsProfitTarget(NinjaTrader.Cbi.Order order)` : bool
- `IsStopLoss(NinjaTrader.Cbi.Order order)` : bool
- `ProtectPosition(NinjaTrader.NinjaScript.AtmStrategy template, NinjaTrader.Cbi.Position position)` : void
- `RemoveTarget(void)` : void
- `Reverse(AtmStrategySelectionMode mode)` : void
- `SetOutstandingEntryQuantity(double price, int quantity)` : void
- `SetOutstandingExitQuantity(double price, int quantity)` : void
- `StartAtmStrategy(NinjaTrader.NinjaScript.AtmStrategy atmStrategyTemplate, NinjaTrader.Cbi.Order entryOrder)` : NinjaTrader.NinjaScript.AtmStrategy
- `StartAtmStrategy(string atmStrategyTemplateName, NinjaTrader.Cbi.Order entryOrder)` : NinjaTrader.NinjaScript.AtmStrategy
- `CanPlaceOrder(OrderAction action)` : bool
- `IsEntry(NinjaTrader.Cbi.Order order)` : bool
- `IsExit(NinjaTrader.Cbi.Order order)` : bool
- `IsSimStop(NinjaTrader.Cbi.Order order)` : bool
- `IsStop(NinjaTrader.Cbi.Order order)` : bool
- `IsTarget(NinjaTrader.Cbi.Order order)` : bool
- `ManageOrder(NinjaTrader.Cbi.Order order)` : void
