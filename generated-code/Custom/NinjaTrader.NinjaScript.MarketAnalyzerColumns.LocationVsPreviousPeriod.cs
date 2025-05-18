[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.MarketAnalyzerColumns
{
    public partial class LocationVsPreviousPeriod : MarketAnalyzerColumn
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Range.
        /// </summary>
        [DataMember]
        public PeriodRangeType Range { get; set; }
        /// <summary>
        /// Gets or sets the UseVoiceAlerts.
        /// </summary>
        [DataMember]
        public Boolean UseVoiceAlerts { get; set; }
        /// <summary>
        /// Gets or sets the MinimumBarsAlertInterval.
        /// </summary>
        [DataMember]
        public Int32 MinimumBarsAlertInterval { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Format method.
        /// </summary>
        /// <param name="value">Double</param>
        /// <returns>String</returns>
        public String Format(Double value);
        #endregion
    }
}
