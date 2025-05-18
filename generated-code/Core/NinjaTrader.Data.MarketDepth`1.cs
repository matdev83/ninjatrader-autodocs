[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class MarketDepth`1
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Asks.
        /// </summary>
        [DataMember]
        public List<T> Asks { get; set; }
        /// <summary>
        /// Gets or sets the Bids.
        /// </summary>
        [DataMember]
        public List<T> Bids { get; set; }
        /// <summary>
        /// Gets or sets the Instrument.
        /// </summary>
        [DataMember]
        public Instrument Instrument { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
