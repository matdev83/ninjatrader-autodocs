[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.MarketAnalyzerColumns
{
    public partial class TSTrend : MarketAnalyzerColumnRenderBase
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AboveAsk.
        /// </summary>
        [DataMember]
        public Brush AboveAsk { get; set; }
        /// <summary>
        /// Gets or sets the AboveAskSeralizer.
        /// </summary>
        [DataMember]
        public String AboveAskSeralizer { get; set; }
        /// <summary>
        /// Gets or sets the AtAsk.
        /// </summary>
        [DataMember]
        public Brush AtAsk { get; set; }
        /// <summary>
        /// Gets or sets the AtAskSeralizer.
        /// </summary>
        [DataMember]
        public String AtAskSeralizer { get; set; }
        /// <summary>
        /// Gets or sets the AtBid.
        /// </summary>
        [DataMember]
        public Brush AtBid { get; set; }
        /// <summary>
        /// Gets or sets the AtBidSeralizer.
        /// </summary>
        [DataMember]
        public String AtBidSeralizer { get; set; }
        /// <summary>
        /// Gets or sets the BarWidth.
        /// </summary>
        [DataMember]
        public Int32 BarWidth { get; set; }
        /// <summary>
        /// Gets or sets the BelowBid.
        /// </summary>
        [DataMember]
        public Brush BelowBid { get; set; }
        /// <summary>
        /// Gets or sets the BelowBidSeralizer.
        /// </summary>
        [DataMember]
        public String BelowBidSeralizer { get; set; }
        /// <summary>
        /// Gets or sets the Between.
        /// </summary>
        [DataMember]
        public Brush Between { get; set; }
        /// <summary>
        /// Gets or sets the BetweenSeralizer.
        /// </summary>
        [DataMember]
        public String BetweenSeralizer { get; set; }
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
