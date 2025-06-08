# InstrumentList

Namespace: `NinjaTrader.Cbi`
Type: class

This documentation is generated from reflection scaffolding and may be incomplete.

## Properties
- `IsWebOnly` (bool)
- `Version` (int)
- `All` (System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.InstrumentList>)
- `Id` (long)
- `Instruments` (System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Instrument>)
- `Name` (string)

## Methods
- `CopyTo(NinjaTrader.Cbi.InstrumentList instrumentList)` : void
- `DbGet(long id)` : NinjaTrader.Cbi.InstrumentList
- `DbPersist(void)` : void
- `DbPersist(bool raiseEvent)` : void
- `DbRemove(void)` : void
- `GetInstruments(string instrumentOrInstrumentList)` : System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Instrument>
- `SnapShotPersist(bool updateVersion)` : void
- `DbGet(string name, bool forceDbQuery)` : NinjaTrader.Cbi.InstrumentList
- `ToString(void)` : string
