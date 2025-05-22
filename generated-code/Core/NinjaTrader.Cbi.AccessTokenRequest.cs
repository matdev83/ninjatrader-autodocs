[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class AccessTokenRequest
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
        /// Gets or sets the Cid.
        /// </summary>
        [DataMember]
        public string Cid { get; set; }
        /// <summary>
        /// Gets or sets the DeviceId.
        /// </summary>
        [DataMember]
        public string DeviceId { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the Password.
        /// </summary>
        [DataMember]
        public string Password { get; set; }
        /// <summary>
        /// Gets or sets the Sec.
        /// </summary>
        [DataMember]
        public string Sec { get; set; }
        /// <summary>
        /// Gets or sets the Captcha.
        /// </summary>
        [DataMember]
        public string Captcha { get; set; }
        /// <summary>
        /// Gets or sets the PTicket.
        /// </summary>
        [DataMember]
        public string PTicket { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
