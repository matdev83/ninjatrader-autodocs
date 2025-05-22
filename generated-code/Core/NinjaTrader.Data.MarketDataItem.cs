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
        public double Open { get; set; }
        /// <summary>
        /// Gets or sets the High.
        /// </summary>
        [DataMember]
        public double High { get; set; }
        /// <summary>
        /// Gets or sets the Low.
        /// </summary>
        [DataMember]
        public double Low { get; set; }
        /// <summary>
        /// Gets or sets the Close.
        /// </summary>
        [DataMember]
        public double Close { get; set; }
        /// <summary>
        /// Gets or sets the Bid.
        /// </summary>
        [DataMember]
        public double Bid { get; set; }
        /// <summary>
        /// Gets or sets the Ask.
        /// </summary>
        [DataMember]
        public double Ask { get; set; }
        /// <summary>
        /// Gets or sets the TickId.
        /// </summary>
        [DataMember]
        public long TickId { get; set; }
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
        #endregion
        #region Methods
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
