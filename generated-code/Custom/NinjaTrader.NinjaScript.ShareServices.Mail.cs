[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.ShareServices
{
    public partial class Mail : ShareService, IPreconfiguredProvider
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Icon.
        /// </summary>
        [DataMember]
        public Object Icon { get; set; }
        /// <summary>
        /// Gets or sets the PreconfiguredNames.
        /// </summary>
        [DataMember]
        public List<String> PreconfiguredNames { get; set; }
        /// <summary>
        /// Gets or sets the SelectedPreconfiguredSetting.
        /// </summary>
        [DataMember]
        public String SelectedPreconfiguredSetting { get; set; }
        /// <summary>
        /// Gets or sets the FromMailAddress.
        /// </summary>
        [DataMember]
        public String FromMailAddress { get; set; }
        /// <summary>
        /// Gets or sets the SenderDisplayName.
        /// </summary>
        [DataMember]
        public String SenderDisplayName { get; set; }
        /// <summary>
        /// Gets or sets the IsBodyHtml.
        /// </summary>
        [DataMember]
        public Boolean IsBodyHtml { get; set; }
        /// <summary>
        /// Gets or sets the OAuthToken.
        /// </summary>
        [DataMember]
        public String OAuthToken { get; set; }
        /// <summary>
        /// Gets or sets the Password.
        /// </summary>
        [DataMember]
        public String Password { get; set; }
        /// <summary>
        /// Gets or sets the Port.
        /// </summary>
        [DataMember]
        public Int32 Port { get; set; }
        /// <summary>
        /// Gets or sets the RefreshToken.
        /// </summary>
        [DataMember]
        public String RefreshToken { get; set; }
        /// <summary>
        /// Gets or sets the Server.
        /// </summary>
        [DataMember]
        public String Server { get; set; }
        /// <summary>
        /// Gets or sets the Subject.
        /// </summary>
        [DataMember]
        public String Subject { get; set; }
        /// <summary>
        /// Gets or sets the ToMailAddress.
        /// </summary>
        [DataMember]
        public String ToMailAddress { get; set; }
        /// <summary>
        /// Gets or sets the CcMailAddress.
        /// </summary>
        [DataMember]
        public String CcMailAddress { get; set; }
        /// <summary>
        /// Gets or sets the UserName.
        /// </summary>
        [DataMember]
        public String UserName { get; set; }
        /// <summary>
        /// Gets or sets the UseSSL.
        /// </summary>
        [DataMember]
        public Boolean UseSSL { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="ninjaScript">NinjaScript</param>
        public Void CopyTo(NinjaScript ninjaScript);
        /// <summary>
        /// OnAuthorizeAccount method.
        /// </summary>
        /// <returns>Task</returns>
        public Task OnAuthorizeAccount();
        /// <summary>
        /// OnShare method.
        /// </summary>
        /// <param name="text">String</param>
        /// <param name="imageFilePath">String</param>
        /// <returns>Task</returns>
        public Task OnShare(String text, String imageFilePath);
        /// <summary>
        /// OnShare method.
        /// </summary>
        /// <param name="text">String</param>
        /// <param name="imageFilePath">String</param>
        /// <param name="args">Object[]</param>
        /// <returns>Task</returns>
        public Task OnShare(String text, String imageFilePath, Object[] args);
        /// <summary>
        /// ApplyPreconfiguredSettings method.
        /// </summary>
        /// <param name="name">String</param>
        public Void ApplyPreconfiguredSettings(String name);
        #endregion
    }
}
