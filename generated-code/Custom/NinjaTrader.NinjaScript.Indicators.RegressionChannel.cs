[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class RegressionChannel : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Lower.
        /// </summary>
        [DataMember]
        public Series<Double> Lower { get; set; }
        /// <summary>
        /// Gets or sets the Middle.
        /// </summary>
        [DataMember]
        public Series<Double> Middle { get; set; }
        /// <summary>
        /// Gets or sets the Period.
        /// </summary>
        [DataMember]
        public Int32 Period { get; set; }
        /// <summary>
        /// Gets or sets the Upper.
        /// </summary>
        [DataMember]
        public Series<Double> Upper { get; set; }
        /// <summary>
        /// Gets or sets the Width.
        /// </summary>
        [DataMember]
        public Double Width { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
