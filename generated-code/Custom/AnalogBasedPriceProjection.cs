[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class AnalogBasedPriceProjection : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the NumMatches.
        /// </summary>
        [DataMember]
        public Int32 NumMatches { get; set; }
        /// <summary>
        /// Gets or sets the ProjectionWindow.
        /// </summary>
        [DataMember]
        public Int32 ProjectionWindow { get; set; }
        /// <summary>
        /// Gets or sets the UseDayOfWeekStats.
        /// </summary>
        [DataMember]
        public Boolean UseDayOfWeekStats { get; set; }
        /// <summary>
        /// Gets or sets the MatchVolatilityRegime.
        /// </summary>
        [DataMember]
        public Boolean MatchVolatilityRegime { get; set; }
        /// <summary>
        /// Gets or sets the CumReturnWeight.
        /// </summary>
        [DataMember]
        public Double CumReturnWeight { get; set; }
        /// <summary>
        /// Gets or sets the DebugOutput.
        /// </summary>
        [DataMember]
        public Boolean DebugOutput { get; set; }
        /// <summary>
        /// Gets or sets the MinUpsideProbabilityAlertBullishThreshold.
        /// </summary>
        [DataMember]
        public Double MinUpsideProbabilityAlertBullishThreshold { get; set; }
        /// <summary>
        /// Gets or sets the MaxUpsideProbabilityAlertBearishThreshold.
        /// </summary>
        [DataMember]
        public Double MaxUpsideProbabilityAlertBearishThreshold { get; set; }
        /// <summary>
        /// Gets or sets the MinimumMatchedHistoricalBars.
        /// </summary>
        [DataMember]
        public Int32 MinimumMatchedHistoricalBars { get; set; }
        /// <summary>
        /// Gets or sets the MinBarsBetweenVoiceAlerts.
        /// </summary>
        [DataMember]
        public Int32 MinBarsBetweenVoiceAlerts { get; set; }
        /// <summary>
        /// Gets or sets the MinimumProjectionPriceChangePts.
        /// </summary>
        [DataMember]
        public Double MinimumProjectionPriceChangePts { get; set; }
        /// <summary>
        /// Gets or sets the MaxSimilarAnalogsWeightMultiplier.
        /// </summary>
        [DataMember]
        public Double MaxSimilarAnalogsWeightMultiplier { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
