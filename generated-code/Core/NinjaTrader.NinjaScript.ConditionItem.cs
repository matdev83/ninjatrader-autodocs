[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class ConditionItem : NotifyPropertyChangedBase, IEquatable<ConditionItem>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Children.
        /// </summary>
        [DataMember]
        public Collection<ConditionItem> Children { get; set; }
        /// <summary>
        /// Gets or sets the IsExpanded.
        /// </summary>
        [DataMember]
        public Boolean IsExpanded { get; set; }
        /// <summary>
        /// Gets or sets the IsSelected.
        /// </summary>
        [DataMember]
        public Boolean IsSelected { get; set; }
        /// <summary>
        /// Gets or sets the HasItems.
        /// </summary>
        [DataMember]
        public Boolean HasItems { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public String Name { get; set; }
        /// <summary>
        /// Gets or sets the Offset.
        /// </summary>
        [DataMember]
        public ConditionOffset Offset { get; set; }
        /// <summary>
        /// Gets or sets the OffsetSpecified.
        /// </summary>
        [DataMember]
        public Boolean OffsetSpecified { get; set; }
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
        /// <param name="other">ConditionItem</param>
        public Void CopyTo(ConditionItem other);
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
        /// <param name="other">ConditionItem</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(ConditionItem other);
        #endregion
    }
}
