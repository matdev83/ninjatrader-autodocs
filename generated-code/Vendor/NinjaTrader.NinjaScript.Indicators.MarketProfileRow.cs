[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class MarketProfileRow
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AskVolume.
        /// </summary>
        [DataMember]
        public long AskVolume { get; set; }
        /// <summary>
        /// Gets or sets the BidVolume.
        /// </summary>
        [DataMember]
        public long BidVolume { get; set; }
        /// <summary>
        /// Gets or sets the TotalVolume.
        /// </summary>
        [DataMember]
        public long TotalVolume { get; set; }
        /// <summary>
        /// Gets or sets the TimeSlotsCount.
        /// </summary>
        [DataMember]
        public int TimeSlotsCount { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Add method.
        /// </summary>
        /// <param name="volume">long</param>
        /// <param name="time">System.DateTime</param>
        /// <param name="isAsk">bool</param>
        /// <returns>bool</returns>
        public bool Add(long volume, System.DateTime time, bool isAsk)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// HasVolumeAtIndex method.
        /// </summary>
        /// <param name="idx">int</param>
        /// <returns>bool</returns>
        public bool HasVolumeAtIndex(int idx)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Merge method.
        /// </summary>
        /// <param name="row">NinjaTrader.NinjaScript.Indicators.MarketProfileRow</param>
        public void Merge(NinjaTrader.NinjaScript.Indicators.MarketProfileRow row)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
