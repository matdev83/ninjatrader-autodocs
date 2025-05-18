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
        public String AccessToken { get; set; }
        /// <summary>
        /// Gets or sets the ErrorText.
        /// </summary>
        [DataMember]
        public String ErrorText { get; set; }
        /// <summary>
        /// Gets or sets the ExpirationTime.
        /// </summary>
        [DataMember]
        public DateTime ExpirationTime { get; set; }
        /// <summary>
        /// Gets or sets the HasFunded.
        /// </summary>
        [DataMember]
        public Boolean HasFunded { get; set; }
        /// <summary>
        /// Gets or sets the HasLive.
        /// </summary>
        [DataMember]
        public Boolean HasLive { get; set; }
        /// <summary>
        /// Gets or sets the HasMarketData.
        /// </summary>
        [DataMember]
        public Boolean HasMarketData { get; set; }
        /// <summary>
        /// Gets or sets the MdAccessToken.
        /// </summary>
        [DataMember]
        public String MdAccessToken { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public String Name { get; set; }
        /// <summary>
        /// Gets or sets the PasswordExpirationTime.
        /// </summary>
        [DataMember]
        public DateTime PasswordExpirationTime { get; set; }
        /// <summary>
        /// Gets or sets the UserId.
        /// </summary>
        [DataMember]
        public Int64 UserId { get; set; }
        /// <summary>
        /// Gets or sets the UserStatus.
        /// </summary>
        [DataMember]
        public String UserStatus { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
