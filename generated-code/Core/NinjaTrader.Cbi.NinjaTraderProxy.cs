[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class NinjaTraderProxy : System.IDisposable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the BPDomainName.
        /// </summary>
        [DataMember]
        public string BPDomainName { get; set; }
        /// <summary>
        /// Gets or sets the ClientType.
        /// </summary>
        [DataMember]
        public ClientType ClientType { get; set; }
        /// <summary>
        /// Gets or sets the EntitiesRequests.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<int, System.Threading.Tasks.TaskCompletionSource<System.Xml.Linq.XDocument>> EntitiesRequests { get; set; }
        /// <summary>
        /// Gets or sets the Requests.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<int, System.Threading.Tasks.TaskCompletionSource<System.Tuple<ErrorCode, string>>> Requests { get; set; }
        /// <summary>
        /// Gets or sets the XmlRequests.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<int, System.Tuple<System.Text.StringBuilder, System.Threading.Tasks.TaskCompletionSource<System.Xml.Linq.XDocument>>> XmlRequests { get; set; }
        /// <summary>
        /// Gets or sets the Accounts.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<long, NinjaTrader.Cbi.Account> Accounts { get; set; }
        /// <summary>
        /// Gets or sets the ConnectionType.
        /// </summary>
        [DataMember]
        public ConnectionType ConnectionType { get; set; }
        /// <summary>
        /// Gets or sets the Deserializer.
        /// </summary>
        [DataMember]
        public NinjaTrader.Core.Deserializer Deserializer { get; set; }
        /// <summary>
        /// Gets or sets the HeartbeatSeconds.
        /// </summary>
        [DataMember]
        public int HeartbeatSeconds { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public string Id { get; set; }
        /// <summary>
        /// Gets or sets the InstrumentLists.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<long, NinjaTrader.Cbi.InstrumentList> InstrumentLists { get; set; }
        /// <summary>
        /// Gets or sets the Instruments.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<long, NinjaTrader.Cbi.Instrument> Instruments { get; set; }
        /// <summary>
        /// Gets or sets the MasterInstruments.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<long, NinjaTrader.Cbi.MasterInstrument> MasterInstruments { get; set; }
        /// <summary>
        /// Gets or sets the Orders.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<long, NinjaTrader.Cbi.Order> Orders { get; set; }
        /// <summary>
        /// Gets or sets the RolloverCollections.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<long, NinjaTrader.Cbi.RolloverCollection> RolloverCollections { get; set; }
        /// <summary>
        /// Gets or sets the Serializer.
        /// </summary>
        [DataMember]
        public NinjaTrader.Core.Serializer Serializer { get; set; }
        /// <summary>
        /// Gets or sets the Status.
        /// </summary>
        [DataMember]
        public ConnectionStatus Status { get; set; }
        /// <summary>
        /// Gets or sets the TradingHours.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<string, NinjaTrader.Data.TradingHours> TradingHours { get; set; }
        /// <summary>
        /// Gets or sets the Version.
        /// </summary>
        [DataMember]
        public int Version { get; set; }
        /// <summary>
        /// Gets or sets the ApiPacing.
        /// </summary>
        [DataMember]
        public NinjaTrader.Server.ApiPacing ApiPacing { get; set; }
        /// <summary>
        /// Gets or sets the Commissions.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<string, NinjaTrader.Cbi.Commission> Commissions { get; set; }
        /// <summary>
        /// Gets or sets the Hotlists.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<string, NinjaTrader.Data.Hotlist> Hotlists { get; set; }
        /// <summary>
        /// Gets or sets the NumActiveFundamentalDataSubscriptions.
        /// </summary>
        [DataMember]
        public int NumActiveFundamentalDataSubscriptions { get; set; }
        /// <summary>
        /// Gets or sets the NumActiveMarketDataSubscriptions.
        /// </summary>
        [DataMember]
        public int NumActiveMarketDataSubscriptions { get; set; }
        /// <summary>
        /// Gets or sets the NumActiveMarketDepthSubscriptions.
        /// </summary>
        [DataMember]
        public int NumActiveMarketDepthSubscriptions { get; set; }
        /// <summary>
        /// Gets or sets the Risks.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<string, NinjaTrader.Cbi.Risk> Risks { get; set; }
        /// <summary>
        /// Gets or sets the Strategies.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<long, NinjaTrader.NinjaScript.StrategyBase> Strategies { get; set; }
        /// <summary>
        /// Gets or sets the SubscribedFundamentalDataInstruments.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.List<NinjaTrader.Cbi.Instrument> SubscribedFundamentalDataInstruments { get; set; }
        /// <summary>
        /// Gets or sets the SubscribedMarketDataInstruments.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.List<NinjaTrader.Cbi.Instrument> SubscribedMarketDataInstruments { get; set; }
        /// <summary>
        /// Gets or sets the SubscribedMarketDepthInstruments.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.List<NinjaTrader.Cbi.Instrument> SubscribedMarketDepthInstruments { get; set; }
        /// <summary>
        /// Gets or sets the Users.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<long, NinjaTrader.Cbi.User> Users { get; set; }
        /// <summary>
        /// Gets or sets the RemoteEndPoint.
        /// </summary>
        [DataMember]
        public string RemoteEndPoint { get; set; }
        /// <summary>
        /// Gets or sets the Socket.
        /// </summary>
        [DataMember]
        public System.Net.Sockets.Socket Socket { get; set; }
        /// <summary>
        /// Gets or sets the StatisticsSendBytes.
        /// </summary>
        [DataMember]
        public double StatisticsSendBytes { get; set; }
        /// <summary>
        /// Gets or sets the StatisticsSendBytesBuffered.
        /// </summary>
        [DataMember]
        public double StatisticsSendBytesBuffered { get; set; }
        /// <summary>
        /// Gets or sets the StatisticsSendMessages.
        /// </summary>
        [DataMember]
        public double StatisticsSendMessages { get; set; }
        /// <summary>
        /// Gets or sets the StatisticsSendTicks.
        /// </summary>
        [DataMember]
        public double StatisticsSendTicks { get; set; }
        /// <summary>
        /// Gets or sets the Stream.
        /// </summary>
        [DataMember]
        public System.IO.Stream Stream { get; set; }
        /// <summary>
        /// Gets or sets the WebSocket.
        /// </summary>
        [DataMember]
        public System.Net.WebSockets.WebSocket WebSocket { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// AuthenticateAsClient method.
        /// </summary>
        /// <returns>bool</returns>
        public bool AuthenticateAsClient()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// BeginReceive method.
        /// </summary>
        /// <returns>System.Threading.Tasks.Task</returns>
        public System.Threading.Tasks.Task BeginReceive()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Dispose method.
        /// </summary>
        public void Dispose()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetAccount method.
        /// </summary>
        /// <param name="id">long</param>
        /// <returns>NinjaTrader.Cbi.Account</returns>
        public NinjaTrader.Cbi.Account GetAccount(long id)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetCommission method.
        /// </summary>
        /// <param name="name">string</param>
        /// <returns>NinjaTrader.Cbi.Commission</returns>
        public NinjaTrader.Cbi.Commission GetCommission(string name)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetHotlist method.
        /// </summary>
        /// <param name="name">string</param>
        /// <returns>NinjaTrader.Data.Hotlist</returns>
        public NinjaTrader.Data.Hotlist GetHotlist(string name)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetInstrument method.
        /// </summary>
        /// <param name="id">long</param>
        /// <returns>NinjaTrader.Cbi.Instrument</returns>
        public NinjaTrader.Cbi.Instrument GetInstrument(long id)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetInstrumentList method.
        /// </summary>
        /// <param name="id">long</param>
        /// <returns>NinjaTrader.Cbi.InstrumentList</returns>
        public NinjaTrader.Cbi.InstrumentList GetInstrumentList(long id)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetMasterInstrument method.
        /// </summary>
        /// <param name="id">long</param>
        /// <returns>NinjaTrader.Cbi.MasterInstrument</returns>
        public NinjaTrader.Cbi.MasterInstrument GetMasterInstrument(long id)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetOrder method.
        /// </summary>
        /// <param name="id">long</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order GetOrder(long id)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetRisk method.
        /// </summary>
        /// <param name="name">string</param>
        /// <returns>NinjaTrader.Cbi.Risk</returns>
        public NinjaTrader.Cbi.Risk GetRisk(string name)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetRolloverCollection method.
        /// </summary>
        /// <param name="id">long</param>
        /// <returns>NinjaTrader.Cbi.RolloverCollection</returns>
        public NinjaTrader.Cbi.RolloverCollection GetRolloverCollection(long id)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetStrategy method.
        /// </summary>
        /// <param name="id">long</param>
        /// <returns>NinjaTrader.NinjaScript.StrategyBase</returns>
        public NinjaTrader.NinjaScript.StrategyBase GetStrategy(long id)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetTradingHours method.
        /// </summary>
        /// <param name="name">string</param>
        /// <returns>NinjaTrader.Data.TradingHours</returns>
        public NinjaTrader.Data.TradingHours GetTradingHours(string name)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetUser method.
        /// </summary>
        /// <param name="id">long</param>
        /// <returns>NinjaTrader.Cbi.User</returns>
        public NinjaTrader.Cbi.User GetUser(long id)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// OnSocketCompleted method.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">System.Net.Sockets.SocketAsyncEventArgs</param>
        public void OnSocketCompleted(object sender, System.Net.Sockets.SocketAsyncEventArgs e)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SendAsync method.
        /// </summary>
        public void SendAsync()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SendEntities method.
        /// </summary>
        /// <param name="doc">System.Xml.Linq.XDocument</param>
        /// <param name="requestId">int</param>
        public void SendEntities(System.Xml.Linq.XDocument doc, int requestId)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SendLog method.
        /// </summary>
        /// <param name="resourceType">System.Type</param>
        /// <param name="name">string</param>
        /// <param name="args">System.Object[]</param>
        /// <param name="logLevel">LogLevel</param>
        /// <param name="logCategory">LogCategories</param>
        /// <param name="serverName">string</param>
        /// <param name="user">NinjaTrader.Cbi.User</param>
        /// <param name="account">NinjaTrader.Cbi.Account</param>
        /// <param name="time">System.DateTime</param>
        public void SendLog(System.Type resourceType, string name, System.Object[] args, LogLevel logLevel, LogCategories logCategory, string serverName, NinjaTrader.Cbi.User user, NinjaTrader.Cbi.Account account, System.DateTime time)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SendXmlData method.
        /// </summary>
        /// <param name="doc">System.Xml.Linq.XDocument</param>
        /// <param name="requestId">int</param>
        public void SendXmlData(System.Xml.Linq.XDocument doc, int requestId)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SetStatus method.
        /// </summary>
        /// <param name="newStatus">ConnectionStatus</param>
        /// <param name="error">ErrorCode</param>
        /// <param name="nativeError">string</param>
        public void SetStatus(ConnectionStatus newStatus, ErrorCode error, string nativeError)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
