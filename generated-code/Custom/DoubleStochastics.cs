[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class DoubleStochastics : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the K.
        /// </summary>
        [DataMember]
        public Series<Double> K { get; set; }
        /// <summary>
        /// Gets or sets the Period.
        /// </summary>
        [DataMember]
        public Int32 Period { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
