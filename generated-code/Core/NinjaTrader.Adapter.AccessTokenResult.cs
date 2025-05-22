[Serializable]
[DataContract]
namespace NinjaTrader.Adapter
{
    public partial class AccessTokenResult
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AccessToken.
        /// </summary>
        [DataMember]
        public string AccessToken { get; set; }
        /// <summary>
        /// Gets or sets the HasFunded.
        /// </summary>
        [DataMember]
        public bool HasFunded { get; set; }
        /// <summary>
        /// Gets or sets the HasLive.
        /// </summary>
        [DataMember]
        public bool HasLive { get; set; }
        /// <summary>
        /// Gets or sets the HasMarketData.
        /// </summary>
        [DataMember]
        public bool HasMarketData { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataAccessToken.
        /// </summary>
        [DataMember]
        public string MarketDataAccessToken { get; set; }
        /// <summary>
        /// Gets or sets the PenaltyTicket.
        /// </summary>
        [DataMember]
        public string PenaltyTicket { get; set; }
        /// <summary>
        /// Gets or sets the TokenExpiration.
        /// </summary>
        [DataMember]
        public System.DateTime TokenExpiration { get; set; }
        /// <summary>
        /// Gets or sets the UserId.
        /// </summary>
        [DataMember]
        public long UserId { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
