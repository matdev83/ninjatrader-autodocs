[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class Bars : ISeries<Double>, IBars, IDisposable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the BarsProxyOnChart.
        /// </summary>
        [DataMember]
        public Bars BarsProxyOnChart { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriod.
        /// </summary>
        [DataMember]
        public BarsPeriod BarsPeriod { get; set; }
        /// <summary>
        /// Gets or sets the BarsSeries.
        /// </summary>
        [DataMember]
        public BarsSeries BarsSeries { get; set; }
        /// <summary>
        /// Gets or sets the BarsSinceNewTradingDay.
        /// </summary>
        [DataMember]
        public Int32 BarsSinceNewTradingDay { get; set; }
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
        /// Gets or sets the CurrentBar.
        /// </summary>
        [DataMember]
        public Int32 CurrentBar { get; set; }
        /// <summary>
        /// Gets or sets the DayCount.
        /// </summary>
        [DataMember]
        public Int32 DayCount { get; set; }
        /// <summary>
        /// Gets or sets the FromDate.
        /// </summary>
        [DataMember]
        public DateTime FromDate { get; set; }
        /// <summary>
        /// Gets or sets the Instrument.
        /// </summary>
        [DataMember]
        public Instrument Instrument { get; set; }
        /// <summary>
        /// Gets or sets the IsDividendAdjusted.
        /// </summary>
        [DataMember]
        public Boolean IsDividendAdjusted { get; set; }
        /// <summary>
        /// Gets or sets the IsFirstBarOfSession.
        /// </summary>
        [DataMember]
        public Boolean IsFirstBarOfSession { get; set; }
        /// <summary>
        /// Gets or sets the IsInReplayMode.
        /// </summary>
        [DataMember]
        public Boolean IsInReplayMode { get; set; }
        /// <summary>
        /// Gets or sets the IsLastBarOfSession.
        /// </summary>
        [DataMember]
        public Boolean IsLastBarOfSession { get; set; }
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
        /// Gets or sets the LastPrice.
        /// </summary>
        [DataMember]
        public Double LastPrice { get; set; }
        /// <summary>
        /// Gets or sets the PercentComplete.
        /// </summary>
        [DataMember]
        public Double PercentComplete { get; set; }
        /// <summary>
        /// Gets or sets the Item.
        /// </summary>
        [DataMember]
        public Double Item { get; set; }
        /// <summary>
        /// Gets or sets the TickCount.
        /// </summary>
        [DataMember]
        public Int32 TickCount { get; set; }
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
        /// GetBars method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        /// <param name="barsPeriod">BarsPeriod</param>
        /// <param name="fromDateLocal">DateTime</param>
        /// <param name="toDateLocal">DateTime</param>
        /// <param name="tradingHours">TradingHours</param>
        /// <param name="isDividendAdjusted">Boolean</param>
        /// <param name="isSplitAdjusted">Boolean</param>
        /// <param name="isTickReplay">Boolean</param>
        /// <param name="isResetOnNewTradingDay">Boolean</param>
        /// <param name="lookupPolicies">LookupPolicies</param>
        /// <param name="mergePolicy">MergePolicy</param>
        /// <param name="isSubscribed">Boolean</param>
        /// <param name="progress">IProgress</param>
        /// <param name="calculateRollovers">Boolean</param>
        /// <param name="state">Object</param>
        /// <param name="callback">Action`4</param>
        public Void GetBars(Instrument instrument, BarsPeriod barsPeriod, DateTime fromDateLocal, DateTime toDateLocal, TradingHours tradingHours, Boolean isDividendAdjusted, Boolean isSplitAdjusted, Boolean isTickReplay, Boolean isResetOnNewTradingDay, LookupPolicies lookupPolicies, MergePolicy mergePolicy, Boolean isSubscribed, IProgress progress, Boolean calculateRollovers, Object state, Action<Bars, ErrorCode, String, Object> callback);
        /// <summary>
        /// GetBarsBack method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        /// <param name="barsPeriod">BarsPeriod</param>
        /// <param name="barsBack">Int32</param>
        /// <param name="toDateLocal">DateTime</param>
        /// <param name="tradingHours">TradingHours</param>
        /// <param name="isDividendAdjusted">Boolean</param>
        /// <param name="isSplitAdjusted">Boolean</param>
        /// <param name="isTickReplay">Boolean</param>
        /// <param name="isResetOnNewTradingDay">Boolean</param>
        /// <param name="lookupPolicies">LookupPolicies</param>
        /// <param name="mergePolicy">MergePolicy</param>
        /// <param name="isSubscribed">Boolean</param>
        /// <param name="progress">IProgress</param>
        /// <param name="state">Object</param>
        /// <param name="callback">Action`4</param>
        public Void GetBarsBack(Instrument instrument, BarsPeriod barsPeriod, Int32 barsBack, DateTime toDateLocal, TradingHours tradingHours, Boolean isDividendAdjusted, Boolean isSplitAdjusted, Boolean isTickReplay, Boolean isResetOnNewTradingDay, LookupPolicies lookupPolicies, MergePolicy mergePolicy, Boolean isSubscribed, IProgress progress, Object state, Action<Bars, ErrorCode, String, Object> callback);
        /// <summary>
        /// GetDayBar method.
        /// </summary>
        /// <param name="tradingDaysBack">Int32</param>
        /// <returns>Bar</returns>
        public Bar GetDayBar(Int32 tradingDaysBack);
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
        /// Add method.
        /// </summary>
        /// <param name="open">Double</param>
        /// <param name="high">Double</param>
        /// <param name="low">Double</param>
        /// <param name="close">Double</param>
        /// <param name="time">DateTime</param>
        /// <param name="volume">Int64</param>
        /// <param name="bid">Double</param>
        /// <param name="ask">Double</param>
        public Void Add(Double open, Double high, Double low, Double close, DateTime time, Int64 volume, Double bid, Double ask);
        /// <summary>
        /// Add method.
        /// </summary>
        /// <param name="open">Double</param>
        /// <param name="high">Double</param>
        /// <param name="low">Double</param>
        /// <param name="close">Double</param>
        /// <param name="time">DateTime</param>
        /// <param name="volume">Int64</param>
        /// <param name="tickSize">Double</param>
        /// <param name="isBar">Boolean</param>
        public Void Add(Double open, Double high, Double low, Double close, DateTime time, Int64 volume, Double tickSize, Boolean isBar);
        /// <summary>
        /// Add method.
        /// </summary>
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
        public Void Add(Double open, Double high, Double low, Double close, DateTime time, Int64 volume, Double tickSize, Boolean isBar, Double bid, Double ask);
        /// <summary>
        /// AddBar method.
        /// </summary>
        /// <param name="open">Double</param>
        /// <param name="high">Double</param>
        /// <param name="low">Double</param>
        /// <param name="close">Double</param>
        /// <param name="time">DateTime</param>
        /// <param name="volume">Int64</param>
        /// <param name="tickSizeIn">Double</param>
        /// <param name="bid">Double</param>
        /// <param name="ask">Double</param>
        public Void AddBar(Double open, Double high, Double low, Double close, DateTime time, Int64 volume, Double tickSizeIn, Double bid, Double ask);
        /// <summary>
        /// ClearCache method.
        /// </summary>
        public Void ClearCache();
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
        /// GetBarTestString method.
        /// </summary>
        /// <param name="index">Int32</param>
        /// <returns>String</returns>
        public String GetBarTestString(Int32 index);
        /// <summary>
        /// GetBarTestString method.
        /// </summary>
        /// <param name="index">Int32</param>
        /// <param name="ignoreIndex">Boolean</param>
        /// <returns>String</returns>
        public String GetBarTestString(Int32 index, Boolean ignoreIndex);
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
        /// GetIndexByTime method.
        /// </summary>
        /// <returns>Int32</returns>
        public Int32 GetIndexByTime();
        /// <summary>
        /// GetSessionEndTime method.
        /// </summary>
        /// <param name="index">Int32</param>
        /// <returns>DateTime</returns>
        public DateTime GetSessionEndTime(Int32 index);
        /// <summary>
        /// GetLow method.
        /// </summary>
        /// <param name="index">Int32</param>
        /// <returns>Double</returns>
        public Double GetLow(Int32 index);
        /// <summary>
        /// GetNewBarsProxy method.
        /// </summary>
        /// <param name="barsProxy">Bars</param>
        /// <returns>Bars</returns>
        public Bars GetNewBarsProxy(Bars barsProxy);
        /// <summary>
        /// GetOpen method.
        /// </summary>
        /// <param name="index">Int32</param>
        /// <returns>Double</returns>
        public Double GetOpen(Int32 index);
        /// <summary>
        /// GetTime method.
        /// </summary>
        /// <param name="index">Int32</param>
        /// <returns>DateTime</returns>
        public DateTime GetTime(Int32 index);
        /// <summary>
        /// GetValueAt method.
        /// </summary>
        /// <param name="barIndex">Int32</param>
        /// <returns>Double</returns>
        public Double GetValueAt(Int32 barIndex);
        /// <summary>
        /// GetVolume method.
        /// </summary>
        /// <param name="index">Int32</param>
        /// <returns>Int64</returns>
        public Int64 GetVolume(Int32 index);
        /// <summary>
        /// IsEqualInstrumentBarsPeriod method.
        /// </summary>
        /// <param name="barsRequested">Bars</param>
        /// <returns>Boolean</returns>
        public Boolean IsEqualInstrumentBarsPeriod(Bars barsRequested);
        /// <summary>
        /// IsEqualBars method.
        /// </summary>
        /// <param name="other">Bars</param>
        /// <returns>Boolean</returns>
        public Boolean IsEqualBars(Bars other);
        /// <summary>
        /// IsFirstBarOfSessionByIndex method.
        /// </summary>
        /// <param name="index">Int32</param>
        /// <returns>Boolean</returns>
        public Boolean IsFirstBarOfSessionByIndex(Int32 index);
        /// <summary>
        /// IsValidDataPoint method.
        /// </summary>
        /// <param name="barsAgo">Int32</param>
        /// <returns>Boolean</returns>
        public Boolean IsValidDataPoint(Int32 barsAgo);
        /// <summary>
        /// IsValidDataPointAt method.
        /// </summary>
        /// <param name="barIndex">Int32</param>
        /// <returns>Boolean</returns>
        public Boolean IsValidDataPointAt(Int32 barIndex);
        /// <summary>
        /// RemoveLastBar method.
        /// </summary>
        public Void RemoveLastBar();
        /// <summary>
        /// ToChartString method.
        /// </summary>
        /// <returns>String</returns>
        public String ToChartString();
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>String</returns>
        public String ToString();
        /// <summary>
        /// AddTest method.
        /// </summary>
        /// <param name="open">Double</param>
        /// <param name="high">Double</param>
        /// <param name="low">Double</param>
        /// <param name="close">Double</param>
        /// <param name="time">DateTime</param>
        /// <param name="volume">Int64</param>
        /// <param name="tickSize">Double</param>
        /// <param name="isBar">Boolean</param>
        public Void AddTest(Double open, Double high, Double low, Double close, DateTime time, Int64 volume, Double tickSize, Boolean isBar);
        /// <summary>
        /// ClearBarsTestDictionary method.
        /// </summary>
        public Void ClearBarsTestDictionary();
        #endregion
    }
}
