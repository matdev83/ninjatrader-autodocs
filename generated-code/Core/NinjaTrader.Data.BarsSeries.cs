[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class BarsSeries : System.IDisposable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the IsInDownloadFromProvider.
        /// </summary>
        [DataMember]
        public bool IsInDownloadFromProvider { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriod.
        /// </summary>
        [DataMember]
        public NinjaTrader.Data.BarsPeriod BarsPeriod { get; set; }
        /// <summary>
        /// Gets or sets the BarsType.
        /// </summary>
        [DataMember]
        public NinjaTrader.Data.BarsType BarsType { get; set; }
        /// <summary>
        /// Gets or sets the Count.
        /// </summary>
        [DataMember]
        public int Count { get; set; }
        /// <summary>
        /// Gets or sets the DayCount.
        /// </summary>
        [DataMember]
        public int DayCount { get; set; }
        /// <summary>
        /// Gets or sets the EstimatedFutureBarTimeDiff.
        /// </summary>
        [DataMember]
        public int EstimatedFutureBarTimeDiff { get; set; }
        /// <summary>
        /// Gets or sets the FirstTimeToFetch.
        /// </summary>
        [DataMember]
        public System.DateTime FirstTimeToFetch { get; set; }
        /// <summary>
        /// Gets or sets the FromDate.
        /// </summary>
        [DataMember]
        public System.DateTime FromDate { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public string Id { get; set; }
        /// <summary>
        /// Gets or sets the Instrument.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Instrument Instrument { get; set; }
        /// <summary>
        /// Gets or sets the IsDisposed.
        /// </summary>
        [DataMember]
        public bool IsDisposed { get; set; }
        /// <summary>
        /// Gets or sets the IsDividendAdjusted.
        /// </summary>
        [DataMember]
        public bool IsDividendAdjusted { get; set; }
        /// <summary>
        /// Gets or sets the IsMarketDataBufferEnabled.
        /// </summary>
        [DataMember]
        public bool IsMarketDataBufferEnabled { get; set; }
        /// <summary>
        /// Gets or sets the IsMarketDataSubscribed.
        /// </summary>
        [DataMember]
        public bool IsMarketDataSubscribed { get; set; }
        /// <summary>
        /// Gets or sets the IsResetOnNewTradingDay.
        /// </summary>
        [DataMember]
        public bool IsResetOnNewTradingDay { get; set; }
        /// <summary>
        /// Gets or sets the IsRolloverAdjusted.
        /// </summary>
        [DataMember]
        public bool IsRolloverAdjusted { get; set; }
        /// <summary>
        /// Gets or sets the IsSplitAdjusted.
        /// </summary>
        [DataMember]
        public bool IsSplitAdjusted { get; set; }
        /// <summary>
        /// Gets or sets the IsTickReplay.
        /// </summary>
        [DataMember]
        public bool IsTickReplay { get; set; }
        /// <summary>
        /// Gets or sets the LastBarTime.
        /// </summary>
        [DataMember]
        public System.DateTime LastBarTime { get; set; }
        /// <summary>
        /// Gets or sets the LastIncludesEndTimeStamp.
        /// </summary>
        [DataMember]
        public bool? LastIncludesEndTimeStamp { get; set; }
        /// <summary>
        /// Gets or sets the LastPrice.
        /// </summary>
        [DataMember]
        public double LastPrice { get; set; }
        /// <summary>
        /// Gets or sets the OneTickOneVolume.
        /// </summary>
        [DataMember]
        public bool OneTickOneVolume { get; set; }
        /// <summary>
        /// Gets or sets the PercentComplete.
        /// </summary>
        [DataMember]
        public double PercentComplete { get; set; }
        /// <summary>
        /// Gets or sets the LastTimeToFetch.
        /// </summary>
        [DataMember]
        public System.DateTime LastTimeToFetch { get; set; }
        /// <summary>
        /// Gets or sets the SyncRoot.
        /// </summary>
        [DataMember]
        public System.Threading.ReaderWriterLockSlim SyncRoot { get; set; }
        /// <summary>
        /// Gets or sets the TickCount.
        /// </summary>
        [DataMember]
        public int TickCount { get; set; }
        /// <summary>
        /// Gets or sets the TicksOnLastSecond.
        /// </summary>
        [DataMember]
        public int TicksOnLastSecond { get; set; }
        /// <summary>
        /// Gets or sets the ToDate.
        /// </summary>
        [DataMember]
        public System.DateTime ToDate { get; set; }
        /// <summary>
        /// Gets or sets the TotalTicks.
        /// </summary>
        [DataMember]
        public long TotalTicks { get; set; }
        /// <summary>
        /// Gets or sets the TradingHours.
        /// </summary>
        [DataMember]
        public NinjaTrader.Data.TradingHours TradingHours { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// CheckInstances method.
        /// </summary>
        public void CheckInstances()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ClearCache method.
        /// </summary>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        /// <param name="firstData2Clear">System.DateTime</param>
        /// <param name="clearReplayCache">bool</param>
        /// <param name="barsPeriodType">BarsPeriodType?</param>
        public void ClearCache(NinjaTrader.Cbi.Instrument instrument, System.DateTime firstData2Clear, bool clearReplayCache, BarsPeriodType? barsPeriodType)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DeleteDbBars method.
        /// </summary>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        /// <param name="periodType">BarsPeriodType</param>
        /// <param name="marketDataType">MarketDataType</param>
        /// <param name="delFrom">System.DateTime</param>
        /// <param name="delTo">System.DateTime</param>
        public void DeleteDbBars(NinjaTrader.Cbi.Instrument instrument, BarsPeriodType periodType, MarketDataType marketDataType, System.DateTime delFrom, System.DateTime delTo)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DisposeBarsSeriesDictionary method.
        /// </summary>
        public void DisposeBarsSeriesDictionary()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DownloadFromProvider method.
        /// </summary>
        /// <param name="barsRequested1">System.Collections.ObjectModel.Collection<NinjaTrader.Data.Bars></param>
        /// <param name="overwriteExistingData1">bool</param>
        /// <param name="deleteDataAfter1">bool</param>
        /// <param name="progress1">NinjaTrader.Core.IProgress</param>
        /// <param name="newConnection1">NinjaTrader.Cbi.Connection</param>
        /// <param name="showErrors1">bool</param>
        /// <param name="isRescheduled">bool</param>
        /// <param name="callback1">System.Action<bool></param>
        public void DownloadFromProvider(System.Collections.ObjectModel.Collection<NinjaTrader.Data.Bars> barsRequested1, bool overwriteExistingData1, bool deleteDataAfter1, NinjaTrader.Core.IProgress progress1, NinjaTrader.Cbi.Connection newConnection1, bool showErrors1, bool isRescheduled, System.Action<bool> callback1)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DownloadFromProviderReloadUI method.
        /// </summary>
        /// <param name="barsRequested">System.Collections.ObjectModel.Collection<NinjaTrader.Data.Bars></param>
        /// <param name="progress">NinjaTrader.Core.IProgress</param>
        /// <param name="downloadCallback">System.Action</param>
        public void DownloadFromProviderReloadUI(System.Collections.ObjectModel.Collection<NinjaTrader.Data.Bars> barsRequested, NinjaTrader.Core.IProgress progress, System.Action downloadCallback)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Load method.
        /// </summary>
        /// <returns>System.DateTime</returns>
        public System.DateTime Load()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// NeedsReloadOnConnect method.
        /// </summary>
        /// <param name="newConnection">NinjaTrader.Cbi.Connection</param>
        /// <returns>bool</returns>
        public bool NeedsReloadOnConnect(NinjaTrader.Cbi.Connection newConnection)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Save method.
        /// </summary>
        public void Save()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SaveToFile method.
        /// </summary>
        /// <param name="path">string</param>
        /// <param name="separator">char</param>
        /// <param name="progress">NinjaTrader.Core.IProgress</param>
        /// <param name="showProgress">bool</param>
        /// <returns>bool</returns>
        public bool SaveToFile(string path, char separator, NinjaTrader.Core.IProgress progress, bool showProgress)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// UnsubscribeInstruments method.
        /// </summary>
        /// <param name="instruments">System.Collections.Generic.List<NinjaTrader.Cbi.Instrument></param>
        public void UnsubscribeInstruments(System.Collections.Generic.List<NinjaTrader.Cbi.Instrument> instruments)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Add method.
        /// </summary>
        /// <param name="bars">NinjaTrader.Data.Bars</param>
        /// <param name="open">double</param>
        /// <param name="high">double</param>
        /// <param name="low">double</param>
        /// <param name="close">double</param>
        /// <param name="time">System.DateTime</param>
        /// <param name="volume">long</param>
        /// <param name="tickSize">double</param>
        /// <param name="isBar">bool</param>
        public void Add(NinjaTrader.Data.Bars bars, double open, double high, double low, double close, System.DateTime time, long volume, double tickSize, bool isBar)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Add method.
        /// </summary>
        /// <param name="bars">NinjaTrader.Data.Bars</param>
        /// <param name="open">double</param>
        /// <param name="high">double</param>
        /// <param name="low">double</param>
        /// <param name="close">double</param>
        /// <param name="time">System.DateTime</param>
        /// <param name="volume">long</param>
        /// <param name="tickSize">double</param>
        /// <param name="isBar">bool</param>
        /// <param name="bid">double</param>
        /// <param name="ask">double</param>
        public void Add(NinjaTrader.Data.Bars bars, double open, double high, double low, double close, System.DateTime time, long volume, double tickSize, bool isBar, double bid, double ask)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Clear method.
        /// </summary>
        public void Clear()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// CountBarsSeriesInDictionary method.
        /// </summary>
        /// <returns>int</returns>
        public int CountBarsSeriesInDictionary()
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
        /// GetAsk method.
        /// </summary>
        /// <param name="index">int</param>
        /// <returns>double</returns>
        public double GetAsk(int index)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetBar method.
        /// </summary>
        /// <param name="time">System.DateTime</param>
        /// <returns>int</returns>
        public int GetBar(System.DateTime time)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetBid method.
        /// </summary>
        /// <param name="index">int</param>
        /// <returns>double</returns>
        public double GetBid(int index)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetClose method.
        /// </summary>
        /// <param name="index">int</param>
        /// <returns>double</returns>
        public double GetClose(int index)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetHigh method.
        /// </summary>
        /// <param name="index">int</param>
        /// <returns>double</returns>
        public double GetHigh(int index)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetSessionEndTime method.
        /// </summary>
        /// <param name="index">int</param>
        /// <returns>System.DateTime</returns>
        public System.DateTime GetSessionEndTime(int index)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetIsFirstBarOfSession method.
        /// </summary>
        /// <param name="index">int</param>
        /// <returns>bool</returns>
        public bool GetIsFirstBarOfSession(int index)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetLow method.
        /// </summary>
        /// <param name="index">int</param>
        /// <returns>double</returns>
        public double GetLow(int index)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetOpen method.
        /// </summary>
        /// <param name="index">int</param>
        /// <returns>double</returns>
        public double GetOpen(int index)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetVolume method.
        /// </summary>
        /// <param name="index">int</param>
        /// <returns>long</returns>
        public long GetVolume(int index)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetTime method.
        /// </summary>
        /// <param name="index">int</param>
        /// <returns>System.DateTime</returns>
        public System.DateTime GetTime(int index)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// RemoveFromBegin method.
        /// </summary>
        /// <param name="cutTime">System.DateTime</param>
        public void RemoveFromBegin(System.DateTime cutTime)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// RemoveFromEnd method.
        /// </summary>
        /// <param name="cutTime">System.DateTime</param>
        public void RemoveFromEnd(System.DateTime cutTime)
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
        /// UpdateLocalDate2BarIndexCache method.
        /// </summary>
        /// <param name="minIdx">int</param>
        public void UpdateLocalDate2BarIndexCache(int minIdx)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
