[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class ZigZag : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the DeviationType.
        /// </summary>
        [DataMember]
        public DeviationType DeviationType { get; set; }
        /// <summary>
        /// Gets or sets the DeviationValue.
        /// </summary>
        [DataMember]
        public Double DeviationValue { get; set; }
        /// <summary>
        /// Gets or sets the UseHighLow.
        /// </summary>
        [DataMember]
        public Boolean UseHighLow { get; set; }
        /// <summary>
        /// Gets or sets the ZigZagHigh.
        /// </summary>
        [DataMember]
        public Series<Double> ZigZagHigh { get; set; }
        /// <summary>
        /// Gets or sets the ZigZagLow.
        /// </summary>
        [DataMember]
        public Series<Double> ZigZagLow { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// LowBar method.
        /// </summary>
        /// <param name="barsAgo">Int32</param>
        /// <param name="instance">Int32</param>
        /// <param name="lookBackPeriod">Int32</param>
        /// <returns>Int32</returns>
        public Int32 LowBar(Int32 barsAgo, Int32 instance, Int32 lookBackPeriod);
        /// <summary>
        /// HighBar method.
        /// </summary>
        /// <param name="barsAgo">Int32</param>
        /// <param name="instance">Int32</param>
        /// <param name="lookBackPeriod">Int32</param>
        /// <returns>Int32</returns>
        public Int32 HighBar(Int32 barsAgo, Int32 instance, Int32 lookBackPeriod);
        /// <summary>
        /// OnCalculateMinMax method.
        /// </summary>
        public Void OnCalculateMinMax();
        #endregion
    }
}
