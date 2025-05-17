[Serializable]
[DataContract]
namespace NinjaTrader.Adapter
{
    public partial class ClientAdapter : IAdapter, IDisposable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the ApisBP.
        /// </summary>
        [DataMember]
        public List<Api> ApisBP { get; set; }
        /// <summary>
        /// Gets or sets the Options.
        /// </summary>
        [DataMember]
        public NTConnectOptions Options { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Cancel method.
        /// </summary>
        /// <param name="orders">Order[]</param>
        public Void Cancel(Order[] orders);
        /// <summary>
        /// Change method.
        /// </summary>
        /// <param name="orders">Order[]</param>
        public Void Change(Order[] orders);
        /// <summary>
        /// Connect method.
        /// </summary>
        /// <param name="connection">IConnection</param>
        public Void Connect(IConnection connection);
        /// <summary>
        /// Disconnect method.
        /// </summary>
        public Void Disconnect();
        /// <summary>
        /// RequestHotlistNames method.
        /// </summary>
        /// <param name="callback">Action`3</param>
        public Void RequestHotlistNames(Action<String[], ErrorCode, String> callback);
        /// <summary>
        /// RequestMarketReplay method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        /// <param name="dateEst">DateTime</param>
        /// <param name="callback">Action`3</param>
        /// <param name="progress">IProgress</param>
        /// <param name="state">Object</param>
        public Void RequestMarketReplay(Instrument instrument, DateTime dateEst, Action<ErrorCode, String, Object> callback, IProgress progress, Object state);
        /// <summary>
        /// ResolveInstrument method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        /// <param name="callback">Action`3</param>
        public Void ResolveInstrument(Instrument instrument, Action<Instrument, ErrorCode, String> callback);
        /// <summary>
        /// Submit method.
        /// </summary>
        /// <param name="orders">Order[]</param>
        public Void Submit(Order[] orders);
        /// <summary>
        /// SubscribeAccount method.
        /// </summary>
        /// <param name="account">Account</param>
        public Void SubscribeAccount(Account account);
        /// <summary>
        /// SubscribeFundamentalData method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        /// <param name="callback">Action`2</param>
        public Void SubscribeFundamentalData(Instrument instrument, Action<FundamentalDataType, Object> callback);
        /// <summary>
        /// SubscribeHotlist method.
        /// </summary>
        /// <param name="hotlist">Hotlist</param>
        /// <param name="callback">Action</param>
        public Void SubscribeHotlist(Hotlist hotlist, Action callback);
        /// <summary>
        /// SubscribeMarketData method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        /// <param name="callback">Action`5</param>
        public Void SubscribeMarketData(Instrument instrument, Action<MarketDataType, Double, Int64, DateTime, Int64> callback);
        /// <summary>
        /// SubscribeMarketDepth method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        /// <param name="callback">Action`7</param>
        public Void SubscribeMarketDepth(Instrument instrument, Action<Int32, String, Operation, MarketDataType, Double, Int64, DateTime> callback);
        /// <summary>
        /// SubscribeNews method.
        /// </summary>
        public Void SubscribeNews();
        /// <summary>
        /// UnsubscribeAccount method.
        /// </summary>
        /// <param name="account">Account</param>
        public Void UnsubscribeAccount(Account account);
        /// <summary>
        /// UnsubscribeFundamentalData method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        public Void UnsubscribeFundamentalData(Instrument instrument);
        /// <summary>
        /// UnsubscribeHotlist method.
        /// </summary>
        /// <param name="hotlist">Hotlist</param>
        public Void UnsubscribeHotlist(Hotlist hotlist);
        /// <summary>
        /// UnsubscribeMarketData method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        public Void UnsubscribeMarketData(Instrument instrument);
        /// <summary>
        /// UnsubscribeMarketDepth method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        public Void UnsubscribeMarketDepth(Instrument instrument);
        /// <summary>
        /// UnsubscribeNews method.
        /// </summary>
        public Void UnsubscribeNews();
        /// <summary>
        /// UpdateSimulationAccount method.
        /// </summary>
        /// <param name="account">Account</param>
        /// <param name="reset">Boolean</param>
        /// <param name="clearTradeData">Boolean</param>
        /// <returns>Task`1</returns>
        public Task<Tuple<ErrorCode, String>> UpdateSimulationAccount(Account account, Boolean reset, Boolean clearTradeData);
        /// <summary>
        /// ChangePassword method.
        /// </summary>
        /// <param name="userName">String</param>
        /// <param name="oldPassword">String</param>
        /// <param name="newPassword">String</param>
        /// <returns>Task`1</returns>
        public Task<Tuple<ErrorCode, String>> ChangePassword(String userName, String oldPassword, String newPassword);
        /// <summary>
        /// Dispose method.
        /// </summary>
        public Void Dispose();
        /// <summary>
        /// QueryEntities method.
        /// </summary>
        /// <param name="entityType">ApiCommand</param>
        /// <param name="queryProperty">String</param>
        /// <param name="queryValue">String</param>
        /// <param name="isEnabled">Nullable`1</param>
        /// <returns>Task`1</returns>
        public Task<XDocument> QueryEntities(ApiCommand entityType, String queryProperty, String queryValue, Nullable<Boolean> isEnabled);
        /// <summary>
        /// QueryReport method.
        /// </summary>
        /// <param name="reportCommand">ReportCommand</param>
        /// <param name="criteria">XDocument</param>
        /// <returns>Task`1</returns>
        public Task<XDocument> QueryReport(ReportCommand reportCommand, XDocument criteria);
        /// <summary>
        /// RegisterUser method.
        /// </summary>
        /// <param name="email">String</param>
        /// <param name="firstName">String</param>
        /// <param name="lastName">String</param>
        /// <param name="phone">String</param>
        /// <param name="country">String</param>
        /// <param name="useWebSockets">Boolean</param>
        /// <param name="system">String</param>
        /// <returns>Task`1</returns>
        public Task<Tuple<ErrorCode, String>> RegisterUser(String email, String firstName, String lastName, String phone, String country, Boolean useWebSockets, String system);
        /// <summary>
        /// RequestBars method.
        /// </summary>
        /// <param name="bars">IBars</param>
        /// <param name="callback">Action`3</param>
        /// <param name="progress">IProgress</param>
        public Void RequestBars(IBars bars, Action<IBars, ErrorCode, String> callback, IProgress progress);
        /// <summary>
        /// ResetPassword method.
        /// </summary>
        /// <param name="userName">String</param>
        /// <param name="useWebSockets">Boolean</param>
        /// <param name="system">String</param>
        /// <returns>Task`1</returns>
        public Task<Tuple<ErrorCode, String>> ResetPassword(String userName, Boolean useWebSockets, String system);
        /// <summary>
        /// SendEntities method.
        /// </summary>
        /// <param name="entities">XDocument</param>
        /// <returns>Task`1</returns>
        public Task<Tuple<ErrorCode, String>> SendEntities(XDocument entities);
        #endregion
    }
}
