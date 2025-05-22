[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class ChartAlertValue : System.IEquatable<NinjaTrader.NinjaScript.ChartAlertValue>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Time.
        /// </summary>
        [DataMember]
        public System.DateTime Time { get; set; }
        /// <summary>
        /// Gets or sets the Value.
        /// </summary>
        [DataMember]
        public double Value { get; set; }
        /// <summary>
        /// Gets or sets the ValueType.
        /// </summary>
        [DataMember]
        public ChartAlertValueType ValueType { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// GetHashCode method.
        /// </summary>
        /// <returns>int</returns>
        public int GetHashCode()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">NinjaTrader.NinjaScript.ChartAlertValue</param>
        /// <returns>bool</returns>
        public bool Equals(NinjaTrader.NinjaScript.ChartAlertValue other)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="obj">object</param>
        /// <returns>bool</returns>
        public bool Equals(object obj)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
