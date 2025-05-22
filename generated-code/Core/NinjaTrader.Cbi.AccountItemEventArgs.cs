[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class AccountItemEventArgs : System.EventArgs
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Account.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Account Account { get; set; }
        /// <summary>
        /// Gets or sets the AccountItem.
        /// </summary>
        [DataMember]
        public AccountItem AccountItem { get; set; }
        /// <summary>
        /// Gets or sets the Currency.
        /// </summary>
        [DataMember]
        public Currency Currency { get; set; }
        /// <summary>
        /// Gets or sets the Time.
        /// </summary>
        [DataMember]
        public System.DateTime Time { get; set; }
        /// <summary>
        /// Gets or sets the Value.
        /// </summary>
        [DataMember]
        public double Value { get; set; }
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
