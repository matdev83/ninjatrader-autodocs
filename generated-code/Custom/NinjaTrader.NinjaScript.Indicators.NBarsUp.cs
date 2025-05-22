[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class NBarsUp : NinjaTrader.NinjaScript.Indicators.Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the BarCount.
        /// </summary>
        [DataMember]
        public int BarCount { get; set; }
        /// <summary>
        /// Gets or sets the BarUp.
        /// </summary>
        [DataMember]
        public bool BarUp { get; set; }
        /// <summary>
        /// Gets or sets the HigherHigh.
        /// </summary>
        [DataMember]
        public bool HigherHigh { get; set; }
        /// <summary>
        /// Gets or sets the HigherLow.
        /// </summary>
        [DataMember]
        public bool HigherLow { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
