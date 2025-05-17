[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class Darvas : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the BuySignal.
        /// </summary>
        [DataMember]
        public Boolean BuySignal { get; set; }
        /// <summary>
        /// Gets or sets the Lower.
        /// </summary>
        [DataMember]
        public Series<Double> Lower { get; set; }
        /// <summary>
        /// Gets or sets the SellSignal.
        /// </summary>
        [DataMember]
        public Boolean SellSignal { get; set; }
        /// <summary>
        /// Gets or sets the Upper.
        /// </summary>
        [DataMember]
        public Series<Double> Upper { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
