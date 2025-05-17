[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class BuySellPressure : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the BuyPressure.
        /// </summary>
        [DataMember]
        public Series<Double> BuyPressure { get; set; }
        /// <summary>
        /// Gets or sets the SellPressure.
        /// </summary>
        [DataMember]
        public Series<Double> SellPressure { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
