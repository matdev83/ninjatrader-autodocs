[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class OrderFlowVWAP : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the VWAP.
        /// </summary>
        [DataMember]
        public Series<Double> VWAP { get; set; }
        /// <summary>
        /// Gets or sets the StdDev1Upper.
        /// </summary>
        [DataMember]
        public Series<Double> StdDev1Upper { get; set; }
        /// <summary>
        /// Gets or sets the StdDev1Lower.
        /// </summary>
        [DataMember]
        public Series<Double> StdDev1Lower { get; set; }
        /// <summary>
        /// Gets or sets the StdDev2Upper.
        /// </summary>
        [DataMember]
        public Series<Double> StdDev2Upper { get; set; }
        /// <summary>
        /// Gets or sets the StdDev2Lower.
        /// </summary>
        [DataMember]
        public Series<Double> StdDev2Lower { get; set; }
        /// <summary>
        /// Gets or sets the StdDev3Upper.
        /// </summary>
        [DataMember]
        public Series<Double> StdDev3Upper { get; set; }
        /// <summary>
        /// Gets or sets the StdDev3Lower.
        /// </summary>
        [DataMember]
        public Series<Double> StdDev3Lower { get; set; }
        /// <summary>
        /// Gets or sets the ResetInterval.
        /// </summary>
        [DataMember]
        public VWAPResetInterval ResetInterval { get; set; }
        /// <summary>
        /// Gets or sets the Resolution.
        /// </summary>
        [DataMember]
        public VWAPResolution Resolution { get; set; }
        /// <summary>
        /// Gets or sets the TradingHoursInstance.
        /// </summary>
        [DataMember]
        public TradingHours TradingHoursInstance { get; set; }
        /// <summary>
        /// Gets or sets the TradingHoursSerializable.
        /// </summary>
        [DataMember]
        public String TradingHoursSerializable { get; set; }
        /// <summary>
        /// Gets or sets the NumStandardDeviations.
        /// </summary>
        [DataMember]
        public VWAPStandardDeviations NumStandardDeviations { get; set; }
        /// <summary>
        /// Gets or sets the SD1Multiplier.
        /// </summary>
        [DataMember]
        public Double SD1Multiplier { get; set; }
        /// <summary>
        /// Gets or sets the BandAreaBrush.
        /// </summary>
        [DataMember]
        public Brush BandAreaBrush { get; set; }
        /// <summary>
        /// Gets or sets the BandAreaBrushSeralizer.
        /// </summary>
        [DataMember]
        public String BandAreaBrushSeralizer { get; set; }
        /// <summary>
        /// Gets or sets the BandAreaOpacity.
        /// </summary>
        [DataMember]
        public Int32 BandAreaOpacity { get; set; }
        /// <summary>
        /// Gets or sets the SD2Multiplier.
        /// </summary>
        [DataMember]
        public Double SD2Multiplier { get; set; }
        /// <summary>
        /// Gets or sets the BandAreaBrush2.
        /// </summary>
        [DataMember]
        public Brush BandAreaBrush2 { get; set; }
        /// <summary>
        /// Gets or sets the BandAreaBrushSeralizer2.
        /// </summary>
        [DataMember]
        public String BandAreaBrushSeralizer2 { get; set; }
        /// <summary>
        /// Gets or sets the BandAreaOpacity2.
        /// </summary>
        [DataMember]
        public Int32 BandAreaOpacity2 { get; set; }
        /// <summary>
        /// Gets or sets the SD3Multiplier.
        /// </summary>
        [DataMember]
        public Double SD3Multiplier { get; set; }
        /// <summary>
        /// Gets or sets the BandAreaBrush3.
        /// </summary>
        [DataMember]
        public Brush BandAreaBrush3 { get; set; }
        /// <summary>
        /// Gets or sets the BandAreaBrushSeralizer3.
        /// </summary>
        [DataMember]
        public String BandAreaBrushSeralizer3 { get; set; }
        /// <summary>
        /// Gets or sets the BandAreaOpacity3.
        /// </summary>
        [DataMember]
        public Int32 BandAreaOpacity3 { get; set; }
        /// <summary>
        /// Gets or sets the AbovePriceBrush.
        /// </summary>
        [DataMember]
        public Brush AbovePriceBrush { get; set; }
        /// <summary>
        /// Gets or sets the AbovePriceBrushSeralizer.
        /// </summary>
        [DataMember]
        public String AbovePriceBrushSeralizer { get; set; }
        /// <summary>
        /// Gets or sets the BelowPriceBrush.
        /// </summary>
        [DataMember]
        public Brush BelowPriceBrush { get; set; }
        /// <summary>
        /// Gets or sets the BelowPriceBrushSeralizer.
        /// </summary>
        [DataMember]
        public String BelowPriceBrushSeralizer { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
