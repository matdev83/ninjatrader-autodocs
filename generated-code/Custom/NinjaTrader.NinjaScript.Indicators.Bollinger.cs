[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class Bollinger : Indicator
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
        /// Gets or sets the NumStdDev.
        /// </summary>
        [DataMember]
        public Double NumStdDev { get; set; }
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
        #endregion
        #region Methods
        #endregion
    }
}
