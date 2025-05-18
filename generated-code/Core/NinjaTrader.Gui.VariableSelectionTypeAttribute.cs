[Serializable]
[DataContract]
namespace NinjaTrader.Gui
{
    public partial class VariableSelectionTypeAttribute : Attribute
    {
        #region Properties
        /// <summary>
        /// Gets or sets the VariableType.
        /// </summary>
        [DataMember]
        public VariableType VariableType { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
