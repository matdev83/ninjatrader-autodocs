[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class AnchoredVWAP : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AnchorDate.
        /// </summary>
        [DataMember]
        public DateTime AnchorDate { get; set; }
        /// <summary>
        /// Gets or sets the AnchorTimeOfDay.
        /// </summary>
        [DataMember]
        public TimeSpan AnchorTimeOfDay { get; set; }
        /// <summary>
        /// Gets or sets the LineColor.
        /// </summary>
        [DataMember]
        public Brush LineColor { get; set; }
        /// <summary>
        /// Gets or sets the LineStyle.
        /// </summary>
        [DataMember]
        public DashStyleHelper LineStyle { get; set; }
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
