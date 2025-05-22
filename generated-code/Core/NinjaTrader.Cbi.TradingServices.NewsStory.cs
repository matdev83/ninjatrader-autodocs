[Serializable]
[DataContract]
namespace NinjaTrader.Cbi.TradingServices
{
    public partial class NewsStory
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Archived.
        /// </summary>
        [DataMember]
        public bool Archived { get; set; }
        /// <summary>
        /// Gets or sets the Author.
        /// </summary>
        [DataMember]
        public string Author { get; set; }
        /// <summary>
        /// Gets or sets the Body.
        /// </summary>
        [DataMember]
        public string Body { get; set; }
        /// <summary>
        /// Gets or sets the Channels.
        /// </summary>
        [DataMember]
        public string Channels { get; set; }
        /// <summary>
        /// Gets or sets the Created.
        /// </summary>
        [DataMember]
        public System.DateTime Created { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public long Id { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the Source.
        /// </summary>
        [DataMember]
        public string Source { get; set; }
        /// <summary>
        /// Gets or sets the Timestamp.
        /// </summary>
        [DataMember]
        public System.DateTime Timestamp { get; set; }
        /// <summary>
        /// Gets or sets the Title.
        /// </summary>
        [DataMember]
        public string Title { get; set; }
        /// <summary>
        /// Gets or sets the Updated.
        /// </summary>
        [DataMember]
        public System.DateTime Updated { get; set; }
        /// <summary>
        /// Gets or sets the Url.
        /// </summary>
        [DataMember]
        public string Url { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
