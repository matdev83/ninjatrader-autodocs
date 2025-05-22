[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class AuthenticatedUser
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AccessToken.
        /// </summary>
        [DataMember]
        public string AccessToken { get; set; }
        /// <summary>
        /// Gets or sets the AccountType.
        /// </summary>
        [DataMember]
        public TradovateAccountType AccountType { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataAccessToken.
        /// </summary>
        [DataMember]
        public string MarketDataAccessToken { get; set; }
        /// <summary>
        /// Gets or sets the UserId.
        /// </summary>
        [DataMember]
        public long UserId { get; set; }
        /// <summary>
        /// Gets or sets the UserName.
        /// </summary>
        [DataMember]
        public string UserName { get; set; }
        /// <summary>
        /// Gets or sets the UseDevEnvironment.
        /// </summary>
        [DataMember]
        public bool UseDevEnvironment { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
