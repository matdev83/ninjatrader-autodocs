[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class AccountLiquidationEventArgs : EventArgs
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public String Name { get; set; }
        /// <summary>
        /// Gets or sets the Fcm.
        /// </summary>
        [DataMember]
        public String Fcm { get; set; }
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
