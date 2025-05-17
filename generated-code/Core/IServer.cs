namespace NinjaTrader.Server
{
    public partial interface IServer : IDisposable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AdminNT.
        /// </summary>
        [DataMember]
        public NinjaTraderProxy AdminNT { get; set; }
        /// <summary>
        /// Gets or sets the HealthStatus.
        /// </summary>
        [DataMember]
        public HealthStatus HealthStatus { get; set; }
        /// <summary>
        /// Gets or sets the NTServer.
        /// </summary>
        [DataMember]
        public NTServer NTServer { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// AddExecution method.
        /// </summary>
        /// <param name="account">String</param>
        /// <param name="executionId">String</param>
        /// <param name="fee">Double</param>
        /// <param name="instrument">String</param>
        /// <param name="instrumentType">InstrumentType</param>
        /// <param name="licenseCode">String</param>
        /// <param name="marketPosition">MarketPosition</param>
        /// <param name="price">Double</param>
        /// <param name="quantity">Int32</param>
        /// <param name="executionTimeUtc">DateTime</param>
        public Void AddExecution(String account, String executionId, Double fee, String instrument, InstrumentType instrumentType, String licenseCode, MarketPosition marketPosition, Double price, Int32 quantity, DateTime executionTimeUtc);
        /// <summary>
        /// AfterApplySnapShot method.
        /// </summary>
        /// <param name="entity">ISnapShotSerializable</param>
        /// <param name="element">XElement</param>
        /// <param name="op">Operation</param>
        public Void AfterApplySnapShot(ISnapShotSerializable entity, XElement element, Operation op);
        /// <summary>
        /// Deserialize method.
        /// </summary>
        /// <param name="d">Deserializer</param>
        /// <param name="cmd">ApiCommand</param>
        /// <param name="version">Int32</param>
        public Void Deserialize(Deserializer d, ApiCommand cmd, Int32 version);
        /// <summary>
        /// DeserializeBP method.
        /// </summary>
        /// <param name="d">Deserializer</param>
        /// <param name="cmd">ApiCommand</param>
        /// <param name="version">Int32</param>
        public Void DeserializeBP(Deserializer d, ApiCommand cmd, Int32 version);
        /// <summary>
        /// DeserializeDS method.
        /// </summary>
        /// <param name="d">Deserializer</param>
        /// <param name="cmd">ApiCommand</param>
        /// <param name="version">Int32</param>
        public Void DeserializeDS(Deserializer d, ApiCommand cmd, Int32 version);
        /// <summary>
        /// DeserializeHDS method.
        /// </summary>
        /// <param name="d">Deserializer</param>
        /// <param name="cmd">ApiCommand</param>
        /// <param name="version">Int32</param>
        public Void DeserializeHDS(Deserializer d, ApiCommand cmd, Int32 version);
        /// <summary>
        /// DeserializeGW method.
        /// </summary>
        /// <param name="d">Deserializer</param>
        /// <param name="cmd">ApiCommand</param>
        /// <param name="version">Int32</param>
        public Void DeserializeGW(Deserializer d, ApiCommand cmd, Int32 version);
        /// <summary>
        /// Process method.
        /// </summary>
        /// <param name="context">HttpListenerContext</param>
        public Void Process(HttpListenerContext context);
        /// <summary>
        /// RegisterTokenAdmin method.
        /// </summary>
        /// <param name="username">String</param>
        /// <param name="token">String</param>
        /// <param name="validThroughUtc">DateTime</param>
        public Void RegisterTokenAdmin(String username, String token, DateTime validThroughUtc);
        /// <summary>
        /// ReloadRolloverCollectionIS method.
        /// </summary>
        public Void ReloadRolloverCollectionIS();
        /// <summary>
        /// RequestBarsHDS method.
        /// </summary>
        /// <param name="nt">NinjaTraderProxy</param>
        /// <param name="idx">Int32</param>
        /// <param name="bars">IBars</param>
        /// <param name="callback">Action`3</param>
        /// <param name="progress">IProgress</param>
        public Void RequestBarsHDS(NinjaTraderProxy nt, Int32 idx, IBars bars, Action<IBars, ErrorCode, String> callback, IProgress progress);
        /// <summary>
        /// RequestMessagesHDS method.
        /// </summary>
        /// <param name="nt">NinjaTraderProxy</param>
        public Void RequestMessagesHDS(NinjaTraderProxy nt);
        /// <summary>
        /// RequestPlaybackHDS method.
        /// </summary>
        /// <param name="nt">NinjaTraderProxy</param>
        /// <param name="idx">Int32</param>
        /// <param name="instrument">Instrument</param>
        /// <param name="dateEst">DateTime</param>
        /// <param name="callback">Action`3</param>
        /// <param name="progress">IProgress</param>
        public Void RequestPlaybackHDS(NinjaTraderProxy nt, Int32 idx, Instrument instrument, DateTime dateEst, Action<ErrorCode, String, Object> callback, IProgress progress);
        /// <summary>
        /// RequestStartupInfoIS method.
        /// </summary>
        /// <param name="nt">NinjaTraderProxy</param>
        /// <param name="o">HandshakeReply</param>
        public Void RequestStartupInfoIS(NinjaTraderProxy nt, HandshakeReply o);
        /// <summary>
        /// SendChangeSetAdmin method.
        /// </summary>
        /// <param name="doc">XDocument</param>
        public Void SendChangeSetAdmin(XDocument doc);
        /// <summary>
        /// SendHDSTokenAdmin method.
        /// </summary>
        /// <param name="username">String</param>
        /// <param name="hdsToken">String</param>
        /// <param name="validThroughUtc">DateTime</param>
        public Void SendHDSTokenAdmin(String username, String hdsToken, DateTime validThroughUtc);
        /// <summary>
        /// Start method.
        /// </summary>
        public Void Start();
        /// <summary>
        /// Stop method.
        /// </summary>
        public Void Stop();
        /// <summary>
        /// SubscribeFundamentalDataBP method.
        /// </summary>
        /// <param name="nt">NinjaTraderProxy</param>
        /// <param name="instrument">Instrument</param>
        /// <param name="user">User</param>
        public Void SubscribeFundamentalDataBP(NinjaTraderProxy nt, Instrument instrument, User user);
        /// <summary>
        /// SubscribeMarketDataBP method.
        /// </summary>
        /// <param name="nt">NinjaTraderProxy</param>
        /// <param name="instrument">Instrument</param>
        /// <param name="user">User</param>
        public Void SubscribeMarketDataBP(NinjaTraderProxy nt, Instrument instrument, User user);
        /// <summary>
        /// SubscribeMarketDepthBP method.
        /// </summary>
        /// <param name="nt">NinjaTraderProxy</param>
        /// <param name="instrument">Instrument</param>
        /// <param name="user">User</param>
        public Void SubscribeMarketDepthBP(NinjaTraderProxy nt, Instrument instrument, User user);
        /// <summary>
        /// UnsubscribeFundamentalDataBP method.
        /// </summary>
        /// <param name="nt">NinjaTraderProxy</param>
        /// <param name="instrument">Instrument</param>
        /// <param name="user">User</param>
        public Void UnsubscribeFundamentalDataBP(NinjaTraderProxy nt, Instrument instrument, User user);
        /// <summary>
        /// UnsubscribeMarketDataBP method.
        /// </summary>
        /// <param name="nt">NinjaTraderProxy</param>
        /// <param name="instrument">Instrument</param>
        /// <param name="user">User</param>
        public Void UnsubscribeMarketDataBP(NinjaTraderProxy nt, Instrument instrument, User user);
        /// <summary>
        /// UnsubscribeMarketDepthBP method.
        /// </summary>
        /// <param name="nt">NinjaTraderProxy</param>
        /// <param name="instrument">Instrument</param>
        /// <param name="user">User</param>
        public Void UnsubscribeMarketDepthBP(NinjaTraderProxy nt, Instrument instrument, User user);
        #endregion
    }
}
