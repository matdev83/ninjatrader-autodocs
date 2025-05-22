[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class NBarsDown : NinjaTrader.NinjaScript.Indicators.Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the BarCount.
        /// </summary>
        [DataMember]
        public int BarCount { get; set; }
        /// <summary>
        /// Gets or sets the BarDown.
        /// </summary>
        [DataMember]
        public bool BarDown { get; set; }
        /// <summary>
        /// Gets or sets the LowerHigh.
        /// </summary>
        [DataMember]
        public bool LowerHigh { get; set; }
        /// <summary>
        /// Gets or sets the LowerLow.
        /// </summary>
        [DataMember]
        public bool LowerLow { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
