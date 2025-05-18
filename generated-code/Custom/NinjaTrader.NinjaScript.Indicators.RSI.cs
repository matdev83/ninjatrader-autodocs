[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class RSI : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Avg.
        /// </summary>
        [DataMember]
        public Series<Double> Avg { get; set; }
        /// <summary>
        /// Gets or sets the Default.
        /// </summary>
        [DataMember]
        public Series<Double> Default { get; set; }
        /// <summary>
        /// Gets or sets the Period.
        /// </summary>
        [DataMember]
        public Int32 Period { get; set; }
        /// <summary>
        /// Gets or sets the Smooth.
        /// </summary>
        [DataMember]
        public Int32 Smooth { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
