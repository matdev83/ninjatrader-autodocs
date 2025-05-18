[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class MovingAverageRibbon : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the MovingAverage1.
        /// </summary>
        [DataMember]
        public Series<Double> MovingAverage1 { get; set; }
        /// <summary>
        /// Gets or sets the MovingAverage2.
        /// </summary>
        [DataMember]
        public Series<Double> MovingAverage2 { get; set; }
        /// <summary>
        /// Gets or sets the MovingAverage3.
        /// </summary>
        [DataMember]
        public Series<Double> MovingAverage3 { get; set; }
        /// <summary>
        /// Gets or sets the MovingAverage4.
        /// </summary>
        [DataMember]
        public Series<Double> MovingAverage4 { get; set; }
        /// <summary>
        /// Gets or sets the MovingAverage5.
        /// </summary>
        [DataMember]
        public Series<Double> MovingAverage5 { get; set; }
        /// <summary>
        /// Gets or sets the MovingAverage6.
        /// </summary>
        [DataMember]
        public Series<Double> MovingAverage6 { get; set; }
        /// <summary>
        /// Gets or sets the MovingAverage7.
        /// </summary>
        [DataMember]
        public Series<Double> MovingAverage7 { get; set; }
        /// <summary>
        /// Gets or sets the MovingAverage8.
        /// </summary>
        [DataMember]
        public Series<Double> MovingAverage8 { get; set; }
        /// <summary>
        /// Gets or sets the MovingAverage.
        /// </summary>
        [DataMember]
        public RibbonMAType MovingAverage { get; set; }
        /// <summary>
        /// Gets or sets the BasePeriod.
        /// </summary>
        [DataMember]
        public Int32 BasePeriod { get; set; }
        /// <summary>
        /// Gets or sets the IncrementalPeriod.
        /// </summary>
        [DataMember]
        public Int32 IncrementalPeriod { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
