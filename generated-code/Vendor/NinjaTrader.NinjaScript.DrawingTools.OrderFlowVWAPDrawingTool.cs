[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.DrawingTools
{
    public partial class OrderFlowVWAPDrawingTool : DrawingTool
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Icon.
        /// </summary>
        [DataMember]
        public Object Icon { get; set; }
        /// <summary>
        /// Gets or sets the Anchors.
        /// </summary>
        [DataMember]
        public IEnumerable<ChartAnchor> Anchors { get; set; }
        /// <summary>
        /// Gets or sets the StartAnchor.
        /// </summary>
        [DataMember]
        public ChartAnchor StartAnchor { get; set; }
        /// <summary>
        /// Gets or sets the StartTimeParam.
        /// </summary>
        [DataMember]
        public DateTime StartTimeParam { get; set; }
        /// <summary>
        /// Gets or sets the EndAnchor.
        /// </summary>
        [DataMember]
        public ChartAnchor EndAnchor { get; set; }
        /// <summary>
        /// Gets or sets the EndTimeParam.
        /// </summary>
        [DataMember]
        public DateTime EndTimeParam { get; set; }
        /// <summary>
        /// Gets or sets the SupportsAlerts.
        /// </summary>
        [DataMember]
        public Boolean SupportsAlerts { get; set; }
        /// <summary>
        /// Gets or sets the Instrument.
        /// </summary>
        [DataMember]
        public Instrument Instrument { get; set; }
        /// <summary>
        /// Gets or sets the Resolution.
        /// </summary>
        [DataMember]
        public VWAPResolution Resolution { get; set; }
        /// <summary>
        /// Gets or sets the NumStandardDeviations.
        /// </summary>
        [DataMember]
        public VWAPStandardDeviations NumStandardDeviations { get; set; }
        /// <summary>
        /// Gets or sets the SD1Stroke.
        /// </summary>
        [DataMember]
        public Stroke SD1Stroke { get; set; }
        /// <summary>
        /// Gets or sets the SD1Multiplier.
        /// </summary>
        [DataMember]
        public Double SD1Multiplier { get; set; }
        /// <summary>
        /// Gets or sets the BandAreaBrush.
        /// </summary>
        [DataMember]
        public Brush BandAreaBrush { get; set; }
        /// <summary>
        /// Gets or sets the BandAreaBrushSeralizer.
        /// </summary>
        [DataMember]
        public String BandAreaBrushSeralizer { get; set; }
        /// <summary>
        /// Gets or sets the BandAreaOpacity.
        /// </summary>
        [DataMember]
        public Int32 BandAreaOpacity { get; set; }
        /// <summary>
        /// Gets or sets the SD2Stroke.
        /// </summary>
        [DataMember]
        public Stroke SD2Stroke { get; set; }
        /// <summary>
        /// Gets or sets the SD2Multiplier.
        /// </summary>
        [DataMember]
        public Double SD2Multiplier { get; set; }
        /// <summary>
        /// Gets or sets the BandAreaBrush2.
        /// </summary>
        [DataMember]
        public Brush BandAreaBrush2 { get; set; }
        /// <summary>
        /// Gets or sets the BandAreaBrushSeralizer2.
        /// </summary>
        [DataMember]
        public String BandAreaBrushSeralizer2 { get; set; }
        /// <summary>
        /// Gets or sets the BandAreaOpacity2.
        /// </summary>
        [DataMember]
        public Int32 BandAreaOpacity2 { get; set; }
        /// <summary>
        /// Gets or sets the SD3Stroke.
        /// </summary>
        [DataMember]
        public Stroke SD3Stroke { get; set; }
        /// <summary>
        /// Gets or sets the SD3Multiplier.
        /// </summary>
        [DataMember]
        public Double SD3Multiplier { get; set; }
        /// <summary>
        /// Gets or sets the BandAreaBrush3.
        /// </summary>
        [DataMember]
        public Brush BandAreaBrush3 { get; set; }
        /// <summary>
        /// Gets or sets the BandAreaBrushSeralizer3.
        /// </summary>
        [DataMember]
        public String BandAreaBrushSeralizer3 { get; set; }
        /// <summary>
        /// Gets or sets the BandAreaOpacity3.
        /// </summary>
        [DataMember]
        public Int32 BandAreaOpacity3 { get; set; }
        /// <summary>
        /// Gets or sets the VwapStroke.
        /// </summary>
        [DataMember]
        public Stroke VwapStroke { get; set; }
        /// <summary>
        /// Gets or sets the AbovePriceBrush.
        /// </summary>
        [DataMember]
        public Brush AbovePriceBrush { get; set; }
        /// <summary>
        /// Gets or sets the AbovePriceBrushSeralizer.
        /// </summary>
        [DataMember]
        public String AbovePriceBrushSeralizer { get; set; }
        /// <summary>
        /// Gets or sets the BelowPriceBrush.
        /// </summary>
        [DataMember]
        public Brush BelowPriceBrush { get; set; }
        /// <summary>
        /// Gets or sets the BelowPriceBrushSeralizer.
        /// </summary>
        [DataMember]
        public String BelowPriceBrushSeralizer { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>Object</returns>
        public Object Clone();
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
        /// GetSupportedAttachedToTypes method.
        /// </summary>
        /// <returns>AttachedToType[]</returns>
        public AttachedToType[] GetSupportedAttachedToTypes();
        /// <summary>
        /// GetValidAlertConditions method.
        /// </summary>
        /// <returns>IEnumerable`1</returns>
        public IEnumerable<Condition> GetValidAlertConditions();
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
        /// OnEdited method.
        /// </summary>
        /// <param name="chartControl">ChartControl</param>
        /// <param name="chartPanel">ChartPanel</param>
        /// <param name="chartScale">ChartScale</param>
        /// <param name="oldinstance">DrawingTool</param>
        public Void OnEdited(ChartControl chartControl, ChartPanel chartPanel, ChartScale chartScale, DrawingTool oldinstance);
        #endregion
    }
}
