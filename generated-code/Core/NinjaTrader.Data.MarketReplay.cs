[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class MarketReplay : System.IDisposable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the CurrentMarketData.
        /// </summary>
        [DataMember]
        public NinjaTrader.Data.MarketDataEventArgs CurrentMarketData { get; set; }
        /// <summary>
        /// Gets or sets the CurrentMarketDepth.
        /// </summary>
        [DataMember]
        public NinjaTrader.Data.MarketDepthEventArgs CurrentMarketDepth { get; set; }
        /// <summary>
        /// Gets or sets the DoInitMarketDepth.
        /// </summary>
        [DataMember]
        public bool DoInitMarketDepth { get; set; }
        /// <summary>
        /// Gets or sets the IsMinTimeCheckEnabled.
        /// </summary>
        [DataMember]
        public bool IsMinTimeCheckEnabled { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Dispose method.
        /// </summary>
        public void Dispose()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DumpMarketData method.
        /// </summary>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        /// <param name="from">System.DateTime</param>
        /// <param name="to">System.DateTime</param>
        /// <param name="path">string</param>
        /// <returns>bool</returns>
        public bool DumpMarketData(NinjaTrader.Cbi.Instrument instrument, System.DateTime from, System.DateTime to, string path)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DumpMarketDepth method.
        /// </summary>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        /// <param name="from">System.DateTime</param>
        /// <param name="to">System.DateTime</param>
        /// <param name="path">string</param>
        public void DumpMarketDepth(NinjaTrader.Cbi.Instrument instrument, System.DateTime from, System.DateTime to, string path)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// MoveNext method.
        /// </summary>
        /// <returns>bool</returns>
        public bool MoveNext()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// OnMarketData method.
        /// </summary>
        /// <param name="marketDataType">MarketDataType</param>
        /// <param name="price">double</param>
        /// <param name="volume">long</param>
        /// <param name="timeLocal">System.DateTime</param>
        public void OnMarketData(MarketDataType marketDataType, double price, long volume, System.DateTime timeLocal)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// OnMarketDepth method.
        /// </summary>
        /// <param name="position">int</param>
        /// <param name="marketMaker">string</param>
        /// <param name="operation">Operation</param>
        /// <param name="marketDataType">MarketDataType</param>
        /// <param name="price">double</param>
        /// <param name="volume">long</param>
        /// <param name="timeLocal">System.DateTime</param>
        public void OnMarketDepth(int position, string marketMaker, Operation operation, MarketDataType marketDataType, double price, long volume, System.DateTime timeLocal)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Start method.
        /// </summary>
        public void Start()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Stop method.
        /// </summary>
        public void Stop()
        {
            // Method implementation goes here
        }
        #endregion
    }
}
