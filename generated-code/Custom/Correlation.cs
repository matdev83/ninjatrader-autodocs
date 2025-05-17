[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class Correlation : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Period.
        /// </summary>
        [DataMember]
        public Int32 Period { get; set; }
        /// <summary>
        /// Gets or sets the CorrelationSeries.
        /// </summary>
        [DataMember]
        public String CorrelationSeries { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
