[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class AccountRollEventArgs : EventArgs
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Account.
        /// </summary>
        [DataMember]
        public Account Account { get; set; }
        /// <summary>
        /// Gets or sets the FcmDate.
        /// </summary>
        [DataMember]
        public DateTime FcmDate { get; set; }
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
