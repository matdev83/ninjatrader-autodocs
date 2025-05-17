[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class MarketData
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Ask.
        /// </summary>
        [DataMember]
        public MarketDataEventArgs Ask { get; set; }
        /// <summary>
        /// Gets or sets the Bid.
        /// </summary>
        [DataMember]
        public MarketDataEventArgs Bid { get; set; }
        /// <summary>
        /// Gets or sets the DailyHigh.
        /// </summary>
        [DataMember]
        public MarketDataEventArgs DailyHigh { get; set; }
        /// <summary>
        /// Gets or sets the DailyLow.
        /// </summary>
        [DataMember]
        public MarketDataEventArgs DailyLow { get; set; }
        /// <summary>
        /// Gets or sets the DailyVolume.
        /// </summary>
        [DataMember]
        public MarketDataEventArgs DailyVolume { get; set; }
        /// <summary>
        /// Gets or sets the Instrument.
        /// </summary>
        [DataMember]
        public Instrument Instrument { get; set; }
        /// <summary>
        /// Gets or sets the Last.
        /// </summary>
        [DataMember]
        public MarketDataEventArgs Last { get; set; }
        /// <summary>
        /// Gets or sets the LastClose.
        /// </summary>
        [DataMember]
        public MarketDataEventArgs LastClose { get; set; }
        /// <summary>
        /// Gets or sets the Opening.
        /// </summary>
        [DataMember]
        public MarketDataEventArgs Opening { get; set; }
        /// <summary>
        /// Gets or sets the OpenInterest.
        /// </summary>
        [DataMember]
        public MarketDataEventArgs OpenInterest { get; set; }
        /// <summary>
        /// Gets or sets the Settlement.
        /// </summary>
        [DataMember]
        public MarketDataEventArgs Settlement { get; set; }
        /// <summary>
        /// Gets or sets the TickFilter.
        /// </summary>
        [DataMember]
        public TickFilter TickFilter { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
