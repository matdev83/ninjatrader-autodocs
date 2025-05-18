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
        public Boolean Archived { get; set; }
        /// <summary>
        /// Gets or sets the Author.
        /// </summary>
        [DataMember]
        public String Author { get; set; }
        /// <summary>
        /// Gets or sets the Body.
        /// </summary>
        [DataMember]
        public String Body { get; set; }
        /// <summary>
        /// Gets or sets the Channels.
        /// </summary>
        [DataMember]
        public String Channels { get; set; }
        /// <summary>
        /// Gets or sets the Created.
        /// </summary>
        [DataMember]
        public DateTime Created { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public Int64 Id { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public String Name { get; set; }
        /// <summary>
        /// Gets or sets the Source.
        /// </summary>
        [DataMember]
        public String Source { get; set; }
        /// <summary>
        /// Gets or sets the Timestamp.
        /// </summary>
        [DataMember]
        public DateTime Timestamp { get; set; }
        /// <summary>
        /// Gets or sets the Title.
        /// </summary>
        [DataMember]
        public String Title { get; set; }
        /// <summary>
        /// Gets or sets the Updated.
        /// </summary>
        [DataMember]
        public DateTime Updated { get; set; }
        /// <summary>
        /// Gets or sets the Url.
        /// </summary>
        [DataMember]
        public String Url { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
