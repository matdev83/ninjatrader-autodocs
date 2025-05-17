[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.AddOns
{
    public partial class DebugCommand
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Operation.
        /// </summary>
        [DataMember]
        public String Operation { get; set; }
        /// <summary>
        /// Gets or sets the DebugId.
        /// </summary>
        [DataMember]
        public String DebugId { get; set; }
        /// <summary>
        /// Gets or sets the MethodName.
        /// </summary>
        [DataMember]
        public String MethodName { get; set; }
        /// <summary>
        /// Gets or sets the Parameters.
        /// </summary>
        [DataMember]
        public Object[] Parameters { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
