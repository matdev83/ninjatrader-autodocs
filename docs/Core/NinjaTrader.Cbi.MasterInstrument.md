# MasterInstrument

Namespace: `NinjaTrader.Cbi`
Type: class

This documentation is generated from reflection scaffolding and may be incomplete.

## Properties
- `IsAutoLiquidationEnabled` (bool)
- `Dividends` (System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Dividend>)
- `Exchanges` (System.Collections.ObjectModel.Collection<Exchange>)
- `IsServerSupported` (bool)
- `MergePolicy` (MergePolicy)
- `PriceLevel` (double)
- `Splits` (System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Split>)
- `SyncBarsBytesFiles` (object)
- `SyncPlaybackFiles` (object)
- `Url` (System.Uri)
- `UrlSerializable` (string)
- `UserData` (System.Xml.Linq.XDocument)
- `Version` (int)
- `Sync` (object)
- `All` (System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.MasterInstrument>)
- `Currency` (Currency)
- `Description` (string)
- `FundamentalData` (NinjaTrader.Data.FundamentalData)
- `Id` (long)
- `InstrumentType` (InstrumentType)
- `Name` (string)
- `PointValue` (double)
- `ProviderNames` (System.String[])
- `RolloverCollection` (NinjaTrader.Cbi.RolloverCollection)
- `TickSize` (double)
- `TradingHours` (NinjaTrader.Data.TradingHours)

## Methods
- `Clone(void)` : object
- `CopyTo(NinjaTrader.Cbi.MasterInstrument masterInstrument)` : void
- `CopyTo(NinjaTrader.Cbi.MasterInstrument masterInstrument, bool generalPropertiesOnly)` : void
- `CreateInstruments(double strikePrice, OptionRight right)` : void
- `DbAdd(void)` : void
- `DbAdd(bool persist)` : void
- `DbGet(long id, bool forceDbQuery)` : NinjaTrader.Cbi.MasterInstrument
- `DbPersist(void)` : void
- `DbRemove(void)` : void
- `DbUpdate(void)` : void
- `DbUpdateCache(void)` : void
- `GetDividendSum(System.DateTime atDate)` : double
- `GetInstrumentByDate(NinjaTrader.Cbi.Instrument instrument, System.DateTime date, bool getActualExiry, bool suppressCalculateRollOvers, NinjaTrader.Core.IProgress progress)` : NinjaTrader.Cbi.Instrument
- `GetNextExpiry(System.DateTime afterDate)` : System.DateTime
- `GetNextRolloverDate(System.DateTime date)` : System.DateTime
- `GetSplitFactor(System.DateTime atDate)` : double
- `RoundDownToTickSize(double price)` : double
- `SnapShotPersist(bool updateVersion)` : void
- `TryParsePrice(string value, System.Double& price)` : bool
- `TryParsePrice(InstrumentType instrumentType, double tickSize, string value, System.Double& price)` : bool
- `UpdateRolloverCollection(NinjaTrader.Core.IProgress progress, System.DateTime earliestRolloverToUpdate)` : void
- `Compare(double price1, double price2)` : int
- `DbGet(string name, InstrumentType instrumentType, bool forceDbQuery)` : NinjaTrader.Cbi.MasterInstrument
- `DeconstructPrice(double price, System.Double& handlePrice, System.Double& pipPrice, System.Double& subPipPrice, System.Boolean& standardTickSize)` : void
- `FormatPrice(double price, bool round)` : string
- `IsValidName(string name)` : bool
- `RoundPrice(double price, double tickSize)` : double
- `RoundToTickSize(double price)` : double
- `ToString(void)` : string
