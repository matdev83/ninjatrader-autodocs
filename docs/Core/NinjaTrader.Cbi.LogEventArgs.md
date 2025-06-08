# LogEventArgs

Namespace: `NinjaTrader.Cbi`
Type: class

This documentation is generated from reflection scaffolding and may be incomplete.

## Properties
- `IgnoreAsServerOrRms` (bool)
- `Args` (System.Object[])
- `Name` (string)
- `RaiseAccountEvent` (bool)
- `ResourceType` (System.Type)
- `Account` (NinjaTrader.Cbi.Account)
- `LogCategory` (LogCategories)
- `LogLevel` (LogLevel)
- `ServerName` (string)
- `Time` (System.DateTime)
- `User` (NinjaTrader.Cbi.User)
- `Message` (string)

## Methods
- `DbAdd(void)` : void
- `DbGet(System.DateTime? fromUtc, System.DateTime? toUtc, NinjaTrader.Cbi.Account account, NinjaTrader.Cbi.User user, string serverName, LogLevel? logLevel, LogCategories? logCategory)` : System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.LogEventArgs>
- `GetResource(System.Type resourceType, string name)` : string
- `ToString(void)` : string
