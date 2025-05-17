[Serializable]
[DataContract]
namespace NinjaTrader.Custom
{
    public partial class Resource
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
        /// Gets or sets the Acceleration.
        /// </summary>
        [DataMember]
        public String Acceleration { get; set; }
        /// <summary>
        /// Gets or sets the AccelerationMax.
        /// </summary>
        [DataMember]
        public String AccelerationMax { get; set; }
        /// <summary>
        /// Gets or sets the AccelerationStep.
        /// </summary>
        [DataMember]
        public String AccelerationStep { get; set; }
        /// <summary>
        /// Gets or sets the ADLAD.
        /// </summary>
        [DataMember]
        public String ADLAD { get; set; }
        /// <summary>
        /// Gets or sets the AlertOnBreak.
        /// </summary>
        [DataMember]
        public String AlertOnBreak { get; set; }
        /// <summary>
        /// Gets or sets the AlertOnBreakSound.
        /// </summary>
        [DataMember]
        public String AlertOnBreakSound { get; set; }
        /// <summary>
        /// Gets or sets the AndrewsPitchforkCalculationMethod_ModifiedSchiff.
        /// </summary>
        [DataMember]
        public String AndrewsPitchforkCalculationMethod_ModifiedSchiff { get; set; }
        /// <summary>
        /// Gets or sets the AndrewsPitchforkCalculationMethod_Schiff.
        /// </summary>
        [DataMember]
        public String AndrewsPitchforkCalculationMethod_Schiff { get; set; }
        /// <summary>
        /// Gets or sets the AndrewsPitchforkCalculationMethod_StandardPitchfork.
        /// </summary>
        [DataMember]
        public String AndrewsPitchforkCalculationMethod_StandardPitchfork { get; set; }
        /// <summary>
        /// Gets or sets the AskLineLength.
        /// </summary>
        [DataMember]
        public String AskLineLength { get; set; }
        /// <summary>
        /// Gets or sets the AskLineStroke.
        /// </summary>
        [DataMember]
        public String AskLineStroke { get; set; }
        /// <summary>
        /// Gets or sets the AuthDisclosureText1.
        /// </summary>
        [DataMember]
        public String AuthDisclosureText1 { get; set; }
        /// <summary>
        /// Gets or sets the AuthDisclosureText2.
        /// </summary>
        [DataMember]
        public String AuthDisclosureText2 { get; set; }
        /// <summary>
        /// Gets or sets the BandPct.
        /// </summary>
        [DataMember]
        public String BandPct { get; set; }
        /// <summary>
        /// Gets or sets the BarCount.
        /// </summary>
        [DataMember]
        public String BarCount { get; set; }
        /// <summary>
        /// Gets or sets the BarDown.
        /// </summary>
        [DataMember]
        public String BarDown { get; set; }
        /// <summary>
        /// Gets or sets the BarSpacing.
        /// </summary>
        [DataMember]
        public String BarSpacing { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodType.
        /// </summary>
        [DataMember]
        public String BarsPeriodType { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodTypeNameDay.
        /// </summary>
        [DataMember]
        public String BarsPeriodTypeNameDay { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodTypeNameHeikenAshi.
        /// </summary>
        [DataMember]
        public String BarsPeriodTypeNameHeikenAshi { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodTypeNameKagi.
        /// </summary>
        [DataMember]
        public String BarsPeriodTypeNameKagi { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodTypeNameLineBreak.
        /// </summary>
        [DataMember]
        public String BarsPeriodTypeNameLineBreak { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodTypeNameMinute.
        /// </summary>
        [DataMember]
        public String BarsPeriodTypeNameMinute { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodTypeNameMonth.
        /// </summary>
        [DataMember]
        public String BarsPeriodTypeNameMonth { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodTypeNamePointAndFigure.
        /// </summary>
        [DataMember]
        public String BarsPeriodTypeNamePointAndFigure { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodTypeNameRange.
        /// </summary>
        [DataMember]
        public String BarsPeriodTypeNameRange { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodTypeNameRenko.
        /// </summary>
        [DataMember]
        public String BarsPeriodTypeNameRenko { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodTypeNameSecond.
        /// </summary>
        [DataMember]
        public String BarsPeriodTypeNameSecond { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodTypeNameTick.
        /// </summary>
        [DataMember]
        public String BarsPeriodTypeNameTick { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodTypeNameVolume.
        /// </summary>
        [DataMember]
        public String BarsPeriodTypeNameVolume { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodTypeNameWeek.
        /// </summary>
        [DataMember]
        public String BarsPeriodTypeNameWeek { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodTypeNameYear.
        /// </summary>
        [DataMember]
        public String BarsPeriodTypeNameYear { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodValue.
        /// </summary>
        [DataMember]
        public String BarsPeriodValue { get; set; }
        /// <summary>
        /// Gets or sets the BarTimerDisconnectedError.
        /// </summary>
        [DataMember]
        public String BarTimerDisconnectedError { get; set; }
        /// <summary>
        /// Gets or sets the BarTimerSessionTimeError.
        /// </summary>
        [DataMember]
        public String BarTimerSessionTimeError { get; set; }
        /// <summary>
        /// Gets or sets the BarTimerTimeBasedError.
        /// </summary>
        [DataMember]
        public String BarTimerTimeBasedError { get; set; }
        /// <summary>
        /// Gets or sets the BarTimerTimeRemaining.
        /// </summary>
        [DataMember]
        public String BarTimerTimeRemaining { get; set; }
        /// <summary>
        /// Gets or sets the BarTimerWaitingOnDataError.
        /// </summary>
        [DataMember]
        public String BarTimerWaitingOnDataError { get; set; }
        /// <summary>
        /// Gets or sets the BarUp.
        /// </summary>
        [DataMember]
        public String BarUp { get; set; }
        /// <summary>
        /// Gets or sets the BasePeriod.
        /// </summary>
        [DataMember]
        public String BasePeriod { get; set; }
        /// <summary>
        /// Gets or sets the BidLineLength.
        /// </summary>
        [DataMember]
        public String BidLineLength { get; set; }
        /// <summary>
        /// Gets or sets the BidLineStroke.
        /// </summary>
        [DataMember]
        public String BidLineStroke { get; set; }
        /// <summary>
        /// Gets or sets the BlockTradeSize.
        /// </summary>
        [DataMember]
        public String BlockTradeSize { get; set; }
        /// <summary>
        /// Gets or sets the BollingerLowerBand.
        /// </summary>
        [DataMember]
        public String BollingerLowerBand { get; set; }
        /// <summary>
        /// Gets or sets the BollingerMiddleBand.
        /// </summary>
        [DataMember]
        public String BollingerMiddleBand { get; set; }
        /// <summary>
        /// Gets or sets the BollingerUpperBand.
        /// </summary>
        [DataMember]
        public String BollingerUpperBand { get; set; }
        /// <summary>
        /// Gets or sets the BuySellPressureBuyPressure.
        /// </summary>
        [DataMember]
        public String BuySellPressureBuyPressure { get; set; }
        /// <summary>
        /// Gets or sets the BuySellPressureSellPressure.
        /// </summary>
        [DataMember]
        public String BuySellPressureSellPressure { get; set; }
        /// <summary>
        /// Gets or sets the BuySellVolumeBuys.
        /// </summary>
        [DataMember]
        public String BuySellVolumeBuys { get; set; }
        /// <summary>
        /// Gets or sets the BuySellVolumeSells.
        /// </summary>
        [DataMember]
        public String BuySellVolumeSells { get; set; }
        /// <summary>
        /// Gets or sets the CandlestickPatternFound.
        /// </summary>
        [DataMember]
        public String CandlestickPatternFound { get; set; }
        /// <summary>
        /// Gets or sets the CCILevel1.
        /// </summary>
        [DataMember]
        public String CCILevel1 { get; set; }
        /// <summary>
        /// Gets or sets the CCILevel2.
        /// </summary>
        [DataMember]
        public String CCILevel2 { get; set; }
        /// <summary>
        /// Gets or sets the CCILevelMinus1.
        /// </summary>
        [DataMember]
        public String CCILevelMinus1 { get; set; }
        /// <summary>
        /// Gets or sets the CCILevelMinus2.
        /// </summary>
        [DataMember]
        public String CCILevelMinus2 { get; set; }
        /// <summary>
        /// Gets or sets the ChartSpan_Day.
        /// </summary>
        [DataMember]
        public String ChartSpan_Day { get; set; }
        /// <summary>
        /// Gets or sets the ChartSpan_Min1.
        /// </summary>
        [DataMember]
        public String ChartSpan_Min1 { get; set; }
        /// <summary>
        /// Gets or sets the ChartSpan_Min15.
        /// </summary>
        [DataMember]
        public String ChartSpan_Min15 { get; set; }
        /// <summary>
        /// Gets or sets the ChartSpan_Min240.
        /// </summary>
        [DataMember]
        public String ChartSpan_Min240 { get; set; }
        /// <summary>
        /// Gets or sets the ChartSpan_Min30.
        /// </summary>
        [DataMember]
        public String ChartSpan_Min30 { get; set; }
        /// <summary>
        /// Gets or sets the ChartSpan_Min5.
        /// </summary>
        [DataMember]
        public String ChartSpan_Min5 { get; set; }
        /// <summary>
        /// Gets or sets the ChartSpan_Min60.
        /// </summary>
        [DataMember]
        public String ChartSpan_Min60 { get; set; }
        /// <summary>
        /// Gets or sets the ChartSpan_Month.
        /// </summary>
        [DataMember]
        public String ChartSpan_Month { get; set; }
        /// <summary>
        /// Gets or sets the ChartSpan_Week.
        /// </summary>
        [DataMember]
        public String ChartSpan_Week { get; set; }
        /// <summary>
        /// Gets or sets the ChartSpan_Year.
        /// </summary>
        [DataMember]
        public String ChartSpan_Year { get; set; }
        /// <summary>
        /// Gets or sets the ConstantLines1.
        /// </summary>
        [DataMember]
        public String ConstantLines1 { get; set; }
        /// <summary>
        /// Gets or sets the ConstantLines2.
        /// </summary>
        [DataMember]
        public String ConstantLines2 { get; set; }
        /// <summary>
        /// Gets or sets the ConstantLines3.
        /// </summary>
        [DataMember]
        public String ConstantLines3 { get; set; }
        /// <summary>
        /// Gets or sets the ConstantLines4.
        /// </summary>
        [DataMember]
        public String ConstantLines4 { get; set; }
        /// <summary>
        /// Gets or sets the COT1.
        /// </summary>
        [DataMember]
        public String COT1 { get; set; }
        /// <summary>
        /// Gets or sets the COT2.
        /// </summary>
        [DataMember]
        public String COT2 { get; set; }
        /// <summary>
        /// Gets or sets the COT3.
        /// </summary>
        [DataMember]
        public String COT3 { get; set; }
        /// <summary>
        /// Gets or sets the COT4.
        /// </summary>
        [DataMember]
        public String COT4 { get; set; }
        /// <summary>
        /// Gets or sets the COT5.
        /// </summary>
        [DataMember]
        public String COT5 { get; set; }
        /// <summary>
        /// Gets or sets the CotDataError.
        /// </summary>
        [DataMember]
        public String CotDataError { get; set; }
        /// <summary>
        /// Gets or sets the CotDataStillDownloading.
        /// </summary>
        [DataMember]
        public String CotDataStillDownloading { get; set; }
        /// <summary>
        /// Gets or sets the CotDataWarning.
        /// </summary>
        [DataMember]
        public String CotDataWarning { get; set; }
        /// <summary>
        /// Gets or sets the CountDown.
        /// </summary>
        [DataMember]
        public String CountDown { get; set; }
        /// <summary>
        /// Gets or sets the CountType_Trades.
        /// </summary>
        [DataMember]
        public String CountType_Trades { get; set; }
        /// <summary>
        /// Gets or sets the CountType_Volume.
        /// </summary>
        [DataMember]
        public String CountType_Volume { get; set; }
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
        /// Gets or sets the CustomWindowAddOnBuyMarket.
        /// </summary>
        [DataMember]
        public String CustomWindowAddOnBuyMarket { get; set; }
        /// <summary>
        /// Gets or sets the CustomWindowAddOnSellMarket.
        /// </summary>
        [DataMember]
        public String CustomWindowAddOnSellMarket { get; set; }
        /// <summary>
        /// Gets or sets the CustomWindowSampleDescription.
        /// </summary>
        [DataMember]
        public String CustomWindowSampleDescription { get; set; }
        /// <summary>
        /// Gets or sets the CustomWindowSampleName.
        /// </summary>
        [DataMember]
        public String CustomWindowSampleName { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsTypeDaily.
        /// </summary>
        [DataMember]
        public String DataBarsTypeDaily { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsTypeDay.
        /// </summary>
        [DataMember]
        public String DataBarsTypeDay { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsTypeMinute.
        /// </summary>
        [DataMember]
        public String DataBarsTypeMinute { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsTypeMonth.
        /// </summary>
        [DataMember]
        public String DataBarsTypeMonth { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsTypeMonthly.
        /// </summary>
        [DataMember]
        public String DataBarsTypeMonthly { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsTypePointAndFigure.
        /// </summary>
        [DataMember]
        public String DataBarsTypePointAndFigure { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsTypeRange.
        /// </summary>
        [DataMember]
        public String DataBarsTypeRange { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsTypeRenko.
        /// </summary>
        [DataMember]
        public String DataBarsTypeRenko { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsTypeSecond.
        /// </summary>
        [DataMember]
        public String DataBarsTypeSecond { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsTypeTick.
        /// </summary>
        [DataMember]
        public String DataBarsTypeTick { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsTypeVolume.
        /// </summary>
        [DataMember]
        public String DataBarsTypeVolume { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsTypeWeek.
        /// </summary>
        [DataMember]
        public String DataBarsTypeWeek { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsTypeWeekly.
        /// </summary>
        [DataMember]
        public String DataBarsTypeWeekly { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsTypeYear.
        /// </summary>
        [DataMember]
        public String DataBarsTypeYear { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsTypeYearly.
        /// </summary>
        [DataMember]
        public String DataBarsTypeYearly { get; set; }
        /// <summary>
        /// Gets or sets the Day.
        /// </summary>
        [DataMember]
        public String Day { get; set; }
        /// <summary>
        /// Gets or sets the Days.
        /// </summary>
        [DataMember]
        public String Days { get; set; }
        /// <summary>
        /// Gets or sets the DeviationType.
        /// </summary>
        [DataMember]
        public String DeviationType { get; set; }
        /// <summary>
        /// Gets or sets the DeviationValue.
        /// </summary>
        [DataMember]
        public String DeviationValue { get; set; }
        /// <summary>
        /// Gets or sets the DMMinusDI.
        /// </summary>
        [DataMember]
        public String DMMinusDI { get; set; }
        /// <summary>
        /// Gets or sets the DMPlusDI.
        /// </summary>
        [DataMember]
        public String DMPlusDI { get; set; }
        /// <summary>
        /// Gets or sets the DonchianChannelMean.
        /// </summary>
        [DataMember]
        public String DonchianChannelMean { get; set; }
        /// <summary>
        /// Gets or sets the DownBarColor.
        /// </summary>
        [DataMember]
        public String DownBarColor { get; set; }
        /// <summary>
        /// Gets or sets the DrawingToolIndicatorDescription.
        /// </summary>
        [DataMember]
        public String DrawingToolIndicatorDescription { get; set; }
        /// <summary>
        /// Gets or sets the DrawingToolIndicatorName.
        /// </summary>
        [DataMember]
        public String DrawingToolIndicatorName { get; set; }
        /// <summary>
        /// Gets or sets the DrawLines.
        /// </summary>
        [DataMember]
        public String DrawLines { get; set; }
        /// <summary>
        /// Gets or sets the EMA1.
        /// </summary>
        [DataMember]
        public String EMA1 { get; set; }
        /// <summary>
        /// Gets or sets the EMA2.
        /// </summary>
        [DataMember]
        public String EMA2 { get; set; }
        /// <summary>
        /// Gets or sets the EmailSignature.
        /// </summary>
        [DataMember]
        public String EmailSignature { get; set; }
        /// <summary>
        /// Gets or sets the EnvelopePercentage.
        /// </summary>
        [DataMember]
        public String EnvelopePercentage { get; set; }
        /// <summary>
        /// Gets or sets the FacebookServiceName.
        /// </summary>
        [DataMember]
        public String FacebookServiceName { get; set; }
        /// <summary>
        /// Gets or sets the FacebookSignature.
        /// </summary>
        [DataMember]
        public String FacebookSignature { get; set; }
        /// <summary>
        /// Gets or sets the Fast.
        /// </summary>
        [DataMember]
        public String Fast { get; set; }
        /// <summary>
        /// Gets or sets the FastLimit.
        /// </summary>
        [DataMember]
        public String FastLimit { get; set; }
        /// <summary>
        /// Gets or sets the FastPeriod.
        /// </summary>
        [DataMember]
        public String FastPeriod { get; set; }
        /// <summary>
        /// Gets or sets the FibonacciTextAlignment_ExtremeLeft.
        /// </summary>
        [DataMember]
        public String FibonacciTextAlignment_ExtremeLeft { get; set; }
        /// <summary>
        /// Gets or sets the FibonacciTextAlignment_ExtremeRight.
        /// </summary>
        [DataMember]
        public String FibonacciTextAlignment_ExtremeRight { get; set; }
        /// <summary>
        /// Gets or sets the FibonacciTextAlignment_Left.
        /// </summary>
        [DataMember]
        public String FibonacciTextAlignment_Left { get; set; }
        /// <summary>
        /// Gets or sets the FibonacciTextAlignment_Off.
        /// </summary>
        [DataMember]
        public String FibonacciTextAlignment_Off { get; set; }
        /// <summary>
        /// Gets or sets the FibonacciTextAlignment_Right.
        /// </summary>
        [DataMember]
        public String FibonacciTextAlignment_Right { get; set; }
        /// <summary>
        /// Gets or sets the FileFilterAnyLoadingDialog.
        /// </summary>
        [DataMember]
        public String FileFilterAnyLoadingDialog { get; set; }
        /// <summary>
        /// Gets or sets the FileFilterAnyWinForms.
        /// </summary>
        [DataMember]
        public String FileFilterAnyWinForms { get; set; }
        /// <summary>
        /// Gets or sets the FileName.
        /// </summary>
        [DataMember]
        public String FileName { get; set; }
        /// <summary>
        /// Gets or sets the Font.
        /// </summary>
        [DataMember]
        public String Font { get; set; }
        /// <summary>
        /// Gets or sets the Forecast.
        /// </summary>
        [DataMember]
        public String Forecast { get; set; }
        /// <summary>
        /// Gets or sets the GannFanDirection_DownLeft.
        /// </summary>
        [DataMember]
        public String GannFanDirection_DownLeft { get; set; }
        /// <summary>
        /// Gets or sets the GannFanDirection_DownRight.
        /// </summary>
        [DataMember]
        public String GannFanDirection_DownRight { get; set; }
        /// <summary>
        /// Gets or sets the GannFanDirection_UpLeft.
        /// </summary>
        [DataMember]
        public String GannFanDirection_UpLeft { get; set; }
        /// <summary>
        /// Gets or sets the GannFanDirection_UpRight.
        /// </summary>
        [DataMember]
        public String GannFanDirection_UpRight { get; set; }
        /// <summary>
        /// Gets or sets the GuiAuthorize.
        /// </summary>
        [DataMember]
        public String GuiAuthorize { get; set; }
        /// <summary>
        /// Gets or sets the GuiChartStyleDojiBrush.
        /// </summary>
        [DataMember]
        public String GuiChartStyleDojiBrush { get; set; }
        /// <summary>
        /// Gets or sets the HigherHigh.
        /// </summary>
        [DataMember]
        public String HigherHigh { get; set; }
        /// <summary>
        /// Gets or sets the HigherLow.
        /// </summary>
        [DataMember]
        public String HigherLow { get; set; }
        /// <summary>
        /// Gets or sets the HighlightVerticalRangeUnit_Currency.
        /// </summary>
        [DataMember]
        public String HighlightVerticalRangeUnit_Currency { get; set; }
        /// <summary>
        /// Gets or sets the HighlightVerticalRangeUnit_Percent.
        /// </summary>
        [DataMember]
        public String HighlightVerticalRangeUnit_Percent { get; set; }
        /// <summary>
        /// Gets or sets the HighlightVerticalRangeUnit_Pips.
        /// </summary>
        [DataMember]
        public String HighlightVerticalRangeUnit_Pips { get; set; }
        /// <summary>
        /// Gets or sets the HighlightVerticalRangeUnit_Price.
        /// </summary>
        [DataMember]
        public String HighlightVerticalRangeUnit_Price { get; set; }
        /// <summary>
        /// Gets or sets the HighlightVerticalRangeUnit_Ticks.
        /// </summary>
        [DataMember]
        public String HighlightVerticalRangeUnit_Ticks { get; set; }
        /// <summary>
        /// Gets or sets the HLCCalculationMode.
        /// </summary>
        [DataMember]
        public String HLCCalculationMode { get; set; }
        /// <summary>
        /// Gets or sets the HLCCalculationMode_CalcFromIntradayData.
        /// </summary>
        [DataMember]
        public String HLCCalculationMode_CalcFromIntradayData { get; set; }
        /// <summary>
        /// Gets or sets the HLCCalculationMode_DailyBars.
        /// </summary>
        [DataMember]
        public String HLCCalculationMode_DailyBars { get; set; }
        /// <summary>
        /// Gets or sets the HLCCalculationMode_UserDefinedValues.
        /// </summary>
        [DataMember]
        public String HLCCalculationMode_UserDefinedValues { get; set; }
        /// <summary>
        /// Gets or sets the HLCCalculationModeDescription.
        /// </summary>
        [DataMember]
        public String HLCCalculationModeDescription { get; set; }
        /// <summary>
        /// Gets or sets the Import.
        /// </summary>
        [DataMember]
        public String Import { get; set; }
        /// <summary>
        /// Gets or sets the ImportTypeNinjaTraderBeginningOfBar.
        /// </summary>
        [DataMember]
        public String ImportTypeNinjaTraderBeginningOfBar { get; set; }
        /// <summary>
        /// Gets or sets the ImportTypeNinjaTraderDateTimeFormatError.
        /// </summary>
        [DataMember]
        public String ImportTypeNinjaTraderDateTimeFormatError { get; set; }
        /// <summary>
        /// Gets or sets the ImportTypeNinjaTraderEndOfBar.
        /// </summary>
        [DataMember]
        public String ImportTypeNinjaTraderEndOfBar { get; set; }
        /// <summary>
        /// Gets or sets the ImportTypeNinjaTraderFieldSeparatorNotIdentified.
        /// </summary>
        [DataMember]
        public String ImportTypeNinjaTraderFieldSeparatorNotIdentified { get; set; }
        /// <summary>
        /// Gets or sets the ImportTypeNinjaTraderFormatError.
        /// </summary>
        [DataMember]
        public String ImportTypeNinjaTraderFormatError { get; set; }
        /// <summary>
        /// Gets or sets the ImportTypeNinjaTraderInstrumentNotSupported.
        /// </summary>
        [DataMember]
        public String ImportTypeNinjaTraderInstrumentNotSupported { get; set; }
        /// <summary>
        /// Gets or sets the ImportTypeNinjaTraderNumericPriceFormatError.
        /// </summary>
        [DataMember]
        public String ImportTypeNinjaTraderNumericPriceFormatError { get; set; }
        /// <summary>
        /// Gets or sets the ImportTypeNinjaTraderUnableReadData.
        /// </summary>
        [DataMember]
        public String ImportTypeNinjaTraderUnableReadData { get; set; }
        /// <summary>
        /// Gets or sets the ImportTypeNinjaTraderUnexpectedFieldNumber.
        /// </summary>
        [DataMember]
        public String ImportTypeNinjaTraderUnexpectedFieldNumber { get; set; }
        /// <summary>
        /// Gets or sets the ImportTypeTickData.
        /// </summary>
        [DataMember]
        public String ImportTypeTickData { get; set; }
        /// <summary>
        /// Gets or sets the IncrementalPeriod.
        /// </summary>
        [DataMember]
        public String IncrementalPeriod { get; set; }
        /// <summary>
        /// Gets or sets the Intermediate.
        /// </summary>
        [DataMember]
        public String Intermediate { get; set; }
        /// <summary>
        /// Gets or sets the Interval.
        /// </summary>
        [DataMember]
        public String Interval { get; set; }
        /// <summary>
        /// Gets or sets the KeltnerChannelMidline.
        /// </summary>
        [DataMember]
        public String KeltnerChannelMidline { get; set; }
        /// <summary>
        /// Gets or sets the KeyReversalPlot0.
        /// </summary>
        [DataMember]
        public String KeyReversalPlot0 { get; set; }
        /// <summary>
        /// Gets or sets the LastLineLength.
        /// </summary>
        [DataMember]
        public String LastLineLength { get; set; }
        /// <summary>
        /// Gets or sets the LastLineStroke.
        /// </summary>
        [DataMember]
        public String LastLineStroke { get; set; }
        /// <summary>
        /// Gets or sets the LegendLocation.
        /// </summary>
        [DataMember]
        public String LegendLocation { get; set; }
        /// <summary>
        /// Gets or sets the LegendLocation_BottomLeft.
        /// </summary>
        [DataMember]
        public String LegendLocation_BottomLeft { get; set; }
        /// <summary>
        /// Gets or sets the LegendLocation_BottomRight.
        /// </summary>
        [DataMember]
        public String LegendLocation_BottomRight { get; set; }
        /// <summary>
        /// Gets or sets the LegendLocation_Disabled.
        /// </summary>
        [DataMember]
        public String LegendLocation_Disabled { get; set; }
        /// <summary>
        /// Gets or sets the LegendLocation_TopLeft.
        /// </summary>
        [DataMember]
        public String LegendLocation_TopLeft { get; set; }
        /// <summary>
        /// Gets or sets the LegendLocation_TopRight.
        /// </summary>
        [DataMember]
        public String LegendLocation_TopRight { get; set; }
        /// <summary>
        /// Gets or sets the Length.
        /// </summary>
        [DataMember]
        public String Length { get; set; }
        /// <summary>
        /// Gets or sets the Line1Value.
        /// </summary>
        [DataMember]
        public String Line1Value { get; set; }
        /// <summary>
        /// Gets or sets the Line2Value.
        /// </summary>
        [DataMember]
        public String Line2Value { get; set; }
        /// <summary>
        /// Gets or sets the Line3Value.
        /// </summary>
        [DataMember]
        public String Line3Value { get; set; }
        /// <summary>
        /// Gets or sets the Line4Value.
        /// </summary>
        [DataMember]
        public String Line4Value { get; set; }
        /// <summary>
        /// Gets or sets the LineColor.
        /// </summary>
        [DataMember]
        public String LineColor { get; set; }
        /// <summary>
        /// Gets or sets the Load.
        /// </summary>
        [DataMember]
        public String Load { get; set; }
        /// <summary>
        /// Gets or sets the Location.
        /// </summary>
        [DataMember]
        public String Location { get; set; }
        /// <summary>
        /// Gets or sets the LowerHigh.
        /// </summary>
        [DataMember]
        public String LowerHigh { get; set; }
        /// <summary>
        /// Gets or sets the LowerLow.
        /// </summary>
        [DataMember]
        public String LowerLow { get; set; }
        /// <summary>
        /// Gets or sets the MailCcAddress.
        /// </summary>
        [DataMember]
        public String MailCcAddress { get; set; }
        /// <summary>
        /// Gets or sets the MailCcAddressDescription.
        /// </summary>
        [DataMember]
        public String MailCcAddressDescription { get; set; }
        /// <summary>
        /// Gets or sets the MailServiceMailAddress.
        /// </summary>
        [DataMember]
        public String MailServiceMailAddress { get; set; }
        /// <summary>
        /// Gets or sets the MailServiceName.
        /// </summary>
        [DataMember]
        public String MailServiceName { get; set; }
        /// <summary>
        /// Gets or sets the MailServicePort.
        /// </summary>
        [DataMember]
        public String MailServicePort { get; set; }
        /// <summary>
        /// Gets or sets the MailServiceSenderDisplayName.
        /// </summary>
        [DataMember]
        public String MailServiceSenderDisplayName { get; set; }
        /// <summary>
        /// Gets or sets the MailServiceServer.
        /// </summary>
        [DataMember]
        public String MailServiceServer { get; set; }
        /// <summary>
        /// Gets or sets the MailServiceSSL.
        /// </summary>
        [DataMember]
        public String MailServiceSSL { get; set; }
        /// <summary>
        /// Gets or sets the MailSubject.
        /// </summary>
        [DataMember]
        public String MailSubject { get; set; }
        /// <summary>
        /// Gets or sets the MailSubjectDescription.
        /// </summary>
        [DataMember]
        public String MailSubjectDescription { get; set; }
        /// <summary>
        /// Gets or sets the MailToAddress.
        /// </summary>
        [DataMember]
        public String MailToAddress { get; set; }
        /// <summary>
        /// Gets or sets the MailToAddressDescription.
        /// </summary>
        [DataMember]
        public String MailToAddressDescription { get; set; }
        /// <summary>
        /// Gets or sets the MAMAFAMA.
        /// </summary>
        [DataMember]
        public String MAMAFAMA { get; set; }
        /// <summary>
        /// Gets or sets the MAPeriod.
        /// </summary>
        [DataMember]
        public String MAPeriod { get; set; }
        /// <summary>
        /// Gets or sets the MAType.
        /// </summary>
        [DataMember]
        public String MAType { get; set; }
        /// <summary>
        /// Gets or sets the MovingAverage.
        /// </summary>
        [DataMember]
        public String MovingAverage { get; set; }
        /// <summary>
        /// Gets or sets the MovingAverageRibbonPlot1.
        /// </summary>
        [DataMember]
        public String MovingAverageRibbonPlot1 { get; set; }
        /// <summary>
        /// Gets or sets the MovingAverageRibbonPlot2.
        /// </summary>
        [DataMember]
        public String MovingAverageRibbonPlot2 { get; set; }
        /// <summary>
        /// Gets or sets the MovingAverageRibbonPlot3.
        /// </summary>
        [DataMember]
        public String MovingAverageRibbonPlot3 { get; set; }
        /// <summary>
        /// Gets or sets the MovingAverageRibbonPlot4.
        /// </summary>
        [DataMember]
        public String MovingAverageRibbonPlot4 { get; set; }
        /// <summary>
        /// Gets or sets the MovingAverageRibbonPlot5.
        /// </summary>
        [DataMember]
        public String MovingAverageRibbonPlot5 { get; set; }
        /// <summary>
        /// Gets or sets the MovingAverageRibbonPlot6.
        /// </summary>
        [DataMember]
        public String MovingAverageRibbonPlot6 { get; set; }
        /// <summary>
        /// Gets or sets the MovingAverageRibbonPlot7.
        /// </summary>
        [DataMember]
        public String MovingAverageRibbonPlot7 { get; set; }
        /// <summary>
        /// Gets or sets the MovingAverageRibbonPlot8.
        /// </summary>
        [DataMember]
        public String MovingAverageRibbonPlot8 { get; set; }
        /// <summary>
        /// Gets or sets the NBarsDownTrigger.
        /// </summary>
        [DataMember]
        public String NBarsDownTrigger { get; set; }
        /// <summary>
        /// Gets or sets the NegativeColor.
        /// </summary>
        [DataMember]
        public String NegativeColor { get; set; }
        /// <summary>
        /// Gets or sets the NetChangePosition_BottomLeft.
        /// </summary>
        [DataMember]
        public String NetChangePosition_BottomLeft { get; set; }
        /// <summary>
        /// Gets or sets the NetChangePosition_BottomRight.
        /// </summary>
        [DataMember]
        public String NetChangePosition_BottomRight { get; set; }
        /// <summary>
        /// Gets or sets the NetChangePosition_TopLeft.
        /// </summary>
        [DataMember]
        public String NetChangePosition_TopLeft { get; set; }
        /// <summary>
        /// Gets or sets the NetChangePosition_TopRight.
        /// </summary>
        [DataMember]
        public String NetChangePosition_TopRight { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBackground.
        /// </summary>
        [DataMember]
        public String NinjaScriptBackground { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsTypeDay.
        /// </summary>
        [DataMember]
        public String NinjaScriptBarsTypeDay { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsTypeHeikenAshi.
        /// </summary>
        [DataMember]
        public String NinjaScriptBarsTypeHeikenAshi { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsTypeKagi.
        /// </summary>
        [DataMember]
        public String NinjaScriptBarsTypeKagi { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsTypeKagiReversal.
        /// </summary>
        [DataMember]
        public String NinjaScriptBarsTypeKagiReversal { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsTypeLineBreak.
        /// </summary>
        [DataMember]
        public String NinjaScriptBarsTypeLineBreak { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsTypeLineBreakLineBreaks.
        /// </summary>
        [DataMember]
        public String NinjaScriptBarsTypeLineBreakLineBreaks { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsTypeMinute.
        /// </summary>
        [DataMember]
        public String NinjaScriptBarsTypeMinute { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsTypeMonth.
        /// </summary>
        [DataMember]
        public String NinjaScriptBarsTypeMonth { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsTypePointAndFigure.
        /// </summary>
        [DataMember]
        public String NinjaScriptBarsTypePointAndFigure { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsTypePointAndFigureBoxSize.
        /// </summary>
        [DataMember]
        public String NinjaScriptBarsTypePointAndFigureBoxSize { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsTypePointAndFigureReversal.
        /// </summary>
        [DataMember]
        public String NinjaScriptBarsTypePointAndFigureReversal { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsTypeRange.
        /// </summary>
        [DataMember]
        public String NinjaScriptBarsTypeRange { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsTypeRenko.
        /// </summary>
        [DataMember]
        public String NinjaScriptBarsTypeRenko { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsTypeRenkoBrickSize.
        /// </summary>
        [DataMember]
        public String NinjaScriptBarsTypeRenkoBrickSize { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsTypeSecond.
        /// </summary>
        [DataMember]
        public String NinjaScriptBarsTypeSecond { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsTypeTick.
        /// </summary>
        [DataMember]
        public String NinjaScriptBarsTypeTick { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsTypeVolume.
        /// </summary>
        [DataMember]
        public String NinjaScriptBarsTypeVolume { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsTypeWeek.
        /// </summary>
        [DataMember]
        public String NinjaScriptBarsTypeWeek { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBorder.
        /// </summary>
        [DataMember]
        public String NinjaScriptBorder { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleBarWidth.
        /// </summary>
        [DataMember]
        public String NinjaScriptChartStyleBarWidth { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleBox.
        /// </summary>
        [DataMember]
        public String NinjaScriptChartStyleBox { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleBoxDownBarsColor.
        /// </summary>
        [DataMember]
        public String NinjaScriptChartStyleBoxDownBarsColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleBoxDownBarsOutline.
        /// </summary>
        [DataMember]
        public String NinjaScriptChartStyleBoxDownBarsOutline { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleBoxUpBarsColor.
        /// </summary>
        [DataMember]
        public String NinjaScriptChartStyleBoxUpBarsColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleBoxUpBarsOutline.
        /// </summary>
        [DataMember]
        public String NinjaScriptChartStyleBoxUpBarsOutline { get; set; }
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
        /// Gets or sets the NinjaScriptChartStyleCandlestick.
        /// </summary>
        [DataMember]
        public String NinjaScriptChartStyleCandlestick { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleCandlestickHollow.
        /// </summary>
        [DataMember]
        public String NinjaScriptChartStyleCandlestickHollow { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleCandleUpBarsColor.
        /// </summary>
        [DataMember]
        public String NinjaScriptChartStyleCandleUpBarsColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleCandleWick.
        /// </summary>
        [DataMember]
        public String NinjaScriptChartStyleCandleWick { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleEquivolume.
        /// </summary>
        [DataMember]
        public String NinjaScriptChartStyleEquivolume { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleHeikenAshi.
        /// </summary>
        [DataMember]
        public String NinjaScriptChartStyleHeikenAshi { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleKagi.
        /// </summary>
        [DataMember]
        public String NinjaScriptChartStyleKagi { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleKagiThickLine.
        /// </summary>
        [DataMember]
        public String NinjaScriptChartStyleKagiThickLine { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleKagiThinLine.
        /// </summary>
        [DataMember]
        public String NinjaScriptChartStyleKagiThinLine { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleLineOnClose.
        /// </summary>
        [DataMember]
        public String NinjaScriptChartStyleLineOnClose { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleLineOnCloseColor.
        /// </summary>
        [DataMember]
        public String NinjaScriptChartStyleLineOnCloseColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleLineOnCloseWidth.
        /// </summary>
        [DataMember]
        public String NinjaScriptChartStyleLineOnCloseWidth { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleLineWidth.
        /// </summary>
        [DataMember]
        public String NinjaScriptChartStyleLineWidth { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleMountain.
        /// </summary>
        [DataMember]
        public String NinjaScriptChartStyleMountain { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleMountainColor.
        /// </summary>
        [DataMember]
        public String NinjaScriptChartStyleMountainColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleMountainOutline.
        /// </summary>
        [DataMember]
        public String NinjaScriptChartStyleMountainOutline { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleOHLC.
        /// </summary>
        [DataMember]
        public String NinjaScriptChartStyleOHLC { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleOhlcDownBarsColor.
        /// </summary>
        [DataMember]
        public String NinjaScriptChartStyleOhlcDownBarsColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleOhlcUpBarsColor.
        /// </summary>
        [DataMember]
        public String NinjaScriptChartStyleOhlcUpBarsColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleOpenClose.
        /// </summary>
        [DataMember]
        public String NinjaScriptChartStyleOpenClose { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleOpenCloseDownBarsColor.
        /// </summary>
        [DataMember]
        public String NinjaScriptChartStyleOpenCloseDownBarsColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleOpenCloseDownBarsOutline.
        /// </summary>
        [DataMember]
        public String NinjaScriptChartStyleOpenCloseDownBarsOutline { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleOpenCloseUpBarsColor.
        /// </summary>
        [DataMember]
        public String NinjaScriptChartStyleOpenCloseUpBarsColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleOpenCloseUpBarsOutline.
        /// </summary>
        [DataMember]
        public String NinjaScriptChartStyleOpenCloseUpBarsOutline { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStylePointAndFigure.
        /// </summary>
        [DataMember]
        public String NinjaScriptChartStylePointAndFigure { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStylePointAndFigureDownColor.
        /// </summary>
        [DataMember]
        public String NinjaScriptChartStylePointAndFigureDownColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStylePointAndFigureUpColor.
        /// </summary>
        [DataMember]
        public String NinjaScriptChartStylePointAndFigureUpColor { get; set; }
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
        /// Gets or sets the NinjaScriptDrawingToolAnchorExtension.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolAnchorExtension { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolAnchorMiddle.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolAnchorMiddle { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolAnchorStart.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolAnchorStart { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolAnchorText.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolAnchorText { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolAndrewsPitchfork.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolAndrewsPitchfork { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolAndrewsPitchforkCalculationMethod.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolAndrewsPitchforkCalculationMethod { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolAndrewsPitchforkCategoryStrokes.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolAndrewsPitchforkCategoryStrokes { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolAndrewsPitchforkDescription.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolAndrewsPitchforkDescription { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolAndrewsPitchforkExtendLinesBack.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolAndrewsPitchforkExtendLinesBack { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolAndrewsPitchforkExtensionStroke.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolAndrewsPitchforkExtensionStroke { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolAndrewsPitchforkRetracement.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolAndrewsPitchforkRetracement { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolArc.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolArc { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolAreaOpacity.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolAreaOpacity { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolArrowLine.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolArrowLine { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolBackgroundOpacity.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolBackgroundOpacity { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolEllipse.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolEllipse { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolExtendedLine.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolExtendedLine { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolFibonacciCircle.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolFibonacciCircle { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolFibonacciExtensions.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolFibonacciExtensions { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolFibonacciLevelsBaseAnchorLineStroke.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolFibonacciLevelsBaseAnchorLineStroke { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolFibonacciRetracements.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolFibonacciRetracements { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolFibonacciRetracementsExtendLinesLeft.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolFibonacciRetracementsExtendLinesLeft { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolFibonacciRetracementsExtendLinesRight.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolFibonacciRetracementsExtendLinesRight { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolFibonacciRetracementsTextAlignment.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolFibonacciRetracementsTextAlignment { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolFibonacciRetracementsTextLocation.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolFibonacciRetracementsTextLocation { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolFibonacciTimeCircleDivideTimeSeparately.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolFibonacciTimeCircleDivideTimeSeparately { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolFibonacciTimeExtensions.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolFibonacciTimeExtensions { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolFibonacciTimeExtensionsShowText.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolFibonacciTimeExtensionsShowText { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolGannFan.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolGannFan { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolGannFanDisplayText.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolGannFanDisplayText { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolGannFanFanDirection.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolGannFanFanDirection { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolGannFanPointsPerBar.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolGannFanPointsPerBar { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolHorizontalLine.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolHorizontalLine { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolLine.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolLine { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolPath.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolPath { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolPathBegin.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolPathBegin { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolPathEnd.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolPathEnd { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolPathSegment.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolPathSegment { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolPathShowCount.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolPathShowCount { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolPolygon.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolPolygon { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolPriceLevelsOpacity.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolPriceLevelsOpacity { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRay.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolRay { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRectangle.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolRectangle { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRegion.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolRegion { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRegionHighlightDirection.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolRegionHighlightDirection { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRegionHighlightDirectionStroke.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolRegionHighlightDirectionStroke { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRegionHighlightHorizontalTextFormat.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolRegionHighlightHorizontalTextFormat { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRegionHighlightVerticalRangeUnit.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolRegionHighlightVerticalRangeUnit { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRegionHighlightVerticalTextFormat.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolRegionHighlightVerticalTextFormat { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRegionHiglightX.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolRegionHiglightX { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRegionHiglightY.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolRegionHiglightY { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRegressionChannel.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolRegressionChannel { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRegressionChannelLowerChannel.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolRegressionChannelLowerChannel { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRegressionChannelLowerChannelColor.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolRegressionChannelLowerChannelColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRegressionChannelPriceType.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolRegressionChannelPriceType { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRegressionChannelRegressionChannel.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolRegressionChannelRegressionChannel { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRegressionChannelStandardDeviationExtendLeft.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolRegressionChannelStandardDeviationExtendLeft { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRegressionChannelStandardDeviationExtendRight.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolRegressionChannelStandardDeviationExtendRight { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRegressionChannelStandardDeviationLowerDistance.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolRegressionChannelStandardDeviationLowerDistance { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRegressionChannelStandardDeviationUpperDistance.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolRegressionChannelStandardDeviationUpperDistance { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRegressionChannelType.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolRegressionChannelType { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRegressionChannelUpperChannel.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolRegressionChannelUpperChannel { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRegressionChannelUpperChannelColor.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolRegressionChannelUpperChannelColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRiskRewardAnchorEntry.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolRiskRewardAnchorEntry { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRiskRewardAnchorLineStroke.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolRiskRewardAnchorLineStroke { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRiskRewardAnchorReward.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolRiskRewardAnchorReward { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRiskRewardAnchorRisk.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolRiskRewardAnchorRisk { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRiskRewardCategoryColors.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolRiskRewardCategoryColors { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRiskRewardDescription.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolRiskRewardDescription { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRiskRewardLineStrokeEntry.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolRiskRewardLineStrokeEntry { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRiskRewardLineStrokeReward.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolRiskRewardLineStrokeReward { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRiskRewardLineStrokeRisk.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolRiskRewardLineStrokeRisk { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRiskRewardName.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolRiskRewardName { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRiskRewardRatio.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolRiskRewardRatio { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRuler.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolRuler { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRulerDaysFormat.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolRulerDaysFormat { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRulerNumberBarsText.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolRulerNumberBarsText { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRulerTimeText.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolRulerTimeText { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRulerYValueDisplayUnit.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolRulerYValueDisplayUnit { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRulerYValueText.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolRulerYValueText { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingTools.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingTools { get; set; }
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
        /// Gets or sets the NinjaScriptDrawingToolsGannAngleRatioX.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolsGannAngleRatioX { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolsGannAngleRatioY.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolsGannAngleRatioY { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolsGannAngles.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolsGannAngles { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolsGannAnglesPrompt.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolsGannAnglesPrompt { get; set; }
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
        /// Gets or sets the NinjaScriptDrawingToolsPriceLevelIsVisible.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolsPriceLevelIsVisible { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolsPriceLevelLineStroke.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolsPriceLevelLineStroke { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolsPriceLevels.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolsPriceLevels { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolsPriceLevelsPrompt.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolsPriceLevelsPrompt { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolsPriceLevelUnset.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolsPriceLevelUnset { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolsPriceLevelValue.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolsPriceLevelValue { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolStroke.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolStroke { get; set; }
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
        /// Gets or sets the NinjaScriptDrawingToolTextBackBrush.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolTextBackBrush { get; set; }
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
        /// Gets or sets the NinjaScriptDrawingToolTimeCycles.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolTimeCycles { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolTrendChannel.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolTrendChannel { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolTrendChannelDescription.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolTrendChannelDescription { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolTrendChannelEnd1AnchorDisplayName.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolTrendChannelEnd1AnchorDisplayName { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolTrendChannelParallelStroke.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolTrendChannelParallelStroke { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolTrendChannelStart1AnchorDisplayName.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolTrendChannelStart1AnchorDisplayName { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolTrendChannelStart2AnchorDisplayName.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolTrendChannelStart2AnchorDisplayName { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolTrendChannelTrendStroke.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolTrendChannelTrendStroke { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolTriangle.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolTriangle { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolVerticalLine.
        /// </summary>
        [DataMember]
        public String NinjaScriptDrawingToolVerticalLine { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptGeneral.
        /// </summary>
        [DataMember]
        public String NinjaScriptGeneral { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptGeneticOptimizerAveragePerformanceOffsetPercent.
        /// </summary>
        [DataMember]
        public String NinjaScriptGeneticOptimizerAveragePerformanceOffsetPercent { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptGeneticOptimizerConvergenceThreshold.
        /// </summary>
        [DataMember]
        public String NinjaScriptGeneticOptimizerConvergenceThreshold { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptGeneticOptimizerCrossoverIndex.
        /// </summary>
        [DataMember]
        public String NinjaScriptGeneticOptimizerCrossoverIndex { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptGeneticOptimizerCrossoverRatePercent.
        /// </summary>
        [DataMember]
        public String NinjaScriptGeneticOptimizerCrossoverRatePercent { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptGeneticOptimizerFastGenerations.
        /// </summary>
        [DataMember]
        public String NinjaScriptGeneticOptimizerFastGenerations { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptGeneticOptimizerGenerations.
        /// </summary>
        [DataMember]
        public String NinjaScriptGeneticOptimizerGenerations { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptGeneticOptimizerGenerationSize.
        /// </summary>
        [DataMember]
        public String NinjaScriptGeneticOptimizerGenerationSize { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptGeneticOptimizerMinimumPerformance.
        /// </summary>
        [DataMember]
        public String NinjaScriptGeneticOptimizerMinimumPerformance { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptGeneticOptimizerMutationRatePercent.
        /// </summary>
        [DataMember]
        public String NinjaScriptGeneticOptimizerMutationRatePercent { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptGeneticOptimizerMutationStrengthPercent.
        /// </summary>
        [DataMember]
        public String NinjaScriptGeneticOptimizerMutationStrengthPercent { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptGeneticOptimizerResetSizePercent.
        /// </summary>
        [DataMember]
        public String NinjaScriptGeneticOptimizerResetSizePercent { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptGeneticOptimizerSlowGenerations.
        /// </summary>
        [DataMember]
        public String NinjaScriptGeneticOptimizerSlowGenerations { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptGeneticOptimizerStabilitySizePercent.
        /// </summary>
        [DataMember]
        public String NinjaScriptGeneticOptimizerStabilitySizePercent { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptGeneticOptimizerThresholdGenerations.
        /// </summary>
        [DataMember]
        public String NinjaScriptGeneticOptimizerThresholdGenerations { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicator.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicator { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorAvg.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorAvg { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorCount.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorCount { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDefault.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDefault { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionADL.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionADL { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionADX.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionADX { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionADXR.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionADXR { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionAPZ.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionAPZ { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionAroon.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionAroon { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionAroonOscillator.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionAroonOscillator { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionATR.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionATR { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionBarTimer.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionBarTimer { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionBlockVolume.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionBlockVolume { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionBollinger.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionBollinger { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionBOP.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionBOP { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionBuySellPressure.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionBuySellPressure { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionBuySellVolume.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionBuySellVolume { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionCamarillaPivots.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionCamarillaPivots { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionCandlestickPattern.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionCandlestickPattern { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionCCI.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionCCI { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionChaikinMoneyFlow.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionChaikinMoneyFlow { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionChaikinOscillator.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionChaikinOscillator { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionChaikinVolatility.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionChaikinVolatility { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionChoppinessIndex.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionChoppinessIndex { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionCMO.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionCMO { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionConstantLines.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionConstantLines { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionCorrelation.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionCorrelation { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionCOT.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionCOT { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionCurrentDayOHL.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionCurrentDayOHL { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionDarvas.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionDarvas { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionDEMA.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionDEMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionDisparityIndex.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionDisparityIndex { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionDM.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionDM { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionDMI.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionDMI { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionDMIndex.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionDMIndex { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionDonchianChannel.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionDonchianChannel { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionDoubleStochastics.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionDoubleStochastics { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionEaseOfMovement.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionEaseOfMovement { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionEMA.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionEMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionFibonacciPivots.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionFibonacciPivots { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionFisherTransform.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionFisherTransform { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionFOSC.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionFOSC { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionHMA.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionHMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionKAMA.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionKAMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionKeltnerChannel.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionKeltnerChannel { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionKeyReversalDown.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionKeyReversalDown { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionKeyReversalUp.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionKeyReversalUp { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionLinReg.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionLinReg { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionLinRegIntercept.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionLinRegIntercept { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionLinRegSlope.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionLinRegSlope { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionMACD.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionMACD { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionMAEnvelopes.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionMAEnvelopes { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionMAMA.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionMAMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionMAX.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionMAX { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionMcClellanOscillator.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionMcClellanOscillator { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionMFI.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionMFI { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionMIN.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionMIN { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionMomentum.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionMomentum { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionMoneyFlowOscillator.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionMoneyFlowOscillator { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionMovingAverageRibbon.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionMovingAverageRibbon { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionNBarsDown.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionNBarsDown { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionNBarsUp.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionNBarsUp { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionNetChangeDisplay.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionNetChangeDisplay { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionOBV.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionOBV { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionParabolicSAR.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionParabolicSAR { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionPFE.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionPFE { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionPivots.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionPivots { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionPPO.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionPPO { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionPriceLine.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionPriceLine { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionPriceOscillator.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionPriceOscillator { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionPriorDayOHLC.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionPriorDayOHLC { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionPsychologicalLine.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionPsychologicalLine { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionRange.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionRange { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionRangeCounter.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionRangeCounter { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionRegressionChannel.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionRegressionChannel { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionRelativeVigorIndex.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionRelativeVigorIndex { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionRIND.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionRIND { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionROC.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionROC { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionRSI.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionRSI { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionRSquared.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionRSquared { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionRSS.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionRSS { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionRVI.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionRVI { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionSampleCustomRender.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionSampleCustomRender { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionSMA.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionSMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionStdDev.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionStdDev { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionStdError.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionStdError { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionStochastics.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionStochastics { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionStochasticsFast.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionStochasticsFast { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionStochRSI.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionStochRSI { get; set; }
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
        /// Gets or sets the NinjaScriptIndicatorDescriptionT3.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionT3 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionTEMA.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionTEMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionTickCounter.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionTickCounter { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionTMA.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionTMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionTrendLines.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionTrendLines { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionTRIX.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionTRIX { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionTSF.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionTSF { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionTSI.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionTSI { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionUltimateOscillator.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionUltimateOscillator { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionVMA.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionVMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionVOL.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionVOL { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionVOLMA.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionVOLMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionVolumeCounter.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionVolumeCounter { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionVolumeOscillator.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionVolumeOscillator { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionVolumeProfile.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionVolumeProfile { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionVolumeUpDown.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionVolumeUpDown { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionVolumeZones.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionVolumeZones { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionVortex.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionVortex { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionVROC.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionVROC { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionVWMA.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionVWMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionWilliamsR.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionWilliamsR { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionWMA.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionWMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionZigZag.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionZigZag { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionZLEMA.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDescriptionZLEMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDiff.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDiff { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDisparityLine.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDisparityLine { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDown.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorDown { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorLower.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorLower { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorMcClellanOscillatorLine.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorMcClellanOscillatorLine { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorMiddle.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorMiddle { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorMoneyFlowLine.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorMoneyFlowLine { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameADL.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameADL { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameADX.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameADX { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameADXR.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameADXR { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameAPZ.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameAPZ { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameAroon.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameAroon { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameAroonOscillator.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameAroonOscillator { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameATR.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameATR { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameBarTimer.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameBarTimer { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameBlockVolume.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameBlockVolume { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameBollinger.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameBollinger { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameBOP.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameBOP { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameBuySellPressure.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameBuySellPressure { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameBuySellVolume.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameBuySellVolume { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameCamarillaPivots.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameCamarillaPivots { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameCandlestickPattern.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameCandlestickPattern { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameCCI.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameCCI { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameChaikinMoneyFlow.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameChaikinMoneyFlow { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameChaikinOscillator.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameChaikinOscillator { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameChaikinVolatility.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameChaikinVolatility { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameChoppinessIndex.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameChoppinessIndex { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameCMO.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameCMO { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameConstantLines.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameConstantLines { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameCorrelation.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameCorrelation { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameCOT.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameCOT { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameCurrentDayOHL.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameCurrentDayOHL { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameDarvas.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameDarvas { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameDEMA.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameDEMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameDisparityIndex.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameDisparityIndex { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameDM.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameDM { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameDMI.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameDMI { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameDMIndex.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameDMIndex { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameDonchianChannel.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameDonchianChannel { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameDoubleStochastics.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameDoubleStochastics { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameEaseOfMovement.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameEaseOfMovement { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameEMA.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameEMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameFibonacciPivots.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameFibonacciPivots { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameFisherTransform.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameFisherTransform { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameFOSC.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameFOSC { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameHMA.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameHMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameKAMA.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameKAMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameKelterChannel.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameKelterChannel { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameKeyReversalDown.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameKeyReversalDown { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameKeyReversalUp.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameKeyReversalUp { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameLinReg.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameLinReg { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameLinRegIntercept.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameLinRegIntercept { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameLinRegSlope.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameLinRegSlope { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameMACD.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameMACD { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameMAEnvelopes.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameMAEnvelopes { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameMAMA.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameMAMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameMAX.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameMAX { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameMcClellanOscillator.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameMcClellanOscillator { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameMFI.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameMFI { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameMIN.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameMIN { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameMomentum.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameMomentum { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameMoneyFlowOscillator.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameMoneyFlowOscillator { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameMovingAverageRibbon.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameMovingAverageRibbon { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameNBarsDown.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameNBarsDown { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameNBarsUp.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameNBarsUp { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameNetChangeDisplay.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameNetChangeDisplay { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameOBV.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameOBV { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameParabolicSAR.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameParabolicSAR { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNamePFE.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNamePFE { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNamePivots.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNamePivots { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNamePPO.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNamePPO { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNamePriceLine.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNamePriceLine { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNamePriceOscillator.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNamePriceOscillator { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNamePriorDayOHLC.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNamePriorDayOHLC { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNamePsychologicalLine.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNamePsychologicalLine { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameRange.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameRange { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameRangeCounter.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameRangeCounter { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameRegressionChannel.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameRegressionChannel { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameRelativeVigorIndex.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameRelativeVigorIndex { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameRIND.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameRIND { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameROC.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameROC { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameRSI.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameRSI { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameRSquared.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameRSquared { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameRSS.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameRSS { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameRVI.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameRVI { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameSampleCustomRender.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameSampleCustomRender { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameSMA.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameSMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameStdDev.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameStdDev { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameStdError.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameStdError { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameStochastics.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameStochastics { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameStochasticsFast.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameStochasticsFast { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameStochRSI.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameStochRSI { get; set; }
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
        /// Gets or sets the NinjaScriptIndicatorNameT3.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameT3 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameTEMA.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameTEMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameTickCounter.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameTickCounter { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameTMA.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameTMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameTrendLines.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameTrendLines { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameTRIX.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameTRIX { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameTSF.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameTSF { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameTSI.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameTSI { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameUltimateOscillator.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameUltimateOscillator { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameVMA.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameVMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameVOL.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameVOL { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameVOLMA.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameVOLMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameVolumeCounter.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameVolumeCounter { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameVolumeOscillator.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameVolumeOscillator { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameVolumeProfile.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameVolumeProfile { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameVolumesZones.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameVolumesZones { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameVolumeUpDown.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameVolumeUpDown { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameVortex.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameVortex { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameVROC.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameVROC { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameVWMA.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameVWMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameWilliamsR.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameWilliamsR { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameWMA.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameWMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameZigZag.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameZigZag { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameZLEMA.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNameZLEMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNeutral.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorNeutral { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorOverbought.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorOverbought { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorOverBoughtLine.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorOverBoughtLine { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorOversold.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorOversold { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorOverSoldLine.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorOverSoldLine { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorRelativeVigorIndex.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorRelativeVigorIndex { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorSignal.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorSignal { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorUp.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorUp { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorUpper.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorUpper { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorVIMinus.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorVIMinus { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorVIPlus.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorVIPlus { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorVisualGroup.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorVisualGroup { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorZeroLine.
        /// </summary>
        [DataMember]
        public String NinjaScriptIndicatorZeroLine { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIsVisibleOnlyFocused.
        /// </summary>
        [DataMember]
        public String NinjaScriptIsVisibleOnlyFocused { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptLine.
        /// </summary>
        [DataMember]
        public String NinjaScriptLine { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptLines.
        /// </summary>
        [DataMember]
        public String NinjaScriptLines { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptLoadingData.
        /// </summary>
        [DataMember]
        public String NinjaScriptLoadingData { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionAskPrice.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionAskPrice { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionAskSize.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionAskSize { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionAverageDailyVolume.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionAverageDailyVolume { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionBeta.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionBeta { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionBidAskSpread.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionBidAskSpread { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionBidPrice.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionBidPrice { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionBidSize.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionBidSize { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionCalendarYearHigh.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionCalendarYearHigh { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionCalendarYearHighDate.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionCalendarYearHighDate { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionCalendarYearLow.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionCalendarYearLow { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionCalendarYearLowDate.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionCalendarYearLowDate { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionChartMini.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionChartMini { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionChartNetChange.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionChartNetChange { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionCurrentRatio.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionCurrentRatio { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionDailyHigh.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionDailyHigh { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionDailyLow.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionDailyLow { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionDailyVolume.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionDailyVolume { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionDaysUntilRollover.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionDaysUntilRollover { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionDescription.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionDescription { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionDividendAmount.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionDividendAmount { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionDividendPayDate.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionDividendPayDate { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionDividendYield.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionDividendYield { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionEarningsPerShare.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionEarningsPerShare { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionFiveYearsGrowthPercentage.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionFiveYearsGrowthPercentage { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionHigh52Weeks.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionHigh52Weeks { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionHigh52WeeksDate.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionHigh52WeeksDate { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionHistoricalVolatility.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionHistoricalVolatility { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionInstrument.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionInstrument { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionLastClose.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionLastClose { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionLastPrice.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionLastPrice { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionLastSize.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionLastSize { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionLow52Weeks.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionLow52Weeks { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionLow52WeeksDate.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionLow52WeeksDate { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionMarketCap.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionMarketCap { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionMarketPrice.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionMarketPrice { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionNetChange.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionNetChange { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionNetChangeMaxDown.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionNetChangeMaxDown { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionNetChangeMaxUp.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionNetChangeMaxUp { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionNextYearsEarningsPerShare.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionNextYearsEarningsPerShare { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionNotes.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionNotes { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionOpening.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionOpening { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionOpenInterest.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionOpenInterest { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionPercentHeldByInstitutions.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionPercentHeldByInstitutions { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionPositionAvgPrice.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionPositionAvgPrice { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionPositionSize.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionPositionSize { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionPriceEarningsRatio.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionPriceEarningsRatio { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionProfitLoss.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionProfitLoss { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionRealizedProfitLoss.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionRealizedProfitLoss { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionRevenuePerShare.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionRevenuePerShare { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionSettlement.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionSettlement { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionSharesOutstanding.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionSharesOutstanding { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionShortInterest.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionShortInterest { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionShortInterestRatio.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionShortInterestRatio { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionTimeLastTick.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionTimeLastTick { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionTradedContracts.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionTradedContracts { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionTSTrend.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionTSTrend { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionUnrealizedProfitLoss.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionUnrealizedProfitLoss { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionVwap.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnDescriptionVwap { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameAskPrice.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameAskPrice { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameAskSize.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameAskSize { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameAverageDailyVolume.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameAverageDailyVolume { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameBeta.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameBeta { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameBidAskSpread.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameBidAskSpread { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameBidPrice.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameBidPrice { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameBidSize.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameBidSize { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameCalendarYearHigh.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameCalendarYearHigh { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameCalendarYearHighDate.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameCalendarYearHighDate { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameCalendarYearLow.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameCalendarYearLow { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameCalendarYearLowDate.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameCalendarYearLowDate { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameChartMini.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameChartMini { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameChartNetChange.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameChartNetChange { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameCurrentRatio.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameCurrentRatio { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameDailyHigh.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameDailyHigh { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameDailyLow.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameDailyLow { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameDailyVolume.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameDailyVolume { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameDaysUntilRollover.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameDaysUntilRollover { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameDescription.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameDescription { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameDividendAmount.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameDividendAmount { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameDividendPayDate.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameDividendPayDate { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameDividendYield.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameDividendYield { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameEarningsPerShare.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameEarningsPerShare { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameFiveYearsGrowthPercentage.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameFiveYearsGrowthPercentage { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameHigh52Weeks.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameHigh52Weeks { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameHigh52WeeksDate.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameHigh52WeeksDate { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameHistoricalVolatility.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameHistoricalVolatility { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameInstrument.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameInstrument { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameLastClose.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameLastClose { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameLastPrice.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameLastPrice { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameLastSize.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameLastSize { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameLow52Weeks.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameLow52Weeks { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameLow52WeeksDate.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameLow52WeeksDate { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameMarketCap.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameMarketCap { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameMarketPrice.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameMarketPrice { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameNetChange.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameNetChange { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameNetChangeMaxDown.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameNetChangeMaxDown { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameNetChangeMaxUp.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameNetChangeMaxUp { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameNextYearsEarningsPerShare.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameNextYearsEarningsPerShare { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameNotes.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameNotes { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameOpening.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameOpening { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameOpenInterest.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameOpenInterest { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNamePercentHeldByInstitutions.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNamePercentHeldByInstitutions { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNamePositionAvgPrice.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNamePositionAvgPrice { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNamePositionSize.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNamePositionSize { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNamePriceEarningsRatio.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNamePriceEarningsRatio { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameProfitLoss.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameProfitLoss { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameRealizedProfitLoss.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameRealizedProfitLoss { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameRevenuePerShare.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameRevenuePerShare { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameSettlement.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameSettlement { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameSharesOutstanding.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameSharesOutstanding { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameShortInterest.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameShortInterest { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameShortInterestRatio.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameShortInterestRatio { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameTimeLastTick.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameTimeLastTick { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameTradedContracts.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameTradedContracts { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameTSTrend.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameTSTrend { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameUnrealizedProfitLoss.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameUnrealizedProfitLoss { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameVwap.
        /// </summary>
        [DataMember]
        public String NinjaScriptMarketAnalyzerColumnNameVwap { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNumberOfRows.
        /// </summary>
        [DataMember]
        public String NinjaScriptNumberOfRows { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOnBarCloseError.
        /// </summary>
        [DataMember]
        public String NinjaScriptOnBarCloseError { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOnPriceChangeError.
        /// </summary>
        [DataMember]
        public String NinjaScriptOnPriceChangeError { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxAvgMfe.
        /// </summary>
        [DataMember]
        public String NinjaScriptOptimizationFitnessNameMaxAvgMfe { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxAvgMfeLong.
        /// </summary>
        [DataMember]
        public String NinjaScriptOptimizationFitnessNameMaxAvgMfeLong { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxAvgMfeShort.
        /// </summary>
        [DataMember]
        public String NinjaScriptOptimizationFitnessNameMaxAvgMfeShort { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxAvgProfit.
        /// </summary>
        [DataMember]
        public String NinjaScriptOptimizationFitnessNameMaxAvgProfit { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxAvgProfitLong.
        /// </summary>
        [DataMember]
        public String NinjaScriptOptimizationFitnessNameMaxAvgProfitLong { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxAvgProfitShort.
        /// </summary>
        [DataMember]
        public String NinjaScriptOptimizationFitnessNameMaxAvgProfitShort { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxNetProfit.
        /// </summary>
        [DataMember]
        public String NinjaScriptOptimizationFitnessNameMaxNetProfit { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxNetProfitLong.
        /// </summary>
        [DataMember]
        public String NinjaScriptOptimizationFitnessNameMaxNetProfitLong { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxNetProfitShort.
        /// </summary>
        [DataMember]
        public String NinjaScriptOptimizationFitnessNameMaxNetProfitShort { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxPercentProfitable.
        /// </summary>
        [DataMember]
        public String NinjaScriptOptimizationFitnessNameMaxPercentProfitable { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxPercentProfitableLong.
        /// </summary>
        [DataMember]
        public String NinjaScriptOptimizationFitnessNameMaxPercentProfitableLong { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxPercentProfitableShort.
        /// </summary>
        [DataMember]
        public String NinjaScriptOptimizationFitnessNameMaxPercentProfitableShort { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxProbablity.
        /// </summary>
        [DataMember]
        public String NinjaScriptOptimizationFitnessNameMaxProbablity { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxProbablityLong.
        /// </summary>
        [DataMember]
        public String NinjaScriptOptimizationFitnessNameMaxProbablityLong { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxProbablityShort.
        /// </summary>
        [DataMember]
        public String NinjaScriptOptimizationFitnessNameMaxProbablityShort { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxProfitFactor.
        /// </summary>
        [DataMember]
        public String NinjaScriptOptimizationFitnessNameMaxProfitFactor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxProfitFactorLong.
        /// </summary>
        [DataMember]
        public String NinjaScriptOptimizationFitnessNameMaxProfitFactorLong { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxProfitFactorShort.
        /// </summary>
        [DataMember]
        public String NinjaScriptOptimizationFitnessNameMaxProfitFactorShort { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxR2.
        /// </summary>
        [DataMember]
        public String NinjaScriptOptimizationFitnessNameMaxR2 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxR2Long.
        /// </summary>
        [DataMember]
        public String NinjaScriptOptimizationFitnessNameMaxR2Long { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxR2Short.
        /// </summary>
        [DataMember]
        public String NinjaScriptOptimizationFitnessNameMaxR2Short { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxSharpeRatio.
        /// </summary>
        [DataMember]
        public String NinjaScriptOptimizationFitnessNameMaxSharpeRatio { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxSharpeRatioLong.
        /// </summary>
        [DataMember]
        public String NinjaScriptOptimizationFitnessNameMaxSharpeRatioLong { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxSharpeRatioShort.
        /// </summary>
        [DataMember]
        public String NinjaScriptOptimizationFitnessNameMaxSharpeRatioShort { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxSortinoRatio.
        /// </summary>
        [DataMember]
        public String NinjaScriptOptimizationFitnessNameMaxSortinoRatio { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxSortinoRatioLong.
        /// </summary>
        [DataMember]
        public String NinjaScriptOptimizationFitnessNameMaxSortinoRatioLong { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxSortinoRatioShort.
        /// </summary>
        [DataMember]
        public String NinjaScriptOptimizationFitnessNameMaxSortinoRatioShort { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxStrength.
        /// </summary>
        [DataMember]
        public String NinjaScriptOptimizationFitnessNameMaxStrength { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxStrengthLong.
        /// </summary>
        [DataMember]
        public String NinjaScriptOptimizationFitnessNameMaxStrengthLong { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxStrengthShort.
        /// </summary>
        [DataMember]
        public String NinjaScriptOptimizationFitnessNameMaxStrengthShort { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxUlcerRatio.
        /// </summary>
        [DataMember]
        public String NinjaScriptOptimizationFitnessNameMaxUlcerRatio { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxUlcerRatioLong.
        /// </summary>
        [DataMember]
        public String NinjaScriptOptimizationFitnessNameMaxUlcerRatioLong { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxUlcerRatioShort.
        /// </summary>
        [DataMember]
        public String NinjaScriptOptimizationFitnessNameMaxUlcerRatioShort { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxWinLossRatio.
        /// </summary>
        [DataMember]
        public String NinjaScriptOptimizationFitnessNameMaxWinLossRatio { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxWinLossRatioLong.
        /// </summary>
        [DataMember]
        public String NinjaScriptOptimizationFitnessNameMaxWinLossRatioLong { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxWinLossRatioShort.
        /// </summary>
        [DataMember]
        public String NinjaScriptOptimizationFitnessNameMaxWinLossRatioShort { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMinAvgMae.
        /// </summary>
        [DataMember]
        public String NinjaScriptOptimizationFitnessNameMinAvgMae { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMinAvgMaeLong.
        /// </summary>
        [DataMember]
        public String NinjaScriptOptimizationFitnessNameMinAvgMaeLong { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMinAvgMaeShort.
        /// </summary>
        [DataMember]
        public String NinjaScriptOptimizationFitnessNameMinAvgMaeShort { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMinDrawDown.
        /// </summary>
        [DataMember]
        public String NinjaScriptOptimizationFitnessNameMinDrawDown { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMinDrawDownLong.
        /// </summary>
        [DataMember]
        public String NinjaScriptOptimizationFitnessNameMinDrawDownLong { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMinDrawDownShort.
        /// </summary>
        [DataMember]
        public String NinjaScriptOptimizationFitnessNameMinDrawDownShort { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizerDefault.
        /// </summary>
        [DataMember]
        public String NinjaScriptOptimizerDefault { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizerGenetic.
        /// </summary>
        [DataMember]
        public String NinjaScriptOptimizerGenetic { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptParameters.
        /// </summary>
        [DataMember]
        public String NinjaScriptParameters { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptRecentColumnAskBackground.
        /// </summary>
        [DataMember]
        public String NinjaScriptRecentColumnAskBackground { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptRecentColumnAskForeground.
        /// </summary>
        [DataMember]
        public String NinjaScriptRecentColumnAskForeground { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptRecentColumnBidBackground.
        /// </summary>
        [DataMember]
        public String NinjaScriptRecentColumnBidBackground { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptRecentColumnBidForeground.
        /// </summary>
        [DataMember]
        public String NinjaScriptRecentColumnBidForeground { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptRecentColumnDiplay.
        /// </summary>
        [DataMember]
        public String NinjaScriptRecentColumnDiplay { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptRecentColumnResetTolerance.
        /// </summary>
        [DataMember]
        public String NinjaScriptRecentColumnResetTolerance { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptRecentColumnResetWhen.
        /// </summary>
        [DataMember]
        public String NinjaScriptRecentColumnResetWhen { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptSetup.
        /// </summary>
        [DataMember]
        public String NinjaScriptSetup { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyDescriptionSampleATMStrategy.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyDescriptionSampleATMStrategy { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyDescriptionSampleCustomPerformance.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyDescriptionSampleCustomPerformance { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyDescriptionSampleFramework.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyDescriptionSampleFramework { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyDescriptionSampleMACrossOver.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyDescriptionSampleMACrossOver { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyDescriptionSampleMultiInstrument.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyDescriptionSampleMultiInstrument { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyDescriptionSampleMultiTimeFrame.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyDescriptionSampleMultiTimeFrame { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyGenerator.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyGenerator { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyGeneratorCandleStickPatternPrompt.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyGeneratorCandleStickPatternPrompt { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyGeneratorEntries.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyGeneratorEntries { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyGeneratorEntriesOrExits.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyGeneratorEntriesOrExits { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyGeneratorIndicatorException.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyGeneratorIndicatorException { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyGeneratorIndicatorsPrompt.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyGeneratorIndicatorsPrompt { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyGeneratorPeformance.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyGeneratorPeformance { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyGeneratorProperties.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyGeneratorProperties { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyGeneratorTerminated.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyGeneratorTerminated { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyGeneratorUseCandleStickPattern.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyGeneratorUseCandleStickPattern { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyGeneratorUseIndicators.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyGeneratorUseIndicators { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyNameSampleATMStrategy.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyNameSampleATMStrategy { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyNameSampleCustomPerformance.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyNameSampleCustomPerformance { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyNameSampleFramework.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyNameSampleFramework { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyNameSampleMACrossOver.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyNameSampleMACrossOver { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyNameSampleMultiInstrument.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyNameSampleMultiInstrument { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyNameSampleMultiTimeFrame.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyNameSampleMultiTimeFrame { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyParameters.
        /// </summary>
        [DataMember]
        public String NinjaScriptStrategyParameters { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptSuperDomColumnApq.
        /// </summary>
        [DataMember]
        public String NinjaScriptSuperDomColumnApq { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptSuperDomColumnBaseInitializeBarsPoolError.
        /// </summary>
        [DataMember]
        public String NinjaScriptSuperDomColumnBaseInitializeBarsPoolError { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptSuperDomColumnDescriptionApq.
        /// </summary>
        [DataMember]
        public String NinjaScriptSuperDomColumnDescriptionApq { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptSuperDomColumnDescriptionNotes.
        /// </summary>
        [DataMember]
        public String NinjaScriptSuperDomColumnDescriptionNotes { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptSuperDomColumnDescriptionPnl.
        /// </summary>
        [DataMember]
        public String NinjaScriptSuperDomColumnDescriptionPnl { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptSuperDomColumnDescriptionVolume.
        /// </summary>
        [DataMember]
        public String NinjaScriptSuperDomColumnDescriptionVolume { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptSuperDomColumnNotes.
        /// </summary>
        [DataMember]
        public String NinjaScriptSuperDomColumnNotes { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptSuperDomColumnProfitAndLoss.
        /// </summary>
        [DataMember]
        public String NinjaScriptSuperDomColumnProfitAndLoss { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptSuperDomColumnVolume.
        /// </summary>
        [DataMember]
        public String NinjaScriptSuperDomColumnVolume { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptTileError.
        /// </summary>
        [DataMember]
        public String NinjaScriptTileError { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptYOffset.
        /// </summary>
        [DataMember]
        public String NinjaScriptYOffset { get; set; }
        /// <summary>
        /// Gets or sets the NumberOfCotPlots.
        /// </summary>
        [DataMember]
        public String NumberOfCotPlots { get; set; }
        /// <summary>
        /// Gets or sets the NumberOfTrendLines.
        /// </summary>
        [DataMember]
        public String NumberOfTrendLines { get; set; }
        /// <summary>
        /// Gets or sets the NumStdDev.
        /// </summary>
        [DataMember]
        public String NumStdDev { get; set; }
        /// <summary>
        /// Gets or sets the OffsetMultiplier.
        /// </summary>
        [DataMember]
        public String OffsetMultiplier { get; set; }
        /// <summary>
        /// Gets or sets the OldTrendsOpacity.
        /// </summary>
        [DataMember]
        public String OldTrendsOpacity { get; set; }
        /// <summary>
        /// Gets or sets the Opacity.
        /// </summary>
        [DataMember]
        public String Opacity { get; set; }
        /// <summary>
        /// Gets or sets the PathCapMode_Arrow.
        /// </summary>
        [DataMember]
        public String PathCapMode_Arrow { get; set; }
        /// <summary>
        /// Gets or sets the PathCapMode_Line.
        /// </summary>
        [DataMember]
        public String PathCapMode_Line { get; set; }
        /// <summary>
        /// Gets or sets the PathToolCapMode_Arrow.
        /// </summary>
        [DataMember]
        public String PathToolCapMode_Arrow { get; set; }
        /// <summary>
        /// Gets or sets the PathToolCapMode_Line.
        /// </summary>
        [DataMember]
        public String PathToolCapMode_Line { get; set; }
        /// <summary>
        /// Gets or sets the PerformanceMetricSampleCumProfit.
        /// </summary>
        [DataMember]
        public String PerformanceMetricSampleCumProfit { get; set; }
        /// <summary>
        /// Gets or sets the Period.
        /// </summary>
        [DataMember]
        public String Period { get; set; }
        /// <summary>
        /// Gets or sets the PeriodD.
        /// </summary>
        [DataMember]
        public String PeriodD { get; set; }
        /// <summary>
        /// Gets or sets the PeriodK.
        /// </summary>
        [DataMember]
        public String PeriodK { get; set; }
        /// <summary>
        /// Gets or sets the PeriodQ.
        /// </summary>
        [DataMember]
        public String PeriodQ { get; set; }
        /// <summary>
        /// Gets or sets the PFEZero.
        /// </summary>
        [DataMember]
        public String PFEZero { get; set; }
        /// <summary>
        /// Gets or sets the PiviotsDailyBarsError.
        /// </summary>
        [DataMember]
        public String PiviotsDailyBarsError { get; set; }
        /// <summary>
        /// Gets or sets the PiviotsDailyDataError.
        /// </summary>
        [DataMember]
        public String PiviotsDailyDataError { get; set; }
        /// <summary>
        /// Gets or sets the PiviotsInsufficentDataError.
        /// </summary>
        [DataMember]
        public String PiviotsInsufficentDataError { get; set; }
        /// <summary>
        /// Gets or sets the PiviotsPeriodTypeError.
        /// </summary>
        [DataMember]
        public String PiviotsPeriodTypeError { get; set; }
        /// <summary>
        /// Gets or sets the PiviotsWeeklyBarsError.
        /// </summary>
        [DataMember]
        public String PiviotsWeeklyBarsError { get; set; }
        /// <summary>
        /// Gets or sets the PivotRange.
        /// </summary>
        [DataMember]
        public String PivotRange { get; set; }
        /// <summary>
        /// Gets or sets the PivotRange_Daily.
        /// </summary>
        [DataMember]
        public String PivotRange_Daily { get; set; }
        /// <summary>
        /// Gets or sets the PivotRange_Monthly.
        /// </summary>
        [DataMember]
        public String PivotRange_Monthly { get; set; }
        /// <summary>
        /// Gets or sets the PivotRange_Weekly.
        /// </summary>
        [DataMember]
        public String PivotRange_Weekly { get; set; }
        /// <summary>
        /// Gets or sets the PivotsPP.
        /// </summary>
        [DataMember]
        public String PivotsPP { get; set; }
        /// <summary>
        /// Gets or sets the PivotsR1.
        /// </summary>
        [DataMember]
        public String PivotsR1 { get; set; }
        /// <summary>
        /// Gets or sets the PivotsR2.
        /// </summary>
        [DataMember]
        public String PivotsR2 { get; set; }
        /// <summary>
        /// Gets or sets the PivotsR3.
        /// </summary>
        [DataMember]
        public String PivotsR3 { get; set; }
        /// <summary>
        /// Gets or sets the PivotsR4.
        /// </summary>
        [DataMember]
        public String PivotsR4 { get; set; }
        /// <summary>
        /// Gets or sets the PivotsS1.
        /// </summary>
        [DataMember]
        public String PivotsS1 { get; set; }
        /// <summary>
        /// Gets or sets the PivotsS2.
        /// </summary>
        [DataMember]
        public String PivotsS2 { get; set; }
        /// <summary>
        /// Gets or sets the PivotsS3.
        /// </summary>
        [DataMember]
        public String PivotsS3 { get; set; }
        /// <summary>
        /// Gets or sets the PivotsS4.
        /// </summary>
        [DataMember]
        public String PivotsS4 { get; set; }
        /// <summary>
        /// Gets or sets the PlotCurrentValue.
        /// </summary>
        [DataMember]
        public String PlotCurrentValue { get; set; }
        /// <summary>
        /// Gets or sets the PositiveColor.
        /// </summary>
        [DataMember]
        public String PositiveColor { get; set; }
        /// <summary>
        /// Gets or sets the PPOSmoothed.
        /// </summary>
        [DataMember]
        public String PPOSmoothed { get; set; }
        /// <summary>
        /// Gets or sets the PriceLinePlotAsk.
        /// </summary>
        [DataMember]
        public String PriceLinePlotAsk { get; set; }
        /// <summary>
        /// Gets or sets the PriceLinePlotBid.
        /// </summary>
        [DataMember]
        public String PriceLinePlotBid { get; set; }
        /// <summary>
        /// Gets or sets the PriceLinePlotLast.
        /// </summary>
        [DataMember]
        public String PriceLinePlotLast { get; set; }
        /// <summary>
        /// Gets or sets the PriorDayOHLCClose.
        /// </summary>
        [DataMember]
        public String PriorDayOHLCClose { get; set; }
        /// <summary>
        /// Gets or sets the PriorDayOHLCHigh.
        /// </summary>
        [DataMember]
        public String PriorDayOHLCHigh { get; set; }
        /// <summary>
        /// Gets or sets the PriorDayOHLCIntradayError.
        /// </summary>
        [DataMember]
        public String PriorDayOHLCIntradayError { get; set; }
        /// <summary>
        /// Gets or sets the PriorDayOHLCLow.
        /// </summary>
        [DataMember]
        public String PriorDayOHLCLow { get; set; }
        /// <summary>
        /// Gets or sets the PriorDayOHLCOpen.
        /// </summary>
        [DataMember]
        public String PriorDayOHLCOpen { get; set; }
        /// <summary>
        /// Gets or sets the PropertyCategoryVisual.
        /// </summary>
        [DataMember]
        public String PropertyCategoryVisual { get; set; }
        /// <summary>
        /// Gets or sets the PullingStackingDisplayType_Ask.
        /// </summary>
        [DataMember]
        public String PullingStackingDisplayType_Ask { get; set; }
        /// <summary>
        /// Gets or sets the PullingStackingDisplayType_Bid.
        /// </summary>
        [DataMember]
        public String PullingStackingDisplayType_Bid { get; set; }
        /// <summary>
        /// Gets or sets the PullingStackingDisplayType_BidAsk.
        /// </summary>
        [DataMember]
        public String PullingStackingDisplayType_BidAsk { get; set; }
        /// <summary>
        /// Gets or sets the PullingStackingResetWhen_BidAskChange.
        /// </summary>
        [DataMember]
        public String PullingStackingResetWhen_BidAskChange { get; set; }
        /// <summary>
        /// Gets or sets the PullingStackingResetWhen_NoMoreData.
        /// </summary>
        [DataMember]
        public String PullingStackingResetWhen_NoMoreData { get; set; }
        /// <summary>
        /// Gets or sets the RangeCounterBarError.
        /// </summary>
        [DataMember]
        public String RangeCounterBarError { get; set; }
        /// <summary>
        /// Gets or sets the RangeCounterRemaing.
        /// </summary>
        [DataMember]
        public String RangeCounterRemaing { get; set; }
        /// <summary>
        /// Gets or sets the RangerCounterCount.
        /// </summary>
        [DataMember]
        public String RangerCounterCount { get; set; }
        /// <summary>
        /// Gets or sets the RangeValue.
        /// </summary>
        [DataMember]
        public String RangeValue { get; set; }
        /// <summary>
        /// Gets or sets the RecentDisplayType_Ask.
        /// </summary>
        [DataMember]
        public String RecentDisplayType_Ask { get; set; }
        /// <summary>
        /// Gets or sets the RecentDisplayType_Bid.
        /// </summary>
        [DataMember]
        public String RecentDisplayType_Bid { get; set; }
        /// <summary>
        /// Gets or sets the RecentDisplayType_BidAsk.
        /// </summary>
        [DataMember]
        public String RecentDisplayType_BidAsk { get; set; }
        /// <summary>
        /// Gets or sets the RecentResetWhen_BidAskChange.
        /// </summary>
        [DataMember]
        public String RecentResetWhen_BidAskChange { get; set; }
        /// <summary>
        /// Gets or sets the RecentResetWhen_PriceReturns.
        /// </summary>
        [DataMember]
        public String RecentResetWhen_PriceReturns { get; set; }
        /// <summary>
        /// Gets or sets the RegionHighlightDirection_Horizontal.
        /// </summary>
        [DataMember]
        public String RegionHighlightDirection_Horizontal { get; set; }
        /// <summary>
        /// Gets or sets the RegionHighlightDirection_Vertical.
        /// </summary>
        [DataMember]
        public String RegionHighlightDirection_Vertical { get; set; }
        /// <summary>
        /// Gets or sets the RegressionChannelType_Segment.
        /// </summary>
        [DataMember]
        public String RegressionChannelType_Segment { get; set; }
        /// <summary>
        /// Gets or sets the RegressionChannelType_StandardDeviation.
        /// </summary>
        [DataMember]
        public String RegressionChannelType_StandardDeviation { get; set; }
        /// <summary>
        /// Gets or sets the ROCPeriod.
        /// </summary>
        [DataMember]
        public String ROCPeriod { get; set; }
        /// <summary>
        /// Gets or sets the RVISignalLine.
        /// </summary>
        [DataMember]
        public String RVISignalLine { get; set; }
        /// <summary>
        /// Gets or sets the SampleAddOnDescription.
        /// </summary>
        [DataMember]
        public String SampleAddOnDescription { get; set; }
        /// <summary>
        /// Gets or sets the SampleAddOnHiThere.
        /// </summary>
        [DataMember]
        public String SampleAddOnHiThere { get; set; }
        /// <summary>
        /// Gets or sets the SampleAddOnName.
        /// </summary>
        [DataMember]
        public String SampleAddOnName { get; set; }
        /// <summary>
        /// Gets or sets the SampleCumProfit.
        /// </summary>
        [DataMember]
        public String SampleCumProfit { get; set; }
        /// <summary>
        /// Gets or sets the SampleCumProfitDescription.
        /// </summary>
        [DataMember]
        public String SampleCumProfitDescription { get; set; }
        /// <summary>
        /// Gets or sets the SampleCustomPlotLowerRightCorner.
        /// </summary>
        [DataMember]
        public String SampleCustomPlotLowerRightCorner { get; set; }
        /// <summary>
        /// Gets or sets the SampleCustomPlotUpperLeftCorner.
        /// </summary>
        [DataMember]
        public String SampleCustomPlotUpperLeftCorner { get; set; }
        /// <summary>
        /// Gets or sets the SelectPattern.
        /// </summary>
        [DataMember]
        public String SelectPattern { get; set; }
        /// <summary>
        /// Gets or sets the SelectPatternDescription.
        /// </summary>
        [DataMember]
        public String SelectPatternDescription { get; set; }
        /// <summary>
        /// Gets or sets the SendAlerts.
        /// </summary>
        [DataMember]
        public String SendAlerts { get; set; }
        /// <summary>
        /// Gets or sets the SendAlertsDescription.
        /// </summary>
        [DataMember]
        public String SendAlertsDescription { get; set; }
        /// <summary>
        /// Gets or sets the ShareArgsException.
        /// </summary>
        [DataMember]
        public String ShareArgsException { get; set; }
        /// <summary>
        /// Gets or sets the ShareBadGatewayError.
        /// </summary>
        [DataMember]
        public String ShareBadGatewayError { get; set; }
        /// <summary>
        /// Gets or sets the ShareBadRequestError.
        /// </summary>
        [DataMember]
        public String ShareBadRequestError { get; set; }
        /// <summary>
        /// Gets or sets the ShareException.
        /// </summary>
        [DataMember]
        public String ShareException { get; set; }
        /// <summary>
        /// Gets or sets the ShareFacebookCouldNotRetrieveUser.
        /// </summary>
        [DataMember]
        public String ShareFacebookCouldNotRetrieveUser { get; set; }
        /// <summary>
        /// Gets or sets the ShareFacebookCouldNotVerifyToken.
        /// </summary>
        [DataMember]
        public String ShareFacebookCouldNotVerifyToken { get; set; }
        /// <summary>
        /// Gets or sets the ShareFacebookNoResult.
        /// </summary>
        [DataMember]
        public String ShareFacebookNoResult { get; set; }
        /// <summary>
        /// Gets or sets the ShareFacebookPermissionDenied.
        /// </summary>
        [DataMember]
        public String ShareFacebookPermissionDenied { get; set; }
        /// <summary>
        /// Gets or sets the ShareFacebookScopesNotFound.
        /// </summary>
        [DataMember]
        public String ShareFacebookScopesNotFound { get; set; }
        /// <summary>
        /// Gets or sets the ShareFacebookSentSuccessfully.
        /// </summary>
        [DataMember]
        public String ShareFacebookSentSuccessfully { get; set; }
        /// <summary>
        /// Gets or sets the ShareForbidden.
        /// </summary>
        [DataMember]
        public String ShareForbidden { get; set; }
        /// <summary>
        /// Gets or sets the ShareGatewayTimeoutError.
        /// </summary>
        [DataMember]
        public String ShareGatewayTimeoutError { get; set; }
        /// <summary>
        /// Gets or sets the ShareImageNoLongerExists.
        /// </summary>
        [DataMember]
        public String ShareImageNoLongerExists { get; set; }
        /// <summary>
        /// Gets or sets the ShareInternalServerError.
        /// </summary>
        [DataMember]
        public String ShareInternalServerError { get; set; }
        /// <summary>
        /// Gets or sets the ShareMailException.
        /// </summary>
        [DataMember]
        public String ShareMailException { get; set; }
        /// <summary>
        /// Gets or sets the ShareMailPreconfiguredAol.
        /// </summary>
        [DataMember]
        public String ShareMailPreconfiguredAol { get; set; }
        /// <summary>
        /// Gets or sets the ShareMailPreconfiguredComcast.
        /// </summary>
        [DataMember]
        public String ShareMailPreconfiguredComcast { get; set; }
        /// <summary>
        /// Gets or sets the ShareMailPreconfiguredGmail.
        /// </summary>
        [DataMember]
        public String ShareMailPreconfiguredGmail { get; set; }
        /// <summary>
        /// Gets or sets the ShareMailPreconfiguredICloud.
        /// </summary>
        [DataMember]
        public String ShareMailPreconfiguredICloud { get; set; }
        /// <summary>
        /// Gets or sets the ShareMailPreconfiguredManual.
        /// </summary>
        [DataMember]
        public String ShareMailPreconfiguredManual { get; set; }
        /// <summary>
        /// Gets or sets the ShareMailPreconfiguredOutlook.
        /// </summary>
        [DataMember]
        public String ShareMailPreconfiguredOutlook { get; set; }
        /// <summary>
        /// Gets or sets the ShareMailPreconfiguredYahoo.
        /// </summary>
        [DataMember]
        public String ShareMailPreconfiguredYahoo { get; set; }
        /// <summary>
        /// Gets or sets the ShareMailSendError.
        /// </summary>
        [DataMember]
        public String ShareMailSendError { get; set; }
        /// <summary>
        /// Gets or sets the ShareMailSentSuccessfully.
        /// </summary>
        [DataMember]
        public String ShareMailSentSuccessfully { get; set; }
        /// <summary>
        /// Gets or sets the ShareNonSuccessCode.
        /// </summary>
        [DataMember]
        public String ShareNonSuccessCode { get; set; }
        /// <summary>
        /// Gets or sets the ShareNotAuthorized.
        /// </summary>
        [DataMember]
        public String ShareNotAuthorized { get; set; }
        /// <summary>
        /// Gets or sets the ShareServiceParameters.
        /// </summary>
        [DataMember]
        public String ShareServiceParameters { get; set; }
        /// <summary>
        /// Gets or sets the ShareServicePassword.
        /// </summary>
        [DataMember]
        public String ShareServicePassword { get; set; }
        /// <summary>
        /// Gets or sets the ShareServiceSignature.
        /// </summary>
        [DataMember]
        public String ShareServiceSignature { get; set; }
        /// <summary>
        /// Gets or sets the ShareServiceUserName.
        /// </summary>
        [DataMember]
        public String ShareServiceUserName { get; set; }
        /// <summary>
        /// Gets or sets the ShareStockTwitsNoAccount.
        /// </summary>
        [DataMember]
        public String ShareStockTwitsNoAccount { get; set; }
        /// <summary>
        /// Gets or sets the ShareStockTwitsSentSuccessfully.
        /// </summary>
        [DataMember]
        public String ShareStockTwitsSentSuccessfully { get; set; }
        /// <summary>
        /// Gets or sets the ShareTextMessageEmail.
        /// </summary>
        [DataMember]
        public String ShareTextMessageEmail { get; set; }
        /// <summary>
        /// Gets or sets the ShareTextMessageEmailRequired.
        /// </summary>
        [DataMember]
        public String ShareTextMessageEmailRequired { get; set; }
        /// <summary>
        /// Gets or sets the ShareTextMessageErrorOnShare.
        /// </summary>
        [DataMember]
        public String ShareTextMessageErrorOnShare { get; set; }
        /// <summary>
        /// Gets or sets the ShareTextMessageMmsAddress.
        /// </summary>
        [DataMember]
        public String ShareTextMessageMmsAddress { get; set; }
        /// <summary>
        /// Gets or sets the ShareTextMessageName.
        /// </summary>
        [DataMember]
        public String ShareTextMessageName { get; set; }
        /// <summary>
        /// Gets or sets the ShareTextMessagePhoneNumber.
        /// </summary>
        [DataMember]
        public String ShareTextMessagePhoneNumber { get; set; }
        /// <summary>
        /// Gets or sets the ShareTextMessagePreconfiguredAtt.
        /// </summary>
        [DataMember]
        public String ShareTextMessagePreconfiguredAtt { get; set; }
        /// <summary>
        /// Gets or sets the ShareTextMessagePreconfiguredManual.
        /// </summary>
        [DataMember]
        public String ShareTextMessagePreconfiguredManual { get; set; }
        /// <summary>
        /// Gets or sets the ShareTextMessagePreconfiguredSprint.
        /// </summary>
        [DataMember]
        public String ShareTextMessagePreconfiguredSprint { get; set; }
        /// <summary>
        /// Gets or sets the ShareTextMessagePreconfiguredTMobile.
        /// </summary>
        [DataMember]
        public String ShareTextMessagePreconfiguredTMobile { get; set; }
        /// <summary>
        /// Gets or sets the ShareTextMessagePreconfiguredVerizon.
        /// </summary>
        [DataMember]
        public String ShareTextMessagePreconfiguredVerizon { get; set; }
        /// <summary>
        /// Gets or sets the ShareTextMessageSentSuccessfully.
        /// </summary>
        [DataMember]
        public String ShareTextMessageSentSuccessfully { get; set; }
        /// <summary>
        /// Gets or sets the ShareTextMessageSmsAddress.
        /// </summary>
        [DataMember]
        public String ShareTextMessageSmsAddress { get; set; }
        /// <summary>
        /// Gets or sets the ShareTooManyRequests.
        /// </summary>
        [DataMember]
        public String ShareTooManyRequests { get; set; }
        /// <summary>
        /// Gets or sets the ShareTwitterSentSuccessfully.
        /// </summary>
        [DataMember]
        public String ShareTwitterSentSuccessfully { get; set; }
        /// <summary>
        /// Gets or sets the ShowAskLine.
        /// </summary>
        [DataMember]
        public String ShowAskLine { get; set; }
        /// <summary>
        /// Gets or sets the ShowBidLine.
        /// </summary>
        [DataMember]
        public String ShowBidLine { get; set; }
        /// <summary>
        /// Gets or sets the ShowClose.
        /// </summary>
        [DataMember]
        public String ShowClose { get; set; }
        /// <summary>
        /// Gets or sets the ShowHigh.
        /// </summary>
        [DataMember]
        public String ShowHigh { get; set; }
        /// <summary>
        /// Gets or sets the ShowLastLine.
        /// </summary>
        [DataMember]
        public String ShowLastLine { get; set; }
        /// <summary>
        /// Gets or sets the ShowLow.
        /// </summary>
        [DataMember]
        public String ShowLow { get; set; }
        /// <summary>
        /// Gets or sets the ShowOpen.
        /// </summary>
        [DataMember]
        public String ShowOpen { get; set; }
        /// <summary>
        /// Gets or sets the ShowPatternCount.
        /// </summary>
        [DataMember]
        public String ShowPatternCount { get; set; }
        /// <summary>
        /// Gets or sets the ShowPatternCountDescription.
        /// </summary>
        [DataMember]
        public String ShowPatternCountDescription { get; set; }
        /// <summary>
        /// Gets or sets the ShowPercent.
        /// </summary>
        [DataMember]
        public String ShowPercent { get; set; }
        /// <summary>
        /// Gets or sets the SignalPeriod.
        /// </summary>
        [DataMember]
        public String SignalPeriod { get; set; }
        /// <summary>
        /// Gets or sets the Slow.
        /// </summary>
        [DataMember]
        public String Slow { get; set; }
        /// <summary>
        /// Gets or sets the SlowLimit.
        /// </summary>
        [DataMember]
        public String SlowLimit { get; set; }
        /// <summary>
        /// Gets or sets the SlowPeriod.
        /// </summary>
        [DataMember]
        public String SlowPeriod { get; set; }
        /// <summary>
        /// Gets or sets the SmallAreaColor.
        /// </summary>
        [DataMember]
        public String SmallAreaColor { get; set; }
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
        /// Gets or sets the StochasticsD.
        /// </summary>
        [DataMember]
        public String StochasticsD { get; set; }
        /// <summary>
        /// Gets or sets the StochasticsK.
        /// </summary>
        [DataMember]
        public String StochasticsK { get; set; }
        /// <summary>
        /// Gets or sets the StockTwitsSentiment.
        /// </summary>
        [DataMember]
        public String StockTwitsSentiment { get; set; }
        /// <summary>
        /// Gets or sets the StockTwitsSentimentDescription.
        /// </summary>
        [DataMember]
        public String StockTwitsSentimentDescription { get; set; }
        /// <summary>
        /// Gets or sets the StockTwitsServiceName.
        /// </summary>
        [DataMember]
        public String StockTwitsServiceName { get; set; }
        /// <summary>
        /// Gets or sets the StockTwitsSignature.
        /// </summary>
        [DataMember]
        public String StockTwitsSignature { get; set; }
        /// <summary>
        /// Gets or sets the Strength.
        /// </summary>
        [DataMember]
        public String Strength { get; set; }
        /// <summary>
        /// Gets or sets the SuperDomColumnException.
        /// </summary>
        [DataMember]
        public String SuperDomColumnException { get; set; }
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
        /// Gets or sets the TCount.
        /// </summary>
        [DataMember]
        public String TCount { get; set; }
        /// <summary>
        /// Gets or sets the TextColor.
        /// </summary>
        [DataMember]
        public String TextColor { get; set; }
        /// <summary>
        /// Gets or sets the TextFont.
        /// </summary>
        [DataMember]
        public String TextFont { get; set; }
        /// <summary>
        /// Gets or sets the TextFontDescription.
        /// </summary>
        [DataMember]
        public String TextFontDescription { get; set; }
        /// <summary>
        /// Gets or sets the TextPosition_BottomLeft.
        /// </summary>
        [DataMember]
        public String TextPosition_BottomLeft { get; set; }
        /// <summary>
        /// Gets or sets the TextPosition_BottomRight.
        /// </summary>
        [DataMember]
        public String TextPosition_BottomRight { get; set; }
        /// <summary>
        /// Gets or sets the TextPosition_Center.
        /// </summary>
        [DataMember]
        public String TextPosition_Center { get; set; }
        /// <summary>
        /// Gets or sets the TextPosition_TopLeft.
        /// </summary>
        [DataMember]
        public String TextPosition_TopLeft { get; set; }
        /// <summary>
        /// Gets or sets the TextPosition_TopRight.
        /// </summary>
        [DataMember]
        public String TextPosition_TopRight { get; set; }
        /// <summary>
        /// Gets or sets the TickCounterBarError.
        /// </summary>
        [DataMember]
        public String TickCounterBarError { get; set; }
        /// <summary>
        /// Gets or sets the TickCounterTickCount.
        /// </summary>
        [DataMember]
        public String TickCounterTickCount { get; set; }
        /// <summary>
        /// Gets or sets the TickCounterTicksRemaining.
        /// </summary>
        [DataMember]
        public String TickCounterTicksRemaining { get; set; }
        /// <summary>
        /// Gets or sets the TrendLinesCurrentTrendLine.
        /// </summary>
        [DataMember]
        public String TrendLinesCurrentTrendLine { get; set; }
        /// <summary>
        /// Gets or sets the TrendLinesNotVisible.
        /// </summary>
        [DataMember]
        public String TrendLinesNotVisible { get; set; }
        /// <summary>
        /// Gets or sets the TrendLinesTrendLineBroken.
        /// </summary>
        [DataMember]
        public String TrendLinesTrendLineBroken { get; set; }
        /// <summary>
        /// Gets or sets the TrendLinesTrendLineHigh.
        /// </summary>
        [DataMember]
        public String TrendLinesTrendLineHigh { get; set; }
        /// <summary>
        /// Gets or sets the TrendLinesTrendLineLow.
        /// </summary>
        [DataMember]
        public String TrendLinesTrendLineLow { get; set; }
        /// <summary>
        /// Gets or sets the TrendStrength.
        /// </summary>
        [DataMember]
        public String TrendStrength { get; set; }
        /// <summary>
        /// Gets or sets the TrendStrengthDescription.
        /// </summary>
        [DataMember]
        public String TrendStrengthDescription { get; set; }
        /// <summary>
        /// Gets or sets the TRIXSignal.
        /// </summary>
        [DataMember]
        public String TRIXSignal { get; set; }
        /// <summary>
        /// Gets or sets the TwitterAuthHeader.
        /// </summary>
        [DataMember]
        public String TwitterAuthHeader { get; set; }
        /// <summary>
        /// Gets or sets the TwitterAuthText1.
        /// </summary>
        [DataMember]
        public String TwitterAuthText1 { get; set; }
        /// <summary>
        /// Gets or sets the TwitterAuthText2.
        /// </summary>
        [DataMember]
        public String TwitterAuthText2 { get; set; }
        /// <summary>
        /// Gets or sets the TwitterServiceName.
        /// </summary>
        [DataMember]
        public String TwitterServiceName { get; set; }
        /// <summary>
        /// Gets or sets the TwitterSignature.
        /// </summary>
        [DataMember]
        public String TwitterSignature { get; set; }
        /// <summary>
        /// Gets or sets the Unit.
        /// </summary>
        [DataMember]
        public String Unit { get; set; }
        /// <summary>
        /// Gets or sets the UpBarColor.
        /// </summary>
        [DataMember]
        public String UpBarColor { get; set; }
        /// <summary>
        /// Gets or sets the UseHighLow.
        /// </summary>
        [DataMember]
        public String UseHighLow { get; set; }
        /// <summary>
        /// Gets or sets the UserDefinedClose.
        /// </summary>
        [DataMember]
        public String UserDefinedClose { get; set; }
        /// <summary>
        /// Gets or sets the UserDefinedHigh.
        /// </summary>
        [DataMember]
        public String UserDefinedHigh { get; set; }
        /// <summary>
        /// Gets or sets the UserDefinedLow.
        /// </summary>
        [DataMember]
        public String UserDefinedLow { get; set; }
        /// <summary>
        /// Gets or sets the VFactor.
        /// </summary>
        [DataMember]
        public String VFactor { get; set; }
        /// <summary>
        /// Gets or sets the VolatilityPeriod.
        /// </summary>
        [DataMember]
        public String VolatilityPeriod { get; set; }
        /// <summary>
        /// Gets or sets the VolumeCounterBarError.
        /// </summary>
        [DataMember]
        public String VolumeCounterBarError { get; set; }
        /// <summary>
        /// Gets or sets the VolumeCounterVolumeCount.
        /// </summary>
        [DataMember]
        public String VolumeCounterVolumeCount { get; set; }
        /// <summary>
        /// Gets or sets the VolumeCounterVolumeRemaining.
        /// </summary>
        [DataMember]
        public String VolumeCounterVolumeRemaining { get; set; }
        /// <summary>
        /// Gets or sets the VolumeDivisor.
        /// </summary>
        [DataMember]
        public String VolumeDivisor { get; set; }
        /// <summary>
        /// Gets or sets the VolumeDown.
        /// </summary>
        [DataMember]
        public String VolumeDown { get; set; }
        /// <summary>
        /// Gets or sets the VolumeDownColor.
        /// </summary>
        [DataMember]
        public String VolumeDownColor { get; set; }
        /// <summary>
        /// Gets or sets the VolumeNeutralColor.
        /// </summary>
        [DataMember]
        public String VolumeNeutralColor { get; set; }
        /// <summary>
        /// Gets or sets the VolumeUp.
        /// </summary>
        [DataMember]
        public String VolumeUp { get; set; }
        /// <summary>
        /// Gets or sets the VolumeUpColor.
        /// </summary>
        [DataMember]
        public String VolumeUpColor { get; set; }
        /// <summary>
        /// Gets or sets the VOLVolume.
        /// </summary>
        [DataMember]
        public String VOLVolume { get; set; }
        /// <summary>
        /// Gets or sets the Width.
        /// </summary>
        [DataMember]
        public String Width { get; set; }
        /// <summary>
        /// Gets or sets the WilliamsPercentR.
        /// </summary>
        [DataMember]
        public String WilliamsPercentR { get; set; }
        /// <summary>
        /// Gets or sets the ZigZagDeviationValueError.
        /// </summary>
        [DataMember]
        public String ZigZagDeviationValueError { get; set; }
        /// <summary>
        /// Gets or sets the ZigZagHighBarBarsAgoOutOfRange.
        /// </summary>
        [DataMember]
        public String ZigZagHighBarBarsAgoOutOfRange { get; set; }
        /// <summary>
        /// Gets or sets the ZigZagHighBarInstanceGreaterEqual.
        /// </summary>
        [DataMember]
        public String ZigZagHighBarInstanceGreaterEqual { get; set; }
        /// <summary>
        /// Gets or sets the ZigZagLowBarBarsAgoOutOfRange.
        /// </summary>
        [DataMember]
        public String ZigZagLowBarBarsAgoOutOfRange { get; set; }
        /// <summary>
        /// Gets or sets the ZigZagLowBarInstanceGreaterEqual.
        /// </summary>
        [DataMember]
        public String ZigZagLowBarInstanceGreaterEqual { get; set; }
        /// <summary>
        /// Gets or sets the ZigZigHighBarBarsAgoGreaterEqual.
        /// </summary>
        [DataMember]
        public String ZigZigHighBarBarsAgoGreaterEqual { get; set; }
        /// <summary>
        /// Gets or sets the ZigZigLowBarBarsAgoGreaterEqual.
        /// </summary>
        [DataMember]
        public String ZigZigLowBarBarsAgoGreaterEqual { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
