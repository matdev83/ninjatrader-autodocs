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
        public String MarketMaker { get; set; }
        /// <summary>
        /// Gets or sets the Price.
        /// </summary>
        [DataMember]
        public Double Price { get; set; }
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
