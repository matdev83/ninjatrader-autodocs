[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class AlertConditionItem : NinjaTrader.NinjaScript.ConditionItem, System.IEquatable<NinjaTrader.NinjaScript.AlertConditionItem>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the IsStaticValue.
        /// </summary>
        [DataMember]
        public bool IsStaticValue { get; set; }
        /// <summary>
        /// Gets or sets the Tag.
        /// </summary>
        [DataMember]
        public object Tag { get; set; }
        /// <summary>
        /// Gets or sets the Value.
        /// </summary>
        [DataMember]
        public double Value { get; set; }
        /// <summary>
        /// Gets or sets the IsOffsetEnabled.
        /// </summary>
        [DataMember]
        public bool IsOffsetEnabled { get; set; }
        /// <summary>
        /// Gets or sets the ShouldOnlyDisplayName.
        /// </summary>
        [DataMember]
        public bool ShouldOnlyDisplayName { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="other">NinjaTrader.NinjaScript.ConditionItem</param>
        public void CopyTo(NinjaTrader.NinjaScript.ConditionItem other)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>string</returns>
        public string ToString()
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
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">NinjaTrader.NinjaScript.AlertConditionItem</param>
        /// <returns>bool</returns>
        public bool Equals(NinjaTrader.NinjaScript.AlertConditionItem other)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetHashCode method.
        /// </summary>
        /// <returns>int</returns>
        public int GetHashCode()
        {
            // Method implementation goes here
        }
        #endregion
    }
}
