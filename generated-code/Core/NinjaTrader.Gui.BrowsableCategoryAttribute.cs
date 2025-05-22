[Serializable]
[DataContract]
namespace NinjaTrader.Gui
{
    public partial class BrowsableCategoryAttribute : System.Attribute
    {
        #region Properties
        /// <summary>
        /// Gets or sets the CategoryName.
        /// </summary>
        [DataMember]
        public string CategoryName { get; set; }
        /// <summary>
        /// Gets or sets the Browsable.
        /// </summary>
        [DataMember]
        public bool Browsable { get; set; }
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
