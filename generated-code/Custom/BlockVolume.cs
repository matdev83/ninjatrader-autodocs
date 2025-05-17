[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class BlockVolume : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the BlockSize.
        /// </summary>
        [DataMember]
        public Double BlockSize { get; set; }
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
