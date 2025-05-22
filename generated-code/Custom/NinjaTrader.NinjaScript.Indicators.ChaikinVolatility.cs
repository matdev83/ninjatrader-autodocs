[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class ChaikinVolatility : NinjaTrader.NinjaScript.Indicators.Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the MAPeriod.
        /// </summary>
        [DataMember]
        public int MAPeriod { get; set; }
        /// <summary>
        /// Gets or sets the ROCPeriod.
        /// </summary>
        [DataMember]
        public int ROCPeriod { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
