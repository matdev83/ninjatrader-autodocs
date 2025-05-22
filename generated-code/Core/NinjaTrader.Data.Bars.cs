[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class Bars : NinjaTrader.NinjaScript.ISeries<double>, NinjaTrader.Data.IBars, System.IDisposable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the BarsProxyOnChart.
        /// </summary>
        [DataMember]
        public NinjaTrader.Data.Bars BarsProxyOnChart { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriod.
        /// </summary>
        [DataMember]
        public NinjaTrader.Data.BarsPeriod BarsPeriod { get; set; }
        /// <summary>
        /// Gets or sets the BarsSeries.
        /// </summary>
        [DataMember]
        public NinjaTrader.Data.BarsSeries BarsSeries { get; set; }
        /// <summary>
        /// Gets or sets the BarsSinceNewTradingDay.
        /// </summary>
        [DataMember]
        public int BarsSinceNewTradingDay { get; set; }
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
        /// Gets or sets the CurrentBar.
        /// </summary>
        [DataMember]
        public int CurrentBar { get; set; }
        /// <summary>
        /// Gets or sets the DayCount.
        /// </summary>
        [DataMember]
        public int DayCount { get; set; }
        /// <summary>
        /// Gets or sets the FromDate.
        /// </summary>
        [DataMember]
        public System.DateTime FromDate { get; set; }
        /// <summary>
        /// Gets or sets the Instrument.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Instrument Instrument { get; set; }
        /// <summary>
        /// Gets or sets the IsDividendAdjusted.
        /// </summary>
        [DataMember]
        public bool IsDividendAdjusted { get; set; }
        /// <summary>
        /// Gets or sets the IsFirstBarOfSession.
        /// </summary>
        [DataMember]
        public bool IsFirstBarOfSession { get; set; }
        /// <summary>
        /// Gets or sets the IsInReplayMode.
        /// </summary>
        [DataMember]
        public bool IsInReplayMode { get; set; }
        /// <summary>
        /// Gets or sets the IsLastBarOfSession.
        /// </summary>
        [DataMember]
        public bool IsLastBarOfSession { get; set; }
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
        /// Gets or sets the LastPrice.
        /// </summary>
        [DataMember]
        public double LastPrice { get; set; }
        /// <summary>
        /// Gets or sets the PercentComplete.
        /// </summary>
        [DataMember]
        public double PercentComplete { get; set; }
        /// <summary>
        /// Gets or sets the Item.
        /// </summary>
        [DataMember]
        public double Item { get; set; }
        /// <summary>
        /// Gets or sets the TickCount.
        /// </summary>
        [DataMember]
        public int TickCount { get; set; }
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
        /// GetBars method.
        /// </summary>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        /// <param name="barsPeriod">NinjaTrader.Data.BarsPeriod</param>
        /// <param name="fromDateLocal">System.DateTime</param>
        /// <param name="toDateLocal">System.DateTime</param>
        /// <param name="tradingHours">NinjaTrader.Data.TradingHours</param>
        /// <param name="isDividendAdjusted">bool</param>
        /// <param name="isSplitAdjusted">bool</param>
        /// <param name="isTickReplay">bool</param>
        /// <param name="isResetOnNewTradingDay">bool</param>
        /// <param name="lookupPolicies">LookupPolicies</param>
        /// <param name="mergePolicy">MergePolicy</param>
        /// <param name="isSubscribed">bool</param>
        /// <param name="progress">NinjaTrader.Core.IProgress</param>
        /// <param name="calculateRollovers">bool</param>
        /// <param name="state">object</param>
        /// <param name="callback">System.Action<NinjaTrader.Data.Bars, ErrorCode, string, object></param>
        public void GetBars(NinjaTrader.Cbi.Instrument instrument, NinjaTrader.Data.BarsPeriod barsPeriod, System.DateTime fromDateLocal, System.DateTime toDateLocal, NinjaTrader.Data.TradingHours tradingHours, bool isDividendAdjusted, bool isSplitAdjusted, bool isTickReplay, bool isResetOnNewTradingDay, LookupPolicies lookupPolicies, MergePolicy mergePolicy, bool isSubscribed, NinjaTrader.Core.IProgress progress, bool calculateRollovers, object state, System.Action<NinjaTrader.Data.Bars, ErrorCode, string, object> callback)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetBarsBack method.
        /// </summary>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        /// <param name="barsPeriod">NinjaTrader.Data.BarsPeriod</param>
        /// <param name="barsBack">int</param>
        /// <param name="toDateLocal">System.DateTime</param>
        /// <param name="tradingHours">NinjaTrader.Data.TradingHours</param>
        /// <param name="isDividendAdjusted">bool</param>
        /// <param name="isSplitAdjusted">bool</param>
        /// <param name="isTickReplay">bool</param>
        /// <param name="isResetOnNewTradingDay">bool</param>
        /// <param name="lookupPolicies">LookupPolicies</param>
        /// <param name="mergePolicy">MergePolicy</param>
        /// <param name="isSubscribed">bool</param>
        /// <param name="progress">NinjaTrader.Core.IProgress</param>
        /// <param name="state">object</param>
        /// <param name="callback">System.Action<NinjaTrader.Data.Bars, ErrorCode, string, object></param>
        public void GetBarsBack(NinjaTrader.Cbi.Instrument instrument, NinjaTrader.Data.BarsPeriod barsPeriod, int barsBack, System.DateTime toDateLocal, NinjaTrader.Data.TradingHours tradingHours, bool isDividendAdjusted, bool isSplitAdjusted, bool isTickReplay, bool isResetOnNewTradingDay, LookupPolicies lookupPolicies, MergePolicy mergePolicy, bool isSubscribed, NinjaTrader.Core.IProgress progress, object state, System.Action<NinjaTrader.Data.Bars, ErrorCode, string, object> callback)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetDayBar method.
        /// </summary>
        /// <param name="tradingDaysBack">int</param>
        /// <returns>NinjaTrader.Data.Bar</returns>
        public NinjaTrader.Data.Bar GetDayBar(int tradingDaysBack)
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
        /// Add method.
        /// </summary>
        /// <param name="open">double</param>
        /// <param name="high">double</param>
        /// <param name="low">double</param>
        /// <param name="close">double</param>
        /// <param name="time">System.DateTime</param>
        /// <param name="volume">long</param>
        /// <param name="bid">double</param>
        /// <param name="ask">double</param>
        public void Add(double open, double high, double low, double close, System.DateTime time, long volume, double bid, double ask)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Add method.
        /// </summary>
        /// <param name="open">double</param>
        /// <param name="high">double</param>
        /// <param name="low">double</param>
        /// <param name="close">double</param>
        /// <param name="time">System.DateTime</param>
        /// <param name="volume">long</param>
        /// <param name="tickSize">double</param>
        /// <param name="isBar">bool</param>
        public void Add(double open, double high, double low, double close, System.DateTime time, long volume, double tickSize, bool isBar)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Add method.
        /// </summary>
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
        public void Add(double open, double high, double low, double close, System.DateTime time, long volume, double tickSize, bool isBar, double bid, double ask)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// AddBar method.
        /// </summary>
        /// <param name="open">double</param>
        /// <param name="high">double</param>
        /// <param name="low">double</param>
        /// <param name="close">double</param>
        /// <param name="time">System.DateTime</param>
        /// <param name="volume">long</param>
        /// <param name="tickSizeIn">double</param>
        /// <param name="bid">double</param>
        /// <param name="ask">double</param>
        public void AddBar(double open, double high, double low, double close, System.DateTime time, long volume, double tickSizeIn, double bid, double ask)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ClearCache method.
        /// </summary>
        public void ClearCache()
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
        /// GetBarTestString method.
        /// </summary>
        /// <param name="index">int</param>
        /// <returns>string</returns>
        public string GetBarTestString(int index)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetBarTestString method.
        /// </summary>
        /// <param name="index">int</param>
        /// <param name="ignoreIndex">bool</param>
        /// <returns>string</returns>
        public string GetBarTestString(int index, bool ignoreIndex)
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
        /// GetIndexByTime method.
        /// </summary>
        /// <returns>int</returns>
        public int GetIndexByTime()
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
        /// GetLow method.
        /// </summary>
        /// <param name="index">int</param>
        /// <returns>double</returns>
        public double GetLow(int index)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetNewBarsProxy method.
        /// </summary>
        /// <param name="barsProxy">NinjaTrader.Data.Bars</param>
        /// <returns>NinjaTrader.Data.Bars</returns>
        public NinjaTrader.Data.Bars GetNewBarsProxy(NinjaTrader.Data.Bars barsProxy)
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
        /// GetTime method.
        /// </summary>
        /// <param name="index">int</param>
        /// <returns>System.DateTime</returns>
        public System.DateTime GetTime(int index)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetValueAt method.
        /// </summary>
        /// <param name="barIndex">int</param>
        /// <returns>double</returns>
        public double GetValueAt(int barIndex)
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
        /// IsEqualInstrumentBarsPeriod method.
        /// </summary>
        /// <param name="barsRequested">NinjaTrader.Data.Bars</param>
        /// <returns>bool</returns>
        public bool IsEqualInstrumentBarsPeriod(NinjaTrader.Data.Bars barsRequested)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// IsEqualBars method.
        /// </summary>
        /// <param name="other">NinjaTrader.Data.Bars</param>
        /// <returns>bool</returns>
        public bool IsEqualBars(NinjaTrader.Data.Bars other)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// IsFirstBarOfSessionByIndex method.
        /// </summary>
        /// <param name="index">int</param>
        /// <returns>bool</returns>
        public bool IsFirstBarOfSessionByIndex(int index)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// IsValidDataPoint method.
        /// </summary>
        /// <param name="barsAgo">int</param>
        /// <returns>bool</returns>
        public bool IsValidDataPoint(int barsAgo)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// IsValidDataPointAt method.
        /// </summary>
        /// <param name="barIndex">int</param>
        /// <returns>bool</returns>
        public bool IsValidDataPointAt(int barIndex)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// RemoveLastBar method.
        /// </summary>
        public void RemoveLastBar()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ToChartString method.
        /// </summary>
        /// <returns>string</returns>
        public string ToChartString()
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
        /// AddTest method.
        /// </summary>
        /// <param name="open">double</param>
        /// <param name="high">double</param>
        /// <param name="low">double</param>
        /// <param name="close">double</param>
        /// <param name="time">System.DateTime</param>
        /// <param name="volume">long</param>
        /// <param name="tickSize">double</param>
        /// <param name="isBar">bool</param>
        public void AddTest(double open, double high, double low, double close, System.DateTime time, long volume, double tickSize, bool isBar)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ClearBarsTestDictionary method.
        /// </summary>
        public void ClearBarsTestDictionary()
        {
            // Method implementation goes here
        }
        #endregion
    }
}
