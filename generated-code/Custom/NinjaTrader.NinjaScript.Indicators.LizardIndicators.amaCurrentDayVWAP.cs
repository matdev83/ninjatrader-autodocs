[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators.LizardIndicators
{
    public partial class amaCurrentDayVWAP : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the SessionVWAP.
        /// </summary>
        [DataMember]
        public Series<Double> SessionVWAP { get; set; }
        /// <summary>
        /// Gets or sets the UpperBand3.
        /// </summary>
        [DataMember]
        public Series<Double> UpperBand3 { get; set; }
        /// <summary>
        /// Gets or sets the UpperBand2.
        /// </summary>
        [DataMember]
        public Series<Double> UpperBand2 { get; set; }
        /// <summary>
        /// Gets or sets the UpperBand1.
        /// </summary>
        [DataMember]
        public Series<Double> UpperBand1 { get; set; }
        /// <summary>
        /// Gets or sets the LowerBand1.
        /// </summary>
        [DataMember]
        public Series<Double> LowerBand1 { get; set; }
        /// <summary>
        /// Gets or sets the LowerBand2.
        /// </summary>
        [DataMember]
        public Series<Double> LowerBand2 { get; set; }
        /// <summary>
        /// Gets or sets the LowerBand3.
        /// </summary>
        [DataMember]
        public Series<Double> LowerBand3 { get; set; }
        /// <summary>
        /// Gets or sets the SessionType.
        /// </summary>
        [DataMember]
        public amaSessionTypeVWAPD SessionType { get; set; }
        /// <summary>
        /// Gets or sets the BandType.
        /// </summary>
        [DataMember]
        public amaBandTypeVWAPD BandType { get; set; }
        /// <summary>
        /// Gets or sets the CustomTZSelector.
        /// </summary>
        [DataMember]
        public amaTimeZonesVWAPD CustomTZSelector { get; set; }
        /// <summary>
        /// Gets or sets the CustomSessionStart.
        /// </summary>
        [DataMember]
        public TimeSpan CustomSessionStart { get; set; }
        /// <summary>
        /// Gets or sets the S_CustomSessionStart.
        /// </summary>
        [DataMember]
        public String S_CustomSessionStart { get; set; }
        /// <summary>
        /// Gets or sets the CustomSessionEnd.
        /// </summary>
        [DataMember]
        public TimeSpan CustomSessionEnd { get; set; }
        /// <summary>
        /// Gets or sets the S_CustomSessionEnd.
        /// </summary>
        [DataMember]
        public String S_CustomSessionEnd { get; set; }
        /// <summary>
        /// Gets or sets the MultiplierSD1.
        /// </summary>
        [DataMember]
        public Double MultiplierSD1 { get; set; }
        /// <summary>
        /// Gets or sets the MultiplierSD2.
        /// </summary>
        [DataMember]
        public Double MultiplierSD2 { get; set; }
        /// <summary>
        /// Gets or sets the MultiplierSD3.
        /// </summary>
        [DataMember]
        public Double MultiplierSD3 { get; set; }
        /// <summary>
        /// Gets or sets the MultiplierQR1.
        /// </summary>
        [DataMember]
        public Double MultiplierQR1 { get; set; }
        /// <summary>
        /// Gets or sets the MultiplierQR2.
        /// </summary>
        [DataMember]
        public Double MultiplierQR2 { get; set; }
        /// <summary>
        /// Gets or sets the MultiplierQR3.
        /// </summary>
        [DataMember]
        public Double MultiplierQR3 { get; set; }
        /// <summary>
        /// Gets or sets the UpBrush.
        /// </summary>
        [DataMember]
        public Brush UpBrush { get; set; }
        /// <summary>
        /// Gets or sets the UpBrushSerializable.
        /// </summary>
        [DataMember]
        public String UpBrushSerializable { get; set; }
        /// <summary>
        /// Gets or sets the DownBrush.
        /// </summary>
        [DataMember]
        public Brush DownBrush { get; set; }
        /// <summary>
        /// Gets or sets the DownBrushSerializable.
        /// </summary>
        [DataMember]
        public String DownBrushSerializable { get; set; }
        /// <summary>
        /// Gets or sets the InnerBandBrush.
        /// </summary>
        [DataMember]
        public Brush InnerBandBrush { get; set; }
        /// <summary>
        /// Gets or sets the InnerBandBrushSerializable.
        /// </summary>
        [DataMember]
        public String InnerBandBrushSerializable { get; set; }
        /// <summary>
        /// Gets or sets the MiddleBandBrush.
        /// </summary>
        [DataMember]
        public Brush MiddleBandBrush { get; set; }
        /// <summary>
        /// Gets or sets the MiddleBandBrushSerializable.
        /// </summary>
        [DataMember]
        public String MiddleBandBrushSerializable { get; set; }
        /// <summary>
        /// Gets or sets the OuterBandBrush.
        /// </summary>
        [DataMember]
        public Brush OuterBandBrush { get; set; }
        /// <summary>
        /// Gets or sets the OuterBandBrushSerializable.
        /// </summary>
        [DataMember]
        public String OuterBandBrushSerializable { get; set; }
        /// <summary>
        /// Gets or sets the Plot0Style.
        /// </summary>
        [DataMember]
        public PlotStyle Plot0Style { get; set; }
        /// <summary>
        /// Gets or sets the Dash0Style.
        /// </summary>
        [DataMember]
        public DashStyleHelper Dash0Style { get; set; }
        /// <summary>
        /// Gets or sets the Plot0Width.
        /// </summary>
        [DataMember]
        public Int32 Plot0Width { get; set; }
        /// <summary>
        /// Gets or sets the Plot1Style.
        /// </summary>
        [DataMember]
        public PlotStyle Plot1Style { get; set; }
        /// <summary>
        /// Gets or sets the Dash1Style.
        /// </summary>
        [DataMember]
        public DashStyleHelper Dash1Style { get; set; }
        /// <summary>
        /// Gets or sets the Plot1Width.
        /// </summary>
        [DataMember]
        public Int32 Plot1Width { get; set; }
        /// <summary>
        /// Gets or sets the InnerAreaOpacity.
        /// </summary>
        [DataMember]
        public Int32 InnerAreaOpacity { get; set; }
        /// <summary>
        /// Gets or sets the MiddleAreaOpacity.
        /// </summary>
        [DataMember]
        public Int32 MiddleAreaOpacity { get; set; }
        /// <summary>
        /// Gets or sets the OuterAreaOpacity.
        /// </summary>
        [DataMember]
        public Int32 OuterAreaOpacity { get; set; }
        /// <summary>
        /// Gets or sets the VersionString.
        /// </summary>
        [DataMember]
        public String VersionString { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// FormatPriceMarker method.
        /// </summary>
        /// <param name="price">Double</param>
        /// <returns>String</returns>
        public String FormatPriceMarker(Double price);
        /// <summary>
        /// OnRenderTargetChanged method.
        /// </summary>
        public Void OnRenderTargetChanged();
        #endregion
    }
}
