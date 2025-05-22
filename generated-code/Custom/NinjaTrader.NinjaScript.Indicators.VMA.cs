[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class VMA : NinjaTrader.NinjaScript.Indicators.Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Period.
        /// </summary>
        [DataMember]
        public int Period { get; set; }
        /// <summary>
        /// Gets or sets the VolatilityPeriod.
        /// </summary>
        [DataMember]
        public int VolatilityPeriod { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
