[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.DrawingTools
{
    public partial class Text : DrawingTool
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Icon.
        /// </summary>
        [DataMember]
        public Object Icon { get; set; }
        /// <summary>
        /// Gets or sets the Alignment.
        /// </summary>
        [DataMember]
        public TextAlignment Alignment { get; set; }
        /// <summary>
        /// Gets or sets the UseChartTextBrush.
        /// </summary>
        [DataMember]
        public Boolean UseChartTextBrush { get; set; }
        /// <summary>
        /// Gets or sets the UseChartTextBrushSerialize.
        /// </summary>
        [DataMember]
        public Boolean UseChartTextBrushSerialize { get; set; }
        /// <summary>
        /// Gets or sets the ManuallyDrawn.
        /// </summary>
        [DataMember]
        public Boolean ManuallyDrawn { get; set; }
        /// <summary>
        /// Gets or sets the LastBrush.
        /// </summary>
        [DataMember]
        public Brush LastBrush { get; set; }
        /// <summary>
        /// Gets or sets the Anchor.
        /// </summary>
        [DataMember]
        public ChartAnchor Anchor { get; set; }
        /// <summary>
        /// Gets or sets the Anchors.
        /// </summary>
        [DataMember]
        public IEnumerable<ChartAnchor> Anchors { get; set; }
        /// <summary>
        /// Gets or sets the AreaBrush.
        /// </summary>
        [DataMember]
        public Brush AreaBrush { get; set; }
        /// <summary>
        /// Gets or sets the AreaBrushSerialize.
        /// </summary>
        [DataMember]
        public String AreaBrushSerialize { get; set; }
        /// <summary>
        /// Gets or sets the AreaOpacity.
        /// </summary>
        [DataMember]
        public Int32 AreaOpacity { get; set; }
        /// <summary>
        /// Gets or sets the Font.
        /// </summary>
        [DataMember]
        public SimpleFont Font { get; set; }
        /// <summary>
        /// Gets or sets the OutlineStroke.
        /// </summary>
        [DataMember]
        public Stroke OutlineStroke { get; set; }
        /// <summary>
        /// Gets or sets the DisplayText.
        /// </summary>
        [DataMember]
        public String DisplayText { get; set; }
        /// <summary>
        /// Gets or sets the TextBrush.
        /// </summary>
        [DataMember]
        public Brush TextBrush { get; set; }
        /// <summary>
        /// Gets or sets the TextBrushSerialize.
        /// </summary>
        [DataMember]
        public String TextBrushSerialize { get; set; }
        /// <summary>
        /// Gets or sets the YPixelOffset.
        /// </summary>
        [DataMember]
        public Int32 YPixelOffset { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// GetCursor method.
        /// </summary>
        /// <param name="chartControl">ChartControl</param>
        /// <param name="chartPanel">ChartPanel</param>
        /// <param name="chartScale">ChartScale</param>
        /// <param name="point">Point</param>
        /// <returns>Cursor</returns>
        public Cursor GetCursor(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, Point point);
        /// <summary>
        /// GetSelectionPoints method.
        /// </summary>
        /// <param name="chartControl">ChartControl</param>
        /// <param name="chartScale">ChartScale</param>
        /// <returns>Point[]</returns>
        public Point[] GetSelectionPoints(ChartControl chartControl, ChartScale chartScale);
        /// <summary>
        /// IsVisibleOnChart method.
        /// </summary>
        /// <param name="chartControl">ChartControl</param>
        /// <param name="chartScale">ChartScale</param>
        /// <param name="firstTimeOnChart">DateTime</param>
        /// <param name="lastTimeOnChart">DateTime</param>
        /// <returns>Boolean</returns>
        public Boolean IsVisibleOnChart(ChartControl chartControl, ChartScale chartScale, DateTime firstTimeOnChart, DateTime lastTimeOnChart);
        /// <summary>
        /// OnCalculateMinMax method.
        /// </summary>
        public Void OnCalculateMinMax();
        /// <summary>
        /// OnMouseDown method.
        /// </summary>
        /// <param name="chartControl">ChartControl</param>
        /// <param name="chartPanel">ChartPanel</param>
        /// <param name="chartScale">ChartScale</param>
        /// <param name="dataPoint">ChartAnchor</param>
        public Void OnMouseDown(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, ChartAnchor dataPoint);
        /// <summary>
        /// OnMouseMove method.
        /// </summary>
        /// <param name="chartControl">ChartControl</param>
        /// <param name="chartPanel">ChartPanel</param>
        /// <param name="chartScale">ChartScale</param>
        /// <param name="dataPoint">ChartAnchor</param>
        public Void OnMouseMove(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, ChartAnchor dataPoint);
        /// <summary>
        /// OnMouseUp method.
        /// </summary>
        /// <param name="chartControl">ChartControl</param>
        /// <param name="chartPanel">ChartPanel</param>
        /// <param name="chartScale">ChartScale</param>
        /// <param name="dataPoint">ChartAnchor</param>
        public Void OnMouseUp(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, ChartAnchor dataPoint);
        /// <summary>
        /// OnRender method.
        /// </summary>
        /// <param name="chartControl">ChartControl</param>
        /// <param name="chartScale">ChartScale</param>
        public Void OnRender(ChartControl chartControl, ChartScale chartScale);
        #endregion
    }
}
