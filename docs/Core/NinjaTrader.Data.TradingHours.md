# TradingHours

Namespace: `NinjaTrader.Data`
Type: class

This documentation is generated from reflection scaffolding and may be incomplete.

## Properties
- `HolidaysSerializable` (NinjaTrader.Data.Holiday[])
- `PartialHolidaysSerializable` (NinjaTrader.Data.PartialHoliday[])
- `TradingHoursTemplateDir` (string)
- `TimeZoneDisplayName` (string)
- `TimeZoneInfo` (System.TimeZoneInfo)
- `Version` (int)
- `All` (System.Collections.ObjectModel.Collection<NinjaTrader.Data.TradingHours>)
- `Name` (string)
- `Sessions` (System.Collections.ObjectModel.Collection<NinjaTrader.Data.Session>)
- `SystemDefault` (string)
- `TimeZone` (string)
- `UseDataSeriesSettings` (string)
- `UseDataSeriesSettingsInstance` (NinjaTrader.Data.TradingHours)
- `UseInstrumentSettings` (string)
- `UseInstrumentSettingsInstance` (NinjaTrader.Data.TradingHours)

## Methods
- `CopyTo(NinjaTrader.Data.TradingHours tradingHours)` : void
- `GetPreviousTradingDayEnd(System.DateTime timeLocal)` : System.DateTime
- `Remove(void)` : void
- `Save(bool persist)` : void
- `SnapShotPersist(bool updateVersion)` : void
- `Get(string name)` : NinjaTrader.Data.TradingHours
- `String2TradingHours(string tradingHoursData)` : NinjaTrader.Data.TradingHours
- `ToString(void)` : string
