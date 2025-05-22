[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class MarketDepthRow
    {
        #region Properties
        /// <summary>
        /// Gets or sets the MarketMaker.
        /// </summary>
        [DataMember]
        public string MarketMaker { get; set; }
        /// <summary>
        /// Gets or sets the Price.
        /// </summary>
        [DataMember]
        public double Price { get; set; }
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
