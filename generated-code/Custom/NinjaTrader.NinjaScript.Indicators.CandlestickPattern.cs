[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class CandlestickPattern : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the PatternFound.
        /// </summary>
        [DataMember]
        public Series<Double> PatternFound { get; set; }
        /// <summary>
        /// Gets or sets the Pattern.
        /// </summary>
        [DataMember]
        public ChartPattern Pattern { get; set; }
        /// <summary>
        /// Gets or sets the ShowAlerts.
        /// </summary>
        [DataMember]
        public Boolean ShowAlerts { get; set; }
        /// <summary>
        /// Gets or sets the ShowPatternCount.
        /// </summary>
        [DataMember]
        public Boolean ShowPatternCount { get; set; }
        /// <summary>
        /// Gets or sets the TextFont.
        /// </summary>
        [DataMember]
        public SimpleFont TextFont { get; set; }
        /// <summary>
        /// Gets or sets the TrendStrength.
        /// </summary>
        [DataMember]
        public Int32 TrendStrength { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>String</returns>
        public String ToString();
        #endregion
    }
}
