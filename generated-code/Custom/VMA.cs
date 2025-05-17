[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class VMA : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Period.
        /// </summary>
        [DataMember]
        public Int32 Period { get; set; }
        /// <summary>
        /// Gets or sets the VolatilityPeriod.
        /// </summary>
        [DataMember]
        public Int32 VolatilityPeriod { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
