[Serializable]
[DataContract]
namespace NinjaTrader.Gui
{
    public partial class CategoryExpandedAttribute : System.Attribute
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Category.
        /// </summary>
        [DataMember]
        public string Category { get; set; }
        /// <summary>
        /// Gets or sets the Expanded.
        /// </summary>
        [DataMember]
        public bool Expanded { get; set; }
        /// <summary>
        /// Gets or sets the ResourceType.
        /// </summary>
        [DataMember]
        public System.Type ResourceType { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
