[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.DrawingTools
{
    public partial class RegressionChannel : DrawingTool
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Anchors.
        /// </summary>
        [DataMember]
        public IEnumerable<ChartAnchor> Anchors { get; set; }
        /// <summary>
        /// Gets or sets the ChannelType.
        /// </summary>
        [DataMember]
        public RegressionChannelType ChannelType { get; set; }
        /// <summary>
        /// Gets or sets the ExtendLeft.
        /// </summary>
        [DataMember]
        public Boolean ExtendLeft { get; set; }
        /// <summary>
        /// Gets or sets the ExtendRight.
        /// </summary>
        [DataMember]
        public Boolean ExtendRight { get; set; }
        /// <summary>
        /// Gets or sets the EndAnchor.
        /// </summary>
        [DataMember]
        public ChartAnchor EndAnchor { get; set; }
        /// <summary>
        /// Gets or sets the Icon.
        /// </summary>
        [DataMember]
        public Object Icon { get; set; }
        /// <summary>
        /// Gets or sets the LowerChannelStroke.
        /// </summary>
        [DataMember]
        public Stroke LowerChannelStroke { get; set; }
        /// <summary>
        /// Gets or sets the RegressionStroke.
        /// </summary>
        [DataMember]
        public Stroke RegressionStroke { get; set; }
        /// <summary>
        /// Gets or sets the PriceType.
        /// </summary>
        [DataMember]
        public PriceType PriceType { get; set; }
        /// <summary>
        /// Gets or sets the StandardDeviationUpperDistance.
        /// </summary>
        [DataMember]
        public Double StandardDeviationUpperDistance { get; set; }
        /// <summary>
        /// Gets or sets the StandardDeviationLowerDistance.
        /// </summary>
        [DataMember]
        public Double StandardDeviationLowerDistance { get; set; }
        /// <summary>
        /// Gets or sets the StartAnchor.
        /// </summary>
        [DataMember]
        public ChartAnchor StartAnchor { get; set; }
        /// <summary>
        /// Gets or sets the SupportsAlerts.
        /// </summary>
        [DataMember]
        public Boolean SupportsAlerts { get; set; }
        /// <summary>
        /// Gets or sets the UpperChannelStroke.
        /// </summary>
        [DataMember]
        public Stroke UpperChannelStroke { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// AddPastedOffset method.
        /// </summary>
        /// <param name="panel">ChartPanel</param>
        /// <param name="chartScale">ChartScale</param>
        public Void AddPastedOffset(ChartPanel panel, ChartScale chartScale);
        /// <summary>
        /// CalculateRegressionPriceValues method.
        /// </summary>
        /// <param name="baseBars">Bars</param>
        /// <param name="startIndex">Int32</param>
        /// <param name="endIndex">Int32</param>
        /// <returns>Double[]</returns>
        public Double[] CalculateRegressionPriceValues(Bars baseBars, Int32 startIndex, Int32 endIndex);
        /// <summary>
        /// GetBarPrice method.
        /// </summary>
        /// <param name="barObject">Bars</param>
        /// <param name="barIndex">Int32</param>
        /// <returns>Double</returns>
        public Double GetBarPrice(Bars barObject, Int32 barIndex);
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
        /// OnBarsChanged method.
        /// </summary>
        public Void OnBarsChanged();
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
