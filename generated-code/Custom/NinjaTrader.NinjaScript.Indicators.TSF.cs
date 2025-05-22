[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class TSF : NinjaTrader.NinjaScript.Indicators.Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Forecast.
        /// </summary>
        [DataMember]
        public int Forecast { get; set; }
        /// <summary>
        /// Gets or sets the Period.
        /// </summary>
        [DataMember]
        public int Period { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
