[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class NBarsDown : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the BarCount.
        /// </summary>
        [DataMember]
        public Int32 BarCount { get; set; }
        /// <summary>
        /// Gets or sets the BarDown.
        /// </summary>
        [DataMember]
        public Boolean BarDown { get; set; }
        /// <summary>
        /// Gets or sets the LowerHigh.
        /// </summary>
        [DataMember]
        public Boolean LowerHigh { get; set; }
        /// <summary>
        /// Gets or sets the LowerLow.
        /// </summary>
        [DataMember]
        public Boolean LowerLow { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
