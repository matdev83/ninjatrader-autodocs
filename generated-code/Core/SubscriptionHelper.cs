[Serializable]
[DataContract]
    public partial class SubscriptionHelper
    {
        #region Properties
        /// <summary>
        /// Gets or sets the FundamentalDataCallbacks.
        /// </summary>
        [DataMember]
        public List<Tuple<GatewayAdapter, Action<FundamentalDataType, Object>>> FundamentalDataCallbacks { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataCallbacks.
        /// </summary>
        [DataMember]
        public List<Tuple<GatewayAdapter, Action<MarketDataType, Double, Int64, DateTime, Int64>>> MarketDataCallbacks { get; set; }
        /// <summary>
        /// Gets or sets the MarketDepthCallbacks.
        /// </summary>
        [DataMember]
        public List<Tuple<GatewayAdapter, Action<Int32, String, Operation, MarketDataType, Double, Int64, DateTime>>> MarketDepthCallbacks { get; set; }
        /// <summary>
        /// Gets or sets the SessionBarSimulator.
        /// </summary>
        [DataMember]
        public SessionBarSimulator SessionBarSimulator { get; set; }
        #endregion
        #region Methods
        #endregion
    }
