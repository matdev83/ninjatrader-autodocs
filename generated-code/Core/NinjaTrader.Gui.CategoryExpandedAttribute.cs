[Serializable]
[DataContract]
namespace NinjaTrader.Gui
{
    public partial class CategoryExpandedAttribute : Attribute
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Category.
        /// </summary>
        [DataMember]
        public String Category { get; set; }
        /// <summary>
        /// Gets or sets the Expanded.
        /// </summary>
        [DataMember]
        public Boolean Expanded { get; set; }
        /// <summary>
        /// Gets or sets the ResourceType.
        /// </summary>
        [DataMember]
        public Type ResourceType { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
