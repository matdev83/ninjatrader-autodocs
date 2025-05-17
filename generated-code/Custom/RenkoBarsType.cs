[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.BarsTypes
{
    public partial class RenkoBarsType : BarsType
    {
        #region Properties
        /// <summary>
        /// Gets or sets the IsRemoveLastBarSupported.
        /// </summary>
        [DataMember]
        public Boolean IsRemoveLastBarSupported { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// ApplyDefaultBasePeriodValue method.
        /// </summary>
        /// <param name="period">BarsPeriod</param>
        public Void ApplyDefaultBasePeriodValue(BarsPeriod period);
        /// <summary>
        /// ApplyDefaultValue method.
        /// </summary>
        /// <param name="period">BarsPeriod</param>
        public Void ApplyDefaultValue(BarsPeriod period);
        /// <summary>
        /// ChartLabel method.
        /// </summary>
        /// <param name="time">DateTime</param>
        /// <returns>String</returns>
        public String ChartLabel(DateTime time);
        /// <summary>
        /// GetInitialLookBackDays method.
        /// </summary>
        /// <param name="period">BarsPeriod</param>
        /// <param name="tradingHours">TradingHours</param>
        /// <param name="barsBack">Int32</param>
        /// <returns>Int32</returns>
        public Int32 GetInitialLookBackDays(BarsPeriod period, TradingHours tradingHours, Int32 barsBack);
        /// <summary>
        /// GetPercentComplete method.
        /// </summary>
        /// <param name="bars">Bars</param>
        /// <param name="now">DateTime</param>
        /// <returns>Double</returns>
        public Double GetPercentComplete(Bars bars, DateTime now);
        #endregion
    }
}
