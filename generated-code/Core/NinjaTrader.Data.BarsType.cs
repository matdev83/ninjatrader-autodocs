[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class BarsType : NinjaTrader.NinjaScript.NinjaScript
    {
        #region Properties
        /// <summary>
        /// Gets or sets the BarsPeriod.
        /// </summary>
        [DataMember]
        public NinjaTrader.Data.BarsPeriod BarsPeriod { get; set; }
        /// <summary>
        /// Gets or sets the BarsTypeDay.
        /// </summary>
        [DataMember]
        public NinjaTrader.Data.BarsType BarsTypeDay { get; set; }
        /// <summary>
        /// Gets or sets the BarsTypeMinute.
        /// </summary>
        [DataMember]
        public NinjaTrader.Data.BarsType BarsTypeMinute { get; set; }
        /// <summary>
        /// Gets or sets the BarsTypeMonth.
        /// </summary>
        [DataMember]
        public NinjaTrader.Data.BarsType BarsTypeMonth { get; set; }
        /// <summary>
        /// Gets or sets the BarsTypeSecond.
        /// </summary>
        [DataMember]
        public NinjaTrader.Data.BarsType BarsTypeSecond { get; set; }
        /// <summary>
        /// Gets or sets the BarsTypeTick.
        /// </summary>
        [DataMember]
        public NinjaTrader.Data.BarsType BarsTypeTick { get; set; }
        /// <summary>
        /// Gets or sets the BarsTypeYear.
        /// </summary>
        [DataMember]
        public NinjaTrader.Data.BarsType BarsTypeYear { get; set; }
        /// <summary>
        /// Gets or sets the BuiltFrom.
        /// </summary>
        [DataMember]
        public BarsPeriodType BuiltFrom { get; set; }
        /// <summary>
        /// Gets or sets the DayCount.
        /// </summary>
        [DataMember]
        public int DayCount { get; set; }
        /// <summary>
        /// Gets or sets the DaysToLoad.
        /// </summary>
        [DataMember]
        public int DaysToLoad { get; set; }
        /// <summary>
        /// Gets or sets the DefaultChartStyle.
        /// </summary>
        [DataMember]
        public ChartStyleType DefaultChartStyle { get; set; }
        /// <summary>
        /// Gets or sets the DisplayNames.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<string, System.Tuple<string, int>> DisplayNames { get; set; }
        /// <summary>
        /// Gets or sets the IsIntraday.
        /// </summary>
        [DataMember]
        public bool IsIntraday { get; set; }
        /// <summary>
        /// Gets or sets the IsRemoveLastBarSupported.
        /// </summary>
        [DataMember]
        public bool IsRemoveLastBarSupported { get; set; }
        /// <summary>
        /// Gets or sets the IsTimeBased.
        /// </summary>
        [DataMember]
        public bool IsTimeBased { get; set; }
        /// <summary>
        /// Gets or sets the LogTypeName.
        /// </summary>
        [DataMember]
        public string LogTypeName { get; set; }
        /// <summary>
        /// Gets or sets the Properties.
        /// </summary>
        [DataMember]
        public System.ComponentModel.PropertyDescriptorCollection Properties { get; set; }
        /// <summary>
        /// Gets or sets the SkipCaching.
        /// </summary>
        [DataMember]
        public bool SkipCaching { get; set; }
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
        #endregion
        #region Methods
        /// <summary>
        /// ApplyDefaultValue method.
        /// </summary>
        /// <param name="period">NinjaTrader.Data.BarsPeriod</param>
        public void ApplyDefaultValue(NinjaTrader.Data.BarsPeriod period)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ApplyDefaultBasePeriodValue method.
        /// </summary>
        /// <param name="period">NinjaTrader.Data.BarsPeriod</param>
        public void ApplyDefaultBasePeriodValue(NinjaTrader.Data.BarsPeriod period)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ChartLabel method.
        /// </summary>
        /// <param name="time">System.DateTime</param>
        /// <returns>string</returns>
        public string ChartLabel(System.DateTime time)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// CreateInstance method.
        /// </summary>
        /// <param name="period">NinjaTrader.Data.BarsPeriod</param>
        /// <returns>NinjaTrader.Data.BarsType</returns>
        public NinjaTrader.Data.BarsType CreateInstance(NinjaTrader.Data.BarsPeriod period)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// CreateInstance method.
        /// </summary>
        /// <param name="periodType">BarsPeriodType</param>
        /// <returns>NinjaTrader.Data.BarsType</returns>
        public NinjaTrader.Data.BarsType CreateInstance(BarsPeriodType periodType)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ResetBarsTypes method.
        /// </summary>
        public void ResetBarsTypes()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetBarsPeriodTypeName method.
        /// </summary>
        /// <param name="barsPeriodType">BarsPeriodType</param>
        /// <returns>string</returns>
        public string GetBarsPeriodTypeName(BarsPeriodType barsPeriodType)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetInitialLookBackDays method.
        /// </summary>
        /// <param name="barsPeriod">NinjaTrader.Data.BarsPeriod</param>
        /// <param name="tradingHours">NinjaTrader.Data.TradingHours</param>
        /// <param name="barsBack">int</param>
        /// <returns>int</returns>
        public int GetInitialLookBackDays(NinjaTrader.Data.BarsPeriod barsPeriod, NinjaTrader.Data.TradingHours tradingHours, int barsBack)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetPercentComplete method.
        /// </summary>
        /// <param name="bars">NinjaTrader.Data.Bars</param>
        /// <param name="now">System.DateTime</param>
        /// <returns>double</returns>
        public double GetPercentComplete(NinjaTrader.Data.Bars bars, System.DateTime now)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetSupported method.
        /// </summary>
        /// <returns>BarsPeriodType[]</returns>
        public BarsPeriodType[] GetSupported()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// IncludesEndTimeStamp method.
        /// </summary>
        /// <param name="isBar">bool</param>
        /// <returns>bool</returns>
        public bool IncludesEndTimeStamp(bool isBar)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Merge method.
        /// </summary>
        /// <param name="barsType">NinjaTrader.Data.BarsType</param>
        public void Merge(NinjaTrader.Data.BarsType barsType)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SetIsRemoveLastBarSupported method.
        /// </summary>
        /// <param name="value">bool</param>
        public void SetIsRemoveLastBarSupported(bool value)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SetState method.
        /// </summary>
        /// <param name="state">State</param>
        public void SetState(State state)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Shutdown method.
        /// </summary>
        public void Shutdown()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// TrimEnd method.
        /// </summary>
        /// <param name="numBars">int</param>
        public void TrimEnd(int numBars)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// TrimStart method.
        /// </summary>
        /// <param name="numBars">int</param>
        public void TrimStart(int numBars)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
