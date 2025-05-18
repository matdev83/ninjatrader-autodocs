[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.DrawingTools
{
    public partial class RiskReward : DrawingTool
    {
        #region Properties
        /// <summary>
        /// Gets or sets the EntryAnchor.
        /// </summary>
        [DataMember]
        public ChartAnchor EntryAnchor { get; set; }
        /// <summary>
        /// Gets or sets the RiskAnchor.
        /// </summary>
        [DataMember]
        public ChartAnchor RiskAnchor { get; set; }
        /// <summary>
        /// Gets or sets the RewardAnchor.
        /// </summary>
        [DataMember]
        public ChartAnchor RewardAnchor { get; set; }
        /// <summary>
        /// Gets or sets the Icon.
        /// </summary>
        [DataMember]
        public Object Icon { get; set; }
        /// <summary>
        /// Gets or sets the Ratio.
        /// </summary>
        [DataMember]
        public Double Ratio { get; set; }
        /// <summary>
        /// Gets or sets the AnchorLineStroke.
        /// </summary>
        [DataMember]
        public Stroke AnchorLineStroke { get; set; }
        /// <summary>
        /// Gets or sets the EntryLineStroke.
        /// </summary>
        [DataMember]
        public Stroke EntryLineStroke { get; set; }
        /// <summary>
        /// Gets or sets the StopLineStroke.
        /// </summary>
        [DataMember]
        public Stroke StopLineStroke { get; set; }
        /// <summary>
        /// Gets or sets the TargetLineStroke.
        /// </summary>
        [DataMember]
        public Stroke TargetLineStroke { get; set; }
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
        /// Gets or sets the TextAlignment.
        /// </summary>
        [DataMember]
        public TextLocation TextAlignment { get; set; }
        /// <summary>
        /// Gets or sets the DisplayUnit.
        /// </summary>
        [DataMember]
        public ValueUnit DisplayUnit { get; set; }
        /// <summary>
        /// Gets or sets the SupportsAlerts.
        /// </summary>
        [DataMember]
        public Boolean SupportsAlerts { get; set; }
        #endregion
        #region Methods
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
        /// <summary>
        /// SetReward method.
        /// </summary>
        public Void SetReward();
        /// <summary>
        /// SetRisk method.
        /// </summary>
        public Void SetRisk();
        #endregion
    }
}
