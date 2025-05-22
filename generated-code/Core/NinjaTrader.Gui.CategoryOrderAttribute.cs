[Serializable]
[DataContract]
namespace NinjaTrader.Gui
{
    public partial class CategoryOrderAttribute : System.Attribute
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Category.
        /// </summary>
        [DataMember]
        public string Category { get; set; }
        /// <summary>
        /// Gets or sets the Order.
        /// </summary>
        [DataMember]
        public int Order { get; set; }
        /// <summary>
        /// Gets or sets the ResourceType.
        /// </summary>
        [DataMember]
        public System.Type ResourceType { get; set; }
        /// <summary>
        /// Gets or sets the TypeId.
        /// </summary>
        [DataMember]
        public object TypeId { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
