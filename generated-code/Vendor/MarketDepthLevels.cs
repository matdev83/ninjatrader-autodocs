[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class MarketDepthLevels
    {
        #region Properties
        /// <summary>
        /// Gets or sets the MaxPrice.
        /// </summary>
        [DataMember]
        public Double MaxPrice { get; set; }
        /// <summary>
        /// Gets or sets the MinPrice.
        /// </summary>
        [DataMember]
        public Double MinPrice { get; set; }
        /// <summary>
        /// Gets or sets the StartPrice.
        /// </summary>
        [DataMember]
        public Double StartPrice { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Add method.
        /// </summary>
        /// <param name="price">Double</param>
        /// <param name="volume">Int32</param>
        /// <param name="isAsk">Boolean</param>
        public Void Add(Double price, Int32 volume, Boolean isAsk);
        /// <summary>
        /// GetMaxVolume method.
        /// </summary>
        /// <param name="minPrice">Double</param>
        /// <param name="maxPrice">Double</param>
        /// <param name="showExtended">Boolean</param>
        /// <returns>Int32</returns>
        public Int32 GetMaxVolume(Double minPrice, Double maxPrice, Boolean showExtended);
        /// <summary>
        /// Seal method.
        /// </summary>
        public Void Seal();
        /// <summary>
        /// GetLadder method.
        /// </summary>
        /// <returns>IEnumerable`1</returns>
        public IEnumerable<KeyValuePair<Int32, Tuple<Int32, Int32>>> GetLadder();
        #endregion
    }
}
