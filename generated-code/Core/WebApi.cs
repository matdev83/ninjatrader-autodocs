[Serializable]
[DataContract]
namespace NinjaTrader.CQG
{
    public partial class WebApi : IAdapter, IQueryMetaData, IQueryOptionChain, IDisposable
    {
        #region Properties
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
        /// Dispose method.
        /// </summary>
        public Void Dispose();
        /// <summary>
        /// FromInstrument method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        /// <returns>Task`1</returns>
        public Task<String> FromInstrument(Instrument instrument);
        /// <summary>
        /// QueryAllMasterInstrumentsAsync method.
        /// </summary>
        /// <param name="progress">IProgress</param>
        /// <returns>Task`1</returns>
        public Task<MasterInstrument[]> QueryAllMasterInstrumentsAsync(IProgress progress);
        /// <summary>
        /// QueryFuturesExpiriesAsync method.
        /// </summary>
        /// <param name="rolloverInstruments">MetaDataRolloverInstrument[]</param>
        /// <param name="progress">IProgress</param>
        /// <returns>Task</returns>
        public Task QueryFuturesExpiriesAsync(MetaDataRolloverInstrument[] rolloverInstruments, IProgress progress);
        /// <summary>
        /// QueryPastExecutionsAsync method.
        /// </summary>
        /// <param name="startDate">DateTime</param>
        /// <param name="endDate">DateTime</param>
        /// <param name="penalty">TimePenalty</param>
        /// <returns>Task`1</returns>
        public Task<List<Execution>> QueryPastExecutionsAsync(DateTime startDate, DateTime endDate, TimePenalty penalty);
        /// <summary>
        /// QueryPastOrdersAsync method.
        /// </summary>
        /// <param name="startDate">DateTime</param>
        /// <param name="endDate">DateTime</param>
        /// <param name="retry">Boolean</param>
        /// <param name="penalty">TimePenalty</param>
        /// <returns>Task`1</returns>
        public Task<List<Order>> QueryPastOrdersAsync(DateTime startDate, DateTime endDate, Boolean retry, TimePenalty penalty);
        /// <summary>
        /// QueryTradingHoursHolidaysAsync method.
        /// </summary>
        /// <param name="tradingHours">TradingHours[]</param>
        /// <param name="progress">IProgress</param>
        /// <returns>Task</returns>
        public Task QueryTradingHoursHolidaysAsync(TradingHours[] tradingHours, IProgress progress);
        /// <summary>
        /// QueryOptionChainAsync method.
        /// </summary>
        /// <param name="underlying">Instrument</param>
        /// <returns>Task`1</returns>
        public Task<InstrumentInfo[]> QueryOptionChainAsync(Instrument underlying);
        /// <summary>
        /// RequestBars method.
        /// </summary>
        /// <param name="bars">IBars</param>
        /// <param name="callback">Action`3</param>
        /// <param name="progress">IProgress</param>
        public Void RequestBars(IBars bars, Action<IBars, ErrorCode, String> callback, IProgress progress);
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
        /// ToDate method.
        /// </summary>
        /// <param name="milliSeconds">Int64</param>
        /// <returns>DateTime</returns>
        public DateTime ToDate(Int64 milliSeconds);
        /// <summary>
        /// ToDateTime method.
        /// </summary>
        /// <param name="timestamp">Timestamp</param>
        /// <returns>DateTime</returns>
        public DateTime ToDateTime(Timestamp timestamp);
        /// <summary>
        /// ToLong method.
        /// </summary>
        /// <param name="date">DateTime</param>
        /// <returns>Int64</returns>
        public Int64 ToLong(DateTime date);
        /// <summary>
        /// ToInstrument method.
        /// </summary>
        /// <param name="contractMetadata">ContractMetadata</param>
        /// <returns>Task`1</returns>
        public Task<Instrument> ToInstrument(ContractMetadata contractMetadata);
        /// <summary>
        /// ToTimestamp method.
        /// </summary>
        /// <param name="utcTime">DateTime</param>
        /// <returns>Timestamp</returns>
        public Timestamp ToTimestamp(DateTime utcTime);
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
        /// SubscribeFundamentalData method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        /// <param name="callback">Action`2</param>
        public Void SubscribeFundamentalData(Instrument instrument, Action<FundamentalDataType, Object> callback);
        /// <summary>
        /// UnsubscribeFundamentalData method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        public Void UnsubscribeFundamentalData(Instrument instrument);
        /// <summary>
        /// SubscribeAccount method.
        /// </summary>
        /// <param name="account">Account</param>
        public Void SubscribeAccount(Account account);
        /// <summary>
        /// UnsubscribeAccount method.
        /// </summary>
        /// <param name="account">Account</param>
        public Void UnsubscribeAccount(Account account);
        /// <summary>
        /// RequestHotlistNames method.
        /// </summary>
        /// <param name="callback">Action`3</param>
        public Void RequestHotlistNames(Action<String[], ErrorCode, String> callback);
        /// <summary>
        /// SubscribeHotlist method.
        /// </summary>
        /// <param name="hotlist">Hotlist</param>
        /// <param name="callback">Action</param>
        public Void SubscribeHotlist(Hotlist hotlist, Action callback);
        /// <summary>
        /// UnsubscribeHotlist method.
        /// </summary>
        /// <param name="hotlist">Hotlist</param>
        public Void UnsubscribeHotlist(Hotlist hotlist);
        /// <summary>
        /// SubscribeNews method.
        /// </summary>
        public Void SubscribeNews();
        /// <summary>
        /// UnsubscribeNews method.
        /// </summary>
        public Void UnsubscribeNews();
        #endregion
    }
}
