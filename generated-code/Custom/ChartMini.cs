[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.MarketAnalyzerColumns
{
    public partial class ChartMini : MarketAnalyzerColumnRenderBase
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Color.
        /// </summary>
        [DataMember]
        public Brush Color { get; set; }
        /// <summary>
        /// Gets or sets the Opacity.
        /// </summary>
        [DataMember]
        public Int32 Opacity { get; set; }
        /// <summary>
        /// Gets or sets the OutlineBrush.
        /// </summary>
        [DataMember]
        public Brush OutlineBrush { get; set; }
        /// <summary>
        /// Gets or sets the OutlineBrushSeralizer.
        /// </summary>
        [DataMember]
        public String OutlineBrushSeralizer { get; set; }
        /// <summary>
        /// Gets or sets the Span.
        /// </summary>
        [DataMember]
        public ChartSpan Span { get; set; }
        /// <summary>
        /// Gets or sets the UpBrushSeralizer.
        /// </summary>
        [DataMember]
        public String UpBrushSeralizer { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Format method.
        /// </summary>
        /// <param name="value">Double</param>
        /// <returns>String</returns>
        public String Format(Double value);
        /// <summary>
        /// OnRender method.
        /// </summary>
        /// <param name="dc">DrawingContext</param>
        /// <param name="renderSize">Size</param>
        public Void OnRender(DrawingContext dc, Size renderSize);
        #endregion
    }
}
