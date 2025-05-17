[Serializable]
[DataContract]
namespace NinjaTrader.Gui
{
    public partial class BrowsableCategoryAttribute : Attribute
    {
        #region Properties
        /// <summary>
        /// Gets or sets the CategoryName.
        /// </summary>
        [DataMember]
        public String CategoryName { get; set; }
        /// <summary>
        /// Gets or sets the Browsable.
        /// </summary>
        [DataMember]
        public Boolean Browsable { get; set; }
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
