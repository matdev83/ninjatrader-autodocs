[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.BarsTypes
{
    public partial class PriceOnVolumeBarsType : BarsType
    {
        #region Properties
        /// <summary>
        /// Gets or sets the SkipCaching.
        /// </summary>
        [DataMember]
        public Boolean SkipCaching { get; set; }
        /// <summary>
        /// Gets or sets the Volumes.
        /// </summary>
        [DataMember]
        public PriceOnVolumeData[] Volumes { get; set; }
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
        /// Merge method.
        /// </summary>
        /// <param name="barsType">BarsType</param>
        public Void Merge(BarsType barsType);
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
