[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.PerformanceMetrics
{
    public partial class SampleCumProfit : PerformanceMetric
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Values.
        /// </summary>
        [DataMember]
        public Double[] Values { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Format method.
        /// </summary>
        /// <param name="value">Object</param>
        /// <param name="unit">PerformanceUnit</param>
        /// <param name="propertyName">String</param>
        /// <returns>String</returns>
        public String Format(Object value, PerformanceUnit unit, String propertyName);
        #endregion
    }
}
