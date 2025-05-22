[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class ChaikinOscillator : NinjaTrader.NinjaScript.Indicators.Indicator
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
        #endregion
        #region Methods
        #endregion
    }
}
