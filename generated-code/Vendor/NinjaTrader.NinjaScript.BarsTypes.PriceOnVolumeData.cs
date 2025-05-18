[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.BarsTypes
{
    public partial class PriceOnVolumeData
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
        /// Gets or sets the High.
        /// </summary>
        [DataMember]
        public Double High { get; set; }
        /// <summary>
        /// Gets or sets the Level2Volume.
        /// </summary>
        [DataMember]
        public List<Int64> Level2Volume { get; set; }
        /// <summary>
        /// Gets or sets the Low.
        /// </summary>
        [DataMember]
        public Double Low { get; set; }
        /// <summary>
        /// Gets or sets the MaxVolume.
        /// </summary>
        [DataMember]
        public Int64 MaxVolume { get; set; }
        /// <summary>
        /// Gets or sets the MinVolume.
        /// </summary>
        [DataMember]
        public Int64 MinVolume { get; set; }
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
        public Void Add(Bars bars, Double price, Int64 volume, Boolean isBuying);
        #endregion
    }
}
