[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class Parameter : ICloneable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the EnumValues.
        /// </summary>
        [DataMember]
        public Object[] EnumValues { get; set; }
        /// <summary>
        /// Gets or sets the EnumValuesSerializable.
        /// </summary>
        [DataMember]
        public String[] EnumValuesSerializable { get; set; }
        /// <summary>
        /// Gets or sets the Increment.
        /// </summary>
        [DataMember]
        public Double Increment { get; set; }
        /// <summary>
        /// Gets or sets the Max.
        /// </summary>
        [DataMember]
        public Object Max { get; set; }
        /// <summary>
        /// Gets or sets the Min.
        /// </summary>
        [DataMember]
        public Object Min { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public String Name { get; set; }
        /// <summary>
        /// Gets or sets the NumIterations.
        /// </summary>
        [DataMember]
        public Int32 NumIterations { get; set; }
        /// <summary>
        /// Gets or sets the ParameterType.
        /// </summary>
        [DataMember]
        public Type ParameterType { get; set; }
        /// <summary>
        /// Gets or sets the ParameterTypeSerializable.
        /// </summary>
        [DataMember]
        public String ParameterTypeSerializable { get; set; }
        /// <summary>
        /// Gets or sets the Value.
        /// </summary>
        [DataMember]
        public Object Value { get; set; }
        /// <summary>
        /// Gets or sets the ValueSerializable.
        /// </summary>
        [DataMember]
        public String ValueSerializable { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>Object</returns>
        public Object Clone();
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="parameter">Parameter</param>
        public Void CopyTo(Parameter parameter);
        /// <summary>
        /// SetPropertyValue method.
        /// </summary>
        /// <param name="strategy">StrategyBase</param>
        public Void SetPropertyValue(StrategyBase strategy);
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>String</returns>
        public String ToString();
        #endregion
    }
}
