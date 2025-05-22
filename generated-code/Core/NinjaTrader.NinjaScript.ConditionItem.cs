[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class ConditionItem : NinjaTrader.Gui.NotifyPropertyChangedBase, System.IEquatable<NinjaTrader.NinjaScript.ConditionItem>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Children.
        /// </summary>
        [DataMember]
        public System.Collections.ObjectModel.Collection<NinjaTrader.NinjaScript.ConditionItem> Children { get; set; }
        /// <summary>
        /// Gets or sets the IsExpanded.
        /// </summary>
        [DataMember]
        public bool IsExpanded { get; set; }
        /// <summary>
        /// Gets or sets the IsSelected.
        /// </summary>
        [DataMember]
        public bool IsSelected { get; set; }
        /// <summary>
        /// Gets or sets the HasItems.
        /// </summary>
        [DataMember]
        public bool HasItems { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the Offset.
        /// </summary>
        [DataMember]
        public NinjaTrader.NinjaScript.ConditionOffset Offset { get; set; }
        /// <summary>
        /// Gets or sets the OffsetSpecified.
        /// </summary>
        [DataMember]
        public bool OffsetSpecified { get; set; }
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
        /// <param name="other">NinjaTrader.NinjaScript.ConditionItem</param>
        public void CopyTo(NinjaTrader.NinjaScript.ConditionItem other)
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
        /// <param name="other">NinjaTrader.NinjaScript.ConditionItem</param>
        /// <returns>bool</returns>
        public bool Equals(NinjaTrader.NinjaScript.ConditionItem other)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
