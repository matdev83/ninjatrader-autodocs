[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class PerformanceMetricBase : NinjaTrader.NinjaScript.NinjaScript
    {
        #region Properties
        /// <summary>
        /// Gets or sets the LogTypeName.
        /// </summary>
        [DataMember]
        public string LogTypeName { get; set; }
        /// <summary>
        /// Gets or sets the PerformanceMetrics.
        /// </summary>
        [DataMember]
        public NinjaTrader.NinjaScript.PerformanceMetricBase[] PerformanceMetrics { get; set; }
        /// <summary>
        /// Gets or sets the ToolTip.
        /// </summary>
        [DataMember]
        public string ToolTip { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// AddPerformanceMetric method.
        /// </summary>
        /// <param name="performanceMetric">NinjaTrader.NinjaScript.PerformanceMetricBase</param>
        public void AddPerformanceMetric(NinjaTrader.NinjaScript.PerformanceMetricBase performanceMetric)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Format method.
        /// </summary>
        /// <param name="value">object</param>
        /// <param name="unit">PerformanceUnit</param>
        /// <param name="propertyName">string</param>
        /// <returns>string</returns>
        public string Format(object value, PerformanceUnit unit, string propertyName)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SetState method.
        /// </summary>
        /// <param name="state">State</param>
        public void SetState(State state)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
