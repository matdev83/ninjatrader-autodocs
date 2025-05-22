[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class MarketDepth<T> where T : NinjaTrader.Data.MarketDepthRow, new()
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Asks.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.List<T> Asks { get; set; }
        /// <summary>
        /// Gets or sets the Bids.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.List<T> Bids { get; set; }
        /// <summary>
        /// Gets or sets the Instrument.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Instrument Instrument { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
