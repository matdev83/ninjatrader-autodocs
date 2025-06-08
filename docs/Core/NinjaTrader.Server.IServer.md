# IServer

Namespace: `NinjaTrader.Server`
Type: interface

This documentation is generated from reflection scaffolding and may be incomplete.

## Properties
- `AdminNT` (NinjaTrader.Cbi.NinjaTraderProxy)
- `HealthStatus` (HealthStatus)
- `NTServer` (NinjaTrader.Server.NTServer)

## Methods
- `AddExecution(string account, string executionId, double fee, string instrument, InstrumentType instrumentType, string licenseCode, MarketPosition marketPosition, double price, int quantity, System.DateTime executionTimeUtc)` : void
- `AfterApplySnapShot(NinjaTrader.Cbi.ISnapShotSerializable entity, System.Xml.Linq.XElement element, Operation op)` : void
- `Deserialize(NinjaTrader.Core.Deserializer d, ApiCommand cmd, int version)` : void
- `DeserializeBP(NinjaTrader.Core.Deserializer d, ApiCommand cmd, int version)` : void
- `DeserializeDS(NinjaTrader.Core.Deserializer d, ApiCommand cmd, int version)` : void
- `DeserializeHDS(NinjaTrader.Core.Deserializer d, ApiCommand cmd, int version)` : void
- `DeserializeGW(NinjaTrader.Core.Deserializer d, ApiCommand cmd, int version)` : void
- `Process(System.Net.HttpListenerContext context)` : void
- `RegisterTokenAdmin(string username, string token, System.DateTime validThroughUtc)` : void
- `ReloadRolloverCollectionIS(void)` : void
- `RequestBarsHDS(NinjaTrader.Cbi.NinjaTraderProxy nt, int idx, NinjaTrader.Data.IBars bars, System.Action<NinjaTrader.Data.IBars, ErrorCode, string> callback, NinjaTrader.Core.IProgress progress)` : void
- `RequestMessagesHDS(NinjaTrader.Cbi.NinjaTraderProxy nt)` : void
- `RequestPlaybackHDS(NinjaTrader.Cbi.NinjaTraderProxy nt, int idx, NinjaTrader.Cbi.Instrument instrument, System.DateTime dateEst, System.Action<ErrorCode, string, object> callback, NinjaTrader.Core.IProgress progress)` : void
- `RequestStartupInfoIS(NinjaTrader.Cbi.NinjaTraderProxy nt, NinjaTrader.Cbi.HandshakeReply o)` : void
- `SendChangeSetAdmin(System.Xml.Linq.XDocument doc)` : void
- `SendHDSTokenAdmin(string username, string hdsToken, System.DateTime validThroughUtc)` : void
- `Start(void)` : void
- `Stop(void)` : void
- `SubscribeFundamentalDataBP(NinjaTrader.Cbi.NinjaTraderProxy nt, NinjaTrader.Cbi.Instrument instrument, NinjaTrader.Cbi.User user)` : void
- `SubscribeMarketDataBP(NinjaTrader.Cbi.NinjaTraderProxy nt, NinjaTrader.Cbi.Instrument instrument, NinjaTrader.Cbi.User user)` : void
- `SubscribeMarketDepthBP(NinjaTrader.Cbi.NinjaTraderProxy nt, NinjaTrader.Cbi.Instrument instrument, NinjaTrader.Cbi.User user)` : void
- `UnsubscribeFundamentalDataBP(NinjaTrader.Cbi.NinjaTraderProxy nt, NinjaTrader.Cbi.Instrument instrument, NinjaTrader.Cbi.User user)` : void
- `UnsubscribeMarketDataBP(NinjaTrader.Cbi.NinjaTraderProxy nt, NinjaTrader.Cbi.Instrument instrument, NinjaTrader.Cbi.User user)` : void
- `UnsubscribeMarketDepthBP(NinjaTrader.Cbi.NinjaTraderProxy nt, NinjaTrader.Cbi.Instrument instrument, NinjaTrader.Cbi.User user)` : void
