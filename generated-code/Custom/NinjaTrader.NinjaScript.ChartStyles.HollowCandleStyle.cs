[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.ChartStyles
{
    public partial class HollowCandleStyle : ChartStyle
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Icon.
        /// </summary>
        [DataMember]
        public Object Icon { get; set; }
        /// <summary>
        /// Gets or sets the LineWidth.
        /// </summary>
        [DataMember]
        public Int32 LineWidth { get; set; }
        /// <summary>
        /// Gets or sets the DojiBrush.
        /// </summary>
        [DataMember]
        public Brush DojiBrush { get; set; }
        /// <summary>
        /// Gets or sets the DojiBrushDX.
        /// </summary>
        [DataMember]
        public Brush DojiBrushDX { get; set; }
        /// <summary>
        /// Gets or sets the DojiBrushSerialize.
        /// </summary>
        [DataMember]
        public String DojiBrushSerialize { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// GetBarPaintWidth method.
        /// </summary>
        /// <param name="barWidth">Int32</param>
        /// <returns>Int32</returns>
        public Int32 GetBarPaintWidth(Int32 barWidth);
        /// <summary>
        /// OnRender method.
        /// </summary>
        /// <param name="chartControl">ChartControl</param>
        /// <param name="chartScale">ChartScale</param>
        /// <param name="chartBars">ChartBars</param>
        public Void OnRender(ChartControl chartControl, ChartScale chartScale, ChartBars chartBars);
        /// <summary>
        /// OnRenderTargetChanged method.
        /// </summary>
        public Void OnRenderTargetChanged();
        #endregion
    }
}
