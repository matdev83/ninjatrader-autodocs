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
        public Int64 FundamentalDataEvents { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataSubscriptions.
        /// </summary>
        [DataMember]
        public Int32 FundamentalDataSubscriptions { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataSubscriptionsTotal.
        /// </summary>
        [DataMember]
        public Int32 FundamentalDataSubscriptionsTotal { get; set; }
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
        /// Gets or sets the MarketDataSubscriptions.
        /// </summary>
        [DataMember]
        public Int32 MarketDataSubscriptions { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataSubscriptionsTotal.
        /// </summary>
        [DataMember]
        public Int32 MarketDataSubscriptionsTotal { get; set; }
        /// <summary>
        /// Gets or sets the MarketDepthEvents.
        /// </summary>
        [DataMember]
        public Int64 MarketDepthEvents { get; set; }
        /// <summary>
        /// Gets or sets the MarketDepthSubscriptions.
        /// </summary>
        [DataMember]
        public Int32 MarketDepthSubscriptions { get; set; }
        /// <summary>
        /// Gets or sets the MarketDepthSubscriptionsTotal.
        /// </summary>
        [DataMember]
        public Int32 MarketDepthSubscriptionsTotal { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
