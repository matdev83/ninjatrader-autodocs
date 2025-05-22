[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.ImportTypes
{
    public partial class ImportType : NinjaTrader.NinjaScript.NinjaScript, System.IDisposable
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
        public bool HasErrors { get; set; }
        /// <summary>
        /// Gets or sets the HasValidDataPoint.
        /// </summary>
        [DataMember]
        public bool HasValidDataPoint { get; set; }
        /// <summary>
        /// Gets or sets the HasValidInstrument.
        /// </summary>
        [DataMember]
        public bool HasValidInstrument { get; set; }
        /// <summary>
        /// Gets or sets the ImportedInstruments.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Instrument[] ImportedInstruments { get; set; }
        /// <summary>
        /// Gets or sets the NumberOfDataPoints.
        /// </summary>
        [DataMember]
        public int NumberOfDataPoints { get; set; }
        /// <summary>
        /// Gets or sets the Ask.
        /// </summary>
        [DataMember]
        public double Ask { get; set; }
        /// <summary>
        /// Gets or sets the Bid.
        /// </summary>
        [DataMember]
        public double Bid { get; set; }
        /// <summary>
        /// Gets or sets the Close.
        /// </summary>
        [DataMember]
        public double Close { get; set; }
        /// <summary>
        /// Gets or sets the DataPointString.
        /// </summary>
        [DataMember]
        public string DataPointString { get; set; }
        /// <summary>
        /// Gets or sets the High.
        /// </summary>
        [DataMember]
        public double High { get; set; }
        /// <summary>
        /// Gets or sets the Instrument.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Instrument Instrument { get; set; }
        /// <summary>
        /// Gets or sets the Low.
        /// </summary>
        [DataMember]
        public double Low { get; set; }
        /// <summary>
        /// Gets or sets the Open.
        /// </summary>
        [DataMember]
        public double Open { get; set; }
        /// <summary>
        /// Gets or sets the OpenInterest.
        /// </summary>
        [DataMember]
        public double OpenInterest { get; set; }
        /// <summary>
        /// Gets or sets the Time.
        /// </summary>
        [DataMember]
        public System.DateTime Time { get; set; }
        /// <summary>
        /// Gets or sets the Volume.
        /// </summary>
        [DataMember]
        public long Volume { get; set; }
        /// <summary>
        /// Gets or sets the LogTypeName.
        /// </summary>
        [DataMember]
        public string LogTypeName { get; set; }
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
        /// Import method.
        /// </summary>
        /// <param name="marketDataType">MarketDataType</param>
        /// <param name="sourceTimeZoneInfo">System.TimeZoneInfo</param>
        /// <param name="generateMinuteBars">bool</param>
        /// <param name="generateDailyBars">bool</param>
        /// <param name="progress">NinjaTrader.Core.IProgress</param>
        public void Import(MarketDataType marketDataType, System.TimeZoneInfo sourceTimeZoneInfo, bool generateMinuteBars, bool generateDailyBars, NinjaTrader.Core.IProgress progress)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SetState method.
        /// </summary>
        /// <param name="state">State</param>
        public void SetState(State state)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
