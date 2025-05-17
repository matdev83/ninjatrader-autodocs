[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class MACD : Indicator
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
        /// Gets or sets the Diff.
        /// </summary>
        [DataMember]
        public Series<Double> Diff { get; set; }
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
