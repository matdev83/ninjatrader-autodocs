[Serializable]
[DataContract]
namespace NinjaTrader.Gui
{
    public partial class BrowsablePropertyAttribute : System.Attribute
    {
        #region Properties
        /// <summary>
        /// Gets or sets the TypeId.
        /// </summary>
        [DataMember]
        public object TypeId { get; set; }
        /// <summary>
        /// Gets or sets the PropertyName.
        /// </summary>
        [DataMember]
        public string PropertyName { get; set; }
        /// <summary>
        /// Gets or sets the Browsable.
        /// </summary>
        [DataMember]
        public bool Browsable { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
