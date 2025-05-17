[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Strategies
{
    public partial class SampleMACrossOver : Strategy
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Fast.
        /// </summary>
        [DataMember]
        public Int32 Fast { get; set; }
        /// <summary>
        /// Gets or sets the Slow.
        /// </summary>
        [DataMember]
        public Int32 Slow { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
