[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class AccountLiquidationEventArgs : System.EventArgs
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the Fcm.
        /// </summary>
        [DataMember]
        public string Fcm { get; set; }
        /// <summary>
        /// Gets or sets the LiquidationState.
        /// </summary>
        [DataMember]
        public LiquidationState LiquidationState { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
