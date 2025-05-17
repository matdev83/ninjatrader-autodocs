[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class TrendLines : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Strength.
        /// </summary>
        [DataMember]
        public Int32 Strength { get; set; }
        /// <summary>
        /// Gets or sets the NumberOfTrendLines.
        /// </summary>
        [DataMember]
        public Int32 NumberOfTrendLines { get; set; }
        /// <summary>
        /// Gets or sets the OldTrendsOpacity.
        /// </summary>
        [DataMember]
        public Int32 OldTrendsOpacity { get; set; }
        /// <summary>
        /// Gets or sets the AlertOnBreak.
        /// </summary>
        [DataMember]
        public Boolean AlertOnBreak { get; set; }
        /// <summary>
        /// Gets or sets the AlertOnBreakSound.
        /// </summary>
        [DataMember]
        public String AlertOnBreakSound { get; set; }
        /// <summary>
        /// Gets or sets the TrendLineHighStroke.
        /// </summary>
        [DataMember]
        public Stroke TrendLineHighStroke { get; set; }
        /// <summary>
        /// Gets or sets the TrendLineLowStroke.
        /// </summary>
        [DataMember]
        public Stroke TrendLineLowStroke { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// OnCalculateMinMax method.
        /// </summary>
        public Void OnCalculateMinMax();
        #endregion
    }
}
