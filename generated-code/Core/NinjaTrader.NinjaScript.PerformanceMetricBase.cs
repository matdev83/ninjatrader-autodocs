[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class PerformanceMetricBase : NinjaScript
    {
        #region Properties
        /// <summary>
        /// Gets or sets the LogTypeName.
        /// </summary>
        [DataMember]
        public String LogTypeName { get; set; }
        /// <summary>
        /// Gets or sets the PerformanceMetrics.
        /// </summary>
        [DataMember]
        public PerformanceMetricBase[] PerformanceMetrics { get; set; }
        /// <summary>
        /// Gets or sets the ToolTip.
        /// </summary>
        [DataMember]
        public String ToolTip { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// AddPerformanceMetric method.
        /// </summary>
        /// <param name="performanceMetric">PerformanceMetricBase</param>
        public Void AddPerformanceMetric(PerformanceMetricBase performanceMetric);
        /// <summary>
        /// Format method.
        /// </summary>
        /// <param name="value">Object</param>
        /// <param name="unit">PerformanceUnit</param>
        /// <param name="propertyName">String</param>
        /// <returns>String</returns>
        public String Format(Object value, PerformanceUnit unit, String propertyName);
        /// <summary>
        /// SetState method.
        /// </summary>
        /// <param name="state">State</param>
        public Void SetState(State state);
        #endregion
    }
}
