[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class NewsEventArgs : EventArgs
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Headline.
        /// </summary>
        [DataMember]
        public String Headline { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public String Id { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider.
        /// </summary>
        [DataMember]
        public NewsProvider NewsProvider { get; set; }
        /// <summary>
        /// Gets or sets the Symbols.
        /// </summary>
        [DataMember]
        public String[] Symbols { get; set; }
        /// <summary>
        /// Gets or sets the Time.
        /// </summary>
        [DataMember]
        public DateTime Time { get; set; }
        /// <summary>
        /// Gets or sets the Text.
        /// </summary>
        [DataMember]
        public String Text { get; set; }
        /// <summary>
        /// Gets or sets the Url.
        /// </summary>
        [DataMember]
        public Uri Url { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// NewsCallback method.
        /// </summary>
        /// <param name="id">String</param>
        /// <param name="newsProvider">NewsProvider</param>
        /// <param name="time">DateTime</param>
        /// <param name="headline">String</param>
        /// <param name="text">String</param>
        /// <param name="url">Uri</param>
        public Void NewsCallback(String id, NewsProvider newsProvider, DateTime time, String headline, String text, Uri url);
        /// <summary>
        /// RaiseNewsEvent method.
        /// </summary>
        /// <param name="e">NewsEventArgs</param>
        public Void RaiseNewsEvent(NewsEventArgs e);
        #endregion
    }
}
