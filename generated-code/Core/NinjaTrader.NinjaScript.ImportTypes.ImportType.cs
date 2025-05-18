[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.ImportTypes
{
    public partial class ImportType : NinjaScript, IDisposable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the BarsPeriodType.
        /// </summary>
        [DataMember]
        public BarsPeriodType BarsPeriodType { get; set; }
        /// <summary>
        /// Gets or sets the HasErrors.
        /// </summary>
        [DataMember]
        public Boolean HasErrors { get; set; }
        /// <summary>
        /// Gets or sets the HasValidDataPoint.
        /// </summary>
        [DataMember]
        public Boolean HasValidDataPoint { get; set; }
        /// <summary>
        /// Gets or sets the HasValidInstrument.
        /// </summary>
        [DataMember]
        public Boolean HasValidInstrument { get; set; }
        /// <summary>
        /// Gets or sets the ImportedInstruments.
        /// </summary>
        [DataMember]
        public Instrument[] ImportedInstruments { get; set; }
        /// <summary>
        /// Gets or sets the NumberOfDataPoints.
        /// </summary>
        [DataMember]
        public Int32 NumberOfDataPoints { get; set; }
        /// <summary>
        /// Gets or sets the Ask.
        /// </summary>
        [DataMember]
        public Double Ask { get; set; }
        /// <summary>
        /// Gets or sets the Bid.
        /// </summary>
        [DataMember]
        public Double Bid { get; set; }
        /// <summary>
        /// Gets or sets the Close.
        /// </summary>
        [DataMember]
        public Double Close { get; set; }
        /// <summary>
        /// Gets or sets the DataPointString.
        /// </summary>
        [DataMember]
        public String DataPointString { get; set; }
        /// <summary>
        /// Gets or sets the High.
        /// </summary>
        [DataMember]
        public Double High { get; set; }
        /// <summary>
        /// Gets or sets the Instrument.
        /// </summary>
        [DataMember]
        public Instrument Instrument { get; set; }
        /// <summary>
        /// Gets or sets the Low.
        /// </summary>
        [DataMember]
        public Double Low { get; set; }
        /// <summary>
        /// Gets or sets the Open.
        /// </summary>
        [DataMember]
        public Double Open { get; set; }
        /// <summary>
        /// Gets or sets the OpenInterest.
        /// </summary>
        [DataMember]
        public Double OpenInterest { get; set; }
        /// <summary>
        /// Gets or sets the Time.
        /// </summary>
        [DataMember]
        public DateTime Time { get; set; }
        /// <summary>
        /// Gets or sets the Volume.
        /// </summary>
        [DataMember]
        public Int64 Volume { get; set; }
        /// <summary>
        /// Gets or sets the LogTypeName.
        /// </summary>
        [DataMember]
        public String LogTypeName { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Dispose method.
        /// </summary>
        public Void Dispose();
        /// <summary>
        /// Import method.
        /// </summary>
        /// <param name="marketDataType">MarketDataType</param>
        /// <param name="sourceTimeZoneInfo">TimeZoneInfo</param>
        /// <param name="generateMinuteBars">Boolean</param>
        /// <param name="generateDailyBars">Boolean</param>
        /// <param name="progress">IProgress</param>
        public Void Import(MarketDataType marketDataType, TimeZoneInfo sourceTimeZoneInfo, Boolean generateMinuteBars, Boolean generateDailyBars, IProgress progress);
        /// <summary>
        /// SetState method.
        /// </summary>
        /// <param name="state">State</param>
        public Void SetState(State state);
        #endregion
    }
}
