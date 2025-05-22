namespace NinjaTrader.Server
{
    public partial interface IServer : System.IDisposable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AdminNT.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.NinjaTraderProxy AdminNT { get; set; }
        /// <summary>
        /// Gets or sets the HealthStatus.
        /// </summary>
        [DataMember]
        public HealthStatus HealthStatus { get; set; }
        /// <summary>
        /// Gets or sets the NTServer.
        /// </summary>
        [DataMember]
        public NinjaTrader.Server.NTServer NTServer { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// AddExecution method.
        /// </summary>
        /// <param name="account">string</param>
        /// <param name="executionId">string</param>
        /// <param name="fee">double</param>
        /// <param name="instrument">string</param>
        /// <param name="instrumentType">InstrumentType</param>
        /// <param name="licenseCode">string</param>
        /// <param name="marketPosition">MarketPosition</param>
        /// <param name="price">double</param>
        /// <param name="quantity">int</param>
        /// <param name="executionTimeUtc">System.DateTime</param>
        public void AddExecution(string account, string executionId, double fee, string instrument, InstrumentType instrumentType, string licenseCode, MarketPosition marketPosition, double price, int quantity, System.DateTime executionTimeUtc);
        /// <summary>
        /// AfterApplySnapShot method.
        /// </summary>
        /// <param name="entity">NinjaTrader.Cbi.ISnapShotSerializable</param>
        /// <param name="element">System.Xml.Linq.XElement</param>
        /// <param name="op">Operation</param>
        public void AfterApplySnapShot(NinjaTrader.Cbi.ISnapShotSerializable entity, System.Xml.Linq.XElement element, Operation op);
        /// <summary>
        /// Deserialize method.
        /// </summary>
        /// <param name="d">NinjaTrader.Core.Deserializer</param>
        /// <param name="cmd">ApiCommand</param>
        /// <param name="version">int</param>
        public void Deserialize(NinjaTrader.Core.Deserializer d, ApiCommand cmd, int version);
        /// <summary>
        /// DeserializeBP method.
        /// </summary>
        /// <param name="d">NinjaTrader.Core.Deserializer</param>
        /// <param name="cmd">ApiCommand</param>
        /// <param name="version">int</param>
        public void DeserializeBP(NinjaTrader.Core.Deserializer d, ApiCommand cmd, int version);
        /// <summary>
        /// DeserializeDS method.
        /// </summary>
        /// <param name="d">NinjaTrader.Core.Deserializer</param>
        /// <param name="cmd">ApiCommand</param>
        /// <param name="version">int</param>
        public void DeserializeDS(NinjaTrader.Core.Deserializer d, ApiCommand cmd, int version);
        /// <summary>
        /// DeserializeHDS method.
        /// </summary>
        /// <param name="d">NinjaTrader.Core.Deserializer</param>
        /// <param name="cmd">ApiCommand</param>
        /// <param name="version">int</param>
        public void DeserializeHDS(NinjaTrader.Core.Deserializer d, ApiCommand cmd, int version);
        /// <summary>
        /// DeserializeGW method.
        /// </summary>
        /// <param name="d">NinjaTrader.Core.Deserializer</param>
        /// <param name="cmd">ApiCommand</param>
        /// <param name="version">int</param>
        public void DeserializeGW(NinjaTrader.Core.Deserializer d, ApiCommand cmd, int version);
        /// <summary>
        /// Process method.
        /// </summary>
        /// <param name="context">System.Net.HttpListenerContext</param>
        public void Process(System.Net.HttpListenerContext context);
        /// <summary>
        /// RegisterTokenAdmin method.
        /// </summary>
        /// <param name="username">string</param>
        /// <param name="token">string</param>
        /// <param name="validThroughUtc">System.DateTime</param>
        public void RegisterTokenAdmin(string username, string token, System.DateTime validThroughUtc);
        /// <summary>
        /// ReloadRolloverCollectionIS method.
        /// </summary>
        public void ReloadRolloverCollectionIS();
        /// <summary>
        /// RequestBarsHDS method.
        /// </summary>
        /// <param name="nt">NinjaTrader.Cbi.NinjaTraderProxy</param>
        /// <param name="idx">int</param>
        /// <param name="bars">NinjaTrader.Data.IBars</param>
        /// <param name="callback">System.Action<NinjaTrader.Data.IBars, ErrorCode, string></param>
        /// <param name="progress">NinjaTrader.Core.IProgress</param>
        public void RequestBarsHDS(NinjaTrader.Cbi.NinjaTraderProxy nt, int idx, NinjaTrader.Data.IBars bars, System.Action<NinjaTrader.Data.IBars, ErrorCode, string> callback, NinjaTrader.Core.IProgress progress);
        /// <summary>
        /// RequestMessagesHDS method.
        /// </summary>
        /// <param name="nt">NinjaTrader.Cbi.NinjaTraderProxy</param>
        public void RequestMessagesHDS(NinjaTrader.Cbi.NinjaTraderProxy nt);
        /// <summary>
        /// RequestPlaybackHDS method.
        /// </summary>
        /// <param name="nt">NinjaTrader.Cbi.NinjaTraderProxy</param>
        /// <param name="idx">int</param>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        /// <param name="dateEst">System.DateTime</param>
        /// <param name="callback">System.Action<ErrorCode, string, object></param>
        /// <param name="progress">NinjaTrader.Core.IProgress</param>
        public void RequestPlaybackHDS(NinjaTrader.Cbi.NinjaTraderProxy nt, int idx, NinjaTrader.Cbi.Instrument instrument, System.DateTime dateEst, System.Action<ErrorCode, string, object> callback, NinjaTrader.Core.IProgress progress);
        /// <summary>
        /// RequestStartupInfoIS method.
        /// </summary>
        /// <param name="nt">NinjaTrader.Cbi.NinjaTraderProxy</param>
        /// <param name="o">NinjaTrader.Cbi.HandshakeReply</param>
        public void RequestStartupInfoIS(NinjaTrader.Cbi.NinjaTraderProxy nt, NinjaTrader.Cbi.HandshakeReply o);
        /// <summary>
        /// SendChangeSetAdmin method.
        /// </summary>
        /// <param name="doc">System.Xml.Linq.XDocument</param>
        public void SendChangeSetAdmin(System.Xml.Linq.XDocument doc);
        /// <summary>
        /// SendHDSTokenAdmin method.
        /// </summary>
        /// <param name="username">string</param>
        /// <param name="hdsToken">string</param>
        /// <param name="validThroughUtc">System.DateTime</param>
        public void SendHDSTokenAdmin(string username, string hdsToken, System.DateTime validThroughUtc);
        /// <summary>
        /// Start method.
        /// </summary>
        public void Start();
        /// <summary>
        /// Stop method.
        /// </summary>
        public void Stop();
        /// <summary>
        /// SubscribeFundamentalDataBP method.
        /// </summary>
        /// <param name="nt">NinjaTrader.Cbi.NinjaTraderProxy</param>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        /// <param name="user">NinjaTrader.Cbi.User</param>
        public void SubscribeFundamentalDataBP(NinjaTrader.Cbi.NinjaTraderProxy nt, NinjaTrader.Cbi.Instrument instrument, NinjaTrader.Cbi.User user);
        /// <summary>
        /// SubscribeMarketDataBP method.
        /// </summary>
        /// <param name="nt">NinjaTrader.Cbi.NinjaTraderProxy</param>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        /// <param name="user">NinjaTrader.Cbi.User</param>
        public void SubscribeMarketDataBP(NinjaTrader.Cbi.NinjaTraderProxy nt, NinjaTrader.Cbi.Instrument instrument, NinjaTrader.Cbi.User user);
        /// <summary>
        /// SubscribeMarketDepthBP method.
        /// </summary>
        /// <param name="nt">NinjaTrader.Cbi.NinjaTraderProxy</param>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        /// <param name="user">NinjaTrader.Cbi.User</param>
        public void SubscribeMarketDepthBP(NinjaTrader.Cbi.NinjaTraderProxy nt, NinjaTrader.Cbi.Instrument instrument, NinjaTrader.Cbi.User user);
        /// <summary>
        /// UnsubscribeFundamentalDataBP method.
        /// </summary>
        /// <param name="nt">NinjaTrader.Cbi.NinjaTraderProxy</param>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        /// <param name="user">NinjaTrader.Cbi.User</param>
        public void UnsubscribeFundamentalDataBP(NinjaTrader.Cbi.NinjaTraderProxy nt, NinjaTrader.Cbi.Instrument instrument, NinjaTrader.Cbi.User user);
        /// <summary>
        /// UnsubscribeMarketDataBP method.
        /// </summary>
        /// <param name="nt">NinjaTrader.Cbi.NinjaTraderProxy</param>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        /// <param name="user">NinjaTrader.Cbi.User</param>
        public void UnsubscribeMarketDataBP(NinjaTrader.Cbi.NinjaTraderProxy nt, NinjaTrader.Cbi.Instrument instrument, NinjaTrader.Cbi.User user);
        /// <summary>
        /// UnsubscribeMarketDepthBP method.
        /// </summary>
        /// <param name="nt">NinjaTrader.Cbi.NinjaTraderProxy</param>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        /// <param name="user">NinjaTrader.Cbi.User</param>
        public void UnsubscribeMarketDepthBP(NinjaTrader.Cbi.NinjaTraderProxy nt, NinjaTrader.Cbi.Instrument instrument, NinjaTrader.Cbi.User user);
        #endregion
    }
}
