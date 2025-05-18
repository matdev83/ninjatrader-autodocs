[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class MarketReplay : IDisposable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the CurrentMarketData.
        /// </summary>
        [DataMember]
        public MarketDataEventArgs CurrentMarketData { get; set; }
        /// <summary>
        /// Gets or sets the CurrentMarketDepth.
        /// </summary>
        [DataMember]
        public MarketDepthEventArgs CurrentMarketDepth { get; set; }
        /// <summary>
        /// Gets or sets the DoInitMarketDepth.
        /// </summary>
        [DataMember]
        public Boolean DoInitMarketDepth { get; set; }
        /// <summary>
        /// Gets or sets the IsMinTimeCheckEnabled.
        /// </summary>
        [DataMember]
        public Boolean IsMinTimeCheckEnabled { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Dispose method.
        /// </summary>
        public Void Dispose();
        /// <summary>
        /// DumpMarketData method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        /// <param name="from">DateTime</param>
        /// <param name="to">DateTime</param>
        /// <param name="path">String</param>
        /// <returns>Boolean</returns>
        public Boolean DumpMarketData(Instrument instrument, DateTime from, DateTime to, String path);
        /// <summary>
        /// DumpMarketDepth method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        /// <param name="from">DateTime</param>
        /// <param name="to">DateTime</param>
        /// <param name="path">String</param>
        public Void DumpMarketDepth(Instrument instrument, DateTime from, DateTime to, String path);
        /// <summary>
        /// MoveNext method.
        /// </summary>
        /// <returns>Boolean</returns>
        public Boolean MoveNext();
        /// <summary>
        /// OnMarketData method.
        /// </summary>
        /// <param name="marketDataType">MarketDataType</param>
        /// <param name="price">Double</param>
        /// <param name="volume">Int64</param>
        /// <param name="timeLocal">DateTime</param>
        public Void OnMarketData(MarketDataType marketDataType, Double price, Int64 volume, DateTime timeLocal);
        /// <summary>
        /// OnMarketDepth method.
        /// </summary>
        /// <param name="position">Int32</param>
        /// <param name="marketMaker">String</param>
        /// <param name="operation">Operation</param>
        /// <param name="marketDataType">MarketDataType</param>
        /// <param name="price">Double</param>
        /// <param name="volume">Int64</param>
        /// <param name="timeLocal">DateTime</param>
        public Void OnMarketDepth(Int32 position, String marketMaker, Operation operation, MarketDataType marketDataType, Double price, Int64 volume, DateTime timeLocal);
        /// <summary>
        /// Start method.
        /// </summary>
        public Void Start();
        /// <summary>
        /// Stop method.
        /// </summary>
        public Void Stop();
        #endregion
    }
}
