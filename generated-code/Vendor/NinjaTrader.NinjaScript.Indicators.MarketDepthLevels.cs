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
        public double MaxPrice { get; set; }
        /// <summary>
        /// Gets or sets the MinPrice.
        /// </summary>
        [DataMember]
        public double MinPrice { get; set; }
        /// <summary>
        /// Gets or sets the StartPrice.
        /// </summary>
        [DataMember]
        public double StartPrice { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Add method.
        /// </summary>
        /// <param name="price">double</param>
        /// <param name="volume">int</param>
        /// <param name="isAsk">bool</param>
        public void Add(double price, int volume, bool isAsk)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetMaxVolume method.
        /// </summary>
        /// <param name="minPrice">double</param>
        /// <param name="maxPrice">double</param>
        /// <param name="showExtended">bool</param>
        /// <returns>int</returns>
        public int GetMaxVolume(double minPrice, double maxPrice, bool showExtended)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Seal method.
        /// </summary>
        public void Seal()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetLadder method.
        /// </summary>
        /// <returns>System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<int, System.Tuple<int, int>>></returns>
        public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<int, System.Tuple<int, int>>> GetLadder()
        {
            // Method implementation goes here
        }
        #endregion
    }
}
