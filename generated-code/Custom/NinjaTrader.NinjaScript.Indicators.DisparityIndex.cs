[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class DisparityIndex : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Period.
        /// </summary>
        [DataMember]
        public Int32 Period { get; set; }
        /// <summary>
        /// Gets or sets the DisparityLine.
        /// </summary>
        [DataMember]
        public Series<Double> DisparityLine { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
