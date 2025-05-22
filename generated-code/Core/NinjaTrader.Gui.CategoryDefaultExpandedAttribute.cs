[Serializable]
[DataContract]
namespace NinjaTrader.Gui
{
    public partial class CategoryDefaultExpandedAttribute : System.Attribute
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Expanded.
        /// </summary>
        [DataMember]
        public bool Expanded { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
