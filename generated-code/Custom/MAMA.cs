[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class MAMA : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Default.
        /// </summary>
        [DataMember]
        public Series<Double> Default { get; set; }
        /// <summary>
        /// Gets or sets the Fama.
        /// </summary>
        [DataMember]
        public Series<Double> Fama { get; set; }
        /// <summary>
        /// Gets or sets the FastLimit.
        /// </summary>
        [DataMember]
        public Double FastLimit { get; set; }
        /// <summary>
        /// Gets or sets the SlowLimit.
        /// </summary>
        [DataMember]
        public Double SlowLimit { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
