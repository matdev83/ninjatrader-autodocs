[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class T3 : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Period.
        /// </summary>
        [DataMember]
        public Int32 Period { get; set; }
        /// <summary>
        /// Gets or sets the TCount.
        /// </summary>
        [DataMember]
        public Int32 TCount { get; set; }
        /// <summary>
        /// Gets or sets the VFactor.
        /// </summary>
        [DataMember]
        public Double VFactor { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
