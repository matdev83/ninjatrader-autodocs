[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class T3 : NinjaTrader.NinjaScript.Indicators.Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Period.
        /// </summary>
        [DataMember]
        public int Period { get; set; }
        /// <summary>
        /// Gets or sets the TCount.
        /// </summary>
        [DataMember]
        public int TCount { get; set; }
        /// <summary>
        /// Gets or sets the VFactor.
        /// </summary>
        [DataMember]
        public double VFactor { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
