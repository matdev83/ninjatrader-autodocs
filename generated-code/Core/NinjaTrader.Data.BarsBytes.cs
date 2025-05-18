[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class BarsBytes : IDisposable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the IsRecordingSuspended.
        /// </summary>
        [DataMember]
        public Boolean IsRecordingSuspended { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriod.
        /// </summary>
        [DataMember]
        public BarsPeriod BarsPeriod { get; set; }
        /// <summary>
        /// Gets or sets the Count.
        /// </summary>
        [DataMember]
        public Int32 Count { get; set; }
        /// <summary>
        /// Gets or sets the FileName.
        /// </summary>
        [DataMember]
        public String FileName { get; set; }
        /// <summary>
        /// Gets or sets the FirstTime.
        /// </summary>
        [DataMember]
        public DateTime FirstTime { get; set; }
        /// <summary>
        /// Gets or sets the Instrument.
        /// </summary>
        [DataMember]
        public Instrument Instrument { get; set; }
        /// <summary>
        /// Gets or sets the IsRecordingMinuteOrDaily.
        /// </summary>
        [DataMember]
        public Boolean IsRecordingMinuteOrDaily { get; set; }
        /// <summary>
        /// Gets or sets the IsTickReplay.
        /// </summary>
        [DataMember]
        public Boolean IsTickReplay { get; set; }
        /// <summary>
        /// Gets or sets the LastTime.
        /// </summary>
        [DataMember]
        public DateTime LastTime { get; set; }
        /// <summary>
        /// Gets or sets the LastTimeUtc.
        /// </summary>
        [DataMember]
        public DateTime LastTimeUtc { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataType.
        /// </summary>
        [DataMember]
        public MarketDataType MarketDataType { get; set; }
        /// <summary>
        /// Gets or sets the MaxTime.
        /// </summary>
        [DataMember]
        public DateTime MaxTime { get; set; }
        /// <summary>
        /// Gets or sets the MinTime.
        /// </summary>
        [DataMember]
        public DateTime MinTime { get; set; }
        /// <summary>
        /// Gets or sets the TickSize.
        /// </summary>
        [DataMember]
        public Double TickSize { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Compress method.
        /// </summary>
        /// <param name="open">Double</param>
        /// <param name="high">Double</param>
        /// <param name="low">Double</param>
        /// <param name="close">Double</param>
        /// <param name="volume">Int64</param>
        /// <param name="time">DateTime</param>
        /// <param name="bid">Double</param>
        /// <param name="ask">Double</param>
        /// <param name="barIndexReplay">Int32</param>
        public Void Compress(Double open, Double high, Double low, Double close, Int64 volume, DateTime time, Double bid, Double ask, Int32 barIndexReplay);
        /// <summary>
        /// DecompressReplayTick method.
        /// </summary>
        /// <param name="reader">BinaryReader</param>
        /// <param name="previousBarIndex">Int32</param>
        /// <param name="lastTimeRead">DateTime</param>
        /// <param name="lastOpenRead">Double</param>
        /// <returns>ReplayObject</returns>
        public ReplayObject DecompressReplayTick(BinaryReader reader, Int32 previousBarIndex, DateTime lastTimeRead, Double lastOpenRead);
        /// <summary>
        /// GetDataDir method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        /// <param name="periodType">BarsPeriodType</param>
        /// <returns>String</returns>
        public String GetDataDir(Instrument instrument, BarsPeriodType periodType);
        /// <summary>
        /// OnMarketData method.
        /// </summary>
        /// <param name="price">Double</param>
        /// <param name="volume">Int64</param>
        /// <param name="time">DateTime</param>
        /// <param name="tickId">Int64</param>
        public Void OnMarketData(Double price, Int64 volume, DateTime time, Int64 tickId);
        /// <summary>
        /// ReadReplay method.
        /// </summary>
        /// <param name="fileName">String</param>
        /// <returns>Tuple`2</returns>
        public Tuple<Int32, DateTime> ReadReplay(String fileName);
        /// <summary>
        /// WriteToFile method.
        /// </summary>
        public Void WriteToFile();
        /// <summary>
        /// Decompress method.
        /// </summary>
        /// <param name="reader">BinaryReader</param>
        /// <param name="barsProxy">Bars</param>
        /// <returns>Boolean</returns>
        public Boolean Decompress(BinaryReader reader, Bars barsProxy);
        /// <summary>
        /// Decompress method.
        /// </summary>
        /// <param name="reader">BinaryReader</param>
        /// <param name="fromUtc">Boolean</param>
        /// <param name="barsProxy">Bars</param>
        /// <param name="minTime">Nullable`1</param>
        /// <param name="maxTime">Nullable`1</param>
        /// <param name="suppressSessionHandling">Boolean</param>
        /// <returns>Boolean</returns>
        public Boolean Decompress(BinaryReader reader, Boolean fromUtc, Bars barsProxy, Nullable<DateTime> minTime, Nullable<DateTime> maxTime, Boolean suppressSessionHandling);
        /// <summary>
        /// Dispose method.
        /// </summary>
        public Void Dispose();
        /// <summary>
        /// GetTickMaxTime method.
        /// </summary>
        /// <param name="time">DateTime</param>
        /// <returns>DateTime</returns>
        public DateTime GetTickMaxTime(DateTime time);
        /// <summary>
        /// SetLastBarIndexReplay method.
        /// </summary>
        /// <param name="index">Int32</param>
        public Void SetLastBarIndexReplay(Int32 index);
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>String</returns>
        public String ToString();
        #endregion
    }
}
