[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class AccountStatusEventArgs : EventArgs
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Account.
        /// </summary>
        [DataMember]
        public Account Account { get; set; }
        /// <summary>
        /// Gets or sets the Message.
        /// </summary>
        [DataMember]
        public String Message { get; set; }
        /// <summary>
        /// Gets or sets the PreviousStatus.
        /// </summary>
        [DataMember]
        public ConnectionStatus PreviousStatus { get; set; }
        /// <summary>
        /// Gets or sets the Status.
        /// </summary>
        [DataMember]
        public ConnectionStatus Status { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>String</returns>
        public String ToString();
        #endregion
    }
}
