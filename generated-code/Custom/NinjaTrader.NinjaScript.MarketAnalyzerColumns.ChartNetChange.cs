[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.MarketAnalyzerColumns
{
    public partial class ChartNetChange : MarketAnalyzerColumnRenderBase
    {
        #region Properties
        /// <summary>
        /// Gets or sets the DownArea.
        /// </summary>
        [DataMember]
        public Brush DownArea { get; set; }
        /// <summary>
        /// Gets or sets the DownAreaSeralizer.
        /// </summary>
        [DataMember]
        public String DownAreaSeralizer { get; set; }
        /// <summary>
        /// Gets or sets the DownOutline.
        /// </summary>
        [DataMember]
        public Brush DownOutline { get; set; }
        /// <summary>
        /// Gets or sets the DownOutlineSeralizer.
        /// </summary>
        [DataMember]
        public String DownOutlineSeralizer { get; set; }
        /// <summary>
        /// Gets or sets the Opacity.
        /// </summary>
        [DataMember]
        public Int32 Opacity { get; set; }
        /// <summary>
        /// Gets or sets the UpArea.
        /// </summary>
        [DataMember]
        public Brush UpArea { get; set; }
        /// <summary>
        /// Gets or sets the UpAreaSeralizer.
        /// </summary>
        [DataMember]
        public String UpAreaSeralizer { get; set; }
        /// <summary>
        /// Gets or sets the UpOutline.
        /// </summary>
        [DataMember]
        public Brush UpOutline { get; set; }
        /// <summary>
        /// Gets or sets the UpOutlineSeralizer.
        /// </summary>
        [DataMember]
        public String UpOutlineSeralizer { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// OnRender method.
        /// </summary>
        /// <param name="dc">DrawingContext</param>
        /// <param name="renderSize">Size</param>
        public Void OnRender(DrawingContext dc, Size renderSize);
        /// <summary>
        /// Format method.
        /// </summary>
        /// <param name="value">Double</param>
        /// <returns>String</returns>
        public String Format(Double value);
        #endregion
    }
}
