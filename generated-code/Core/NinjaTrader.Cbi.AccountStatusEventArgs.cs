[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class AccountStatusEventArgs : System.EventArgs
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Account.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Account Account { get; set; }
        /// <summary>
        /// Gets or sets the Message.
        /// </summary>
        [DataMember]
        public string Message { get; set; }
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
        /// <returns>string</returns>
        public string ToString()
        {
            // Method implementation goes here
        }
        #endregion
    }
}
