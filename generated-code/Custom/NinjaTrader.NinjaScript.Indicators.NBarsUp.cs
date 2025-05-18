[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class NBarsUp : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the BarCount.
        /// </summary>
        [DataMember]
        public Int32 BarCount { get; set; }
        /// <summary>
        /// Gets or sets the BarUp.
        /// </summary>
        [DataMember]
        public Boolean BarUp { get; set; }
        /// <summary>
        /// Gets or sets the HigherHigh.
        /// </summary>
        [DataMember]
        public Boolean HigherHigh { get; set; }
        /// <summary>
        /// Gets or sets the HigherLow.
        /// </summary>
        [DataMember]
        public Boolean HigherLow { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
