[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class HighlightBarRatioAnomaliesShifted : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the SecondaryBarsPeriodType.
        /// </summary>
        [DataMember]
        public BarsPeriodType SecondaryBarsPeriodType { get; set; }
        /// <summary>
        /// Gets or sets the SecondaryPeriodValue.
        /// </summary>
        [DataMember]
        public Int32 SecondaryPeriodValue { get; set; }
        /// <summary>
        /// Gets or sets the FutureBarsToPlot.
        /// </summary>
        [DataMember]
        public Int32 FutureBarsToPlot { get; set; }
        /// <summary>
        /// Gets or sets the MinPercentToHighlightBullish.
        /// </summary>
        [DataMember]
        public Double MinPercentToHighlightBullish { get; set; }
        /// <summary>
        /// Gets or sets the MaxPercentToHighlightBearish.
        /// </summary>
        [DataMember]
        public Double MaxPercentToHighlightBearish { get; set; }
        /// <summary>
        /// Gets or sets the UseTrendFilter.
        /// </summary>
        [DataMember]
        public Boolean UseTrendFilter { get; set; }
        /// <summary>
        /// Gets or sets the VwmaLength.
        /// </summary>
        [DataMember]
        public Int32 VwmaLength { get; set; }
        /// <summary>
        /// Gets or sets the MinSamplesAfterTrendFilter.
        /// </summary>
        [DataMember]
        public Int32 MinSamplesAfterTrendFilter { get; set; }
        /// <summary>
        /// Gets or sets the ShowSessionDiagnostics.
        /// </summary>
        [DataMember]
        public Boolean ShowSessionDiagnostics { get; set; }
        /// <summary>
        /// Gets or sets the SessionDiagnosticColor.
        /// </summary>
        [DataMember]
        public Brush SessionDiagnosticColor { get; set; }
        /// <summary>
        /// Gets or sets the MeanRatio.
        /// </summary>
        [DataMember]
        public Series<Double> MeanRatio { get; set; }
        /// <summary>
        /// Gets or sets the ZeroLine.
        /// </summary>
        [DataMember]
        public Series<Double> ZeroLine { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
