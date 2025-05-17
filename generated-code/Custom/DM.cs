[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class DM : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the ADXPlot.
        /// </summary>
        [DataMember]
        public Series<Double> ADXPlot { get; set; }
        /// <summary>
        /// Gets or sets the DiPlus.
        /// </summary>
        [DataMember]
        public Series<Double> DiPlus { get; set; }
        /// <summary>
        /// Gets or sets the DiMinus.
        /// </summary>
        [DataMember]
        public Series<Double> DiMinus { get; set; }
        /// <summary>
        /// Gets or sets the Period.
        /// </summary>
        [DataMember]
        public Int32 Period { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
