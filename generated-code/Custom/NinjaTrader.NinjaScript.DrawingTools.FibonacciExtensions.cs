[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.DrawingTools
{
    public partial class FibonacciExtensions : FibonacciRetracements
    {
        #region Properties
        /// <summary>
        /// Gets or sets the ExtensionAnchor.
        /// </summary>
        [DataMember]
        public ChartAnchor ExtensionAnchor { get; set; }
        /// <summary>
        /// Gets or sets the Anchors.
        /// </summary>
        [DataMember]
        public IEnumerable<ChartAnchor> Anchors { get; set; }
        /// <summary>
        /// Gets or sets the Icon.
        /// </summary>
        [DataMember]
        public Object Icon { get; set; }
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
        /// OnRender method.
        /// </summary>
        /// <param name="chartControl">ChartControl</param>
        /// <param name="chartScale">ChartScale</param>
        public Void OnRender(ChartControl chartControl, ChartScale chartScale);
        #endregion
    }
}
