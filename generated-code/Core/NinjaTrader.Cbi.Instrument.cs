[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class Instrument : ISnapShotSerializable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the HistoricalData.
        /// </summary>
        [DataMember]
        public BarsBytes[] HistoricalData { get; set; }
        /// <summary>
        /// Gets or sets the PendingRateUpdates.
        /// </summary>
        [DataMember]
        public List<Execution> PendingRateUpdates { get; set; }
        /// <summary>
        /// Gets or sets the SubscriptionHelperInstance.
        /// </summary>
        [DataMember]
        public SubscriptionHelper SubscriptionHelperInstance { get; set; }
        /// <summary>
        /// Gets or sets the HasSeenMarketData.
        /// </summary>
        [DataMember]
        public Boolean HasSeenMarketData { get; set; }
        /// <summary>
        /// Gets or sets the Dispatcher.
        /// </summary>
        [DataMember]
        public Dispatcher Dispatcher { get; set; }
        /// <summary>
        /// Gets or sets the IsPersisted.
        /// </summary>
        [DataMember]
        public Boolean IsPersisted { get; set; }
        /// <summary>
        /// Gets or sets the IsRMSOnly.
        /// </summary>
        [DataMember]
        public Boolean IsRMSOnly { get; set; }
        /// <summary>
        /// Gets or sets the All.
        /// </summary>
        [DataMember]
        public Collection<Instrument> All { get; set; }
        /// <summary>
        /// Gets or sets the Exchange.
        /// </summary>
        [DataMember]
        public Exchange Exchange { get; set; }
        /// <summary>
        /// Gets or sets the Expiry.
        /// </summary>
        [DataMember]
        public DateTime Expiry { get; set; }
        /// <summary>
        /// Gets or sets the FullName.
        /// </summary>
        [DataMember]
        public String FullName { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalData.
        /// </summary>
        [DataMember]
        public FundamentalData FundamentalData { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public Int64 Id { get; set; }
        /// <summary>
        /// Gets or sets the IndexPrefix.
        /// </summary>
        [DataMember]
        public Char IndexPrefix { get; set; }
        /// <summary>
        /// Gets or sets the IsAutoSubscribed.
        /// </summary>
        [DataMember]
        public Boolean IsAutoSubscribed { get; set; }
        /// <summary>
        /// Gets or sets the MarketData.
        /// </summary>
        [DataMember]
        public MarketData MarketData { get; set; }
        /// <summary>
        /// Gets or sets the MarketDepth.
        /// </summary>
        [DataMember]
        public MarketDepth<MarketDepthRow> MarketDepth { get; set; }
        /// <summary>
        /// Gets or sets the MasterInstrument.
        /// </summary>
        [DataMember]
        public MasterInstrument MasterInstrument { get; set; }
        /// <summary>
        /// Gets or sets the OptionRight.
        /// </summary>
        [DataMember]
        public OptionRight OptionRight { get; set; }
        /// <summary>
        /// Gets or sets the StrikePrice.
        /// </summary>
        [DataMember]
        public Double StrikePrice { get; set; }
        /// <summary>
        /// Gets or sets the SyncFundamentalData.
        /// </summary>
        [DataMember]
        public Object SyncFundamentalData { get; set; }
        /// <summary>
        /// Gets or sets the SyncMarketData.
        /// </summary>
        [DataMember]
        public Object SyncMarketData { get; set; }
        /// <summary>
        /// Gets or sets the SyncMarketDepth.
        /// </summary>
        [DataMember]
        public Object SyncMarketDepth { get; set; }
        /// <summary>
        /// Gets or sets the UnderlyingInstrumentType.
        /// </summary>
        [DataMember]
        public InstrumentType UnderlyingInstrumentType { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// BPRealtimeDataThread method.
        /// </summary>
        /// <param name="e">IInstrumentProvider</param>
        public Void BPRealtimeDataThread(IInstrumentProvider e);
        /// <summary>
        /// DbAdd method.
        /// </summary>
        /// <param name="persist">Boolean</param>
        public Void DbAdd(Boolean persist);
        /// <summary>
        /// DbRemove method.
        /// </summary>
        public Void DbRemove();
        /// <summary>
        /// DbRemoveByMasterInstrumentID method.
        /// </summary>
        /// <param name="id">Int64</param>
        public Void DbRemoveByMasterInstrumentID(Int64 id);
        /// <summary>
        /// DbUpdateCache method.
        /// </summary>
        public Void DbUpdateCache();
        /// <summary>
        /// GetDataConnection method.
        /// </summary>
        /// <param name="feature">Feature</param>
        /// <param name="includeConnectionLost">Boolean</param>
        /// <returns>Connection</returns>
        public Connection GetDataConnection(Feature feature, Boolean includeConnectionLost);
        /// <summary>
        /// GetFakeOptionInstrument method.
        /// </summary>
        /// <returns>Instrument</returns>
        public Instrument GetFakeOptionInstrument();
        /// <summary>
        /// GetInstrumentFuzzy method.
        /// </summary>
        /// <param name="instrumentName">String</param>
        /// <returns>Instrument</returns>
        public Instrument GetInstrumentFuzzy(String instrumentName);
        /// <summary>
        /// GetMarketDataConnection method.
        /// </summary>
        /// <returns>Connection</returns>
        public Connection GetMarketDataConnection();
        /// <summary>
        /// GetRolloverOffset method.
        /// </summary>
        /// <param name="toInstrument">Instrument</param>
        /// <returns>Double</returns>
        public Double GetRolloverOffset(Instrument toInstrument);
        /// <summary>
        /// IsInstrumentThread method.
        /// </summary>
        /// <param name="thread">Thread</param>
        /// <returns>Boolean</returns>
        public Boolean IsInstrumentThread(Thread thread);
        /// <summary>
        /// RecordingBarsDataFilename method.
        /// </summary>
        /// <param name="barsPeriod">BarsPeriod</param>
        /// <returns>String</returns>
        public String RecordingBarsDataFilename(BarsPeriod barsPeriod);
        /// <summary>
        /// RequestBars method.
        /// </summary>
        /// <param name="replayBars">Bars</param>
        /// <param name="barsPeriod">BarsPeriod</param>
        /// <param name="from">DateTime</param>
        /// <param name="to">DateTime</param>
        /// <param name="tradingHours">TradingHours</param>
        /// <param name="isDividendAdjusted">Boolean</param>
        /// <param name="isSplitAdjusted">Boolean</param>
        /// <param name="isRolloverAdjusted">Boolean</param>
        /// <param name="isTickReplay">Boolean</param>
        /// <param name="isResetOnNewTradingDay">Boolean</param>
        /// <param name="isRequestForLiveSession">Boolean</param>
        /// <param name="lookupPolicy">LookupPolicies</param>
        /// <param name="requestedInstrument">Instrument</param>
        /// <param name="isSubscribed">Boolean</param>
        /// <param name="calculateRollOvers">Boolean</param>
        /// <param name="addToRepositorySeries">Boolean</param>
        /// <param name="replayToDate">DateTime</param>
        /// <param name="progress">IProgress</param>
        /// <param name="doSubscribeMarketData">Boolean</param>
        /// <param name="lastTradingDayOfContract">DateTime</param>
        /// <param name="callback">Action`4</param>
        /// <param name="state">Object</param>
        public Void RequestBars(Bars replayBars, BarsPeriod barsPeriod, DateTime from, DateTime to, TradingHours tradingHours, Boolean isDividendAdjusted, Boolean isSplitAdjusted, Boolean isRolloverAdjusted, Boolean isTickReplay, Boolean isResetOnNewTradingDay, Boolean isRequestForLiveSession, LookupPolicies lookupPolicy, Instrument requestedInstrument, Boolean isSubscribed, Boolean calculateRollOvers, Boolean addToRepositorySeries, DateTime replayToDate, IProgress progress, Boolean doSubscribeMarketData, DateTime lastTradingDayOfContract, Action<Bars, ErrorCode, String, Object> callback, Object state);
        /// <summary>
        /// SnapShotPersist method.
        /// </summary>
        /// <param name="updateVersion">Boolean</param>
        public Void SnapShotPersist(Boolean updateVersion);
        /// <summary>
        /// UpdateExternCache method.
        /// </summary>
        public Void UpdateExternCache();
        /// <summary>
        /// UpdateMarketDepth method.
        /// </summary>
        /// <param name="mmId">String</param>
        /// <param name="dataType">MarketDataType</param>
        /// <param name="askPrice">Double</param>
        /// <param name="askSize">Int64</param>
        /// <param name="bidPrice">Double</param>
        /// <param name="bidSize">Int64</param>
        /// <param name="time">DateTime</param>
        /// <param name="callback">Action`7</param>
        public Void UpdateMarketDepth(String mmId, MarketDataType dataType, Double askPrice, Int64 askSize, Double bidPrice, Int64 bidSize, DateTime time, Action<Int32, String, Operation, MarketDataType, Double, Int64, DateTime> callback);
        /// <summary>
        /// DbGet method.
        /// </summary>
        /// <param name="id">Int64</param>
        /// <param name="forceDbQuery">Boolean</param>
        /// <returns>Instrument</returns>
        public Instrument DbGet(Int64 id, Boolean forceDbQuery);
        /// <summary>
        /// DbGet method.
        /// </summary>
        /// <param name="name">String</param>
        /// <param name="instrumentType">InstrumentType</param>
        /// <param name="exchange">Exchange</param>
        /// <param name="expiry">DateTime</param>
        /// <param name="strikePrice">Double</param>
        /// <param name="right">OptionRight</param>
        /// <param name="forceDbQuery">Boolean</param>
        /// <returns>Instrument</returns>
        public Instrument DbGet(String name, InstrumentType instrumentType, Exchange exchange, DateTime expiry, Double strikePrice, OptionRight right, Boolean forceDbQuery);
        /// <summary>
        /// DbGet method.
        /// </summary>
        /// <param name="name">String</param>
        /// <param name="instrumentType">InstrumentType</param>
        /// <param name="exchange">Exchange</param>
        /// <param name="expiry">DateTime</param>
        /// <param name="strikePrice">Double</param>
        /// <param name="right">OptionRight</param>
        /// <param name="forceDbQuery">Boolean</param>
        /// <param name="underlyingInstrumentType">InstrumentType</param>
        /// <returns>Instrument</returns>
        public Instrument DbGet(String name, InstrumentType instrumentType, Exchange exchange, DateTime expiry, Double strikePrice, OptionRight right, Boolean forceDbQuery, InstrumentType underlyingInstrumentType);
        /// <summary>
        /// GetFullName method.
        /// </summary>
        /// <param name="symbologySetting">UserSymbologySetting</param>
        /// <param name="legacy">Boolean</param>
        /// <returns>String</returns>
        public String GetFullName(UserSymbologySetting symbologySetting, Boolean legacy);
        /// <summary>
        /// GetConversionRate method.
        /// </summary>
        /// <param name="marketDataType">MarketDataType</param>
        /// <param name="denomination">Currency</param>
        /// <param name="tryAgainLater">Boolean&</param>
        /// <returns>Double</returns>
        public Double GetConversionRate(MarketDataType marketDataType, Currency denomination, Boolean& tryAgainLater);
        /// <summary>
        /// GetInstrument method.
        /// </summary>
        /// <param name="instrumentName">String</param>
        /// <param name="create">Boolean</param>
        /// <returns>Instrument</returns>
        public Instrument GetInstrument(String instrumentName, Boolean create);
        /// <summary>
        /// GetInstrumentType method.
        /// </summary>
        /// <param name="instrumentName">String</param>
        /// <returns>InstrumentType</returns>
        public InstrumentType GetInstrumentType(String instrumentName);
        /// <summary>
        /// IsInstrumentFuture method.
        /// </summary>
        /// <param name="instrumentName">String</param>
        /// <returns>Boolean</returns>
        public Boolean IsInstrumentFuture(String instrumentName);
        /// <summary>
        /// ToInstrumentInfo method.
        /// </summary>
        /// <param name="exchange">Nullable`1</param>
        /// <returns>InstrumentInfo</returns>
        public InstrumentInfo ToInstrumentInfo(Nullable<Exchange> exchange);
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>String</returns>
        public String ToString();
        /// <summary>
        /// UpdateMarketDepth method.
        /// </summary>
        /// <param name="dataType">MarketDataType</param>
        /// <param name="price">Double</param>
        /// <param name="volume">Int64</param>
        /// <param name="operation">Operation</param>
        /// <param name="time">DateTime</param>
        /// <param name="callback">Action`7</param>
        public Void UpdateMarketDepth(MarketDataType dataType, Double price, Int64 volume, Operation operation, DateTime time, Action<Int32, String, Operation, MarketDataType, Double, Int64, DateTime> callback);
        #endregion
    }
}
