[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class AccountItemEventArgs : EventArgs
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Account.
        /// </summary>
        [DataMember]
        public Account Account { get; set; }
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
        public DateTime Time { get; set; }
        /// <summary>
        /// Gets or sets the Value.
        /// </summary>
        [DataMember]
        public Double Value { get; set; }
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
