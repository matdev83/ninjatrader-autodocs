[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class RangeCounter : NinjaTrader.NinjaScript.Indicators.Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the CountDown.
        /// </summary>
        [DataMember]
        public bool CountDown { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
