# IndicatorBase

Namespace: `NinjaTrader.NinjaScript`
Type: class

This documentation is generated from reflection scaffolding and may be incomplete.

## Properties
- `InputPlot` (int)
- `IsChartOnly` (bool)
- `IsCreatedByStrategy` (bool)
- `IsOwnedByChart` (bool)
- `IsSuspended` (bool)
- `IsTradingHoursBreakLineVisible` (bool)
- `TrackedOrders` (System.Collections.Generic.List<NinjaTrader.NinjaScript.TrackedOrder>)
- `DefaultName` (string)
- `DisplayName` (string)
- `DrawHorizontalGridLines` (bool)
- `DrawVerticalGridLines` (bool)
- `DrawOnPricePanel` (bool)
- `LogTypeName` (string)
- `PaintPriceMarkers` (bool)

## Methods
- `RestoreInputFromXml(System.Xml.Linq.XContainer node)` : void
- `SaveInputToXml(void)` : System.Xml.Linq.XElement
- `PropagateIsSuspendedToChildren(void)` : void
- `UpdateTrackedOrderPrice(bool forceOffsetUpdate)` : void
- `CopyTo(NinjaTrader.NinjaScript.NinjaScript ninjaScript)` : void
- `GetDisplayName(bool useDefaultLogic, bool trim)` : string
- `GetDisplayName(bool useDefaultLogic, bool generateCode, bool trim)` : string
- `RestoreFromXml(System.Xml.Linq.XElement element)` : void
- `SaveToXml(System.Xml.Linq.XElement element)` : void
- `ToString(void)` : string
