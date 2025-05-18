[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.ShareServices
{
    public partial class ShareService : NinjaScript
    {
        #region Properties
        /// <summary>
        /// Gets or sets the CharacterLimit.
        /// </summary>
        [DataMember]
        public Int32 CharacterLimit { get; set; }
        /// <summary>
        /// Gets or sets the CharactersReservedPerMedia.
        /// </summary>
        [DataMember]
        public Int32 CharactersReservedPerMedia { get; set; }
        /// <summary>
        /// Gets or sets the IsConfigured.
        /// </summary>
        [DataMember]
        public Boolean IsConfigured { get; set; }
        /// <summary>
        /// Gets or sets the IsDefault.
        /// </summary>
        [DataMember]
        public Boolean IsDefault { get; set; }
        /// <summary>
        /// Gets or sets the IsImageAttachmentSupported.
        /// </summary>
        [DataMember]
        public Boolean IsImageAttachmentSupported { get; set; }
        /// <summary>
        /// Gets or sets the LogTypeName.
        /// </summary>
        [DataMember]
        public String LogTypeName { get; set; }
        /// <summary>
        /// Gets or sets the Icon.
        /// </summary>
        [DataMember]
        public Object Icon { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public String Name { get; set; }
        /// <summary>
        /// Gets or sets the DisplayName.
        /// </summary>
        [DataMember]
        public String DisplayName { get; set; }
        /// <summary>
        /// Gets or sets the Signature.
        /// </summary>
        [DataMember]
        public String Signature { get; set; }
        /// <summary>
        /// Gets or sets the UseOAuth.
        /// </summary>
        [DataMember]
        public Boolean UseOAuth { get; set; }
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
        /// SetState method.
        /// </summary>
        /// <param name="state">State</param>
        public Void SetState(State state);
        #endregion
    }
}
