[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.BarsTypes
{
    public partial class TickBarsType : BarsType
    {
        #region Properties
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
        #endregion
    }
}
