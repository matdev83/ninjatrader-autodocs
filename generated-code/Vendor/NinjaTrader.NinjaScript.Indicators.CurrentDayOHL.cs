[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class CurrentDayOHL : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the CurrentOpen.
        /// </summary>
        [DataMember]
        public Series<Double> CurrentOpen { get; set; }
        /// <summary>
        /// Gets or sets the CurrentHigh.
        /// </summary>
        [DataMember]
        public Series<Double> CurrentHigh { get; set; }
        /// <summary>
        /// Gets or sets the CurrentLow.
        /// </summary>
        [DataMember]
        public Series<Double> CurrentLow { get; set; }
        /// <summary>
        /// Gets or sets the PlotCurrentValue.
        /// </summary>
        [DataMember]
        public Boolean PlotCurrentValue { get; set; }
        /// <summary>
        /// Gets or sets the ShowHigh.
        /// </summary>
        [DataMember]
        public Boolean ShowHigh { get; set; }
        /// <summary>
        /// Gets or sets the ShowLow.
        /// </summary>
        [DataMember]
        public Boolean ShowLow { get; set; }
        /// <summary>
        /// Gets or sets the ShowOpen.
        /// </summary>
        [DataMember]
        public Boolean ShowOpen { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
