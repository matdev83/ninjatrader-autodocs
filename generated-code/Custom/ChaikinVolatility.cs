[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class ChaikinVolatility : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the MAPeriod.
        /// </summary>
        [DataMember]
        public Int32 MAPeriod { get; set; }
        /// <summary>
        /// Gets or sets the ROCPeriod.
        /// </summary>
        [DataMember]
        public Int32 ROCPeriod { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
