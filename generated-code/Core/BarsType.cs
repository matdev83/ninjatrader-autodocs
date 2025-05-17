[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class BarsType : NinjaScript
    {
        #region Properties
        /// <summary>
        /// Gets or sets the BarsPeriod.
        /// </summary>
        [DataMember]
        public BarsPeriod BarsPeriod { get; set; }
        /// <summary>
        /// Gets or sets the BarsTypeDay.
        /// </summary>
        [DataMember]
        public BarsType BarsTypeDay { get; set; }
        /// <summary>
        /// Gets or sets the BarsTypeMinute.
        /// </summary>
        [DataMember]
        public BarsType BarsTypeMinute { get; set; }
        /// <summary>
        /// Gets or sets the BarsTypeMonth.
        /// </summary>
        [DataMember]
        public BarsType BarsTypeMonth { get; set; }
        /// <summary>
        /// Gets or sets the BarsTypeSecond.
        /// </summary>
        [DataMember]
        public BarsType BarsTypeSecond { get; set; }
        /// <summary>
        /// Gets or sets the BarsTypeTick.
        /// </summary>
        [DataMember]
        public BarsType BarsTypeTick { get; set; }
        /// <summary>
        /// Gets or sets the BarsTypeYear.
        /// </summary>
        [DataMember]
        public BarsType BarsTypeYear { get; set; }
        /// <summary>
        /// Gets or sets the BuiltFrom.
        /// </summary>
        [DataMember]
        public BarsPeriodType BuiltFrom { get; set; }
        /// <summary>
        /// Gets or sets the DayCount.
        /// </summary>
        [DataMember]
        public Int32 DayCount { get; set; }
        /// <summary>
        /// Gets or sets the DaysToLoad.
        /// </summary>
        [DataMember]
        public Int32 DaysToLoad { get; set; }
        /// <summary>
        /// Gets or sets the DefaultChartStyle.
        /// </summary>
        [DataMember]
        public ChartStyleType DefaultChartStyle { get; set; }
        /// <summary>
        /// Gets or sets the DisplayNames.
        /// </summary>
        [DataMember]
        public Dictionary<String, Tuple<String, Int32>> DisplayNames { get; set; }
        /// <summary>
        /// Gets or sets the IsIntraday.
        /// </summary>
        [DataMember]
        public Boolean IsIntraday { get; set; }
        /// <summary>
        /// Gets or sets the IsRemoveLastBarSupported.
        /// </summary>
        [DataMember]
        public Boolean IsRemoveLastBarSupported { get; set; }
        /// <summary>
        /// Gets or sets the IsTimeBased.
        /// </summary>
        [DataMember]
        public Boolean IsTimeBased { get; set; }
        /// <summary>
        /// Gets or sets the LogTypeName.
        /// </summary>
        [DataMember]
        public String LogTypeName { get; set; }
        /// <summary>
        /// Gets or sets the Properties.
        /// </summary>
        [DataMember]
        public PropertyDescriptorCollection Properties { get; set; }
        /// <summary>
        /// Gets or sets the SkipCaching.
        /// </summary>
        [DataMember]
        public Boolean SkipCaching { get; set; }
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
        #endregion
        #region Methods
        /// <summary>
        /// ApplyDefaultValue method.
        /// </summary>
        /// <param name="period">BarsPeriod</param>
        public Void ApplyDefaultValue(BarsPeriod period);
        /// <summary>
        /// ApplyDefaultBasePeriodValue method.
        /// </summary>
        /// <param name="period">BarsPeriod</param>
        public Void ApplyDefaultBasePeriodValue(BarsPeriod period);
        /// <summary>
        /// ChartLabel method.
        /// </summary>
        /// <param name="time">DateTime</param>
        /// <returns>String</returns>
        public String ChartLabel(DateTime time);
        /// <summary>
        /// CreateInstance method.
        /// </summary>
        /// <param name="period">BarsPeriod</param>
        /// <returns>BarsType</returns>
        public BarsType CreateInstance(BarsPeriod period);
        /// <summary>
        /// CreateInstance method.
        /// </summary>
        /// <param name="periodType">BarsPeriodType</param>
        /// <returns>BarsType</returns>
        public BarsType CreateInstance(BarsPeriodType periodType);
        /// <summary>
        /// ResetBarsTypes method.
        /// </summary>
        public Void ResetBarsTypes();
        /// <summary>
        /// GetBarsPeriodTypeName method.
        /// </summary>
        /// <param name="barsPeriodType">BarsPeriodType</param>
        /// <returns>String</returns>
        public String GetBarsPeriodTypeName(BarsPeriodType barsPeriodType);
        /// <summary>
        /// GetInitialLookBackDays method.
        /// </summary>
        /// <param name="barsPeriod">BarsPeriod</param>
        /// <param name="tradingHours">TradingHours</param>
        /// <param name="barsBack">Int32</param>
        /// <returns>Int32</returns>
        public Int32 GetInitialLookBackDays(BarsPeriod barsPeriod, TradingHours tradingHours, Int32 barsBack);
        /// <summary>
        /// GetPercentComplete method.
        /// </summary>
        /// <param name="bars">Bars</param>
        /// <param name="now">DateTime</param>
        /// <returns>Double</returns>
        public Double GetPercentComplete(Bars bars, DateTime now);
        /// <summary>
        /// GetSupported method.
        /// </summary>
        /// <returns>BarsPeriodType[]</returns>
        public BarsPeriodType[] GetSupported();
        /// <summary>
        /// IncludesEndTimeStamp method.
        /// </summary>
        /// <param name="isBar">Boolean</param>
        /// <returns>Boolean</returns>
        public Boolean IncludesEndTimeStamp(Boolean isBar);
        /// <summary>
        /// Merge method.
        /// </summary>
        /// <param name="barsType">BarsType</param>
        public Void Merge(BarsType barsType);
        /// <summary>
        /// SetIsRemoveLastBarSupported method.
        /// </summary>
        /// <param name="value">Boolean</param>
        public Void SetIsRemoveLastBarSupported(Boolean value);
        /// <summary>
        /// SetState method.
        /// </summary>
        /// <param name="state">State</param>
        public Void SetState(State state);
        /// <summary>
        /// Shutdown method.
        /// </summary>
        public Void Shutdown();
        /// <summary>
        /// TrimEnd method.
        /// </summary>
        /// <param name="numBars">Int32</param>
        public Void TrimEnd(Int32 numBars);
        /// <summary>
        /// TrimStart method.
        /// </summary>
        /// <param name="numBars">Int32</param>
        public Void TrimStart(Int32 numBars);
        #endregion
    }
}
