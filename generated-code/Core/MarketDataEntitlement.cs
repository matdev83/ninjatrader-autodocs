[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class MarketDataEntitlement : ISnapShotSerializable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the CqgCastNonProMarketData.
        /// </summary>
        [DataMember]
        public String CqgCastNonProMarketData { get; set; }
        /// <summary>
        /// Gets or sets the CqgCastProMarketData.
        /// </summary>
        [DataMember]
        public String CqgCastProMarketData { get; set; }
        /// <summary>
        /// Gets or sets the CqgCastNonProMarketDepth.
        /// </summary>
        [DataMember]
        public String CqgCastNonProMarketDepth { get; set; }
        /// <summary>
        /// Gets or sets the CqgCastProMarketDepth.
        /// </summary>
        [DataMember]
        public String CqgCastProMarketDepth { get; set; }
        /// <summary>
        /// Gets or sets the MasterInstrumentsSerializable.
        /// </summary>
        [DataMember]
        public String[] MasterInstrumentsSerializable { get; set; }
        /// <summary>
        /// Gets or sets the All.
        /// </summary>
        [DataMember]
        public Collection<MarketDataEntitlement> All { get; set; }
        /// <summary>
        /// Gets or sets the MasterInstruments.
        /// </summary>
        [DataMember]
        public Collection<MasterInstrument> MasterInstruments { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public String Name { get; set; }
        /// <summary>
        /// Gets or sets the PriceMarketDataNonPro.
        /// </summary>
        [DataMember]
        public Double PriceMarketDataNonPro { get; set; }
        /// <summary>
        /// Gets or sets the PriceMarketDataPro.
        /// </summary>
        [DataMember]
        public Double PriceMarketDataPro { get; set; }
        /// <summary>
        /// Gets or sets the PriceMarketDepthNonPro.
        /// </summary>
        [DataMember]
        public Double PriceMarketDepthNonPro { get; set; }
        /// <summary>
        /// Gets or sets the PriceMarketDepthPro.
        /// </summary>
        [DataMember]
        public Double PriceMarketDepthPro { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="marketDataEntitlement">MarketDataEntitlement</param>
        public Void CopyTo(MarketDataEntitlement marketDataEntitlement);
        /// <summary>
        /// Remove method.
        /// </summary>
        public Void Remove();
        /// <summary>
        /// Save method.
        /// </summary>
        /// <param name="persist">Boolean</param>
        public Void Save(Boolean persist);
        /// <summary>
        /// SnapShotPersist method.
        /// </summary>
        /// <param name="updateVersion">Boolean</param>
        public Void SnapShotPersist(Boolean updateVersion);
        /// <summary>
        /// Get method.
        /// </summary>
        /// <param name="name">String</param>
        /// <returns>MarketDataEntitlement</returns>
        public MarketDataEntitlement Get(String name);
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>String</returns>
        public String ToString();
        #endregion
    }
}
