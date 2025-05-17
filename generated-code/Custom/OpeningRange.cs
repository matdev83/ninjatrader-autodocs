[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class OpeningRange : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the OrStartHour.
        /// </summary>
        [DataMember]
        public Int32 OrStartHour { get; set; }
        /// <summary>
        /// Gets or sets the OrStartMinute.
        /// </summary>
        [DataMember]
        public Int32 OrStartMinute { get; set; }
        /// <summary>
        /// Gets or sets the SecondarySeriesType.
        /// </summary>
        [DataMember]
        public BarsPeriodType SecondarySeriesType { get; set; }
        /// <summary>
        /// Gets or sets the SecondarySeriesValue.
        /// </summary>
        [DataMember]
        public Int32 SecondarySeriesValue { get; set; }
        /// <summary>
        /// Gets or sets the MaxHistoricalPlots.
        /// </summary>
        [DataMember]
        public Int32 MaxHistoricalPlots { get; set; }
        /// <summary>
        /// Gets or sets the LineColor.
        /// </summary>
        [DataMember]
        public Brush LineColor { get; set; }
        /// <summary>
        /// Gets or sets the LineOpacity.
        /// </summary>
        [DataMember]
        public Int32 LineOpacity { get; set; }
        /// <summary>
        /// Gets or sets the LineWidth.
        /// </summary>
        [DataMember]
        public Int32 LineWidth { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
