# User

Namespace: `NinjaTrader.Cbi`
Type: class

This documentation is generated from reflection scaffolding and may be incomplete.

## Properties
- `ApiPacing` (NinjaTrader.Server.ApiPacing)
- `Auth0UserId` (string)
- `ExpirationTime` (System.DateTime)
- `RegisteredTime` (System.DateTime)
- `UserData` (System.Xml.Linq.XDocument)
- `All` (System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.User>)
- `Address` (string)
- `ApiRateMultiplier` (double)
- `CanManageAccounts` (bool)
- `CanManageMessages` (bool)
- `CanManagePermissions` (bool)
- `CanManagePlatform` (bool)
- `CanManageRisk` (bool)
- `CanManageTreasury` (bool)
- `CanManageUsers` (bool)
- `CanRunReports` (bool)
- `CanViewAccounts` (bool)
- `CanViewUsers` (bool)
- `City` (string)
- `Company` (string)
- `CqgPurchaseEligible` (System.DateTime)
- `Country` (string)
- `CreatedByProvider` (Provider)
- `Current` (NinjaTrader.Cbi.User)
- `Description` (string)
- `Email1` (string)
- `Email2` (string)
- `Email3` (string)
- `FirstName` (string)
- `Id` (long)
- `IsEnabled` (bool)
- `IsMonitor` (bool)
- `IsProfessional` (bool)
- `LastName` (string)
- `Licenses` (System.Collections.Generic.List<NinjaTrader.Cbi.UserLicense>)
- `ManagedProvider` (Provider)
- `ManagesAllAccounts` (bool)
- `MaxConcurrentLogins` (int)
- `MaxMarketDataSubscriptions` (int)
- `MaxMarketDepthSubscriptions` (int)
- `Name` (string)
- `NumSimulationAccounts` (int)
- `Password` (string)
- `Phone` (string)
- `PostalCode` (string)
- `Salt` (string)
- `State` (string)

## Methods
- `DbAdd(bool persist)` : void
- `DbRemove(void)` : void
- `DbUpdate(void)` : void
- `SnapShotPersist(bool updateVersion)` : void
- `DbGet(long id)` : NinjaTrader.Cbi.User
- `DbGet(string name, bool forceDbQuery)` : NinjaTrader.Cbi.User
- `ToString(void)` : string
