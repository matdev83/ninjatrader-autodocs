[Serializable]
[DataContract]
namespace NinjaTrader.Server
{
    public partial class BPDataStatistics
    {
        #region Properties
        /// <summary>
        /// Gets or sets the FundamentalDataEvents.
        /// </summary>
        [DataMember]
        public long FundamentalDataEvents { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataSubscriptions.
        /// </summary>
        [DataMember]
        public int FundamentalDataSubscriptions { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataSubscriptionsTotal.
        /// </summary>
        [DataMember]
        public int FundamentalDataSubscriptionsTotal { get; set; }
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
        /// Gets or sets the MarketDataSubscriptions.
        /// </summary>
        [DataMember]
        public int MarketDataSubscriptions { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataSubscriptionsTotal.
        /// </summary>
        [DataMember]
        public int MarketDataSubscriptionsTotal { get; set; }
        /// <summary>
        /// Gets or sets the MarketDepthEvents.
        /// </summary>
        [DataMember]
        public long MarketDepthEvents { get; set; }
        /// <summary>
        /// Gets or sets the MarketDepthSubscriptions.
        /// </summary>
        [DataMember]
        public int MarketDepthSubscriptions { get; set; }
        /// <summary>
        /// Gets or sets the MarketDepthSubscriptionsTotal.
        /// </summary>
        [DataMember]
        public int MarketDepthSubscriptionsTotal { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
