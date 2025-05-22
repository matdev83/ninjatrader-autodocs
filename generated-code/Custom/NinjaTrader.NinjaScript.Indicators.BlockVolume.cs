[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class BlockVolume : NinjaTrader.NinjaScript.Indicators.Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the BlockSize.
        /// </summary>
        [DataMember]
        public double BlockSize { get; set; }
        /// <summary>
        /// Gets or sets the CountType.
        /// </summary>
        [DataMember]
        public CountType CountType { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
