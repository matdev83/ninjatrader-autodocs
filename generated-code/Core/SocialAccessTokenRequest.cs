[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class SocialAccessTokenRequest
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AppId.
        /// </summary>
        [DataMember]
        public String AppId { get; set; }
        /// <summary>
        /// Gets or sets the AppVersion.
        /// </summary>
        [DataMember]
        public String AppVersion { get; set; }
        /// <summary>
        /// Gets or sets the DeviceId.
        /// </summary>
        [DataMember]
        public String DeviceId { get; set; }
        /// <summary>
        /// Gets or sets the Organization.
        /// </summary>
        [DataMember]
        public String Organization { get; set; }
        /// <summary>
        /// Gets or sets the Provider.
        /// </summary>
        [DataMember]
        public String Provider { get; set; }
        /// <summary>
        /// Gets or sets the Token.
        /// </summary>
        [DataMember]
        public String Token { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
