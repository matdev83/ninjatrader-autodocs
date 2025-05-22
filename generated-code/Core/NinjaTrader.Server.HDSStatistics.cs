[Serializable]
[DataContract]
namespace NinjaTrader.Server
{
    public partial class HDSStatistics
    {
        #region Properties
        /// <summary>
        /// Gets or sets the BarsBytesSent.
        /// </summary>
        [DataMember]
        public long BarsBytesSent { get; set; }
        /// <summary>
        /// Gets or sets the BarsFilesSent.
        /// </summary>
        [DataMember]
        public int BarsFilesSent { get; set; }
        /// <summary>
        /// Gets or sets the BarsRequests.
        /// </summary>
        [DataMember]
        public int BarsRequests { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataEvents.
        /// </summary>
        [DataMember]
        public long FundamentalDataEvents { get; set; }
        /// <summary>
        /// Gets or sets the IsUpdated.
        /// </summary>
        [DataMember]
        public bool IsUpdated { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataEvents.
        /// </summary>
        [DataMember]
        public long MarketDataEvents { get; set; }
        /// <summary>
        /// Gets or sets the MarketDepthEvents.
        /// </summary>
        [DataMember]
        public long MarketDepthEvents { get; set; }
        /// <summary>
        /// Gets or sets the PlaybackBytesSent.
        /// </summary>
        [DataMember]
        public long PlaybackBytesSent { get; set; }
        /// <summary>
        /// Gets or sets the PlaybackRequests.
        /// </summary>
        [DataMember]
        public int PlaybackRequests { get; set; }
        /// <summary>
        /// Gets or sets the TimeLastEvent.
        /// </summary>
        [DataMember]
        public System.DateTime TimeLastEvent { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
