[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.BarsTypes
{
    public partial class VolumetricData
    {
        #region Properties
        /// <summary>
        /// Gets or sets the BarDelta.
        /// </summary>
        [DataMember]
        public Int64 BarDelta { get; set; }
        /// <summary>
        /// Gets or sets the CumulativeDelta.
        /// </summary>
        [DataMember]
        public Int64 CumulativeDelta { get; set; }
        /// <summary>
        /// Gets or sets the DeltaSh.
        /// </summary>
        [DataMember]
        public Int64 DeltaSh { get; set; }
        /// <summary>
        /// Gets or sets the DeltaSl.
        /// </summary>
        [DataMember]
        public Int64 DeltaSl { get; set; }
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
        /// Gets or sets the MaxSeenDelta.
        /// </summary>
        [DataMember]
        public Int64 MaxSeenDelta { get; set; }
        /// <summary>
        /// Gets or sets the MinSeenDelta.
        /// </summary>
        [DataMember]
        public Int64 MinSeenDelta { get; set; }
        /// <summary>
        /// Gets or sets the Trades.
        /// </summary>
        [DataMember]
        public Int64 Trades { get; set; }
        /// <summary>
        /// Gets or sets the TotalBuyingVolume.
        /// </summary>
        [DataMember]
        public Int64 TotalBuyingVolume { get; set; }
        /// <summary>
        /// Gets or sets the TotalSellingVolume.
        /// </summary>
        [DataMember]
        public Int64 TotalSellingVolume { get; set; }
        /// <summary>
        /// Gets or sets the TotalVolume.
        /// </summary>
        [DataMember]
        public Int64 TotalVolume { get; set; }
        /// <summary>
        /// Gets or sets the Volumes.
        /// </summary>
        [DataMember]
        public Int64[0...,0...] Volumes { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Add method.
        /// </summary>
        /// <param name="bars">Bars</param>
        /// <param name="price">Double</param>
        /// <param name="volume">Int64</param>
        /// <param name="isBuying">Boolean</param>
        /// <param name="filter">Int32</param>
        public Void Add(Bars bars, Double price, Int64 volume, Boolean isBuying, Int32 filter);
        /// <summary>
        /// GetMaximumVolume method.
        /// </summary>
        /// <param name="askVolume">Nullable`1</param>
        /// <param name="price">Double&</param>
        /// <returns>Int64</returns>
        public Int64 GetMaximumVolume(Nullable<Boolean> askVolume, Double& price);
        /// <summary>
        /// GetMaximumPositiveDelta method.
        /// </summary>
        /// <returns>Int64</returns>
        public Int64 GetMaximumPositiveDelta();
        /// <summary>
        /// GetMaximumNegativeDelta method.
        /// </summary>
        /// <returns>Int64</returns>
        public Int64 GetMaximumNegativeDelta();
        /// <summary>
        /// GetDeltaPercent method.
        /// </summary>
        /// <returns>Double</returns>
        public Double GetDeltaPercent();
        /// <summary>
        /// GetDeltaForPrice method.
        /// </summary>
        /// <param name="price">Double</param>
        /// <returns>Int64</returns>
        public Int64 GetDeltaForPrice(Double price);
        /// <summary>
        /// GetAskVolumeForPrice method.
        /// </summary>
        /// <param name="price">Double</param>
        /// <returns>Int64</returns>
        public Int64 GetAskVolumeForPrice(Double price);
        /// <summary>
        /// GetBidVolumeForPrice method.
        /// </summary>
        /// <param name="price">Double</param>
        /// <returns>Int64</returns>
        public Int64 GetBidVolumeForPrice(Double price);
        /// <summary>
        /// GetTotalVolumeForPrice method.
        /// </summary>
        /// <param name="price">Double</param>
        /// <returns>Int64</returns>
        public Int64 GetTotalVolumeForPrice(Double price);
        #endregion
    }
}
