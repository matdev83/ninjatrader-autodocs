# ImportType

Namespace: `NinjaTrader.NinjaScript.ImportTypes`
Type: class

This documentation is generated from reflection scaffolding and may be incomplete.

## Properties
- `BarsPeriodType` (BarsPeriodType)
- `HasErrors` (bool)
- `HasValidDataPoint` (bool)
- `HasValidInstrument` (bool)
- `ImportedInstruments` (NinjaTrader.Cbi.Instrument[])
- `NumberOfDataPoints` (int)
- `Ask` (double)
- `Bid` (double)
- `Close` (double)
- `DataPointString` (string)
- `High` (double)
- `Instrument` (NinjaTrader.Cbi.Instrument)
- `Low` (double)
- `Open` (double)
- `OpenInterest` (double)
- `Time` (System.DateTime)
- `Volume` (long)
- `LogTypeName` (string)

## Methods
- `Dispose(void)` : void
- `Import(MarketDataType marketDataType, System.TimeZoneInfo sourceTimeZoneInfo, bool generateMinuteBars, bool generateDailyBars, NinjaTrader.Core.IProgress progress)` : void
- `SetState(State state)` : void
