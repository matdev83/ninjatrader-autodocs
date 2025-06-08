# NinjaTraderProxy

Namespace: `NinjaTrader.Cbi`
Type: class

This documentation is generated from reflection scaffolding and may be incomplete.

## Properties
- `BPDomainName` (string)
- `ClientType` (ClientType)
- `ConnectionType` (ConnectionType)
- `Deserializer` (NinjaTrader.Core.Deserializer)
- `HeartbeatSeconds` (int)
- `Id` (string)
- `Serializer` (NinjaTrader.Core.Serializer)
- `Status` (ConnectionStatus)
- `Version` (int)
- `ApiPacing` (NinjaTrader.Server.ApiPacing)
- `NumActiveFundamentalDataSubscriptions` (int)
- `NumActiveMarketDataSubscriptions` (int)
- `NumActiveMarketDepthSubscriptions` (int)
- `SubscribedFundamentalDataInstruments` (System.Collections.Generic.List<NinjaTrader.Cbi.Instrument>)
- `SubscribedMarketDataInstruments` (System.Collections.Generic.List<NinjaTrader.Cbi.Instrument>)
- `SubscribedMarketDepthInstruments` (System.Collections.Generic.List<NinjaTrader.Cbi.Instrument>)
- `RemoteEndPoint` (string)
- `Socket` (System.Net.Sockets.Socket)
- `StatisticsSendBytes` (double)
- `StatisticsSendBytesBuffered` (double)
- `StatisticsSendMessages` (double)
- `StatisticsSendTicks` (double)
- `Stream` (System.IO.Stream)
- `WebSocket` (System.Net.WebSockets.WebSocket)

## Methods
- `AuthenticateAsClient(void)` : bool
- `BeginReceive(void)` : System.Threading.Tasks.Task
- `Dispose(void)` : void
- `GetAccount(long id)` : NinjaTrader.Cbi.Account
- `GetCommission(string name)` : NinjaTrader.Cbi.Commission
- `GetHotlist(string name)` : NinjaTrader.Data.Hotlist
- `GetInstrument(long id)` : NinjaTrader.Cbi.Instrument
- `GetInstrumentList(long id)` : NinjaTrader.Cbi.InstrumentList
- `GetMasterInstrument(long id)` : NinjaTrader.Cbi.MasterInstrument
- `GetOrder(long id)` : NinjaTrader.Cbi.Order
- `GetRisk(string name)` : NinjaTrader.Cbi.Risk
- `GetRolloverCollection(long id)` : NinjaTrader.Cbi.RolloverCollection
- `GetStrategy(long id)` : NinjaTrader.NinjaScript.StrategyBase
- `GetTradingHours(string name)` : NinjaTrader.Data.TradingHours
- `GetUser(long id)` : NinjaTrader.Cbi.User
- `OnSocketCompleted(object sender, System.Net.Sockets.SocketAsyncEventArgs e)` : void
- `SendAsync(void)` : void
- `SendEntities(System.Xml.Linq.XDocument doc, int requestId)` : void
- `SendLog(System.Type resourceType, string name, System.Object[] args, LogLevel logLevel, LogCategories logCategory, string serverName, NinjaTrader.Cbi.User user, NinjaTrader.Cbi.Account account, System.DateTime time)` : void
- `SendXmlData(System.Xml.Linq.XDocument doc, int requestId)` : void
- `SetStatus(ConnectionStatus newStatus, ErrorCode error, string nativeError)` : void
