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
        public String AppId { get; set; }
        /// <summary>
        /// Gets or sets the AppVersion.
        /// </summary>
        [DataMember]
        public String AppVersion { get; set; }
        /// <summary>
        /// Gets or sets the Cid.
        /// </summary>
        [DataMember]
        public String Cid { get; set; }
        /// <summary>
        /// Gets or sets the DeviceId.
        /// </summary>
        [DataMember]
        public String DeviceId { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public String Name { get; set; }
        /// <summary>
        /// Gets or sets the Password.
        /// </summary>
        [DataMember]
        public String Password { get; set; }
        /// <summary>
        /// Gets or sets the Sec.
        /// </summary>
        [DataMember]
        public String Sec { get; set; }
        /// <summary>
        /// Gets or sets the Captcha.
        /// </summary>
        [DataMember]
        public String Captcha { get; set; }
        /// <summary>
        /// Gets or sets the PTicket.
        /// </summary>
        [DataMember]
        public String PTicket { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
