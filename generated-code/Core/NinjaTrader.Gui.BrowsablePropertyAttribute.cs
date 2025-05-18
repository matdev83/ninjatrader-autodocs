[Serializable]
[DataContract]
namespace NinjaTrader.Gui
{
    public partial class BrowsablePropertyAttribute : Attribute
    {
        #region Properties
        /// <summary>
        /// Gets or sets the TypeId.
        /// </summary>
        [DataMember]
        public Object TypeId { get; set; }
        /// <summary>
        /// Gets or sets the PropertyName.
        /// </summary>
        [DataMember]
        public String PropertyName { get; set; }
        /// <summary>
        /// Gets or sets the Browsable.
        /// </summary>
        [DataMember]
        public Boolean Browsable { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
