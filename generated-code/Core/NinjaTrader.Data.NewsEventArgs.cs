[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class NewsEventArgs : System.EventArgs
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Headline.
        /// </summary>
        [DataMember]
        public string Headline { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public string Id { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider.
        /// </summary>
        [DataMember]
        public NewsProvider NewsProvider { get; set; }
        /// <summary>
        /// Gets or sets the Symbols.
        /// </summary>
        [DataMember]
        public System.String[] Symbols { get; set; }
        /// <summary>
        /// Gets or sets the Time.
        /// </summary>
        [DataMember]
        public System.DateTime Time { get; set; }
        /// <summary>
        /// Gets or sets the Text.
        /// </summary>
        [DataMember]
        public string Text { get; set; }
        /// <summary>
        /// Gets or sets the Url.
        /// </summary>
        [DataMember]
        public System.Uri Url { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// NewsCallback method.
        /// </summary>
        /// <param name="id">string</param>
        /// <param name="newsProvider">NewsProvider</param>
        /// <param name="time">System.DateTime</param>
        /// <param name="headline">string</param>
        /// <param name="text">string</param>
        /// <param name="url">System.Uri</param>
        public void NewsCallback(string id, NewsProvider newsProvider, System.DateTime time, string headline, string text, System.Uri url)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// RaiseNewsEvent method.
        /// </summary>
        /// <param name="e">NinjaTrader.Data.NewsEventArgs</param>
        public void RaiseNewsEvent(NinjaTrader.Data.NewsEventArgs e)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
