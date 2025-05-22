[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class TickCounter : NinjaTrader.NinjaScript.Indicators.Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the CountDown.
        /// </summary>
        [DataMember]
        public bool CountDown { get; set; }
        /// <summary>
        /// Gets or sets the ShowPercent.
        /// </summary>
        [DataMember]
        public bool ShowPercent { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
