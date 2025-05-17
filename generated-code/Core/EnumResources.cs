[Serializable]
[DataContract]
namespace NinjaTrader
{
    public partial class EnumResources
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
        /// Gets or sets the AccountItem_BuyingPower.
        /// </summary>
        [DataMember]
        public String AccountItem_BuyingPower { get; set; }
        /// <summary>
        /// Gets or sets the AccountItem_CashValue.
        /// </summary>
        [DataMember]
        public String AccountItem_CashValue { get; set; }
        /// <summary>
        /// Gets or sets the AccountItem_Commission.
        /// </summary>
        [DataMember]
        public String AccountItem_Commission { get; set; }
        /// <summary>
        /// Gets or sets the AccountItem_ExcessInitialMargin.
        /// </summary>
        [DataMember]
        public String AccountItem_ExcessInitialMargin { get; set; }
        /// <summary>
        /// Gets or sets the AccountItem_ExcessIntradayMargin.
        /// </summary>
        [DataMember]
        public String AccountItem_ExcessIntradayMargin { get; set; }
        /// <summary>
        /// Gets or sets the AccountItem_ExcessMaintenanceMargin.
        /// </summary>
        [DataMember]
        public String AccountItem_ExcessMaintenanceMargin { get; set; }
        /// <summary>
        /// Gets or sets the AccountItem_ExcessPositionMargin.
        /// </summary>
        [DataMember]
        public String AccountItem_ExcessPositionMargin { get; set; }
        /// <summary>
        /// Gets or sets the AccountItem_Fee.
        /// </summary>
        [DataMember]
        public String AccountItem_Fee { get; set; }
        /// <summary>
        /// Gets or sets the AccountItem_GrossRealizedProfitLoss.
        /// </summary>
        [DataMember]
        public String AccountItem_GrossRealizedProfitLoss { get; set; }
        /// <summary>
        /// Gets or sets the AccountItem_InitialMargin.
        /// </summary>
        [DataMember]
        public String AccountItem_InitialMargin { get; set; }
        /// <summary>
        /// Gets or sets the AccountItem_IntradayMargin.
        /// </summary>
        [DataMember]
        public String AccountItem_IntradayMargin { get; set; }
        /// <summary>
        /// Gets or sets the AccountItem_LongOptionValue.
        /// </summary>
        [DataMember]
        public String AccountItem_LongOptionValue { get; set; }
        /// <summary>
        /// Gets or sets the AccountItem_LongStockValue.
        /// </summary>
        [DataMember]
        public String AccountItem_LongStockValue { get; set; }
        /// <summary>
        /// Gets or sets the AccountItem_LookAheadMaintenanceMargin.
        /// </summary>
        [DataMember]
        public String AccountItem_LookAheadMaintenanceMargin { get; set; }
        /// <summary>
        /// Gets or sets the AccountItem_MaintenanceMargin.
        /// </summary>
        [DataMember]
        public String AccountItem_MaintenanceMargin { get; set; }
        /// <summary>
        /// Gets or sets the AccountItem_NetLiquidation.
        /// </summary>
        [DataMember]
        public String AccountItem_NetLiquidation { get; set; }
        /// <summary>
        /// Gets or sets the AccountItem_NetLiquidationByCurrency.
        /// </summary>
        [DataMember]
        public String AccountItem_NetLiquidationByCurrency { get; set; }
        /// <summary>
        /// Gets or sets the AccountItem_PositionMargin.
        /// </summary>
        [DataMember]
        public String AccountItem_PositionMargin { get; set; }
        /// <summary>
        /// Gets or sets the AccountItem_RealizedProfitLoss.
        /// </summary>
        [DataMember]
        public String AccountItem_RealizedProfitLoss { get; set; }
        /// <summary>
        /// Gets or sets the AccountItem_ShortOptionValue.
        /// </summary>
        [DataMember]
        public String AccountItem_ShortOptionValue { get; set; }
        /// <summary>
        /// Gets or sets the AccountItem_ShortStockValue.
        /// </summary>
        [DataMember]
        public String AccountItem_ShortStockValue { get; set; }
        /// <summary>
        /// Gets or sets the AccountItem_SodCashValue.
        /// </summary>
        [DataMember]
        public String AccountItem_SodCashValue { get; set; }
        /// <summary>
        /// Gets or sets the AccountItem_SodLiquidatingValue.
        /// </summary>
        [DataMember]
        public String AccountItem_SodLiquidatingValue { get; set; }
        /// <summary>
        /// Gets or sets the AccountItem_TotalCashBalance.
        /// </summary>
        [DataMember]
        public String AccountItem_TotalCashBalance { get; set; }
        /// <summary>
        /// Gets or sets the AccountItem_UnrealizedProfitLoss.
        /// </summary>
        [DataMember]
        public String AccountItem_UnrealizedProfitLoss { get; set; }
        /// <summary>
        /// Gets or sets the AccountStatus_Disabled.
        /// </summary>
        [DataMember]
        public String AccountStatus_Disabled { get; set; }
        /// <summary>
        /// Gets or sets the AccountStatus_Enabled.
        /// </summary>
        [DataMember]
        public String AccountStatus_Enabled { get; set; }
        /// <summary>
        /// Gets or sets the AccountStatus_Excluded.
        /// </summary>
        [DataMember]
        public String AccountStatus_Excluded { get; set; }
        /// <summary>
        /// Gets or sets the AccountStatus_LiquidationOnly.
        /// </summary>
        [DataMember]
        public String AccountStatus_LiquidationOnly { get; set; }
        /// <summary>
        /// Gets or sets the AlertActionType_PlaySound.
        /// </summary>
        [DataMember]
        public String AlertActionType_PlaySound { get; set; }
        /// <summary>
        /// Gets or sets the AlertActionType_Share.
        /// </summary>
        [DataMember]
        public String AlertActionType_Share { get; set; }
        /// <summary>
        /// Gets or sets the AlertActionType_ShowMessage.
        /// </summary>
        [DataMember]
        public String AlertActionType_ShowMessage { get; set; }
        /// <summary>
        /// Gets or sets the AlertActionType_SubmitOrder.
        /// </summary>
        [DataMember]
        public String AlertActionType_SubmitOrder { get; set; }
        /// <summary>
        /// Gets or sets the AlertConditionOperator_All.
        /// </summary>
        [DataMember]
        public String AlertConditionOperator_All { get; set; }
        /// <summary>
        /// Gets or sets the AlertConditionOperator_Any.
        /// </summary>
        [DataMember]
        public String AlertConditionOperator_Any { get; set; }
        /// <summary>
        /// Gets or sets the AlertRearmType_Never.
        /// </summary>
        [DataMember]
        public String AlertRearmType_Never { get; set; }
        /// <summary>
        /// Gets or sets the AlertRearmType_OnBarClose.
        /// </summary>
        [DataMember]
        public String AlertRearmType_OnBarClose { get; set; }
        /// <summary>
        /// Gets or sets the AlertRearmType_OnConditionReversed.
        /// </summary>
        [DataMember]
        public String AlertRearmType_OnConditionReversed { get; set; }
        /// <summary>
        /// Gets or sets the AlertRearmType_OnConnect.
        /// </summary>
        [DataMember]
        public String AlertRearmType_OnConnect { get; set; }
        /// <summary>
        /// Gets or sets the AlertRearmType_OnTimer.
        /// </summary>
        [DataMember]
        public String AlertRearmType_OnTimer { get; set; }
        /// <summary>
        /// Gets or sets the AlertRearmType_RearmAllAlerts.
        /// </summary>
        [DataMember]
        public String AlertRearmType_RearmAllAlerts { get; set; }
        /// <summary>
        /// Gets or sets the AlertRearmType_RemoveAlert.
        /// </summary>
        [DataMember]
        public String AlertRearmType_RemoveAlert { get; set; }
        /// <summary>
        /// Gets or sets the ApplicationType_BP.
        /// </summary>
        [DataMember]
        public String ApplicationType_BP { get; set; }
        /// <summary>
        /// Gets or sets the ApplicationType_Desktop.
        /// </summary>
        [DataMember]
        public String ApplicationType_Desktop { get; set; }
        /// <summary>
        /// Gets or sets the ApplicationType_DS.
        /// </summary>
        [DataMember]
        public String ApplicationType_DS { get; set; }
        /// <summary>
        /// Gets or sets the ApplicationType_GW.
        /// </summary>
        [DataMember]
        public String ApplicationType_GW { get; set; }
        /// <summary>
        /// Gets or sets the ApplicationType_HDSIS.
        /// </summary>
        [DataMember]
        public String ApplicationType_HDSIS { get; set; }
        /// <summary>
        /// Gets or sets the AtmStrategySelectionMode_DisplaySelectedAtmStrategyOnly.
        /// </summary>
        [DataMember]
        public String AtmStrategySelectionMode_DisplaySelectedAtmStrategyOnly { get; set; }
        /// <summary>
        /// Gets or sets the AtmStrategySelectionMode_KeepSelectedAtmStrategyTemplateOnOrderSubmission.
        /// </summary>
        [DataMember]
        public String AtmStrategySelectionMode_KeepSelectedAtmStrategyTemplateOnOrderSubmission { get; set; }
        /// <summary>
        /// Gets or sets the AtmStrategySelectionMode_SelectActiveAtmStrategyOnOrderSubmission.
        /// </summary>
        [DataMember]
        public String AtmStrategySelectionMode_SelectActiveAtmStrategyOnOrderSubmission { get; set; }
        /// <summary>
        /// Gets or sets the BackupReminderInterval_Day.
        /// </summary>
        [DataMember]
        public String BackupReminderInterval_Day { get; set; }
        /// <summary>
        /// Gets or sets the BackupReminderInterval_FirstOfMonth.
        /// </summary>
        [DataMember]
        public String BackupReminderInterval_FirstOfMonth { get; set; }
        /// <summary>
        /// Gets or sets the BackupReminderInterval_Friday.
        /// </summary>
        [DataMember]
        public String BackupReminderInterval_Friday { get; set; }
        /// <summary>
        /// Gets or sets the BackupReminderInterval_Monday.
        /// </summary>
        [DataMember]
        public String BackupReminderInterval_Monday { get; set; }
        /// <summary>
        /// Gets or sets the BackupReminderInterval_Saturday.
        /// </summary>
        [DataMember]
        public String BackupReminderInterval_Saturday { get; set; }
        /// <summary>
        /// Gets or sets the BackupReminderInterval_Sunday.
        /// </summary>
        [DataMember]
        public String BackupReminderInterval_Sunday { get; set; }
        /// <summary>
        /// Gets or sets the BackupReminderInterval_Thursday.
        /// </summary>
        [DataMember]
        public String BackupReminderInterval_Thursday { get; set; }
        /// <summary>
        /// Gets or sets the BackupReminderInterval_Tuesday.
        /// </summary>
        [DataMember]
        public String BackupReminderInterval_Tuesday { get; set; }
        /// <summary>
        /// Gets or sets the BackupReminderInterval_Wednesday.
        /// </summary>
        [DataMember]
        public String BackupReminderInterval_Wednesday { get; set; }
        /// <summary>
        /// Gets or sets the BarGraphGrowthType_Center.
        /// </summary>
        [DataMember]
        public String BarGraphGrowthType_Center { get; set; }
        /// <summary>
        /// Gets or sets the BarGraphGrowthType_LeftToRight.
        /// </summary>
        [DataMember]
        public String BarGraphGrowthType_LeftToRight { get; set; }
        /// <summary>
        /// Gets or sets the BarGraphGrowthType_RightToLeft.
        /// </summary>
        [DataMember]
        public String BarGraphGrowthType_RightToLeft { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodTypeWeb_Day.
        /// </summary>
        [DataMember]
        public String BarsPeriodTypeWeb_Day { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodTypeWeb_Minute.
        /// </summary>
        [DataMember]
        public String BarsPeriodTypeWeb_Minute { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodTypeWeb_Month.
        /// </summary>
        [DataMember]
        public String BarsPeriodTypeWeb_Month { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodTypeWeb_Range.
        /// </summary>
        [DataMember]
        public String BarsPeriodTypeWeb_Range { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodTypeWeb_Second.
        /// </summary>
        [DataMember]
        public String BarsPeriodTypeWeb_Second { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodTypeWeb_Tick.
        /// </summary>
        [DataMember]
        public String BarsPeriodTypeWeb_Tick { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodTypeWeb_Volume.
        /// </summary>
        [DataMember]
        public String BarsPeriodTypeWeb_Volume { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodTypeWeb_Week.
        /// </summary>
        [DataMember]
        public String BarsPeriodTypeWeb_Week { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodTypeWeb_Year.
        /// </summary>
        [DataMember]
        public String BarsPeriodTypeWeb_Year { get; set; }
        /// <summary>
        /// Gets or sets the Calculate_OnBarClose.
        /// </summary>
        [DataMember]
        public String Calculate_OnBarClose { get; set; }
        /// <summary>
        /// Gets or sets the Calculate_OnEachTick.
        /// </summary>
        [DataMember]
        public String Calculate_OnEachTick { get; set; }
        /// <summary>
        /// Gets or sets the Calculate_OnPriceChange.
        /// </summary>
        [DataMember]
        public String Calculate_OnPriceChange { get; set; }
        /// <summary>
        /// Gets or sets the CalculationMode_Currency.
        /// </summary>
        [DataMember]
        public String CalculationMode_Currency { get; set; }
        /// <summary>
        /// Gets or sets the CalculationMode_Percent.
        /// </summary>
        [DataMember]
        public String CalculationMode_Percent { get; set; }
        /// <summary>
        /// Gets or sets the CalculationMode_Pips.
        /// </summary>
        [DataMember]
        public String CalculationMode_Pips { get; set; }
        /// <summary>
        /// Gets or sets the CalculationMode_Price.
        /// </summary>
        [DataMember]
        public String CalculationMode_Price { get; set; }
        /// <summary>
        /// Gets or sets the CalculationMode_Ticks.
        /// </summary>
        [DataMember]
        public String CalculationMode_Ticks { get; set; }
        /// <summary>
        /// Gets or sets the Category_Atm.
        /// </summary>
        [DataMember]
        public String Category_Atm { get; set; }
        /// <summary>
        /// Gets or sets the Category_Backtest.
        /// </summary>
        [DataMember]
        public String Category_Backtest { get; set; }
        /// <summary>
        /// Gets or sets the Category_MultiObjective.
        /// </summary>
        [DataMember]
        public String Category_MultiObjective { get; set; }
        /// <summary>
        /// Gets or sets the Category_NinjaScript.
        /// </summary>
        [DataMember]
        public String Category_NinjaScript { get; set; }
        /// <summary>
        /// Gets or sets the Category_Optimize.
        /// </summary>
        [DataMember]
        public String Category_Optimize { get; set; }
        /// <summary>
        /// Gets or sets the Category_WalkForward.
        /// </summary>
        [DataMember]
        public String Category_WalkForward { get; set; }
        /// <summary>
        /// Gets or sets the Category_WalkForwardAnchored.
        /// </summary>
        [DataMember]
        public String Category_WalkForwardAnchored { get; set; }
        /// <summary>
        /// Gets or sets the ChartAlertValueType_Ask.
        /// </summary>
        [DataMember]
        public String ChartAlertValueType_Ask { get; set; }
        /// <summary>
        /// Gets or sets the ChartAlertValueType_Bid.
        /// </summary>
        [DataMember]
        public String ChartAlertValueType_Bid { get; set; }
        /// <summary>
        /// Gets or sets the ChartAlertValueType_Close.
        /// </summary>
        [DataMember]
        public String ChartAlertValueType_Close { get; set; }
        /// <summary>
        /// Gets or sets the ChartAlertValueType_High.
        /// </summary>
        [DataMember]
        public String ChartAlertValueType_High { get; set; }
        /// <summary>
        /// Gets or sets the ChartAlertValueType_Low.
        /// </summary>
        [DataMember]
        public String ChartAlertValueType_Low { get; set; }
        /// <summary>
        /// Gets or sets the ChartAlertValueType_Median.
        /// </summary>
        [DataMember]
        public String ChartAlertValueType_Median { get; set; }
        /// <summary>
        /// Gets or sets the ChartAlertValueType_Open.
        /// </summary>
        [DataMember]
        public String ChartAlertValueType_Open { get; set; }
        /// <summary>
        /// Gets or sets the ChartAlertValueType_Typical.
        /// </summary>
        [DataMember]
        public String ChartAlertValueType_Typical { get; set; }
        /// <summary>
        /// Gets or sets the ChartAlertValueType_Volume.
        /// </summary>
        [DataMember]
        public String ChartAlertValueType_Volume { get; set; }
        /// <summary>
        /// Gets or sets the ChartAlertValueType_Weighted.
        /// </summary>
        [DataMember]
        public String ChartAlertValueType_Weighted { get; set; }
        /// <summary>
        /// Gets or sets the ChartMarkerSize_ExtraLarge.
        /// </summary>
        [DataMember]
        public String ChartMarkerSize_ExtraLarge { get; set; }
        /// <summary>
        /// Gets or sets the ChartMarkerSize_ExtraSmall.
        /// </summary>
        [DataMember]
        public String ChartMarkerSize_ExtraSmall { get; set; }
        /// <summary>
        /// Gets or sets the ChartMarkerSize_Large.
        /// </summary>
        [DataMember]
        public String ChartMarkerSize_Large { get; set; }
        /// <summary>
        /// Gets or sets the ChartMarkerSize_Medium.
        /// </summary>
        [DataMember]
        public String ChartMarkerSize_Medium { get; set; }
        /// <summary>
        /// Gets or sets the ChartMarkerSize_Small.
        /// </summary>
        [DataMember]
        public String ChartMarkerSize_Small { get; set; }
        /// <summary>
        /// Gets or sets the ChartStyleType_Box.
        /// </summary>
        [DataMember]
        public String ChartStyleType_Box { get; set; }
        /// <summary>
        /// Gets or sets the ChartStyleType_CandleStick.
        /// </summary>
        [DataMember]
        public String ChartStyleType_CandleStick { get; set; }
        /// <summary>
        /// Gets or sets the ChartStyleType_EquiVolume.
        /// </summary>
        [DataMember]
        public String ChartStyleType_EquiVolume { get; set; }
        /// <summary>
        /// Gets or sets the ChartStyleType_LineOnClose.
        /// </summary>
        [DataMember]
        public String ChartStyleType_LineOnClose { get; set; }
        /// <summary>
        /// Gets or sets the ChartStyleType_Mountain.
        /// </summary>
        [DataMember]
        public String ChartStyleType_Mountain { get; set; }
        /// <summary>
        /// Gets or sets the ChartStyleType_OHLC.
        /// </summary>
        [DataMember]
        public String ChartStyleType_OHLC { get; set; }
        /// <summary>
        /// Gets or sets the ColumnType_BarGraph.
        /// </summary>
        [DataMember]
        public String ColumnType_BarGraph { get; set; }
        /// <summary>
        /// Gets or sets the ColumnType_Regular.
        /// </summary>
        [DataMember]
        public String ColumnType_Regular { get; set; }
        /// <summary>
        /// Gets or sets the Condition_CrossAbove.
        /// </summary>
        [DataMember]
        public String Condition_CrossAbove { get; set; }
        /// <summary>
        /// Gets or sets the Condition_CrossBelow.
        /// </summary>
        [DataMember]
        public String Condition_CrossBelow { get; set; }
        /// <summary>
        /// Gets or sets the Condition_CrossInside.
        /// </summary>
        [DataMember]
        public String Condition_CrossInside { get; set; }
        /// <summary>
        /// Gets or sets the Condition_CrossOutside.
        /// </summary>
        [DataMember]
        public String Condition_CrossOutside { get; set; }
        /// <summary>
        /// Gets or sets the Condition_Equals.
        /// </summary>
        [DataMember]
        public String Condition_Equals { get; set; }
        /// <summary>
        /// Gets or sets the Condition_Greater.
        /// </summary>
        [DataMember]
        public String Condition_Greater { get; set; }
        /// <summary>
        /// Gets or sets the Condition_GreaterEqual.
        /// </summary>
        [DataMember]
        public String Condition_GreaterEqual { get; set; }
        /// <summary>
        /// Gets or sets the Condition_Less.
        /// </summary>
        [DataMember]
        public String Condition_Less { get; set; }
        /// <summary>
        /// Gets or sets the Condition_LessEqual.
        /// </summary>
        [DataMember]
        public String Condition_LessEqual { get; set; }
        /// <summary>
        /// Gets or sets the Condition_NotEqual.
        /// </summary>
        [DataMember]
        public String Condition_NotEqual { get; set; }
        /// <summary>
        /// Gets or sets the ConditionOffsetType_Arithmetic.
        /// </summary>
        [DataMember]
        public String ConditionOffsetType_Arithmetic { get; set; }
        /// <summary>
        /// Gets or sets the ConditionOffsetType_Percent.
        /// </summary>
        [DataMember]
        public String ConditionOffsetType_Percent { get; set; }
        /// <summary>
        /// Gets or sets the ConditionOffsetType_Pips.
        /// </summary>
        [DataMember]
        public String ConditionOffsetType_Pips { get; set; }
        /// <summary>
        /// Gets or sets the ConditionOffsetType_Ticks.
        /// </summary>
        [DataMember]
        public String ConditionOffsetType_Ticks { get; set; }
        /// <summary>
        /// Gets or sets the ConnectionLossHandling_KeepRunning.
        /// </summary>
        [DataMember]
        public String ConnectionLossHandling_KeepRunning { get; set; }
        /// <summary>
        /// Gets or sets the ConnectionLossHandling_Recalculate.
        /// </summary>
        [DataMember]
        public String ConnectionLossHandling_Recalculate { get; set; }
        /// <summary>
        /// Gets or sets the ConnectionLossHandling_StopStrategy.
        /// </summary>
        [DataMember]
        public String ConnectionLossHandling_StopStrategy { get; set; }
        /// <summary>
        /// Gets or sets the ConnectionStatus_Connected.
        /// </summary>
        [DataMember]
        public String ConnectionStatus_Connected { get; set; }
        /// <summary>
        /// Gets or sets the ConnectionStatus_Connecting.
        /// </summary>
        [DataMember]
        public String ConnectionStatus_Connecting { get; set; }
        /// <summary>
        /// Gets or sets the ConnectionStatus_ConnectionLost.
        /// </summary>
        [DataMember]
        public String ConnectionStatus_ConnectionLost { get; set; }
        /// <summary>
        /// Gets or sets the ConnectionStatus_Disconnected.
        /// </summary>
        [DataMember]
        public String ConnectionStatus_Disconnected { get; set; }
        /// <summary>
        /// Gets or sets the ConnectionStatus_Disconnecting.
        /// </summary>
        [DataMember]
        public String ConnectionStatus_Disconnecting { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_AssetManagerInstitutionalLong.
        /// </summary>
        [DataMember]
        public String CotReportField_AssetManagerInstitutionalLong { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_AssetManagerInstitutionalNet.
        /// </summary>
        [DataMember]
        public String CotReportField_AssetManagerInstitutionalNet { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_AssetManagerInstitutionalShort.
        /// </summary>
        [DataMember]
        public String CotReportField_AssetManagerInstitutionalShort { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_AssetManagerInstitutionalSpreading.
        /// </summary>
        [DataMember]
        public String CotReportField_AssetManagerInstitutionalSpreading { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_CommercialLong.
        /// </summary>
        [DataMember]
        public String CotReportField_CommercialLong { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_CommercialNet.
        /// </summary>
        [DataMember]
        public String CotReportField_CommercialNet { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_CommercialShort.
        /// </summary>
        [DataMember]
        public String CotReportField_CommercialShort { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_DealerIntermediaryLong.
        /// </summary>
        [DataMember]
        public String CotReportField_DealerIntermediaryLong { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_DealerIntermediaryNet.
        /// </summary>
        [DataMember]
        public String CotReportField_DealerIntermediaryNet { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_DealerIntermediaryShort.
        /// </summary>
        [DataMember]
        public String CotReportField_DealerIntermediaryShort { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_DealerIntermediarySpreading.
        /// </summary>
        [DataMember]
        public String CotReportField_DealerIntermediarySpreading { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_IndexTradersLong.
        /// </summary>
        [DataMember]
        public String CotReportField_IndexTradersLong { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_IndexTradersNet.
        /// </summary>
        [DataMember]
        public String CotReportField_IndexTradersNet { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_IndexTradersShort.
        /// </summary>
        [DataMember]
        public String CotReportField_IndexTradersShort { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_LeveragedFundsLong.
        /// </summary>
        [DataMember]
        public String CotReportField_LeveragedFundsLong { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_LeveragedFundsNet.
        /// </summary>
        [DataMember]
        public String CotReportField_LeveragedFundsNet { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_LeveragedFundsShort.
        /// </summary>
        [DataMember]
        public String CotReportField_LeveragedFundsShort { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_LeveragedFundsSpreading.
        /// </summary>
        [DataMember]
        public String CotReportField_LeveragedFundsSpreading { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_ManagedMoneyLong.
        /// </summary>
        [DataMember]
        public String CotReportField_ManagedMoneyLong { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_ManagedMoneyNet.
        /// </summary>
        [DataMember]
        public String CotReportField_ManagedMoneyNet { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_ManagedMoneyShort.
        /// </summary>
        [DataMember]
        public String CotReportField_ManagedMoneyShort { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_ManagedMoneySpreading.
        /// </summary>
        [DataMember]
        public String CotReportField_ManagedMoneySpreading { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_NoncommercialLong.
        /// </summary>
        [DataMember]
        public String CotReportField_NoncommercialLong { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_NoncommercialNet.
        /// </summary>
        [DataMember]
        public String CotReportField_NoncommercialNet { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_NoncommercialShort.
        /// </summary>
        [DataMember]
        public String CotReportField_NoncommercialShort { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_NoncommercialSpreads.
        /// </summary>
        [DataMember]
        public String CotReportField_NoncommercialSpreads { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_NonreportablePositionsLong.
        /// </summary>
        [DataMember]
        public String CotReportField_NonreportablePositionsLong { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_NonreportablePositionsNet.
        /// </summary>
        [DataMember]
        public String CotReportField_NonreportablePositionsNet { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_NonreportablePositionsShort.
        /// </summary>
        [DataMember]
        public String CotReportField_NonreportablePositionsShort { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_OpenInterest.
        /// </summary>
        [DataMember]
        public String CotReportField_OpenInterest { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_OtherReportablesLong.
        /// </summary>
        [DataMember]
        public String CotReportField_OtherReportablesLong { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_OtherReportablesNet.
        /// </summary>
        [DataMember]
        public String CotReportField_OtherReportablesNet { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_OtherReportablesShort.
        /// </summary>
        [DataMember]
        public String CotReportField_OtherReportablesShort { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_OtherReportablesSpreading.
        /// </summary>
        [DataMember]
        public String CotReportField_OtherReportablesSpreading { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_PmpuLong.
        /// </summary>
        [DataMember]
        public String CotReportField_PmpuLong { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_PmpuNet.
        /// </summary>
        [DataMember]
        public String CotReportField_PmpuNet { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_PmpuShort.
        /// </summary>
        [DataMember]
        public String CotReportField_PmpuShort { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_SwapDealersLong.
        /// </summary>
        [DataMember]
        public String CotReportField_SwapDealersLong { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_SwapDealersNet.
        /// </summary>
        [DataMember]
        public String CotReportField_SwapDealersNet { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_SwapDealersShort.
        /// </summary>
        [DataMember]
        public String CotReportField_SwapDealersShort { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_SwapDealersSpreading.
        /// </summary>
        [DataMember]
        public String CotReportField_SwapDealersSpreading { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TotalLong.
        /// </summary>
        [DataMember]
        public String CotReportField_TotalLong { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TotalNet.
        /// </summary>
        [DataMember]
        public String CotReportField_TotalNet { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TotalShort.
        /// </summary>
        [DataMember]
        public String CotReportField_TotalShort { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TotalTraders.
        /// </summary>
        [DataMember]
        public String CotReportField_TotalTraders { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInAssetManagerInstitutionalLong.
        /// </summary>
        [DataMember]
        public String CotReportField_TradersInAssetManagerInstitutionalLong { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInAssetManagerInstitutionalShort.
        /// </summary>
        [DataMember]
        public String CotReportField_TradersInAssetManagerInstitutionalShort { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInAssetManagerInstitutionalSpreading.
        /// </summary>
        [DataMember]
        public String CotReportField_TradersInAssetManagerInstitutionalSpreading { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInCommercialLong.
        /// </summary>
        [DataMember]
        public String CotReportField_TradersInCommercialLong { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInCommercialShort.
        /// </summary>
        [DataMember]
        public String CotReportField_TradersInCommercialShort { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInDealerIntermediaryLong.
        /// </summary>
        [DataMember]
        public String CotReportField_TradersInDealerIntermediaryLong { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInDealerIntermediaryShort.
        /// </summary>
        [DataMember]
        public String CotReportField_TradersInDealerIntermediaryShort { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInDealerIntermediarySpreading.
        /// </summary>
        [DataMember]
        public String CotReportField_TradersInDealerIntermediarySpreading { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInIndexTradersLong.
        /// </summary>
        [DataMember]
        public String CotReportField_TradersInIndexTradersLong { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInIndexTradersShort.
        /// </summary>
        [DataMember]
        public String CotReportField_TradersInIndexTradersShort { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInLeveragedFundsLong.
        /// </summary>
        [DataMember]
        public String CotReportField_TradersInLeveragedFundsLong { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInLeveragedFundsShort.
        /// </summary>
        [DataMember]
        public String CotReportField_TradersInLeveragedFundsShort { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInLeveragedFundsSpreading.
        /// </summary>
        [DataMember]
        public String CotReportField_TradersInLeveragedFundsSpreading { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInManagedMoneyLong.
        /// </summary>
        [DataMember]
        public String CotReportField_TradersInManagedMoneyLong { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInManagedMoneyShort.
        /// </summary>
        [DataMember]
        public String CotReportField_TradersInManagedMoneyShort { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInManagedMoneySpreading.
        /// </summary>
        [DataMember]
        public String CotReportField_TradersInManagedMoneySpreading { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInNoncommercialLong.
        /// </summary>
        [DataMember]
        public String CotReportField_TradersInNoncommercialLong { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInNoncommercialShort.
        /// </summary>
        [DataMember]
        public String CotReportField_TradersInNoncommercialShort { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInNoncommercialSpreads.
        /// </summary>
        [DataMember]
        public String CotReportField_TradersInNoncommercialSpreads { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInOtherReportablesLong.
        /// </summary>
        [DataMember]
        public String CotReportField_TradersInOtherReportablesLong { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInOtherReportablesShort.
        /// </summary>
        [DataMember]
        public String CotReportField_TradersInOtherReportablesShort { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInOtherReportablesSpreading.
        /// </summary>
        [DataMember]
        public String CotReportField_TradersInOtherReportablesSpreading { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInPmpuLong.
        /// </summary>
        [DataMember]
        public String CotReportField_TradersInPmpuLong { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInPmpuShort.
        /// </summary>
        [DataMember]
        public String CotReportField_TradersInPmpuShort { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInSwapDealersLong.
        /// </summary>
        [DataMember]
        public String CotReportField_TradersInSwapDealersLong { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInSwapDealersShort.
        /// </summary>
        [DataMember]
        public String CotReportField_TradersInSwapDealersShort { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInSwapDealersSpreading.
        /// </summary>
        [DataMember]
        public String CotReportField_TradersInSwapDealersSpreading { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInTotalLong.
        /// </summary>
        [DataMember]
        public String CotReportField_TradersInTotalLong { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInTotalShort.
        /// </summary>
        [DataMember]
        public String CotReportField_TradersInTotalShort { get; set; }
        /// <summary>
        /// Gets or sets the CotReportType_CitSupplement.
        /// </summary>
        [DataMember]
        public String CotReportType_CitSupplement { get; set; }
        /// <summary>
        /// Gets or sets the CotReportType_Combined.
        /// </summary>
        [DataMember]
        public String CotReportType_Combined { get; set; }
        /// <summary>
        /// Gets or sets the CotReportType_DisaggregatedCombined.
        /// </summary>
        [DataMember]
        public String CotReportType_DisaggregatedCombined { get; set; }
        /// <summary>
        /// Gets or sets the CotReportType_DisaggregatedFutures.
        /// </summary>
        [DataMember]
        public String CotReportType_DisaggregatedFutures { get; set; }
        /// <summary>
        /// Gets or sets the CotReportType_FinancialFuturesCombined.
        /// </summary>
        [DataMember]
        public String CotReportType_FinancialFuturesCombined { get; set; }
        /// <summary>
        /// Gets or sets the CotReportType_FinancialFuturesFutures.
        /// </summary>
        [DataMember]
        public String CotReportType_FinancialFuturesFutures { get; set; }
        /// <summary>
        /// Gets or sets the CotReportType_Futures.
        /// </summary>
        [DataMember]
        public String CotReportType_Futures { get; set; }
        /// <summary>
        /// Gets or sets the Currency_AustralianDollar.
        /// </summary>
        [DataMember]
        public String Currency_AustralianDollar { get; set; }
        /// <summary>
        /// Gets or sets the Currency_BrasilianReal.
        /// </summary>
        [DataMember]
        public String Currency_BrasilianReal { get; set; }
        /// <summary>
        /// Gets or sets the Currency_BrazilianReal.
        /// </summary>
        [DataMember]
        public String Currency_BrazilianReal { get; set; }
        /// <summary>
        /// Gets or sets the Currency_BritishPound.
        /// </summary>
        [DataMember]
        public String Currency_BritishPound { get; set; }
        /// <summary>
        /// Gets or sets the Currency_CanadianDollar.
        /// </summary>
        [DataMember]
        public String Currency_CanadianDollar { get; set; }
        /// <summary>
        /// Gets or sets the Currency_ChinaYuan.
        /// </summary>
        [DataMember]
        public String Currency_ChinaYuan { get; set; }
        /// <summary>
        /// Gets or sets the Currency_CzechRepublicKoruna.
        /// </summary>
        [DataMember]
        public String Currency_CzechRepublicKoruna { get; set; }
        /// <summary>
        /// Gets or sets the Currency_DenmarkKrone.
        /// </summary>
        [DataMember]
        public String Currency_DenmarkKrone { get; set; }
        /// <summary>
        /// Gets or sets the Currency_Euro.
        /// </summary>
        [DataMember]
        public String Currency_Euro { get; set; }
        /// <summary>
        /// Gets or sets the Currency_HongKongDollar.
        /// </summary>
        [DataMember]
        public String Currency_HongKongDollar { get; set; }
        /// <summary>
        /// Gets or sets the Currency_HungaryForint.
        /// </summary>
        [DataMember]
        public String Currency_HungaryForint { get; set; }
        /// <summary>
        /// Gets or sets the Currency_IndianRupee.
        /// </summary>
        [DataMember]
        public String Currency_IndianRupee { get; set; }
        /// <summary>
        /// Gets or sets the Currency_IsraeliShekel.
        /// </summary>
        [DataMember]
        public String Currency_IsraeliShekel { get; set; }
        /// <summary>
        /// Gets or sets the Currency_JapaneseYen.
        /// </summary>
        [DataMember]
        public String Currency_JapaneseYen { get; set; }
        /// <summary>
        /// Gets or sets the Currency_KoreanWon.
        /// </summary>
        [DataMember]
        public String Currency_KoreanWon { get; set; }
        /// <summary>
        /// Gets or sets the Currency_MalaysiaRinggit.
        /// </summary>
        [DataMember]
        public String Currency_MalaysiaRinggit { get; set; }
        /// <summary>
        /// Gets or sets the Currency_MexicanPeso.
        /// </summary>
        [DataMember]
        public String Currency_MexicanPeso { get; set; }
        /// <summary>
        /// Gets or sets the Currency_NewZealandDollar.
        /// </summary>
        [DataMember]
        public String Currency_NewZealandDollar { get; set; }
        /// <summary>
        /// Gets or sets the Currency_NorwayKrone.
        /// </summary>
        [DataMember]
        public String Currency_NorwayKrone { get; set; }
        /// <summary>
        /// Gets or sets the Currency_PolandZloty.
        /// </summary>
        [DataMember]
        public String Currency_PolandZloty { get; set; }
        /// <summary>
        /// Gets or sets the Currency_RussiaRuble.
        /// </summary>
        [DataMember]
        public String Currency_RussiaRuble { get; set; }
        /// <summary>
        /// Gets or sets the Currency_SaudiRiyal.
        /// </summary>
        [DataMember]
        public String Currency_SaudiRiyal { get; set; }
        /// <summary>
        /// Gets or sets the Currency_SingaporeDollar.
        /// </summary>
        [DataMember]
        public String Currency_SingaporeDollar { get; set; }
        /// <summary>
        /// Gets or sets the Currency_SouthAfricanRand.
        /// </summary>
        [DataMember]
        public String Currency_SouthAfricanRand { get; set; }
        /// <summary>
        /// Gets or sets the Currency_SwedishKrona.
        /// </summary>
        [DataMember]
        public String Currency_SwedishKrona { get; set; }
        /// <summary>
        /// Gets or sets the Currency_SwissFranc.
        /// </summary>
        [DataMember]
        public String Currency_SwissFranc { get; set; }
        /// <summary>
        /// Gets or sets the Currency_TaiwanNewDollar.
        /// </summary>
        [DataMember]
        public String Currency_TaiwanNewDollar { get; set; }
        /// <summary>
        /// Gets or sets the Currency_ThailandBaht.
        /// </summary>
        [DataMember]
        public String Currency_ThailandBaht { get; set; }
        /// <summary>
        /// Gets or sets the Currency_TurkeyLira.
        /// </summary>
        [DataMember]
        public String Currency_TurkeyLira { get; set; }
        /// <summary>
        /// Gets or sets the Currency_UsDollar.
        /// </summary>
        [DataMember]
        public String Currency_UsDollar { get; set; }
        /// <summary>
        /// Gets or sets the DashStyleHelper_Dash.
        /// </summary>
        [DataMember]
        public String DashStyleHelper_Dash { get; set; }
        /// <summary>
        /// Gets or sets the DashStyleHelper_DashDot.
        /// </summary>
        [DataMember]
        public String DashStyleHelper_DashDot { get; set; }
        /// <summary>
        /// Gets or sets the DashStyleHelper_DashDotDot.
        /// </summary>
        [DataMember]
        public String DashStyleHelper_DashDotDot { get; set; }
        /// <summary>
        /// Gets or sets the DashStyleHelper_Dot.
        /// </summary>
        [DataMember]
        public String DashStyleHelper_Dot { get; set; }
        /// <summary>
        /// Gets or sets the DashStyleHelper_Solid.
        /// </summary>
        [DataMember]
        public String DashStyleHelper_Solid { get; set; }
        /// <summary>
        /// Gets or sets the DataType_Ask.
        /// </summary>
        [DataMember]
        public String DataType_Ask { get; set; }
        /// <summary>
        /// Gets or sets the DataType_Bid.
        /// </summary>
        [DataMember]
        public String DataType_Bid { get; set; }
        /// <summary>
        /// Gets or sets the DataType_Last.
        /// </summary>
        [DataMember]
        public String DataType_Last { get; set; }
        /// <summary>
        /// Gets or sets the DbType_MsSqlCe.
        /// </summary>
        [DataMember]
        public String DbType_MsSqlCe { get; set; }
        /// <summary>
        /// Gets or sets the DbType_MySql.
        /// </summary>
        [DataMember]
        public String DbType_MySql { get; set; }
        /// <summary>
        /// Gets or sets the DbType_SQLite.
        /// </summary>
        [DataMember]
        public String DbType_SQLite { get; set; }
        /// <summary>
        /// Gets or sets the EntryHandling_AllEntries.
        /// </summary>
        [DataMember]
        public String EntryHandling_AllEntries { get; set; }
        /// <summary>
        /// Gets or sets the EntryHandling_UniqueEntries.
        /// </summary>
        [DataMember]
        public String EntryHandling_UniqueEntries { get; set; }
        /// <summary>
        /// Gets or sets the ErrorCode_LoginExpired.
        /// </summary>
        [DataMember]
        public String ErrorCode_LoginExpired { get; set; }
        /// <summary>
        /// Gets or sets the ErrorCode_LogOnFailed.
        /// </summary>
        [DataMember]
        public String ErrorCode_LogOnFailed { get; set; }
        /// <summary>
        /// Gets or sets the ErrorCode_NoError.
        /// </summary>
        [DataMember]
        public String ErrorCode_NoError { get; set; }
        /// <summary>
        /// Gets or sets the ErrorCode_NoLiveOrdersOnSimulationLicense.
        /// </summary>
        [DataMember]
        public String ErrorCode_NoLiveOrdersOnSimulationLicense { get; set; }
        /// <summary>
        /// Gets or sets the ErrorCode_OrderRejected.
        /// </summary>
        [DataMember]
        public String ErrorCode_OrderRejected { get; set; }
        /// <summary>
        /// Gets or sets the ErrorCode_Panic.
        /// </summary>
        [DataMember]
        public String ErrorCode_Panic { get; set; }
        /// <summary>
        /// Gets or sets the ErrorCode_ReloadingData.
        /// </summary>
        [DataMember]
        public String ErrorCode_ReloadingData { get; set; }
        /// <summary>
        /// Gets or sets the ErrorCode_UnableToCancelOrder.
        /// </summary>
        [DataMember]
        public String ErrorCode_UnableToCancelOrder { get; set; }
        /// <summary>
        /// Gets or sets the ErrorCode_UnableToChangeOrder.
        /// </summary>
        [DataMember]
        public String ErrorCode_UnableToChangeOrder { get; set; }
        /// <summary>
        /// Gets or sets the ErrorCode_UnableToSubmitOrder.
        /// </summary>
        [DataMember]
        public String ErrorCode_UnableToSubmitOrder { get; set; }
        /// <summary>
        /// Gets or sets the ErrorCode_UserAbort.
        /// </summary>
        [DataMember]
        public String ErrorCode_UserAbort { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Ace.
        /// </summary>
        [DataMember]
        public String Exchange_Ace { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Aeb.
        /// </summary>
        [DataMember]
        public String Exchange_Aeb { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Aex.
        /// </summary>
        [DataMember]
        public String Exchange_Aex { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Amex.
        /// </summary>
        [DataMember]
        public String Exchange_Amex { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Arca.
        /// </summary>
        [DataMember]
        public String Exchange_Arca { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Asx.
        /// </summary>
        [DataMember]
        public String Exchange_Asx { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Belfox.
        /// </summary>
        [DataMember]
        public String Exchange_Belfox { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Bm.
        /// </summary>
        [DataMember]
        public String Exchange_Bm { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Bovespa.
        /// </summary>
        [DataMember]
        public String Exchange_Bovespa { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Box.
        /// </summary>
        [DataMember]
        public String Exchange_Box { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_BrokerTec.
        /// </summary>
        [DataMember]
        public String Exchange_BrokerTec { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Brut.
        /// </summary>
        [DataMember]
        public String Exchange_Brut { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Bse.
        /// </summary>
        [DataMember]
        public String Exchange_Bse { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_BTrade.
        /// </summary>
        [DataMember]
        public String Exchange_BTrade { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Bvme.
        /// </summary>
        [DataMember]
        public String Exchange_Bvme { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Caes.
        /// </summary>
        [DataMember]
        public String Exchange_Caes { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Cboe.
        /// </summary>
        [DataMember]
        public String Exchange_Cboe { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Cfe.
        /// </summary>
        [DataMember]
        public String Exchange_Cfe { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_ClearPort.
        /// </summary>
        [DataMember]
        public String Exchange_ClearPort { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Cme.
        /// </summary>
        [DataMember]
        public String Exchange_Cme { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Czce.
        /// </summary>
        [DataMember]
        public String Exchange_Czce { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Dce.
        /// </summary>
        [DataMember]
        public String Exchange_Dce { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Default.
        /// </summary>
        [DataMember]
        public String Exchange_Default { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_ECbot.
        /// </summary>
        [DataMember]
        public String Exchange_ECbot { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Eurex.
        /// </summary>
        [DataMember]
        public String Exchange_Eurex { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_EurexSW.
        /// </summary>
        [DataMember]
        public String Exchange_EurexSW { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_EurexUS.
        /// </summary>
        [DataMember]
        public String Exchange_EurexUS { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_FairX.
        /// </summary>
        [DataMember]
        public String Exchange_FairX { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Fta.
        /// </summary>
        [DataMember]
        public String Exchange_Fta { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Gdax.
        /// </summary>
        [DataMember]
        public String Exchange_Gdax { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Globex.
        /// </summary>
        [DataMember]
        public String Exchange_Globex { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Hkex.
        /// </summary>
        [DataMember]
        public String Exchange_Hkex { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Hkfe.
        /// </summary>
        [DataMember]
        public String Exchange_Hkfe { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_IBIdeal.
        /// </summary>
        [DataMember]
        public String Exchange_IBIdeal { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_IBIdealPro.
        /// </summary>
        [DataMember]
        public String Exchange_IBIdealPro { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_IBTmbr.
        /// </summary>
        [DataMember]
        public String Exchange_IBTmbr { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_IBVwap.
        /// </summary>
        [DataMember]
        public String Exchange_IBVwap { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Ice.
        /// </summary>
        [DataMember]
        public String Exchange_Ice { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Idem.
        /// </summary>
        [DataMember]
        public String Exchange_Idem { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Inca.
        /// </summary>
        [DataMember]
        public String Exchange_Inca { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Ipe.
        /// </summary>
        [DataMember]
        public String Exchange_Ipe { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Ise.
        /// </summary>
        [DataMember]
        public String Exchange_Ise { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Island.
        /// </summary>
        [DataMember]
        public String Exchange_Island { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Kse.
        /// </summary>
        [DataMember]
        public String Exchange_Kse { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Liffe.
        /// </summary>
        [DataMember]
        public String Exchange_Liffe { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_LiffeCommodities.
        /// </summary>
        [DataMember]
        public String Exchange_LiffeCommodities { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Lse.
        /// </summary>
        [DataMember]
        public String Exchange_Lse { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Matif.
        /// </summary>
        [DataMember]
        public String Exchange_Matif { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Me.
        /// </summary>
        [DataMember]
        public String Exchange_Me { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Meff.
        /// </summary>
        [DataMember]
        public String Exchange_Meff { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Mexi.
        /// </summary>
        [DataMember]
        public String Exchange_Mexi { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Monep.
        /// </summary>
        [DataMember]
        public String Exchange_Monep { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Nasdaq.
        /// </summary>
        [DataMember]
        public String Exchange_Nasdaq { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Nnm.
        /// </summary>
        [DataMember]
        public String Exchange_Nnm { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Nqlx.
        /// </summary>
        [DataMember]
        public String Exchange_Nqlx { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Nscm.
        /// </summary>
        [DataMember]
        public String Exchange_Nscm { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Nse.
        /// </summary>
        [DataMember]
        public String Exchange_Nse { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Nybot.
        /// </summary>
        [DataMember]
        public String Exchange_Nybot { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Nymex.
        /// </summary>
        [DataMember]
        public String Exchange_Nymex { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Nyse.
        /// </summary>
        [DataMember]
        public String Exchange_Nyse { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Oes.
        /// </summary>
        [DataMember]
        public String Exchange_Oes { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Omx.
        /// </summary>
        [DataMember]
        public String Exchange_Omx { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_One.
        /// </summary>
        [DataMember]
        public String Exchange_One { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Opra.
        /// </summary>
        [DataMember]
        public String Exchange_Opra { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Ose.
        /// </summary>
        [DataMember]
        public String Exchange_Ose { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_OtcBB.
        /// </summary>
        [DataMember]
        public String Exchange_OtcBB { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Phlx.
        /// </summary>
        [DataMember]
        public String Exchange_Phlx { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Pse.
        /// </summary>
        [DataMember]
        public String Exchange_Pse { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Redi.
        /// </summary>
        [DataMember]
        public String Exchange_Redi { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Sbf.
        /// </summary>
        [DataMember]
        public String Exchange_Sbf { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_SDot.
        /// </summary>
        [DataMember]
        public String Exchange_SDot { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Sfb.
        /// </summary>
        [DataMember]
        public String Exchange_Sfb { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Sfe.
        /// </summary>
        [DataMember]
        public String Exchange_Sfe { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Sfx.
        /// </summary>
        [DataMember]
        public String Exchange_Sfx { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Sgx.
        /// </summary>
        [DataMember]
        public String Exchange_Sgx { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Shfe.
        /// </summary>
        [DataMember]
        public String Exchange_Shfe { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Shse.
        /// </summary>
        [DataMember]
        public String Exchange_Shse { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Snfe.
        /// </summary>
        [DataMember]
        public String Exchange_Snfe { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Soes.
        /// </summary>
        [DataMember]
        public String Exchange_Soes { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Swb.
        /// </summary>
        [DataMember]
        public String Exchange_Swb { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Swx.
        /// </summary>
        [DataMember]
        public String Exchange_Swx { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Szse.
        /// </summary>
        [DataMember]
        public String Exchange_Szse { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Tadawul.
        /// </summary>
        [DataMember]
        public String Exchange_Tadawul { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Tse.
        /// </summary>
        [DataMember]
        public String Exchange_Tse { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Tsx.
        /// </summary>
        [DataMember]
        public String Exchange_Tsx { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_TsxV.
        /// </summary>
        [DataMember]
        public String Exchange_TsxV { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_US.
        /// </summary>
        [DataMember]
        public String Exchange_US { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_VirtX.
        /// </summary>
        [DataMember]
        public String Exchange_VirtX { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Vse.
        /// </summary>
        [DataMember]
        public String Exchange_Vse { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Xetra.
        /// </summary>
        [DataMember]
        public String Exchange_Xetra { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_AverageDailyVolume.
        /// </summary>
        [DataMember]
        public String FundamentalDataType_AverageDailyVolume { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_Beta.
        /// </summary>
        [DataMember]
        public String FundamentalDataType_Beta { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_CalendarYearHigh.
        /// </summary>
        [DataMember]
        public String FundamentalDataType_CalendarYearHigh { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_CalendarYearHighDate.
        /// </summary>
        [DataMember]
        public String FundamentalDataType_CalendarYearHighDate { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_CalendarYearLow.
        /// </summary>
        [DataMember]
        public String FundamentalDataType_CalendarYearLow { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_CalendarYearLowDate.
        /// </summary>
        [DataMember]
        public String FundamentalDataType_CalendarYearLowDate { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_CurrentRatio.
        /// </summary>
        [DataMember]
        public String FundamentalDataType_CurrentRatio { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_Day200MovingAverage.
        /// </summary>
        [DataMember]
        public String FundamentalDataType_Day200MovingAverage { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_Day50MovingAverage.
        /// </summary>
        [DataMember]
        public String FundamentalDataType_Day50MovingAverage { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_DividendAmount.
        /// </summary>
        [DataMember]
        public String FundamentalDataType_DividendAmount { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_DividendPayDate.
        /// </summary>
        [DataMember]
        public String FundamentalDataType_DividendPayDate { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_DividendYield.
        /// </summary>
        [DataMember]
        public String FundamentalDataType_DividendYield { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_EarningsPerShare.
        /// </summary>
        [DataMember]
        public String FundamentalDataType_EarningsPerShare { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_FiveYearsGrowthPercentage.
        /// </summary>
        [DataMember]
        public String FundamentalDataType_FiveYearsGrowthPercentage { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_High52Weeks.
        /// </summary>
        [DataMember]
        public String FundamentalDataType_High52Weeks { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_High52WeeksDate.
        /// </summary>
        [DataMember]
        public String FundamentalDataType_High52WeeksDate { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_HistoricalVolatility.
        /// </summary>
        [DataMember]
        public String FundamentalDataType_HistoricalVolatility { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_InsiderOwned.
        /// </summary>
        [DataMember]
        public String FundamentalDataType_InsiderOwned { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_Low52Weeks.
        /// </summary>
        [DataMember]
        public String FundamentalDataType_Low52Weeks { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_Low52WeeksDate.
        /// </summary>
        [DataMember]
        public String FundamentalDataType_Low52WeeksDate { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_MarketCap.
        /// </summary>
        [DataMember]
        public String FundamentalDataType_MarketCap { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_NextEarningsDate.
        /// </summary>
        [DataMember]
        public String FundamentalDataType_NextEarningsDate { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_NextYearsEarningsPerShare.
        /// </summary>
        [DataMember]
        public String FundamentalDataType_NextYearsEarningsPerShare { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_PercentHeldByInstitutions.
        /// </summary>
        [DataMember]
        public String FundamentalDataType_PercentHeldByInstitutions { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_PriceEarningsRatio.
        /// </summary>
        [DataMember]
        public String FundamentalDataType_PriceEarningsRatio { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_RevenuePerShare.
        /// </summary>
        [DataMember]
        public String FundamentalDataType_RevenuePerShare { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_SharesOutstanding.
        /// </summary>
        [DataMember]
        public String FundamentalDataType_SharesOutstanding { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_ShortInterest.
        /// </summary>
        [DataMember]
        public String FundamentalDataType_ShortInterest { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_ShortInterestRatio.
        /// </summary>
        [DataMember]
        public String FundamentalDataType_ShortInterestRatio { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_VWAP.
        /// </summary>
        [DataMember]
        public String FundamentalDataType_VWAP { get; set; }
        /// <summary>
        /// Gets or sets the FxcmServerConnectionType_MarketData.
        /// </summary>
        [DataMember]
        public String FxcmServerConnectionType_MarketData { get; set; }
        /// <summary>
        /// Gets or sets the FxcmServerConnectionType_Orders.
        /// </summary>
        [DataMember]
        public String FxcmServerConnectionType_Orders { get; set; }
        /// <summary>
        /// Gets or sets the FxLotSize_HundredK.
        /// </summary>
        [DataMember]
        public String FxLotSize_HundredK { get; set; }
        /// <summary>
        /// Gets or sets the FxLotSize_OneK.
        /// </summary>
        [DataMember]
        public String FxLotSize_OneK { get; set; }
        /// <summary>
        /// Gets or sets the FxLotSize_TenK.
        /// </summary>
        [DataMember]
        public String FxLotSize_TenK { get; set; }
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
        /// Gets or sets the IBConnectUsing_Gateway.
        /// </summary>
        [DataMember]
        public String IBConnectUsing_Gateway { get; set; }
        /// <summary>
        /// Gets or sets the IBConnectUsing_Tws.
        /// </summary>
        [DataMember]
        public String IBConnectUsing_Tws { get; set; }
        /// <summary>
        /// Gets or sets the IBLogLevel_Detail.
        /// </summary>
        [DataMember]
        public String IBLogLevel_Detail { get; set; }
        /// <summary>
        /// Gets or sets the IBLogLevel_Error.
        /// </summary>
        [DataMember]
        public String IBLogLevel_Error { get; set; }
        /// <summary>
        /// Gets or sets the IBLogLevel_Information.
        /// </summary>
        [DataMember]
        public String IBLogLevel_Information { get; set; }
        /// <summary>
        /// Gets or sets the IBLogLevel_System.
        /// </summary>
        [DataMember]
        public String IBLogLevel_System { get; set; }
        /// <summary>
        /// Gets or sets the IBLogLevel_Warning.
        /// </summary>
        [DataMember]
        public String IBLogLevel_Warning { get; set; }
        /// <summary>
        /// Gets or sets the InstrumentType_Cfd.
        /// </summary>
        [DataMember]
        public String InstrumentType_Cfd { get; set; }
        /// <summary>
        /// Gets or sets the InstrumentType_CryptoCurrency.
        /// </summary>
        [DataMember]
        public String InstrumentType_CryptoCurrency { get; set; }
        /// <summary>
        /// Gets or sets the InstrumentType_Forex.
        /// </summary>
        [DataMember]
        public String InstrumentType_Forex { get; set; }
        /// <summary>
        /// Gets or sets the InstrumentType_Future.
        /// </summary>
        [DataMember]
        public String InstrumentType_Future { get; set; }
        /// <summary>
        /// Gets or sets the InstrumentType_Index.
        /// </summary>
        [DataMember]
        public String InstrumentType_Index { get; set; }
        /// <summary>
        /// Gets or sets the InstrumentType_Option.
        /// </summary>
        [DataMember]
        public String InstrumentType_Option { get; set; }
        /// <summary>
        /// Gets or sets the InstrumentType_Spread.
        /// </summary>
        [DataMember]
        public String InstrumentType_Spread { get; set; }
        /// <summary>
        /// Gets or sets the InstrumentType_Stock.
        /// </summary>
        [DataMember]
        public String InstrumentType_Stock { get; set; }
        /// <summary>
        /// Gets or sets the LicenseType_FreeTrial.
        /// </summary>
        [DataMember]
        public String LicenseType_FreeTrial { get; set; }
        /// <summary>
        /// Gets or sets the LicenseType_Regular.
        /// </summary>
        [DataMember]
        public String LicenseType_Regular { get; set; }
        /// <summary>
        /// Gets or sets the LicenseType_SimulationOnly.
        /// </summary>
        [DataMember]
        public String LicenseType_SimulationOnly { get; set; }
        /// <summary>
        /// Gets or sets the LiquidationState_Disabled.
        /// </summary>
        [DataMember]
        public String LiquidationState_Disabled { get; set; }
        /// <summary>
        /// Gets or sets the LiquidationState_Enabled.
        /// </summary>
        [DataMember]
        public String LiquidationState_Enabled { get; set; }
        /// <summary>
        /// Gets or sets the LiquidationState_Excluded.
        /// </summary>
        [DataMember]
        public String LiquidationState_Excluded { get; set; }
        /// <summary>
        /// Gets or sets the LiquidationState_Fail.
        /// </summary>
        [DataMember]
        public String LiquidationState_Fail { get; set; }
        /// <summary>
        /// Gets or sets the LiquidationState_ValidationFail.
        /// </summary>
        [DataMember]
        public String LiquidationState_ValidationFail { get; set; }
        /// <summary>
        /// Gets or sets the LocalOcoCancelBehavior_CancelOtherSide.
        /// </summary>
        [DataMember]
        public String LocalOcoCancelBehavior_CancelOtherSide { get; set; }
        /// <summary>
        /// Gets or sets the LocalOcoCancelBehavior_KeepOtherSideOpen.
        /// </summary>
        [DataMember]
        public String LocalOcoCancelBehavior_KeepOtherSideOpen { get; set; }
        /// <summary>
        /// Gets or sets the LogCategories_Account.
        /// </summary>
        [DataMember]
        public String LogCategories_Account { get; set; }
        /// <summary>
        /// Gets or sets the LogCategories_Ati.
        /// </summary>
        [DataMember]
        public String LogCategories_Ati { get; set; }
        /// <summary>
        /// Gets or sets the LogCategories_Connection.
        /// </summary>
        [DataMember]
        public String LogCategories_Connection { get; set; }
        /// <summary>
        /// Gets or sets the LogCategories_DB.
        /// </summary>
        [DataMember]
        public String LogCategories_DB { get; set; }
        /// <summary>
        /// Gets or sets the LogCategories_Default.
        /// </summary>
        [DataMember]
        public String LogCategories_Default { get; set; }
        /// <summary>
        /// Gets or sets the LogCategories_Execution.
        /// </summary>
        [DataMember]
        public String LogCategories_Execution { get; set; }
        /// <summary>
        /// Gets or sets the LogCategories_Job.
        /// </summary>
        [DataMember]
        public String LogCategories_Job { get; set; }
        /// <summary>
        /// Gets or sets the LogCategories_LicenseManagement.
        /// </summary>
        [DataMember]
        public String LogCategories_LicenseManagement { get; set; }
        /// <summary>
        /// Gets or sets the LogCategories_Money.
        /// </summary>
        [DataMember]
        public String LogCategories_Money { get; set; }
        /// <summary>
        /// Gets or sets the LogCategories_NinjaScript.
        /// </summary>
        [DataMember]
        public String LogCategories_NinjaScript { get; set; }
        /// <summary>
        /// Gets or sets the LogCategories_Order.
        /// </summary>
        [DataMember]
        public String LogCategories_Order { get; set; }
        /// <summary>
        /// Gets or sets the LogCategories_Position.
        /// </summary>
        [DataMember]
        public String LogCategories_Position { get; set; }
        /// <summary>
        /// Gets or sets the LogCategories_Strategy.
        /// </summary>
        [DataMember]
        public String LogCategories_Strategy { get; set; }
        /// <summary>
        /// Gets or sets the LogCategories_System.
        /// </summary>
        [DataMember]
        public String LogCategories_System { get; set; }
        /// <summary>
        /// Gets or sets the LogCategories_User.
        /// </summary>
        [DataMember]
        public String LogCategories_User { get; set; }
        /// <summary>
        /// Gets or sets the LogLevel_Alert.
        /// </summary>
        [DataMember]
        public String LogLevel_Alert { get; set; }
        /// <summary>
        /// Gets or sets the LogLevel_Error.
        /// </summary>
        [DataMember]
        public String LogLevel_Error { get; set; }
        /// <summary>
        /// Gets or sets the LogLevel_Information.
        /// </summary>
        [DataMember]
        public String LogLevel_Information { get; set; }
        /// <summary>
        /// Gets or sets the LogLevel_Warning.
        /// </summary>
        [DataMember]
        public String LogLevel_Warning { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataScanType_AskPrice.
        /// </summary>
        [DataMember]
        public String MarketDataScanType_AskPrice { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataScanType_AskVolume.
        /// </summary>
        [DataMember]
        public String MarketDataScanType_AskVolume { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataScanType_BidPrice.
        /// </summary>
        [DataMember]
        public String MarketDataScanType_BidPrice { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataScanType_BidVolume.
        /// </summary>
        [DataMember]
        public String MarketDataScanType_BidVolume { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataScanType_DailyHighPrice.
        /// </summary>
        [DataMember]
        public String MarketDataScanType_DailyHighPrice { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataScanType_DailyLowPrice.
        /// </summary>
        [DataMember]
        public String MarketDataScanType_DailyLowPrice { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataScanType_DailyVolume.
        /// </summary>
        [DataMember]
        public String MarketDataScanType_DailyVolume { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataScanType_LastClosePrice.
        /// </summary>
        [DataMember]
        public String MarketDataScanType_LastClosePrice { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataScanType_LastPrice.
        /// </summary>
        [DataMember]
        public String MarketDataScanType_LastPrice { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataScanType_LastVolume.
        /// </summary>
        [DataMember]
        public String MarketDataScanType_LastVolume { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataScanType_OpeningPrice.
        /// </summary>
        [DataMember]
        public String MarketDataScanType_OpeningPrice { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataScanType_OpenInterest.
        /// </summary>
        [DataMember]
        public String MarketDataScanType_OpenInterest { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataScanType_SettlementPrice.
        /// </summary>
        [DataMember]
        public String MarketDataScanType_SettlementPrice { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataType_Ask.
        /// </summary>
        [DataMember]
        public String MarketDataType_Ask { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataType_Bid.
        /// </summary>
        [DataMember]
        public String MarketDataType_Bid { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataType_DailyHigh.
        /// </summary>
        [DataMember]
        public String MarketDataType_DailyHigh { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataType_DailyLow.
        /// </summary>
        [DataMember]
        public String MarketDataType_DailyLow { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataType_DailyVolume.
        /// </summary>
        [DataMember]
        public String MarketDataType_DailyVolume { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataType_Last.
        /// </summary>
        [DataMember]
        public String MarketDataType_Last { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataType_LastClose.
        /// </summary>
        [DataMember]
        public String MarketDataType_LastClose { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataType_Opening.
        /// </summary>
        [DataMember]
        public String MarketDataType_Opening { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataType_OpenInterest.
        /// </summary>
        [DataMember]
        public String MarketDataType_OpenInterest { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataType_Settlement.
        /// </summary>
        [DataMember]
        public String MarketDataType_Settlement { get; set; }
        /// <summary>
        /// Gets or sets the MarketPosition_Flat.
        /// </summary>
        [DataMember]
        public String MarketPosition_Flat { get; set; }
        /// <summary>
        /// Gets or sets the MarketPosition_Long.
        /// </summary>
        [DataMember]
        public String MarketPosition_Long { get; set; }
        /// <summary>
        /// Gets or sets the MarketPosition_Short.
        /// </summary>
        [DataMember]
        public String MarketPosition_Short { get; set; }
        /// <summary>
        /// Gets or sets the MaximumBarsLookBack_Infinite.
        /// </summary>
        [DataMember]
        public String MaximumBarsLookBack_Infinite { get; set; }
        /// <summary>
        /// Gets or sets the MaximumBarsLookBack_TwoHundredFiftySix.
        /// </summary>
        [DataMember]
        public String MaximumBarsLookBack_TwoHundredFiftySix { get; set; }
        /// <summary>
        /// Gets or sets the MergePolicy_DoNotMerge.
        /// </summary>
        [DataMember]
        public String MergePolicy_DoNotMerge { get; set; }
        /// <summary>
        /// Gets or sets the MergePolicy_MergeBackAdjusted.
        /// </summary>
        [DataMember]
        public String MergePolicy_MergeBackAdjusted { get; set; }
        /// <summary>
        /// Gets or sets the MergePolicy_MergeNonBackAdjusted.
        /// </summary>
        [DataMember]
        public String MergePolicy_MergeNonBackAdjusted { get; set; }
        /// <summary>
        /// Gets or sets the MergePolicy_UseDefault.
        /// </summary>
        [DataMember]
        public String MergePolicy_UseDefault { get; set; }
        /// <summary>
        /// Gets or sets the MergePolicy_UseGlobalSettings.
        /// </summary>
        [DataMember]
        public String MergePolicy_UseGlobalSettings { get; set; }
        /// <summary>
        /// Gets or sets the Mode_Live.
        /// </summary>
        [DataMember]
        public String Mode_Live { get; set; }
        /// <summary>
        /// Gets or sets the Mode_Simulation.
        /// </summary>
        [DataMember]
        public String Mode_Simulation { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_AfxCnf.
        /// </summary>
        [DataMember]
        public String NewsProvider_AfxCnf { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_AfxFocus.
        /// </summary>
        [DataMember]
        public String NewsProvider_AfxFocus { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_AfxUk.
        /// </summary>
        [DataMember]
        public String NewsProvider_AfxUk { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_Asia.
        /// </summary>
        [DataMember]
        public String NewsProvider_Asia { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_AssociatedPress.
        /// </summary>
        [DataMember]
        public String NewsProvider_AssociatedPress { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_BusinessWire.
        /// </summary>
        [DataMember]
        public String NewsProvider_BusinessWire { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_Canada.
        /// </summary>
        [DataMember]
        public String NewsProvider_Canada { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_Catalog.
        /// </summary>
        [DataMember]
        public String NewsProvider_Catalog { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_CbsMarketWatch.
        /// </summary>
        [DataMember]
        public String NewsProvider_CbsMarketWatch { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_CityFalcon.
        /// </summary>
        [DataMember]
        public String NewsProvider_CityFalcon { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_CMEGroup.
        /// </summary>
        [DataMember]
        public String NewsProvider_CMEGroup { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_CNBC.
        /// </summary>
        [DataMember]
        public String NewsProvider_CNBC { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_Commercial.
        /// </summary>
        [DataMember]
        public String NewsProvider_Commercial { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_Comtex.
        /// </summary>
        [DataMember]
        public String NewsProvider_Comtex { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_DailyFx.
        /// </summary>
        [DataMember]
        public String NewsProvider_DailyFx { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_Default.
        /// </summary>
        [DataMember]
        public String NewsProvider_Default { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_DowJones.
        /// </summary>
        [DataMember]
        public String NewsProvider_DowJones { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_Dtn.
        /// </summary>
        [DataMember]
        public String NewsProvider_Dtn { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_DtnNewsBreak.
        /// </summary>
        [DataMember]
        public String NewsProvider_DtnNewsBreak { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_EconomicNews.
        /// </summary>
        [DataMember]
        public String NewsProvider_EconomicNews { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_Europe.
        /// </summary>
        [DataMember]
        public String NewsProvider_Europe { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_Fastmarkets.
        /// </summary>
        [DataMember]
        public String NewsProvider_Fastmarkets { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_FirstCall.
        /// </summary>
        [DataMember]
        public String NewsProvider_FirstCall { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_FuturesWorld.
        /// </summary>
        [DataMember]
        public String NewsProvider_FuturesWorld { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_Google.
        /// </summary>
        [DataMember]
        public String NewsProvider_Google { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_InternetWire.
        /// </summary>
        [DataMember]
        public String NewsProvider_InternetWire { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_InvestingDotCom.
        /// </summary>
        [DataMember]
        public String NewsProvider_InvestingDotCom { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_JagNotes.
        /// </summary>
        [DataMember]
        public String NewsProvider_JagNotes { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_KnightRidder.
        /// </summary>
        [DataMember]
        public String NewsProvider_KnightRidder { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_M2.
        /// </summary>
        [DataMember]
        public String NewsProvider_M2 { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_MarketGuide.
        /// </summary>
        [DataMember]
        public String NewsProvider_MarketGuide { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_MarketNewsPub.
        /// </summary>
        [DataMember]
        public String NewsProvider_MarketNewsPub { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_MarketWire.
        /// </summary>
        [DataMember]
        public String NewsProvider_MarketWire { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_MidnightTrader.
        /// </summary>
        [DataMember]
        public String NewsProvider_MidnightTrader { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_PREuro.
        /// </summary>
        [DataMember]
        public String NewsProvider_PREuro { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_PrimeZone.
        /// </summary>
        [DataMember]
        public String NewsProvider_PrimeZone { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_PRNewswire.
        /// </summary>
        [DataMember]
        public String NewsProvider_PRNewswire { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_RealTimeTrader.
        /// </summary>
        [DataMember]
        public String NewsProvider_RealTimeTrader { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_Reuters.
        /// </summary>
        [DataMember]
        public String NewsProvider_Reuters { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_ReutersBasic.
        /// </summary>
        [DataMember]
        public String NewsProvider_ReutersBasic { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_ReutersPremium.
        /// </summary>
        [DataMember]
        public String NewsProvider_ReutersPremium { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_RssDailyFx.
        /// </summary>
        [DataMember]
        public String NewsProvider_RssDailyFx { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_RssEconomicNews.
        /// </summary>
        [DataMember]
        public String NewsProvider_RssEconomicNews { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_RssEconomicNewsForex.
        /// </summary>
        [DataMember]
        public String NewsProvider_RssEconomicNewsForex { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_RssGoogle.
        /// </summary>
        [DataMember]
        public String NewsProvider_RssGoogle { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_RssYahoo.
        /// </summary>
        [DataMember]
        public String NewsProvider_RssYahoo { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_RttProNews.
        /// </summary>
        [DataMember]
        public String NewsProvider_RttProNews { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_TheFlyOnTheWall.
        /// </summary>
        [DataMember]
        public String NewsProvider_TheFlyOnTheWall { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_TradovateTwitter.
        /// </summary>
        [DataMember]
        public String NewsProvider_TradovateTwitter { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_Upi.
        /// </summary>
        [DataMember]
        public String NewsProvider_Upi { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_Us.
        /// </summary>
        [DataMember]
        public String NewsProvider_Us { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_Usda.
        /// </summary>
        [DataMember]
        public String NewsProvider_Usda { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_Yahoo.
        /// </summary>
        [DataMember]
        public String NewsProvider_Yahoo { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_ZacksTrader.
        /// </summary>
        [DataMember]
        public String NewsProvider_ZacksTrader { get; set; }
        /// <summary>
        /// Gets or sets the OhlcMode_HiLo.
        /// </summary>
        [DataMember]
        public String OhlcMode_HiLo { get; set; }
        /// <summary>
        /// Gets or sets the OhlcMode_HLC.
        /// </summary>
        [DataMember]
        public String OhlcMode_HLC { get; set; }
        /// <summary>
        /// Gets or sets the OhlcMode_OHLC.
        /// </summary>
        [DataMember]
        public String OhlcMode_OHLC { get; set; }
        /// <summary>
        /// Gets or sets the Operation_Insert.
        /// </summary>
        [DataMember]
        public String Operation_Insert { get; set; }
        /// <summary>
        /// Gets or sets the Operation_Remove.
        /// </summary>
        [DataMember]
        public String Operation_Remove { get; set; }
        /// <summary>
        /// Gets or sets the Operation_Update.
        /// </summary>
        [DataMember]
        public String Operation_Update { get; set; }
        /// <summary>
        /// Gets or sets the OptionRight_Call.
        /// </summary>
        [DataMember]
        public String OptionRight_Call { get; set; }
        /// <summary>
        /// Gets or sets the OptionRight_Put.
        /// </summary>
        [DataMember]
        public String OptionRight_Put { get; set; }
        /// <summary>
        /// Gets or sets the OptionRight_Unknown.
        /// </summary>
        [DataMember]
        public String OptionRight_Unknown { get; set; }
        /// <summary>
        /// Gets or sets the OrderAction_Buy.
        /// </summary>
        [DataMember]
        public String OrderAction_Buy { get; set; }
        /// <summary>
        /// Gets or sets the OrderAction_BuyToCover.
        /// </summary>
        [DataMember]
        public String OrderAction_BuyToCover { get; set; }
        /// <summary>
        /// Gets or sets the OrderAction_Sell.
        /// </summary>
        [DataMember]
        public String OrderAction_Sell { get; set; }
        /// <summary>
        /// Gets or sets the OrderAction_SellShort.
        /// </summary>
        [DataMember]
        public String OrderAction_SellShort { get; set; }
        /// <summary>
        /// Gets or sets the OrderFillResolution_High.
        /// </summary>
        [DataMember]
        public String OrderFillResolution_High { get; set; }
        /// <summary>
        /// Gets or sets the OrderFillResolution_Standard.
        /// </summary>
        [DataMember]
        public String OrderFillResolution_Standard { get; set; }
        /// <summary>
        /// Gets or sets the OrderState_Accepted.
        /// </summary>
        [DataMember]
        public String OrderState_Accepted { get; set; }
        /// <summary>
        /// Gets or sets the OrderState_AcceptedByRisk.
        /// </summary>
        [DataMember]
        public String OrderState_AcceptedByRisk { get; set; }
        /// <summary>
        /// Gets or sets the OrderState_Busted.
        /// </summary>
        [DataMember]
        public String OrderState_Busted { get; set; }
        /// <summary>
        /// Gets or sets the OrderState_Cancelled.
        /// </summary>
        [DataMember]
        public String OrderState_Cancelled { get; set; }
        /// <summary>
        /// Gets or sets the OrderState_CancelPending.
        /// </summary>
        [DataMember]
        public String OrderState_CancelPending { get; set; }
        /// <summary>
        /// Gets or sets the OrderState_CancelSubmitted.
        /// </summary>
        [DataMember]
        public String OrderState_CancelSubmitted { get; set; }
        /// <summary>
        /// Gets or sets the OrderState_ChangePending.
        /// </summary>
        [DataMember]
        public String OrderState_ChangePending { get; set; }
        /// <summary>
        /// Gets or sets the OrderState_ChangeSubmitted.
        /// </summary>
        [DataMember]
        public String OrderState_ChangeSubmitted { get; set; }
        /// <summary>
        /// Gets or sets the OrderState_Filled.
        /// </summary>
        [DataMember]
        public String OrderState_Filled { get; set; }
        /// <summary>
        /// Gets or sets the OrderState_Initialized.
        /// </summary>
        [DataMember]
        public String OrderState_Initialized { get; set; }
        /// <summary>
        /// Gets or sets the OrderState_PartFilled.
        /// </summary>
        [DataMember]
        public String OrderState_PartFilled { get; set; }
        /// <summary>
        /// Gets or sets the OrderState_Rejected.
        /// </summary>
        [DataMember]
        public String OrderState_Rejected { get; set; }
        /// <summary>
        /// Gets or sets the OrderState_Submitted.
        /// </summary>
        [DataMember]
        public String OrderState_Submitted { get; set; }
        /// <summary>
        /// Gets or sets the OrderState_Suspended.
        /// </summary>
        [DataMember]
        public String OrderState_Suspended { get; set; }
        /// <summary>
        /// Gets or sets the OrderState_TriggerPending.
        /// </summary>
        [DataMember]
        public String OrderState_TriggerPending { get; set; }
        /// <summary>
        /// Gets or sets the OrderState_Unknown.
        /// </summary>
        [DataMember]
        public String OrderState_Unknown { get; set; }
        /// <summary>
        /// Gets or sets the OrderState_Working.
        /// </summary>
        [DataMember]
        public String OrderState_Working { get; set; }
        /// <summary>
        /// Gets or sets the OrderType_Limit.
        /// </summary>
        [DataMember]
        public String OrderType_Limit { get; set; }
        /// <summary>
        /// Gets or sets the OrderType_Market.
        /// </summary>
        [DataMember]
        public String OrderType_Market { get; set; }
        /// <summary>
        /// Gets or sets the OrderType_MIT.
        /// </summary>
        [DataMember]
        public String OrderType_MIT { get; set; }
        /// <summary>
        /// Gets or sets the OrderType_StopLimit.
        /// </summary>
        [DataMember]
        public String OrderType_StopLimit { get; set; }
        /// <summary>
        /// Gets or sets the OrderType_StopMarket.
        /// </summary>
        [DataMember]
        public String OrderType_StopMarket { get; set; }
        /// <summary>
        /// Gets or sets the OrderType_Unknown.
        /// </summary>
        [DataMember]
        public String OrderType_Unknown { get; set; }
        /// <summary>
        /// Gets or sets the PerformanceUnit_Currency.
        /// </summary>
        [DataMember]
        public String PerformanceUnit_Currency { get; set; }
        /// <summary>
        /// Gets or sets the PerformanceUnit_Percent.
        /// </summary>
        [DataMember]
        public String PerformanceUnit_Percent { get; set; }
        /// <summary>
        /// Gets or sets the PerformanceUnit_Pips.
        /// </summary>
        [DataMember]
        public String PerformanceUnit_Pips { get; set; }
        /// <summary>
        /// Gets or sets the PerformanceUnit_Points.
        /// </summary>
        [DataMember]
        public String PerformanceUnit_Points { get; set; }
        /// <summary>
        /// Gets or sets the PerformanceUnit_Ticks.
        /// </summary>
        [DataMember]
        public String PerformanceUnit_Ticks { get; set; }
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
        /// Gets or sets the PlotStyle_Bar.
        /// </summary>
        [DataMember]
        public String PlotStyle_Bar { get; set; }
        /// <summary>
        /// Gets or sets the PlotStyle_Block.
        /// </summary>
        [DataMember]
        public String PlotStyle_Block { get; set; }
        /// <summary>
        /// Gets or sets the PlotStyle_Cross.
        /// </summary>
        [DataMember]
        public String PlotStyle_Cross { get; set; }
        /// <summary>
        /// Gets or sets the PlotStyle_Dot.
        /// </summary>
        [DataMember]
        public String PlotStyle_Dot { get; set; }
        /// <summary>
        /// Gets or sets the PlotStyle_Hash.
        /// </summary>
        [DataMember]
        public String PlotStyle_Hash { get; set; }
        /// <summary>
        /// Gets or sets the PlotStyle_HLine.
        /// </summary>
        [DataMember]
        public String PlotStyle_HLine { get; set; }
        /// <summary>
        /// Gets or sets the PlotStyle_Line.
        /// </summary>
        [DataMember]
        public String PlotStyle_Line { get; set; }
        /// <summary>
        /// Gets or sets the PlotStyle_PriceBox.
        /// </summary>
        [DataMember]
        public String PlotStyle_PriceBox { get; set; }
        /// <summary>
        /// Gets or sets the PlotStyle_Square.
        /// </summary>
        [DataMember]
        public String PlotStyle_Square { get; set; }
        /// <summary>
        /// Gets or sets the PlotStyle_TriangleDown.
        /// </summary>
        [DataMember]
        public String PlotStyle_TriangleDown { get; set; }
        /// <summary>
        /// Gets or sets the PlotStyle_TriangleLeft.
        /// </summary>
        [DataMember]
        public String PlotStyle_TriangleLeft { get; set; }
        /// <summary>
        /// Gets or sets the PlotStyle_TriangleRight.
        /// </summary>
        [DataMember]
        public String PlotStyle_TriangleRight { get; set; }
        /// <summary>
        /// Gets or sets the PlotStyle_TriangleUp.
        /// </summary>
        [DataMember]
        public String PlotStyle_TriangleUp { get; set; }
        /// <summary>
        /// Gets or sets the PointAndFigurePriceType_Close.
        /// </summary>
        [DataMember]
        public String PointAndFigurePriceType_Close { get; set; }
        /// <summary>
        /// Gets or sets the PointAndFigurePriceType_HighsAndLows.
        /// </summary>
        [DataMember]
        public String PointAndFigurePriceType_HighsAndLows { get; set; }
        /// <summary>
        /// Gets or sets the PriceType_Close.
        /// </summary>
        [DataMember]
        public String PriceType_Close { get; set; }
        /// <summary>
        /// Gets or sets the PriceType_High.
        /// </summary>
        [DataMember]
        public String PriceType_High { get; set; }
        /// <summary>
        /// Gets or sets the PriceType_Low.
        /// </summary>
        [DataMember]
        public String PriceType_Low { get; set; }
        /// <summary>
        /// Gets or sets the PriceType_Median.
        /// </summary>
        [DataMember]
        public String PriceType_Median { get; set; }
        /// <summary>
        /// Gets or sets the PriceType_Open.
        /// </summary>
        [DataMember]
        public String PriceType_Open { get; set; }
        /// <summary>
        /// Gets or sets the PriceType_Typical.
        /// </summary>
        [DataMember]
        public String PriceType_Typical { get; set; }
        /// <summary>
        /// Gets or sets the PriceType_Weighted.
        /// </summary>
        [DataMember]
        public String PriceType_Weighted { get; set; }
        /// <summary>
        /// Gets or sets the PrintTo_OutputTab1.
        /// </summary>
        [DataMember]
        public String PrintTo_OutputTab1 { get; set; }
        /// <summary>
        /// Gets or sets the PrintTo_OutputTab2.
        /// </summary>
        [DataMember]
        public String PrintTo_OutputTab2 { get; set; }
        /// <summary>
        /// Gets or sets the Priority_High.
        /// </summary>
        [DataMember]
        public String Priority_High { get; set; }
        /// <summary>
        /// Gets or sets the Priority_Low.
        /// </summary>
        [DataMember]
        public String Priority_Low { get; set; }
        /// <summary>
        /// Gets or sets the Priority_Medium.
        /// </summary>
        [DataMember]
        public String Priority_Medium { get; set; }
        /// <summary>
        /// Gets or sets the QuantityModificationForStocks_IncreaseQuantity.
        /// </summary>
        [DataMember]
        public String QuantityModificationForStocks_IncreaseQuantity { get; set; }
        /// <summary>
        /// Gets or sets the QuantityModificationForStocks_SubmitNewOrder.
        /// </summary>
        [DataMember]
        public String QuantityModificationForStocks_SubmitNewOrder { get; set; }
        /// <summary>
        /// Gets or sets the RangeType_Bars.
        /// </summary>
        [DataMember]
        public String RangeType_Bars { get; set; }
        /// <summary>
        /// Gets or sets the RangeType_CustomRange.
        /// </summary>
        [DataMember]
        public String RangeType_CustomRange { get; set; }
        /// <summary>
        /// Gets or sets the RangeType_Days.
        /// </summary>
        [DataMember]
        public String RangeType_Days { get; set; }
        /// <summary>
        /// Gets or sets the RealtimeErrorHandling_IgnoreAllErrors.
        /// </summary>
        [DataMember]
        public String RealtimeErrorHandling_IgnoreAllErrors { get; set; }
        /// <summary>
        /// Gets or sets the RealtimeErrorHandling_StopCancelClose.
        /// </summary>
        [DataMember]
        public String RealtimeErrorHandling_StopCancelClose { get; set; }
        /// <summary>
        /// Gets or sets the RealtimeErrorHandling_StopCancelCloseIgnoreRejects.
        /// </summary>
        [DataMember]
        public String RealtimeErrorHandling_StopCancelCloseIgnoreRejects { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_Apex.
        /// </summary>
        [DataMember]
        public String RithmicConnection_Apex { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_DayTradingAcademy.
        /// </summary>
        [DataMember]
        public String RithmicConnection_DayTradingAcademy { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_FundedFuturesNetwork.
        /// </summary>
        [DataMember]
        public String RithmicConnection_FundedFuturesNetwork { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_FuturesDE.
        /// </summary>
        [DataMember]
        public String RithmicConnection_FuturesDE { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_MesCapitalPaperTrading.
        /// </summary>
        [DataMember]
        public String RithmicConnection_MesCapitalPaperTrading { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_None.
        /// </summary>
        [DataMember]
        public String RithmicConnection_None { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_Rithmic01Chicago.
        /// </summary>
        [DataMember]
        public String RithmicConnection_Rithmic01Chicago { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_Rithmic01ChicagoAggregatedData.
        /// </summary>
        [DataMember]
        public String RithmicConnection_Rithmic01ChicagoAggregatedData { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_Rithmic01ChicagoMDP3.
        /// </summary>
        [DataMember]
        public String RithmicConnection_Rithmic01ChicagoMDP3 { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_Rithmic01ChicagoPaperTrading.
        /// </summary>
        [DataMember]
        public String RithmicConnection_Rithmic01ChicagoPaperTrading { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_Rithmic01ChicagoPaperTradingAggregatedData.
        /// </summary>
        [DataMember]
        public String RithmicConnection_Rithmic01ChicagoPaperTradingAggregatedData { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_Rithmic01Colocation75.
        /// </summary>
        [DataMember]
        public String RithmicConnection_Rithmic01Colocation75 { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_Rithmic01Europe.
        /// </summary>
        [DataMember]
        public String RithmicConnection_Rithmic01Europe { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_Rithmic01EuropeAggregatedData.
        /// </summary>
        [DataMember]
        public String RithmicConnection_Rithmic01EuropeAggregatedData { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_Rithmic01EuropePaperTrading.
        /// </summary>
        [DataMember]
        public String RithmicConnection_Rithmic01EuropePaperTrading { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_Rithmic01EuropePaperTradingAggregatedData.
        /// </summary>
        [DataMember]
        public String RithmicConnection_Rithmic01EuropePaperTradingAggregatedData { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_Rithmic01Singapore.
        /// </summary>
        [DataMember]
        public String RithmicConnection_Rithmic01Singapore { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_Rithmic01SingaporeAggregatedData.
        /// </summary>
        [DataMember]
        public String RithmicConnection_Rithmic01SingaporeAggregatedData { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_Rithmic01Test.
        /// </summary>
        [DataMember]
        public String RithmicConnection_Rithmic01Test { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_Rithmic01TestAggregatedData.
        /// </summary>
        [DataMember]
        public String RithmicConnection_Rithmic01TestAggregatedData { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_Rithmic01Tokyo.
        /// </summary>
        [DataMember]
        public String RithmicConnection_Rithmic01Tokyo { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_Rithmic01TokyoAggregatedData.
        /// </summary>
        [DataMember]
        public String RithmicConnection_Rithmic01TokyoAggregatedData { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_Rithmic01TokyoPaperTrading.
        /// </summary>
        [DataMember]
        public String RithmicConnection_Rithmic01TokyoPaperTrading { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_Rithmic01TokyoPaperTradingAggregatedData.
        /// </summary>
        [DataMember]
        public String RithmicConnection_Rithmic01TokyoPaperTradingAggregatedData { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_Rithmic01UsEast.
        /// </summary>
        [DataMember]
        public String RithmicConnection_Rithmic01UsEast { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_Rithmic01UsEastAggregatedData.
        /// </summary>
        [DataMember]
        public String RithmicConnection_Rithmic01UsEastAggregatedData { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_Rithmic01UsWest.
        /// </summary>
        [DataMember]
        public String RithmicConnection_Rithmic01UsWest { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_Rithmic01UsWestAggregatedData.
        /// </summary>
        [DataMember]
        public String RithmicConnection_Rithmic01UsWestAggregatedData { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_TopstepTraderPaperTrading.
        /// </summary>
        [DataMember]
        public String RithmicConnection_TopstepTraderPaperTrading { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_TradeFundrr.
        /// </summary>
        [DataMember]
        public String RithmicConnection_TradeFundrr { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_UProfitTrader.
        /// </summary>
        [DataMember]
        public String RithmicConnection_UProfitTrader { get; set; }
        /// <summary>
        /// Gets or sets the ScaleJustification_Left.
        /// </summary>
        [DataMember]
        public String ScaleJustification_Left { get; set; }
        /// <summary>
        /// Gets or sets the ScaleJustification_Overlay.
        /// </summary>
        [DataMember]
        public String ScaleJustification_Overlay { get; set; }
        /// <summary>
        /// Gets or sets the ScaleJustification_Right.
        /// </summary>
        [DataMember]
        public String ScaleJustification_Right { get; set; }
        /// <summary>
        /// Gets or sets the ScanConditionItemType_CandleStickPattern.
        /// </summary>
        [DataMember]
        public String ScanConditionItemType_CandleStickPattern { get; set; }
        /// <summary>
        /// Gets or sets the ScanConditionItemType_Exchanges.
        /// </summary>
        [DataMember]
        public String ScanConditionItemType_Exchanges { get; set; }
        /// <summary>
        /// Gets or sets the ScanConditionItemType_FundamentalData.
        /// </summary>
        [DataMember]
        public String ScanConditionItemType_FundamentalData { get; set; }
        /// <summary>
        /// Gets or sets the ScanConditionItemType_Indicator.
        /// </summary>
        [DataMember]
        public String ScanConditionItemType_Indicator { get; set; }
        /// <summary>
        /// Gets or sets the ScanConditionItemType_LastPriceOfInstrument.
        /// </summary>
        [DataMember]
        public String ScanConditionItemType_LastPriceOfInstrument { get; set; }
        /// <summary>
        /// Gets or sets the ScanConditionItemType_MarketData.
        /// </summary>
        [DataMember]
        public String ScanConditionItemType_MarketData { get; set; }
        /// <summary>
        /// Gets or sets the ScanConditionItemType_NetChange.
        /// </summary>
        [DataMember]
        public String ScanConditionItemType_NetChange { get; set; }
        /// <summary>
        /// Gets or sets the ScanConditionItemType_NetChangeMaxDown.
        /// </summary>
        [DataMember]
        public String ScanConditionItemType_NetChangeMaxDown { get; set; }
        /// <summary>
        /// Gets or sets the ScanConditionItemType_NetChangeMaxUp.
        /// </summary>
        [DataMember]
        public String ScanConditionItemType_NetChangeMaxUp { get; set; }
        /// <summary>
        /// Gets or sets the ScanConditionItemType_NewDailyHigh.
        /// </summary>
        [DataMember]
        public String ScanConditionItemType_NewDailyHigh { get; set; }
        /// <summary>
        /// Gets or sets the ScanConditionItemType_NewDailyLow.
        /// </summary>
        [DataMember]
        public String ScanConditionItemType_NewDailyLow { get; set; }
        /// <summary>
        /// Gets or sets the ScanConditionItemType_NumericValue.
        /// </summary>
        [DataMember]
        public String ScanConditionItemType_NumericValue { get; set; }
        /// <summary>
        /// Gets or sets the ServerCalculationMode_Currency.
        /// </summary>
        [DataMember]
        public String ServerCalculationMode_Currency { get; set; }
        /// <summary>
        /// Gets or sets the ServerCalculationMode_Price.
        /// </summary>
        [DataMember]
        public String ServerCalculationMode_Price { get; set; }
        /// <summary>
        /// Gets or sets the ServerCalculationMode_Ticks.
        /// </summary>
        [DataMember]
        public String ServerCalculationMode_Ticks { get; set; }
        /// <summary>
        /// Gets or sets the SetOrderQuantity_AccountSize.
        /// </summary>
        [DataMember]
        public String SetOrderQuantity_AccountSize { get; set; }
        /// <summary>
        /// Gets or sets the SetOrderQuantity_DefaultQuantity.
        /// </summary>
        [DataMember]
        public String SetOrderQuantity_DefaultQuantity { get; set; }
        /// <summary>
        /// Gets or sets the SetOrderQuantity_Strategy.
        /// </summary>
        [DataMember]
        public String SetOrderQuantity_Strategy { get; set; }
        /// <summary>
        /// Gets or sets the ShareScreenshotType_Chart.
        /// </summary>
        [DataMember]
        public String ShareScreenshotType_Chart { get; set; }
        /// <summary>
        /// Gets or sets the ShareScreenshotType_Grid.
        /// </summary>
        [DataMember]
        public String ShareScreenshotType_Grid { get; set; }
        /// <summary>
        /// Gets or sets the ShareScreenshotType_None.
        /// </summary>
        [DataMember]
        public String ShareScreenshotType_None { get; set; }
        /// <summary>
        /// Gets or sets the ShareScreenshotType_Tab.
        /// </summary>
        [DataMember]
        public String ShareScreenshotType_Tab { get; set; }
        /// <summary>
        /// Gets or sets the ShareScreenshotType_Window.
        /// </summary>
        [DataMember]
        public String ShareScreenshotType_Window { get; set; }
        /// <summary>
        /// Gets or sets the Source_Chart.
        /// </summary>
        [DataMember]
        public String Source_Chart { get; set; }
        /// <summary>
        /// Gets or sets the Source_HotListAnalyzer.
        /// </summary>
        [DataMember]
        public String Source_HotListAnalyzer { get; set; }
        /// <summary>
        /// Gets or sets the Source_MarketAnalyzer.
        /// </summary>
        [DataMember]
        public String Source_MarketAnalyzer { get; set; }
        /// <summary>
        /// Gets or sets the Source_News.
        /// </summary>
        [DataMember]
        public String Source_News { get; set; }
        /// <summary>
        /// Gets or sets the Source_NinjaScript.
        /// </summary>
        [DataMember]
        public String Source_NinjaScript { get; set; }
        /// <summary>
        /// Gets or sets the StartBehavior_AdoptAccountPosition.
        /// </summary>
        [DataMember]
        public String StartBehavior_AdoptAccountPosition { get; set; }
        /// <summary>
        /// Gets or sets the StartBehavior_ImmediatelySubmit.
        /// </summary>
        [DataMember]
        public String StartBehavior_ImmediatelySubmit { get; set; }
        /// <summary>
        /// Gets or sets the StartBehavior_ImmediatelySubmitSynchronizeAccount.
        /// </summary>
        [DataMember]
        public String StartBehavior_ImmediatelySubmitSynchronizeAccount { get; set; }
        /// <summary>
        /// Gets or sets the StartBehavior_WaitUntilFlat.
        /// </summary>
        [DataMember]
        public String StartBehavior_WaitUntilFlat { get; set; }
        /// <summary>
        /// Gets or sets the StartBehavior_WaitUntilFlatSynchronizeAccount.
        /// </summary>
        [DataMember]
        public String StartBehavior_WaitUntilFlatSynchronizeAccount { get; set; }
        /// <summary>
        /// Gets or sets the State_Active.
        /// </summary>
        [DataMember]
        public String State_Active { get; set; }
        /// <summary>
        /// Gets or sets the State_Configure.
        /// </summary>
        [DataMember]
        public String State_Configure { get; set; }
        /// <summary>
        /// Gets or sets the State_Historical.
        /// </summary>
        [DataMember]
        public String State_Historical { get; set; }
        /// <summary>
        /// Gets or sets the State_Realtime.
        /// </summary>
        [DataMember]
        public String State_Realtime { get; set; }
        /// <summary>
        /// Gets or sets the State_SetDefaults.
        /// </summary>
        [DataMember]
        public String State_SetDefaults { get; set; }
        /// <summary>
        /// Gets or sets the State_Start.
        /// </summary>
        [DataMember]
        public String State_Start { get; set; }
        /// <summary>
        /// Gets or sets the State_Terminated.
        /// </summary>
        [DataMember]
        public String State_Terminated { get; set; }
        /// <summary>
        /// Gets or sets the State_Transition.
        /// </summary>
        [DataMember]
        public String State_Transition { get; set; }
        /// <summary>
        /// Gets or sets the State_Undefined.
        /// </summary>
        [DataMember]
        public String State_Undefined { get; set; }
        /// <summary>
        /// Gets or sets the StopTargetHandling_ByStrategyPosition.
        /// </summary>
        [DataMember]
        public String StopTargetHandling_ByStrategyPosition { get; set; }
        /// <summary>
        /// Gets or sets the StopTargetHandling_PerEntryExecution.
        /// </summary>
        [DataMember]
        public String StopTargetHandling_PerEntryExecution { get; set; }
        /// <summary>
        /// Gets or sets the SupportedLanguage_ChineseSimplified.
        /// </summary>
        [DataMember]
        public String SupportedLanguage_ChineseSimplified { get; set; }
        /// <summary>
        /// Gets or sets the SupportedLanguage_English.
        /// </summary>
        [DataMember]
        public String SupportedLanguage_English { get; set; }
        /// <summary>
        /// Gets or sets the SupportedLanguage_French.
        /// </summary>
        [DataMember]
        public String SupportedLanguage_French { get; set; }
        /// <summary>
        /// Gets or sets the SupportedLanguage_German.
        /// </summary>
        [DataMember]
        public String SupportedLanguage_German { get; set; }
        /// <summary>
        /// Gets or sets the SupportedLanguage_Italian.
        /// </summary>
        [DataMember]
        public String SupportedLanguage_Italian { get; set; }
        /// <summary>
        /// Gets or sets the SupportedLanguage_Korean.
        /// </summary>
        [DataMember]
        public String SupportedLanguage_Korean { get; set; }
        /// <summary>
        /// Gets or sets the SupportedLanguage_Portuguese.
        /// </summary>
        [DataMember]
        public String SupportedLanguage_Portuguese { get; set; }
        /// <summary>
        /// Gets or sets the SupportedLanguage_Russian.
        /// </summary>
        [DataMember]
        public String SupportedLanguage_Russian { get; set; }
        /// <summary>
        /// Gets or sets the SupportedLanguage_Spanish.
        /// </summary>
        [DataMember]
        public String SupportedLanguage_Spanish { get; set; }
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
        /// Gets or sets the TimeInForce_Day.
        /// </summary>
        [DataMember]
        public String TimeInForce_Day { get; set; }
        /// <summary>
        /// Gets or sets the TimeInForce_Gtc.
        /// </summary>
        [DataMember]
        public String TimeInForce_Gtc { get; set; }
        /// <summary>
        /// Gets or sets the TimeInForce_Gtd.
        /// </summary>
        [DataMember]
        public String TimeInForce_Gtd { get; set; }
        /// <summary>
        /// Gets or sets the TimeInForce_Ioc.
        /// </summary>
        [DataMember]
        public String TimeInForce_Ioc { get; set; }
        /// <summary>
        /// Gets or sets the TimeInForce_Opg.
        /// </summary>
        [DataMember]
        public String TimeInForce_Opg { get; set; }
        /// <summary>
        /// Gets or sets the TraceLevels_Alerts.
        /// </summary>
        [DataMember]
        public String TraceLevels_Alerts { get; set; }
        /// <summary>
        /// Gets or sets the TraceLevels_All.
        /// </summary>
        [DataMember]
        public String TraceLevels_All { get; set; }
        /// <summary>
        /// Gets or sets the TraceLevels_Bars.
        /// </summary>
        [DataMember]
        public String TraceLevels_Bars { get; set; }
        /// <summary>
        /// Gets or sets the TraceLevels_Connect.
        /// </summary>
        [DataMember]
        public String TraceLevels_Connect { get; set; }
        /// <summary>
        /// Gets or sets the TraceLevels_Database.
        /// </summary>
        [DataMember]
        public String TraceLevels_Database { get; set; }
        /// <summary>
        /// Gets or sets the TraceLevels_FundamentalData.
        /// </summary>
        [DataMember]
        public String TraceLevels_FundamentalData { get; set; }
        /// <summary>
        /// Gets or sets the TraceLevels_Gui.
        /// </summary>
        [DataMember]
        public String TraceLevels_Gui { get; set; }
        /// <summary>
        /// Gets or sets the TraceLevels_Hotlists.
        /// </summary>
        [DataMember]
        public String TraceLevels_Hotlists { get; set; }
        /// <summary>
        /// Gets or sets the TraceLevels_Indicator.
        /// </summary>
        [DataMember]
        public String TraceLevels_Indicator { get; set; }
        /// <summary>
        /// Gets or sets the TraceLevels_MarketData.
        /// </summary>
        [DataMember]
        public String TraceLevels_MarketData { get; set; }
        /// <summary>
        /// Gets or sets the TraceLevels_MarketDepth.
        /// </summary>
        [DataMember]
        public String TraceLevels_MarketDepth { get; set; }
        /// <summary>
        /// Gets or sets the TraceLevels_Native.
        /// </summary>
        [DataMember]
        public String TraceLevels_Native { get; set; }
        /// <summary>
        /// Gets or sets the TraceLevels_News.
        /// </summary>
        [DataMember]
        public String TraceLevels_News { get; set; }
        /// <summary>
        /// Gets or sets the TraceLevels_None.
        /// </summary>
        [DataMember]
        public String TraceLevels_None { get; set; }
        /// <summary>
        /// Gets or sets the TraceLevels_Order.
        /// </summary>
        [DataMember]
        public String TraceLevels_Order { get; set; }
        /// <summary>
        /// Gets or sets the TraceLevels_ResolveInstrument.
        /// </summary>
        [DataMember]
        public String TraceLevels_ResolveInstrument { get; set; }
        /// <summary>
        /// Gets or sets the TraceLevels_Server.
        /// </summary>
        [DataMember]
        public String TraceLevels_Server { get; set; }
        /// <summary>
        /// Gets or sets the TraceLevels_Strategy.
        /// </summary>
        [DataMember]
        public String TraceLevels_Strategy { get; set; }
        /// <summary>
        /// Gets or sets the TraceLevels_Strict.
        /// </summary>
        [DataMember]
        public String TraceLevels_Strict { get; set; }
        /// <summary>
        /// Gets or sets the TraceLevels_Test.
        /// </summary>
        [DataMember]
        public String TraceLevels_Test { get; set; }
        /// <summary>
        /// Gets or sets the TraceLevels_Timer.
        /// </summary>
        [DataMember]
        public String TraceLevels_Timer { get; set; }
        /// <summary>
        /// Gets or sets the TradingHoursBreakLineVisible_AllSessions.
        /// </summary>
        [DataMember]
        public String TradingHoursBreakLineVisible_AllSessions { get; set; }
        /// <summary>
        /// Gets or sets the TradingHoursBreakLineVisible_EodOnly.
        /// </summary>
        [DataMember]
        public String TradingHoursBreakLineVisible_EodOnly { get; set; }
        /// <summary>
        /// Gets or sets the TradingHoursBreakLineVisible_Off.
        /// </summary>
        [DataMember]
        public String TradingHoursBreakLineVisible_Off { get; set; }
        /// <summary>
        /// Gets or sets the TradovateAccountType_Live.
        /// </summary>
        [DataMember]
        public String TradovateAccountType_Live { get; set; }
        /// <summary>
        /// Gets or sets the TradovateAccountType_Simulation.
        /// </summary>
        [DataMember]
        public String TradovateAccountType_Simulation { get; set; }
        /// <summary>
        /// Gets or sets the TSOrderHandling_SubmitAndForget.
        /// </summary>
        [DataMember]
        public String TSOrderHandling_SubmitAndForget { get; set; }
        /// <summary>
        /// Gets or sets the TSOrderHandling_SubmitAsIs.
        /// </summary>
        [DataMember]
        public String TSOrderHandling_SubmitAsIs { get; set; }
        /// <summary>
        /// Gets or sets the TSOrderHandling_SubmitMarketOrder.
        /// </summary>
        [DataMember]
        public String TSOrderHandling_SubmitMarketOrder { get; set; }
        /// <summary>
        /// Gets or sets the TSStopOrderHandling_Convert2StopLimit.
        /// </summary>
        [DataMember]
        public String TSStopOrderHandling_Convert2StopLimit { get; set; }
        /// <summary>
        /// Gets or sets the TSStopOrderHandling_SubmitAsIs.
        /// </summary>
        [DataMember]
        public String TSStopOrderHandling_SubmitAsIs { get; set; }
        /// <summary>
        /// Gets or sets the TSStopOrderHandling_SubmitAsSimStop.
        /// </summary>
        [DataMember]
        public String TSStopOrderHandling_SubmitAsSimStop { get; set; }
        /// <summary>
        /// Gets or sets the UserSymbologySetting_Abbreviation.
        /// </summary>
        [DataMember]
        public String UserSymbologySetting_Abbreviation { get; set; }
        /// <summary>
        /// Gets or sets the UserSymbologySetting_Exchange.
        /// </summary>
        [DataMember]
        public String UserSymbologySetting_Exchange { get; set; }
        /// <summary>
        /// Gets or sets the UserSymbologySetting_Numeric.
        /// </summary>
        [DataMember]
        public String UserSymbologySetting_Numeric { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartStyleType_BidAsk.
        /// </summary>
        [DataMember]
        public String VolumetricChartStyleType_BidAsk { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartStyleType_Delta.
        /// </summary>
        [DataMember]
        public String VolumetricChartStyleType_Delta { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartStyleType_Volume.
        /// </summary>
        [DataMember]
        public String VolumetricChartStyleType_Volume { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricDeltaType_BidAsk.
        /// </summary>
        [DataMember]
        public String VolumetricDeltaType_BidAsk { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricDeltaType_UpDownTick.
        /// </summary>
        [DataMember]
        public String VolumetricDeltaType_UpDownTick { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricImbalanceMode_Diagonal.
        /// </summary>
        [DataMember]
        public String VolumetricImbalanceMode_Diagonal { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricImbalanceMode_Horizontal.
        /// </summary>
        [DataMember]
        public String VolumetricImbalanceMode_Horizontal { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
