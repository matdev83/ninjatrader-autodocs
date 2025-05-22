[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.ShareServices
{
    public partial class ShareService : NinjaTrader.NinjaScript.NinjaScript
    {
        #region Properties
        /// <summary>
        /// Gets or sets the CharacterLimit.
        /// </summary>
        [DataMember]
        public int CharacterLimit { get; set; }
        /// <summary>
        /// Gets or sets the CharactersReservedPerMedia.
        /// </summary>
        [DataMember]
        public int CharactersReservedPerMedia { get; set; }
        /// <summary>
        /// Gets or sets the IsConfigured.
        /// </summary>
        [DataMember]
        public bool IsConfigured { get; set; }
        /// <summary>
        /// Gets or sets the IsDefault.
        /// </summary>
        [DataMember]
        public bool IsDefault { get; set; }
        /// <summary>
        /// Gets or sets the IsImageAttachmentSupported.
        /// </summary>
        [DataMember]
        public bool IsImageAttachmentSupported { get; set; }
        /// <summary>
        /// Gets or sets the LogTypeName.
        /// </summary>
        [DataMember]
        public string LogTypeName { get; set; }
        /// <summary>
        /// Gets or sets the Icon.
        /// </summary>
        [DataMember]
        public object Icon { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the DisplayName.
        /// </summary>
        [DataMember]
        public string DisplayName { get; set; }
        /// <summary>
        /// Gets or sets the Signature.
        /// </summary>
        [DataMember]
        public string Signature { get; set; }
        /// <summary>
        /// Gets or sets the UseOAuth.
        /// </summary>
        [DataMember]
        public bool UseOAuth { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="ninjaScript">NinjaTrader.NinjaScript.NinjaScript</param>
        public void CopyTo(NinjaTrader.NinjaScript.NinjaScript ninjaScript)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// OnAuthorizeAccount method.
        /// </summary>
        /// <returns>System.Threading.Tasks.Task</returns>
        public System.Threading.Tasks.Task OnAuthorizeAccount()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// OnShare method.
        /// </summary>
        /// <param name="text">string</param>
        /// <param name="imageFilePath">string</param>
        /// <returns>System.Threading.Tasks.Task</returns>
        public System.Threading.Tasks.Task OnShare(string text, string imageFilePath)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// OnShare method.
        /// </summary>
        /// <param name="text">string</param>
        /// <param name="imageFilePath">string</param>
        /// <param name="args">System.Object[]</param>
        /// <returns>System.Threading.Tasks.Task</returns>
        public System.Threading.Tasks.Task OnShare(string text, string imageFilePath, System.Object[] args)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SetState method.
        /// </summary>
        /// <param name="state">State</param>
        public void SetState(State state)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
