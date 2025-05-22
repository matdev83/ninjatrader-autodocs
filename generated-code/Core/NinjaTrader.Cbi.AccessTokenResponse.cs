[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class AccessTokenResponse
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AccessToken.
        /// </summary>
        [DataMember]
        public string AccessToken { get; set; }
        /// <summary>
        /// Gets or sets the ErrorText.
        /// </summary>
        [DataMember]
        public string ErrorText { get; set; }
        /// <summary>
        /// Gets or sets the ExpirationTime.
        /// </summary>
        [DataMember]
        public System.DateTime ExpirationTime { get; set; }
        /// <summary>
        /// Gets or sets the HasFunded.
        /// </summary>
        [DataMember]
        public bool HasFunded { get; set; }
        /// <summary>
        /// Gets or sets the HasLive.
        /// </summary>
        [DataMember]
        public bool HasLive { get; set; }
        /// <summary>
        /// Gets or sets the HasMarketData.
        /// </summary>
        [DataMember]
        public bool HasMarketData { get; set; }
        /// <summary>
        /// Gets or sets the MdAccessToken.
        /// </summary>
        [DataMember]
        public string MdAccessToken { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the PasswordExpirationTime.
        /// </summary>
        [DataMember]
        public System.DateTime PasswordExpirationTime { get; set; }
        /// <summary>
        /// Gets or sets the UserId.
        /// </summary>
        [DataMember]
        public long UserId { get; set; }
        /// <summary>
        /// Gets or sets the UserStatus.
        /// </summary>
        [DataMember]
        public string UserStatus { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
