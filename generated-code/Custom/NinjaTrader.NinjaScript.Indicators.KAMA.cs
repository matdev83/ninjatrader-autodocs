[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class KAMA : NinjaTrader.NinjaScript.Indicators.Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Fast.
        /// </summary>
        [DataMember]
        public int Fast { get; set; }
        /// <summary>
        /// Gets or sets the Period.
        /// </summary>
        [DataMember]
        public int Period { get; set; }
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
