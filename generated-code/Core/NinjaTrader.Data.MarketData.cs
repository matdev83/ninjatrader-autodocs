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
        public NinjaTrader.Data.MarketDataEventArgs Ask { get; set; }
        /// <summary>
        /// Gets or sets the Bid.
        /// </summary>
        [DataMember]
        public NinjaTrader.Data.MarketDataEventArgs Bid { get; set; }
        /// <summary>
        /// Gets or sets the DailyHigh.
        /// </summary>
        [DataMember]
        public NinjaTrader.Data.MarketDataEventArgs DailyHigh { get; set; }
        /// <summary>
        /// Gets or sets the DailyLow.
        /// </summary>
        [DataMember]
        public NinjaTrader.Data.MarketDataEventArgs DailyLow { get; set; }
        /// <summary>
        /// Gets or sets the DailyVolume.
        /// </summary>
        [DataMember]
        public NinjaTrader.Data.MarketDataEventArgs DailyVolume { get; set; }
        /// <summary>
        /// Gets or sets the Instrument.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Instrument Instrument { get; set; }
        /// <summary>
        /// Gets or sets the Last.
        /// </summary>
        [DataMember]
        public NinjaTrader.Data.MarketDataEventArgs Last { get; set; }
        /// <summary>
        /// Gets or sets the LastClose.
        /// </summary>
        [DataMember]
        public NinjaTrader.Data.MarketDataEventArgs LastClose { get; set; }
        /// <summary>
        /// Gets or sets the Opening.
        /// </summary>
        [DataMember]
        public NinjaTrader.Data.MarketDataEventArgs Opening { get; set; }
        /// <summary>
        /// Gets or sets the OpenInterest.
        /// </summary>
        [DataMember]
        public NinjaTrader.Data.MarketDataEventArgs OpenInterest { get; set; }
        /// <summary>
        /// Gets or sets the Settlement.
        /// </summary>
        [DataMember]
        public NinjaTrader.Data.MarketDataEventArgs Settlement { get; set; }
        /// <summary>
        /// Gets or sets the TickFilter.
        /// </summary>
        [DataMember]
        public NinjaTrader.Data.TickFilter TickFilter { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
