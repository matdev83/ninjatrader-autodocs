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
        public Int64 BarsBytesSent { get; set; }
        /// <summary>
        /// Gets or sets the BarsFilesSent.
        /// </summary>
        [DataMember]
        public Int32 BarsFilesSent { get; set; }
        /// <summary>
        /// Gets or sets the BarsRequests.
        /// </summary>
        [DataMember]
        public Int32 BarsRequests { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataEvents.
        /// </summary>
        [DataMember]
        public Int64 FundamentalDataEvents { get; set; }
        /// <summary>
        /// Gets or sets the IsUpdated.
        /// </summary>
        [DataMember]
        public Boolean IsUpdated { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataEvents.
        /// </summary>
        [DataMember]
        public Int64 MarketDataEvents { get; set; }
        /// <summary>
        /// Gets or sets the MarketDepthEvents.
        /// </summary>
        [DataMember]
        public Int64 MarketDepthEvents { get; set; }
        /// <summary>
        /// Gets or sets the PlaybackBytesSent.
        /// </summary>
        [DataMember]
        public Int64 PlaybackBytesSent { get; set; }
        /// <summary>
        /// Gets or sets the PlaybackRequests.
        /// </summary>
        [DataMember]
        public Int32 PlaybackRequests { get; set; }
        /// <summary>
        /// Gets or sets the TimeLastEvent.
        /// </summary>
        [DataMember]
        public DateTime TimeLastEvent { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
