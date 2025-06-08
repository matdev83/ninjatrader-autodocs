# UserEntitlement

Namespace: `NinjaTrader.Cbi`
Type: class

This documentation is generated from reflection scaffolding and may be incomplete.

## Properties
- `Entitlements` (Entitlement[])
- `Instance` (NinjaTrader.Cbi.UserEntitlement)
- `HasStaticSuperDOM` (bool)
- `IsAdmin` (bool)
- `IsAMP` (bool)
- `IsEvaluation` (bool)
- `IsGFF` (bool)
- `IsLifeTime` (bool)
- `IsMarketReplay` (bool)
- `IsMultiBroker` (bool)
- `IsOrderFlowPlus` (bool)
- `IsRiskManagement` (bool)
- `IsRithmic` (bool)
- `IsServer` (bool)
- `LicensedProviders` (Provider[])
- `MachineId` (string)
- `MachineId2` (string)
- `NTLMUrl` (string)
- `TradableRithmicSystems` (RithmicConnection[])
- `TradingProviders` (Provider[])
- `Subscription` (UserSubscriptionType)
- `UserEntitlements` (Entitlement[])
- `UserId` (long)
- `UserSubscription` (UserSubscriptionType)
- `VerificationState` (VerificationState)

## Methods
- `IsTradingAndAccountAvailable(Provider provider, RithmicConnection? rithmicConnection)` : bool
- `Log(string action)` : void
- `ResetProviders(void)` : void
- `VerifyAsync(string accessToken, long authUserId)` : System.Threading.Tasks.Task<System.DateTime>
