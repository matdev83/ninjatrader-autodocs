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
        public Action<MarketDataType, Double, Int64, DateTime, Int64> Callback { get; set; }
        /// <summary>
        /// Gets or sets the Instrument.
        /// </summary>
        [DataMember]
        public Instrument Instrument { get; set; }
        /// <summary>
        /// Gets or sets the ProviderSupportsSettlementPrice.
        /// </summary>
        [DataMember]
        public Boolean ProviderSupportsSettlementPrice { get; set; }
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
        /// <param name="price">Double</param>
        /// <param name="volume">Int64</param>
        /// <param name="time">DateTime</param>
        public Void OnMarketData(MarketDataType marketDataType, Double price, Int64 volume, DateTime time);
        #endregion
    }
}
