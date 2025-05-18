namespace NinjaTrader.NinjaScript.Indicators
{
    public partial interface IVolumeProfilePropertiesProvider
    {
        #region Properties
        /// <summary>
        /// Gets or sets the ColorAsk.
        /// </summary>
        [DataMember]
        public Brush ColorAsk { get; set; }
        /// <summary>
        /// Gets or sets the ColorBid.
        /// </summary>
        [DataMember]
        public Brush ColorBid { get; set; }
        /// <summary>
        /// Gets or sets the ColorBarOutline.
        /// </summary>
        [DataMember]
        public Brush ColorBarOutline { get; set; }
        /// <summary>
        /// Gets or sets the ColorByTime.
        /// </summary>
        [DataMember]
        public Boolean ColorByTime { get; set; }
        /// <summary>
        /// Gets or sets the ColorHighHeat.
        /// </summary>
        [DataMember]
        public Brush ColorHighHeat { get; set; }
        /// <summary>
        /// Gets or sets the ColorLowHeat.
        /// </summary>
        [DataMember]
        public Brush ColorLowHeat { get; set; }
        /// <summary>
        /// Gets or sets the ColorPoc.
        /// </summary>
        [DataMember]
        public Brush ColorPoc { get; set; }
        /// <summary>
        /// Gets or sets the ColorProfileSummary.
        /// </summary>
        [DataMember]
        public Brush ColorProfileSummary { get; set; }
        /// <summary>
        /// Gets or sets the ColorVolumeData.
        /// </summary>
        [DataMember]
        public Brush ColorVolumeData { get; set; }
        /// <summary>
        /// Gets or sets the DeltaType.
        /// </summary>
        [DataMember]
        public VolumetricDeltaType DeltaType { get; set; }
        /// <summary>
        /// Gets or sets the DisplayMode.
        /// </summary>
        [DataMember]
        public MarketProfileDisplayMode DisplayMode { get; set; }
        /// <summary>
        /// Gets or sets the DrawMode.
        /// </summary>
        [DataMember]
        public MarketProfilePriceDrawMode DrawMode { get; set; }
        /// <summary>
        /// Gets or sets the InitialBalanceMinutes.
        /// </summary>
        [DataMember]
        public Int32 InitialBalanceMinutes { get; set; }
        /// <summary>
        /// Gets or sets the InitialPocLine.
        /// </summary>
        [DataMember]
        public LabeledGridLine InitialPocLine { get; set; }
        /// <summary>
        /// Gets or sets the InitialVaLine.
        /// </summary>
        [DataMember]
        public LabeledGridLine InitialVaLine { get; set; }
        /// <summary>
        /// Gets or sets the InitialRangeLine.
        /// </summary>
        [DataMember]
        public LabeledGridLine InitialRangeLine { get; set; }
        /// <summary>
        /// Gets or sets the Instrument.
        /// </summary>
        [DataMember]
        public Instrument Instrument { get; set; }
        /// <summary>
        /// Gets or sets the LabelFont.
        /// </summary>
        [DataMember]
        public SimpleFont LabelFont { get; set; }
        /// <summary>
        /// Gets or sets the PocLine.
        /// </summary>
        [DataMember]
        public LabeledGridLine PocLine { get; set; }
        /// <summary>
        /// Gets or sets the ProfileAlignment.
        /// </summary>
        [DataMember]
        public MarketProfileAlignment ProfileAlignment { get; set; }
        /// <summary>
        /// Gets or sets the ProfileOpacity.
        /// </summary>
        [DataMember]
        public Int32 ProfileOpacity { get; set; }
        /// <summary>
        /// Gets or sets the ProfileType.
        /// </summary>
        [DataMember]
        public MarketProfileType ProfileType { get; set; }
        /// <summary>
        /// Gets or sets the RangeLine.
        /// </summary>
        [DataMember]
        public LabeledGridLine RangeLine { get; set; }
        /// <summary>
        /// Gets or sets the Resolution.
        /// </summary>
        [DataMember]
        public MarketProfileResolution Resolution { get; set; }
        /// <summary>
        /// Gets or sets the ShowPoc.
        /// </summary>
        [DataMember]
        public Boolean ShowPoc { get; set; }
        /// <summary>
        /// Gets or sets the ShowVa.
        /// </summary>
        [DataMember]
        public Boolean ShowVa { get; set; }
        /// <summary>
        /// Gets or sets the ShowVolumeData.
        /// </summary>
        [DataMember]
        public Boolean ShowVolumeData { get; set; }
        /// <summary>
        /// Gets or sets the ShowProfileSummary.
        /// </summary>
        [DataMember]
        public Boolean ShowProfileSummary { get; set; }
        /// <summary>
        /// Gets or sets the SummaryDisplayUnit.
        /// </summary>
        [DataMember]
        public ValueUnit SummaryDisplayUnit { get; set; }
        /// <summary>
        /// Gets or sets the TicksPerLevel.
        /// </summary>
        [DataMember]
        public Int32 TicksPerLevel { get; set; }
        /// <summary>
        /// Gets or sets the TpoColors.
        /// </summary>
        [DataMember]
        public Brush[] TpoColors { get; set; }
        /// <summary>
        /// Gets or sets the VaLine.
        /// </summary>
        [DataMember]
        public LabeledGridLine VaLine { get; set; }
        /// <summary>
        /// Gets or sets the ValueArea.
        /// </summary>
        [DataMember]
        public Int32 ValueArea { get; set; }
        /// <summary>
        /// Gets or sets the ValueAreaOpacity.
        /// </summary>
        [DataMember]
        public Int32 ValueAreaOpacity { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
