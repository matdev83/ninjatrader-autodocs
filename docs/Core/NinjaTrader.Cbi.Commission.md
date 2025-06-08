# Commission

Namespace: `NinjaTrader.Cbi`
Type: class

This documentation is generated from reflection scaffolding and may be incomplete.

## Properties
- `Name` (string)
- `All` (System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Commission>)
- `ByInstrumentType` (NinjaTrader.Cbi.InstrumentCommission[])
- `MasterInstrumentsSerializable` (System.String[])
- `Version` (int)

## Methods
- `CopyTo(NinjaTrader.Cbi.Commission commission)` : void
- `GetMinimum(NinjaTrader.Cbi.Instrument instrument)` : double
- `GetWithMinimum(NinjaTrader.Cbi.Instrument instrument, int quantity)` : double
- `GetWithoutMinimum(NinjaTrader.Cbi.Instrument instrument, int quantity)` : double
- `Get(string name)` : NinjaTrader.Cbi.Commission
- `Remove(void)` : void
- `Save(bool persist)` : void
- `SnapShotPersist(bool updateVersion)` : void
- `ToString(void)` : string
