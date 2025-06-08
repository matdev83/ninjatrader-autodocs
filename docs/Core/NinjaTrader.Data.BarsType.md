# BarsType

Namespace: `NinjaTrader.Data`
Type: class

This documentation is generated from reflection scaffolding and may be incomplete.

## Properties
- `BarsPeriod` (NinjaTrader.Data.BarsPeriod)
- `BarsTypeDay` (NinjaTrader.Data.BarsType)
- `BarsTypeMinute` (NinjaTrader.Data.BarsType)
- `BarsTypeMonth` (NinjaTrader.Data.BarsType)
- `BarsTypeSecond` (NinjaTrader.Data.BarsType)
- `BarsTypeTick` (NinjaTrader.Data.BarsType)
- `BarsTypeYear` (NinjaTrader.Data.BarsType)
- `BuiltFrom` (BarsPeriodType)
- `DayCount` (int)
- `DaysToLoad` (int)
- `DefaultChartStyle` (ChartStyleType)
- `IsIntraday` (bool)
- `IsRemoveLastBarSupported` (bool)
- `IsTimeBased` (bool)
- `LogTypeName` (string)
- `Properties` (System.ComponentModel.PropertyDescriptorCollection)
- `SkipCaching` (bool)
- `TickCount` (int)
- `TicksOnLastSecond` (int)

## Methods
- `ApplyDefaultValue(NinjaTrader.Data.BarsPeriod period)` : void
- `ApplyDefaultBasePeriodValue(NinjaTrader.Data.BarsPeriod period)` : void
- `ChartLabel(System.DateTime time)` : string
- `CreateInstance(NinjaTrader.Data.BarsPeriod period)` : NinjaTrader.Data.BarsType
- `CreateInstance(BarsPeriodType periodType)` : NinjaTrader.Data.BarsType
- `ResetBarsTypes(void)` : void
- `GetBarsPeriodTypeName(BarsPeriodType barsPeriodType)` : string
- `GetInitialLookBackDays(NinjaTrader.Data.BarsPeriod barsPeriod, NinjaTrader.Data.TradingHours tradingHours, int barsBack)` : int
- `GetPercentComplete(NinjaTrader.Data.Bars bars, System.DateTime now)` : double
- `GetSupported(void)` : BarsPeriodType[]
- `IncludesEndTimeStamp(bool isBar)` : bool
- `Merge(NinjaTrader.Data.BarsType barsType)` : void
- `SetIsRemoveLastBarSupported(bool value)` : void
- `SetState(State state)` : void
- `Shutdown(void)` : void
- `TrimEnd(int numBars)` : void
- `TrimStart(int numBars)` : void
