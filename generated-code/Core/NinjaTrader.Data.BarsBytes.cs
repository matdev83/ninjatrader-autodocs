[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class BarsBytes : System.IDisposable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the IsRecordingSuspended.
        /// </summary>
        [DataMember]
        public bool IsRecordingSuspended { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriod.
        /// </summary>
        [DataMember]
        public NinjaTrader.Data.BarsPeriod BarsPeriod { get; set; }
        /// <summary>
        /// Gets or sets the Count.
        /// </summary>
        [DataMember]
        public int Count { get; set; }
        /// <summary>
        /// Gets or sets the FileName.
        /// </summary>
        [DataMember]
        public string FileName { get; set; }
        /// <summary>
        /// Gets or sets the FirstTime.
        /// </summary>
        [DataMember]
        public System.DateTime FirstTime { get; set; }
        /// <summary>
        /// Gets or sets the Instrument.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Instrument Instrument { get; set; }
        /// <summary>
        /// Gets or sets the IsRecordingMinuteOrDaily.
        /// </summary>
        [DataMember]
        public bool IsRecordingMinuteOrDaily { get; set; }
        /// <summary>
        /// Gets or sets the IsTickReplay.
        /// </summary>
        [DataMember]
        public bool IsTickReplay { get; set; }
        /// <summary>
        /// Gets or sets the LastTime.
        /// </summary>
        [DataMember]
        public System.DateTime LastTime { get; set; }
        /// <summary>
        /// Gets or sets the LastTimeUtc.
        /// </summary>
        [DataMember]
        public System.DateTime LastTimeUtc { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataType.
        /// </summary>
        [DataMember]
        public MarketDataType MarketDataType { get; set; }
        /// <summary>
        /// Gets or sets the MaxTime.
        /// </summary>
        [DataMember]
        public System.DateTime MaxTime { get; set; }
        /// <summary>
        /// Gets or sets the MinTime.
        /// </summary>
        [DataMember]
        public System.DateTime MinTime { get; set; }
        /// <summary>
        /// Gets or sets the TickSize.
        /// </summary>
        [DataMember]
        public double TickSize { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Compress method.
        /// </summary>
        /// <param name="open">double</param>
        /// <param name="high">double</param>
        /// <param name="low">double</param>
        /// <param name="close">double</param>
        /// <param name="volume">long</param>
        /// <param name="time">System.DateTime</param>
        /// <param name="bid">double</param>
        /// <param name="ask">double</param>
        /// <param name="barIndexReplay">int</param>
        public void Compress(double open, double high, double low, double close, long volume, System.DateTime time, double bid, double ask, int barIndexReplay)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DecompressReplayTick method.
        /// </summary>
        /// <param name="reader">System.IO.BinaryReader</param>
        /// <param name="previousBarIndex">int</param>
        /// <param name="lastTimeRead">System.DateTime</param>
        /// <param name="lastOpenRead">double</param>
        /// <returns>NinjaTrader.Data.ReplayObject</returns>
        public NinjaTrader.Data.ReplayObject DecompressReplayTick(System.IO.BinaryReader reader, int previousBarIndex, System.DateTime lastTimeRead, double lastOpenRead)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetDataDir method.
        /// </summary>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        /// <param name="periodType">BarsPeriodType</param>
        /// <returns>string</returns>
        public string GetDataDir(NinjaTrader.Cbi.Instrument instrument, BarsPeriodType periodType)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// OnMarketData method.
        /// </summary>
        /// <param name="price">double</param>
        /// <param name="volume">long</param>
        /// <param name="time">System.DateTime</param>
        /// <param name="tickId">long</param>
        public void OnMarketData(double price, long volume, System.DateTime time, long tickId)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ReadReplay method.
        /// </summary>
        /// <param name="fileName">string</param>
        /// <returns>System.Tuple<int, System.DateTime></returns>
        public System.Tuple<int, System.DateTime> ReadReplay(string fileName)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// WriteToFile method.
        /// </summary>
        public void WriteToFile()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Decompress method.
        /// </summary>
        /// <param name="reader">System.IO.BinaryReader</param>
        /// <param name="barsProxy">NinjaTrader.Data.Bars</param>
        /// <returns>bool</returns>
        public bool Decompress(System.IO.BinaryReader reader, NinjaTrader.Data.Bars barsProxy)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Decompress method.
        /// </summary>
        /// <param name="reader">System.IO.BinaryReader</param>
        /// <param name="fromUtc">bool</param>
        /// <param name="barsProxy">NinjaTrader.Data.Bars</param>
        /// <param name="minTime">System.DateTime?</param>
        /// <param name="maxTime">System.DateTime?</param>
        /// <param name="suppressSessionHandling">bool</param>
        /// <returns>bool</returns>
        public bool Decompress(System.IO.BinaryReader reader, bool fromUtc, NinjaTrader.Data.Bars barsProxy, System.DateTime? minTime, System.DateTime? maxTime, bool suppressSessionHandling)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Dispose method.
        /// </summary>
        public void Dispose()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetTickMaxTime method.
        /// </summary>
        /// <param name="time">System.DateTime</param>
        /// <returns>System.DateTime</returns>
        public System.DateTime GetTickMaxTime(System.DateTime time)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SetLastBarIndexReplay method.
        /// </summary>
        /// <param name="index">int</param>
        public void SetLastBarIndexReplay(int index)
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
