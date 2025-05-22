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
        public string AppId { get; set; }
        /// <summary>
        /// Gets or sets the AppVersion.
        /// </summary>
        [DataMember]
        public string AppVersion { get; set; }
        /// <summary>
        /// Gets or sets the DeviceId.
        /// </summary>
        [DataMember]
        public string DeviceId { get; set; }
        /// <summary>
        /// Gets or sets the Organization.
        /// </summary>
        [DataMember]
        public string Organization { get; set; }
        /// <summary>
        /// Gets or sets the Provider.
        /// </summary>
        [DataMember]
        public string Provider { get; set; }
        /// <summary>
        /// Gets or sets the Token.
        /// </summary>
        [DataMember]
        public string Token { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
