[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.DrawingTools
{
    public partial class OrderFlowVolumeProfile : DrawingTool, IVolumeProfilePropertiesProvider
    {
        #region Properties
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
        /// <summary>
        /// Gets or sets the StartAnchor.
        /// </summary>
        [DataMember]
        public ChartAnchor StartAnchor { get; set; }
        /// <summary>
        /// Gets or sets the EndAnchor.
        /// </summary>
        [DataMember]
        public ChartAnchor EndAnchor { get; set; }
        /// <summary>
        /// Gets or sets the SupportsAlerts.
        /// </summary>
        [DataMember]
        public Boolean SupportsAlerts { get; set; }
        /// <summary>
        /// Gets or sets the ColorAsk.
        /// </summary>
        [DataMember]
        public Brush ColorAsk { get; set; }
        /// <summary>
        /// Gets or sets the ColorAskSerialize.
        /// </summary>
        [DataMember]
        public String ColorAskSerialize { get; set; }
        /// <summary>
        /// Gets or sets the ColorBid.
        /// </summary>
        [DataMember]
        public Brush ColorBid { get; set; }
        /// <summary>
        /// Gets or sets the ColorBidSerialize.
        /// </summary>
        [DataMember]
        public String ColorBidSerialize { get; set; }
        /// <summary>
        /// Gets or sets the ColorBarOutline.
        /// </summary>
        [DataMember]
        public Brush ColorBarOutline { get; set; }
        /// <summary>
        /// Gets or sets the ColorBarOutlineSerialize.
        /// </summary>
        [DataMember]
        public String ColorBarOutlineSerialize { get; set; }
        /// <summary>
        /// Gets or sets the DeltaType.
        /// </summary>
        [DataMember]
        public VolumetricDeltaType DeltaType { get; set; }
        /// <summary>
        /// Gets or sets the ColorByTime.
        /// </summary>
        [DataMember]
        public Boolean ColorByTime { get; set; }
        /// <summary>
        /// Gets or sets the ColorHighHeat.
        /// </summary>
        [DataMember]
        public Brush ColorHighHeat { get; set; }
        /// <summary>
        /// Gets or sets the ColorHighHeatSerialize.
        /// </summary>
        [DataMember]
        public String ColorHighHeatSerialize { get; set; }
        /// <summary>
        /// Gets or sets the ColorLowHeat.
        /// </summary>
        [DataMember]
        public Brush ColorLowHeat { get; set; }
        /// <summary>
        /// Gets or sets the ColorLowHeatSerialize.
        /// </summary>
        [DataMember]
        public String ColorLowHeatSerialize { get; set; }
        /// <summary>
        /// Gets or sets the ColorPoc.
        /// </summary>
        [DataMember]
        public Brush ColorPoc { get; set; }
        /// <summary>
        /// Gets or sets the ColorPocSerialize.
        /// </summary>
        [DataMember]
        public String ColorPocSerialize { get; set; }
        /// <summary>
        /// Gets or sets the ColorProfileSummary.
        /// </summary>
        [DataMember]
        public Brush ColorProfileSummary { get; set; }
        /// <summary>
        /// Gets or sets the ColorProfileSummarySerialize.
        /// </summary>
        [DataMember]
        public String ColorProfileSummarySerialize { get; set; }
        /// <summary>
        /// Gets or sets the ColorVolumeData.
        /// </summary>
        [DataMember]
        public Brush ColorVolumeData { get; set; }
        /// <summary>
        /// Gets or sets the ColorVolumeDataSerialize.
        /// </summary>
        [DataMember]
        public String ColorVolumeDataSerialize { get; set; }
        /// <summary>
        /// Gets or sets the InitialPocLine.
        /// </summary>
        [DataMember]
        public LabeledGridLine InitialPocLine { get; set; }
        /// <summary>
        /// Gets or sets the InitialVaLine.
        /// </summary>
        [DataMember]
        public LabeledGridLine InitialVaLine { get; set; }
        /// <summary>
        /// Gets or sets the InitialRangeLine.
        /// </summary>
        [DataMember]
        public LabeledGridLine InitialRangeLine { get; set; }
        /// <summary>
        /// Gets or sets the InitialBalanceMinutes.
        /// </summary>
        [DataMember]
        public Int32 InitialBalanceMinutes { get; set; }
        /// <summary>
        /// Gets or sets the DisplayMode.
        /// </summary>
        [DataMember]
        public MarketProfileDisplayMode DisplayMode { get; set; }
        /// <summary>
        /// Gets or sets the DrawMode.
        /// </summary>
        [DataMember]
        public MarketProfilePriceDrawMode DrawMode { get; set; }
        /// <summary>
        /// Gets or sets the Instrument.
        /// </summary>
        [DataMember]
        public Instrument Instrument { get; set; }
        /// <summary>
        /// Gets or sets the LabelFont.
        /// </summary>
        [DataMember]
        public SimpleFont LabelFont { get; set; }
        /// <summary>
        /// Gets or sets the PocLine.
        /// </summary>
        [DataMember]
        public LabeledGridLine PocLine { get; set; }
        /// <summary>
        /// Gets or sets the ProfileAlignment.
        /// </summary>
        [DataMember]
        public MarketProfileAlignment ProfileAlignment { get; set; }
        /// <summary>
        /// Gets or sets the ProfileOpacity.
        /// </summary>
        [DataMember]
        public Int32 ProfileOpacity { get; set; }
        /// <summary>
        /// Gets or sets the ProfileType.
        /// </summary>
        [DataMember]
        public MarketProfileType ProfileType { get; set; }
        /// <summary>
        /// Gets or sets the RangeLine.
        /// </summary>
        [DataMember]
        public LabeledGridLine RangeLine { get; set; }
        /// <summary>
        /// Gets or sets the ShowPoc.
        /// </summary>
        [DataMember]
        public Boolean ShowPoc { get; set; }
        /// <summary>
        /// Gets or sets the ShowVa.
        /// </summary>
        [DataMember]
        public Boolean ShowVa { get; set; }
        /// <summary>
        /// Gets or sets the ShowVolumeData.
        /// </summary>
        [DataMember]
        public Boolean ShowVolumeData { get; set; }
        /// <summary>
        /// Gets or sets the ShowProfileSummary.
        /// </summary>
        [DataMember]
        public Boolean ShowProfileSummary { get; set; }
        /// <summary>
        /// Gets or sets the SummaryDisplayUnit.
        /// </summary>
        [DataMember]
        public ValueUnit SummaryDisplayUnit { get; set; }
        /// <summary>
        /// Gets or sets the TicksPerLevel.
        /// </summary>
        [DataMember]
        public Int32 TicksPerLevel { get; set; }
        /// <summary>
        /// Gets or sets the VaLine.
        /// </summary>
        [DataMember]
        public LabeledGridLine VaLine { get; set; }
        /// <summary>
        /// Gets or sets the AnchorLineStroke.
        /// </summary>
        [DataMember]
        public Stroke AnchorLineStroke { get; set; }
        /// <summary>
        /// Gets or sets the Resolution.
        /// </summary>
        [DataMember]
        public MarketProfileResolution Resolution { get; set; }
        /// <summary>
        /// Gets or sets the ValueArea.
        /// </summary>
        [DataMember]
        public Int32 ValueArea { get; set; }
        /// <summary>
        /// Gets or sets the ValueAreaOpacity.
        /// </summary>
        [DataMember]
        public Int32 ValueAreaOpacity { get; set; }
        /// <summary>
        /// Gets or sets the TpoColorA0000.
        /// </summary>
        [DataMember]
        public Brush TpoColorA0000 { get; set; }
        /// <summary>
        /// Gets or sets the TpoColorB0030.
        /// </summary>
        [DataMember]
        public Brush TpoColorB0030 { get; set; }
        /// <summary>
        /// Gets or sets the TpoColorD0060.
        /// </summary>
        [DataMember]
        public Brush TpoColorD0060 { get; set; }
        /// <summary>
        /// Gets or sets the TpoColorE0090.
        /// </summary>
        [DataMember]
        public Brush TpoColorE0090 { get; set; }
        /// <summary>
        /// Gets or sets the TpoColorF0120.
        /// </summary>
        [DataMember]
        public Brush TpoColorF0120 { get; set; }
        /// <summary>
        /// Gets or sets the TpoColorG0150.
        /// </summary>
        [DataMember]
        public Brush TpoColorG0150 { get; set; }
        /// <summary>
        /// Gets or sets the TpoColorH0180.
        /// </summary>
        [DataMember]
        public Brush TpoColorH0180 { get; set; }
        /// <summary>
        /// Gets or sets the TpoColorI0210.
        /// </summary>
        [DataMember]
        public Brush TpoColorI0210 { get; set; }
        /// <summary>
        /// Gets or sets the TpoColorJ0240.
        /// </summary>
        [DataMember]
        public Brush TpoColorJ0240 { get; set; }
        /// <summary>
        /// Gets or sets the TpoColorK0270.
        /// </summary>
        [DataMember]
        public Brush TpoColorK0270 { get; set; }
        /// <summary>
        /// Gets or sets the TpoColorL0300.
        /// </summary>
        [DataMember]
        public Brush TpoColorL0300 { get; set; }
        /// <summary>
        /// Gets or sets the TpoColorM0330.
        /// </summary>
        [DataMember]
        public Brush TpoColorM0330 { get; set; }
        /// <summary>
        /// Gets or sets the TpoColorN0360.
        /// </summary>
        [DataMember]
        public Brush TpoColorN0360 { get; set; }
        /// <summary>
        /// Gets or sets the TpoColorP0390.
        /// </summary>
        [DataMember]
        public Brush TpoColorP0390 { get; set; }
        /// <summary>
        /// Gets or sets the TpoColorQ0420.
        /// </summary>
        [DataMember]
        public Brush TpoColorQ0420 { get; set; }
        /// <summary>
        /// Gets or sets the TpoColorR0450.
        /// </summary>
        [DataMember]
        public Brush TpoColorR0450 { get; set; }
        /// <summary>
        /// Gets or sets the TpoColorS0480.
        /// </summary>
        [DataMember]
        public Brush TpoColorS0480 { get; set; }
        /// <summary>
        /// Gets or sets the TpoColorT0510.
        /// </summary>
        [DataMember]
        public Brush TpoColorT0510 { get; set; }
        /// <summary>
        /// Gets or sets the TpoColorU0540.
        /// </summary>
        [DataMember]
        public Brush TpoColorU0540 { get; set; }
        /// <summary>
        /// Gets or sets the TpoColorV0570.
        /// </summary>
        [DataMember]
        public Brush TpoColorV0570 { get; set; }
        /// <summary>
        /// Gets or sets the TpoColorW0600.
        /// </summary>
        [DataMember]
        public Brush TpoColorW0600 { get; set; }
        /// <summary>
        /// Gets or sets the TpoColorX0630.
        /// </summary>
        [DataMember]
        public Brush TpoColorX0630 { get; set; }
        /// <summary>
        /// Gets or sets the TpoColorY0660.
        /// </summary>
        [DataMember]
        public Brush TpoColorY0660 { get; set; }
        /// <summary>
        /// Gets or sets the TpoColorZ0690.
        /// </summary>
        [DataMember]
        public Brush TpoColorZ0690 { get; set; }
        /// <summary>
        /// Gets or sets the TpoColora0720.
        /// </summary>
        [DataMember]
        public Brush TpoColora0720 { get; set; }
        /// <summary>
        /// Gets or sets the TpoColorb0750.
        /// </summary>
        [DataMember]
        public Brush TpoColorb0750 { get; set; }
        /// <summary>
        /// Gets or sets the TpoColord0780.
        /// </summary>
        [DataMember]
        public Brush TpoColord0780 { get; set; }
        /// <summary>
        /// Gets or sets the TpoColore0810.
        /// </summary>
        [DataMember]
        public Brush TpoColore0810 { get; set; }
        /// <summary>
        /// Gets or sets the TpoColorf0840.
        /// </summary>
        [DataMember]
        public Brush TpoColorf0840 { get; set; }
        /// <summary>
        /// Gets or sets the TpoColorg0870.
        /// </summary>
        [DataMember]
        public Brush TpoColorg0870 { get; set; }
        /// <summary>
        /// Gets or sets the TpoColorh0900.
        /// </summary>
        [DataMember]
        public Brush TpoColorh0900 { get; set; }
        /// <summary>
        /// Gets or sets the TpoColori0930.
        /// </summary>
        [DataMember]
        public Brush TpoColori0930 { get; set; }
        /// <summary>
        /// Gets or sets the TpoColorj0960.
        /// </summary>
        [DataMember]
        public Brush TpoColorj0960 { get; set; }
        /// <summary>
        /// Gets or sets the TpoColork0990.
        /// </summary>
        [DataMember]
        public Brush TpoColork0990 { get; set; }
        /// <summary>
        /// Gets or sets the TpoColorl1020.
        /// </summary>
        [DataMember]
        public Brush TpoColorl1020 { get; set; }
        /// <summary>
        /// Gets or sets the TpoColorm1050.
        /// </summary>
        [DataMember]
        public Brush TpoColorm1050 { get; set; }
        /// <summary>
        /// Gets or sets the TpoColorn1080.
        /// </summary>
        [DataMember]
        public Brush TpoColorn1080 { get; set; }
        /// <summary>
        /// Gets or sets the TpoColorp1110.
        /// </summary>
        [DataMember]
        public Brush TpoColorp1110 { get; set; }
        /// <summary>
        /// Gets or sets the TpoColorq1140.
        /// </summary>
        [DataMember]
        public Brush TpoColorq1140 { get; set; }
        /// <summary>
        /// Gets or sets the TpoColorr1170.
        /// </summary>
        [DataMember]
        public Brush TpoColorr1170 { get; set; }
        /// <summary>
        /// Gets or sets the TpoColors1200.
        /// </summary>
        [DataMember]
        public Brush TpoColors1200 { get; set; }
        /// <summary>
        /// Gets or sets the TpoColort1230.
        /// </summary>
        [DataMember]
        public Brush TpoColort1230 { get; set; }
        /// <summary>
        /// Gets or sets the TpoColoru1260.
        /// </summary>
        [DataMember]
        public Brush TpoColoru1260 { get; set; }
        /// <summary>
        /// Gets or sets the TpoColorv1290.
        /// </summary>
        [DataMember]
        public Brush TpoColorv1290 { get; set; }
        /// <summary>
        /// Gets or sets the TpoColorw1320.
        /// </summary>
        [DataMember]
        public Brush TpoColorw1320 { get; set; }
        /// <summary>
        /// Gets or sets the TpoColorx1350.
        /// </summary>
        [DataMember]
        public Brush TpoColorx1350 { get; set; }
        /// <summary>
        /// Gets or sets the TpoColory1380.
        /// </summary>
        [DataMember]
        public Brush TpoColory1380 { get; set; }
        /// <summary>
        /// Gets or sets the TpoColorz1410.
        /// </summary>
        [DataMember]
        public Brush TpoColorz1410 { get; set; }
        /// <summary>
        /// Gets or sets the TpoColors.
        /// </summary>
        [DataMember]
        public Brush[] TpoColors { get; set; }
        /// <summary>
        /// Gets or sets the Tpo01.
        /// </summary>
        [DataMember]
        public String Tpo01 { get; set; }
        /// <summary>
        /// Gets or sets the Tpo02.
        /// </summary>
        [DataMember]
        public String Tpo02 { get; set; }
        /// <summary>
        /// Gets or sets the Tpo03.
        /// </summary>
        [DataMember]
        public String Tpo03 { get; set; }
        /// <summary>
        /// Gets or sets the Tpo04.
        /// </summary>
        [DataMember]
        public String Tpo04 { get; set; }
        /// <summary>
        /// Gets or sets the Tpo05.
        /// </summary>
        [DataMember]
        public String Tpo05 { get; set; }
        /// <summary>
        /// Gets or sets the Tpo06.
        /// </summary>
        [DataMember]
        public String Tpo06 { get; set; }
        /// <summary>
        /// Gets or sets the Tpo07.
        /// </summary>
        [DataMember]
        public String Tpo07 { get; set; }
        /// <summary>
        /// Gets or sets the Tpo08.
        /// </summary>
        [DataMember]
        public String Tpo08 { get; set; }
        /// <summary>
        /// Gets or sets the Tpo09.
        /// </summary>
        [DataMember]
        public String Tpo09 { get; set; }
        /// <summary>
        /// Gets or sets the Tpo10.
        /// </summary>
        [DataMember]
        public String Tpo10 { get; set; }
        /// <summary>
        /// Gets or sets the Tpo11.
        /// </summary>
        [DataMember]
        public String Tpo11 { get; set; }
        /// <summary>
        /// Gets or sets the Tpo12.
        /// </summary>
        [DataMember]
        public String Tpo12 { get; set; }
        /// <summary>
        /// Gets or sets the Tpo13.
        /// </summary>
        [DataMember]
        public String Tpo13 { get; set; }
        /// <summary>
        /// Gets or sets the Tpo14.
        /// </summary>
        [DataMember]
        public String Tpo14 { get; set; }
        /// <summary>
        /// Gets or sets the Tpo15.
        /// </summary>
        [DataMember]
        public String Tpo15 { get; set; }
        /// <summary>
        /// Gets or sets the Tpo16.
        /// </summary>
        [DataMember]
        public String Tpo16 { get; set; }
        /// <summary>
        /// Gets or sets the Tpo17.
        /// </summary>
        [DataMember]
        public String Tpo17 { get; set; }
        /// <summary>
        /// Gets or sets the Tpo18.
        /// </summary>
        [DataMember]
        public String Tpo18 { get; set; }
        /// <summary>
        /// Gets or sets the Tpo19.
        /// </summary>
        [DataMember]
        public String Tpo19 { get; set; }
        /// <summary>
        /// Gets or sets the Tpo20.
        /// </summary>
        [DataMember]
        public String Tpo20 { get; set; }
        /// <summary>
        /// Gets or sets the Tpo21.
        /// </summary>
        [DataMember]
        public String Tpo21 { get; set; }
        /// <summary>
        /// Gets or sets the Tpo22.
        /// </summary>
        [DataMember]
        public String Tpo22 { get; set; }
        /// <summary>
        /// Gets or sets the Tpo23.
        /// </summary>
        [DataMember]
        public String Tpo23 { get; set; }
        /// <summary>
        /// Gets or sets the Tpo24.
        /// </summary>
        [DataMember]
        public String Tpo24 { get; set; }
        /// <summary>
        /// Gets or sets the Tpo25.
        /// </summary>
        [DataMember]
        public String Tpo25 { get; set; }
        /// <summary>
        /// Gets or sets the Tpo26.
        /// </summary>
        [DataMember]
        public String Tpo26 { get; set; }
        /// <summary>
        /// Gets or sets the Tpo27.
        /// </summary>
        [DataMember]
        public String Tpo27 { get; set; }
        /// <summary>
        /// Gets or sets the Tpo28.
        /// </summary>
        [DataMember]
        public String Tpo28 { get; set; }
        /// <summary>
        /// Gets or sets the Tpo29.
        /// </summary>
        [DataMember]
        public String Tpo29 { get; set; }
        /// <summary>
        /// Gets or sets the Tpo30.
        /// </summary>
        [DataMember]
        public String Tpo30 { get; set; }
        /// <summary>
        /// Gets or sets the Tpo31.
        /// </summary>
        [DataMember]
        public String Tpo31 { get; set; }
        /// <summary>
        /// Gets or sets the Tpo32.
        /// </summary>
        [DataMember]
        public String Tpo32 { get; set; }
        /// <summary>
        /// Gets or sets the Tpo33.
        /// </summary>
        [DataMember]
        public String Tpo33 { get; set; }
        /// <summary>
        /// Gets or sets the Tpo34.
        /// </summary>
        [DataMember]
        public String Tpo34 { get; set; }
        /// <summary>
        /// Gets or sets the Tpo35.
        /// </summary>
        [DataMember]
        public String Tpo35 { get; set; }
        /// <summary>
        /// Gets or sets the Tpo36.
        /// </summary>
        [DataMember]
        public String Tpo36 { get; set; }
        /// <summary>
        /// Gets or sets the Tpo37.
        /// </summary>
        [DataMember]
        public String Tpo37 { get; set; }
        /// <summary>
        /// Gets or sets the Tpo38.
        /// </summary>
        [DataMember]
        public String Tpo38 { get; set; }
        /// <summary>
        /// Gets or sets the Tpo39.
        /// </summary>
        [DataMember]
        public String Tpo39 { get; set; }
        /// <summary>
        /// Gets or sets the Tpo40.
        /// </summary>
        [DataMember]
        public String Tpo40 { get; set; }
        /// <summary>
        /// Gets or sets the Tpo41.
        /// </summary>
        [DataMember]
        public String Tpo41 { get; set; }
        /// <summary>
        /// Gets or sets the Tpo42.
        /// </summary>
        [DataMember]
        public String Tpo42 { get; set; }
        /// <summary>
        /// Gets or sets the Tpo43.
        /// </summary>
        [DataMember]
        public String Tpo43 { get; set; }
        /// <summary>
        /// Gets or sets the Tpo44.
        /// </summary>
        [DataMember]
        public String Tpo44 { get; set; }
        /// <summary>
        /// Gets or sets the Tpo45.
        /// </summary>
        [DataMember]
        public String Tpo45 { get; set; }
        /// <summary>
        /// Gets or sets the Tpo46.
        /// </summary>
        [DataMember]
        public String Tpo46 { get; set; }
        /// <summary>
        /// Gets or sets the Tpo47.
        /// </summary>
        [DataMember]
        public String Tpo47 { get; set; }
        /// <summary>
        /// Gets or sets the Tpo48.
        /// </summary>
        [DataMember]
        public String Tpo48 { get; set; }
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
        #endregion
    }
}
