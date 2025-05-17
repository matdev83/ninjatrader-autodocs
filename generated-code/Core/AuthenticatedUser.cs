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
        public String AccessToken { get; set; }
        /// <summary>
        /// Gets or sets the AccountType.
        /// </summary>
        [DataMember]
        public TradovateAccountType AccountType { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataAccessToken.
        /// </summary>
        [DataMember]
        public String MarketDataAccessToken { get; set; }
        /// <summary>
        /// Gets or sets the UserId.
        /// </summary>
        [DataMember]
        public Int64 UserId { get; set; }
        /// <summary>
        /// Gets or sets the UserName.
        /// </summary>
        [DataMember]
        public String UserName { get; set; }
        /// <summary>
        /// Gets or sets the UseDevEnvironment.
        /// </summary>
        [DataMember]
        public Boolean UseDevEnvironment { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
