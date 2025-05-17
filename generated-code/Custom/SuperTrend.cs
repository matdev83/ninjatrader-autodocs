[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class SuperTrend : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the ATRMultiplier.
        /// </summary>
        [DataMember]
        public Double ATRMultiplier { get; set; }
        /// <summary>
        /// Gets or sets the ATRPeriod.
        /// </summary>
        [DataMember]
        public Int32 ATRPeriod { get; set; }
        /// <summary>
        /// Gets or sets the IsUpTrend.
        /// </summary>
        [DataMember]
        public Boolean IsUpTrend { get; set; }
        /// <summary>
        /// Gets or sets the IsDownTrend.
        /// </summary>
        [DataMember]
        public Boolean IsDownTrend { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
