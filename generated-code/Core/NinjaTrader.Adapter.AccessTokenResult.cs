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
        public String AccessToken { get; set; }
        /// <summary>
        /// Gets or sets the HasFunded.
        /// </summary>
        [DataMember]
        public Boolean HasFunded { get; set; }
        /// <summary>
        /// Gets or sets the HasLive.
        /// </summary>
        [DataMember]
        public Boolean HasLive { get; set; }
        /// <summary>
        /// Gets or sets the HasMarketData.
        /// </summary>
        [DataMember]
        public Boolean HasMarketData { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataAccessToken.
        /// </summary>
        [DataMember]
        public String MarketDataAccessToken { get; set; }
        /// <summary>
        /// Gets or sets the PenaltyTicket.
        /// </summary>
        [DataMember]
        public String PenaltyTicket { get; set; }
        /// <summary>
        /// Gets or sets the TokenExpiration.
        /// </summary>
        [DataMember]
        public DateTime TokenExpiration { get; set; }
        /// <summary>
        /// Gets or sets the UserId.
        /// </summary>
        [DataMember]
        public Int64 UserId { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
