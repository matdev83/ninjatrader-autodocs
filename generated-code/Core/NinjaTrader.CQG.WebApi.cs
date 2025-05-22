[Serializable]
[DataContract]
namespace NinjaTrader.CQG
{
    public partial class WebApi : NinjaTrader.Adapter.IAdapter, NinjaTrader.Adapter.IQueryMetaData, NinjaTrader.Adapter.IQueryOptionChain, System.IDisposable
    {
        #region Properties
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
        /// Dispose method.
        /// </summary>
        public void Dispose()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// FromInstrument method.
        /// </summary>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        /// <returns>System.Threading.Tasks.Task<string></returns>
        public System.Threading.Tasks.Task<string> FromInstrument(NinjaTrader.Cbi.Instrument instrument)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// QueryAllMasterInstrumentsAsync method.
        /// </summary>
        /// <param name="progress">NinjaTrader.Core.IProgress</param>
        /// <returns>System.Threading.Tasks.Task<NinjaTrader.Cbi.MasterInstrument[]></returns>
        public System.Threading.Tasks.Task<NinjaTrader.Cbi.MasterInstrument[]> QueryAllMasterInstrumentsAsync(NinjaTrader.Core.IProgress progress)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// QueryFuturesExpiriesAsync method.
        /// </summary>
        /// <param name="rolloverInstruments">NinjaTrader.Cbi.MetaDataRolloverInstrument[]</param>
        /// <param name="progress">NinjaTrader.Core.IProgress</param>
        /// <returns>System.Threading.Tasks.Task</returns>
        public System.Threading.Tasks.Task QueryFuturesExpiriesAsync(NinjaTrader.Cbi.MetaDataRolloverInstrument[] rolloverInstruments, NinjaTrader.Core.IProgress progress)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// QueryPastExecutionsAsync method.
        /// </summary>
        /// <param name="startDate">System.DateTime</param>
        /// <param name="endDate">System.DateTime</param>
        /// <param name="penalty">NinjaTrader.Cbi.TimePenalty</param>
        /// <returns>System.Threading.Tasks.Task<System.Collections.Generic.List<NinjaTrader.Cbi.Execution>></returns>
        public System.Threading.Tasks.Task<System.Collections.Generic.List<NinjaTrader.Cbi.Execution>> QueryPastExecutionsAsync(System.DateTime startDate, System.DateTime endDate, NinjaTrader.Cbi.TimePenalty penalty)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// QueryPastOrdersAsync method.
        /// </summary>
        /// <param name="startDate">System.DateTime</param>
        /// <param name="endDate">System.DateTime</param>
        /// <param name="retry">bool</param>
        /// <param name="penalty">NinjaTrader.Cbi.TimePenalty</param>
        /// <returns>System.Threading.Tasks.Task<System.Collections.Generic.List<NinjaTrader.Cbi.Order>></returns>
        public System.Threading.Tasks.Task<System.Collections.Generic.List<NinjaTrader.Cbi.Order>> QueryPastOrdersAsync(System.DateTime startDate, System.DateTime endDate, bool retry, NinjaTrader.Cbi.TimePenalty penalty)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// QueryTradingHoursHolidaysAsync method.
        /// </summary>
        /// <param name="tradingHours">NinjaTrader.Data.TradingHours[]</param>
        /// <param name="progress">NinjaTrader.Core.IProgress</param>
        /// <returns>System.Threading.Tasks.Task</returns>
        public System.Threading.Tasks.Task QueryTradingHoursHolidaysAsync(NinjaTrader.Data.TradingHours[] tradingHours, NinjaTrader.Core.IProgress progress)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// QueryOptionChainAsync method.
        /// </summary>
        /// <param name="underlying">NinjaTrader.Cbi.Instrument</param>
        /// <returns>System.Threading.Tasks.Task<NinjaTrader.Adapter.InstrumentInfo[]></returns>
        public System.Threading.Tasks.Task<NinjaTrader.Adapter.InstrumentInfo[]> QueryOptionChainAsync(NinjaTrader.Cbi.Instrument underlying)
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
        /// ToDate method.
        /// </summary>
        /// <param name="milliSeconds">long</param>
        /// <returns>System.DateTime</returns>
        public System.DateTime ToDate(long milliSeconds)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ToDateTime method.
        /// </summary>
        /// <param name="timestamp">Google.Protobuf.Timestamp</param>
        /// <returns>System.DateTime</returns>
        public System.DateTime ToDateTime(Google.Protobuf.Timestamp timestamp)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ToLong method.
        /// </summary>
        /// <param name="date">System.DateTime</param>
        /// <returns>long</returns>
        public long ToLong(System.DateTime date)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ToInstrument method.
        /// </summary>
        /// <param name="contractMetadata">NinjaTrader.CQG.ProtoBuf.ContractMetadata</param>
        /// <returns>System.Threading.Tasks.Task<NinjaTrader.Cbi.Instrument></returns>
        public System.Threading.Tasks.Task<NinjaTrader.Cbi.Instrument> ToInstrument(NinjaTrader.CQG.ProtoBuf.ContractMetadata contractMetadata)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ToTimestamp method.
        /// </summary>
        /// <param name="utcTime">System.DateTime</param>
        /// <returns>Google.Protobuf.Timestamp</returns>
        public Google.Protobuf.Timestamp ToTimestamp(System.DateTime utcTime)
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
        /// SubscribeFundamentalData method.
        /// </summary>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        /// <param name="callback">System.Action<FundamentalDataType, object></param>
        public void SubscribeFundamentalData(NinjaTrader.Cbi.Instrument instrument, System.Action<FundamentalDataType, object> callback)
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
        /// SubscribeAccount method.
        /// </summary>
        /// <param name="account">NinjaTrader.Cbi.Account</param>
        public void SubscribeAccount(NinjaTrader.Cbi.Account account)
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
        /// RequestHotlistNames method.
        /// </summary>
        /// <param name="callback">System.Action<System.String[], ErrorCode, string></param>
        public void RequestHotlistNames(System.Action<System.String[], ErrorCode, string> callback)
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
        /// UnsubscribeHotlist method.
        /// </summary>
        /// <param name="hotlist">NinjaTrader.Data.Hotlist</param>
        public void UnsubscribeHotlist(NinjaTrader.Data.Hotlist hotlist)
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
        /// UnsubscribeNews method.
        /// </summary>
        public void UnsubscribeNews()
        {
            // Method implementation goes here
        }
        #endregion
    }
}
