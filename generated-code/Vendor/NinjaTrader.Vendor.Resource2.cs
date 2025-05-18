[Serializable]
[DataContract]
namespace NinjaTrader.Vendor
{
    public partial class Resource2
    {
        #region Properties
        /// <summary>
        /// Gets or sets the ResourceManager.
        /// </summary>
        [DataMember]
        public ResourceManager ResourceManager { get; set; }
        /// <summary>
        /// Gets or sets the Culture.
        /// </summary>
        [DataMember]
        public CultureInfo Culture { get; set; }
        /// <summary>
        /// Gets or sets the BaseVolumeRange_ExactVolume.
        /// </summary>
        [DataMember]
        public String BaseVolumeRange_ExactVolume { get; set; }
        /// <summary>
        /// Gets or sets the BaseVolumeRange_Percent.
        /// </summary>
        [DataMember]
        public String BaseVolumeRange_Percent { get; set; }
        /// <summary>
        /// Gets or sets the CumulativeDeltaPeriod_Bar.
        /// </summary>
        [DataMember]
        public String CumulativeDeltaPeriod_Bar { get; set; }
        /// <summary>
        /// Gets or sets the CumulativeDeltaPeriod_Session.
        /// </summary>
        [DataMember]
        public String CumulativeDeltaPeriod_Session { get; set; }
        /// <summary>
        /// Gets or sets the CumulativeDeltaPlotClose.
        /// </summary>
        [DataMember]
        public String CumulativeDeltaPlotClose { get; set; }
        /// <summary>
        /// Gets or sets the CumulativeDeltaPlotHigh.
        /// </summary>
        [DataMember]
        public String CumulativeDeltaPlotHigh { get; set; }
        /// <summary>
        /// Gets or sets the CumulativeDeltaPlotLow.
        /// </summary>
        [DataMember]
        public String CumulativeDeltaPlotLow { get; set; }
        /// <summary>
        /// Gets or sets the CumulativeDeltaPlotOpen.
        /// </summary>
        [DataMember]
        public String CumulativeDeltaPlotOpen { get; set; }
        /// <summary>
        /// Gets or sets the CumulativeDeltaType_BidAsk.
        /// </summary>
        [DataMember]
        public String CumulativeDeltaType_BidAsk { get; set; }
        /// <summary>
        /// Gets or sets the CumulativeDeltaType_UpDownTick.
        /// </summary>
        [DataMember]
        public String CumulativeDeltaType_UpDownTick { get; set; }
        /// <summary>
        /// Gets or sets the CurrentDayOHLError.
        /// </summary>
        [DataMember]
        public String CurrentDayOHLError { get; set; }
        /// <summary>
        /// Gets or sets the CurrentDayOHLHigh.
        /// </summary>
        [DataMember]
        public String CurrentDayOHLHigh { get; set; }
        /// <summary>
        /// Gets or sets the CurrentDayOHLLow.
        /// </summary>
        [DataMember]
        public String CurrentDayOHLLow { get; set; }
        /// <summary>
        /// Gets or sets the CurrentDayOHLOpen.
        /// </summary>
        [DataMember]
        public String CurrentDayOHLOpen { get; set; }
        /// <summary>
        /// Gets or sets the DeltaType.
        /// </summary>
        [DataMember]
        public String DeltaType { get; set; }
        /// <summary>
        /// Gets or sets the Depth.
        /// </summary>
        [DataMember]
        public String Depth { get; set; }
        /// <summary>
        /// Gets or sets the DepthMapDisplayMode_Both.
        /// </summary>
        [DataMember]
        public String DepthMapDisplayMode_Both { get; set; }
        /// <summary>
        /// Gets or sets the DepthMapDisplayMode_Historical.
        /// </summary>
        [DataMember]
        public String DepthMapDisplayMode_Historical { get; set; }
        /// <summary>
        /// Gets or sets the DepthMapDisplayMode_Realtime.
        /// </summary>
        [DataMember]
        public String DepthMapDisplayMode_Realtime { get; set; }
        /// <summary>
        /// Gets or sets the DownBrush.
        /// </summary>
        [DataMember]
        public String DownBrush { get; set; }
        /// <summary>
        /// Gets or sets the FXTileBuyToolTip.
        /// </summary>
        [DataMember]
        public String FXTileBuyToolTip { get; set; }
        /// <summary>
        /// Gets or sets the FXTileInstrumentMatchError.
        /// </summary>
        [DataMember]
        public String FXTileInstrumentMatchError { get; set; }
        /// <summary>
        /// Gets or sets the FXTileInstrumentTypeError.
        /// </summary>
        [DataMember]
        public String FXTileInstrumentTypeError { get; set; }
        /// <summary>
        /// Gets or sets the FXTileSellToolTip.
        /// </summary>
        [DataMember]
        public String FXTileSellToolTip { get; set; }
        /// <summary>
        /// Gets or sets the HLCCalculationModeWoodie_CalcFromIntradayData.
        /// </summary>
        [DataMember]
        public String HLCCalculationModeWoodie_CalcFromIntradayData { get; set; }
        /// <summary>
        /// Gets or sets the HLCCalculationModeWoodie_DailyBars.
        /// </summary>
        [DataMember]
        public String HLCCalculationModeWoodie_DailyBars { get; set; }
        /// <summary>
        /// Gets or sets the HLCCalculationModeWoodie_UserDefinedValues.
        /// </summary>
        [DataMember]
        public String HLCCalculationModeWoodie_UserDefinedValues { get; set; }
        /// <summary>
        /// Gets or sets the JurikCallFailed.
        /// </summary>
        [DataMember]
        public String JurikCallFailed { get; set; }
        /// <summary>
        /// Gets or sets the JurikNotInstalled.
        /// </summary>
        [DataMember]
        public String JurikNotInstalled { get; set; }
        /// <summary>
        /// Gets or sets the LargeVolumeMarkerSizeBase_Session.
        /// </summary>
        [DataMember]
        public String LargeVolumeMarkerSizeBase_Session { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfileAlignment_Left.
        /// </summary>
        [DataMember]
        public String MarketProfileAlignment_Left { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfileAlignment_Right.
        /// </summary>
        [DataMember]
        public String MarketProfileAlignment_Right { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfileComposeBy_Chart.
        /// </summary>
        [DataMember]
        public String MarketProfileComposeBy_Chart { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfileComposeBy_DaysBack.
        /// </summary>
        [DataMember]
        public String MarketProfileComposeBy_DaysBack { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfileComposeBy_MonthsBack.
        /// </summary>
        [DataMember]
        public String MarketProfileComposeBy_MonthsBack { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfileComposeBy_StartDate.
        /// </summary>
        [DataMember]
        public String MarketProfileComposeBy_StartDate { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfileComposeBy_VisibleScreen.
        /// </summary>
        [DataMember]
        public String MarketProfileComposeBy_VisibleScreen { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfileComposeBy_WeeksBack.
        /// </summary>
        [DataMember]
        public String MarketProfileComposeBy_WeeksBack { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfileDisplayMode_BuySell.
        /// </summary>
        [DataMember]
        public String MarketProfileDisplayMode_BuySell { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfileDisplayMode_Delta.
        /// </summary>
        [DataMember]
        public String MarketProfileDisplayMode_Delta { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfileDisplayMode_Heat.
        /// </summary>
        [DataMember]
        public String MarketProfileDisplayMode_Heat { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfileDisplayMode_Outline.
        /// </summary>
        [DataMember]
        public String MarketProfileDisplayMode_Outline { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfileDisplayMode_Standard.
        /// </summary>
        [DataMember]
        public String MarketProfileDisplayMode_Standard { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfileDisplayMode_TimeColor.
        /// </summary>
        [DataMember]
        public String MarketProfileDisplayMode_TimeColor { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfilePeriod_Bars.
        /// </summary>
        [DataMember]
        public String MarketProfilePeriod_Bars { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfilePeriod_Composite.
        /// </summary>
        [DataMember]
        public String MarketProfilePeriod_Composite { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfilePeriod_Minutes.
        /// </summary>
        [DataMember]
        public String MarketProfilePeriod_Minutes { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfilePeriod_Months.
        /// </summary>
        [DataMember]
        public String MarketProfilePeriod_Months { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfilePeriod_Sessions.
        /// </summary>
        [DataMember]
        public String MarketProfilePeriod_Sessions { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfilePeriod_Weeks.
        /// </summary>
        [DataMember]
        public String MarketProfilePeriod_Weeks { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfilePriceDrawMode_Boxes.
        /// </summary>
        [DataMember]
        public String MarketProfilePriceDrawMode_Boxes { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfilePriceDrawMode_Letters.
        /// </summary>
        [DataMember]
        public String MarketProfilePriceDrawMode_Letters { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfileResolution_Minute.
        /// </summary>
        [DataMember]
        public String MarketProfileResolution_Minute { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfileResolution_Tick.
        /// </summary>
        [DataMember]
        public String MarketProfileResolution_Tick { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfileType_Price.
        /// </summary>
        [DataMember]
        public String MarketProfileType_Price { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfileType_Tick.
        /// </summary>
        [DataMember]
        public String MarketProfileType_Tick { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfileType_Volume.
        /// </summary>
        [DataMember]
        public String MarketProfileType_Volume { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsTypeDelta.
        /// </summary>
        [DataMember]
        public String NinjaScriptBarsTypeDelta { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsTypePriceOnVolume.
        /// </summary>
        [DataMember]
        public String NinjaScriptBarsTypePriceOnVolume { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsTypeReversal.
        /// </summary>
        [DataMember]
        public String NinjaScriptBarsTypeReversal { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsTypeTrendDelta.
        /// </summary>
        [DataMember]
        public String NinjaScriptBarsTypeTrendDelta { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsTypeTrendReversal.
        /// </summary>
        [DataMember]
        public String NinjaScriptBarsTypeTrendReversal { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsTypeVolumetric.
        /// </summary>
        [DataMember]
        public String NinjaScriptBarsTypeVolumetric { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleBarWidth.
        /// </summary>
        [DataMember]
        public String NinjaScriptChartStyleBarWidth { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleCandleDownBarsColor.
        /// </summary>
        [DataMember]
        public String NinjaScriptChartStyleCandleDownBarsColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleCandleOutline.
        /// </summary>
        [DataMember]
        public String NinjaScriptChartStyleCandleOutline { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleCandleUpBarsColor.
        /// </summary>
        [DataMember]
        public String NinjaScriptChartStyleCandleUpBarsColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStylePOVCandlestick.
        /// </summary>
        [DataMember]
        public String NinjaScriptChartStylePOVCandlestick { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStylePOVEquivolume.
        /// </summary>
        [DataMember]
        public String NinjaScriptChartStylePOVEquivolume { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleVolumetric.
        /// </summary>
        [DataMember]
        public String NinjaScriptChartStyleVolumetric { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDescriptionPivotRangeType.
        /// </summary>
        [DataMember]
        public String NinjaScriptDescriptionPivotRangeType { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDescriptionPriorDayHLC.
        /// </summary>
        [DataMember]
        public String NinjaScriptDescriptionPriorDayHLC { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDescriptionUserDefinedHigh.
        /// </summary>
        [DataMember]
        public String NinjaScriptDescriptionUserDefinedHigh { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDescriptionUserDefinedLow.
        /// </summary>
        [DataMember]
        public String NinjaScriptDescriptionUserDefinedLow { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDescriptionUserDefinedOpen.
        /// </summary>
        [DataMember]
        public String NinjaScriptDescriptionUserDefinedOpen { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDescriptionWidth.
        /// </summary>
        [DataMember]
        public String NinjaScriptDescriptionWidth { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolAnchor.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolAnchor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolAnchorEnd.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolAnchorEnd { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolAnchorStart.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolAnchorStart { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolAreaOpacity.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolAreaOpacity { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRegion.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolRegion { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolsChartArrowDownMarkerName.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolsChartArrowDownMarkerName { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolsChartArrowUpMarkerName.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolsChartArrowUpMarkerName { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolsChartDiamondMarkerName.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolsChartDiamondMarkerName { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolsChartDotMarkerName.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolsChartDotMarkerName { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolsChartSquareMarkerName.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolsChartSquareMarkerName { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolsChartTriangleDownMarkerName.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolsChartTriangleDownMarkerName { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolsChartTriangleUpMarkerName.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolsChartTriangleUpMarkerName { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolSD1Stroke.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolSD1Stroke { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolSD2Stroke.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolSD2Stroke { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolSD3Stroke.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolSD3Stroke { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolShapesAreaBrush.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolShapesAreaBrush { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolShapesOutlineBrush.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolShapesOutlineBrush { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolText.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolText { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolTextAlignment.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolTextAlignment { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolTextBrush.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolTextBrush { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolTextFixed.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolTextFixed { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolTextFixedTextPosition.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolTextFixedTextPosition { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolTextFont.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolTextFont { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolTextOutlineStroke.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolTextOutlineStroke { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolTextOutlineVisible.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolTextOutlineVisible { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolVwapStroke.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolVwapStroke { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptErrorVWAPAccuracyWarning.
        /// </summary>
        [DataMember]
        public String NinjaScriptErrorVWAPAccuracyWarning { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptErrorVWAPResolution.
        /// </summary>
        [DataMember]
        public String NinjaScriptErrorVWAPResolution { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptErrorWoodiesPivotsHistorical.
        /// </summary>
        [DataMember]
        public String NinjaScriptErrorWoodiesPivotsHistorical { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptErrorWoodiesPivotsInterday.
        /// </summary>
        [DataMember]
        public String NinjaScriptErrorWoodiesPivotsInterday { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptGeneral.
        /// </summary>
        [DataMember]
        public String NinjaScriptGeneral { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorAbovePriceBrush.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorAbovePriceBrush { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorAskBrush.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorAskBrush { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorBandAreaBrush.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorBandAreaBrush { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorBandAreaBrush2.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorBandAreaBrush2 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorBandAreaBrush3.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorBandAreaBrush3 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorBandAreaOpacity.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorBandAreaOpacity { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorBandAreaOpacity2.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorBandAreaOpacity2 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorBandAreaOpacity3.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorBandAreaOpacity3 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorBarColor.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorBarColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorBaseLargeVolumeOn.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorBaseLargeVolumeOn { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorBaseMarkerSizeOn.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorBaseMarkerSizeOn { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorBaseVolumeRangeOn.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorBaseVolumeRangeOn { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorBelowPriceBrush.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorBelowPriceBrush { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorBidBrush.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorBidBrush { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorButtonBackground.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorButtonBackground { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorButtonForeground.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorButtonForeground { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorCalculating.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorCalculating { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorCannotBeDrawnOn.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorCannotBeDrawnOn { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorChopIndicatorWidth.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorChopIndicatorWidth { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorCloseForAsk.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorCloseForAsk { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorCloseForBid.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorCloseForBid { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColorByTime.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorColorByTime { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColorDown.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorColorDown { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColorDownFill.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorColorDownFill { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColorDownOutline.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorColorDownOutline { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColorForAsk.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorColorForAsk { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColorForAskDepth.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorColorForAskDepth { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColorForBid.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorColorForBid { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColorForBitDepth.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorColorForBitDepth { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColorForPoc.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorColorForPoc { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColorHighHeat.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorColorHighHeat { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColorLastNeutralBar.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorColorLastNeutralBar { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColorLowHeat.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorColorLowHeat { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColorNegLsma.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorColorNegLsma { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColorNegValues.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorColorNegValues { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColorNeutralZone.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorColorNeutralZone { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColorPosLsma.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorColorPosLsma { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColorPosValues.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorColorPosValues { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColorProfile.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorColorProfile { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColorProfileSummary.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorColorProfileSummary { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColorSquatFill.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorColorSquatFill { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColorSquatOutline.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorColorSquatOutline { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColorUp.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorColorUp { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColorUpFill.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorColorUpFill { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColorUpOutline.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorColorUpOutline { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColorVolumeData.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorColorVolumeData { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorComposeBy.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorComposeBy { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDataSeriesGroup.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDataSeriesGroup { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDeltaType.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDeltaType { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionCumulativeDelta.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionCumulativeDelta { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionCurrentDayOHL.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionCurrentDayOHL { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionEMA.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionEMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionJurikDMX.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionJurikDMX { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionJurikJMA.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionJurikJMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionJurikRSX.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionJurikRSX { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionJurikVEL.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionJurikVEL { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionLinReg.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionLinReg { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionSMA.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionSMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionSUM.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionSUM { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionSwing.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionSwing { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionTradeDetector.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionTradeDetector { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionVolumeProfile.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionVolumeProfile { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionVWAP.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionVWAP { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionWisemanAlligator.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionWisemanAlligator { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionWisemanAwesomeOscillator.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionWisemanAwesomeOscillator { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionWisemanFractal.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionWisemanFractal { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionWoodiesCCI.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionWoodiesCCI { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionWoodiesPivots.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionWoodiesPivots { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDevPoc.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDevPoc { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDevVa.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDevVa { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDisplayCCIPanel.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDisplayCCIPanel { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDisplayInMargin.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDisplayInMargin { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDisplayMode.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDisplayMode { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDownBrush.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDownBrush { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDowntickBackground.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDowntickBackground { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDowntickForeground.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDowntickForeground { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDrawMode.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDrawMode { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorEnabled.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorEnabled { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorEndTime.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorEndTime { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorExtendLastKnownValue.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorExtendLastKnownValue { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorExtendNakedPoc.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorExtendNakedPoc { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorExtendNakedVa.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorExtendNakedVa { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorFillOpacity.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorFillOpacity { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorFont.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorFont { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorFXTile.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorFXTile { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorFXTileDescription.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorFXTileDescription { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorHideBars.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorHideBars { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorHighlightDuration.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorHighlightDuration { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorHighPivotColor.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorHighPivotColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorHoverValues.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorHoverValues { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorInitialBalance.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorInitialBalance { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorInitialPoc.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorInitialPoc { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorInitialRange.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorInitialRange { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorInitialVa.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorInitialVa { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorJawOffset.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorJawOffset { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorJawPeriod.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorJawPeriod { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorLabelsGroup.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorLabelsGroup { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorLevelsToTrack.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorLevelsToTrack { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorLinesGroup.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorLinesGroup { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorLipsOffset.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorLipsOffset { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorLipsPeriod.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorLipsPeriod { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorLowPivotColor.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorLowPivotColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorMaximumMarkerSize.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorMaximumMarkerSize { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorMaximumVolumeRange.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorMaximumVolumeRange { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorMinimumVolumeForMarker.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorMinimumVolumeForMarker { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorMinimumVolumeRange.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorMinimumVolumeRange { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameCumulativeDelta.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameCumulativeDelta { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameCurrentDayOHL.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameCurrentDayOHL { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameEMA.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameEMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameLinReg.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameLinReg { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameSMA.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameSMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameSUM.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameSUM { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameSwing.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameSwing { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameTradeDetector.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameTradeDetector { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameVWAP.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameVWAP { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameWisemanAlligator.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameWisemanAlligator { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameWisemanAwesomeOscillator.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameWisemanAwesomeOscillator { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameWisemanFractal.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameWisemanFractal { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameWoodiesCCI.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameWoodiesCCI { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameWoodiesPivots.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameWoodiesPivots { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNoData.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNoData { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNumberOfNeutralBars.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNumberOfNeutralBars { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNumStandardDeviations.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNumStandardDeviations { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorOffsetTicks.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorOffsetTicks { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorOpacityDistribution.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorOpacityDistribution { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorOrderFlowMarketDepthMap.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorOrderFlowMarketDepthMap { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorOrderFlowMarketDepthMapDescription.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorOrderFlowMarketDepthMapDescription { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorOrderFlowVolumeProfile.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorOrderFlowVolumeProfile { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorOutlineBrush.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorOutlineBrush { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorOutlineStroke.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorOutlineStroke { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorPeriod.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorPeriod { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorPeriodEma.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorPeriodEma { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorPeriodLinRegr.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorPeriodLinRegr { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorPeriodTurboCCI.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorPeriodTurboCCI { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorPivotRangeType.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorPivotRangeType { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorPoc.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorPoc { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorPrevPoc.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorPrevPoc { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorPrevVa.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorPrevVa { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorPriorDayHLC.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorPriorDayHLC { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorProfileAlignment.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorProfileAlignment { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorProfileOpacity.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorProfileOpacity { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorProfilePeriod.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorProfilePeriod { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorProfilePeriodTradingHours.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorProfilePeriodTradingHours { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorProfilePeriodValue.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorProfilePeriodValue { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorProfileType.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorProfileType { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorProfileWidthPct.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorProfileWidthPct { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorProfileWidthPix.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorProfileWidthPix { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorRange.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorRange { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorRealTimeDepthMargin.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorRealTimeDepthMargin { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorResetInterval.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorResetInterval { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorResolution.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorResolution { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorResolutionWarning.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorResolutionWarning { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorSD1Multiplier.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorSD1Multiplier { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorSD2Multiplier.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorSD2Multiplier { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorSD3Multiplier.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorSD3Multiplier { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorSetupGroup.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorSetupGroup { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorShowBidAskLine.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorShowBidAskLine { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorShowCumulativeDepth.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorShowCumulativeDepth { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorShowPoc.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorShowPoc { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorShowProfileSummary.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorShowProfileSummary { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorShowVa.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorShowVa { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorShowVolumeData.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorShowVolumeData { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorSidewinderLimit0.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorSidewinderLimit0 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorSidewinderLimit1.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorSidewinderLimit1 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorSidewinderNeutral.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorSidewinderNeutral { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorSidewinderTrending.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorSidewinderTrending { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorSidewinderWarning.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorSidewinderWarning { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorSidewinderWidth.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorSidewinderWidth { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorSizeFilter.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorSizeFilter { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorStartDate.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorStartDate { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorStartTime.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorStartTime { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorStrength.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorStrength { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorSummaryDisplayUnit.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorSummaryDisplayUnit { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorTeethOffset.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorTeethOffset { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorTeethPeriod.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorTeethPeriod { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorTileSize.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorTileSize { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorTimesGroup.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorTimesGroup { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorTradingHours.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorTradingHours { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorUnableToLoadData.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorUnableToLoadData { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorUpBrush.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorUpBrush { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorUptickBackground.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorUptickBackground { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorUptickForeground.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorUptickForeground { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorUserDefinedHigh.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorUserDefinedHigh { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorUserDefinedLow.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorUserDefinedLow { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorUserDefinedOpen.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorUserDefinedOpen { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorUserDefinedValues.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorUserDefinedValues { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorValueArea.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorValueArea { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorValueAreaOpacity.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorValueAreaOpacity { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorVisualGroup.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorVisualGroup { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorWickStroke.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorWickStroke { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorWidth.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorWidth { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorWisemanAwesomeOscillatorPlot.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorWisemanAwesomeOscillatorPlot { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorZeroLine.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorZeroLine { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptParameters.
        /// </summary>
        [DataMember]
        public String NinjaScriptParameters { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptPlots.
        /// </summary>
        [DataMember]
        public String NinjaScriptPlots { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptUserDefinedValues.
        /// </summary>
        [DataMember]
        public String NinjaScriptUserDefinedValues { get; set; }
        /// <summary>
        /// Gets or sets the OpacityDistribution_High.
        /// </summary>
        [DataMember]
        public String OpacityDistribution_High { get; set; }
        /// <summary>
        /// Gets or sets the OpacityDistribution_Low.
        /// </summary>
        [DataMember]
        public String OpacityDistribution_Low { get; set; }
        /// <summary>
        /// Gets or sets the OpacityDistribution_Normal.
        /// </summary>
        [DataMember]
        public String OpacityDistribution_Normal { get; set; }
        /// <summary>
        /// Gets or sets the OutlineStroke.
        /// </summary>
        [DataMember]
        public String OutlineStroke { get; set; }
        /// <summary>
        /// Gets or sets the Period.
        /// </summary>
        [DataMember]
        public String Period { get; set; }
        /// <summary>
        /// Gets or sets the Phase.
        /// </summary>
        [DataMember]
        public String Phase { get; set; }
        /// <summary>
        /// Gets or sets the PivotRangeWoodie_Daily.
        /// </summary>
        [DataMember]
        public String PivotRangeWoodie_Daily { get; set; }
        /// <summary>
        /// Gets or sets the PivotRangeWoodie_Monthly.
        /// </summary>
        [DataMember]
        public String PivotRangeWoodie_Monthly { get; set; }
        /// <summary>
        /// Gets or sets the PivotRangeWoodie_Weekly.
        /// </summary>
        [DataMember]
        public String PivotRangeWoodie_Weekly { get; set; }
        /// <summary>
        /// Gets or sets the SizeFilter.
        /// </summary>
        [DataMember]
        public String SizeFilter { get; set; }
        /// <summary>
        /// Gets or sets the Smooth.
        /// </summary>
        [DataMember]
        public String Smooth { get; set; }
        /// <summary>
        /// Gets or sets the Smoothing.
        /// </summary>
        [DataMember]
        public String Smoothing { get; set; }
        /// <summary>
        /// Gets or sets the SwingHigh.
        /// </summary>
        [DataMember]
        public String SwingHigh { get; set; }
        /// <summary>
        /// Gets or sets the SwingLow.
        /// </summary>
        [DataMember]
        public String SwingLow { get; set; }
        /// <summary>
        /// Gets or sets the SwingSwingHighBarBarsAgoGreaterEqual.
        /// </summary>
        [DataMember]
        public String SwingSwingHighBarBarsAgoGreaterEqual { get; set; }
        /// <summary>
        /// Gets or sets the SwingSwingHighBarBarsAgoOutOfRange.
        /// </summary>
        [DataMember]
        public String SwingSwingHighBarBarsAgoOutOfRange { get; set; }
        /// <summary>
        /// Gets or sets the SwingSwingHighBarInstanceGreaterEqual.
        /// </summary>
        [DataMember]
        public String SwingSwingHighBarInstanceGreaterEqual { get; set; }
        /// <summary>
        /// Gets or sets the SwingSwingLowBarBarsAgoGreaterEqual.
        /// </summary>
        [DataMember]
        public String SwingSwingLowBarBarsAgoGreaterEqual { get; set; }
        /// <summary>
        /// Gets or sets the SwingSwingLowBarBarsAgoOutOfRange.
        /// </summary>
        [DataMember]
        public String SwingSwingLowBarBarsAgoOutOfRange { get; set; }
        /// <summary>
        /// Gets or sets the SwingSwingLowBarInstanceGreaterEqual.
        /// </summary>
        [DataMember]
        public String SwingSwingLowBarInstanceGreaterEqual { get; set; }
        /// <summary>
        /// Gets or sets the TradeDetectorBaseLargeVolumeOn_BidAsk.
        /// </summary>
        [DataMember]
        public String TradeDetectorBaseLargeVolumeOn_BidAsk { get; set; }
        /// <summary>
        /// Gets or sets the TradeDetectorBaseLargeVolumeOn_Block.
        /// </summary>
        [DataMember]
        public String TradeDetectorBaseLargeVolumeOn_Block { get; set; }
        /// <summary>
        /// Gets or sets the TradeDetectorBaseLargeVolumeOn_Price.
        /// </summary>
        [DataMember]
        public String TradeDetectorBaseLargeVolumeOn_Price { get; set; }
        /// <summary>
        /// Gets or sets the TradeDetectorSizeBase_Session.
        /// </summary>
        [DataMember]
        public String TradeDetectorSizeBase_Session { get; set; }
        /// <summary>
        /// Gets or sets the TradeDetectorSizeBase_VisibleArea.
        /// </summary>
        [DataMember]
        public String TradeDetectorSizeBase_VisibleArea { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricBarsTypeSizeFilter.
        /// </summary>
        [DataMember]
        public String VolumetricBarsTypeSizeFilter { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricBarsTypeTicksPerLevel.
        /// </summary>
        [DataMember]
        public String VolumetricBarsTypeTicksPerLevel { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartBarStatistics.
        /// </summary>
        [DataMember]
        public String VolumetricChartBarStatistics { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartBarStatisticsBuyVolume.
        /// </summary>
        [DataMember]
        public String VolumetricChartBarStatisticsBuyVolume { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartBarStatisticsCumulativeDelta.
        /// </summary>
        [DataMember]
        public String VolumetricChartBarStatisticsCumulativeDelta { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartBarStatisticsDeltaBar.
        /// </summary>
        [DataMember]
        public String VolumetricChartBarStatisticsDeltaBar { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartBarStatisticsDeltaDelta.
        /// </summary>
        [DataMember]
        public String VolumetricChartBarStatisticsDeltaDelta { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartBarStatisticsDeltaPct.
        /// </summary>
        [DataMember]
        public String VolumetricChartBarStatisticsDeltaPct { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartBarStatisticsDeltaSh.
        /// </summary>
        [DataMember]
        public String VolumetricChartBarStatisticsDeltaSh { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartBarStatisticsDeltaSl.
        /// </summary>
        [DataMember]
        public String VolumetricChartBarStatisticsDeltaSl { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartBarStatisticsMaxDelta.
        /// </summary>
        [DataMember]
        public String VolumetricChartBarStatisticsMaxDelta { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartBarStatisticsMinDelta.
        /// </summary>
        [DataMember]
        public String VolumetricChartBarStatisticsMinDelta { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartBarStatisticsSellVolume.
        /// </summary>
        [DataMember]
        public String VolumetricChartBarStatisticsSellVolume { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartBarStatisticsShowBuyVolume.
        /// </summary>
        [DataMember]
        public String VolumetricChartBarStatisticsShowBuyVolume { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartBarStatisticsShowDeltaBar.
        /// </summary>
        [DataMember]
        public String VolumetricChartBarStatisticsShowDeltaBar { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartBarStatisticsShowDeltaCum.
        /// </summary>
        [DataMember]
        public String VolumetricChartBarStatisticsShowDeltaCum { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartBarStatisticsShowDeltaDelta.
        /// </summary>
        [DataMember]
        public String VolumetricChartBarStatisticsShowDeltaDelta { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartBarStatisticsShowDeltaMax.
        /// </summary>
        [DataMember]
        public String VolumetricChartBarStatisticsShowDeltaMax { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartBarStatisticsShowDeltaMin.
        /// </summary>
        [DataMember]
        public String VolumetricChartBarStatisticsShowDeltaMin { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartBarStatisticsShowDeltaPct.
        /// </summary>
        [DataMember]
        public String VolumetricChartBarStatisticsShowDeltaPct { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartBarStatisticsShowDeltaSh.
        /// </summary>
        [DataMember]
        public String VolumetricChartBarStatisticsShowDeltaSh { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartBarStatisticsShowDeltaSl.
        /// </summary>
        [DataMember]
        public String VolumetricChartBarStatisticsShowDeltaSl { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartBarStatisticsShowSellVolume.
        /// </summary>
        [DataMember]
        public String VolumetricChartBarStatisticsShowSellVolume { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartBarStatisticsShowTrades.
        /// </summary>
        [DataMember]
        public String VolumetricChartBarStatisticsShowTrades { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartBarStatisticsShowVolume.
        /// </summary>
        [DataMember]
        public String VolumetricChartBarStatisticsShowVolume { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartBarStatisticsStatGrid.
        /// </summary>
        [DataMember]
        public String VolumetricChartBarStatisticsStatGrid { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartBarStatisticsTrades.
        /// </summary>
        [DataMember]
        public String VolumetricChartBarStatisticsTrades { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartBarStatisticsVolume.
        /// </summary>
        [DataMember]
        public String VolumetricChartBarStatisticsVolume { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartCenterOpenClose.
        /// </summary>
        [DataMember]
        public String VolumetricChartCenterOpenClose { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartColorDominantSide.
        /// </summary>
        [DataMember]
        public String VolumetricChartColorDominantSide { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartHideText.
        /// </summary>
        [DataMember]
        public String VolumetricChartHideText { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartShowAsProfile.
        /// </summary>
        [DataMember]
        public String VolumetricChartShowAsProfile { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartShowBarStatistics.
        /// </summary>
        [DataMember]
        public String VolumetricChartShowBarStatistics { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartShowImbalance.
        /// </summary>
        [DataMember]
        public String VolumetricChartShowImbalance { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartShowVolume.
        /// </summary>
        [DataMember]
        public String VolumetricChartShowVolume { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartStyleBaseBrush.
        /// </summary>
        [DataMember]
        public String VolumetricChartStyleBaseBrush { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartStyleBoxGrid.
        /// </summary>
        [DataMember]
        public String VolumetricChartStyleBoxGrid { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartStyleBoxOutline.
        /// </summary>
        [DataMember]
        public String VolumetricChartStyleBoxOutline { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartStyleBuyImbalancBrush.
        /// </summary>
        [DataMember]
        public String VolumetricChartStyleBuyImbalancBrush { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartStyleDojiBrush.
        /// </summary>
        [DataMember]
        public String VolumetricChartStyleDojiBrush { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartStyleGradientDepth.
        /// </summary>
        [DataMember]
        public String VolumetricChartStyleGradientDepth { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartStyleImbalanceBuyBrush.
        /// </summary>
        [DataMember]
        public String VolumetricChartStyleImbalanceBuyBrush { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartStyleImbalanceRatio.
        /// </summary>
        [DataMember]
        public String VolumetricChartStyleImbalanceRatio { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartStyleImbalanceSellBrush.
        /// </summary>
        [DataMember]
        public String VolumetricChartStyleImbalanceSellBrush { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartStyleMaxBrush.
        /// </summary>
        [DataMember]
        public String VolumetricChartStyleMaxBrush { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartStyleMinDelta.
        /// </summary>
        [DataMember]
        public String VolumetricChartStyleMinDelta { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartStyleNegativeStrengthBrush.
        /// </summary>
        [DataMember]
        public String VolumetricChartStyleNegativeStrengthBrush { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartStylePositiveStrengthBrush.
        /// </summary>
        [DataMember]
        public String VolumetricChartStylePositiveStrengthBrush { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartStyleSellImbalancBrush.
        /// </summary>
        [DataMember]
        public String VolumetricChartStyleSellImbalancBrush { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartStyleShowMaximum.
        /// </summary>
        [DataMember]
        public String VolumetricChartStyleShowMaximum { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartStyleSizeDisplayFilter.
        /// </summary>
        [DataMember]
        public String VolumetricChartStyleSizeDisplayFilter { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartStyleStatGrid.
        /// </summary>
        [DataMember]
        public String VolumetricChartStyleStatGrid { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartStyleTextBrush.
        /// </summary>
        [DataMember]
        public String VolumetricChartStyleTextBrush { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartStyleType.
        /// </summary>
        [DataMember]
        public String VolumetricChartStyleType { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartStyleVolBrush.
        /// </summary>
        [DataMember]
        public String VolumetricChartStyleVolBrush { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricImbalanceMode.
        /// </summary>
        [DataMember]
        public String VolumetricImbalanceMode { get; set; }
        /// <summary>
        /// Gets or sets the VWAPPlotStdDev1Lower.
        /// </summary>
        [DataMember]
        public String VWAPPlotStdDev1Lower { get; set; }
        /// <summary>
        /// Gets or sets the VWAPPlotStdDev1Upper.
        /// </summary>
        [DataMember]
        public String VWAPPlotStdDev1Upper { get; set; }
        /// <summary>
        /// Gets or sets the VWAPPlotStdDev2Lower.
        /// </summary>
        [DataMember]
        public String VWAPPlotStdDev2Lower { get; set; }
        /// <summary>
        /// Gets or sets the VWAPPlotStdDev2Upper.
        /// </summary>
        [DataMember]
        public String VWAPPlotStdDev2Upper { get; set; }
        /// <summary>
        /// Gets or sets the VWAPPlotStdDev3Lower.
        /// </summary>
        [DataMember]
        public String VWAPPlotStdDev3Lower { get; set; }
        /// <summary>
        /// Gets or sets the VWAPPlotStdDev3Upper.
        /// </summary>
        [DataMember]
        public String VWAPPlotStdDev3Upper { get; set; }
        /// <summary>
        /// Gets or sets the VWAPResetInterval_Month.
        /// </summary>
        [DataMember]
        public String VWAPResetInterval_Month { get; set; }
        /// <summary>
        /// Gets or sets the VWAPResetInterval_Session.
        /// </summary>
        [DataMember]
        public String VWAPResetInterval_Session { get; set; }
        /// <summary>
        /// Gets or sets the VWAPResetInterval_Week.
        /// </summary>
        [DataMember]
        public String VWAPResetInterval_Week { get; set; }
        /// <summary>
        /// Gets or sets the VWAPResolution_Standard.
        /// </summary>
        [DataMember]
        public String VWAPResolution_Standard { get; set; }
        /// <summary>
        /// Gets or sets the VWAPResolution_Tick.
        /// </summary>
        [DataMember]
        public String VWAPResolution_Tick { get; set; }
        /// <summary>
        /// Gets or sets the VWAPStandardDeviations_None.
        /// </summary>
        [DataMember]
        public String VWAPStandardDeviations_None { get; set; }
        /// <summary>
        /// Gets or sets the VWAPStandardDeviations_One.
        /// </summary>
        [DataMember]
        public String VWAPStandardDeviations_One { get; set; }
        /// <summary>
        /// Gets or sets the VWAPStandardDeviations_Three.
        /// </summary>
        [DataMember]
        public String VWAPStandardDeviations_Three { get; set; }
        /// <summary>
        /// Gets or sets the VWAPStandardDeviations_Two.
        /// </summary>
        [DataMember]
        public String VWAPStandardDeviations_Two { get; set; }
        /// <summary>
        /// Gets or sets the VWAPStandardDeviations_Zero.
        /// </summary>
        [DataMember]
        public String VWAPStandardDeviations_Zero { get; set; }
        /// <summary>
        /// Gets or sets the WickStroke.
        /// </summary>
        [DataMember]
        public String WickStroke { get; set; }
        /// <summary>
        /// Gets or sets the WisemanAlligatorPlot1.
        /// </summary>
        [DataMember]
        public String WisemanAlligatorPlot1 { get; set; }
        /// <summary>
        /// Gets or sets the WisemanAlligatorPlot2.
        /// </summary>
        [DataMember]
        public String WisemanAlligatorPlot2 { get; set; }
        /// <summary>
        /// Gets or sets the WisemanAlligatorPlot3.
        /// </summary>
        [DataMember]
        public String WisemanAlligatorPlot3 { get; set; }
        /// <summary>
        /// Gets or sets the WoodiesCCIInsufficientPanelData.
        /// </summary>
        [DataMember]
        public String WoodiesCCIInsufficientPanelData { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
