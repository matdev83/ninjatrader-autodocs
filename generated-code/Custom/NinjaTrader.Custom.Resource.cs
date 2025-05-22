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
        public System.Resources.ResourceManager ResourceManager { get; set; }
        /// <summary>
        /// Gets or sets the Culture.
        /// </summary>
        [DataMember]
        public System.Globalization.CultureInfo Culture { get; set; }
        /// <summary>
        /// Gets or sets the Acceleration.
        /// </summary>
        [DataMember]
        public string Acceleration { get; set; }
        /// <summary>
        /// Gets or sets the AccelerationMax.
        /// </summary>
        [DataMember]
        public string AccelerationMax { get; set; }
        /// <summary>
        /// Gets or sets the AccelerationStep.
        /// </summary>
        [DataMember]
        public string AccelerationStep { get; set; }
        /// <summary>
        /// Gets or sets the ADLAD.
        /// </summary>
        [DataMember]
        public string ADLAD { get; set; }
        /// <summary>
        /// Gets or sets the AlertOnBreak.
        /// </summary>
        [DataMember]
        public string AlertOnBreak { get; set; }
        /// <summary>
        /// Gets or sets the AlertOnBreakSound.
        /// </summary>
        [DataMember]
        public string AlertOnBreakSound { get; set; }
        /// <summary>
        /// Gets or sets the AndrewsPitchforkCalculationMethod_ModifiedSchiff.
        /// </summary>
        [DataMember]
        public string AndrewsPitchforkCalculationMethod_ModifiedSchiff { get; set; }
        /// <summary>
        /// Gets or sets the AndrewsPitchforkCalculationMethod_Schiff.
        /// </summary>
        [DataMember]
        public string AndrewsPitchforkCalculationMethod_Schiff { get; set; }
        /// <summary>
        /// Gets or sets the AndrewsPitchforkCalculationMethod_StandardPitchfork.
        /// </summary>
        [DataMember]
        public string AndrewsPitchforkCalculationMethod_StandardPitchfork { get; set; }
        /// <summary>
        /// Gets or sets the AskLineLength.
        /// </summary>
        [DataMember]
        public string AskLineLength { get; set; }
        /// <summary>
        /// Gets or sets the AskLineStroke.
        /// </summary>
        [DataMember]
        public string AskLineStroke { get; set; }
        /// <summary>
        /// Gets or sets the AuthDisclosureText1.
        /// </summary>
        [DataMember]
        public string AuthDisclosureText1 { get; set; }
        /// <summary>
        /// Gets or sets the AuthDisclosureText2.
        /// </summary>
        [DataMember]
        public string AuthDisclosureText2 { get; set; }
        /// <summary>
        /// Gets or sets the BandPct.
        /// </summary>
        [DataMember]
        public string BandPct { get; set; }
        /// <summary>
        /// Gets or sets the BarCount.
        /// </summary>
        [DataMember]
        public string BarCount { get; set; }
        /// <summary>
        /// Gets or sets the BarDown.
        /// </summary>
        [DataMember]
        public string BarDown { get; set; }
        /// <summary>
        /// Gets or sets the BarSpacing.
        /// </summary>
        [DataMember]
        public string BarSpacing { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodType.
        /// </summary>
        [DataMember]
        public string BarsPeriodType { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodTypeNameDay.
        /// </summary>
        [DataMember]
        public string BarsPeriodTypeNameDay { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodTypeNameHeikenAshi.
        /// </summary>
        [DataMember]
        public string BarsPeriodTypeNameHeikenAshi { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodTypeNameKagi.
        /// </summary>
        [DataMember]
        public string BarsPeriodTypeNameKagi { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodTypeNameLineBreak.
        /// </summary>
        [DataMember]
        public string BarsPeriodTypeNameLineBreak { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodTypeNameMinute.
        /// </summary>
        [DataMember]
        public string BarsPeriodTypeNameMinute { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodTypeNameMonth.
        /// </summary>
        [DataMember]
        public string BarsPeriodTypeNameMonth { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodTypeNamePointAndFigure.
        /// </summary>
        [DataMember]
        public string BarsPeriodTypeNamePointAndFigure { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodTypeNameRange.
        /// </summary>
        [DataMember]
        public string BarsPeriodTypeNameRange { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodTypeNameRenko.
        /// </summary>
        [DataMember]
        public string BarsPeriodTypeNameRenko { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodTypeNameSecond.
        /// </summary>
        [DataMember]
        public string BarsPeriodTypeNameSecond { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodTypeNameTick.
        /// </summary>
        [DataMember]
        public string BarsPeriodTypeNameTick { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodTypeNameVolume.
        /// </summary>
        [DataMember]
        public string BarsPeriodTypeNameVolume { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodTypeNameWeek.
        /// </summary>
        [DataMember]
        public string BarsPeriodTypeNameWeek { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodTypeNameYear.
        /// </summary>
        [DataMember]
        public string BarsPeriodTypeNameYear { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodValue.
        /// </summary>
        [DataMember]
        public string BarsPeriodValue { get; set; }
        /// <summary>
        /// Gets or sets the BarTimerDisconnectedError.
        /// </summary>
        [DataMember]
        public string BarTimerDisconnectedError { get; set; }
        /// <summary>
        /// Gets or sets the BarTimerSessionTimeError.
        /// </summary>
        [DataMember]
        public string BarTimerSessionTimeError { get; set; }
        /// <summary>
        /// Gets or sets the BarTimerTimeBasedError.
        /// </summary>
        [DataMember]
        public string BarTimerTimeBasedError { get; set; }
        /// <summary>
        /// Gets or sets the BarTimerTimeRemaining.
        /// </summary>
        [DataMember]
        public string BarTimerTimeRemaining { get; set; }
        /// <summary>
        /// Gets or sets the BarTimerWaitingOnDataError.
        /// </summary>
        [DataMember]
        public string BarTimerWaitingOnDataError { get; set; }
        /// <summary>
        /// Gets or sets the BarUp.
        /// </summary>
        [DataMember]
        public string BarUp { get; set; }
        /// <summary>
        /// Gets or sets the BasePeriod.
        /// </summary>
        [DataMember]
        public string BasePeriod { get; set; }
        /// <summary>
        /// Gets or sets the BidLineLength.
        /// </summary>
        [DataMember]
        public string BidLineLength { get; set; }
        /// <summary>
        /// Gets or sets the BidLineStroke.
        /// </summary>
        [DataMember]
        public string BidLineStroke { get; set; }
        /// <summary>
        /// Gets or sets the BlockTradeSize.
        /// </summary>
        [DataMember]
        public string BlockTradeSize { get; set; }
        /// <summary>
        /// Gets or sets the BollingerLowerBand.
        /// </summary>
        [DataMember]
        public string BollingerLowerBand { get; set; }
        /// <summary>
        /// Gets or sets the BollingerMiddleBand.
        /// </summary>
        [DataMember]
        public string BollingerMiddleBand { get; set; }
        /// <summary>
        /// Gets or sets the BollingerUpperBand.
        /// </summary>
        [DataMember]
        public string BollingerUpperBand { get; set; }
        /// <summary>
        /// Gets or sets the BuySellPressureBuyPressure.
        /// </summary>
        [DataMember]
        public string BuySellPressureBuyPressure { get; set; }
        /// <summary>
        /// Gets or sets the BuySellPressureSellPressure.
        /// </summary>
        [DataMember]
        public string BuySellPressureSellPressure { get; set; }
        /// <summary>
        /// Gets or sets the BuySellVolumeBuys.
        /// </summary>
        [DataMember]
        public string BuySellVolumeBuys { get; set; }
        /// <summary>
        /// Gets or sets the BuySellVolumeSells.
        /// </summary>
        [DataMember]
        public string BuySellVolumeSells { get; set; }
        /// <summary>
        /// Gets or sets the CandlestickPatternFound.
        /// </summary>
        [DataMember]
        public string CandlestickPatternFound { get; set; }
        /// <summary>
        /// Gets or sets the CCILevel1.
        /// </summary>
        [DataMember]
        public string CCILevel1 { get; set; }
        /// <summary>
        /// Gets or sets the CCILevel2.
        /// </summary>
        [DataMember]
        public string CCILevel2 { get; set; }
        /// <summary>
        /// Gets or sets the CCILevelMinus1.
        /// </summary>
        [DataMember]
        public string CCILevelMinus1 { get; set; }
        /// <summary>
        /// Gets or sets the CCILevelMinus2.
        /// </summary>
        [DataMember]
        public string CCILevelMinus2 { get; set; }
        /// <summary>
        /// Gets or sets the ChartSpan_Day.
        /// </summary>
        [DataMember]
        public string ChartSpan_Day { get; set; }
        /// <summary>
        /// Gets or sets the ChartSpan_Min1.
        /// </summary>
        [DataMember]
        public string ChartSpan_Min1 { get; set; }
        /// <summary>
        /// Gets or sets the ChartSpan_Min15.
        /// </summary>
        [DataMember]
        public string ChartSpan_Min15 { get; set; }
        /// <summary>
        /// Gets or sets the ChartSpan_Min240.
        /// </summary>
        [DataMember]
        public string ChartSpan_Min240 { get; set; }
        /// <summary>
        /// Gets or sets the ChartSpan_Min30.
        /// </summary>
        [DataMember]
        public string ChartSpan_Min30 { get; set; }
        /// <summary>
        /// Gets or sets the ChartSpan_Min5.
        /// </summary>
        [DataMember]
        public string ChartSpan_Min5 { get; set; }
        /// <summary>
        /// Gets or sets the ChartSpan_Min60.
        /// </summary>
        [DataMember]
        public string ChartSpan_Min60 { get; set; }
        /// <summary>
        /// Gets or sets the ChartSpan_Month.
        /// </summary>
        [DataMember]
        public string ChartSpan_Month { get; set; }
        /// <summary>
        /// Gets or sets the ChartSpan_Week.
        /// </summary>
        [DataMember]
        public string ChartSpan_Week { get; set; }
        /// <summary>
        /// Gets or sets the ChartSpan_Year.
        /// </summary>
        [DataMember]
        public string ChartSpan_Year { get; set; }
        /// <summary>
        /// Gets or sets the ConstantLines1.
        /// </summary>
        [DataMember]
        public string ConstantLines1 { get; set; }
        /// <summary>
        /// Gets or sets the ConstantLines2.
        /// </summary>
        [DataMember]
        public string ConstantLines2 { get; set; }
        /// <summary>
        /// Gets or sets the ConstantLines3.
        /// </summary>
        [DataMember]
        public string ConstantLines3 { get; set; }
        /// <summary>
        /// Gets or sets the ConstantLines4.
        /// </summary>
        [DataMember]
        public string ConstantLines4 { get; set; }
        /// <summary>
        /// Gets or sets the COT1.
        /// </summary>
        [DataMember]
        public string COT1 { get; set; }
        /// <summary>
        /// Gets or sets the COT2.
        /// </summary>
        [DataMember]
        public string COT2 { get; set; }
        /// <summary>
        /// Gets or sets the COT3.
        /// </summary>
        [DataMember]
        public string COT3 { get; set; }
        /// <summary>
        /// Gets or sets the COT4.
        /// </summary>
        [DataMember]
        public string COT4 { get; set; }
        /// <summary>
        /// Gets or sets the COT5.
        /// </summary>
        [DataMember]
        public string COT5 { get; set; }
        /// <summary>
        /// Gets or sets the CotDataError.
        /// </summary>
        [DataMember]
        public string CotDataError { get; set; }
        /// <summary>
        /// Gets or sets the CotDataStillDownloading.
        /// </summary>
        [DataMember]
        public string CotDataStillDownloading { get; set; }
        /// <summary>
        /// Gets or sets the CotDataWarning.
        /// </summary>
        [DataMember]
        public string CotDataWarning { get; set; }
        /// <summary>
        /// Gets or sets the CountDown.
        /// </summary>
        [DataMember]
        public string CountDown { get; set; }
        /// <summary>
        /// Gets or sets the CountType_Trades.
        /// </summary>
        [DataMember]
        public string CountType_Trades { get; set; }
        /// <summary>
        /// Gets or sets the CountType_Volume.
        /// </summary>
        [DataMember]
        public string CountType_Volume { get; set; }
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
        /// Gets or sets the CustomWindowAddOnBuyMarket.
        /// </summary>
        [DataMember]
        public string CustomWindowAddOnBuyMarket { get; set; }
        /// <summary>
        /// Gets or sets the CustomWindowAddOnSellMarket.
        /// </summary>
        [DataMember]
        public string CustomWindowAddOnSellMarket { get; set; }
        /// <summary>
        /// Gets or sets the CustomWindowSampleDescription.
        /// </summary>
        [DataMember]
        public string CustomWindowSampleDescription { get; set; }
        /// <summary>
        /// Gets or sets the CustomWindowSampleName.
        /// </summary>
        [DataMember]
        public string CustomWindowSampleName { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsTypeDaily.
        /// </summary>
        [DataMember]
        public string DataBarsTypeDaily { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsTypeDay.
        /// </summary>
        [DataMember]
        public string DataBarsTypeDay { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsTypeMinute.
        /// </summary>
        [DataMember]
        public string DataBarsTypeMinute { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsTypeMonth.
        /// </summary>
        [DataMember]
        public string DataBarsTypeMonth { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsTypeMonthly.
        /// </summary>
        [DataMember]
        public string DataBarsTypeMonthly { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsTypePointAndFigure.
        /// </summary>
        [DataMember]
        public string DataBarsTypePointAndFigure { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsTypeRange.
        /// </summary>
        [DataMember]
        public string DataBarsTypeRange { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsTypeRenko.
        /// </summary>
        [DataMember]
        public string DataBarsTypeRenko { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsTypeSecond.
        /// </summary>
        [DataMember]
        public string DataBarsTypeSecond { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsTypeTick.
        /// </summary>
        [DataMember]
        public string DataBarsTypeTick { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsTypeVolume.
        /// </summary>
        [DataMember]
        public string DataBarsTypeVolume { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsTypeWeek.
        /// </summary>
        [DataMember]
        public string DataBarsTypeWeek { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsTypeWeekly.
        /// </summary>
        [DataMember]
        public string DataBarsTypeWeekly { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsTypeYear.
        /// </summary>
        [DataMember]
        public string DataBarsTypeYear { get; set; }
        /// <summary>
        /// Gets or sets the DataBarsTypeYearly.
        /// </summary>
        [DataMember]
        public string DataBarsTypeYearly { get; set; }
        /// <summary>
        /// Gets or sets the Day.
        /// </summary>
        [DataMember]
        public string Day { get; set; }
        /// <summary>
        /// Gets or sets the Days.
        /// </summary>
        [DataMember]
        public string Days { get; set; }
        /// <summary>
        /// Gets or sets the DeviationType.
        /// </summary>
        [DataMember]
        public string DeviationType { get; set; }
        /// <summary>
        /// Gets or sets the DeviationValue.
        /// </summary>
        [DataMember]
        public string DeviationValue { get; set; }
        /// <summary>
        /// Gets or sets the DMMinusDI.
        /// </summary>
        [DataMember]
        public string DMMinusDI { get; set; }
        /// <summary>
        /// Gets or sets the DMPlusDI.
        /// </summary>
        [DataMember]
        public string DMPlusDI { get; set; }
        /// <summary>
        /// Gets or sets the DonchianChannelMean.
        /// </summary>
        [DataMember]
        public string DonchianChannelMean { get; set; }
        /// <summary>
        /// Gets or sets the DownBarColor.
        /// </summary>
        [DataMember]
        public string DownBarColor { get; set; }
        /// <summary>
        /// Gets or sets the DrawingToolIndicatorDescription.
        /// </summary>
        [DataMember]
        public string DrawingToolIndicatorDescription { get; set; }
        /// <summary>
        /// Gets or sets the DrawingToolIndicatorName.
        /// </summary>
        [DataMember]
        public string DrawingToolIndicatorName { get; set; }
        /// <summary>
        /// Gets or sets the DrawLines.
        /// </summary>
        [DataMember]
        public string DrawLines { get; set; }
        /// <summary>
        /// Gets or sets the EMA1.
        /// </summary>
        [DataMember]
        public string EMA1 { get; set; }
        /// <summary>
        /// Gets or sets the EMA2.
        /// </summary>
        [DataMember]
        public string EMA2 { get; set; }
        /// <summary>
        /// Gets or sets the EmailSignature.
        /// </summary>
        [DataMember]
        public string EmailSignature { get; set; }
        /// <summary>
        /// Gets or sets the EnvelopePercentage.
        /// </summary>
        [DataMember]
        public string EnvelopePercentage { get; set; }
        /// <summary>
        /// Gets or sets the FacebookServiceName.
        /// </summary>
        [DataMember]
        public string FacebookServiceName { get; set; }
        /// <summary>
        /// Gets or sets the FacebookSignature.
        /// </summary>
        [DataMember]
        public string FacebookSignature { get; set; }
        /// <summary>
        /// Gets or sets the Fast.
        /// </summary>
        [DataMember]
        public string Fast { get; set; }
        /// <summary>
        /// Gets or sets the FastLimit.
        /// </summary>
        [DataMember]
        public string FastLimit { get; set; }
        /// <summary>
        /// Gets or sets the FastPeriod.
        /// </summary>
        [DataMember]
        public string FastPeriod { get; set; }
        /// <summary>
        /// Gets or sets the FibonacciTextAlignment_ExtremeLeft.
        /// </summary>
        [DataMember]
        public string FibonacciTextAlignment_ExtremeLeft { get; set; }
        /// <summary>
        /// Gets or sets the FibonacciTextAlignment_ExtremeRight.
        /// </summary>
        [DataMember]
        public string FibonacciTextAlignment_ExtremeRight { get; set; }
        /// <summary>
        /// Gets or sets the FibonacciTextAlignment_Left.
        /// </summary>
        [DataMember]
        public string FibonacciTextAlignment_Left { get; set; }
        /// <summary>
        /// Gets or sets the FibonacciTextAlignment_Off.
        /// </summary>
        [DataMember]
        public string FibonacciTextAlignment_Off { get; set; }
        /// <summary>
        /// Gets or sets the FibonacciTextAlignment_Right.
        /// </summary>
        [DataMember]
        public string FibonacciTextAlignment_Right { get; set; }
        /// <summary>
        /// Gets or sets the FileFilterAnyLoadingDialog.
        /// </summary>
        [DataMember]
        public string FileFilterAnyLoadingDialog { get; set; }
        /// <summary>
        /// Gets or sets the FileFilterAnyWinForms.
        /// </summary>
        [DataMember]
        public string FileFilterAnyWinForms { get; set; }
        /// <summary>
        /// Gets or sets the FileName.
        /// </summary>
        [DataMember]
        public string FileName { get; set; }
        /// <summary>
        /// Gets or sets the Font.
        /// </summary>
        [DataMember]
        public string Font { get; set; }
        /// <summary>
        /// Gets or sets the Forecast.
        /// </summary>
        [DataMember]
        public string Forecast { get; set; }
        /// <summary>
        /// Gets or sets the GannFanDirection_DownLeft.
        /// </summary>
        [DataMember]
        public string GannFanDirection_DownLeft { get; set; }
        /// <summary>
        /// Gets or sets the GannFanDirection_DownRight.
        /// </summary>
        [DataMember]
        public string GannFanDirection_DownRight { get; set; }
        /// <summary>
        /// Gets or sets the GannFanDirection_UpLeft.
        /// </summary>
        [DataMember]
        public string GannFanDirection_UpLeft { get; set; }
        /// <summary>
        /// Gets or sets the GannFanDirection_UpRight.
        /// </summary>
        [DataMember]
        public string GannFanDirection_UpRight { get; set; }
        /// <summary>
        /// Gets or sets the GuiAuthorize.
        /// </summary>
        [DataMember]
        public string GuiAuthorize { get; set; }
        /// <summary>
        /// Gets or sets the GuiChartStyleDojiBrush.
        /// </summary>
        [DataMember]
        public string GuiChartStyleDojiBrush { get; set; }
        /// <summary>
        /// Gets or sets the HigherHigh.
        /// </summary>
        [DataMember]
        public string HigherHigh { get; set; }
        /// <summary>
        /// Gets or sets the HigherLow.
        /// </summary>
        [DataMember]
        public string HigherLow { get; set; }
        /// <summary>
        /// Gets or sets the HighlightVerticalRangeUnit_Currency.
        /// </summary>
        [DataMember]
        public string HighlightVerticalRangeUnit_Currency { get; set; }
        /// <summary>
        /// Gets or sets the HighlightVerticalRangeUnit_Percent.
        /// </summary>
        [DataMember]
        public string HighlightVerticalRangeUnit_Percent { get; set; }
        /// <summary>
        /// Gets or sets the HighlightVerticalRangeUnit_Pips.
        /// </summary>
        [DataMember]
        public string HighlightVerticalRangeUnit_Pips { get; set; }
        /// <summary>
        /// Gets or sets the HighlightVerticalRangeUnit_Price.
        /// </summary>
        [DataMember]
        public string HighlightVerticalRangeUnit_Price { get; set; }
        /// <summary>
        /// Gets or sets the HighlightVerticalRangeUnit_Ticks.
        /// </summary>
        [DataMember]
        public string HighlightVerticalRangeUnit_Ticks { get; set; }
        /// <summary>
        /// Gets or sets the HLCCalculationMode.
        /// </summary>
        [DataMember]
        public string HLCCalculationMode { get; set; }
        /// <summary>
        /// Gets or sets the HLCCalculationMode_CalcFromIntradayData.
        /// </summary>
        [DataMember]
        public string HLCCalculationMode_CalcFromIntradayData { get; set; }
        /// <summary>
        /// Gets or sets the HLCCalculationMode_DailyBars.
        /// </summary>
        [DataMember]
        public string HLCCalculationMode_DailyBars { get; set; }
        /// <summary>
        /// Gets or sets the HLCCalculationMode_UserDefinedValues.
        /// </summary>
        [DataMember]
        public string HLCCalculationMode_UserDefinedValues { get; set; }
        /// <summary>
        /// Gets or sets the HLCCalculationModeDescription.
        /// </summary>
        [DataMember]
        public string HLCCalculationModeDescription { get; set; }
        /// <summary>
        /// Gets or sets the Import.
        /// </summary>
        [DataMember]
        public string Import { get; set; }
        /// <summary>
        /// Gets or sets the ImportTypeNinjaTraderBeginningOfBar.
        /// </summary>
        [DataMember]
        public string ImportTypeNinjaTraderBeginningOfBar { get; set; }
        /// <summary>
        /// Gets or sets the ImportTypeNinjaTraderDateTimeFormatError.
        /// </summary>
        [DataMember]
        public string ImportTypeNinjaTraderDateTimeFormatError { get; set; }
        /// <summary>
        /// Gets or sets the ImportTypeNinjaTraderEndOfBar.
        /// </summary>
        [DataMember]
        public string ImportTypeNinjaTraderEndOfBar { get; set; }
        /// <summary>
        /// Gets or sets the ImportTypeNinjaTraderFieldSeparatorNotIdentified.
        /// </summary>
        [DataMember]
        public string ImportTypeNinjaTraderFieldSeparatorNotIdentified { get; set; }
        /// <summary>
        /// Gets or sets the ImportTypeNinjaTraderFormatError.
        /// </summary>
        [DataMember]
        public string ImportTypeNinjaTraderFormatError { get; set; }
        /// <summary>
        /// Gets or sets the ImportTypeNinjaTraderInstrumentNotSupported.
        /// </summary>
        [DataMember]
        public string ImportTypeNinjaTraderInstrumentNotSupported { get; set; }
        /// <summary>
        /// Gets or sets the ImportTypeNinjaTraderNumericPriceFormatError.
        /// </summary>
        [DataMember]
        public string ImportTypeNinjaTraderNumericPriceFormatError { get; set; }
        /// <summary>
        /// Gets or sets the ImportTypeNinjaTraderUnableReadData.
        /// </summary>
        [DataMember]
        public string ImportTypeNinjaTraderUnableReadData { get; set; }
        /// <summary>
        /// Gets or sets the ImportTypeNinjaTraderUnexpectedFieldNumber.
        /// </summary>
        [DataMember]
        public string ImportTypeNinjaTraderUnexpectedFieldNumber { get; set; }
        /// <summary>
        /// Gets or sets the ImportTypeTickData.
        /// </summary>
        [DataMember]
        public string ImportTypeTickData { get; set; }
        /// <summary>
        /// Gets or sets the IncrementalPeriod.
        /// </summary>
        [DataMember]
        public string IncrementalPeriod { get; set; }
        /// <summary>
        /// Gets or sets the Intermediate.
        /// </summary>
        [DataMember]
        public string Intermediate { get; set; }
        /// <summary>
        /// Gets or sets the Interval.
        /// </summary>
        [DataMember]
        public string Interval { get; set; }
        /// <summary>
        /// Gets or sets the KeltnerChannelMidline.
        /// </summary>
        [DataMember]
        public string KeltnerChannelMidline { get; set; }
        /// <summary>
        /// Gets or sets the KeyReversalPlot0.
        /// </summary>
        [DataMember]
        public string KeyReversalPlot0 { get; set; }
        /// <summary>
        /// Gets or sets the LastLineLength.
        /// </summary>
        [DataMember]
        public string LastLineLength { get; set; }
        /// <summary>
        /// Gets or sets the LastLineStroke.
        /// </summary>
        [DataMember]
        public string LastLineStroke { get; set; }
        /// <summary>
        /// Gets or sets the LegendLocation.
        /// </summary>
        [DataMember]
        public string LegendLocation { get; set; }
        /// <summary>
        /// Gets or sets the LegendLocation_BottomLeft.
        /// </summary>
        [DataMember]
        public string LegendLocation_BottomLeft { get; set; }
        /// <summary>
        /// Gets or sets the LegendLocation_BottomRight.
        /// </summary>
        [DataMember]
        public string LegendLocation_BottomRight { get; set; }
        /// <summary>
        /// Gets or sets the LegendLocation_Disabled.
        /// </summary>
        [DataMember]
        public string LegendLocation_Disabled { get; set; }
        /// <summary>
        /// Gets or sets the LegendLocation_TopLeft.
        /// </summary>
        [DataMember]
        public string LegendLocation_TopLeft { get; set; }
        /// <summary>
        /// Gets or sets the LegendLocation_TopRight.
        /// </summary>
        [DataMember]
        public string LegendLocation_TopRight { get; set; }
        /// <summary>
        /// Gets or sets the Length.
        /// </summary>
        [DataMember]
        public string Length { get; set; }
        /// <summary>
        /// Gets or sets the Line1Value.
        /// </summary>
        [DataMember]
        public string Line1Value { get; set; }
        /// <summary>
        /// Gets or sets the Line2Value.
        /// </summary>
        [DataMember]
        public string Line2Value { get; set; }
        /// <summary>
        /// Gets or sets the Line3Value.
        /// </summary>
        [DataMember]
        public string Line3Value { get; set; }
        /// <summary>
        /// Gets or sets the Line4Value.
        /// </summary>
        [DataMember]
        public string Line4Value { get; set; }
        /// <summary>
        /// Gets or sets the LineColor.
        /// </summary>
        [DataMember]
        public string LineColor { get; set; }
        /// <summary>
        /// Gets or sets the Load.
        /// </summary>
        [DataMember]
        public string Load { get; set; }
        /// <summary>
        /// Gets or sets the Location.
        /// </summary>
        [DataMember]
        public string Location { get; set; }
        /// <summary>
        /// Gets or sets the LowerHigh.
        /// </summary>
        [DataMember]
        public string LowerHigh { get; set; }
        /// <summary>
        /// Gets or sets the LowerLow.
        /// </summary>
        [DataMember]
        public string LowerLow { get; set; }
        /// <summary>
        /// Gets or sets the MailCcAddress.
        /// </summary>
        [DataMember]
        public string MailCcAddress { get; set; }
        /// <summary>
        /// Gets or sets the MailCcAddressDescription.
        /// </summary>
        [DataMember]
        public string MailCcAddressDescription { get; set; }
        /// <summary>
        /// Gets or sets the MailServiceMailAddress.
        /// </summary>
        [DataMember]
        public string MailServiceMailAddress { get; set; }
        /// <summary>
        /// Gets or sets the MailServiceName.
        /// </summary>
        [DataMember]
        public string MailServiceName { get; set; }
        /// <summary>
        /// Gets or sets the MailServicePort.
        /// </summary>
        [DataMember]
        public string MailServicePort { get; set; }
        /// <summary>
        /// Gets or sets the MailServiceSenderDisplayName.
        /// </summary>
        [DataMember]
        public string MailServiceSenderDisplayName { get; set; }
        /// <summary>
        /// Gets or sets the MailServiceServer.
        /// </summary>
        [DataMember]
        public string MailServiceServer { get; set; }
        /// <summary>
        /// Gets or sets the MailServiceSSL.
        /// </summary>
        [DataMember]
        public string MailServiceSSL { get; set; }
        /// <summary>
        /// Gets or sets the MailSubject.
        /// </summary>
        [DataMember]
        public string MailSubject { get; set; }
        /// <summary>
        /// Gets or sets the MailSubjectDescription.
        /// </summary>
        [DataMember]
        public string MailSubjectDescription { get; set; }
        /// <summary>
        /// Gets or sets the MailToAddress.
        /// </summary>
        [DataMember]
        public string MailToAddress { get; set; }
        /// <summary>
        /// Gets or sets the MailToAddressDescription.
        /// </summary>
        [DataMember]
        public string MailToAddressDescription { get; set; }
        /// <summary>
        /// Gets or sets the MAMAFAMA.
        /// </summary>
        [DataMember]
        public string MAMAFAMA { get; set; }
        /// <summary>
        /// Gets or sets the MAPeriod.
        /// </summary>
        [DataMember]
        public string MAPeriod { get; set; }
        /// <summary>
        /// Gets or sets the MAType.
        /// </summary>
        [DataMember]
        public string MAType { get; set; }
        /// <summary>
        /// Gets or sets the MovingAverage.
        /// </summary>
        [DataMember]
        public string MovingAverage { get; set; }
        /// <summary>
        /// Gets or sets the MovingAverageRibbonPlot1.
        /// </summary>
        [DataMember]
        public string MovingAverageRibbonPlot1 { get; set; }
        /// <summary>
        /// Gets or sets the MovingAverageRibbonPlot2.
        /// </summary>
        [DataMember]
        public string MovingAverageRibbonPlot2 { get; set; }
        /// <summary>
        /// Gets or sets the MovingAverageRibbonPlot3.
        /// </summary>
        [DataMember]
        public string MovingAverageRibbonPlot3 { get; set; }
        /// <summary>
        /// Gets or sets the MovingAverageRibbonPlot4.
        /// </summary>
        [DataMember]
        public string MovingAverageRibbonPlot4 { get; set; }
        /// <summary>
        /// Gets or sets the MovingAverageRibbonPlot5.
        /// </summary>
        [DataMember]
        public string MovingAverageRibbonPlot5 { get; set; }
        /// <summary>
        /// Gets or sets the MovingAverageRibbonPlot6.
        /// </summary>
        [DataMember]
        public string MovingAverageRibbonPlot6 { get; set; }
        /// <summary>
        /// Gets or sets the MovingAverageRibbonPlot7.
        /// </summary>
        [DataMember]
        public string MovingAverageRibbonPlot7 { get; set; }
        /// <summary>
        /// Gets or sets the MovingAverageRibbonPlot8.
        /// </summary>
        [DataMember]
        public string MovingAverageRibbonPlot8 { get; set; }
        /// <summary>
        /// Gets or sets the NBarsDownTrigger.
        /// </summary>
        [DataMember]
        public string NBarsDownTrigger { get; set; }
        /// <summary>
        /// Gets or sets the NegativeColor.
        /// </summary>
        [DataMember]
        public string NegativeColor { get; set; }
        /// <summary>
        /// Gets or sets the NetChangePosition_BottomLeft.
        /// </summary>
        [DataMember]
        public string NetChangePosition_BottomLeft { get; set; }
        /// <summary>
        /// Gets or sets the NetChangePosition_BottomRight.
        /// </summary>
        [DataMember]
        public string NetChangePosition_BottomRight { get; set; }
        /// <summary>
        /// Gets or sets the NetChangePosition_TopLeft.
        /// </summary>
        [DataMember]
        public string NetChangePosition_TopLeft { get; set; }
        /// <summary>
        /// Gets or sets the NetChangePosition_TopRight.
        /// </summary>
        [DataMember]
        public string NetChangePosition_TopRight { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBackground.
        /// </summary>
        [DataMember]
        public string NinjaScriptBackground { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsTypeDay.
        /// </summary>
        [DataMember]
        public string NinjaScriptBarsTypeDay { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsTypeHeikenAshi.
        /// </summary>
        [DataMember]
        public string NinjaScriptBarsTypeHeikenAshi { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsTypeKagi.
        /// </summary>
        [DataMember]
        public string NinjaScriptBarsTypeKagi { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsTypeKagiReversal.
        /// </summary>
        [DataMember]
        public string NinjaScriptBarsTypeKagiReversal { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsTypeLineBreak.
        /// </summary>
        [DataMember]
        public string NinjaScriptBarsTypeLineBreak { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsTypeLineBreakLineBreaks.
        /// </summary>
        [DataMember]
        public string NinjaScriptBarsTypeLineBreakLineBreaks { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsTypeMinute.
        /// </summary>
        [DataMember]
        public string NinjaScriptBarsTypeMinute { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsTypeMonth.
        /// </summary>
        [DataMember]
        public string NinjaScriptBarsTypeMonth { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsTypePointAndFigure.
        /// </summary>
        [DataMember]
        public string NinjaScriptBarsTypePointAndFigure { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsTypePointAndFigureBoxSize.
        /// </summary>
        [DataMember]
        public string NinjaScriptBarsTypePointAndFigureBoxSize { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsTypePointAndFigureReversal.
        /// </summary>
        [DataMember]
        public string NinjaScriptBarsTypePointAndFigureReversal { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsTypeRange.
        /// </summary>
        [DataMember]
        public string NinjaScriptBarsTypeRange { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsTypeRenko.
        /// </summary>
        [DataMember]
        public string NinjaScriptBarsTypeRenko { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsTypeRenkoBrickSize.
        /// </summary>
        [DataMember]
        public string NinjaScriptBarsTypeRenkoBrickSize { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsTypeSecond.
        /// </summary>
        [DataMember]
        public string NinjaScriptBarsTypeSecond { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsTypeTick.
        /// </summary>
        [DataMember]
        public string NinjaScriptBarsTypeTick { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsTypeVolume.
        /// </summary>
        [DataMember]
        public string NinjaScriptBarsTypeVolume { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBarsTypeWeek.
        /// </summary>
        [DataMember]
        public string NinjaScriptBarsTypeWeek { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptBorder.
        /// </summary>
        [DataMember]
        public string NinjaScriptBorder { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleBarWidth.
        /// </summary>
        [DataMember]
        public string NinjaScriptChartStyleBarWidth { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleBox.
        /// </summary>
        [DataMember]
        public string NinjaScriptChartStyleBox { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleBoxDownBarsColor.
        /// </summary>
        [DataMember]
        public string NinjaScriptChartStyleBoxDownBarsColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleBoxDownBarsOutline.
        /// </summary>
        [DataMember]
        public string NinjaScriptChartStyleBoxDownBarsOutline { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleBoxUpBarsColor.
        /// </summary>
        [DataMember]
        public string NinjaScriptChartStyleBoxUpBarsColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleBoxUpBarsOutline.
        /// </summary>
        [DataMember]
        public string NinjaScriptChartStyleBoxUpBarsOutline { get; set; }
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
        /// Gets or sets the NinjaScriptChartStyleCandlestick.
        /// </summary>
        [DataMember]
        public string NinjaScriptChartStyleCandlestick { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleCandlestickHollow.
        /// </summary>
        [DataMember]
        public string NinjaScriptChartStyleCandlestickHollow { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleCandleUpBarsColor.
        /// </summary>
        [DataMember]
        public string NinjaScriptChartStyleCandleUpBarsColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleCandleWick.
        /// </summary>
        [DataMember]
        public string NinjaScriptChartStyleCandleWick { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleEquivolume.
        /// </summary>
        [DataMember]
        public string NinjaScriptChartStyleEquivolume { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleHeikenAshi.
        /// </summary>
        [DataMember]
        public string NinjaScriptChartStyleHeikenAshi { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleKagi.
        /// </summary>
        [DataMember]
        public string NinjaScriptChartStyleKagi { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleKagiThickLine.
        /// </summary>
        [DataMember]
        public string NinjaScriptChartStyleKagiThickLine { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleKagiThinLine.
        /// </summary>
        [DataMember]
        public string NinjaScriptChartStyleKagiThinLine { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleLineOnClose.
        /// </summary>
        [DataMember]
        public string NinjaScriptChartStyleLineOnClose { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleLineOnCloseColor.
        /// </summary>
        [DataMember]
        public string NinjaScriptChartStyleLineOnCloseColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleLineOnCloseWidth.
        /// </summary>
        [DataMember]
        public string NinjaScriptChartStyleLineOnCloseWidth { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleLineWidth.
        /// </summary>
        [DataMember]
        public string NinjaScriptChartStyleLineWidth { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleMountain.
        /// </summary>
        [DataMember]
        public string NinjaScriptChartStyleMountain { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleMountainColor.
        /// </summary>
        [DataMember]
        public string NinjaScriptChartStyleMountainColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleMountainOutline.
        /// </summary>
        [DataMember]
        public string NinjaScriptChartStyleMountainOutline { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleOHLC.
        /// </summary>
        [DataMember]
        public string NinjaScriptChartStyleOHLC { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleOhlcDownBarsColor.
        /// </summary>
        [DataMember]
        public string NinjaScriptChartStyleOhlcDownBarsColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleOhlcUpBarsColor.
        /// </summary>
        [DataMember]
        public string NinjaScriptChartStyleOhlcUpBarsColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleOpenClose.
        /// </summary>
        [DataMember]
        public string NinjaScriptChartStyleOpenClose { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleOpenCloseDownBarsColor.
        /// </summary>
        [DataMember]
        public string NinjaScriptChartStyleOpenCloseDownBarsColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleOpenCloseDownBarsOutline.
        /// </summary>
        [DataMember]
        public string NinjaScriptChartStyleOpenCloseDownBarsOutline { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleOpenCloseUpBarsColor.
        /// </summary>
        [DataMember]
        public string NinjaScriptChartStyleOpenCloseUpBarsColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStyleOpenCloseUpBarsOutline.
        /// </summary>
        [DataMember]
        public string NinjaScriptChartStyleOpenCloseUpBarsOutline { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStylePointAndFigure.
        /// </summary>
        [DataMember]
        public string NinjaScriptChartStylePointAndFigure { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStylePointAndFigureDownColor.
        /// </summary>
        [DataMember]
        public string NinjaScriptChartStylePointAndFigureDownColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptChartStylePointAndFigureUpColor.
        /// </summary>
        [DataMember]
        public string NinjaScriptChartStylePointAndFigureUpColor { get; set; }
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
        /// Gets or sets the NinjaScriptDrawingToolAnchorExtension.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolAnchorExtension { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolAnchorMiddle.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolAnchorMiddle { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolAnchorStart.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolAnchorStart { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolAnchorText.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolAnchorText { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolAndrewsPitchfork.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolAndrewsPitchfork { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolAndrewsPitchforkCalculationMethod.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolAndrewsPitchforkCalculationMethod { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolAndrewsPitchforkCategoryStrokes.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolAndrewsPitchforkCategoryStrokes { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolAndrewsPitchforkDescription.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolAndrewsPitchforkDescription { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolAndrewsPitchforkExtendLinesBack.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolAndrewsPitchforkExtendLinesBack { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolAndrewsPitchforkExtensionStroke.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolAndrewsPitchforkExtensionStroke { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolAndrewsPitchforkRetracement.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolAndrewsPitchforkRetracement { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolArc.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolArc { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolAreaOpacity.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolAreaOpacity { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolArrowLine.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolArrowLine { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolBackgroundOpacity.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolBackgroundOpacity { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolEllipse.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolEllipse { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolExtendedLine.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolExtendedLine { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolFibonacciCircle.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolFibonacciCircle { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolFibonacciExtensions.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolFibonacciExtensions { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolFibonacciLevelsBaseAnchorLineStroke.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolFibonacciLevelsBaseAnchorLineStroke { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolFibonacciRetracements.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolFibonacciRetracements { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolFibonacciRetracementsExtendLinesLeft.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolFibonacciRetracementsExtendLinesLeft { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolFibonacciRetracementsExtendLinesRight.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolFibonacciRetracementsExtendLinesRight { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolFibonacciRetracementsTextAlignment.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolFibonacciRetracementsTextAlignment { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolFibonacciRetracementsTextLocation.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolFibonacciRetracementsTextLocation { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolFibonacciTimeCircleDivideTimeSeparately.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolFibonacciTimeCircleDivideTimeSeparately { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolFibonacciTimeExtensions.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolFibonacciTimeExtensions { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolFibonacciTimeExtensionsShowText.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolFibonacciTimeExtensionsShowText { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolGannFan.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolGannFan { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolGannFanDisplayText.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolGannFanDisplayText { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolGannFanFanDirection.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolGannFanFanDirection { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolGannFanPointsPerBar.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolGannFanPointsPerBar { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolHorizontalLine.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolHorizontalLine { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolLine.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolLine { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolPath.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolPath { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolPathBegin.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolPathBegin { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolPathEnd.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolPathEnd { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolPathSegment.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolPathSegment { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolPathShowCount.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolPathShowCount { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolPolygon.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolPolygon { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolPriceLevelsOpacity.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolPriceLevelsOpacity { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRay.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolRay { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRectangle.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolRectangle { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRegion.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolRegion { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRegionHighlightDirection.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolRegionHighlightDirection { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRegionHighlightDirectionStroke.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolRegionHighlightDirectionStroke { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRegionHighlightHorizontalTextFormat.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolRegionHighlightHorizontalTextFormat { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRegionHighlightVerticalRangeUnit.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolRegionHighlightVerticalRangeUnit { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRegionHighlightVerticalTextFormat.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolRegionHighlightVerticalTextFormat { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRegionHiglightX.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolRegionHiglightX { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRegionHiglightY.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolRegionHiglightY { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRegressionChannel.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolRegressionChannel { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRegressionChannelLowerChannel.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolRegressionChannelLowerChannel { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRegressionChannelLowerChannelColor.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolRegressionChannelLowerChannelColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRegressionChannelPriceType.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolRegressionChannelPriceType { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRegressionChannelRegressionChannel.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolRegressionChannelRegressionChannel { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRegressionChannelStandardDeviationExtendLeft.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolRegressionChannelStandardDeviationExtendLeft { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRegressionChannelStandardDeviationExtendRight.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolRegressionChannelStandardDeviationExtendRight { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRegressionChannelStandardDeviationLowerDistance.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolRegressionChannelStandardDeviationLowerDistance { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRegressionChannelStandardDeviationUpperDistance.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolRegressionChannelStandardDeviationUpperDistance { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRegressionChannelType.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolRegressionChannelType { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRegressionChannelUpperChannel.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolRegressionChannelUpperChannel { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRegressionChannelUpperChannelColor.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolRegressionChannelUpperChannelColor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRiskRewardAnchorEntry.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolRiskRewardAnchorEntry { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRiskRewardAnchorLineStroke.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolRiskRewardAnchorLineStroke { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRiskRewardAnchorReward.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolRiskRewardAnchorReward { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRiskRewardAnchorRisk.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolRiskRewardAnchorRisk { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRiskRewardCategoryColors.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolRiskRewardCategoryColors { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRiskRewardDescription.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolRiskRewardDescription { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRiskRewardLineStrokeEntry.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolRiskRewardLineStrokeEntry { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRiskRewardLineStrokeReward.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolRiskRewardLineStrokeReward { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRiskRewardLineStrokeRisk.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolRiskRewardLineStrokeRisk { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRiskRewardName.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolRiskRewardName { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRiskRewardRatio.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolRiskRewardRatio { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRuler.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolRuler { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRulerDaysFormat.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolRulerDaysFormat { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRulerNumberBarsText.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolRulerNumberBarsText { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRulerTimeText.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolRulerTimeText { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRulerYValueDisplayUnit.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolRulerYValueDisplayUnit { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolRulerYValueText.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolRulerYValueText { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingTools.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingTools { get; set; }
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
        /// Gets or sets the NinjaScriptDrawingToolsGannAngleRatioX.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolsGannAngleRatioX { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolsGannAngleRatioY.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolsGannAngleRatioY { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolsGannAngles.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolsGannAngles { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolsGannAnglesPrompt.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolsGannAnglesPrompt { get; set; }
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
        /// Gets or sets the NinjaScriptDrawingToolsPriceLevelIsVisible.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolsPriceLevelIsVisible { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolsPriceLevelLineStroke.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolsPriceLevelLineStroke { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolsPriceLevels.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolsPriceLevels { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolsPriceLevelsPrompt.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolsPriceLevelsPrompt { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolsPriceLevelUnset.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolsPriceLevelUnset { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolsPriceLevelValue.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolsPriceLevelValue { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolStroke.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolStroke { get; set; }
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
        /// Gets or sets the NinjaScriptDrawingToolTextBackBrush.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolTextBackBrush { get; set; }
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
        /// Gets or sets the NinjaScriptDrawingToolTimeCycles.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolTimeCycles { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolTrendChannel.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolTrendChannel { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolTrendChannelDescription.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolTrendChannelDescription { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolTrendChannelEnd1AnchorDisplayName.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolTrendChannelEnd1AnchorDisplayName { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolTrendChannelParallelStroke.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolTrendChannelParallelStroke { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolTrendChannelStart1AnchorDisplayName.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolTrendChannelStart1AnchorDisplayName { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolTrendChannelStart2AnchorDisplayName.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolTrendChannelStart2AnchorDisplayName { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolTrendChannelTrendStroke.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolTrendChannelTrendStroke { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolTriangle.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolTriangle { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptDrawingToolVerticalLine.
        /// </summary>
        [DataMember]
        public string NinjaScriptDrawingToolVerticalLine { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptGeneral.
        /// </summary>
        [DataMember]
        public string NinjaScriptGeneral { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptGeneticOptimizerAveragePerformanceOffsetPercent.
        /// </summary>
        [DataMember]
        public string NinjaScriptGeneticOptimizerAveragePerformanceOffsetPercent { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptGeneticOptimizerConvergenceThreshold.
        /// </summary>
        [DataMember]
        public string NinjaScriptGeneticOptimizerConvergenceThreshold { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptGeneticOptimizerCrossoverIndex.
        /// </summary>
        [DataMember]
        public string NinjaScriptGeneticOptimizerCrossoverIndex { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptGeneticOptimizerCrossoverRatePercent.
        /// </summary>
        [DataMember]
        public string NinjaScriptGeneticOptimizerCrossoverRatePercent { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptGeneticOptimizerFastGenerations.
        /// </summary>
        [DataMember]
        public string NinjaScriptGeneticOptimizerFastGenerations { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptGeneticOptimizerGenerations.
        /// </summary>
        [DataMember]
        public string NinjaScriptGeneticOptimizerGenerations { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptGeneticOptimizerGenerationSize.
        /// </summary>
        [DataMember]
        public string NinjaScriptGeneticOptimizerGenerationSize { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptGeneticOptimizerMinimumPerformance.
        /// </summary>
        [DataMember]
        public string NinjaScriptGeneticOptimizerMinimumPerformance { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptGeneticOptimizerMutationRatePercent.
        /// </summary>
        [DataMember]
        public string NinjaScriptGeneticOptimizerMutationRatePercent { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptGeneticOptimizerMutationStrengthPercent.
        /// </summary>
        [DataMember]
        public string NinjaScriptGeneticOptimizerMutationStrengthPercent { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptGeneticOptimizerResetSizePercent.
        /// </summary>
        [DataMember]
        public string NinjaScriptGeneticOptimizerResetSizePercent { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptGeneticOptimizerSlowGenerations.
        /// </summary>
        [DataMember]
        public string NinjaScriptGeneticOptimizerSlowGenerations { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptGeneticOptimizerStabilitySizePercent.
        /// </summary>
        [DataMember]
        public string NinjaScriptGeneticOptimizerStabilitySizePercent { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptGeneticOptimizerThresholdGenerations.
        /// </summary>
        [DataMember]
        public string NinjaScriptGeneticOptimizerThresholdGenerations { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicator.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicator { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorAvg.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorAvg { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorCount.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorCount { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDefault.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDefault { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionADL.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionADL { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionADX.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionADX { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionADXR.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionADXR { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionAPZ.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionAPZ { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionAroon.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionAroon { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionAroonOscillator.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionAroonOscillator { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionATR.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionATR { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionBarTimer.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionBarTimer { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionBlockVolume.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionBlockVolume { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionBollinger.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionBollinger { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionBOP.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionBOP { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionBuySellPressure.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionBuySellPressure { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionBuySellVolume.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionBuySellVolume { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionCamarillaPivots.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionCamarillaPivots { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionCandlestickPattern.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionCandlestickPattern { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionCCI.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionCCI { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionChaikinMoneyFlow.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionChaikinMoneyFlow { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionChaikinOscillator.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionChaikinOscillator { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionChaikinVolatility.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionChaikinVolatility { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionChoppinessIndex.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionChoppinessIndex { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionCMO.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionCMO { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionConstantLines.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionConstantLines { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionCorrelation.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionCorrelation { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionCOT.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionCOT { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionCurrentDayOHL.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionCurrentDayOHL { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionDarvas.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionDarvas { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionDEMA.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionDEMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionDisparityIndex.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionDisparityIndex { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionDM.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionDM { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionDMI.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionDMI { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionDMIndex.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionDMIndex { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionDonchianChannel.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionDonchianChannel { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionDoubleStochastics.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionDoubleStochastics { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionEaseOfMovement.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionEaseOfMovement { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionEMA.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionEMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionFibonacciPivots.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionFibonacciPivots { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionFisherTransform.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionFisherTransform { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionFOSC.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionFOSC { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionHMA.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionHMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionKAMA.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionKAMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionKeltnerChannel.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionKeltnerChannel { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionKeyReversalDown.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionKeyReversalDown { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionKeyReversalUp.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionKeyReversalUp { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionLinReg.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionLinReg { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionLinRegIntercept.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionLinRegIntercept { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionLinRegSlope.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionLinRegSlope { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionMACD.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionMACD { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionMAEnvelopes.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionMAEnvelopes { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionMAMA.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionMAMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionMAX.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionMAX { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionMcClellanOscillator.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionMcClellanOscillator { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionMFI.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionMFI { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionMIN.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionMIN { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionMomentum.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionMomentum { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionMoneyFlowOscillator.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionMoneyFlowOscillator { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionMovingAverageRibbon.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionMovingAverageRibbon { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionNBarsDown.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionNBarsDown { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionNBarsUp.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionNBarsUp { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionNetChangeDisplay.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionNetChangeDisplay { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionOBV.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionOBV { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionParabolicSAR.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionParabolicSAR { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionPFE.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionPFE { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionPivots.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionPivots { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionPPO.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionPPO { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionPriceLine.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionPriceLine { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionPriceOscillator.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionPriceOscillator { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionPriorDayOHLC.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionPriorDayOHLC { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionPsychologicalLine.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionPsychologicalLine { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionRange.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionRange { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionRangeCounter.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionRangeCounter { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionRegressionChannel.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionRegressionChannel { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionRelativeVigorIndex.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionRelativeVigorIndex { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionRIND.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionRIND { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionROC.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionROC { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionRSI.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionRSI { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionRSquared.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionRSquared { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionRSS.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionRSS { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionRVI.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionRVI { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionSampleCustomRender.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionSampleCustomRender { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionSMA.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionSMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionStdDev.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionStdDev { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionStdError.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionStdError { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionStochastics.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionStochastics { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionStochasticsFast.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionStochasticsFast { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionStochRSI.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionStochRSI { get; set; }
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
        /// Gets or sets the NinjaScriptIndicatorDescriptionT3.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionT3 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionTEMA.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionTEMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionTickCounter.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionTickCounter { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionTMA.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionTMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionTrendLines.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionTrendLines { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionTRIX.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionTRIX { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionTSF.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionTSF { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionTSI.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionTSI { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionUltimateOscillator.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionUltimateOscillator { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionVMA.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionVMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionVOL.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionVOL { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionVOLMA.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionVOLMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionVolumeCounter.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionVolumeCounter { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionVolumeOscillator.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionVolumeOscillator { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionVolumeProfile.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionVolumeProfile { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionVolumeUpDown.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionVolumeUpDown { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionVolumeZones.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionVolumeZones { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionVortex.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionVortex { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionVROC.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionVROC { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionVWMA.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionVWMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionWilliamsR.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionWilliamsR { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionWMA.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionWMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionZigZag.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionZigZag { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDescriptionZLEMA.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDescriptionZLEMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDiff.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDiff { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDisparityLine.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDisparityLine { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorDown.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorDown { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorLower.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorLower { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorMcClellanOscillatorLine.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorMcClellanOscillatorLine { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorMiddle.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorMiddle { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorMoneyFlowLine.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorMoneyFlowLine { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameADL.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameADL { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameADX.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameADX { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameADXR.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameADXR { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameAPZ.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameAPZ { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameAroon.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameAroon { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameAroonOscillator.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameAroonOscillator { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameATR.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameATR { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameBarTimer.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameBarTimer { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameBlockVolume.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameBlockVolume { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameBollinger.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameBollinger { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameBOP.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameBOP { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameBuySellPressure.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameBuySellPressure { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameBuySellVolume.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameBuySellVolume { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameCamarillaPivots.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameCamarillaPivots { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameCandlestickPattern.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameCandlestickPattern { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameCCI.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameCCI { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameChaikinMoneyFlow.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameChaikinMoneyFlow { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameChaikinOscillator.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameChaikinOscillator { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameChaikinVolatility.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameChaikinVolatility { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameChoppinessIndex.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameChoppinessIndex { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameCMO.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameCMO { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameConstantLines.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameConstantLines { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameCorrelation.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameCorrelation { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameCOT.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameCOT { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameCurrentDayOHL.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameCurrentDayOHL { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameDarvas.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameDarvas { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameDEMA.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameDEMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameDisparityIndex.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameDisparityIndex { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameDM.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameDM { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameDMI.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameDMI { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameDMIndex.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameDMIndex { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameDonchianChannel.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameDonchianChannel { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameDoubleStochastics.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameDoubleStochastics { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameEaseOfMovement.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameEaseOfMovement { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameEMA.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameEMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameFibonacciPivots.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameFibonacciPivots { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameFisherTransform.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameFisherTransform { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameFOSC.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameFOSC { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameHMA.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameHMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameKAMA.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameKAMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameKelterChannel.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameKelterChannel { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameKeyReversalDown.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameKeyReversalDown { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameKeyReversalUp.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameKeyReversalUp { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameLinReg.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameLinReg { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameLinRegIntercept.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameLinRegIntercept { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameLinRegSlope.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameLinRegSlope { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameMACD.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameMACD { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameMAEnvelopes.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameMAEnvelopes { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameMAMA.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameMAMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameMAX.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameMAX { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameMcClellanOscillator.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameMcClellanOscillator { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameMFI.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameMFI { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameMIN.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameMIN { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameMomentum.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameMomentum { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameMoneyFlowOscillator.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameMoneyFlowOscillator { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameMovingAverageRibbon.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameMovingAverageRibbon { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameNBarsDown.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameNBarsDown { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameNBarsUp.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameNBarsUp { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameNetChangeDisplay.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameNetChangeDisplay { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameOBV.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameOBV { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameParabolicSAR.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameParabolicSAR { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNamePFE.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNamePFE { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNamePivots.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNamePivots { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNamePPO.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNamePPO { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNamePriceLine.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNamePriceLine { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNamePriceOscillator.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNamePriceOscillator { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNamePriorDayOHLC.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNamePriorDayOHLC { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNamePsychologicalLine.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNamePsychologicalLine { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameRange.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameRange { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameRangeCounter.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameRangeCounter { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameRegressionChannel.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameRegressionChannel { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameRelativeVigorIndex.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameRelativeVigorIndex { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameRIND.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameRIND { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameROC.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameROC { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameRSI.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameRSI { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameRSquared.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameRSquared { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameRSS.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameRSS { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameRVI.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameRVI { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameSampleCustomRender.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameSampleCustomRender { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameSMA.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameSMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameStdDev.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameStdDev { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameStdError.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameStdError { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameStochastics.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameStochastics { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameStochasticsFast.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameStochasticsFast { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameStochRSI.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameStochRSI { get; set; }
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
        /// Gets or sets the NinjaScriptIndicatorNameT3.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameT3 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameTEMA.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameTEMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameTickCounter.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameTickCounter { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameTMA.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameTMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameTrendLines.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameTrendLines { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameTRIX.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameTRIX { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameTSF.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameTSF { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameTSI.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameTSI { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameUltimateOscillator.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameUltimateOscillator { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameVMA.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameVMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameVOL.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameVOL { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameVOLMA.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameVOLMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameVolumeCounter.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameVolumeCounter { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameVolumeOscillator.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameVolumeOscillator { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameVolumeProfile.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameVolumeProfile { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameVolumesZones.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameVolumesZones { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameVolumeUpDown.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameVolumeUpDown { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameVortex.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameVortex { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameVROC.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameVROC { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameVWMA.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameVWMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameWilliamsR.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameWilliamsR { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameWMA.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameWMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameZigZag.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameZigZag { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNameZLEMA.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNameZLEMA { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorNeutral.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorNeutral { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorOverbought.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorOverbought { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorOverBoughtLine.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorOverBoughtLine { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorOversold.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorOversold { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorOverSoldLine.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorOverSoldLine { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorRelativeVigorIndex.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorRelativeVigorIndex { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorSignal.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorSignal { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorUp.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorUp { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorUpper.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorUpper { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorVIMinus.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorVIMinus { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorVIPlus.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorVIPlus { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorVisualGroup.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorVisualGroup { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIndicatorZeroLine.
        /// </summary>
        [DataMember]
        public string NinjaScriptIndicatorZeroLine { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptIsVisibleOnlyFocused.
        /// </summary>
        [DataMember]
        public string NinjaScriptIsVisibleOnlyFocused { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptLine.
        /// </summary>
        [DataMember]
        public string NinjaScriptLine { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptLines.
        /// </summary>
        [DataMember]
        public string NinjaScriptLines { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptLoadingData.
        /// </summary>
        [DataMember]
        public string NinjaScriptLoadingData { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionAskPrice.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionAskPrice { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionAskSize.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionAskSize { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionAverageDailyVolume.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionAverageDailyVolume { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionBeta.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionBeta { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionBidAskSpread.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionBidAskSpread { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionBidPrice.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionBidPrice { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionBidSize.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionBidSize { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionCalendarYearHigh.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionCalendarYearHigh { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionCalendarYearHighDate.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionCalendarYearHighDate { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionCalendarYearLow.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionCalendarYearLow { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionCalendarYearLowDate.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionCalendarYearLowDate { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionChartMini.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionChartMini { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionChartNetChange.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionChartNetChange { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionCurrentRatio.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionCurrentRatio { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionDailyHigh.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionDailyHigh { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionDailyLow.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionDailyLow { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionDailyVolume.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionDailyVolume { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionDaysUntilRollover.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionDaysUntilRollover { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionDescription.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionDescription { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionDividendAmount.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionDividendAmount { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionDividendPayDate.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionDividendPayDate { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionDividendYield.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionDividendYield { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionEarningsPerShare.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionEarningsPerShare { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionFiveYearsGrowthPercentage.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionFiveYearsGrowthPercentage { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionHigh52Weeks.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionHigh52Weeks { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionHigh52WeeksDate.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionHigh52WeeksDate { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionHistoricalVolatility.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionHistoricalVolatility { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionInstrument.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionInstrument { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionLastClose.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionLastClose { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionLastPrice.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionLastPrice { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionLastSize.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionLastSize { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionLow52Weeks.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionLow52Weeks { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionLow52WeeksDate.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionLow52WeeksDate { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionMarketCap.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionMarketCap { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionMarketPrice.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionMarketPrice { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionNetChange.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionNetChange { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionNetChangeMaxDown.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionNetChangeMaxDown { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionNetChangeMaxUp.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionNetChangeMaxUp { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionNextYearsEarningsPerShare.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionNextYearsEarningsPerShare { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionNotes.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionNotes { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionOpening.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionOpening { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionOpenInterest.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionOpenInterest { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionPercentHeldByInstitutions.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionPercentHeldByInstitutions { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionPositionAvgPrice.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionPositionAvgPrice { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionPositionSize.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionPositionSize { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionPriceEarningsRatio.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionPriceEarningsRatio { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionProfitLoss.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionProfitLoss { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionRealizedProfitLoss.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionRealizedProfitLoss { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionRevenuePerShare.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionRevenuePerShare { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionSettlement.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionSettlement { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionSharesOutstanding.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionSharesOutstanding { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionShortInterest.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionShortInterest { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionShortInterestRatio.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionShortInterestRatio { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionTimeLastTick.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionTimeLastTick { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionTradedContracts.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionTradedContracts { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionTSTrend.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionTSTrend { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionUnrealizedProfitLoss.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionUnrealizedProfitLoss { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnDescriptionVwap.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnDescriptionVwap { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameAskPrice.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameAskPrice { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameAskSize.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameAskSize { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameAverageDailyVolume.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameAverageDailyVolume { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameBeta.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameBeta { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameBidAskSpread.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameBidAskSpread { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameBidPrice.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameBidPrice { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameBidSize.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameBidSize { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameCalendarYearHigh.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameCalendarYearHigh { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameCalendarYearHighDate.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameCalendarYearHighDate { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameCalendarYearLow.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameCalendarYearLow { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameCalendarYearLowDate.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameCalendarYearLowDate { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameChartMini.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameChartMini { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameChartNetChange.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameChartNetChange { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameCurrentRatio.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameCurrentRatio { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameDailyHigh.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameDailyHigh { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameDailyLow.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameDailyLow { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameDailyVolume.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameDailyVolume { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameDaysUntilRollover.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameDaysUntilRollover { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameDescription.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameDescription { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameDividendAmount.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameDividendAmount { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameDividendPayDate.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameDividendPayDate { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameDividendYield.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameDividendYield { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameEarningsPerShare.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameEarningsPerShare { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameFiveYearsGrowthPercentage.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameFiveYearsGrowthPercentage { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameHigh52Weeks.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameHigh52Weeks { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameHigh52WeeksDate.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameHigh52WeeksDate { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameHistoricalVolatility.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameHistoricalVolatility { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameInstrument.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameInstrument { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameLastClose.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameLastClose { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameLastPrice.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameLastPrice { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameLastSize.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameLastSize { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameLow52Weeks.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameLow52Weeks { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameLow52WeeksDate.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameLow52WeeksDate { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameMarketCap.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameMarketCap { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameMarketPrice.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameMarketPrice { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameNetChange.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameNetChange { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameNetChangeMaxDown.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameNetChangeMaxDown { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameNetChangeMaxUp.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameNetChangeMaxUp { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameNextYearsEarningsPerShare.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameNextYearsEarningsPerShare { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameNotes.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameNotes { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameOpening.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameOpening { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameOpenInterest.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameOpenInterest { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNamePercentHeldByInstitutions.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNamePercentHeldByInstitutions { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNamePositionAvgPrice.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNamePositionAvgPrice { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNamePositionSize.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNamePositionSize { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNamePriceEarningsRatio.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNamePriceEarningsRatio { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameProfitLoss.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameProfitLoss { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameRealizedProfitLoss.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameRealizedProfitLoss { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameRevenuePerShare.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameRevenuePerShare { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameSettlement.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameSettlement { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameSharesOutstanding.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameSharesOutstanding { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameShortInterest.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameShortInterest { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameShortInterestRatio.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameShortInterestRatio { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameTimeLastTick.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameTimeLastTick { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameTradedContracts.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameTradedContracts { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameTSTrend.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameTSTrend { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameUnrealizedProfitLoss.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameUnrealizedProfitLoss { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptMarketAnalyzerColumnNameVwap.
        /// </summary>
        [DataMember]
        public string NinjaScriptMarketAnalyzerColumnNameVwap { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptNumberOfRows.
        /// </summary>
        [DataMember]
        public string NinjaScriptNumberOfRows { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOnBarCloseError.
        /// </summary>
        [DataMember]
        public string NinjaScriptOnBarCloseError { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOnPriceChangeError.
        /// </summary>
        [DataMember]
        public string NinjaScriptOnPriceChangeError { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxAvgMfe.
        /// </summary>
        [DataMember]
        public string NinjaScriptOptimizationFitnessNameMaxAvgMfe { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxAvgMfeLong.
        /// </summary>
        [DataMember]
        public string NinjaScriptOptimizationFitnessNameMaxAvgMfeLong { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxAvgMfeShort.
        /// </summary>
        [DataMember]
        public string NinjaScriptOptimizationFitnessNameMaxAvgMfeShort { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxAvgProfit.
        /// </summary>
        [DataMember]
        public string NinjaScriptOptimizationFitnessNameMaxAvgProfit { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxAvgProfitLong.
        /// </summary>
        [DataMember]
        public string NinjaScriptOptimizationFitnessNameMaxAvgProfitLong { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxAvgProfitShort.
        /// </summary>
        [DataMember]
        public string NinjaScriptOptimizationFitnessNameMaxAvgProfitShort { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxNetProfit.
        /// </summary>
        [DataMember]
        public string NinjaScriptOptimizationFitnessNameMaxNetProfit { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxNetProfitLong.
        /// </summary>
        [DataMember]
        public string NinjaScriptOptimizationFitnessNameMaxNetProfitLong { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxNetProfitShort.
        /// </summary>
        [DataMember]
        public string NinjaScriptOptimizationFitnessNameMaxNetProfitShort { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxPercentProfitable.
        /// </summary>
        [DataMember]
        public string NinjaScriptOptimizationFitnessNameMaxPercentProfitable { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxPercentProfitableLong.
        /// </summary>
        [DataMember]
        public string NinjaScriptOptimizationFitnessNameMaxPercentProfitableLong { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxPercentProfitableShort.
        /// </summary>
        [DataMember]
        public string NinjaScriptOptimizationFitnessNameMaxPercentProfitableShort { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxProbablity.
        /// </summary>
        [DataMember]
        public string NinjaScriptOptimizationFitnessNameMaxProbablity { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxProbablityLong.
        /// </summary>
        [DataMember]
        public string NinjaScriptOptimizationFitnessNameMaxProbablityLong { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxProbablityShort.
        /// </summary>
        [DataMember]
        public string NinjaScriptOptimizationFitnessNameMaxProbablityShort { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxProfitFactor.
        /// </summary>
        [DataMember]
        public string NinjaScriptOptimizationFitnessNameMaxProfitFactor { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxProfitFactorLong.
        /// </summary>
        [DataMember]
        public string NinjaScriptOptimizationFitnessNameMaxProfitFactorLong { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxProfitFactorShort.
        /// </summary>
        [DataMember]
        public string NinjaScriptOptimizationFitnessNameMaxProfitFactorShort { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxR2.
        /// </summary>
        [DataMember]
        public string NinjaScriptOptimizationFitnessNameMaxR2 { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxR2Long.
        /// </summary>
        [DataMember]
        public string NinjaScriptOptimizationFitnessNameMaxR2Long { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxR2Short.
        /// </summary>
        [DataMember]
        public string NinjaScriptOptimizationFitnessNameMaxR2Short { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxSharpeRatio.
        /// </summary>
        [DataMember]
        public string NinjaScriptOptimizationFitnessNameMaxSharpeRatio { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxSharpeRatioLong.
        /// </summary>
        [DataMember]
        public string NinjaScriptOptimizationFitnessNameMaxSharpeRatioLong { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxSharpeRatioShort.
        /// </summary>
        [DataMember]
        public string NinjaScriptOptimizationFitnessNameMaxSharpeRatioShort { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxSortinoRatio.
        /// </summary>
        [DataMember]
        public string NinjaScriptOptimizationFitnessNameMaxSortinoRatio { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxSortinoRatioLong.
        /// </summary>
        [DataMember]
        public string NinjaScriptOptimizationFitnessNameMaxSortinoRatioLong { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxSortinoRatioShort.
        /// </summary>
        [DataMember]
        public string NinjaScriptOptimizationFitnessNameMaxSortinoRatioShort { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxStrength.
        /// </summary>
        [DataMember]
        public string NinjaScriptOptimizationFitnessNameMaxStrength { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxStrengthLong.
        /// </summary>
        [DataMember]
        public string NinjaScriptOptimizationFitnessNameMaxStrengthLong { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxStrengthShort.
        /// </summary>
        [DataMember]
        public string NinjaScriptOptimizationFitnessNameMaxStrengthShort { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxUlcerRatio.
        /// </summary>
        [DataMember]
        public string NinjaScriptOptimizationFitnessNameMaxUlcerRatio { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxUlcerRatioLong.
        /// </summary>
        [DataMember]
        public string NinjaScriptOptimizationFitnessNameMaxUlcerRatioLong { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxUlcerRatioShort.
        /// </summary>
        [DataMember]
        public string NinjaScriptOptimizationFitnessNameMaxUlcerRatioShort { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxWinLossRatio.
        /// </summary>
        [DataMember]
        public string NinjaScriptOptimizationFitnessNameMaxWinLossRatio { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxWinLossRatioLong.
        /// </summary>
        [DataMember]
        public string NinjaScriptOptimizationFitnessNameMaxWinLossRatioLong { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMaxWinLossRatioShort.
        /// </summary>
        [DataMember]
        public string NinjaScriptOptimizationFitnessNameMaxWinLossRatioShort { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMinAvgMae.
        /// </summary>
        [DataMember]
        public string NinjaScriptOptimizationFitnessNameMinAvgMae { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMinAvgMaeLong.
        /// </summary>
        [DataMember]
        public string NinjaScriptOptimizationFitnessNameMinAvgMaeLong { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMinAvgMaeShort.
        /// </summary>
        [DataMember]
        public string NinjaScriptOptimizationFitnessNameMinAvgMaeShort { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMinDrawDown.
        /// </summary>
        [DataMember]
        public string NinjaScriptOptimizationFitnessNameMinDrawDown { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMinDrawDownLong.
        /// </summary>
        [DataMember]
        public string NinjaScriptOptimizationFitnessNameMinDrawDownLong { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizationFitnessNameMinDrawDownShort.
        /// </summary>
        [DataMember]
        public string NinjaScriptOptimizationFitnessNameMinDrawDownShort { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizerDefault.
        /// </summary>
        [DataMember]
        public string NinjaScriptOptimizerDefault { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptOptimizerGenetic.
        /// </summary>
        [DataMember]
        public string NinjaScriptOptimizerGenetic { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptParameters.
        /// </summary>
        [DataMember]
        public string NinjaScriptParameters { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptRecentColumnAskBackground.
        /// </summary>
        [DataMember]
        public string NinjaScriptRecentColumnAskBackground { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptRecentColumnAskForeground.
        /// </summary>
        [DataMember]
        public string NinjaScriptRecentColumnAskForeground { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptRecentColumnBidBackground.
        /// </summary>
        [DataMember]
        public string NinjaScriptRecentColumnBidBackground { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptRecentColumnBidForeground.
        /// </summary>
        [DataMember]
        public string NinjaScriptRecentColumnBidForeground { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptRecentColumnDiplay.
        /// </summary>
        [DataMember]
        public string NinjaScriptRecentColumnDiplay { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptRecentColumnResetTolerance.
        /// </summary>
        [DataMember]
        public string NinjaScriptRecentColumnResetTolerance { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptRecentColumnResetWhen.
        /// </summary>
        [DataMember]
        public string NinjaScriptRecentColumnResetWhen { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptSetup.
        /// </summary>
        [DataMember]
        public string NinjaScriptSetup { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyDescriptionSampleATMStrategy.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyDescriptionSampleATMStrategy { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyDescriptionSampleCustomPerformance.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyDescriptionSampleCustomPerformance { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyDescriptionSampleFramework.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyDescriptionSampleFramework { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyDescriptionSampleMACrossOver.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyDescriptionSampleMACrossOver { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyDescriptionSampleMultiInstrument.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyDescriptionSampleMultiInstrument { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyDescriptionSampleMultiTimeFrame.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyDescriptionSampleMultiTimeFrame { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyGenerator.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyGenerator { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyGeneratorCandleStickPatternPrompt.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyGeneratorCandleStickPatternPrompt { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyGeneratorEntries.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyGeneratorEntries { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyGeneratorEntriesOrExits.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyGeneratorEntriesOrExits { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyGeneratorIndicatorException.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyGeneratorIndicatorException { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyGeneratorIndicatorsPrompt.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyGeneratorIndicatorsPrompt { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyGeneratorPeformance.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyGeneratorPeformance { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyGeneratorProperties.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyGeneratorProperties { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyGeneratorTerminated.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyGeneratorTerminated { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyGeneratorUseCandleStickPattern.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyGeneratorUseCandleStickPattern { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyGeneratorUseIndicators.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyGeneratorUseIndicators { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyNameSampleATMStrategy.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyNameSampleATMStrategy { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyNameSampleCustomPerformance.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyNameSampleCustomPerformance { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyNameSampleFramework.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyNameSampleFramework { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyNameSampleMACrossOver.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyNameSampleMACrossOver { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyNameSampleMultiInstrument.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyNameSampleMultiInstrument { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyNameSampleMultiTimeFrame.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyNameSampleMultiTimeFrame { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptStrategyParameters.
        /// </summary>
        [DataMember]
        public string NinjaScriptStrategyParameters { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptSuperDomColumnApq.
        /// </summary>
        [DataMember]
        public string NinjaScriptSuperDomColumnApq { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptSuperDomColumnBaseInitializeBarsPoolError.
        /// </summary>
        [DataMember]
        public string NinjaScriptSuperDomColumnBaseInitializeBarsPoolError { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptSuperDomColumnDescriptionApq.
        /// </summary>
        [DataMember]
        public string NinjaScriptSuperDomColumnDescriptionApq { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptSuperDomColumnDescriptionNotes.
        /// </summary>
        [DataMember]
        public string NinjaScriptSuperDomColumnDescriptionNotes { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptSuperDomColumnDescriptionPnl.
        /// </summary>
        [DataMember]
        public string NinjaScriptSuperDomColumnDescriptionPnl { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptSuperDomColumnDescriptionVolume.
        /// </summary>
        [DataMember]
        public string NinjaScriptSuperDomColumnDescriptionVolume { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptSuperDomColumnNotes.
        /// </summary>
        [DataMember]
        public string NinjaScriptSuperDomColumnNotes { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptSuperDomColumnProfitAndLoss.
        /// </summary>
        [DataMember]
        public string NinjaScriptSuperDomColumnProfitAndLoss { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptSuperDomColumnVolume.
        /// </summary>
        [DataMember]
        public string NinjaScriptSuperDomColumnVolume { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptTileError.
        /// </summary>
        [DataMember]
        public string NinjaScriptTileError { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScriptYOffset.
        /// </summary>
        [DataMember]
        public string NinjaScriptYOffset { get; set; }
        /// <summary>
        /// Gets or sets the NumberOfCotPlots.
        /// </summary>
        [DataMember]
        public string NumberOfCotPlots { get; set; }
        /// <summary>
        /// Gets or sets the NumberOfTrendLines.
        /// </summary>
        [DataMember]
        public string NumberOfTrendLines { get; set; }
        /// <summary>
        /// Gets or sets the NumStdDev.
        /// </summary>
        [DataMember]
        public string NumStdDev { get; set; }
        /// <summary>
        /// Gets or sets the OffsetMultiplier.
        /// </summary>
        [DataMember]
        public string OffsetMultiplier { get; set; }
        /// <summary>
        /// Gets or sets the OldTrendsOpacity.
        /// </summary>
        [DataMember]
        public string OldTrendsOpacity { get; set; }
        /// <summary>
        /// Gets or sets the Opacity.
        /// </summary>
        [DataMember]
        public string Opacity { get; set; }
        /// <summary>
        /// Gets or sets the PathCapMode_Arrow.
        /// </summary>
        [DataMember]
        public string PathCapMode_Arrow { get; set; }
        /// <summary>
        /// Gets or sets the PathCapMode_Line.
        /// </summary>
        [DataMember]
        public string PathCapMode_Line { get; set; }
        /// <summary>
        /// Gets or sets the PathToolCapMode_Arrow.
        /// </summary>
        [DataMember]
        public string PathToolCapMode_Arrow { get; set; }
        /// <summary>
        /// Gets or sets the PathToolCapMode_Line.
        /// </summary>
        [DataMember]
        public string PathToolCapMode_Line { get; set; }
        /// <summary>
        /// Gets or sets the PerformanceMetricSampleCumProfit.
        /// </summary>
        [DataMember]
        public string PerformanceMetricSampleCumProfit { get; set; }
        /// <summary>
        /// Gets or sets the Period.
        /// </summary>
        [DataMember]
        public string Period { get; set; }
        /// <summary>
        /// Gets or sets the PeriodD.
        /// </summary>
        [DataMember]
        public string PeriodD { get; set; }
        /// <summary>
        /// Gets or sets the PeriodK.
        /// </summary>
        [DataMember]
        public string PeriodK { get; set; }
        /// <summary>
        /// Gets or sets the PeriodQ.
        /// </summary>
        [DataMember]
        public string PeriodQ { get; set; }
        /// <summary>
        /// Gets or sets the PFEZero.
        /// </summary>
        [DataMember]
        public string PFEZero { get; set; }
        /// <summary>
        /// Gets or sets the PiviotsDailyBarsError.
        /// </summary>
        [DataMember]
        public string PiviotsDailyBarsError { get; set; }
        /// <summary>
        /// Gets or sets the PiviotsDailyDataError.
        /// </summary>
        [DataMember]
        public string PiviotsDailyDataError { get; set; }
        /// <summary>
        /// Gets or sets the PiviotsInsufficentDataError.
        /// </summary>
        [DataMember]
        public string PiviotsInsufficentDataError { get; set; }
        /// <summary>
        /// Gets or sets the PiviotsPeriodTypeError.
        /// </summary>
        [DataMember]
        public string PiviotsPeriodTypeError { get; set; }
        /// <summary>
        /// Gets or sets the PiviotsWeeklyBarsError.
        /// </summary>
        [DataMember]
        public string PiviotsWeeklyBarsError { get; set; }
        /// <summary>
        /// Gets or sets the PivotRange.
        /// </summary>
        [DataMember]
        public string PivotRange { get; set; }
        /// <summary>
        /// Gets or sets the PivotRange_Daily.
        /// </summary>
        [DataMember]
        public string PivotRange_Daily { get; set; }
        /// <summary>
        /// Gets or sets the PivotRange_Monthly.
        /// </summary>
        [DataMember]
        public string PivotRange_Monthly { get; set; }
        /// <summary>
        /// Gets or sets the PivotRange_Weekly.
        /// </summary>
        [DataMember]
        public string PivotRange_Weekly { get; set; }
        /// <summary>
        /// Gets or sets the PivotsPP.
        /// </summary>
        [DataMember]
        public string PivotsPP { get; set; }
        /// <summary>
        /// Gets or sets the PivotsR1.
        /// </summary>
        [DataMember]
        public string PivotsR1 { get; set; }
        /// <summary>
        /// Gets or sets the PivotsR2.
        /// </summary>
        [DataMember]
        public string PivotsR2 { get; set; }
        /// <summary>
        /// Gets or sets the PivotsR3.
        /// </summary>
        [DataMember]
        public string PivotsR3 { get; set; }
        /// <summary>
        /// Gets or sets the PivotsR4.
        /// </summary>
        [DataMember]
        public string PivotsR4 { get; set; }
        /// <summary>
        /// Gets or sets the PivotsS1.
        /// </summary>
        [DataMember]
        public string PivotsS1 { get; set; }
        /// <summary>
        /// Gets or sets the PivotsS2.
        /// </summary>
        [DataMember]
        public string PivotsS2 { get; set; }
        /// <summary>
        /// Gets or sets the PivotsS3.
        /// </summary>
        [DataMember]
        public string PivotsS3 { get; set; }
        /// <summary>
        /// Gets or sets the PivotsS4.
        /// </summary>
        [DataMember]
        public string PivotsS4 { get; set; }
        /// <summary>
        /// Gets or sets the PlotCurrentValue.
        /// </summary>
        [DataMember]
        public string PlotCurrentValue { get; set; }
        /// <summary>
        /// Gets or sets the PositiveColor.
        /// </summary>
        [DataMember]
        public string PositiveColor { get; set; }
        /// <summary>
        /// Gets or sets the PPOSmoothed.
        /// </summary>
        [DataMember]
        public string PPOSmoothed { get; set; }
        /// <summary>
        /// Gets or sets the PriceLinePlotAsk.
        /// </summary>
        [DataMember]
        public string PriceLinePlotAsk { get; set; }
        /// <summary>
        /// Gets or sets the PriceLinePlotBid.
        /// </summary>
        [DataMember]
        public string PriceLinePlotBid { get; set; }
        /// <summary>
        /// Gets or sets the PriceLinePlotLast.
        /// </summary>
        [DataMember]
        public string PriceLinePlotLast { get; set; }
        /// <summary>
        /// Gets or sets the PriorDayOHLCClose.
        /// </summary>
        [DataMember]
        public string PriorDayOHLCClose { get; set; }
        /// <summary>
        /// Gets or sets the PriorDayOHLCHigh.
        /// </summary>
        [DataMember]
        public string PriorDayOHLCHigh { get; set; }
        /// <summary>
        /// Gets or sets the PriorDayOHLCIntradayError.
        /// </summary>
        [DataMember]
        public string PriorDayOHLCIntradayError { get; set; }
        /// <summary>
        /// Gets or sets the PriorDayOHLCLow.
        /// </summary>
        [DataMember]
        public string PriorDayOHLCLow { get; set; }
        /// <summary>
        /// Gets or sets the PriorDayOHLCOpen.
        /// </summary>
        [DataMember]
        public string PriorDayOHLCOpen { get; set; }
        /// <summary>
        /// Gets or sets the PropertyCategoryVisual.
        /// </summary>
        [DataMember]
        public string PropertyCategoryVisual { get; set; }
        /// <summary>
        /// Gets or sets the PullingStackingDisplayType_Ask.
        /// </summary>
        [DataMember]
        public string PullingStackingDisplayType_Ask { get; set; }
        /// <summary>
        /// Gets or sets the PullingStackingDisplayType_Bid.
        /// </summary>
        [DataMember]
        public string PullingStackingDisplayType_Bid { get; set; }
        /// <summary>
        /// Gets or sets the PullingStackingDisplayType_BidAsk.
        /// </summary>
        [DataMember]
        public string PullingStackingDisplayType_BidAsk { get; set; }
        /// <summary>
        /// Gets or sets the PullingStackingResetWhen_BidAskChange.
        /// </summary>
        [DataMember]
        public string PullingStackingResetWhen_BidAskChange { get; set; }
        /// <summary>
        /// Gets or sets the PullingStackingResetWhen_NoMoreData.
        /// </summary>
        [DataMember]
        public string PullingStackingResetWhen_NoMoreData { get; set; }
        /// <summary>
        /// Gets or sets the RangeCounterBarError.
        /// </summary>
        [DataMember]
        public string RangeCounterBarError { get; set; }
        /// <summary>
        /// Gets or sets the RangeCounterRemaing.
        /// </summary>
        [DataMember]
        public string RangeCounterRemaing { get; set; }
        /// <summary>
        /// Gets or sets the RangerCounterCount.
        /// </summary>
        [DataMember]
        public string RangerCounterCount { get; set; }
        /// <summary>
        /// Gets or sets the RangeValue.
        /// </summary>
        [DataMember]
        public string RangeValue { get; set; }
        /// <summary>
        /// Gets or sets the RecentDisplayType_Ask.
        /// </summary>
        [DataMember]
        public string RecentDisplayType_Ask { get; set; }
        /// <summary>
        /// Gets or sets the RecentDisplayType_Bid.
        /// </summary>
        [DataMember]
        public string RecentDisplayType_Bid { get; set; }
        /// <summary>
        /// Gets or sets the RecentDisplayType_BidAsk.
        /// </summary>
        [DataMember]
        public string RecentDisplayType_BidAsk { get; set; }
        /// <summary>
        /// Gets or sets the RecentResetWhen_BidAskChange.
        /// </summary>
        [DataMember]
        public string RecentResetWhen_BidAskChange { get; set; }
        /// <summary>
        /// Gets or sets the RecentResetWhen_PriceReturns.
        /// </summary>
        [DataMember]
        public string RecentResetWhen_PriceReturns { get; set; }
        /// <summary>
        /// Gets or sets the RegionHighlightDirection_Horizontal.
        /// </summary>
        [DataMember]
        public string RegionHighlightDirection_Horizontal { get; set; }
        /// <summary>
        /// Gets or sets the RegionHighlightDirection_Vertical.
        /// </summary>
        [DataMember]
        public string RegionHighlightDirection_Vertical { get; set; }
        /// <summary>
        /// Gets or sets the RegressionChannelType_Segment.
        /// </summary>
        [DataMember]
        public string RegressionChannelType_Segment { get; set; }
        /// <summary>
        /// Gets or sets the RegressionChannelType_StandardDeviation.
        /// </summary>
        [DataMember]
        public string RegressionChannelType_StandardDeviation { get; set; }
        /// <summary>
        /// Gets or sets the ROCPeriod.
        /// </summary>
        [DataMember]
        public string ROCPeriod { get; set; }
        /// <summary>
        /// Gets or sets the RVISignalLine.
        /// </summary>
        [DataMember]
        public string RVISignalLine { get; set; }
        /// <summary>
        /// Gets or sets the SampleAddOnDescription.
        /// </summary>
        [DataMember]
        public string SampleAddOnDescription { get; set; }
        /// <summary>
        /// Gets or sets the SampleAddOnHiThere.
        /// </summary>
        [DataMember]
        public string SampleAddOnHiThere { get; set; }
        /// <summary>
        /// Gets or sets the SampleAddOnName.
        /// </summary>
        [DataMember]
        public string SampleAddOnName { get; set; }
        /// <summary>
        /// Gets or sets the SampleCumProfit.
        /// </summary>
        [DataMember]
        public string SampleCumProfit { get; set; }
        /// <summary>
        /// Gets or sets the SampleCumProfitDescription.
        /// </summary>
        [DataMember]
        public string SampleCumProfitDescription { get; set; }
        /// <summary>
        /// Gets or sets the SampleCustomPlotLowerRightCorner.
        /// </summary>
        [DataMember]
        public string SampleCustomPlotLowerRightCorner { get; set; }
        /// <summary>
        /// Gets or sets the SampleCustomPlotUpperLeftCorner.
        /// </summary>
        [DataMember]
        public string SampleCustomPlotUpperLeftCorner { get; set; }
        /// <summary>
        /// Gets or sets the SelectPattern.
        /// </summary>
        [DataMember]
        public string SelectPattern { get; set; }
        /// <summary>
        /// Gets or sets the SelectPatternDescription.
        /// </summary>
        [DataMember]
        public string SelectPatternDescription { get; set; }
        /// <summary>
        /// Gets or sets the SendAlerts.
        /// </summary>
        [DataMember]
        public string SendAlerts { get; set; }
        /// <summary>
        /// Gets or sets the SendAlertsDescription.
        /// </summary>
        [DataMember]
        public string SendAlertsDescription { get; set; }
        /// <summary>
        /// Gets or sets the ShareArgsException.
        /// </summary>
        [DataMember]
        public string ShareArgsException { get; set; }
        /// <summary>
        /// Gets or sets the ShareBadGatewayError.
        /// </summary>
        [DataMember]
        public string ShareBadGatewayError { get; set; }
        /// <summary>
        /// Gets or sets the ShareBadRequestError.
        /// </summary>
        [DataMember]
        public string ShareBadRequestError { get; set; }
        /// <summary>
        /// Gets or sets the ShareException.
        /// </summary>
        [DataMember]
        public string ShareException { get; set; }
        /// <summary>
        /// Gets or sets the ShareFacebookCouldNotRetrieveUser.
        /// </summary>
        [DataMember]
        public string ShareFacebookCouldNotRetrieveUser { get; set; }
        /// <summary>
        /// Gets or sets the ShareFacebookCouldNotVerifyToken.
        /// </summary>
        [DataMember]
        public string ShareFacebookCouldNotVerifyToken { get; set; }
        /// <summary>
        /// Gets or sets the ShareFacebookNoResult.
        /// </summary>
        [DataMember]
        public string ShareFacebookNoResult { get; set; }
        /// <summary>
        /// Gets or sets the ShareFacebookPermissionDenied.
        /// </summary>
        [DataMember]
        public string ShareFacebookPermissionDenied { get; set; }
        /// <summary>
        /// Gets or sets the ShareFacebookScopesNotFound.
        /// </summary>
        [DataMember]
        public string ShareFacebookScopesNotFound { get; set; }
        /// <summary>
        /// Gets or sets the ShareFacebookSentSuccessfully.
        /// </summary>
        [DataMember]
        public string ShareFacebookSentSuccessfully { get; set; }
        /// <summary>
        /// Gets or sets the ShareForbidden.
        /// </summary>
        [DataMember]
        public string ShareForbidden { get; set; }
        /// <summary>
        /// Gets or sets the ShareGatewayTimeoutError.
        /// </summary>
        [DataMember]
        public string ShareGatewayTimeoutError { get; set; }
        /// <summary>
        /// Gets or sets the ShareImageNoLongerExists.
        /// </summary>
        [DataMember]
        public string ShareImageNoLongerExists { get; set; }
        /// <summary>
        /// Gets or sets the ShareInternalServerError.
        /// </summary>
        [DataMember]
        public string ShareInternalServerError { get; set; }
        /// <summary>
        /// Gets or sets the ShareMailException.
        /// </summary>
        [DataMember]
        public string ShareMailException { get; set; }
        /// <summary>
        /// Gets or sets the ShareMailPreconfiguredAol.
        /// </summary>
        [DataMember]
        public string ShareMailPreconfiguredAol { get; set; }
        /// <summary>
        /// Gets or sets the ShareMailPreconfiguredComcast.
        /// </summary>
        [DataMember]
        public string ShareMailPreconfiguredComcast { get; set; }
        /// <summary>
        /// Gets or sets the ShareMailPreconfiguredGmail.
        /// </summary>
        [DataMember]
        public string ShareMailPreconfiguredGmail { get; set; }
        /// <summary>
        /// Gets or sets the ShareMailPreconfiguredICloud.
        /// </summary>
        [DataMember]
        public string ShareMailPreconfiguredICloud { get; set; }
        /// <summary>
        /// Gets or sets the ShareMailPreconfiguredManual.
        /// </summary>
        [DataMember]
        public string ShareMailPreconfiguredManual { get; set; }
        /// <summary>
        /// Gets or sets the ShareMailPreconfiguredOutlook.
        /// </summary>
        [DataMember]
        public string ShareMailPreconfiguredOutlook { get; set; }
        /// <summary>
        /// Gets or sets the ShareMailPreconfiguredYahoo.
        /// </summary>
        [DataMember]
        public string ShareMailPreconfiguredYahoo { get; set; }
        /// <summary>
        /// Gets or sets the ShareMailSendError.
        /// </summary>
        [DataMember]
        public string ShareMailSendError { get; set; }
        /// <summary>
        /// Gets or sets the ShareMailSentSuccessfully.
        /// </summary>
        [DataMember]
        public string ShareMailSentSuccessfully { get; set; }
        /// <summary>
        /// Gets or sets the ShareNonSuccessCode.
        /// </summary>
        [DataMember]
        public string ShareNonSuccessCode { get; set; }
        /// <summary>
        /// Gets or sets the ShareNotAuthorized.
        /// </summary>
        [DataMember]
        public string ShareNotAuthorized { get; set; }
        /// <summary>
        /// Gets or sets the ShareServiceParameters.
        /// </summary>
        [DataMember]
        public string ShareServiceParameters { get; set; }
        /// <summary>
        /// Gets or sets the ShareServicePassword.
        /// </summary>
        [DataMember]
        public string ShareServicePassword { get; set; }
        /// <summary>
        /// Gets or sets the ShareServiceSignature.
        /// </summary>
        [DataMember]
        public string ShareServiceSignature { get; set; }
        /// <summary>
        /// Gets or sets the ShareServiceUserName.
        /// </summary>
        [DataMember]
        public string ShareServiceUserName { get; set; }
        /// <summary>
        /// Gets or sets the ShareStockTwitsNoAccount.
        /// </summary>
        [DataMember]
        public string ShareStockTwitsNoAccount { get; set; }
        /// <summary>
        /// Gets or sets the ShareStockTwitsSentSuccessfully.
        /// </summary>
        [DataMember]
        public string ShareStockTwitsSentSuccessfully { get; set; }
        /// <summary>
        /// Gets or sets the ShareTextMessageEmail.
        /// </summary>
        [DataMember]
        public string ShareTextMessageEmail { get; set; }
        /// <summary>
        /// Gets or sets the ShareTextMessageEmailRequired.
        /// </summary>
        [DataMember]
        public string ShareTextMessageEmailRequired { get; set; }
        /// <summary>
        /// Gets or sets the ShareTextMessageErrorOnShare.
        /// </summary>
        [DataMember]
        public string ShareTextMessageErrorOnShare { get; set; }
        /// <summary>
        /// Gets or sets the ShareTextMessageMmsAddress.
        /// </summary>
        [DataMember]
        public string ShareTextMessageMmsAddress { get; set; }
        /// <summary>
        /// Gets or sets the ShareTextMessageName.
        /// </summary>
        [DataMember]
        public string ShareTextMessageName { get; set; }
        /// <summary>
        /// Gets or sets the ShareTextMessagePhoneNumber.
        /// </summary>
        [DataMember]
        public string ShareTextMessagePhoneNumber { get; set; }
        /// <summary>
        /// Gets or sets the ShareTextMessagePreconfiguredAtt.
        /// </summary>
        [DataMember]
        public string ShareTextMessagePreconfiguredAtt { get; set; }
        /// <summary>
        /// Gets or sets the ShareTextMessagePreconfiguredManual.
        /// </summary>
        [DataMember]
        public string ShareTextMessagePreconfiguredManual { get; set; }
        /// <summary>
        /// Gets or sets the ShareTextMessagePreconfiguredSprint.
        /// </summary>
        [DataMember]
        public string ShareTextMessagePreconfiguredSprint { get; set; }
        /// <summary>
        /// Gets or sets the ShareTextMessagePreconfiguredTMobile.
        /// </summary>
        [DataMember]
        public string ShareTextMessagePreconfiguredTMobile { get; set; }
        /// <summary>
        /// Gets or sets the ShareTextMessagePreconfiguredVerizon.
        /// </summary>
        [DataMember]
        public string ShareTextMessagePreconfiguredVerizon { get; set; }
        /// <summary>
        /// Gets or sets the ShareTextMessageSentSuccessfully.
        /// </summary>
        [DataMember]
        public string ShareTextMessageSentSuccessfully { get; set; }
        /// <summary>
        /// Gets or sets the ShareTextMessageSmsAddress.
        /// </summary>
        [DataMember]
        public string ShareTextMessageSmsAddress { get; set; }
        /// <summary>
        /// Gets or sets the ShareTooManyRequests.
        /// </summary>
        [DataMember]
        public string ShareTooManyRequests { get; set; }
        /// <summary>
        /// Gets or sets the ShareTwitterSentSuccessfully.
        /// </summary>
        [DataMember]
        public string ShareTwitterSentSuccessfully { get; set; }
        /// <summary>
        /// Gets or sets the ShowAskLine.
        /// </summary>
        [DataMember]
        public string ShowAskLine { get; set; }
        /// <summary>
        /// Gets or sets the ShowBidLine.
        /// </summary>
        [DataMember]
        public string ShowBidLine { get; set; }
        /// <summary>
        /// Gets or sets the ShowClose.
        /// </summary>
        [DataMember]
        public string ShowClose { get; set; }
        /// <summary>
        /// Gets or sets the ShowHigh.
        /// </summary>
        [DataMember]
        public string ShowHigh { get; set; }
        /// <summary>
        /// Gets or sets the ShowLastLine.
        /// </summary>
        [DataMember]
        public string ShowLastLine { get; set; }
        /// <summary>
        /// Gets or sets the ShowLow.
        /// </summary>
        [DataMember]
        public string ShowLow { get; set; }
        /// <summary>
        /// Gets or sets the ShowOpen.
        /// </summary>
        [DataMember]
        public string ShowOpen { get; set; }
        /// <summary>
        /// Gets or sets the ShowPatternCount.
        /// </summary>
        [DataMember]
        public string ShowPatternCount { get; set; }
        /// <summary>
        /// Gets or sets the ShowPatternCountDescription.
        /// </summary>
        [DataMember]
        public string ShowPatternCountDescription { get; set; }
        /// <summary>
        /// Gets or sets the ShowPercent.
        /// </summary>
        [DataMember]
        public string ShowPercent { get; set; }
        /// <summary>
        /// Gets or sets the SignalPeriod.
        /// </summary>
        [DataMember]
        public string SignalPeriod { get; set; }
        /// <summary>
        /// Gets or sets the Slow.
        /// </summary>
        [DataMember]
        public string Slow { get; set; }
        /// <summary>
        /// Gets or sets the SlowLimit.
        /// </summary>
        [DataMember]
        public string SlowLimit { get; set; }
        /// <summary>
        /// Gets or sets the SlowPeriod.
        /// </summary>
        [DataMember]
        public string SlowPeriod { get; set; }
        /// <summary>
        /// Gets or sets the SmallAreaColor.
        /// </summary>
        [DataMember]
        public string SmallAreaColor { get; set; }
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
        /// Gets or sets the StochasticsD.
        /// </summary>
        [DataMember]
        public string StochasticsD { get; set; }
        /// <summary>
        /// Gets or sets the StochasticsK.
        /// </summary>
        [DataMember]
        public string StochasticsK { get; set; }
        /// <summary>
        /// Gets or sets the StockTwitsSentiment.
        /// </summary>
        [DataMember]
        public string StockTwitsSentiment { get; set; }
        /// <summary>
        /// Gets or sets the StockTwitsSentimentDescription.
        /// </summary>
        [DataMember]
        public string StockTwitsSentimentDescription { get; set; }
        /// <summary>
        /// Gets or sets the StockTwitsServiceName.
        /// </summary>
        [DataMember]
        public string StockTwitsServiceName { get; set; }
        /// <summary>
        /// Gets or sets the StockTwitsSignature.
        /// </summary>
        [DataMember]
        public string StockTwitsSignature { get; set; }
        /// <summary>
        /// Gets or sets the Strength.
        /// </summary>
        [DataMember]
        public string Strength { get; set; }
        /// <summary>
        /// Gets or sets the SuperDomColumnException.
        /// </summary>
        [DataMember]
        public string SuperDomColumnException { get; set; }
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
        /// Gets or sets the TCount.
        /// </summary>
        [DataMember]
        public string TCount { get; set; }
        /// <summary>
        /// Gets or sets the TextColor.
        /// </summary>
        [DataMember]
        public string TextColor { get; set; }
        /// <summary>
        /// Gets or sets the TextFont.
        /// </summary>
        [DataMember]
        public string TextFont { get; set; }
        /// <summary>
        /// Gets or sets the TextFontDescription.
        /// </summary>
        [DataMember]
        public string TextFontDescription { get; set; }
        /// <summary>
        /// Gets or sets the TextPosition_BottomLeft.
        /// </summary>
        [DataMember]
        public string TextPosition_BottomLeft { get; set; }
        /// <summary>
        /// Gets or sets the TextPosition_BottomRight.
        /// </summary>
        [DataMember]
        public string TextPosition_BottomRight { get; set; }
        /// <summary>
        /// Gets or sets the TextPosition_Center.
        /// </summary>
        [DataMember]
        public string TextPosition_Center { get; set; }
        /// <summary>
        /// Gets or sets the TextPosition_TopLeft.
        /// </summary>
        [DataMember]
        public string TextPosition_TopLeft { get; set; }
        /// <summary>
        /// Gets or sets the TextPosition_TopRight.
        /// </summary>
        [DataMember]
        public string TextPosition_TopRight { get; set; }
        /// <summary>
        /// Gets or sets the TickCounterBarError.
        /// </summary>
        [DataMember]
        public string TickCounterBarError { get; set; }
        /// <summary>
        /// Gets or sets the TickCounterTickCount.
        /// </summary>
        [DataMember]
        public string TickCounterTickCount { get; set; }
        /// <summary>
        /// Gets or sets the TickCounterTicksRemaining.
        /// </summary>
        [DataMember]
        public string TickCounterTicksRemaining { get; set; }
        /// <summary>
        /// Gets or sets the TrendLinesCurrentTrendLine.
        /// </summary>
        [DataMember]
        public string TrendLinesCurrentTrendLine { get; set; }
        /// <summary>
        /// Gets or sets the TrendLinesNotVisible.
        /// </summary>
        [DataMember]
        public string TrendLinesNotVisible { get; set; }
        /// <summary>
        /// Gets or sets the TrendLinesTrendLineBroken.
        /// </summary>
        [DataMember]
        public string TrendLinesTrendLineBroken { get; set; }
        /// <summary>
        /// Gets or sets the TrendLinesTrendLineHigh.
        /// </summary>
        [DataMember]
        public string TrendLinesTrendLineHigh { get; set; }
        /// <summary>
        /// Gets or sets the TrendLinesTrendLineLow.
        /// </summary>
        [DataMember]
        public string TrendLinesTrendLineLow { get; set; }
        /// <summary>
        /// Gets or sets the TrendStrength.
        /// </summary>
        [DataMember]
        public string TrendStrength { get; set; }
        /// <summary>
        /// Gets or sets the TrendStrengthDescription.
        /// </summary>
        [DataMember]
        public string TrendStrengthDescription { get; set; }
        /// <summary>
        /// Gets or sets the TRIXSignal.
        /// </summary>
        [DataMember]
        public string TRIXSignal { get; set; }
        /// <summary>
        /// Gets or sets the TwitterAuthHeader.
        /// </summary>
        [DataMember]
        public string TwitterAuthHeader { get; set; }
        /// <summary>
        /// Gets or sets the TwitterAuthText1.
        /// </summary>
        [DataMember]
        public string TwitterAuthText1 { get; set; }
        /// <summary>
        /// Gets or sets the TwitterAuthText2.
        /// </summary>
        [DataMember]
        public string TwitterAuthText2 { get; set; }
        /// <summary>
        /// Gets or sets the TwitterServiceName.
        /// </summary>
        [DataMember]
        public string TwitterServiceName { get; set; }
        /// <summary>
        /// Gets or sets the TwitterSignature.
        /// </summary>
        [DataMember]
        public string TwitterSignature { get; set; }
        /// <summary>
        /// Gets or sets the Unit.
        /// </summary>
        [DataMember]
        public string Unit { get; set; }
        /// <summary>
        /// Gets or sets the UpBarColor.
        /// </summary>
        [DataMember]
        public string UpBarColor { get; set; }
        /// <summary>
        /// Gets or sets the UseHighLow.
        /// </summary>
        [DataMember]
        public string UseHighLow { get; set; }
        /// <summary>
        /// Gets or sets the UserDefinedClose.
        /// </summary>
        [DataMember]
        public string UserDefinedClose { get; set; }
        /// <summary>
        /// Gets or sets the UserDefinedHigh.
        /// </summary>
        [DataMember]
        public string UserDefinedHigh { get; set; }
        /// <summary>
        /// Gets or sets the UserDefinedLow.
        /// </summary>
        [DataMember]
        public string UserDefinedLow { get; set; }
        /// <summary>
        /// Gets or sets the VFactor.
        /// </summary>
        [DataMember]
        public string VFactor { get; set; }
        /// <summary>
        /// Gets or sets the VolatilityPeriod.
        /// </summary>
        [DataMember]
        public string VolatilityPeriod { get; set; }
        /// <summary>
        /// Gets or sets the VolumeCounterBarError.
        /// </summary>
        [DataMember]
        public string VolumeCounterBarError { get; set; }
        /// <summary>
        /// Gets or sets the VolumeCounterVolumeCount.
        /// </summary>
        [DataMember]
        public string VolumeCounterVolumeCount { get; set; }
        /// <summary>
        /// Gets or sets the VolumeCounterVolumeRemaining.
        /// </summary>
        [DataMember]
        public string VolumeCounterVolumeRemaining { get; set; }
        /// <summary>
        /// Gets or sets the VolumeDivisor.
        /// </summary>
        [DataMember]
        public string VolumeDivisor { get; set; }
        /// <summary>
        /// Gets or sets the VolumeDown.
        /// </summary>
        [DataMember]
        public string VolumeDown { get; set; }
        /// <summary>
        /// Gets or sets the VolumeDownColor.
        /// </summary>
        [DataMember]
        public string VolumeDownColor { get; set; }
        /// <summary>
        /// Gets or sets the VolumeNeutralColor.
        /// </summary>
        [DataMember]
        public string VolumeNeutralColor { get; set; }
        /// <summary>
        /// Gets or sets the VolumeUp.
        /// </summary>
        [DataMember]
        public string VolumeUp { get; set; }
        /// <summary>
        /// Gets or sets the VolumeUpColor.
        /// </summary>
        [DataMember]
        public string VolumeUpColor { get; set; }
        /// <summary>
        /// Gets or sets the VOLVolume.
        /// </summary>
        [DataMember]
        public string VOLVolume { get; set; }
        /// <summary>
        /// Gets or sets the Width.
        /// </summary>
        [DataMember]
        public string Width { get; set; }
        /// <summary>
        /// Gets or sets the WilliamsPercentR.
        /// </summary>
        [DataMember]
        public string WilliamsPercentR { get; set; }
        /// <summary>
        /// Gets or sets the ZigZagDeviationValueError.
        /// </summary>
        [DataMember]
        public string ZigZagDeviationValueError { get; set; }
        /// <summary>
        /// Gets or sets the ZigZagHighBarBarsAgoOutOfRange.
        /// </summary>
        [DataMember]
        public string ZigZagHighBarBarsAgoOutOfRange { get; set; }
        /// <summary>
        /// Gets or sets the ZigZagHighBarInstanceGreaterEqual.
        /// </summary>
        [DataMember]
        public string ZigZagHighBarInstanceGreaterEqual { get; set; }
        /// <summary>
        /// Gets or sets the ZigZagLowBarBarsAgoOutOfRange.
        /// </summary>
        [DataMember]
        public string ZigZagLowBarBarsAgoOutOfRange { get; set; }
        /// <summary>
        /// Gets or sets the ZigZagLowBarInstanceGreaterEqual.
        /// </summary>
        [DataMember]
        public string ZigZagLowBarInstanceGreaterEqual { get; set; }
        /// <summary>
        /// Gets or sets the ZigZigHighBarBarsAgoGreaterEqual.
        /// </summary>
        [DataMember]
        public string ZigZigHighBarBarsAgoGreaterEqual { get; set; }
        /// <summary>
        /// Gets or sets the ZigZigLowBarBarsAgoGreaterEqual.
        /// </summary>
        [DataMember]
        public string ZigZigLowBarBarsAgoGreaterEqual { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
