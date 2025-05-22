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
        public System.Resources.ResourceManager ResourceManager { get; set; }
        /// <summary>
        /// Gets or sets the Culture.
        /// </summary>
        [DataMember]
        public System.Globalization.CultureInfo Culture { get; set; }
        /// <summary>
        /// Gets or sets the BaseVolumeRange_ExactVolume.
        /// </summary>
        [DataMember]
        public string BaseVolumeRange_ExactVolume { get; set; }
        /// <summary>
        /// Gets or sets the BaseVolumeRange_Percent.
        /// </summary>
        [DataMember]
        public string BaseVolumeRange_Percent { get; set; }
        /// <summary>
        /// Gets or sets the CumulativeDeltaPeriod_Bar.
        /// </summary>
        [DataMember]
        public string CumulativeDeltaPeriod_Bar { get; set; }
        /// <summary>
        /// Gets or sets the CumulativeDeltaPeriod_Session.
        /// </summary>
        [DataMember]
        public string CumulativeDeltaPeriod_Session { get; set; }
        /// <summary>
        /// Gets or sets the CumulativeDeltaPlotClose.
        /// </summary>
        [DataMember]
        public string CumulativeDeltaPlotClose { get; set; }
        /// <summary>
        /// Gets or sets the CumulativeDeltaPlotHigh.
        /// </summary>
        [DataMember]
        public string CumulativeDeltaPlotHigh { get; set; }
        /// <summary>
        /// Gets or sets the CumulativeDeltaPlotLow.
        /// </summary>
        [DataMember]
        public string CumulativeDeltaPlotLow { get; set; }
        /// <summary>
        /// Gets or sets the CumulativeDeltaPlotOpen.
        /// </summary>
        [DataMember]
        public string CumulativeDeltaPlotOpen { get; set; }
        /// <summary>
        /// Gets or sets the CumulativeDeltaType_BidAsk.
        /// </summary>
        [DataMember]
        public string CumulativeDeltaType_BidAsk { get; set; }
        /// <summary>
        /// Gets or sets the CumulativeDeltaType_UpDownTick.
        /// </summary>
        [DataMember]
        public string CumulativeDeltaType_UpDownTick { get; set; }
        /// <summary>
        /// Gets or sets the CurrentDayOHLError.
        /// </summary>
        [DataMember]
        public string CurrentDayOHLError { get; set; }
        /// <summary>
        /// Gets or sets the CurrentDayOHLHigh.
        /// </summary>
        [DataMember]
        public string CurrentDayOHLHigh { get; set; }
        /// <summary>
        /// Gets or sets the CurrentDayOHLLow.
        /// </summary>
        [DataMember]
        public string CurrentDayOHLLow { get; set; }
        /// <summary>
        /// Gets or sets the CurrentDayOHLOpen.
        /// </summary>
        [DataMember]
        public string CurrentDayOHLOpen { get; set; }
        /// <summary>
        /// Gets or sets the DeltaType.
        /// </summary>
        [DataMember]
        public string DeltaType { get; set; }
        /// <summary>
        /// Gets or sets the Depth.
        /// </summary>
        [DataMember]
        public string Depth { get; set; }
        /// <summary>
        /// Gets or sets the DepthMapDisplayMode_Both.
        /// </summary>
        [DataMember]
        public string DepthMapDisplayMode_Both { get; set; }
        /// <summary>
        /// Gets or sets the DepthMapDisplayMode_Historical.
        /// </summary>
        [DataMember]
        public string DepthMapDisplayMode_Historical { get; set; }
        /// <summary>
        /// Gets or sets the DepthMapDisplayMode_Realtime.
        /// </summary>
        [DataMember]
        public string DepthMapDisplayMode_Realtime { get; set; }
        /// <summary>
        /// Gets or sets the DownBrush.
        /// </summary>
        [DataMember]
        public string DownBrush { get; set; }
        /// <summary>
        /// Gets or sets the FXTileBuyToolTip.
        /// </summary>
        [DataMember]
        public string FXTileBuyToolTip { get; set; }
        /// <summary>
        /// Gets or sets the FXTileInstrumentMatchError.
        /// </summary>
        [DataMember]
        public string FXTileInstrumentMatchError { get; set; }
        /// <summary>
        /// Gets or sets the FXTileInstrumentTypeError.
        /// </summary>
        [DataMember]
        public string FXTileInstrumentTypeError { get; set; }
        /// <summary>
        /// Gets or sets the FXTileSellToolTip.
        /// </summary>
        [DataMember]
        public string FXTileSellToolTip { get; set; }
        /// <summary>
        /// Gets or sets the HLCCalculationModeWoodie_CalcFromIntradayData.
        /// </summary>
        [DataMember]
        public string HLCCalculationModeWoodie_CalcFromIntradayData { get; set; }
        /// <summary>
        /// Gets or sets the HLCCalculationModeWoodie_DailyBars.
        /// </summary>
        [DataMember]
        public string HLCCalculationModeWoodie_DailyBars { get; set; }
        /// <summary>
        /// Gets or sets the HLCCalculationModeWoodie_UserDefinedValues.
        /// </summary>
        [DataMember]
        public string HLCCalculationModeWoodie_UserDefinedValues { get; set; }
        /// <summary>
        /// Gets or sets the JurikCallFailed.
        /// </summary>
        [DataMember]
        public string JurikCallFailed { get; set; }
        /// <summary>
        /// Gets or sets the JurikNotInstalled.
        /// </summary>
        [DataMember]
        public string JurikNotInstalled { get; set; }
        /// <summary>
        /// Gets or sets the LargeVolumeMarkerSizeBase_Session.
        /// </summary>
        [DataMember]
        public string LargeVolumeMarkerSizeBase_Session { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfileAlignment_Left.
        /// </summary>
        [DataMember]
        public string MarketProfileAlignment_Left { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfileAlignment_Right.
        /// </summary>
        [DataMember]
        public string MarketProfileAlignment_Right { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfileComposeBy_Chart.
        /// </summary>
        [DataMember]
        public string MarketProfileComposeBy_Chart { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfileComposeBy_DaysBack.
        /// </summary>
        [DataMember]
        public string MarketProfileComposeBy_DaysBack { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfileComposeBy_MonthsBack.
        /// </summary>
        [DataMember]
        public string MarketProfileComposeBy_MonthsBack { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfileComposeBy_StartDate.
        /// </summary>
        [DataMember]
        public string MarketProfileComposeBy_StartDate { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfileComposeBy_VisibleScreen.
        /// </summary>
        [DataMember]
        public string MarketProfileComposeBy_VisibleScreen { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfileComposeBy_WeeksBack.
        /// </summary>
        [DataMember]
        public string MarketProfileComposeBy_WeeksBack { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfileDisplayMode_BuySell.
        /// </summary>
        [DataMember]
        public string MarketProfileDisplayMode_BuySell { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfileDisplayMode_Delta.
        /// </summary>
        [DataMember]
        public string MarketProfileDisplayMode_Delta { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfileDisplayMode_Heat.
        /// </summary>
        [DataMember]
        public string MarketProfileDisplayMode_Heat { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfileDisplayMode_Outline.
        /// </summary>
        [DataMember]
        public string MarketProfileDisplayMode_Outline { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfileDisplayMode_Standard.
        /// </summary>
        [DataMember]
        public string MarketProfileDisplayMode_Standard { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfileDisplayMode_TimeColor.
        /// </summary>
        [DataMember]
        public string MarketProfileDisplayMode_TimeColor { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfilePeriod_Bars.
        /// </summary>
        [DataMember]
        public string MarketProfilePeriod_Bars { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfilePeriod_Composite.
        /// </summary>
        [DataMember]
        public string MarketProfilePeriod_Composite { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfilePeriod_Minutes.
        /// </summary>
        [DataMember]
        public string MarketProfilePeriod_Minutes { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfilePeriod_Months.
        /// </summary>
        [DataMember]
        public string MarketProfilePeriod_Months { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfilePeriod_Sessions.
        /// </summary>
        [DataMember]
        public string MarketProfilePeriod_Sessions { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfilePeriod_Weeks.
        /// </summary>
        [DataMember]
        public string MarketProfilePeriod_Weeks { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfilePriceDrawMode_Boxes.
        /// </summary>
        [DataMember]
        public string MarketProfilePriceDrawMode_Boxes { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfilePriceDrawMode_Letters.
        /// </summary>
        [DataMember]
        public string MarketProfilePriceDrawMode_Letters { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfileResolution_Minute.
        /// </summary>
        [DataMember]
        public string MarketProfileResolution_Minute { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfileResolution_Tick.
        /// </summary>
        [DataMember]
        public string MarketProfileResolution_Tick { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfileType_Price.
        /// </summary>
        [DataMember]
        public string MarketProfileType_Price { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfileType_Tick.
        /// </summary>
        [DataMember]
        public string MarketProfileType_Tick { get; set; }
        /// <summary>
        /// Gets or sets the MarketProfileType_Volume.
        /// </summary>
        [DataMember]
        public string MarketProfileType_Volume { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsTypeDelta.
        /// </summary>
        [DataMember]
        public string NinjaScriptBarsTypeDelta { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsTypePriceOnVolume.
        /// </summary>
        [DataMember]
        public string NinjaScriptBarsTypePriceOnVolume { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsTypeReversal.
        /// </summary>
        [DataMember]
        public string NinjaScriptBarsTypeReversal { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsTypeTrendDelta.
        /// </summary>
        [DataMember]
        public string NinjaScriptBarsTypeTrendDelta { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsTypeTrendReversal.
        /// </summary>
        [DataMember]
        public string NinjaScriptBarsTypeTrendReversal { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsTypeVolumetric.
        /// </summary>
        [DataMember]
        public string NinjaScriptBarsTypeVolumetric { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleBarWidth.
        /// </summary>
        [DataMember]
        public string NinjaScriptChartStyleBarWidth { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleCandleDownBarsColor.
        /// </summary>
        [DataMember]
        public string NinjaScriptChartStyleCandleDownBarsColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleCandleOutline.
        /// </summary>
        [DataMember]
        public string NinjaScriptChartStyleCandleOutline { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleCandleUpBarsColor.
        /// </summary>
        [DataMember]
        public string NinjaScriptChartStyleCandleUpBarsColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStylePOVCandlestick.
        /// </summary>
        [DataMember]
        public string NinjaScriptChartStylePOVCandlestick { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStylePOVEquivolume.
        /// </summary>
        [DataMember]
        public string NinjaScriptChartStylePOVEquivolume { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleVolumetric.
        /// </summary>
        [DataMember]
        public string NinjaScriptChartStyleVolumetric { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDescriptionPivotRangeType.
        /// </summary>
        [DataMember]
        public string NinjaScriptDescriptionPivotRangeType { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDescriptionPriorDayHLC.
        /// </summary>
        [DataMember]
        public string NinjaScriptDescriptionPriorDayHLC { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDescriptionUserDefinedHigh.
        /// </summary>
        [DataMember]
        public string NinjaScriptDescriptionUserDefinedHigh { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDescriptionUserDefinedLow.
        /// </summary>
        [DataMember]
        public string NinjaScriptDescriptionUserDefinedLow { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDescriptionUserDefinedOpen.
        /// </summary>
        [DataMember]
        public string NinjaScriptDescriptionUserDefinedOpen { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDescriptionWidth.
        /// </summary>
        [DataMember]
        public string NinjaScriptDescriptionWidth { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolAnchor.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolAnchor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolAnchorEnd.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolAnchorEnd { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolAnchorStart.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolAnchorStart { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolAreaOpacity.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolAreaOpacity { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRegion.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolRegion { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolsChartArrowDownMarkerName.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolsChartArrowDownMarkerName { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolsChartArrowUpMarkerName.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolsChartArrowUpMarkerName { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolsChartDiamondMarkerName.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolsChartDiamondMarkerName { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolsChartDotMarkerName.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolsChartDotMarkerName { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolsChartSquareMarkerName.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolsChartSquareMarkerName { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolsChartTriangleDownMarkerName.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolsChartTriangleDownMarkerName { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolsChartTriangleUpMarkerName.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolsChartTriangleUpMarkerName { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolSD1Stroke.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolSD1Stroke { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolSD2Stroke.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolSD2Stroke { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolSD3Stroke.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolSD3Stroke { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolShapesAreaBrush.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolShapesAreaBrush { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolShapesOutlineBrush.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolShapesOutlineBrush { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolText.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolText { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolTextAlignment.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolTextAlignment { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolTextBrush.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolTextBrush { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolTextFixed.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolTextFixed { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolTextFixedTextPosition.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolTextFixedTextPosition { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolTextFont.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolTextFont { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolTextOutlineStroke.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolTextOutlineStroke { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolTextOutlineVisible.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolTextOutlineVisible { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolVwapStroke.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolVwapStroke { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptErrorVWAPAccuracyWarning.
        /// </summary>
        [DataMember]
        public string NinjaScriptErrorVWAPAccuracyWarning { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptErrorVWAPResolution.
        /// </summary>
        [DataMember]
        public string NinjaScriptErrorVWAPResolution { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptErrorWoodiesPivotsHistorical.
        /// </summary>
        [DataMember]
        public string NinjaScriptErrorWoodiesPivotsHistorical { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptErrorWoodiesPivotsInterday.
        /// </summary>
        [DataMember]
        public string NinjaScriptErrorWoodiesPivotsInterday { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptGeneral.
        /// </summary>
        [DataMember]
        public string NinjaScriptGeneral { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorAbovePriceBrush.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorAbovePriceBrush { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorAskBrush.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorAskBrush { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorBandAreaBrush.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorBandAreaBrush { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorBandAreaBrush2.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorBandAreaBrush2 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorBandAreaBrush3.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorBandAreaBrush3 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorBandAreaOpacity.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorBandAreaOpacity { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorBandAreaOpacity2.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorBandAreaOpacity2 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorBandAreaOpacity3.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorBandAreaOpacity3 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorBarColor.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorBarColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorBaseLargeVolumeOn.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorBaseLargeVolumeOn { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorBaseMarkerSizeOn.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorBaseMarkerSizeOn { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorBaseVolumeRangeOn.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorBaseVolumeRangeOn { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorBelowPriceBrush.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorBelowPriceBrush { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorBidBrush.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorBidBrush { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorButtonBackground.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorButtonBackground { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorButtonForeground.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorButtonForeground { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorCalculating.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorCalculating { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorCannotBeDrawnOn.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorCannotBeDrawnOn { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorChopIndicatorWidth.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorChopIndicatorWidth { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorCloseForAsk.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorCloseForAsk { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorCloseForBid.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorCloseForBid { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColorByTime.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorColorByTime { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColorDown.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorColorDown { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColorDownFill.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorColorDownFill { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColorDownOutline.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorColorDownOutline { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColorForAsk.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorColorForAsk { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColorForAskDepth.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorColorForAskDepth { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColorForBid.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorColorForBid { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColorForBitDepth.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorColorForBitDepth { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColorForPoc.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorColorForPoc { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColorHighHeat.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorColorHighHeat { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColorLastNeutralBar.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorColorLastNeutralBar { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColorLowHeat.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorColorLowHeat { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColorNegLsma.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorColorNegLsma { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColorNegValues.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorColorNegValues { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColorNeutralZone.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorColorNeutralZone { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColorPosLsma.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorColorPosLsma { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColorPosValues.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorColorPosValues { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColorProfile.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorColorProfile { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColorProfileSummary.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorColorProfileSummary { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColorSquatFill.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorColorSquatFill { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColorSquatOutline.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorColorSquatOutline { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColorUp.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorColorUp { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColorUpFill.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorColorUpFill { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColorUpOutline.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorColorUpOutline { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorColorVolumeData.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorColorVolumeData { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorComposeBy.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorComposeBy { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDataSeriesGroup.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDataSeriesGroup { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDeltaType.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDeltaType { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionCumulativeDelta.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionCumulativeDelta { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionCurrentDayOHL.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionCurrentDayOHL { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionEMA.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionEMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionJurikDMX.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionJurikDMX { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionJurikJMA.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionJurikJMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionJurikRSX.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionJurikRSX { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionJurikVEL.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionJurikVEL { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionLinReg.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionLinReg { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionSMA.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionSMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionSUM.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionSUM { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionSwing.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionSwing { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionTradeDetector.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionTradeDetector { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionVolumeProfile.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionVolumeProfile { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionVWAP.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionVWAP { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionWisemanAlligator.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionWisemanAlligator { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionWisemanAwesomeOscillator.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionWisemanAwesomeOscillator { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionWisemanFractal.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionWisemanFractal { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionWoodiesCCI.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionWoodiesCCI { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionWoodiesPivots.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionWoodiesPivots { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDevPoc.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDevPoc { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDevVa.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDevVa { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDisplayCCIPanel.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDisplayCCIPanel { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDisplayInMargin.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDisplayInMargin { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDisplayMode.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDisplayMode { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDownBrush.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDownBrush { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDowntickBackground.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDowntickBackground { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDowntickForeground.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDowntickForeground { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDrawMode.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDrawMode { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorEnabled.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorEnabled { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorEndTime.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorEndTime { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorExtendLastKnownValue.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorExtendLastKnownValue { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorExtendNakedPoc.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorExtendNakedPoc { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorExtendNakedVa.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorExtendNakedVa { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorFillOpacity.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorFillOpacity { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorFont.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorFont { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorFXTile.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorFXTile { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorFXTileDescription.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorFXTileDescription { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorHideBars.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorHideBars { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorHighlightDuration.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorHighlightDuration { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorHighPivotColor.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorHighPivotColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorHoverValues.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorHoverValues { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorInitialBalance.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorInitialBalance { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorInitialPoc.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorInitialPoc { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorInitialRange.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorInitialRange { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorInitialVa.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorInitialVa { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorJawOffset.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorJawOffset { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorJawPeriod.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorJawPeriod { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorLabelsGroup.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorLabelsGroup { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorLevelsToTrack.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorLevelsToTrack { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorLinesGroup.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorLinesGroup { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorLipsOffset.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorLipsOffset { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorLipsPeriod.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorLipsPeriod { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorLowPivotColor.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorLowPivotColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorMaximumMarkerSize.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorMaximumMarkerSize { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorMaximumVolumeRange.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorMaximumVolumeRange { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorMinimumVolumeForMarker.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorMinimumVolumeForMarker { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorMinimumVolumeRange.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorMinimumVolumeRange { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameCumulativeDelta.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameCumulativeDelta { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameCurrentDayOHL.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameCurrentDayOHL { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameEMA.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameEMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameLinReg.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameLinReg { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameSMA.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameSMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameSUM.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameSUM { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameSwing.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameSwing { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameTradeDetector.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameTradeDetector { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameVWAP.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameVWAP { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameWisemanAlligator.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameWisemanAlligator { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameWisemanAwesomeOscillator.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameWisemanAwesomeOscillator { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameWisemanFractal.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameWisemanFractal { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameWoodiesCCI.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameWoodiesCCI { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameWoodiesPivots.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameWoodiesPivots { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNoData.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNoData { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNumberOfNeutralBars.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNumberOfNeutralBars { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNumStandardDeviations.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNumStandardDeviations { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorOffsetTicks.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorOffsetTicks { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorOpacityDistribution.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorOpacityDistribution { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorOrderFlowMarketDepthMap.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorOrderFlowMarketDepthMap { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorOrderFlowMarketDepthMapDescription.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorOrderFlowMarketDepthMapDescription { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorOrderFlowVolumeProfile.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorOrderFlowVolumeProfile { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorOutlineBrush.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorOutlineBrush { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorOutlineStroke.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorOutlineStroke { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorPeriod.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorPeriod { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorPeriodEma.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorPeriodEma { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorPeriodLinRegr.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorPeriodLinRegr { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorPeriodTurboCCI.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorPeriodTurboCCI { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorPivotRangeType.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorPivotRangeType { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorPoc.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorPoc { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorPrevPoc.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorPrevPoc { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorPrevVa.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorPrevVa { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorPriorDayHLC.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorPriorDayHLC { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorProfileAlignment.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorProfileAlignment { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorProfileOpacity.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorProfileOpacity { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorProfilePeriod.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorProfilePeriod { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorProfilePeriodTradingHours.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorProfilePeriodTradingHours { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorProfilePeriodValue.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorProfilePeriodValue { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorProfileType.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorProfileType { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorProfileWidthPct.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorProfileWidthPct { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorProfileWidthPix.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorProfileWidthPix { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorRange.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorRange { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorRealTimeDepthMargin.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorRealTimeDepthMargin { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorResetInterval.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorResetInterval { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorResolution.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorResolution { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorResolutionWarning.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorResolutionWarning { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorSD1Multiplier.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorSD1Multiplier { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorSD2Multiplier.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorSD2Multiplier { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorSD3Multiplier.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorSD3Multiplier { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorSetupGroup.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorSetupGroup { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorShowBidAskLine.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorShowBidAskLine { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorShowCumulativeDepth.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorShowCumulativeDepth { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorShowPoc.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorShowPoc { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorShowProfileSummary.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorShowProfileSummary { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorShowVa.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorShowVa { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorShowVolumeData.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorShowVolumeData { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorSidewinderLimit0.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorSidewinderLimit0 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorSidewinderLimit1.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorSidewinderLimit1 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorSidewinderNeutral.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorSidewinderNeutral { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorSidewinderTrending.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorSidewinderTrending { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorSidewinderWarning.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorSidewinderWarning { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorSidewinderWidth.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorSidewinderWidth { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorSizeFilter.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorSizeFilter { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorStartDate.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorStartDate { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorStartTime.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorStartTime { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorStrength.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorStrength { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorSummaryDisplayUnit.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorSummaryDisplayUnit { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorTeethOffset.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorTeethOffset { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorTeethPeriod.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorTeethPeriod { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorTileSize.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorTileSize { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorTimesGroup.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorTimesGroup { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorTradingHours.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorTradingHours { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorUnableToLoadData.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorUnableToLoadData { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorUpBrush.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorUpBrush { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorUptickBackground.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorUptickBackground { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorUptickForeground.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorUptickForeground { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorUserDefinedHigh.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorUserDefinedHigh { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorUserDefinedLow.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorUserDefinedLow { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorUserDefinedOpen.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorUserDefinedOpen { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorUserDefinedValues.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorUserDefinedValues { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorValueArea.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorValueArea { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorValueAreaOpacity.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorValueAreaOpacity { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorVisualGroup.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorVisualGroup { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorWickStroke.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorWickStroke { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorWidth.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorWidth { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorWisemanAwesomeOscillatorPlot.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorWisemanAwesomeOscillatorPlot { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorZeroLine.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorZeroLine { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptParameters.
        /// </summary>
        [DataMember]
        public string NinjaScriptParameters { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptPlots.
        /// </summary>
        [DataMember]
        public string NinjaScriptPlots { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptUserDefinedValues.
        /// </summary>
        [DataMember]
        public string NinjaScriptUserDefinedValues { get; set; }
        /// <summary>
        /// Gets or sets the OpacityDistribution_High.
        /// </summary>
        [DataMember]
        public string OpacityDistribution_High { get; set; }
        /// <summary>
        /// Gets or sets the OpacityDistribution_Low.
        /// </summary>
        [DataMember]
        public string OpacityDistribution_Low { get; set; }
        /// <summary>
        /// Gets or sets the OpacityDistribution_Normal.
        /// </summary>
        [DataMember]
        public string OpacityDistribution_Normal { get; set; }
        /// <summary>
        /// Gets or sets the OutlineStroke.
        /// </summary>
        [DataMember]
        public string OutlineStroke { get; set; }
        /// <summary>
        /// Gets or sets the Period.
        /// </summary>
        [DataMember]
        public string Period { get; set; }
        /// <summary>
        /// Gets or sets the Phase.
        /// </summary>
        [DataMember]
        public string Phase { get; set; }
        /// <summary>
        /// Gets or sets the PivotRangeWoodie_Daily.
        /// </summary>
        [DataMember]
        public string PivotRangeWoodie_Daily { get; set; }
        /// <summary>
        /// Gets or sets the PivotRangeWoodie_Monthly.
        /// </summary>
        [DataMember]
        public string PivotRangeWoodie_Monthly { get; set; }
        /// <summary>
        /// Gets or sets the PivotRangeWoodie_Weekly.
        /// </summary>
        [DataMember]
        public string PivotRangeWoodie_Weekly { get; set; }
        /// <summary>
        /// Gets or sets the SizeFilter.
        /// </summary>
        [DataMember]
        public string SizeFilter { get; set; }
        /// <summary>
        /// Gets or sets the Smooth.
        /// </summary>
        [DataMember]
        public string Smooth { get; set; }
        /// <summary>
        /// Gets or sets the Smoothing.
        /// </summary>
        [DataMember]
        public string Smoothing { get; set; }
        /// <summary>
        /// Gets or sets the SwingHigh.
        /// </summary>
        [DataMember]
        public string SwingHigh { get; set; }
        /// <summary>
        /// Gets or sets the SwingLow.
        /// </summary>
        [DataMember]
        public string SwingLow { get; set; }
        /// <summary>
        /// Gets or sets the SwingSwingHighBarBarsAgoGreaterEqual.
        /// </summary>
        [DataMember]
        public string SwingSwingHighBarBarsAgoGreaterEqual { get; set; }
        /// <summary>
        /// Gets or sets the SwingSwingHighBarBarsAgoOutOfRange.
        /// </summary>
        [DataMember]
        public string SwingSwingHighBarBarsAgoOutOfRange { get; set; }
        /// <summary>
        /// Gets or sets the SwingSwingHighBarInstanceGreaterEqual.
        /// </summary>
        [DataMember]
        public string SwingSwingHighBarInstanceGreaterEqual { get; set; }
        /// <summary>
        /// Gets or sets the SwingSwingLowBarBarsAgoGreaterEqual.
        /// </summary>
        [DataMember]
        public string SwingSwingLowBarBarsAgoGreaterEqual { get; set; }
        /// <summary>
        /// Gets or sets the SwingSwingLowBarBarsAgoOutOfRange.
        /// </summary>
        [DataMember]
        public string SwingSwingLowBarBarsAgoOutOfRange { get; set; }
        /// <summary>
        /// Gets or sets the SwingSwingLowBarInstanceGreaterEqual.
        /// </summary>
        [DataMember]
        public string SwingSwingLowBarInstanceGreaterEqual { get; set; }
        /// <summary>
        /// Gets or sets the TradeDetectorBaseLargeVolumeOn_BidAsk.
        /// </summary>
        [DataMember]
        public string TradeDetectorBaseLargeVolumeOn_BidAsk { get; set; }
        /// <summary>
        /// Gets or sets the TradeDetectorBaseLargeVolumeOn_Block.
        /// </summary>
        [DataMember]
        public string TradeDetectorBaseLargeVolumeOn_Block { get; set; }
        /// <summary>
        /// Gets or sets the TradeDetectorBaseLargeVolumeOn_Price.
        /// </summary>
        [DataMember]
        public string TradeDetectorBaseLargeVolumeOn_Price { get; set; }
        /// <summary>
        /// Gets or sets the TradeDetectorSizeBase_Session.
        /// </summary>
        [DataMember]
        public string TradeDetectorSizeBase_Session { get; set; }
        /// <summary>
        /// Gets or sets the TradeDetectorSizeBase_VisibleArea.
        /// </summary>
        [DataMember]
        public string TradeDetectorSizeBase_VisibleArea { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricBarsTypeSizeFilter.
        /// </summary>
        [DataMember]
        public string VolumetricBarsTypeSizeFilter { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricBarsTypeTicksPerLevel.
        /// </summary>
        [DataMember]
        public string VolumetricBarsTypeTicksPerLevel { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartBarStatistics.
        /// </summary>
        [DataMember]
        public string VolumetricChartBarStatistics { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartBarStatisticsBuyVolume.
        /// </summary>
        [DataMember]
        public string VolumetricChartBarStatisticsBuyVolume { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartBarStatisticsCumulativeDelta.
        /// </summary>
        [DataMember]
        public string VolumetricChartBarStatisticsCumulativeDelta { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartBarStatisticsDeltaBar.
        /// </summary>
        [DataMember]
        public string VolumetricChartBarStatisticsDeltaBar { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartBarStatisticsDeltaDelta.
        /// </summary>
        [DataMember]
        public string VolumetricChartBarStatisticsDeltaDelta { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartBarStatisticsDeltaPct.
        /// </summary>
        [DataMember]
        public string VolumetricChartBarStatisticsDeltaPct { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartBarStatisticsDeltaSh.
        /// </summary>
        [DataMember]
        public string VolumetricChartBarStatisticsDeltaSh { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartBarStatisticsDeltaSl.
        /// </summary>
        [DataMember]
        public string VolumetricChartBarStatisticsDeltaSl { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartBarStatisticsMaxDelta.
        /// </summary>
        [DataMember]
        public string VolumetricChartBarStatisticsMaxDelta { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartBarStatisticsMinDelta.
        /// </summary>
        [DataMember]
        public string VolumetricChartBarStatisticsMinDelta { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartBarStatisticsSellVolume.
        /// </summary>
        [DataMember]
        public string VolumetricChartBarStatisticsSellVolume { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartBarStatisticsShowBuyVolume.
        /// </summary>
        [DataMember]
        public string VolumetricChartBarStatisticsShowBuyVolume { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartBarStatisticsShowDeltaBar.
        /// </summary>
        [DataMember]
        public string VolumetricChartBarStatisticsShowDeltaBar { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartBarStatisticsShowDeltaCum.
        /// </summary>
        [DataMember]
        public string VolumetricChartBarStatisticsShowDeltaCum { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartBarStatisticsShowDeltaDelta.
        /// </summary>
        [DataMember]
        public string VolumetricChartBarStatisticsShowDeltaDelta { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartBarStatisticsShowDeltaMax.
        /// </summary>
        [DataMember]
        public string VolumetricChartBarStatisticsShowDeltaMax { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartBarStatisticsShowDeltaMin.
        /// </summary>
        [DataMember]
        public string VolumetricChartBarStatisticsShowDeltaMin { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartBarStatisticsShowDeltaPct.
        /// </summary>
        [DataMember]
        public string VolumetricChartBarStatisticsShowDeltaPct { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartBarStatisticsShowDeltaSh.
        /// </summary>
        [DataMember]
        public string VolumetricChartBarStatisticsShowDeltaSh { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartBarStatisticsShowDeltaSl.
        /// </summary>
        [DataMember]
        public string VolumetricChartBarStatisticsShowDeltaSl { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartBarStatisticsShowSellVolume.
        /// </summary>
        [DataMember]
        public string VolumetricChartBarStatisticsShowSellVolume { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartBarStatisticsShowTrades.
        /// </summary>
        [DataMember]
        public string VolumetricChartBarStatisticsShowTrades { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartBarStatisticsShowVolume.
        /// </summary>
        [DataMember]
        public string VolumetricChartBarStatisticsShowVolume { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartBarStatisticsStatGrid.
        /// </summary>
        [DataMember]
        public string VolumetricChartBarStatisticsStatGrid { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartBarStatisticsTrades.
        /// </summary>
        [DataMember]
        public string VolumetricChartBarStatisticsTrades { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartBarStatisticsVolume.
        /// </summary>
        [DataMember]
        public string VolumetricChartBarStatisticsVolume { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartCenterOpenClose.
        /// </summary>
        [DataMember]
        public string VolumetricChartCenterOpenClose { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartColorDominantSide.
        /// </summary>
        [DataMember]
        public string VolumetricChartColorDominantSide { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartHideText.
        /// </summary>
        [DataMember]
        public string VolumetricChartHideText { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartShowAsProfile.
        /// </summary>
        [DataMember]
        public string VolumetricChartShowAsProfile { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartShowBarStatistics.
        /// </summary>
        [DataMember]
        public string VolumetricChartShowBarStatistics { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartShowImbalance.
        /// </summary>
        [DataMember]
        public string VolumetricChartShowImbalance { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartShowVolume.
        /// </summary>
        [DataMember]
        public string VolumetricChartShowVolume { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartStyleBaseBrush.
        /// </summary>
        [DataMember]
        public string VolumetricChartStyleBaseBrush { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartStyleBoxGrid.
        /// </summary>
        [DataMember]
        public string VolumetricChartStyleBoxGrid { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartStyleBoxOutline.
        /// </summary>
        [DataMember]
        public string VolumetricChartStyleBoxOutline { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartStyleBuyImbalancBrush.
        /// </summary>
        [DataMember]
        public string VolumetricChartStyleBuyImbalancBrush { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartStyleDojiBrush.
        /// </summary>
        [DataMember]
        public string VolumetricChartStyleDojiBrush { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartStyleGradientDepth.
        /// </summary>
        [DataMember]
        public string VolumetricChartStyleGradientDepth { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartStyleImbalanceBuyBrush.
        /// </summary>
        [DataMember]
        public string VolumetricChartStyleImbalanceBuyBrush { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartStyleImbalanceRatio.
        /// </summary>
        [DataMember]
        public string VolumetricChartStyleImbalanceRatio { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartStyleImbalanceSellBrush.
        /// </summary>
        [DataMember]
        public string VolumetricChartStyleImbalanceSellBrush { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartStyleMaxBrush.
        /// </summary>
        [DataMember]
        public string VolumetricChartStyleMaxBrush { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartStyleMinDelta.
        /// </summary>
        [DataMember]
        public string VolumetricChartStyleMinDelta { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartStyleNegativeStrengthBrush.
        /// </summary>
        [DataMember]
        public string VolumetricChartStyleNegativeStrengthBrush { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartStylePositiveStrengthBrush.
        /// </summary>
        [DataMember]
        public string VolumetricChartStylePositiveStrengthBrush { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartStyleSellImbalancBrush.
        /// </summary>
        [DataMember]
        public string VolumetricChartStyleSellImbalancBrush { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartStyleShowMaximum.
        /// </summary>
        [DataMember]
        public string VolumetricChartStyleShowMaximum { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartStyleSizeDisplayFilter.
        /// </summary>
        [DataMember]
        public string VolumetricChartStyleSizeDisplayFilter { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartStyleStatGrid.
        /// </summary>
        [DataMember]
        public string VolumetricChartStyleStatGrid { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartStyleTextBrush.
        /// </summary>
        [DataMember]
        public string VolumetricChartStyleTextBrush { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartStyleType.
        /// </summary>
        [DataMember]
        public string VolumetricChartStyleType { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartStyleVolBrush.
        /// </summary>
        [DataMember]
        public string VolumetricChartStyleVolBrush { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricImbalanceMode.
        /// </summary>
        [DataMember]
        public string VolumetricImbalanceMode { get; set; }
        /// <summary>
        /// Gets or sets the VWAPPlotStdDev1Lower.
        /// </summary>
        [DataMember]
        public string VWAPPlotStdDev1Lower { get; set; }
        /// <summary>
        /// Gets or sets the VWAPPlotStdDev1Upper.
        /// </summary>
        [DataMember]
        public string VWAPPlotStdDev1Upper { get; set; }
        /// <summary>
        /// Gets or sets the VWAPPlotStdDev2Lower.
        /// </summary>
        [DataMember]
        public string VWAPPlotStdDev2Lower { get; set; }
        /// <summary>
        /// Gets or sets the VWAPPlotStdDev2Upper.
        /// </summary>
        [DataMember]
        public string VWAPPlotStdDev2Upper { get; set; }
        /// <summary>
        /// Gets or sets the VWAPPlotStdDev3Lower.
        /// </summary>
        [DataMember]
        public string VWAPPlotStdDev3Lower { get; set; }
        /// <summary>
        /// Gets or sets the VWAPPlotStdDev3Upper.
        /// </summary>
        [DataMember]
        public string VWAPPlotStdDev3Upper { get; set; }
        /// <summary>
        /// Gets or sets the VWAPResetInterval_Month.
        /// </summary>
        [DataMember]
        public string VWAPResetInterval_Month { get; set; }
        /// <summary>
        /// Gets or sets the VWAPResetInterval_Session.
        /// </summary>
        [DataMember]
        public string VWAPResetInterval_Session { get; set; }
        /// <summary>
        /// Gets or sets the VWAPResetInterval_Week.
        /// </summary>
        [DataMember]
        public string VWAPResetInterval_Week { get; set; }
        /// <summary>
        /// Gets or sets the VWAPResolution_Standard.
        /// </summary>
        [DataMember]
        public string VWAPResolution_Standard { get; set; }
        /// <summary>
        /// Gets or sets the VWAPResolution_Tick.
        /// </summary>
        [DataMember]
        public string VWAPResolution_Tick { get; set; }
        /// <summary>
        /// Gets or sets the VWAPStandardDeviations_None.
        /// </summary>
        [DataMember]
        public string VWAPStandardDeviations_None { get; set; }
        /// <summary>
        /// Gets or sets the VWAPStandardDeviations_One.
        /// </summary>
        [DataMember]
        public string VWAPStandardDeviations_One { get; set; }
        /// <summary>
        /// Gets or sets the VWAPStandardDeviations_Three.
        /// </summary>
        [DataMember]
        public string VWAPStandardDeviations_Three { get; set; }
        /// <summary>
        /// Gets or sets the VWAPStandardDeviations_Two.
        /// </summary>
        [DataMember]
        public string VWAPStandardDeviations_Two { get; set; }
        /// <summary>
        /// Gets or sets the VWAPStandardDeviations_Zero.
        /// </summary>
        [DataMember]
        public string VWAPStandardDeviations_Zero { get; set; }
        /// <summary>
        /// Gets or sets the WickStroke.
        /// </summary>
        [DataMember]
        public string WickStroke { get; set; }
        /// <summary>
        /// Gets or sets the WisemanAlligatorPlot1.
        /// </summary>
        [DataMember]
        public string WisemanAlligatorPlot1 { get; set; }
        /// <summary>
        /// Gets or sets the WisemanAlligatorPlot2.
        /// </summary>
        [DataMember]
        public string WisemanAlligatorPlot2 { get; set; }
        /// <summary>
        /// Gets or sets the WisemanAlligatorPlot3.
        /// </summary>
        [DataMember]
        public string WisemanAlligatorPlot3 { get; set; }
        /// <summary>
        /// Gets or sets the WoodiesCCIInsufficientPanelData.
        /// </summary>
        [DataMember]
        public string WoodiesCCIInsufficientPanelData { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
