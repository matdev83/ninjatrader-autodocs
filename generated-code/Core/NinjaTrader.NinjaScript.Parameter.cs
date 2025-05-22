[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class Parameter : System.ICloneable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the EnumValues.
        /// </summary>
        [DataMember]
        public System.Object[] EnumValues { get; set; }
        /// <summary>
        /// Gets or sets the EnumValuesSerializable.
        /// </summary>
        [DataMember]
        public System.String[] EnumValuesSerializable { get; set; }
        /// <summary>
        /// Gets or sets the Increment.
        /// </summary>
        [DataMember]
        public double Increment { get; set; }
        /// <summary>
        /// Gets or sets the Max.
        /// </summary>
        [DataMember]
        public object Max { get; set; }
        /// <summary>
        /// Gets or sets the Min.
        /// </summary>
        [DataMember]
        public object Min { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the NumIterations.
        /// </summary>
        [DataMember]
        public int NumIterations { get; set; }
        /// <summary>
        /// Gets or sets the ParameterType.
        /// </summary>
        [DataMember]
        public System.Type ParameterType { get; set; }
        /// <summary>
        /// Gets or sets the ParameterTypeSerializable.
        /// </summary>
        [DataMember]
        public string ParameterTypeSerializable { get; set; }
        /// <summary>
        /// Gets or sets the Value.
        /// </summary>
        [DataMember]
        public object Value { get; set; }
        /// <summary>
        /// Gets or sets the ValueSerializable.
        /// </summary>
        [DataMember]
        public string ValueSerializable { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>object</returns>
        public object Clone()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="parameter">NinjaTrader.NinjaScript.Parameter</param>
        public void CopyTo(NinjaTrader.NinjaScript.Parameter parameter)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SetPropertyValue method.
        /// </summary>
        /// <param name="strategy">NinjaTrader.NinjaScript.StrategyBase</param>
        public void SetPropertyValue(NinjaTrader.NinjaScript.StrategyBase strategy)
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
        #endregion
    }
}
