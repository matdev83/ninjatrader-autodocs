[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.DrawingTools
{
    public partial class TrendChannel : PriceLevelContainer
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Icon.
        /// </summary>
        [DataMember]
        public Object Icon { get; set; }
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
        /// Gets or sets the Anchors.
        /// </summary>
        [DataMember]
        public IEnumerable<ChartAnchor> Anchors { get; set; }
        /// <summary>
        /// Gets or sets the IsExtendedLinesRight.
        /// </summary>
        [DataMember]
        public Boolean IsExtendedLinesRight { get; set; }
        /// <summary>
        /// Gets or sets the IsExtendedLinesLeft.
        /// </summary>
        [DataMember]
        public Boolean IsExtendedLinesLeft { get; set; }
        /// <summary>
        /// Gets or sets the Stroke.
        /// </summary>
        [DataMember]
        public Stroke Stroke { get; set; }
        /// <summary>
        /// Gets or sets the TrendEndAnchor.
        /// </summary>
        [DataMember]
        public ChartAnchor TrendEndAnchor { get; set; }
        /// <summary>
        /// Gets or sets the TrendStartAnchor.
        /// </summary>
        [DataMember]
        public ChartAnchor TrendStartAnchor { get; set; }
        /// <summary>
        /// Gets or sets the ParallelStartAnchor.
        /// </summary>
        [DataMember]
        public ChartAnchor ParallelStartAnchor { get; set; }
        /// <summary>
        /// Gets or sets the ParallelStroke.
        /// </summary>
        [DataMember]
        public Stroke ParallelStroke { get; set; }
        /// <summary>
        /// Gets or sets the SupportsAlerts.
        /// </summary>
        [DataMember]
        public Boolean SupportsAlerts { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="ninjaScript">NinjaScript</param>
        public Void CopyTo(NinjaScript ninjaScript);
        /// <summary>
        /// GetAlertConditionItems method.
        /// </summary>
        /// <returns>IEnumerable`1</returns>
        public IEnumerable<AlertConditionItem> GetAlertConditionItems();
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
        /// IsAlertConditionTrue method.
        /// </summary>
        /// <param name="conditionItem">AlertConditionItem</param>
        /// <param name="condition">Condition</param>
        /// <param name="values">ChartAlertValue[]</param>
        /// <param name="chartControl">ChartControl</param>
        /// <param name="chartScale">ChartScale</param>
        /// <returns>Boolean</returns>
        public Boolean IsAlertConditionTrue(AlertConditionItem conditionItem, Condition condition, ChartAlertValue[] values, ChartControl chartControl, ChartScale chartScale);
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
        /// OnEdited method.
        /// </summary>
        /// <param name="chartControl">ChartControl</param>
        /// <param name="chartPanel">ChartPanel</param>
        /// <param name="chartScale">ChartScale</param>
        /// <param name="oldinstance">DrawingTool</param>
        public Void OnEdited(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, DrawingTool oldinstance);
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
