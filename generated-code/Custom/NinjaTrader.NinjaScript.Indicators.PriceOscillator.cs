[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class PriceOscillator : NinjaTrader.NinjaScript.Indicators.Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Fast.
        /// </summary>
        [DataMember]
        public int Fast { get; set; }
        /// <summary>
        /// Gets or sets the Slow.
        /// </summary>
        [DataMember]
        public int Slow { get; set; }
        /// <summary>
        /// Gets or sets the Smooth.
        /// </summary>
        [DataMember]
        public int Smooth { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
