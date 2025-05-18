[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class BuySellVolume : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Sells.
        /// </summary>
        [DataMember]
        public Series<Double> Sells { get; set; }
        /// <summary>
        /// Gets or sets the Buys.
        /// </summary>
        [DataMember]
        public Series<Double> Buys { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
