[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class BarsSeries : IDisposable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the IsInDownloadFromProvider.
        /// </summary>
        [DataMember]
        public Boolean IsInDownloadFromProvider { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriod.
        /// </summary>
        [DataMember]
        public BarsPeriod BarsPeriod { get; set; }
        /// <summary>
        /// Gets or sets the BarsType.
        /// </summary>
        [DataMember]
        public BarsType BarsType { get; set; }
        /// <summary>
        /// Gets or sets the Count.
        /// </summary>
        [DataMember]
        public Int32 Count { get; set; }
        /// <summary>
        /// Gets or sets the DayCount.
        /// </summary>
        [DataMember]
        public Int32 DayCount { get; set; }
        /// <summary>
        /// Gets or sets the EstimatedFutureBarTimeDiff.
        /// </summary>
        [DataMember]
        public Int32 EstimatedFutureBarTimeDiff { get; set; }
        /// <summary>
        /// Gets or sets the FirstTimeToFetch.
        /// </summary>
        [DataMember]
        public DateTime FirstTimeToFetch { get; set; }
        /// <summary>
        /// Gets or sets the FromDate.
        /// </summary>
        [DataMember]
        public DateTime FromDate { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public String Id { get; set; }
        /// <summary>
        /// Gets or sets the Instrument.
        /// </summary>
        [DataMember]
        public Instrument Instrument { get; set; }
        /// <summary>
        /// Gets or sets the IsDisposed.
        /// </summary>
        [DataMember]
        public Boolean IsDisposed { get; set; }
        /// <summary>
        /// Gets or sets the IsDividendAdjusted.
        /// </summary>
        [DataMember]
        public Boolean IsDividendAdjusted { get; set; }
        /// <summary>
        /// Gets or sets the IsMarketDataBufferEnabled.
        /// </summary>
        [DataMember]
        public Boolean IsMarketDataBufferEnabled { get; set; }
        /// <summary>
        /// Gets or sets the IsMarketDataSubscribed.
        /// </summary>
        [DataMember]
        public Boolean IsMarketDataSubscribed { get; set; }
        /// <summary>
        /// Gets or sets the IsResetOnNewTradingDay.
        /// </summary>
        [DataMember]
        public Boolean IsResetOnNewTradingDay { get; set; }
        /// <summary>
        /// Gets or sets the IsRolloverAdjusted.
        /// </summary>
        [DataMember]
        public Boolean IsRolloverAdjusted { get; set; }
        /// <summary>
        /// Gets or sets the IsSplitAdjusted.
        /// </summary>
        [DataMember]
        public Boolean IsSplitAdjusted { get; set; }
        /// <summary>
        /// Gets or sets the IsTickReplay.
        /// </summary>
        [DataMember]
        public Boolean IsTickReplay { get; set; }
        /// <summary>
        /// Gets or sets the LastBarTime.
        /// </summary>
        [DataMember]
        public DateTime LastBarTime { get; set; }
        /// <summary>
        /// Gets or sets the LastIncludesEndTimeStamp.
        /// </summary>
        [DataMember]
        public Nullable<Boolean> LastIncludesEndTimeStamp { get; set; }
        /// <summary>
        /// Gets or sets the LastPrice.
        /// </summary>
        [DataMember]
        public Double LastPrice { get; set; }
        /// <summary>
        /// Gets or sets the OneTickOneVolume.
        /// </summary>
        [DataMember]
        public Boolean OneTickOneVolume { get; set; }
        /// <summary>
        /// Gets or sets the PercentComplete.
        /// </summary>
        [DataMember]
        public Double PercentComplete { get; set; }
        /// <summary>
        /// Gets or sets the LastTimeToFetch.
        /// </summary>
        [DataMember]
        public DateTime LastTimeToFetch { get; set; }
        /// <summary>
        /// Gets or sets the SyncRoot.
        /// </summary>
        [DataMember]
        public ReaderWriterLockSlim SyncRoot { get; set; }
        /// <summary>
        /// Gets or sets the TickCount.
        /// </summary>
        [DataMember]
        public Int32 TickCount { get; set; }
        /// <summary>
        /// Gets or sets the TicksOnLastSecond.
        /// </summary>
        [DataMember]
        public Int32 TicksOnLastSecond { get; set; }
        /// <summary>
        /// Gets or sets the ToDate.
        /// </summary>
        [DataMember]
        public DateTime ToDate { get; set; }
        /// <summary>
        /// Gets or sets the TotalTicks.
        /// </summary>
        [DataMember]
        public Int64 TotalTicks { get; set; }
        /// <summary>
        /// Gets or sets the TradingHours.
        /// </summary>
        [DataMember]
        public TradingHours TradingHours { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// CheckInstances method.
        /// </summary>
        public Void CheckInstances();
        /// <summary>
        /// ClearCache method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        /// <param name="firstData2Clear">DateTime</param>
        /// <param name="clearReplayCache">Boolean</param>
        /// <param name="barsPeriodType">Nullable`1</param>
        public Void ClearCache(Instrument instrument, DateTime firstData2Clear, Boolean clearReplayCache, Nullable<BarsPeriodType> barsPeriodType);
        /// <summary>
        /// DeleteDbBars method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        /// <param name="periodType">BarsPeriodType</param>
        /// <param name="marketDataType">MarketDataType</param>
        /// <param name="delFrom">DateTime</param>
        /// <param name="delTo">DateTime</param>
        public Void DeleteDbBars(Instrument instrument, BarsPeriodType periodType, MarketDataType marketDataType, DateTime delFrom, DateTime delTo);
        /// <summary>
        /// DisposeBarsSeriesDictionary method.
        /// </summary>
        public Void DisposeBarsSeriesDictionary();
        /// <summary>
        /// DownloadFromProvider method.
        /// </summary>
        /// <param name="barsRequested1">Collection`1</param>
        /// <param name="overwriteExistingData1">Boolean</param>
        /// <param name="deleteDataAfter1">Boolean</param>
        /// <param name="progress1">IProgress</param>
        /// <param name="newConnection1">Connection</param>
        /// <param name="showErrors1">Boolean</param>
        /// <param name="isRescheduled">Boolean</param>
        /// <param name="callback1">Action`1</param>
        public Void DownloadFromProvider(Collection<Bars> barsRequested1, Boolean overwriteExistingData1, Boolean deleteDataAfter1, IProgress progress1, Connection newConnection1, Boolean showErrors1, Boolean isRescheduled, Action<Boolean> callback1);
        /// <summary>
        /// DownloadFromProviderReloadUI method.
        /// </summary>
        /// <param name="barsRequested">Collection`1</param>
        /// <param name="progress">IProgress</param>
        /// <param name="downloadCallback">Action</param>
        public Void DownloadFromProviderReloadUI(Collection<Bars> barsRequested, IProgress progress, Action downloadCallback);
        /// <summary>
        /// Load method.
        /// </summary>
        /// <returns>DateTime</returns>
        public DateTime Load();
        /// <summary>
        /// NeedsReloadOnConnect method.
        /// </summary>
        /// <param name="newConnection">Connection</param>
        /// <returns>Boolean</returns>
        public Boolean NeedsReloadOnConnect(Connection newConnection);
        /// <summary>
        /// Save method.
        /// </summary>
        public Void Save();
        /// <summary>
        /// SaveToFile method.
        /// </summary>
        /// <param name="path">String</param>
        /// <param name="separator">Char</param>
        /// <param name="progress">IProgress</param>
        /// <param name="showProgress">Boolean</param>
        /// <returns>Boolean</returns>
        public Boolean SaveToFile(String path, Char separator, IProgress progress, Boolean showProgress);
        /// <summary>
        /// UnsubscribeInstruments method.
        /// </summary>
        /// <param name="instruments">List`1</param>
        public Void UnsubscribeInstruments(List<Instrument> instruments);
        /// <summary>
        /// Add method.
        /// </summary>
        /// <param name="bars">Bars</param>
        /// <param name="open">Double</param>
        /// <param name="high">Double</param>
        /// <param name="low">Double</param>
        /// <param name="close">Double</param>
        /// <param name="time">DateTime</param>
        /// <param name="volume">Int64</param>
        /// <param name="tickSize">Double</param>
        /// <param name="isBar">Boolean</param>
        public Void Add(Bars bars, Double open, Double high, Double low, Double close, DateTime time, Int64 volume, Double tickSize, Boolean isBar);
        /// <summary>
        /// Add method.
        /// </summary>
        /// <param name="bars">Bars</param>
        /// <param name="open">Double</param>
        /// <param name="high">Double</param>
        /// <param name="low">Double</param>
        /// <param name="close">Double</param>
        /// <param name="time">DateTime</param>
        /// <param name="volume">Int64</param>
        /// <param name="tickSize">Double</param>
        /// <param name="isBar">Boolean</param>
        /// <param name="bid">Double</param>
        /// <param name="ask">Double</param>
        public Void Add(Bars bars, Double open, Double high, Double low, Double close, DateTime time, Int64 volume, Double tickSize, Boolean isBar, Double bid, Double ask);
        /// <summary>
        /// Clear method.
        /// </summary>
        public Void Clear();
        /// <summary>
        /// CountBarsSeriesInDictionary method.
        /// </summary>
        /// <returns>Int32</returns>
        public Int32 CountBarsSeriesInDictionary();
        /// <summary>
        /// Dispose method.
        /// </summary>
        public Void Dispose();
        /// <summary>
        /// GetAsk method.
        /// </summary>
        /// <param name="index">Int32</param>
        /// <returns>Double</returns>
        public Double GetAsk(Int32 index);
        /// <summary>
        /// GetBar method.
        /// </summary>
        /// <param name="time">DateTime</param>
        /// <returns>Int32</returns>
        public Int32 GetBar(DateTime time);
        /// <summary>
        /// GetBid method.
        /// </summary>
        /// <param name="index">Int32</param>
        /// <returns>Double</returns>
        public Double GetBid(Int32 index);
        /// <summary>
        /// GetClose method.
        /// </summary>
        /// <param name="index">Int32</param>
        /// <returns>Double</returns>
        public Double GetClose(Int32 index);
        /// <summary>
        /// GetHigh method.
        /// </summary>
        /// <param name="index">Int32</param>
        /// <returns>Double</returns>
        public Double GetHigh(Int32 index);
        /// <summary>
        /// GetSessionEndTime method.
        /// </summary>
        /// <param name="index">Int32</param>
        /// <returns>DateTime</returns>
        public DateTime GetSessionEndTime(Int32 index);
        /// <summary>
        /// GetIsFirstBarOfSession method.
        /// </summary>
        /// <param name="index">Int32</param>
        /// <returns>Boolean</returns>
        public Boolean GetIsFirstBarOfSession(Int32 index);
        /// <summary>
        /// GetLow method.
        /// </summary>
        /// <param name="index">Int32</param>
        /// <returns>Double</returns>
        public Double GetLow(Int32 index);
        /// <summary>
        /// GetOpen method.
        /// </summary>
        /// <param name="index">Int32</param>
        /// <returns>Double</returns>
        public Double GetOpen(Int32 index);
        /// <summary>
        /// GetVolume method.
        /// </summary>
        /// <param name="index">Int32</param>
        /// <returns>Int64</returns>
        public Int64 GetVolume(Int32 index);
        /// <summary>
        /// GetTime method.
        /// </summary>
        /// <param name="index">Int32</param>
        /// <returns>DateTime</returns>
        public DateTime GetTime(Int32 index);
        /// <summary>
        /// RemoveFromBegin method.
        /// </summary>
        /// <param name="cutTime">DateTime</param>
        public Void RemoveFromBegin(DateTime cutTime);
        /// <summary>
        /// RemoveFromEnd method.
        /// </summary>
        /// <param name="cutTime">DateTime</param>
        public Void RemoveFromEnd(DateTime cutTime);
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>String</returns>
        public String ToString();
        /// <summary>
        /// UpdateLocalDate2BarIndexCache method.
        /// </summary>
        /// <param name="minIdx">Int32</param>
        public Void UpdateLocalDate2BarIndexCache(Int32 minIdx);
        #endregion
    }
}
