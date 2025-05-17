[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class VWMACenteredATRBands : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the VWMAPeriod.
        /// </summary>
        [DataMember]
        public Int32 VWMAPeriod { get; set; }
        /// <summary>
        /// Gets or sets the ATRPeriod.
        /// </summary>
        [DataMember]
        public Int32 ATRPeriod { get; set; }
        /// <summary>
        /// Gets or sets the Multiplier.
        /// </summary>
        [DataMember]
        public Double Multiplier { get; set; }
        /// <summary>
        /// Gets or sets the VWMAPlot.
        /// </summary>
        [DataMember]
        public Series<Double> VWMAPlot { get; set; }
        /// <summary>
        /// Gets or sets the UpperBand.
        /// </summary>
        [DataMember]
        public Series<Double> UpperBand { get; set; }
        /// <summary>
        /// Gets or sets the LowerBand.
        /// </summary>
        [DataMember]
        public Series<Double> LowerBand { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
