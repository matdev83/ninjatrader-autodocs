[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class MarketProfile
    {
        #region Properties
        /// <summary>
        /// Gets or sets the HasData.
        /// </summary>
        [DataMember]
        public Boolean HasData { get; set; }
        /// <summary>
        /// Gets or sets the Open.
        /// </summary>
        [DataMember]
        public Double Open { get; set; }
        /// <summary>
        /// Gets or sets the Close.
        /// </summary>
        [DataMember]
        public Double Close { get; set; }
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
        /// Gets or sets the PocNaked.
        /// </summary>
        [DataMember]
        public Nullable<DateTime> PocNaked { get; set; }
        /// <summary>
        /// Gets or sets the VahNaked.
        /// </summary>
        [DataMember]
        public Nullable<DateTime> VahNaked { get; set; }
        /// <summary>
        /// Gets or sets the ValNaked.
        /// </summary>
        [DataMember]
        public Nullable<DateTime> ValNaked { get; set; }
        /// <summary>
        /// Gets or sets the Poc.
        /// </summary>
        [DataMember]
        public Double Poc { get; set; }
        /// <summary>
        /// Gets or sets the Vah.
        /// </summary>
        [DataMember]
        public Double Vah { get; set; }
        /// <summary>
        /// Gets or sets the Val.
        /// </summary>
        [DataMember]
        public Double Val { get; set; }
        /// <summary>
        /// Gets or sets the StartTime.
        /// </summary>
        [DataMember]
        public DateTime StartTime { get; set; }
        /// <summary>
        /// Gets or sets the EndTime.
        /// </summary>
        [DataMember]
        public DateTime EndTime { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Add method.
        /// </summary>
        /// <param name="volume">Int64</param>
        /// <param name="price">Double</param>
        /// <param name="time">DateTime</param>
        /// <param name="isAsk">Boolean</param>
        public Void Add(Int64 volume, Double price, DateTime time, Boolean isAsk);
        /// <summary>
        /// GetPercentageOfMaximum method.
        /// </summary>
        /// <param name="price">Double</param>
        /// <returns>Single</returns>
        public Single GetPercentageOfMaximum(Double price);
        /// <summary>
        /// GetVolumeAtPrice method.
        /// </summary>
        /// <param name="price">Double</param>
        /// <returns>Int64</returns>
        public Int64 GetVolumeAtPrice(Double price);
        /// <summary>
        /// IndexToPrice method.
        /// </summary>
        /// <param name="index">Int32</param>
        /// <returns>Double</returns>
        public Double IndexToPrice(Int32 index);
        /// <summary>
        /// Merge method.
        /// </summary>
        /// <param name="profile">MarketProfile</param>
        public Void Merge(MarketProfile profile);
        /// <summary>
        /// PriceToIndex method.
        /// </summary>
        /// <param name="price">Double</param>
        /// <returns>Int32</returns>
        public Int32 PriceToIndex(Double price);
        /// <summary>
        /// Render method.
        /// </summary>
        /// <param name="renderTarget">RenderTarget</param>
        /// <param name="x">Single</param>
        /// <param name="width">Single</param>
        /// <param name="cc">ChartControl</param>
        /// <param name="cs">ChartScale</param>
        public Void Render(RenderTarget renderTarget, Single x, Single width, ChartControl cc, ChartScale cs);
        #endregion
    }
}
