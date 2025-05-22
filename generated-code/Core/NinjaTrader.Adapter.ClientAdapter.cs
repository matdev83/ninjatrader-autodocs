[Serializable]
[DataContract]
namespace NinjaTrader.Adapter
{
    public partial class ClientAdapter : NinjaTrader.Adapter.IAdapter, System.IDisposable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the ApisBP.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.List<NinjaTrader.Server.Api> ApisBP { get; set; }
        /// <summary>
        /// Gets or sets the Options.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.NTConnectOptions Options { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Cancel method.
        /// </summary>
        /// <param name="orders">NinjaTrader.Cbi.Order[]</param>
        public void Cancel(NinjaTrader.Cbi.Order[] orders)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Change method.
        /// </summary>
        /// <param name="orders">NinjaTrader.Cbi.Order[]</param>
        public void Change(NinjaTrader.Cbi.Order[] orders)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Connect method.
        /// </summary>
        /// <param name="connection">NinjaTrader.Cbi.IConnection</param>
        public void Connect(NinjaTrader.Cbi.IConnection connection)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Disconnect method.
        /// </summary>
        public void Disconnect()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// RequestHotlistNames method.
        /// </summary>
        /// <param name="callback">System.Action<System.String[], ErrorCode, string></param>
        public void RequestHotlistNames(System.Action<System.String[], ErrorCode, string> callback)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// RequestMarketReplay method.
        /// </summary>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        /// <param name="dateEst">System.DateTime</param>
        /// <param name="callback">System.Action<ErrorCode, string, object></param>
        /// <param name="progress">NinjaTrader.Core.IProgress</param>
        /// <param name="state">object</param>
        public void RequestMarketReplay(NinjaTrader.Cbi.Instrument instrument, System.DateTime dateEst, System.Action<ErrorCode, string, object> callback, NinjaTrader.Core.IProgress progress, object state)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ResolveInstrument method.
        /// </summary>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        /// <param name="callback">System.Action<NinjaTrader.Cbi.Instrument, ErrorCode, string></param>
        public void ResolveInstrument(NinjaTrader.Cbi.Instrument instrument, System.Action<NinjaTrader.Cbi.Instrument, ErrorCode, string> callback)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Submit method.
        /// </summary>
        /// <param name="orders">NinjaTrader.Cbi.Order[]</param>
        public void Submit(NinjaTrader.Cbi.Order[] orders)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SubscribeAccount method.
        /// </summary>
        /// <param name="account">NinjaTrader.Cbi.Account</param>
        public void SubscribeAccount(NinjaTrader.Cbi.Account account)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SubscribeFundamentalData method.
        /// </summary>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        /// <param name="callback">System.Action<FundamentalDataType, object></param>
        public void SubscribeFundamentalData(NinjaTrader.Cbi.Instrument instrument, System.Action<FundamentalDataType, object> callback)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SubscribeHotlist method.
        /// </summary>
        /// <param name="hotlist">NinjaTrader.Data.Hotlist</param>
        /// <param name="callback">System.Action</param>
        public void SubscribeHotlist(NinjaTrader.Data.Hotlist hotlist, System.Action callback)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SubscribeMarketData method.
        /// </summary>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        /// <param name="callback">System.Action<MarketDataType, double, long, System.DateTime, long></param>
        public void SubscribeMarketData(NinjaTrader.Cbi.Instrument instrument, System.Action<MarketDataType, double, long, System.DateTime, long> callback)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SubscribeMarketDepth method.
        /// </summary>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        /// <param name="callback">System.Action<int, string, Operation, MarketDataType, double, long, System.DateTime></param>
        public void SubscribeMarketDepth(NinjaTrader.Cbi.Instrument instrument, System.Action<int, string, Operation, MarketDataType, double, long, System.DateTime> callback)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SubscribeNews method.
        /// </summary>
        public void SubscribeNews()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// UnsubscribeAccount method.
        /// </summary>
        /// <param name="account">NinjaTrader.Cbi.Account</param>
        public void UnsubscribeAccount(NinjaTrader.Cbi.Account account)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// UnsubscribeFundamentalData method.
        /// </summary>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        public void UnsubscribeFundamentalData(NinjaTrader.Cbi.Instrument instrument)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// UnsubscribeHotlist method.
        /// </summary>
        /// <param name="hotlist">NinjaTrader.Data.Hotlist</param>
        public void UnsubscribeHotlist(NinjaTrader.Data.Hotlist hotlist)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// UnsubscribeMarketData method.
        /// </summary>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        public void UnsubscribeMarketData(NinjaTrader.Cbi.Instrument instrument)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// UnsubscribeMarketDepth method.
        /// </summary>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        public void UnsubscribeMarketDepth(NinjaTrader.Cbi.Instrument instrument)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// UnsubscribeNews method.
        /// </summary>
        public void UnsubscribeNews()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// UpdateSimulationAccount method.
        /// </summary>
        /// <param name="account">NinjaTrader.Cbi.Account</param>
        /// <param name="reset">bool</param>
        /// <param name="clearTradeData">bool</param>
        /// <returns>System.Threading.Tasks.Task<System.Tuple<ErrorCode, string>></returns>
        public System.Threading.Tasks.Task<System.Tuple<ErrorCode, string>> UpdateSimulationAccount(NinjaTrader.Cbi.Account account, bool reset, bool clearTradeData)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ChangePassword method.
        /// </summary>
        /// <param name="userName">string</param>
        /// <param name="oldPassword">string</param>
        /// <param name="newPassword">string</param>
        /// <returns>System.Threading.Tasks.Task<System.Tuple<ErrorCode, string>></returns>
        public System.Threading.Tasks.Task<System.Tuple<ErrorCode, string>> ChangePassword(string userName, string oldPassword, string newPassword)
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
        /// QueryEntities method.
        /// </summary>
        /// <param name="entityType">ApiCommand</param>
        /// <param name="queryProperty">string</param>
        /// <param name="queryValue">string</param>
        /// <param name="isEnabled">bool?</param>
        /// <returns>System.Threading.Tasks.Task<System.Xml.Linq.XDocument></returns>
        public System.Threading.Tasks.Task<System.Xml.Linq.XDocument> QueryEntities(ApiCommand entityType, string queryProperty, string queryValue, bool? isEnabled)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// QueryReport method.
        /// </summary>
        /// <param name="reportCommand">ReportCommand</param>
        /// <param name="criteria">System.Xml.Linq.XDocument</param>
        /// <returns>System.Threading.Tasks.Task<System.Xml.Linq.XDocument></returns>
        public System.Threading.Tasks.Task<System.Xml.Linq.XDocument> QueryReport(ReportCommand reportCommand, System.Xml.Linq.XDocument criteria)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// RegisterUser method.
        /// </summary>
        /// <param name="email">string</param>
        /// <param name="firstName">string</param>
        /// <param name="lastName">string</param>
        /// <param name="phone">string</param>
        /// <param name="country">string</param>
        /// <param name="useWebSockets">bool</param>
        /// <param name="system">string</param>
        /// <returns>System.Threading.Tasks.Task<System.Tuple<ErrorCode, string>></returns>
        public System.Threading.Tasks.Task<System.Tuple<ErrorCode, string>> RegisterUser(string email, string firstName, string lastName, string phone, string country, bool useWebSockets, string system)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// RequestBars method.
        /// </summary>
        /// <param name="bars">NinjaTrader.Data.IBars</param>
        /// <param name="callback">System.Action<NinjaTrader.Data.IBars, ErrorCode, string></param>
        /// <param name="progress">NinjaTrader.Core.IProgress</param>
        public void RequestBars(NinjaTrader.Data.IBars bars, System.Action<NinjaTrader.Data.IBars, ErrorCode, string> callback, NinjaTrader.Core.IProgress progress)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ResetPassword method.
        /// </summary>
        /// <param name="userName">string</param>
        /// <param name="useWebSockets">bool</param>
        /// <param name="system">string</param>
        /// <returns>System.Threading.Tasks.Task<System.Tuple<ErrorCode, string>></returns>
        public System.Threading.Tasks.Task<System.Tuple<ErrorCode, string>> ResetPassword(string userName, bool useWebSockets, string system)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SendEntities method.
        /// </summary>
        /// <param name="entities">System.Xml.Linq.XDocument</param>
        /// <returns>System.Threading.Tasks.Task<System.Tuple<ErrorCode, string>></returns>
        public System.Threading.Tasks.Task<System.Tuple<ErrorCode, string>> SendEntities(System.Xml.Linq.XDocument entities)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
