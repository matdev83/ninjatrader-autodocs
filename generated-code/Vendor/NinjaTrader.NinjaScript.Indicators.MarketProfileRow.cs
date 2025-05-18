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
        public Int64 AskVolume { get; set; }
        /// <summary>
        /// Gets or sets the BidVolume.
        /// </summary>
        [DataMember]
        public Int64 BidVolume { get; set; }
        /// <summary>
        /// Gets or sets the TotalVolume.
        /// </summary>
        [DataMember]
        public Int64 TotalVolume { get; set; }
        /// <summary>
        /// Gets or sets the TimeSlotsCount.
        /// </summary>
        [DataMember]
        public Int32 TimeSlotsCount { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Add method.
        /// </summary>
        /// <param name="volume">Int64</param>
        /// <param name="time">DateTime</param>
        /// <param name="isAsk">Boolean</param>
        /// <returns>Boolean</returns>
        public Boolean Add(Int64 volume, DateTime time, Boolean isAsk);
        /// <summary>
        /// HasVolumeAtIndex method.
        /// </summary>
        /// <param name="idx">Int32</param>
        /// <returns>Boolean</returns>
        public Boolean HasVolumeAtIndex(Int32 idx);
        /// <summary>
        /// Merge method.
        /// </summary>
        /// <param name="row">MarketProfileRow</param>
        public Void Merge(MarketProfileRow row);
        #endregion
    }
}
