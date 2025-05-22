[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class Correlation : NinjaTrader.NinjaScript.Indicators.Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Period.
        /// </summary>
        [DataMember]
        public int Period { get; set; }
        /// <summary>
        /// Gets or sets the CorrelationSeries.
        /// </summary>
        [DataMember]
        public string CorrelationSeries { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
