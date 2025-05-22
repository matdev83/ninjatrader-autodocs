[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class AccountRollEventArgs : System.EventArgs
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Account.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Account Account { get; set; }
        /// <summary>
        /// Gets or sets the FcmDate.
        /// </summary>
        [DataMember]
        public System.DateTime FcmDate { get; set; }
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
