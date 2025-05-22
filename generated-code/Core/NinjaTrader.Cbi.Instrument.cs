[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class Instrument : NinjaTrader.Cbi.ISnapShotSerializable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the HistoricalData.
        /// </summary>
        [DataMember]
        public NinjaTrader.Data.BarsBytes[] HistoricalData { get; set; }
        /// <summary>
        /// Gets or sets the PendingRateUpdates.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.List<NinjaTrader.Cbi.Execution> PendingRateUpdates { get; set; }
        /// <summary>
        /// Gets or sets the SubscriptionHelperInstance.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Instrument.SubscriptionHelper SubscriptionHelperInstance { get; set; }
        /// <summary>
        /// Gets or sets the HasSeenMarketData.
        /// </summary>
        [DataMember]
        public bool HasSeenMarketData { get; set; }
        /// <summary>
        /// Gets or sets the Dispatcher.
        /// </summary>
        [DataMember]
        public System.Windows.Threading.Dispatcher Dispatcher { get; set; }
        /// <summary>
        /// Gets or sets the IsPersisted.
        /// </summary>
        [DataMember]
        public bool IsPersisted { get; set; }
        /// <summary>
        /// Gets or sets the IsRMSOnly.
        /// </summary>
        [DataMember]
        public bool IsRMSOnly { get; set; }
        /// <summary>
        /// Gets or sets the All.
        /// </summary>
        [DataMember]
        public System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Instrument> All { get; set; }
        /// <summary>
        /// Gets or sets the Exchange.
        /// </summary>
        [DataMember]
        public Exchange Exchange { get; set; }
        /// <summary>
        /// Gets or sets the Expiry.
        /// </summary>
        [DataMember]
        public System.DateTime Expiry { get; set; }
        /// <summary>
        /// Gets or sets the FullName.
        /// </summary>
        [DataMember]
        public string FullName { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalData.
        /// </summary>
        [DataMember]
        public NinjaTrader.Data.FundamentalData FundamentalData { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public long Id { get; set; }
        /// <summary>
        /// Gets or sets the IndexPrefix.
        /// </summary>
        [DataMember]
        public char IndexPrefix { get; set; }
        /// <summary>
        /// Gets or sets the IsAutoSubscribed.
        /// </summary>
        [DataMember]
        public bool IsAutoSubscribed { get; set; }
        /// <summary>
        /// Gets or sets the MarketData.
        /// </summary>
        [DataMember]
        public NinjaTrader.Data.MarketData MarketData { get; set; }
        /// <summary>
        /// Gets or sets the MarketDepth.
        /// </summary>
        [DataMember]
        public NinjaTrader.Data.MarketDepth<NinjaTrader.Data.MarketDepthRow> MarketDepth { get; set; }
        /// <summary>
        /// Gets or sets the MasterInstrument.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.MasterInstrument MasterInstrument { get; set; }
        /// <summary>
        /// Gets or sets the OptionRight.
        /// </summary>
        [DataMember]
        public OptionRight OptionRight { get; set; }
        /// <summary>
        /// Gets or sets the StrikePrice.
        /// </summary>
        [DataMember]
        public double StrikePrice { get; set; }
        /// <summary>
        /// Gets or sets the SyncFundamentalData.
        /// </summary>
        [DataMember]
        public object SyncFundamentalData { get; set; }
        /// <summary>
        /// Gets or sets the SyncMarketData.
        /// </summary>
        [DataMember]
        public object SyncMarketData { get; set; }
        /// <summary>
        /// Gets or sets the SyncMarketDepth.
        /// </summary>
        [DataMember]
        public object SyncMarketDepth { get; set; }
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
        /// <param name="e">NinjaTrader.Data.IInstrumentProvider</param>
        public void BPRealtimeDataThread(NinjaTrader.Data.IInstrumentProvider e)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DbAdd method.
        /// </summary>
        /// <param name="persist">bool</param>
        public void DbAdd(bool persist)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DbRemove method.
        /// </summary>
        public void DbRemove()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DbRemoveByMasterInstrumentID method.
        /// </summary>
        /// <param name="id">long</param>
        public void DbRemoveByMasterInstrumentID(long id)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DbUpdateCache method.
        /// </summary>
        public void DbUpdateCache()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetDataConnection method.
        /// </summary>
        /// <param name="feature">Feature</param>
        /// <param name="includeConnectionLost">bool</param>
        /// <returns>NinjaTrader.Cbi.Connection</returns>
        public NinjaTrader.Cbi.Connection GetDataConnection(Feature feature, bool includeConnectionLost)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetFakeOptionInstrument method.
        /// </summary>
        /// <returns>NinjaTrader.Cbi.Instrument</returns>
        public NinjaTrader.Cbi.Instrument GetFakeOptionInstrument()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetInstrumentFuzzy method.
        /// </summary>
        /// <param name="instrumentName">string</param>
        /// <returns>NinjaTrader.Cbi.Instrument</returns>
        public NinjaTrader.Cbi.Instrument GetInstrumentFuzzy(string instrumentName)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetMarketDataConnection method.
        /// </summary>
        /// <returns>NinjaTrader.Cbi.Connection</returns>
        public NinjaTrader.Cbi.Connection GetMarketDataConnection()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetRolloverOffset method.
        /// </summary>
        /// <param name="toInstrument">NinjaTrader.Cbi.Instrument</param>
        /// <returns>double</returns>
        public double GetRolloverOffset(NinjaTrader.Cbi.Instrument toInstrument)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// IsInstrumentThread method.
        /// </summary>
        /// <param name="thread">System.Threading.Thread</param>
        /// <returns>bool</returns>
        public bool IsInstrumentThread(System.Threading.Thread thread)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// RecordingBarsDataFilename method.
        /// </summary>
        /// <param name="barsPeriod">NinjaTrader.Data.BarsPeriod</param>
        /// <returns>string</returns>
        public string RecordingBarsDataFilename(NinjaTrader.Data.BarsPeriod barsPeriod)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// RequestBars method.
        /// </summary>
        /// <param name="replayBars">NinjaTrader.Data.Bars</param>
        /// <param name="barsPeriod">NinjaTrader.Data.BarsPeriod</param>
        /// <param name="from">System.DateTime</param>
        /// <param name="to">System.DateTime</param>
        /// <param name="tradingHours">NinjaTrader.Data.TradingHours</param>
        /// <param name="isDividendAdjusted">bool</param>
        /// <param name="isSplitAdjusted">bool</param>
        /// <param name="isRolloverAdjusted">bool</param>
        /// <param name="isTickReplay">bool</param>
        /// <param name="isResetOnNewTradingDay">bool</param>
        /// <param name="isRequestForLiveSession">bool</param>
        /// <param name="lookupPolicy">LookupPolicies</param>
        /// <param name="requestedInstrument">NinjaTrader.Cbi.Instrument</param>
        /// <param name="isSubscribed">bool</param>
        /// <param name="calculateRollOvers">bool</param>
        /// <param name="addToRepositorySeries">bool</param>
        /// <param name="replayToDate">System.DateTime</param>
        /// <param name="progress">NinjaTrader.Core.IProgress</param>
        /// <param name="doSubscribeMarketData">bool</param>
        /// <param name="lastTradingDayOfContract">System.DateTime</param>
        /// <param name="callback">System.Action<NinjaTrader.Data.Bars, ErrorCode, string, object></param>
        /// <param name="state">object</param>
        public void RequestBars(NinjaTrader.Data.Bars replayBars, NinjaTrader.Data.BarsPeriod barsPeriod, System.DateTime from, System.DateTime to, NinjaTrader.Data.TradingHours tradingHours, bool isDividendAdjusted, bool isSplitAdjusted, bool isRolloverAdjusted, bool isTickReplay, bool isResetOnNewTradingDay, bool isRequestForLiveSession, LookupPolicies lookupPolicy, NinjaTrader.Cbi.Instrument requestedInstrument, bool isSubscribed, bool calculateRollOvers, bool addToRepositorySeries, System.DateTime replayToDate, NinjaTrader.Core.IProgress progress, bool doSubscribeMarketData, System.DateTime lastTradingDayOfContract, System.Action<NinjaTrader.Data.Bars, ErrorCode, string, object> callback, object state)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SnapShotPersist method.
        /// </summary>
        /// <param name="updateVersion">bool</param>
        public void SnapShotPersist(bool updateVersion)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// UpdateExternCache method.
        /// </summary>
        public void UpdateExternCache()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// UpdateMarketDepth method.
        /// </summary>
        /// <param name="mmId">string</param>
        /// <param name="dataType">MarketDataType</param>
        /// <param name="askPrice">double</param>
        /// <param name="askSize">long</param>
        /// <param name="bidPrice">double</param>
        /// <param name="bidSize">long</param>
        /// <param name="time">System.DateTime</param>
        /// <param name="callback">System.Action<int, string, Operation, MarketDataType, double, long, System.DateTime></param>
        public void UpdateMarketDepth(string mmId, MarketDataType dataType, double askPrice, long askSize, double bidPrice, long bidSize, System.DateTime time, System.Action<int, string, Operation, MarketDataType, double, long, System.DateTime> callback)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DbGet method.
        /// </summary>
        /// <param name="id">long</param>
        /// <param name="forceDbQuery">bool</param>
        /// <returns>NinjaTrader.Cbi.Instrument</returns>
        public NinjaTrader.Cbi.Instrument DbGet(long id, bool forceDbQuery)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DbGet method.
        /// </summary>
        /// <param name="name">string</param>
        /// <param name="instrumentType">InstrumentType</param>
        /// <param name="exchange">Exchange</param>
        /// <param name="expiry">System.DateTime</param>
        /// <param name="strikePrice">double</param>
        /// <param name="right">OptionRight</param>
        /// <param name="forceDbQuery">bool</param>
        /// <returns>NinjaTrader.Cbi.Instrument</returns>
        public NinjaTrader.Cbi.Instrument DbGet(string name, InstrumentType instrumentType, Exchange exchange, System.DateTime expiry, double strikePrice, OptionRight right, bool forceDbQuery)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DbGet method.
        /// </summary>
        /// <param name="name">string</param>
        /// <param name="instrumentType">InstrumentType</param>
        /// <param name="exchange">Exchange</param>
        /// <param name="expiry">System.DateTime</param>
        /// <param name="strikePrice">double</param>
        /// <param name="right">OptionRight</param>
        /// <param name="forceDbQuery">bool</param>
        /// <param name="underlyingInstrumentType">InstrumentType</param>
        /// <returns>NinjaTrader.Cbi.Instrument</returns>
        public NinjaTrader.Cbi.Instrument DbGet(string name, InstrumentType instrumentType, Exchange exchange, System.DateTime expiry, double strikePrice, OptionRight right, bool forceDbQuery, InstrumentType underlyingInstrumentType)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetFullName method.
        /// </summary>
        /// <param name="symbologySetting">UserSymbologySetting</param>
        /// <param name="legacy">bool</param>
        /// <returns>string</returns>
        public string GetFullName(UserSymbologySetting symbologySetting, bool legacy)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetConversionRate method.
        /// </summary>
        /// <param name="marketDataType">MarketDataType</param>
        /// <param name="denomination">Currency</param>
        /// <param name="tryAgainLater">System.Boolean&</param>
        /// <returns>double</returns>
        public double GetConversionRate(MarketDataType marketDataType, Currency denomination, System.Boolean& tryAgainLater)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetInstrument method.
        /// </summary>
        /// <param name="instrumentName">string</param>
        /// <param name="create">bool</param>
        /// <returns>NinjaTrader.Cbi.Instrument</returns>
        public NinjaTrader.Cbi.Instrument GetInstrument(string instrumentName, bool create)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetInstrumentType method.
        /// </summary>
        /// <param name="instrumentName">string</param>
        /// <returns>InstrumentType</returns>
        public InstrumentType GetInstrumentType(string instrumentName)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// IsInstrumentFuture method.
        /// </summary>
        /// <param name="instrumentName">string</param>
        /// <returns>bool</returns>
        public bool IsInstrumentFuture(string instrumentName)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ToInstrumentInfo method.
        /// </summary>
        /// <param name="exchange">Exchange?</param>
        /// <returns>NinjaTrader.Adapter.InstrumentInfo</returns>
        public NinjaTrader.Adapter.InstrumentInfo ToInstrumentInfo(Exchange? exchange)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>string</returns>
        public string ToString()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// UpdateMarketDepth method.
        /// </summary>
        /// <param name="dataType">MarketDataType</param>
        /// <param name="price">double</param>
        /// <param name="volume">long</param>
        /// <param name="operation">Operation</param>
        /// <param name="time">System.DateTime</param>
        /// <param name="callback">System.Action<int, string, Operation, MarketDataType, double, long, System.DateTime></param>
        public void UpdateMarketDepth(MarketDataType dataType, double price, long volume, Operation operation, System.DateTime time, System.Action<int, string, Operation, MarketDataType, double, long, System.DateTime> callback)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
