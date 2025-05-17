[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.DrawingTools
{
    public partial class ChartMarker : DrawingTool
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Anchor.
        /// </summary>
        [DataMember]
        public ChartAnchor Anchor { get; set; }
        /// <summary>
        /// Gets or sets the AreaBrush.
        /// </summary>
        [DataMember]
        public Brush AreaBrush { get; set; }
        /// <summary>
        /// Gets or sets the Size.
        /// </summary>
        [DataMember]
        public ChartMarkerSize Size { get; set; }
        /// <summary>
        /// Gets or sets the AreaBrushSerialize.
        /// </summary>
        [DataMember]
        public String AreaBrushSerialize { get; set; }
        /// <summary>
        /// Gets or sets the OutlineBrush.
        /// </summary>
        [DataMember]
        public Brush OutlineBrush { get; set; }
        /// <summary>
        /// Gets or sets the OutlineBrushSerialize.
        /// </summary>
        [DataMember]
        public String OutlineBrushSerialize { get; set; }
        /// <summary>
        /// Gets or sets the Anchors.
        /// </summary>
        [DataMember]
        public IEnumerable<ChartAnchor> Anchors { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// OnCalculateMinMax method.
        /// </summary>
        public Void OnCalculateMinMax();
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
        /// <param name="control">ChartControl</param>
        /// <param name="chartPanel">ChartPanel</param>
        /// <param name="chartScale">ChartScale</param>
        /// <param name="dataPoint">ChartAnchor</param>
        public Void OnMouseUp(ChartControl control, ChartPanel chartPanel, ChartScale chartScale, ChartAnchor dataPoint);
        #endregion
    }
}
