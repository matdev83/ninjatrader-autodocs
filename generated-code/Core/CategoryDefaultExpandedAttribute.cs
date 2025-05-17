[Serializable]
[DataContract]
namespace NinjaTrader.Gui
{
    public partial class CategoryDefaultExpandedAttribute : Attribute
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Expanded.
        /// </summary>
        [DataMember]
        public Boolean Expanded { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
