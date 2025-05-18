[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class AlertConditionItem : ConditionItem, IEquatable<AlertConditionItem>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the IsStaticValue.
        /// </summary>
        [DataMember]
        public Boolean IsStaticValue { get; set; }
        /// <summary>
        /// Gets or sets the Tag.
        /// </summary>
        [DataMember]
        public Object Tag { get; set; }
        /// <summary>
        /// Gets or sets the Value.
        /// </summary>
        [DataMember]
        public Double Value { get; set; }
        /// <summary>
        /// Gets or sets the IsOffsetEnabled.
        /// </summary>
        [DataMember]
        public Boolean IsOffsetEnabled { get; set; }
        /// <summary>
        /// Gets or sets the ShouldOnlyDisplayName.
        /// </summary>
        [DataMember]
        public Boolean ShouldOnlyDisplayName { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="other">ConditionItem</param>
        public Void CopyTo(ConditionItem other);
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>String</returns>
        public String ToString();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="obj">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object obj);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">AlertConditionItem</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(AlertConditionItem other);
        /// <summary>
        /// GetHashCode method.
        /// </summary>
        /// <returns>Int32</returns>
        public Int32 GetHashCode();
        #endregion
    }
}
