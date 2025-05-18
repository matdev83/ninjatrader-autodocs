[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class BrushSeries
    {
        #region Properties
        /// <summary>
        /// Gets or sets the IsAnySet.
        /// </summary>
        [DataMember]
        public Boolean IsAnySet { get; set; }
        /// <summary>
        /// Gets or sets the RenderTarget.
        /// </summary>
        [DataMember]
        public RenderTarget RenderTarget { get; set; }
        /// <summary>
        /// Gets or sets the Count.
        /// </summary>
        [DataMember]
        public Int32 Count { get; set; }
        /// <summary>
        /// Gets or sets the Item.
        /// </summary>
        [DataMember]
        public Brush Item { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Get method.
        /// </summary>
        /// <param name="index">Int32</param>
        /// <returns>Brush</returns>
        public Brush Get(Int32 index);
        /// <summary>
        /// GetDxBrush method.
        /// </summary>
        /// <param name="index">Int32</param>
        /// <returns>Brush</returns>
        public Brush GetDxBrush(Int32 index);
        /// <summary>
        /// Reset method.
        /// </summary>
        public Void Reset();
        /// <summary>
        /// Set method.
        /// </summary>
        /// <param name="index">Int32</param>
        /// <param name="value">Brush</param>
        public Void Set(Int32 index, Brush value);
        #endregion
    }
}
