[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.ShareServices
{
    public partial class StockTwits : ShareService
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Icon.
        /// </summary>
        [DataMember]
        public Object Icon { get; set; }
        /// <summary>
        /// Gets or sets the OAuth_Token.
        /// </summary>
        [DataMember]
        public String OAuth_Token { get; set; }
        /// <summary>
        /// Gets or sets the StockTwitsSentiment.
        /// </summary>
        [DataMember]
        public Sentiment StockTwitsSentiment { get; set; }
        /// <summary>
        /// Gets or sets the UserName.
        /// </summary>
        [DataMember]
        public String UserName { get; set; }
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
        /// HideScriptErrors method.
        /// </summary>
        /// <param name="wb">WebBrowser</param>
        public Void HideScriptErrors(WebBrowser wb);
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
        #endregion
    }
}
