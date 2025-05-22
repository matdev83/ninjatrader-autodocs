[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class SessionBarSimulator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Callback.
        /// </summary>
        [DataMember]
        public System.Action<MarketDataType, double, long, System.DateTime, long> Callback { get; set; }
        /// <summary>
        /// Gets or sets the Instrument.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Instrument Instrument { get; set; }
        /// <summary>
        /// Gets or sets the ProviderSupportsSettlementPrice.
        /// </summary>
        [DataMember]
        public bool ProviderSupportsSettlementPrice { get; set; }
        /// <summary>
        /// Gets or sets the SimulatedMarketDataTypes.
        /// </summary>
        [DataMember]
        public MarketDataType[] SimulatedMarketDataTypes { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// OnMarketData method.
        /// </summary>
        /// <param name="marketDataType">MarketDataType</param>
        /// <param name="price">double</param>
        /// <param name="volume">long</param>
        /// <param name="time">System.DateTime</param>
        public void OnMarketData(MarketDataType marketDataType, double price, long volume, System.DateTime time)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
