[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class ConditionOffset : NotifyPropertyChangedBase, IEquatable<ConditionOffset>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the DynamicOffsetProvider.
        /// </summary>
        [DataMember]
        public IConditionOffsetValueProvider DynamicOffsetProvider { get; set; }
        /// <summary>
        /// Gets or sets the IsSetEnabled.
        /// </summary>
        [DataMember]
        public Boolean IsSetEnabled { get; set; }
        /// <summary>
        /// Gets or sets the OffsetValue.
        /// </summary>
        [DataMember]
        public Double OffsetValue { get; set; }
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
        /// <param name="other">ConditionOffset</param>
        public Void CopyTo(ConditionOffset other);
        /// <summary>
        /// Calculate method.
        /// </summary>
        /// <param name="initialValue">Double</param>
        /// <param name="instrument">Instrument</param>
        /// <returns>Double</returns>
        public Double Calculate(Double initialValue, Instrument instrument);
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>String</returns>
        public String ToString();
        /// <summary>
        /// GetHashCode method.
        /// </summary>
        /// <returns>Int32</returns>
        public Int32 GetHashCode();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="obj">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object obj);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">ConditionOffset</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(ConditionOffset other);
        #endregion
    }
}
