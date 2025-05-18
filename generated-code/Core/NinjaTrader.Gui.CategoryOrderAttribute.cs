[Serializable]
[DataContract]
namespace NinjaTrader.Gui
{
    public partial class CategoryOrderAttribute : Attribute
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Category.
        /// </summary>
        [DataMember]
        public String Category { get; set; }
        /// <summary>
        /// Gets or sets the Order.
        /// </summary>
        [DataMember]
        public Int32 Order { get; set; }
        /// <summary>
        /// Gets or sets the ResourceType.
        /// </summary>
        [DataMember]
        public Type ResourceType { get; set; }
        /// <summary>
        /// Gets or sets the TypeId.
        /// </summary>
        [DataMember]
        public Object TypeId { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
