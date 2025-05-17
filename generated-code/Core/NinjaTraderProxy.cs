[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class NinjaTraderProxy : IDisposable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the BPDomainName.
        /// </summary>
        [DataMember]
        public String BPDomainName { get; set; }
        /// <summary>
        /// Gets or sets the ClientType.
        /// </summary>
        [DataMember]
        public ClientType ClientType { get; set; }
        /// <summary>
        /// Gets or sets the EntitiesRequests.
        /// </summary>
        [DataMember]
        public Dictionary<Int32, TaskCompletionSource<XDocument>> EntitiesRequests { get; set; }
        /// <summary>
        /// Gets or sets the Requests.
        /// </summary>
        [DataMember]
        public Dictionary<Int32, TaskCompletionSource<Tuple<ErrorCode, String>>> Requests { get; set; }
        /// <summary>
        /// Gets or sets the XmlRequests.
        /// </summary>
        [DataMember]
        public Dictionary<Int32, Tuple<StringBuilder, TaskCompletionSource<XDocument>>> XmlRequests { get; set; }
        /// <summary>
        /// Gets or sets the Accounts.
        /// </summary>
        [DataMember]
        public Dictionary<Int64, Account> Accounts { get; set; }
        /// <summary>
        /// Gets or sets the ConnectionType.
        /// </summary>
        [DataMember]
        public ConnectionType ConnectionType { get; set; }
        /// <summary>
        /// Gets or sets the Deserializer.
        /// </summary>
        [DataMember]
        public Deserializer Deserializer { get; set; }
        /// <summary>
        /// Gets or sets the HeartbeatSeconds.
        /// </summary>
        [DataMember]
        public Int32 HeartbeatSeconds { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public String Id { get; set; }
        /// <summary>
        /// Gets or sets the InstrumentLists.
        /// </summary>
        [DataMember]
        public Dictionary<Int64, InstrumentList> InstrumentLists { get; set; }
        /// <summary>
        /// Gets or sets the Instruments.
        /// </summary>
        [DataMember]
        public Dictionary<Int64, Instrument> Instruments { get; set; }
        /// <summary>
        /// Gets or sets the MasterInstruments.
        /// </summary>
        [DataMember]
        public Dictionary<Int64, MasterInstrument> MasterInstruments { get; set; }
        /// <summary>
        /// Gets or sets the Orders.
        /// </summary>
        [DataMember]
        public Dictionary<Int64, Order> Orders { get; set; }
        /// <summary>
        /// Gets or sets the RolloverCollections.
        /// </summary>
        [DataMember]
        public Dictionary<Int64, RolloverCollection> RolloverCollections { get; set; }
        /// <summary>
        /// Gets or sets the Serializer.
        /// </summary>
        [DataMember]
        public Serializer Serializer { get; set; }
        /// <summary>
        /// Gets or sets the Status.
        /// </summary>
        [DataMember]
        public ConnectionStatus Status { get; set; }
        /// <summary>
        /// Gets or sets the TradingHours.
        /// </summary>
        [DataMember]
        public Dictionary<String, TradingHours> TradingHours { get; set; }
        /// <summary>
        /// Gets or sets the Version.
        /// </summary>
        [DataMember]
        public Int32 Version { get; set; }
        /// <summary>
        /// Gets or sets the ApiPacing.
        /// </summary>
        [DataMember]
        public ApiPacing ApiPacing { get; set; }
        /// <summary>
        /// Gets or sets the Commissions.
        /// </summary>
        [DataMember]
        public Dictionary<String, Commission> Commissions { get; set; }
        /// <summary>
        /// Gets or sets the Hotlists.
        /// </summary>
        [DataMember]
        public Dictionary<String, Hotlist> Hotlists { get; set; }
        /// <summary>
        /// Gets or sets the NumActiveFundamentalDataSubscriptions.
        /// </summary>
        [DataMember]
        public Int32 NumActiveFundamentalDataSubscriptions { get; set; }
        /// <summary>
        /// Gets or sets the NumActiveMarketDataSubscriptions.
        /// </summary>
        [DataMember]
        public Int32 NumActiveMarketDataSubscriptions { get; set; }
        /// <summary>
        /// Gets or sets the NumActiveMarketDepthSubscriptions.
        /// </summary>
        [DataMember]
        public Int32 NumActiveMarketDepthSubscriptions { get; set; }
        /// <summary>
        /// Gets or sets the Risks.
        /// </summary>
        [DataMember]
        public Dictionary<String, Risk> Risks { get; set; }
        /// <summary>
        /// Gets or sets the Strategies.
        /// </summary>
        [DataMember]
        public Dictionary<Int64, StrategyBase> Strategies { get; set; }
        /// <summary>
        /// Gets or sets the SubscribedFundamentalDataInstruments.
        /// </summary>
        [DataMember]
        public List<Instrument> SubscribedFundamentalDataInstruments { get; set; }
        /// <summary>
        /// Gets or sets the SubscribedMarketDataInstruments.
        /// </summary>
        [DataMember]
        public List<Instrument> SubscribedMarketDataInstruments { get; set; }
        /// <summary>
        /// Gets or sets the SubscribedMarketDepthInstruments.
        /// </summary>
        [DataMember]
        public List<Instrument> SubscribedMarketDepthInstruments { get; set; }
        /// <summary>
        /// Gets or sets the Users.
        /// </summary>
        [DataMember]
        public Dictionary<Int64, User> Users { get; set; }
        /// <summary>
        /// Gets or sets the RemoteEndPoint.
        /// </summary>
        [DataMember]
        public String RemoteEndPoint { get; set; }
        /// <summary>
        /// Gets or sets the Socket.
        /// </summary>
        [DataMember]
        public Socket Socket { get; set; }
        /// <summary>
        /// Gets or sets the StatisticsSendBytes.
        /// </summary>
        [DataMember]
        public Double StatisticsSendBytes { get; set; }
        /// <summary>
        /// Gets or sets the StatisticsSendBytesBuffered.
        /// </summary>
        [DataMember]
        public Double StatisticsSendBytesBuffered { get; set; }
        /// <summary>
        /// Gets or sets the StatisticsSendMessages.
        /// </summary>
        [DataMember]
        public Double StatisticsSendMessages { get; set; }
        /// <summary>
        /// Gets or sets the StatisticsSendTicks.
        /// </summary>
        [DataMember]
        public Double StatisticsSendTicks { get; set; }
        /// <summary>
        /// Gets or sets the Stream.
        /// </summary>
        [DataMember]
        public Stream Stream { get; set; }
        /// <summary>
        /// Gets or sets the WebSocket.
        /// </summary>
        [DataMember]
        public WebSocket WebSocket { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// AuthenticateAsClient method.
        /// </summary>
        /// <returns>Boolean</returns>
        public Boolean AuthenticateAsClient();
        /// <summary>
        /// BeginReceive method.
        /// </summary>
        /// <returns>Task</returns>
        public Task BeginReceive();
        /// <summary>
        /// Dispose method.
        /// </summary>
        public Void Dispose();
        /// <summary>
        /// GetAccount method.
        /// </summary>
        /// <param name="id">Int64</param>
        /// <returns>Account</returns>
        public Account GetAccount(Int64 id);
        /// <summary>
        /// GetCommission method.
        /// </summary>
        /// <param name="name">String</param>
        /// <returns>Commission</returns>
        public Commission GetCommission(String name);
        /// <summary>
        /// GetHotlist method.
        /// </summary>
        /// <param name="name">String</param>
        /// <returns>Hotlist</returns>
        public Hotlist GetHotlist(String name);
        /// <summary>
        /// GetInstrument method.
        /// </summary>
        /// <param name="id">Int64</param>
        /// <returns>Instrument</returns>
        public Instrument GetInstrument(Int64 id);
        /// <summary>
        /// GetInstrumentList method.
        /// </summary>
        /// <param name="id">Int64</param>
        /// <returns>InstrumentList</returns>
        public InstrumentList GetInstrumentList(Int64 id);
        /// <summary>
        /// GetMasterInstrument method.
        /// </summary>
        /// <param name="id">Int64</param>
        /// <returns>MasterInstrument</returns>
        public MasterInstrument GetMasterInstrument(Int64 id);
        /// <summary>
        /// GetOrder method.
        /// </summary>
        /// <param name="id">Int64</param>
        /// <returns>Order</returns>
        public Order GetOrder(Int64 id);
        /// <summary>
        /// GetRisk method.
        /// </summary>
        /// <param name="name">String</param>
        /// <returns>Risk</returns>
        public Risk GetRisk(String name);
        /// <summary>
        /// GetRolloverCollection method.
        /// </summary>
        /// <param name="id">Int64</param>
        /// <returns>RolloverCollection</returns>
        public RolloverCollection GetRolloverCollection(Int64 id);
        /// <summary>
        /// GetStrategy method.
        /// </summary>
        /// <param name="id">Int64</param>
        /// <returns>StrategyBase</returns>
        public StrategyBase GetStrategy(Int64 id);
        /// <summary>
        /// GetTradingHours method.
        /// </summary>
        /// <param name="name">String</param>
        /// <returns>TradingHours</returns>
        public TradingHours GetTradingHours(String name);
        /// <summary>
        /// GetUser method.
        /// </summary>
        /// <param name="id">Int64</param>
        /// <returns>User</returns>
        public User GetUser(Int64 id);
        /// <summary>
        /// OnSocketCompleted method.
        /// </summary>
        /// <param name="sender">Object</param>
        /// <param name="e">SocketAsyncEventArgs</param>
        public Void OnSocketCompleted(Object sender, SocketAsyncEventArgs e);
        /// <summary>
        /// SendAsync method.
        /// </summary>
        public Void SendAsync();
        /// <summary>
        /// SendEntities method.
        /// </summary>
        /// <param name="doc">XDocument</param>
        /// <param name="requestId">Int32</param>
        public Void SendEntities(XDocument doc, Int32 requestId);
        /// <summary>
        /// SendLog method.
        /// </summary>
        /// <param name="resourceType">Type</param>
        /// <param name="name">String</param>
        /// <param name="args">Object[]</param>
        /// <param name="logLevel">LogLevel</param>
        /// <param name="logCategory">LogCategories</param>
        /// <param name="serverName">String</param>
        /// <param name="user">User</param>
        /// <param name="account">Account</param>
        /// <param name="time">DateTime</param>
        public Void SendLog(Type resourceType, String name, Object[] args, LogLevel logLevel, LogCategories logCategory, String serverName, User user, Account account, DateTime time);
        /// <summary>
        /// SendXmlData method.
        /// </summary>
        /// <param name="doc">XDocument</param>
        /// <param name="requestId">Int32</param>
        public Void SendXmlData(XDocument doc, Int32 requestId);
        /// <summary>
        /// SetStatus method.
        /// </summary>
        /// <param name="newStatus">ConnectionStatus</param>
        /// <param name="error">ErrorCode</param>
        /// <param name="nativeError">String</param>
        public Void SetStatus(ConnectionStatus newStatus, ErrorCode error, String nativeError);
        #endregion
    }
}
