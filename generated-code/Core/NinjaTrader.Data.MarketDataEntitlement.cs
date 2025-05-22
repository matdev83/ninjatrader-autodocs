[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class MarketDataEntitlement : NinjaTrader.Cbi.ISnapShotSerializable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the CqgCastNonProMarketData.
        /// </summary>
        [DataMember]
        public string CqgCastNonProMarketData { get; set; }
        /// <summary>
        /// Gets or sets the CqgCastProMarketData.
        /// </summary>
        [DataMember]
        public string CqgCastProMarketData { get; set; }
        /// <summary>
        /// Gets or sets the CqgCastNonProMarketDepth.
        /// </summary>
        [DataMember]
        public string CqgCastNonProMarketDepth { get; set; }
        /// <summary>
        /// Gets or sets the CqgCastProMarketDepth.
        /// </summary>
        [DataMember]
        public string CqgCastProMarketDepth { get; set; }
        /// <summary>
        /// Gets or sets the MasterInstrumentsSerializable.
        /// </summary>
        [DataMember]
        public System.String[] MasterInstrumentsSerializable { get; set; }
        /// <summary>
        /// Gets or sets the All.
        /// </summary>
        [DataMember]
        public System.Collections.ObjectModel.Collection<NinjaTrader.Data.MarketDataEntitlement> All { get; set; }
        /// <summary>
        /// Gets or sets the MasterInstruments.
        /// </summary>
        [DataMember]
        public System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.MasterInstrument> MasterInstruments { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the PriceMarketDataNonPro.
        /// </summary>
        [DataMember]
        public double PriceMarketDataNonPro { get; set; }
        /// <summary>
        /// Gets or sets the PriceMarketDataPro.
        /// </summary>
        [DataMember]
        public double PriceMarketDataPro { get; set; }
        /// <summary>
        /// Gets or sets the PriceMarketDepthNonPro.
        /// </summary>
        [DataMember]
        public double PriceMarketDepthNonPro { get; set; }
        /// <summary>
        /// Gets or sets the PriceMarketDepthPro.
        /// </summary>
        [DataMember]
        public double PriceMarketDepthPro { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="marketDataEntitlement">NinjaTrader.Data.MarketDataEntitlement</param>
        public void CopyTo(NinjaTrader.Data.MarketDataEntitlement marketDataEntitlement)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Remove method.
        /// </summary>
        public void Remove()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Save method.
        /// </summary>
        /// <param name="persist">bool</param>
        public void Save(bool persist)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SnapShotPersist method.
        /// </summary>
        /// <param name="updateVersion">bool</param>
        public void SnapShotPersist(bool updateVersion)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Get method.
        /// </summary>
        /// <param name="name">string</param>
        /// <returns>NinjaTrader.Data.MarketDataEntitlement</returns>
        public NinjaTrader.Data.MarketDataEntitlement Get(string name)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>string</returns>
        public string ToString()
        {
            // Method implementation goes here
        }
        #endregion
    }
}
