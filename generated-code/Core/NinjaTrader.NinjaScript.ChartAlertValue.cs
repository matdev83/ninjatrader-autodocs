[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class ChartAlertValue : IEquatable<ChartAlertValue>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Time.
        /// </summary>
        [DataMember]
        public DateTime Time { get; set; }
        /// <summary>
        /// Gets or sets the Value.
        /// </summary>
        [DataMember]
        public Double Value { get; set; }
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
        /// <returns>Int32</returns>
        public Int32 GetHashCode();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">ChartAlertValue</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(ChartAlertValue other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="obj">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object obj);
        #endregion
    }
}
