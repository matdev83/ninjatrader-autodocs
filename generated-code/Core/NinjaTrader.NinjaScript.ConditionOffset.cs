[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class ConditionOffset : NinjaTrader.Gui.NotifyPropertyChangedBase, System.IEquatable<NinjaTrader.NinjaScript.ConditionOffset>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the DynamicOffsetProvider.
        /// </summary>
        [DataMember]
        public NinjaTrader.NinjaScript.IConditionOffsetValueProvider DynamicOffsetProvider { get; set; }
        /// <summary>
        /// Gets or sets the IsSetEnabled.
        /// </summary>
        [DataMember]
        public bool IsSetEnabled { get; set; }
        /// <summary>
        /// Gets or sets the OffsetValue.
        /// </summary>
        [DataMember]
        public double OffsetValue { get; set; }
        /// <summary>
        /// Gets or sets the OffsetOperator.
        /// </summary>
        [DataMember]
        public ConditionOffsetOperator OffsetOperator { get; set; }
        /// <summary>
        /// Gets or sets the OffsetType.
        /// </summary>
        [DataMember]
        public ConditionOffsetType OffsetType { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="other">NinjaTrader.NinjaScript.ConditionOffset</param>
        public void CopyTo(NinjaTrader.NinjaScript.ConditionOffset other)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Calculate method.
        /// </summary>
        /// <param name="initialValue">double</param>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        /// <returns>double</returns>
        public double Calculate(double initialValue, NinjaTrader.Cbi.Instrument instrument)
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
        /// <param name="obj">object</param>
        /// <returns>bool</returns>
        public bool Equals(object obj)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">NinjaTrader.NinjaScript.ConditionOffset</param>
        /// <returns>bool</returns>
        public bool Equals(NinjaTrader.NinjaScript.ConditionOffset other)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
