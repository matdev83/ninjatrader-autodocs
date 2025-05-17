[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class MarketDataItem
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Open.
        /// </summary>
        [DataMember]
        public Double Open { get; set; }
        /// <summary>
        /// Gets or sets the High.
        /// </summary>
        [DataMember]
        public Double High { get; set; }
        /// <summary>
        /// Gets or sets the Low.
        /// </summary>
        [DataMember]
        public Double Low { get; set; }
        /// <summary>
        /// Gets or sets the Close.
        /// </summary>
        [DataMember]
        public Double Close { get; set; }
        /// <summary>
        /// Gets or sets the Bid.
        /// </summary>
        [DataMember]
        public Double Bid { get; set; }
        /// <summary>
        /// Gets or sets the Ask.
        /// </summary>
        [DataMember]
        public Double Ask { get; set; }
        /// <summary>
        /// Gets or sets the TickId.
        /// </summary>
        [DataMember]
        public Int64 TickId { get; set; }
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
        #endregion
        #region Methods
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>String</returns>
        public String ToString();
        #endregion
    }
}
