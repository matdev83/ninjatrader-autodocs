[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class PropertyValidForAlertActionAttribute : System.Attribute
    {
        #region Properties
        /// <summary>
        /// Gets or sets the ValidForAction.
        /// </summary>
        [DataMember]
        public AlertActionType ValidForAction { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
