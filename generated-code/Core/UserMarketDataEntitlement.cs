[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class UserMarketDataEntitlement
    {
        #region Properties
        /// <summary>
        /// Gets or sets the MarketData.
        /// </summary>
        [DataMember]
        public Boolean MarketData { get; set; }
        /// <summary>
        /// Gets or sets the MarketDepth.
        /// </summary>
        [DataMember]
        public Boolean MarketDepth { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
