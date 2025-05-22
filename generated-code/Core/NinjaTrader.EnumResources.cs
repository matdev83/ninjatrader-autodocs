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
        public System.Resources.ResourceManager ResourceManager { get; set; }
        /// <summary>
        /// Gets or sets the Culture.
        /// </summary>
        [DataMember]
        public System.Globalization.CultureInfo Culture { get; set; }
        /// <summary>
        /// Gets or sets the AccountItem_BuyingPower.
        /// </summary>
        [DataMember]
        public string AccountItem_BuyingPower { get; set; }
        /// <summary>
        /// Gets or sets the AccountItem_CashValue.
        /// </summary>
        [DataMember]
        public string AccountItem_CashValue { get; set; }
        /// <summary>
        /// Gets or sets the AccountItem_Commission.
        /// </summary>
        [DataMember]
        public string AccountItem_Commission { get; set; }
        /// <summary>
        /// Gets or sets the AccountItem_ExcessInitialMargin.
        /// </summary>
        [DataMember]
        public string AccountItem_ExcessInitialMargin { get; set; }
        /// <summary>
        /// Gets or sets the AccountItem_ExcessIntradayMargin.
        /// </summary>
        [DataMember]
        public string AccountItem_ExcessIntradayMargin { get; set; }
        /// <summary>
        /// Gets or sets the AccountItem_ExcessMaintenanceMargin.
        /// </summary>
        [DataMember]
        public string AccountItem_ExcessMaintenanceMargin { get; set; }
        /// <summary>
        /// Gets or sets the AccountItem_ExcessPositionMargin.
        /// </summary>
        [DataMember]
        public string AccountItem_ExcessPositionMargin { get; set; }
        /// <summary>
        /// Gets or sets the AccountItem_Fee.
        /// </summary>
        [DataMember]
        public string AccountItem_Fee { get; set; }
        /// <summary>
        /// Gets or sets the AccountItem_GrossRealizedProfitLoss.
        /// </summary>
        [DataMember]
        public string AccountItem_GrossRealizedProfitLoss { get; set; }
        /// <summary>
        /// Gets or sets the AccountItem_InitialMargin.
        /// </summary>
        [DataMember]
        public string AccountItem_InitialMargin { get; set; }
        /// <summary>
        /// Gets or sets the AccountItem_IntradayMargin.
        /// </summary>
        [DataMember]
        public string AccountItem_IntradayMargin { get; set; }
        /// <summary>
        /// Gets or sets the AccountItem_LongOptionValue.
        /// </summary>
        [DataMember]
        public string AccountItem_LongOptionValue { get; set; }
        /// <summary>
        /// Gets or sets the AccountItem_LongStockValue.
        /// </summary>
        [DataMember]
        public string AccountItem_LongStockValue { get; set; }
        /// <summary>
        /// Gets or sets the AccountItem_LookAheadMaintenanceMargin.
        /// </summary>
        [DataMember]
        public string AccountItem_LookAheadMaintenanceMargin { get; set; }
        /// <summary>
        /// Gets or sets the AccountItem_MaintenanceMargin.
        /// </summary>
        [DataMember]
        public string AccountItem_MaintenanceMargin { get; set; }
        /// <summary>
        /// Gets or sets the AccountItem_NetLiquidation.
        /// </summary>
        [DataMember]
        public string AccountItem_NetLiquidation { get; set; }
        /// <summary>
        /// Gets or sets the AccountItem_NetLiquidationByCurrency.
        /// </summary>
        [DataMember]
        public string AccountItem_NetLiquidationByCurrency { get; set; }
        /// <summary>
        /// Gets or sets the AccountItem_PositionMargin.
        /// </summary>
        [DataMember]
        public string AccountItem_PositionMargin { get; set; }
        /// <summary>
        /// Gets or sets the AccountItem_RealizedProfitLoss.
        /// </summary>
        [DataMember]
        public string AccountItem_RealizedProfitLoss { get; set; }
        /// <summary>
        /// Gets or sets the AccountItem_ShortOptionValue.
        /// </summary>
        [DataMember]
        public string AccountItem_ShortOptionValue { get; set; }
        /// <summary>
        /// Gets or sets the AccountItem_ShortStockValue.
        /// </summary>
        [DataMember]
        public string AccountItem_ShortStockValue { get; set; }
        /// <summary>
        /// Gets or sets the AccountItem_SodCashValue.
        /// </summary>
        [DataMember]
        public string AccountItem_SodCashValue { get; set; }
        /// <summary>
        /// Gets or sets the AccountItem_SodLiquidatingValue.
        /// </summary>
        [DataMember]
        public string AccountItem_SodLiquidatingValue { get; set; }
        /// <summary>
        /// Gets or sets the AccountItem_TotalCashBalance.
        /// </summary>
        [DataMember]
        public string AccountItem_TotalCashBalance { get; set; }
        /// <summary>
        /// Gets or sets the AccountItem_UnrealizedProfitLoss.
        /// </summary>
        [DataMember]
        public string AccountItem_UnrealizedProfitLoss { get; set; }
        /// <summary>
        /// Gets or sets the AccountStatus_Disabled.
        /// </summary>
        [DataMember]
        public string AccountStatus_Disabled { get; set; }
        /// <summary>
        /// Gets or sets the AccountStatus_Enabled.
        /// </summary>
        [DataMember]
        public string AccountStatus_Enabled { get; set; }
        /// <summary>
        /// Gets or sets the AccountStatus_Excluded.
        /// </summary>
        [DataMember]
        public string AccountStatus_Excluded { get; set; }
        /// <summary>
        /// Gets or sets the AccountStatus_LiquidationOnly.
        /// </summary>
        [DataMember]
        public string AccountStatus_LiquidationOnly { get; set; }
        /// <summary>
        /// Gets or sets the AlertActionType_PlaySound.
        /// </summary>
        [DataMember]
        public string AlertActionType_PlaySound { get; set; }
        /// <summary>
        /// Gets or sets the AlertActionType_Share.
        /// </summary>
        [DataMember]
        public string AlertActionType_Share { get; set; }
        /// <summary>
        /// Gets or sets the AlertActionType_ShowMessage.
        /// </summary>
        [DataMember]
        public string AlertActionType_ShowMessage { get; set; }
        /// <summary>
        /// Gets or sets the AlertActionType_SubmitOrder.
        /// </summary>
        [DataMember]
        public string AlertActionType_SubmitOrder { get; set; }
        /// <summary>
        /// Gets or sets the AlertConditionOperator_All.
        /// </summary>
        [DataMember]
        public string AlertConditionOperator_All { get; set; }
        /// <summary>
        /// Gets or sets the AlertConditionOperator_Any.
        /// </summary>
        [DataMember]
        public string AlertConditionOperator_Any { get; set; }
        /// <summary>
        /// Gets or sets the AlertRearmType_Never.
        /// </summary>
        [DataMember]
        public string AlertRearmType_Never { get; set; }
        /// <summary>
        /// Gets or sets the AlertRearmType_OnBarClose.
        /// </summary>
        [DataMember]
        public string AlertRearmType_OnBarClose { get; set; }
        /// <summary>
        /// Gets or sets the AlertRearmType_OnConditionReversed.
        /// </summary>
        [DataMember]
        public string AlertRearmType_OnConditionReversed { get; set; }
        /// <summary>
        /// Gets or sets the AlertRearmType_OnConnect.
        /// </summary>
        [DataMember]
        public string AlertRearmType_OnConnect { get; set; }
        /// <summary>
        /// Gets or sets the AlertRearmType_OnTimer.
        /// </summary>
        [DataMember]
        public string AlertRearmType_OnTimer { get; set; }
        /// <summary>
        /// Gets or sets the AlertRearmType_RearmAllAlerts.
        /// </summary>
        [DataMember]
        public string AlertRearmType_RearmAllAlerts { get; set; }
        /// <summary>
        /// Gets or sets the AlertRearmType_RemoveAlert.
        /// </summary>
        [DataMember]
        public string AlertRearmType_RemoveAlert { get; set; }
        /// <summary>
        /// Gets or sets the ApplicationType_BP.
        /// </summary>
        [DataMember]
        public string ApplicationType_BP { get; set; }
        /// <summary>
        /// Gets or sets the ApplicationType_Desktop.
        /// </summary>
        [DataMember]
        public string ApplicationType_Desktop { get; set; }
        /// <summary>
        /// Gets or sets the ApplicationType_DS.
        /// </summary>
        [DataMember]
        public string ApplicationType_DS { get; set; }
        /// <summary>
        /// Gets or sets the ApplicationType_GW.
        /// </summary>
        [DataMember]
        public string ApplicationType_GW { get; set; }
        /// <summary>
        /// Gets or sets the ApplicationType_HDSIS.
        /// </summary>
        [DataMember]
        public string ApplicationType_HDSIS { get; set; }
        /// <summary>
        /// Gets or sets the AtmStrategySelectionMode_DisplaySelectedAtmStrategyOnly.
        /// </summary>
        [DataMember]
        public string AtmStrategySelectionMode_DisplaySelectedAtmStrategyOnly { get; set; }
        /// <summary>
        /// Gets or sets the AtmStrategySelectionMode_KeepSelectedAtmStrategyTemplateOnOrderSubmission.
        /// </summary>
        [DataMember]
        public string AtmStrategySelectionMode_KeepSelectedAtmStrategyTemplateOnOrderSubmission { get; set; }
        /// <summary>
        /// Gets or sets the AtmStrategySelectionMode_SelectActiveAtmStrategyOnOrderSubmission.
        /// </summary>
        [DataMember]
        public string AtmStrategySelectionMode_SelectActiveAtmStrategyOnOrderSubmission { get; set; }
        /// <summary>
        /// Gets or sets the BackupReminderInterval_Day.
        /// </summary>
        [DataMember]
        public string BackupReminderInterval_Day { get; set; }
        /// <summary>
        /// Gets or sets the BackupReminderInterval_FirstOfMonth.
        /// </summary>
        [DataMember]
        public string BackupReminderInterval_FirstOfMonth { get; set; }
        /// <summary>
        /// Gets or sets the BackupReminderInterval_Friday.
        /// </summary>
        [DataMember]
        public string BackupReminderInterval_Friday { get; set; }
        /// <summary>
        /// Gets or sets the BackupReminderInterval_Monday.
        /// </summary>
        [DataMember]
        public string BackupReminderInterval_Monday { get; set; }
        /// <summary>
        /// Gets or sets the BackupReminderInterval_Saturday.
        /// </summary>
        [DataMember]
        public string BackupReminderInterval_Saturday { get; set; }
        /// <summary>
        /// Gets or sets the BackupReminderInterval_Sunday.
        /// </summary>
        [DataMember]
        public string BackupReminderInterval_Sunday { get; set; }
        /// <summary>
        /// Gets or sets the BackupReminderInterval_Thursday.
        /// </summary>
        [DataMember]
        public string BackupReminderInterval_Thursday { get; set; }
        /// <summary>
        /// Gets or sets the BackupReminderInterval_Tuesday.
        /// </summary>
        [DataMember]
        public string BackupReminderInterval_Tuesday { get; set; }
        /// <summary>
        /// Gets or sets the BackupReminderInterval_Wednesday.
        /// </summary>
        [DataMember]
        public string BackupReminderInterval_Wednesday { get; set; }
        /// <summary>
        /// Gets or sets the BarGraphGrowthType_Center.
        /// </summary>
        [DataMember]
        public string BarGraphGrowthType_Center { get; set; }
        /// <summary>
        /// Gets or sets the BarGraphGrowthType_LeftToRight.
        /// </summary>
        [DataMember]
        public string BarGraphGrowthType_LeftToRight { get; set; }
        /// <summary>
        /// Gets or sets the BarGraphGrowthType_RightToLeft.
        /// </summary>
        [DataMember]
        public string BarGraphGrowthType_RightToLeft { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodTypeWeb_Day.
        /// </summary>
        [DataMember]
        public string BarsPeriodTypeWeb_Day { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodTypeWeb_Minute.
        /// </summary>
        [DataMember]
        public string BarsPeriodTypeWeb_Minute { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodTypeWeb_Month.
        /// </summary>
        [DataMember]
        public string BarsPeriodTypeWeb_Month { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodTypeWeb_Range.
        /// </summary>
        [DataMember]
        public string BarsPeriodTypeWeb_Range { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodTypeWeb_Second.
        /// </summary>
        [DataMember]
        public string BarsPeriodTypeWeb_Second { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodTypeWeb_Tick.
        /// </summary>
        [DataMember]
        public string BarsPeriodTypeWeb_Tick { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodTypeWeb_Volume.
        /// </summary>
        [DataMember]
        public string BarsPeriodTypeWeb_Volume { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodTypeWeb_Week.
        /// </summary>
        [DataMember]
        public string BarsPeriodTypeWeb_Week { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodTypeWeb_Year.
        /// </summary>
        [DataMember]
        public string BarsPeriodTypeWeb_Year { get; set; }
        /// <summary>
        /// Gets or sets the Calculate_OnBarClose.
        /// </summary>
        [DataMember]
        public string Calculate_OnBarClose { get; set; }
        /// <summary>
        /// Gets or sets the Calculate_OnEachTick.
        /// </summary>
        [DataMember]
        public string Calculate_OnEachTick { get; set; }
        /// <summary>
        /// Gets or sets the Calculate_OnPriceChange.
        /// </summary>
        [DataMember]
        public string Calculate_OnPriceChange { get; set; }
        /// <summary>
        /// Gets or sets the CalculationMode_Currency.
        /// </summary>
        [DataMember]
        public string CalculationMode_Currency { get; set; }
        /// <summary>
        /// Gets or sets the CalculationMode_Percent.
        /// </summary>
        [DataMember]
        public string CalculationMode_Percent { get; set; }
        /// <summary>
        /// Gets or sets the CalculationMode_Pips.
        /// </summary>
        [DataMember]
        public string CalculationMode_Pips { get; set; }
        /// <summary>
        /// Gets or sets the CalculationMode_Price.
        /// </summary>
        [DataMember]
        public string CalculationMode_Price { get; set; }
        /// <summary>
        /// Gets or sets the CalculationMode_Ticks.
        /// </summary>
        [DataMember]
        public string CalculationMode_Ticks { get; set; }
        /// <summary>
        /// Gets or sets the Category_Atm.
        /// </summary>
        [DataMember]
        public string Category_Atm { get; set; }
        /// <summary>
        /// Gets or sets the Category_Backtest.
        /// </summary>
        [DataMember]
        public string Category_Backtest { get; set; }
        /// <summary>
        /// Gets or sets the Category_MultiObjective.
        /// </summary>
        [DataMember]
        public string Category_MultiObjective { get; set; }
        /// <summary>
        /// Gets or sets the Category_NinjaScript.
        /// </summary>
        [DataMember]
        public string Category_NinjaScript { get; set; }
        /// <summary>
        /// Gets or sets the Category_Optimize.
        /// </summary>
        [DataMember]
        public string Category_Optimize { get; set; }
        /// <summary>
        /// Gets or sets the Category_WalkForward.
        /// </summary>
        [DataMember]
        public string Category_WalkForward { get; set; }
        /// <summary>
        /// Gets or sets the Category_WalkForwardAnchored.
        /// </summary>
        [DataMember]
        public string Category_WalkForwardAnchored { get; set; }
        /// <summary>
        /// Gets or sets the ChartAlertValueType_Ask.
        /// </summary>
        [DataMember]
        public string ChartAlertValueType_Ask { get; set; }
        /// <summary>
        /// Gets or sets the ChartAlertValueType_Bid.
        /// </summary>
        [DataMember]
        public string ChartAlertValueType_Bid { get; set; }
        /// <summary>
        /// Gets or sets the ChartAlertValueType_Close.
        /// </summary>
        [DataMember]
        public string ChartAlertValueType_Close { get; set; }
        /// <summary>
        /// Gets or sets the ChartAlertValueType_High.
        /// </summary>
        [DataMember]
        public string ChartAlertValueType_High { get; set; }
        /// <summary>
        /// Gets or sets the ChartAlertValueType_Low.
        /// </summary>
        [DataMember]
        public string ChartAlertValueType_Low { get; set; }
        /// <summary>
        /// Gets or sets the ChartAlertValueType_Median.
        /// </summary>
        [DataMember]
        public string ChartAlertValueType_Median { get; set; }
        /// <summary>
        /// Gets or sets the ChartAlertValueType_Open.
        /// </summary>
        [DataMember]
        public string ChartAlertValueType_Open { get; set; }
        /// <summary>
        /// Gets or sets the ChartAlertValueType_Typical.
        /// </summary>
        [DataMember]
        public string ChartAlertValueType_Typical { get; set; }
        /// <summary>
        /// Gets or sets the ChartAlertValueType_Volume.
        /// </summary>
        [DataMember]
        public string ChartAlertValueType_Volume { get; set; }
        /// <summary>
        /// Gets or sets the ChartAlertValueType_Weighted.
        /// </summary>
        [DataMember]
        public string ChartAlertValueType_Weighted { get; set; }
        /// <summary>
        /// Gets or sets the ChartMarkerSize_ExtraLarge.
        /// </summary>
        [DataMember]
        public string ChartMarkerSize_ExtraLarge { get; set; }
        /// <summary>
        /// Gets or sets the ChartMarkerSize_ExtraSmall.
        /// </summary>
        [DataMember]
        public string ChartMarkerSize_ExtraSmall { get; set; }
        /// <summary>
        /// Gets or sets the ChartMarkerSize_Large.
        /// </summary>
        [DataMember]
        public string ChartMarkerSize_Large { get; set; }
        /// <summary>
        /// Gets or sets the ChartMarkerSize_Medium.
        /// </summary>
        [DataMember]
        public string ChartMarkerSize_Medium { get; set; }
        /// <summary>
        /// Gets or sets the ChartMarkerSize_Small.
        /// </summary>
        [DataMember]
        public string ChartMarkerSize_Small { get; set; }
        /// <summary>
        /// Gets or sets the ChartStyleType_Box.
        /// </summary>
        [DataMember]
        public string ChartStyleType_Box { get; set; }
        /// <summary>
        /// Gets or sets the ChartStyleType_CandleStick.
        /// </summary>
        [DataMember]
        public string ChartStyleType_CandleStick { get; set; }
        /// <summary>
        /// Gets or sets the ChartStyleType_EquiVolume.
        /// </summary>
        [DataMember]
        public string ChartStyleType_EquiVolume { get; set; }
        /// <summary>
        /// Gets or sets the ChartStyleType_LineOnClose.
        /// </summary>
        [DataMember]
        public string ChartStyleType_LineOnClose { get; set; }
        /// <summary>
        /// Gets or sets the ChartStyleType_Mountain.
        /// </summary>
        [DataMember]
        public string ChartStyleType_Mountain { get; set; }
        /// <summary>
        /// Gets or sets the ChartStyleType_OHLC.
        /// </summary>
        [DataMember]
        public string ChartStyleType_OHLC { get; set; }
        /// <summary>
        /// Gets or sets the ColumnType_BarGraph.
        /// </summary>
        [DataMember]
        public string ColumnType_BarGraph { get; set; }
        /// <summary>
        /// Gets or sets the ColumnType_Regular.
        /// </summary>
        [DataMember]
        public string ColumnType_Regular { get; set; }
        /// <summary>
        /// Gets or sets the Condition_CrossAbove.
        /// </summary>
        [DataMember]
        public string Condition_CrossAbove { get; set; }
        /// <summary>
        /// Gets or sets the Condition_CrossBelow.
        /// </summary>
        [DataMember]
        public string Condition_CrossBelow { get; set; }
        /// <summary>
        /// Gets or sets the Condition_CrossInside.
        /// </summary>
        [DataMember]
        public string Condition_CrossInside { get; set; }
        /// <summary>
        /// Gets or sets the Condition_CrossOutside.
        /// </summary>
        [DataMember]
        public string Condition_CrossOutside { get; set; }
        /// <summary>
        /// Gets or sets the Condition_Equals.
        /// </summary>
        [DataMember]
        public string Condition_Equals { get; set; }
        /// <summary>
        /// Gets or sets the Condition_Greater.
        /// </summary>
        [DataMember]
        public string Condition_Greater { get; set; }
        /// <summary>
        /// Gets or sets the Condition_GreaterEqual.
        /// </summary>
        [DataMember]
        public string Condition_GreaterEqual { get; set; }
        /// <summary>
        /// Gets or sets the Condition_Less.
        /// </summary>
        [DataMember]
        public string Condition_Less { get; set; }
        /// <summary>
        /// Gets or sets the Condition_LessEqual.
        /// </summary>
        [DataMember]
        public string Condition_LessEqual { get; set; }
        /// <summary>
        /// Gets or sets the Condition_NotEqual.
        /// </summary>
        [DataMember]
        public string Condition_NotEqual { get; set; }
        /// <summary>
        /// Gets or sets the ConditionOffsetType_Arithmetic.
        /// </summary>
        [DataMember]
        public string ConditionOffsetType_Arithmetic { get; set; }
        /// <summary>
        /// Gets or sets the ConditionOffsetType_Percent.
        /// </summary>
        [DataMember]
        public string ConditionOffsetType_Percent { get; set; }
        /// <summary>
        /// Gets or sets the ConditionOffsetType_Pips.
        /// </summary>
        [DataMember]
        public string ConditionOffsetType_Pips { get; set; }
        /// <summary>
        /// Gets or sets the ConditionOffsetType_Ticks.
        /// </summary>
        [DataMember]
        public string ConditionOffsetType_Ticks { get; set; }
        /// <summary>
        /// Gets or sets the ConnectionLossHandling_KeepRunning.
        /// </summary>
        [DataMember]
        public string ConnectionLossHandling_KeepRunning { get; set; }
        /// <summary>
        /// Gets or sets the ConnectionLossHandling_Recalculate.
        /// </summary>
        [DataMember]
        public string ConnectionLossHandling_Recalculate { get; set; }
        /// <summary>
        /// Gets or sets the ConnectionLossHandling_StopStrategy.
        /// </summary>
        [DataMember]
        public string ConnectionLossHandling_StopStrategy { get; set; }
        /// <summary>
        /// Gets or sets the ConnectionStatus_Connected.
        /// </summary>
        [DataMember]
        public string ConnectionStatus_Connected { get; set; }
        /// <summary>
        /// Gets or sets the ConnectionStatus_Connecting.
        /// </summary>
        [DataMember]
        public string ConnectionStatus_Connecting { get; set; }
        /// <summary>
        /// Gets or sets the ConnectionStatus_ConnectionLost.
        /// </summary>
        [DataMember]
        public string ConnectionStatus_ConnectionLost { get; set; }
        /// <summary>
        /// Gets or sets the ConnectionStatus_Disconnected.
        /// </summary>
        [DataMember]
        public string ConnectionStatus_Disconnected { get; set; }
        /// <summary>
        /// Gets or sets the ConnectionStatus_Disconnecting.
        /// </summary>
        [DataMember]
        public string ConnectionStatus_Disconnecting { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_AssetManagerInstitutionalLong.
        /// </summary>
        [DataMember]
        public string CotReportField_AssetManagerInstitutionalLong { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_AssetManagerInstitutionalNet.
        /// </summary>
        [DataMember]
        public string CotReportField_AssetManagerInstitutionalNet { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_AssetManagerInstitutionalShort.
        /// </summary>
        [DataMember]
        public string CotReportField_AssetManagerInstitutionalShort { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_AssetManagerInstitutionalSpreading.
        /// </summary>
        [DataMember]
        public string CotReportField_AssetManagerInstitutionalSpreading { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_CommercialLong.
        /// </summary>
        [DataMember]
        public string CotReportField_CommercialLong { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_CommercialNet.
        /// </summary>
        [DataMember]
        public string CotReportField_CommercialNet { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_CommercialShort.
        /// </summary>
        [DataMember]
        public string CotReportField_CommercialShort { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_DealerIntermediaryLong.
        /// </summary>
        [DataMember]
        public string CotReportField_DealerIntermediaryLong { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_DealerIntermediaryNet.
        /// </summary>
        [DataMember]
        public string CotReportField_DealerIntermediaryNet { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_DealerIntermediaryShort.
        /// </summary>
        [DataMember]
        public string CotReportField_DealerIntermediaryShort { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_DealerIntermediarySpreading.
        /// </summary>
        [DataMember]
        public string CotReportField_DealerIntermediarySpreading { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_IndexTradersLong.
        /// </summary>
        [DataMember]
        public string CotReportField_IndexTradersLong { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_IndexTradersNet.
        /// </summary>
        [DataMember]
        public string CotReportField_IndexTradersNet { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_IndexTradersShort.
        /// </summary>
        [DataMember]
        public string CotReportField_IndexTradersShort { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_LeveragedFundsLong.
        /// </summary>
        [DataMember]
        public string CotReportField_LeveragedFundsLong { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_LeveragedFundsNet.
        /// </summary>
        [DataMember]
        public string CotReportField_LeveragedFundsNet { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_LeveragedFundsShort.
        /// </summary>
        [DataMember]
        public string CotReportField_LeveragedFundsShort { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_LeveragedFundsSpreading.
        /// </summary>
        [DataMember]
        public string CotReportField_LeveragedFundsSpreading { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_ManagedMoneyLong.
        /// </summary>
        [DataMember]
        public string CotReportField_ManagedMoneyLong { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_ManagedMoneyNet.
        /// </summary>
        [DataMember]
        public string CotReportField_ManagedMoneyNet { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_ManagedMoneyShort.
        /// </summary>
        [DataMember]
        public string CotReportField_ManagedMoneyShort { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_ManagedMoneySpreading.
        /// </summary>
        [DataMember]
        public string CotReportField_ManagedMoneySpreading { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_NoncommercialLong.
        /// </summary>
        [DataMember]
        public string CotReportField_NoncommercialLong { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_NoncommercialNet.
        /// </summary>
        [DataMember]
        public string CotReportField_NoncommercialNet { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_NoncommercialShort.
        /// </summary>
        [DataMember]
        public string CotReportField_NoncommercialShort { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_NoncommercialSpreads.
        /// </summary>
        [DataMember]
        public string CotReportField_NoncommercialSpreads { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_NonreportablePositionsLong.
        /// </summary>
        [DataMember]
        public string CotReportField_NonreportablePositionsLong { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_NonreportablePositionsNet.
        /// </summary>
        [DataMember]
        public string CotReportField_NonreportablePositionsNet { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_NonreportablePositionsShort.
        /// </summary>
        [DataMember]
        public string CotReportField_NonreportablePositionsShort { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_OpenInterest.
        /// </summary>
        [DataMember]
        public string CotReportField_OpenInterest { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_OtherReportablesLong.
        /// </summary>
        [DataMember]
        public string CotReportField_OtherReportablesLong { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_OtherReportablesNet.
        /// </summary>
        [DataMember]
        public string CotReportField_OtherReportablesNet { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_OtherReportablesShort.
        /// </summary>
        [DataMember]
        public string CotReportField_OtherReportablesShort { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_OtherReportablesSpreading.
        /// </summary>
        [DataMember]
        public string CotReportField_OtherReportablesSpreading { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_PmpuLong.
        /// </summary>
        [DataMember]
        public string CotReportField_PmpuLong { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_PmpuNet.
        /// </summary>
        [DataMember]
        public string CotReportField_PmpuNet { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_PmpuShort.
        /// </summary>
        [DataMember]
        public string CotReportField_PmpuShort { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_SwapDealersLong.
        /// </summary>
        [DataMember]
        public string CotReportField_SwapDealersLong { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_SwapDealersNet.
        /// </summary>
        [DataMember]
        public string CotReportField_SwapDealersNet { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_SwapDealersShort.
        /// </summary>
        [DataMember]
        public string CotReportField_SwapDealersShort { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_SwapDealersSpreading.
        /// </summary>
        [DataMember]
        public string CotReportField_SwapDealersSpreading { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TotalLong.
        /// </summary>
        [DataMember]
        public string CotReportField_TotalLong { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TotalNet.
        /// </summary>
        [DataMember]
        public string CotReportField_TotalNet { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TotalShort.
        /// </summary>
        [DataMember]
        public string CotReportField_TotalShort { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TotalTraders.
        /// </summary>
        [DataMember]
        public string CotReportField_TotalTraders { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInAssetManagerInstitutionalLong.
        /// </summary>
        [DataMember]
        public string CotReportField_TradersInAssetManagerInstitutionalLong { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInAssetManagerInstitutionalShort.
        /// </summary>
        [DataMember]
        public string CotReportField_TradersInAssetManagerInstitutionalShort { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInAssetManagerInstitutionalSpreading.
        /// </summary>
        [DataMember]
        public string CotReportField_TradersInAssetManagerInstitutionalSpreading { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInCommercialLong.
        /// </summary>
        [DataMember]
        public string CotReportField_TradersInCommercialLong { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInCommercialShort.
        /// </summary>
        [DataMember]
        public string CotReportField_TradersInCommercialShort { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInDealerIntermediaryLong.
        /// </summary>
        [DataMember]
        public string CotReportField_TradersInDealerIntermediaryLong { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInDealerIntermediaryShort.
        /// </summary>
        [DataMember]
        public string CotReportField_TradersInDealerIntermediaryShort { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInDealerIntermediarySpreading.
        /// </summary>
        [DataMember]
        public string CotReportField_TradersInDealerIntermediarySpreading { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInIndexTradersLong.
        /// </summary>
        [DataMember]
        public string CotReportField_TradersInIndexTradersLong { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInIndexTradersShort.
        /// </summary>
        [DataMember]
        public string CotReportField_TradersInIndexTradersShort { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInLeveragedFundsLong.
        /// </summary>
        [DataMember]
        public string CotReportField_TradersInLeveragedFundsLong { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInLeveragedFundsShort.
        /// </summary>
        [DataMember]
        public string CotReportField_TradersInLeveragedFundsShort { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInLeveragedFundsSpreading.
        /// </summary>
        [DataMember]
        public string CotReportField_TradersInLeveragedFundsSpreading { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInManagedMoneyLong.
        /// </summary>
        [DataMember]
        public string CotReportField_TradersInManagedMoneyLong { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInManagedMoneyShort.
        /// </summary>
        [DataMember]
        public string CotReportField_TradersInManagedMoneyShort { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInManagedMoneySpreading.
        /// </summary>
        [DataMember]
        public string CotReportField_TradersInManagedMoneySpreading { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInNoncommercialLong.
        /// </summary>
        [DataMember]
        public string CotReportField_TradersInNoncommercialLong { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInNoncommercialShort.
        /// </summary>
        [DataMember]
        public string CotReportField_TradersInNoncommercialShort { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInNoncommercialSpreads.
        /// </summary>
        [DataMember]
        public string CotReportField_TradersInNoncommercialSpreads { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInOtherReportablesLong.
        /// </summary>
        [DataMember]
        public string CotReportField_TradersInOtherReportablesLong { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInOtherReportablesShort.
        /// </summary>
        [DataMember]
        public string CotReportField_TradersInOtherReportablesShort { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInOtherReportablesSpreading.
        /// </summary>
        [DataMember]
        public string CotReportField_TradersInOtherReportablesSpreading { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInPmpuLong.
        /// </summary>
        [DataMember]
        public string CotReportField_TradersInPmpuLong { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInPmpuShort.
        /// </summary>
        [DataMember]
        public string CotReportField_TradersInPmpuShort { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInSwapDealersLong.
        /// </summary>
        [DataMember]
        public string CotReportField_TradersInSwapDealersLong { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInSwapDealersShort.
        /// </summary>
        [DataMember]
        public string CotReportField_TradersInSwapDealersShort { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInSwapDealersSpreading.
        /// </summary>
        [DataMember]
        public string CotReportField_TradersInSwapDealersSpreading { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInTotalLong.
        /// </summary>
        [DataMember]
        public string CotReportField_TradersInTotalLong { get; set; }
        /// <summary>
        /// Gets or sets the CotReportField_TradersInTotalShort.
        /// </summary>
        [DataMember]
        public string CotReportField_TradersInTotalShort { get; set; }
        /// <summary>
        /// Gets or sets the CotReportType_CitSupplement.
        /// </summary>
        [DataMember]
        public string CotReportType_CitSupplement { get; set; }
        /// <summary>
        /// Gets or sets the CotReportType_Combined.
        /// </summary>
        [DataMember]
        public string CotReportType_Combined { get; set; }
        /// <summary>
        /// Gets or sets the CotReportType_DisaggregatedCombined.
        /// </summary>
        [DataMember]
        public string CotReportType_DisaggregatedCombined { get; set; }
        /// <summary>
        /// Gets or sets the CotReportType_DisaggregatedFutures.
        /// </summary>
        [DataMember]
        public string CotReportType_DisaggregatedFutures { get; set; }
        /// <summary>
        /// Gets or sets the CotReportType_FinancialFuturesCombined.
        /// </summary>
        [DataMember]
        public string CotReportType_FinancialFuturesCombined { get; set; }
        /// <summary>
        /// Gets or sets the CotReportType_FinancialFuturesFutures.
        /// </summary>
        [DataMember]
        public string CotReportType_FinancialFuturesFutures { get; set; }
        /// <summary>
        /// Gets or sets the CotReportType_Futures.
        /// </summary>
        [DataMember]
        public string CotReportType_Futures { get; set; }
        /// <summary>
        /// Gets or sets the Currency_AustralianDollar.
        /// </summary>
        [DataMember]
        public string Currency_AustralianDollar { get; set; }
        /// <summary>
        /// Gets or sets the Currency_BrasilianReal.
        /// </summary>
        [DataMember]
        public string Currency_BrasilianReal { get; set; }
        /// <summary>
        /// Gets or sets the Currency_BrazilianReal.
        /// </summary>
        [DataMember]
        public string Currency_BrazilianReal { get; set; }
        /// <summary>
        /// Gets or sets the Currency_BritishPound.
        /// </summary>
        [DataMember]
        public string Currency_BritishPound { get; set; }
        /// <summary>
        /// Gets or sets the Currency_CanadianDollar.
        /// </summary>
        [DataMember]
        public string Currency_CanadianDollar { get; set; }
        /// <summary>
        /// Gets or sets the Currency_ChinaYuan.
        /// </summary>
        [DataMember]
        public string Currency_ChinaYuan { get; set; }
        /// <summary>
        /// Gets or sets the Currency_CzechRepublicKoruna.
        /// </summary>
        [DataMember]
        public string Currency_CzechRepublicKoruna { get; set; }
        /// <summary>
        /// Gets or sets the Currency_DenmarkKrone.
        /// </summary>
        [DataMember]
        public string Currency_DenmarkKrone { get; set; }
        /// <summary>
        /// Gets or sets the Currency_Euro.
        /// </summary>
        [DataMember]
        public string Currency_Euro { get; set; }
        /// <summary>
        /// Gets or sets the Currency_HongKongDollar.
        /// </summary>
        [DataMember]
        public string Currency_HongKongDollar { get; set; }
        /// <summary>
        /// Gets or sets the Currency_HungaryForint.
        /// </summary>
        [DataMember]
        public string Currency_HungaryForint { get; set; }
        /// <summary>
        /// Gets or sets the Currency_IndianRupee.
        /// </summary>
        [DataMember]
        public string Currency_IndianRupee { get; set; }
        /// <summary>
        /// Gets or sets the Currency_IsraeliShekel.
        /// </summary>
        [DataMember]
        public string Currency_IsraeliShekel { get; set; }
        /// <summary>
        /// Gets or sets the Currency_JapaneseYen.
        /// </summary>
        [DataMember]
        public string Currency_JapaneseYen { get; set; }
        /// <summary>
        /// Gets or sets the Currency_KoreanWon.
        /// </summary>
        [DataMember]
        public string Currency_KoreanWon { get; set; }
        /// <summary>
        /// Gets or sets the Currency_MalaysiaRinggit.
        /// </summary>
        [DataMember]
        public string Currency_MalaysiaRinggit { get; set; }
        /// <summary>
        /// Gets or sets the Currency_MexicanPeso.
        /// </summary>
        [DataMember]
        public string Currency_MexicanPeso { get; set; }
        /// <summary>
        /// Gets or sets the Currency_NewZealandDollar.
        /// </summary>
        [DataMember]
        public string Currency_NewZealandDollar { get; set; }
        /// <summary>
        /// Gets or sets the Currency_NorwayKrone.
        /// </summary>
        [DataMember]
        public string Currency_NorwayKrone { get; set; }
        /// <summary>
        /// Gets or sets the Currency_PolandZloty.
        /// </summary>
        [DataMember]
        public string Currency_PolandZloty { get; set; }
        /// <summary>
        /// Gets or sets the Currency_RussiaRuble.
        /// </summary>
        [DataMember]
        public string Currency_RussiaRuble { get; set; }
        /// <summary>
        /// Gets or sets the Currency_SaudiRiyal.
        /// </summary>
        [DataMember]
        public string Currency_SaudiRiyal { get; set; }
        /// <summary>
        /// Gets or sets the Currency_SingaporeDollar.
        /// </summary>
        [DataMember]
        public string Currency_SingaporeDollar { get; set; }
        /// <summary>
        /// Gets or sets the Currency_SouthAfricanRand.
        /// </summary>
        [DataMember]
        public string Currency_SouthAfricanRand { get; set; }
        /// <summary>
        /// Gets or sets the Currency_SwedishKrona.
        /// </summary>
        [DataMember]
        public string Currency_SwedishKrona { get; set; }
        /// <summary>
        /// Gets or sets the Currency_SwissFranc.
        /// </summary>
        [DataMember]
        public string Currency_SwissFranc { get; set; }
        /// <summary>
        /// Gets or sets the Currency_TaiwanNewDollar.
        /// </summary>
        [DataMember]
        public string Currency_TaiwanNewDollar { get; set; }
        /// <summary>
        /// Gets or sets the Currency_ThailandBaht.
        /// </summary>
        [DataMember]
        public string Currency_ThailandBaht { get; set; }
        /// <summary>
        /// Gets or sets the Currency_TurkeyLira.
        /// </summary>
        [DataMember]
        public string Currency_TurkeyLira { get; set; }
        /// <summary>
        /// Gets or sets the Currency_UsDollar.
        /// </summary>
        [DataMember]
        public string Currency_UsDollar { get; set; }
        /// <summary>
        /// Gets or sets the DashStyleHelper_Dash.
        /// </summary>
        [DataMember]
        public string DashStyleHelper_Dash { get; set; }
        /// <summary>
        /// Gets or sets the DashStyleHelper_DashDot.
        /// </summary>
        [DataMember]
        public string DashStyleHelper_DashDot { get; set; }
        /// <summary>
        /// Gets or sets the DashStyleHelper_DashDotDot.
        /// </summary>
        [DataMember]
        public string DashStyleHelper_DashDotDot { get; set; }
        /// <summary>
        /// Gets or sets the DashStyleHelper_Dot.
        /// </summary>
        [DataMember]
        public string DashStyleHelper_Dot { get; set; }
        /// <summary>
        /// Gets or sets the DashStyleHelper_Solid.
        /// </summary>
        [DataMember]
        public string DashStyleHelper_Solid { get; set; }
        /// <summary>
        /// Gets or sets the DataType_Ask.
        /// </summary>
        [DataMember]
        public string DataType_Ask { get; set; }
        /// <summary>
        /// Gets or sets the DataType_Bid.
        /// </summary>
        [DataMember]
        public string DataType_Bid { get; set; }
        /// <summary>
        /// Gets or sets the DataType_Last.
        /// </summary>
        [DataMember]
        public string DataType_Last { get; set; }
        /// <summary>
        /// Gets or sets the DbType_MsSqlCe.
        /// </summary>
        [DataMember]
        public string DbType_MsSqlCe { get; set; }
        /// <summary>
        /// Gets or sets the DbType_MySql.
        /// </summary>
        [DataMember]
        public string DbType_MySql { get; set; }
        /// <summary>
        /// Gets or sets the DbType_SQLite.
        /// </summary>
        [DataMember]
        public string DbType_SQLite { get; set; }
        /// <summary>
        /// Gets or sets the EntryHandling_AllEntries.
        /// </summary>
        [DataMember]
        public string EntryHandling_AllEntries { get; set; }
        /// <summary>
        /// Gets or sets the EntryHandling_UniqueEntries.
        /// </summary>
        [DataMember]
        public string EntryHandling_UniqueEntries { get; set; }
        /// <summary>
        /// Gets or sets the ErrorCode_LoginExpired.
        /// </summary>
        [DataMember]
        public string ErrorCode_LoginExpired { get; set; }
        /// <summary>
        /// Gets or sets the ErrorCode_LogOnFailed.
        /// </summary>
        [DataMember]
        public string ErrorCode_LogOnFailed { get; set; }
        /// <summary>
        /// Gets or sets the ErrorCode_NoError.
        /// </summary>
        [DataMember]
        public string ErrorCode_NoError { get; set; }
        /// <summary>
        /// Gets or sets the ErrorCode_NoLiveOrdersOnSimulationLicense.
        /// </summary>
        [DataMember]
        public string ErrorCode_NoLiveOrdersOnSimulationLicense { get; set; }
        /// <summary>
        /// Gets or sets the ErrorCode_OrderRejected.
        /// </summary>
        [DataMember]
        public string ErrorCode_OrderRejected { get; set; }
        /// <summary>
        /// Gets or sets the ErrorCode_Panic.
        /// </summary>
        [DataMember]
        public string ErrorCode_Panic { get; set; }
        /// <summary>
        /// Gets or sets the ErrorCode_ReloadingData.
        /// </summary>
        [DataMember]
        public string ErrorCode_ReloadingData { get; set; }
        /// <summary>
        /// Gets or sets the ErrorCode_UnableToCancelOrder.
        /// </summary>
        [DataMember]
        public string ErrorCode_UnableToCancelOrder { get; set; }
        /// <summary>
        /// Gets or sets the ErrorCode_UnableToChangeOrder.
        /// </summary>
        [DataMember]
        public string ErrorCode_UnableToChangeOrder { get; set; }
        /// <summary>
        /// Gets or sets the ErrorCode_UnableToSubmitOrder.
        /// </summary>
        [DataMember]
        public string ErrorCode_UnableToSubmitOrder { get; set; }
        /// <summary>
        /// Gets or sets the ErrorCode_UserAbort.
        /// </summary>
        [DataMember]
        public string ErrorCode_UserAbort { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Ace.
        /// </summary>
        [DataMember]
        public string Exchange_Ace { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Aeb.
        /// </summary>
        [DataMember]
        public string Exchange_Aeb { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Aex.
        /// </summary>
        [DataMember]
        public string Exchange_Aex { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Amex.
        /// </summary>
        [DataMember]
        public string Exchange_Amex { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Arca.
        /// </summary>
        [DataMember]
        public string Exchange_Arca { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Asx.
        /// </summary>
        [DataMember]
        public string Exchange_Asx { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Belfox.
        /// </summary>
        [DataMember]
        public string Exchange_Belfox { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Bm.
        /// </summary>
        [DataMember]
        public string Exchange_Bm { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Bovespa.
        /// </summary>
        [DataMember]
        public string Exchange_Bovespa { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Box.
        /// </summary>
        [DataMember]
        public string Exchange_Box { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_BrokerTec.
        /// </summary>
        [DataMember]
        public string Exchange_BrokerTec { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Brut.
        /// </summary>
        [DataMember]
        public string Exchange_Brut { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Bse.
        /// </summary>
        [DataMember]
        public string Exchange_Bse { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_BTrade.
        /// </summary>
        [DataMember]
        public string Exchange_BTrade { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Bvme.
        /// </summary>
        [DataMember]
        public string Exchange_Bvme { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Caes.
        /// </summary>
        [DataMember]
        public string Exchange_Caes { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Cboe.
        /// </summary>
        [DataMember]
        public string Exchange_Cboe { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Cfe.
        /// </summary>
        [DataMember]
        public string Exchange_Cfe { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_ClearPort.
        /// </summary>
        [DataMember]
        public string Exchange_ClearPort { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Cme.
        /// </summary>
        [DataMember]
        public string Exchange_Cme { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Czce.
        /// </summary>
        [DataMember]
        public string Exchange_Czce { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Dce.
        /// </summary>
        [DataMember]
        public string Exchange_Dce { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Default.
        /// </summary>
        [DataMember]
        public string Exchange_Default { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_ECbot.
        /// </summary>
        [DataMember]
        public string Exchange_ECbot { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Eurex.
        /// </summary>
        [DataMember]
        public string Exchange_Eurex { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_EurexSW.
        /// </summary>
        [DataMember]
        public string Exchange_EurexSW { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_EurexUS.
        /// </summary>
        [DataMember]
        public string Exchange_EurexUS { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_FairX.
        /// </summary>
        [DataMember]
        public string Exchange_FairX { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Fta.
        /// </summary>
        [DataMember]
        public string Exchange_Fta { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Gdax.
        /// </summary>
        [DataMember]
        public string Exchange_Gdax { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Globex.
        /// </summary>
        [DataMember]
        public string Exchange_Globex { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Hkex.
        /// </summary>
        [DataMember]
        public string Exchange_Hkex { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Hkfe.
        /// </summary>
        [DataMember]
        public string Exchange_Hkfe { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_IBIdeal.
        /// </summary>
        [DataMember]
        public string Exchange_IBIdeal { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_IBIdealPro.
        /// </summary>
        [DataMember]
        public string Exchange_IBIdealPro { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_IBTmbr.
        /// </summary>
        [DataMember]
        public string Exchange_IBTmbr { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_IBVwap.
        /// </summary>
        [DataMember]
        public string Exchange_IBVwap { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Ice.
        /// </summary>
        [DataMember]
        public string Exchange_Ice { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Idem.
        /// </summary>
        [DataMember]
        public string Exchange_Idem { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Inca.
        /// </summary>
        [DataMember]
        public string Exchange_Inca { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Ipe.
        /// </summary>
        [DataMember]
        public string Exchange_Ipe { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Ise.
        /// </summary>
        [DataMember]
        public string Exchange_Ise { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Island.
        /// </summary>
        [DataMember]
        public string Exchange_Island { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Kse.
        /// </summary>
        [DataMember]
        public string Exchange_Kse { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Liffe.
        /// </summary>
        [DataMember]
        public string Exchange_Liffe { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_LiffeCommodities.
        /// </summary>
        [DataMember]
        public string Exchange_LiffeCommodities { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Lse.
        /// </summary>
        [DataMember]
        public string Exchange_Lse { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Matif.
        /// </summary>
        [DataMember]
        public string Exchange_Matif { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Me.
        /// </summary>
        [DataMember]
        public string Exchange_Me { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Meff.
        /// </summary>
        [DataMember]
        public string Exchange_Meff { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Mexi.
        /// </summary>
        [DataMember]
        public string Exchange_Mexi { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Monep.
        /// </summary>
        [DataMember]
        public string Exchange_Monep { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Nasdaq.
        /// </summary>
        [DataMember]
        public string Exchange_Nasdaq { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Nnm.
        /// </summary>
        [DataMember]
        public string Exchange_Nnm { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Nqlx.
        /// </summary>
        [DataMember]
        public string Exchange_Nqlx { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Nscm.
        /// </summary>
        [DataMember]
        public string Exchange_Nscm { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Nse.
        /// </summary>
        [DataMember]
        public string Exchange_Nse { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Nybot.
        /// </summary>
        [DataMember]
        public string Exchange_Nybot { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Nymex.
        /// </summary>
        [DataMember]
        public string Exchange_Nymex { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Nyse.
        /// </summary>
        [DataMember]
        public string Exchange_Nyse { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Oes.
        /// </summary>
        [DataMember]
        public string Exchange_Oes { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Omx.
        /// </summary>
        [DataMember]
        public string Exchange_Omx { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_One.
        /// </summary>
        [DataMember]
        public string Exchange_One { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Opra.
        /// </summary>
        [DataMember]
        public string Exchange_Opra { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Ose.
        /// </summary>
        [DataMember]
        public string Exchange_Ose { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_OtcBB.
        /// </summary>
        [DataMember]
        public string Exchange_OtcBB { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Phlx.
        /// </summary>
        [DataMember]
        public string Exchange_Phlx { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Pse.
        /// </summary>
        [DataMember]
        public string Exchange_Pse { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Redi.
        /// </summary>
        [DataMember]
        public string Exchange_Redi { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Sbf.
        /// </summary>
        [DataMember]
        public string Exchange_Sbf { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_SDot.
        /// </summary>
        [DataMember]
        public string Exchange_SDot { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Sfb.
        /// </summary>
        [DataMember]
        public string Exchange_Sfb { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Sfe.
        /// </summary>
        [DataMember]
        public string Exchange_Sfe { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Sfx.
        /// </summary>
        [DataMember]
        public string Exchange_Sfx { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Sgx.
        /// </summary>
        [DataMember]
        public string Exchange_Sgx { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Shfe.
        /// </summary>
        [DataMember]
        public string Exchange_Shfe { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Shse.
        /// </summary>
        [DataMember]
        public string Exchange_Shse { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Snfe.
        /// </summary>
        [DataMember]
        public string Exchange_Snfe { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Soes.
        /// </summary>
        [DataMember]
        public string Exchange_Soes { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Swb.
        /// </summary>
        [DataMember]
        public string Exchange_Swb { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Swx.
        /// </summary>
        [DataMember]
        public string Exchange_Swx { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Szse.
        /// </summary>
        [DataMember]
        public string Exchange_Szse { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Tadawul.
        /// </summary>
        [DataMember]
        public string Exchange_Tadawul { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Tse.
        /// </summary>
        [DataMember]
        public string Exchange_Tse { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Tsx.
        /// </summary>
        [DataMember]
        public string Exchange_Tsx { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_TsxV.
        /// </summary>
        [DataMember]
        public string Exchange_TsxV { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_US.
        /// </summary>
        [DataMember]
        public string Exchange_US { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_VirtX.
        /// </summary>
        [DataMember]
        public string Exchange_VirtX { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Vse.
        /// </summary>
        [DataMember]
        public string Exchange_Vse { get; set; }
        /// <summary>
        /// Gets or sets the Exchange_Xetra.
        /// </summary>
        [DataMember]
        public string Exchange_Xetra { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_AverageDailyVolume.
        /// </summary>
        [DataMember]
        public string FundamentalDataType_AverageDailyVolume { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_Beta.
        /// </summary>
        [DataMember]
        public string FundamentalDataType_Beta { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_CalendarYearHigh.
        /// </summary>
        [DataMember]
        public string FundamentalDataType_CalendarYearHigh { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_CalendarYearHighDate.
        /// </summary>
        [DataMember]
        public string FundamentalDataType_CalendarYearHighDate { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_CalendarYearLow.
        /// </summary>
        [DataMember]
        public string FundamentalDataType_CalendarYearLow { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_CalendarYearLowDate.
        /// </summary>
        [DataMember]
        public string FundamentalDataType_CalendarYearLowDate { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_CurrentRatio.
        /// </summary>
        [DataMember]
        public string FundamentalDataType_CurrentRatio { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_Day200MovingAverage.
        /// </summary>
        [DataMember]
        public string FundamentalDataType_Day200MovingAverage { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_Day50MovingAverage.
        /// </summary>
        [DataMember]
        public string FundamentalDataType_Day50MovingAverage { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_DividendAmount.
        /// </summary>
        [DataMember]
        public string FundamentalDataType_DividendAmount { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_DividendPayDate.
        /// </summary>
        [DataMember]
        public string FundamentalDataType_DividendPayDate { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_DividendYield.
        /// </summary>
        [DataMember]
        public string FundamentalDataType_DividendYield { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_EarningsPerShare.
        /// </summary>
        [DataMember]
        public string FundamentalDataType_EarningsPerShare { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_FiveYearsGrowthPercentage.
        /// </summary>
        [DataMember]
        public string FundamentalDataType_FiveYearsGrowthPercentage { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_High52Weeks.
        /// </summary>
        [DataMember]
        public string FundamentalDataType_High52Weeks { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_High52WeeksDate.
        /// </summary>
        [DataMember]
        public string FundamentalDataType_High52WeeksDate { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_HistoricalVolatility.
        /// </summary>
        [DataMember]
        public string FundamentalDataType_HistoricalVolatility { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_InsiderOwned.
        /// </summary>
        [DataMember]
        public string FundamentalDataType_InsiderOwned { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_Low52Weeks.
        /// </summary>
        [DataMember]
        public string FundamentalDataType_Low52Weeks { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_Low52WeeksDate.
        /// </summary>
        [DataMember]
        public string FundamentalDataType_Low52WeeksDate { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_MarketCap.
        /// </summary>
        [DataMember]
        public string FundamentalDataType_MarketCap { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_NextEarningsDate.
        /// </summary>
        [DataMember]
        public string FundamentalDataType_NextEarningsDate { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_NextYearsEarningsPerShare.
        /// </summary>
        [DataMember]
        public string FundamentalDataType_NextYearsEarningsPerShare { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_PercentHeldByInstitutions.
        /// </summary>
        [DataMember]
        public string FundamentalDataType_PercentHeldByInstitutions { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_PriceEarningsRatio.
        /// </summary>
        [DataMember]
        public string FundamentalDataType_PriceEarningsRatio { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_RevenuePerShare.
        /// </summary>
        [DataMember]
        public string FundamentalDataType_RevenuePerShare { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_SharesOutstanding.
        /// </summary>
        [DataMember]
        public string FundamentalDataType_SharesOutstanding { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_ShortInterest.
        /// </summary>
        [DataMember]
        public string FundamentalDataType_ShortInterest { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_ShortInterestRatio.
        /// </summary>
        [DataMember]
        public string FundamentalDataType_ShortInterestRatio { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataType_VWAP.
        /// </summary>
        [DataMember]
        public string FundamentalDataType_VWAP { get; set; }
        /// <summary>
        /// Gets or sets the FxcmServerConnectionType_MarketData.
        /// </summary>
        [DataMember]
        public string FxcmServerConnectionType_MarketData { get; set; }
        /// <summary>
        /// Gets or sets the FxcmServerConnectionType_Orders.
        /// </summary>
        [DataMember]
        public string FxcmServerConnectionType_Orders { get; set; }
        /// <summary>
        /// Gets or sets the FxLotSize_HundredK.
        /// </summary>
        [DataMember]
        public string FxLotSize_HundredK { get; set; }
        /// <summary>
        /// Gets or sets the FxLotSize_OneK.
        /// </summary>
        [DataMember]
        public string FxLotSize_OneK { get; set; }
        /// <summary>
        /// Gets or sets the FxLotSize_TenK.
        /// </summary>
        [DataMember]
        public string FxLotSize_TenK { get; set; }
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
        /// Gets or sets the IBConnectUsing_Gateway.
        /// </summary>
        [DataMember]
        public string IBConnectUsing_Gateway { get; set; }
        /// <summary>
        /// Gets or sets the IBConnectUsing_Tws.
        /// </summary>
        [DataMember]
        public string IBConnectUsing_Tws { get; set; }
        /// <summary>
        /// Gets or sets the IBLogLevel_Detail.
        /// </summary>
        [DataMember]
        public string IBLogLevel_Detail { get; set; }
        /// <summary>
        /// Gets or sets the IBLogLevel_Error.
        /// </summary>
        [DataMember]
        public string IBLogLevel_Error { get; set; }
        /// <summary>
        /// Gets or sets the IBLogLevel_Information.
        /// </summary>
        [DataMember]
        public string IBLogLevel_Information { get; set; }
        /// <summary>
        /// Gets or sets the IBLogLevel_System.
        /// </summary>
        [DataMember]
        public string IBLogLevel_System { get; set; }
        /// <summary>
        /// Gets or sets the IBLogLevel_Warning.
        /// </summary>
        [DataMember]
        public string IBLogLevel_Warning { get; set; }
        /// <summary>
        /// Gets or sets the InstrumentType_Cfd.
        /// </summary>
        [DataMember]
        public string InstrumentType_Cfd { get; set; }
        /// <summary>
        /// Gets or sets the InstrumentType_CryptoCurrency.
        /// </summary>
        [DataMember]
        public string InstrumentType_CryptoCurrency { get; set; }
        /// <summary>
        /// Gets or sets the InstrumentType_Forex.
        /// </summary>
        [DataMember]
        public string InstrumentType_Forex { get; set; }
        /// <summary>
        /// Gets or sets the InstrumentType_Future.
        /// </summary>
        [DataMember]
        public string InstrumentType_Future { get; set; }
        /// <summary>
        /// Gets or sets the InstrumentType_Index.
        /// </summary>
        [DataMember]
        public string InstrumentType_Index { get; set; }
        /// <summary>
        /// Gets or sets the InstrumentType_Option.
        /// </summary>
        [DataMember]
        public string InstrumentType_Option { get; set; }
        /// <summary>
        /// Gets or sets the InstrumentType_Spread.
        /// </summary>
        [DataMember]
        public string InstrumentType_Spread { get; set; }
        /// <summary>
        /// Gets or sets the InstrumentType_Stock.
        /// </summary>
        [DataMember]
        public string InstrumentType_Stock { get; set; }
        /// <summary>
        /// Gets or sets the LicenseType_FreeTrial.
        /// </summary>
        [DataMember]
        public string LicenseType_FreeTrial { get; set; }
        /// <summary>
        /// Gets or sets the LicenseType_Regular.
        /// </summary>
        [DataMember]
        public string LicenseType_Regular { get; set; }
        /// <summary>
        /// Gets or sets the LicenseType_SimulationOnly.
        /// </summary>
        [DataMember]
        public string LicenseType_SimulationOnly { get; set; }
        /// <summary>
        /// Gets or sets the LiquidationState_Disabled.
        /// </summary>
        [DataMember]
        public string LiquidationState_Disabled { get; set; }
        /// <summary>
        /// Gets or sets the LiquidationState_Enabled.
        /// </summary>
        [DataMember]
        public string LiquidationState_Enabled { get; set; }
        /// <summary>
        /// Gets or sets the LiquidationState_Excluded.
        /// </summary>
        [DataMember]
        public string LiquidationState_Excluded { get; set; }
        /// <summary>
        /// Gets or sets the LiquidationState_Fail.
        /// </summary>
        [DataMember]
        public string LiquidationState_Fail { get; set; }
        /// <summary>
        /// Gets or sets the LiquidationState_ValidationFail.
        /// </summary>
        [DataMember]
        public string LiquidationState_ValidationFail { get; set; }
        /// <summary>
        /// Gets or sets the LocalOcoCancelBehavior_CancelOtherSide.
        /// </summary>
        [DataMember]
        public string LocalOcoCancelBehavior_CancelOtherSide { get; set; }
        /// <summary>
        /// Gets or sets the LocalOcoCancelBehavior_KeepOtherSideOpen.
        /// </summary>
        [DataMember]
        public string LocalOcoCancelBehavior_KeepOtherSideOpen { get; set; }
        /// <summary>
        /// Gets or sets the LogCategories_Account.
        /// </summary>
        [DataMember]
        public string LogCategories_Account { get; set; }
        /// <summary>
        /// Gets or sets the LogCategories_Ati.
        /// </summary>
        [DataMember]
        public string LogCategories_Ati { get; set; }
        /// <summary>
        /// Gets or sets the LogCategories_Connection.
        /// </summary>
        [DataMember]
        public string LogCategories_Connection { get; set; }
        /// <summary>
        /// Gets or sets the LogCategories_DB.
        /// </summary>
        [DataMember]
        public string LogCategories_DB { get; set; }
        /// <summary>
        /// Gets or sets the LogCategories_Default.
        /// </summary>
        [DataMember]
        public string LogCategories_Default { get; set; }
        /// <summary>
        /// Gets or sets the LogCategories_Execution.
        /// </summary>
        [DataMember]
        public string LogCategories_Execution { get; set; }
        /// <summary>
        /// Gets or sets the LogCategories_Job.
        /// </summary>
        [DataMember]
        public string LogCategories_Job { get; set; }
        /// <summary>
        /// Gets or sets the LogCategories_LicenseManagement.
        /// </summary>
        [DataMember]
        public string LogCategories_LicenseManagement { get; set; }
        /// <summary>
        /// Gets or sets the LogCategories_Money.
        /// </summary>
        [DataMember]
        public string LogCategories_Money { get; set; }
        /// <summary>
        /// Gets or sets the LogCategories_NinjaScript.
        /// </summary>
        [DataMember]
        public string LogCategories_NinjaScript { get; set; }
        /// <summary>
        /// Gets or sets the LogCategories_Order.
        /// </summary>
        [DataMember]
        public string LogCategories_Order { get; set; }
        /// <summary>
        /// Gets or sets the LogCategories_Position.
        /// </summary>
        [DataMember]
        public string LogCategories_Position { get; set; }
        /// <summary>
        /// Gets or sets the LogCategories_Strategy.
        /// </summary>
        [DataMember]
        public string LogCategories_Strategy { get; set; }
        /// <summary>
        /// Gets or sets the LogCategories_System.
        /// </summary>
        [DataMember]
        public string LogCategories_System { get; set; }
        /// <summary>
        /// Gets or sets the LogCategories_User.
        /// </summary>
        [DataMember]
        public string LogCategories_User { get; set; }
        /// <summary>
        /// Gets or sets the LogLevel_Alert.
        /// </summary>
        [DataMember]
        public string LogLevel_Alert { get; set; }
        /// <summary>
        /// Gets or sets the LogLevel_Error.
        /// </summary>
        [DataMember]
        public string LogLevel_Error { get; set; }
        /// <summary>
        /// Gets or sets the LogLevel_Information.
        /// </summary>
        [DataMember]
        public string LogLevel_Information { get; set; }
        /// <summary>
        /// Gets or sets the LogLevel_Warning.
        /// </summary>
        [DataMember]
        public string LogLevel_Warning { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataScanType_AskPrice.
        /// </summary>
        [DataMember]
        public string MarketDataScanType_AskPrice { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataScanType_AskVolume.
        /// </summary>
        [DataMember]
        public string MarketDataScanType_AskVolume { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataScanType_BidPrice.
        /// </summary>
        [DataMember]
        public string MarketDataScanType_BidPrice { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataScanType_BidVolume.
        /// </summary>
        [DataMember]
        public string MarketDataScanType_BidVolume { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataScanType_DailyHighPrice.
        /// </summary>
        [DataMember]
        public string MarketDataScanType_DailyHighPrice { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataScanType_DailyLowPrice.
        /// </summary>
        [DataMember]
        public string MarketDataScanType_DailyLowPrice { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataScanType_DailyVolume.
        /// </summary>
        [DataMember]
        public string MarketDataScanType_DailyVolume { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataScanType_LastClosePrice.
        /// </summary>
        [DataMember]
        public string MarketDataScanType_LastClosePrice { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataScanType_LastPrice.
        /// </summary>
        [DataMember]
        public string MarketDataScanType_LastPrice { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataScanType_LastVolume.
        /// </summary>
        [DataMember]
        public string MarketDataScanType_LastVolume { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataScanType_OpeningPrice.
        /// </summary>
        [DataMember]
        public string MarketDataScanType_OpeningPrice { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataScanType_OpenInterest.
        /// </summary>
        [DataMember]
        public string MarketDataScanType_OpenInterest { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataScanType_SettlementPrice.
        /// </summary>
        [DataMember]
        public string MarketDataScanType_SettlementPrice { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataType_Ask.
        /// </summary>
        [DataMember]
        public string MarketDataType_Ask { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataType_Bid.
        /// </summary>
        [DataMember]
        public string MarketDataType_Bid { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataType_DailyHigh.
        /// </summary>
        [DataMember]
        public string MarketDataType_DailyHigh { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataType_DailyLow.
        /// </summary>
        [DataMember]
        public string MarketDataType_DailyLow { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataType_DailyVolume.
        /// </summary>
        [DataMember]
        public string MarketDataType_DailyVolume { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataType_Last.
        /// </summary>
        [DataMember]
        public string MarketDataType_Last { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataType_LastClose.
        /// </summary>
        [DataMember]
        public string MarketDataType_LastClose { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataType_Opening.
        /// </summary>
        [DataMember]
        public string MarketDataType_Opening { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataType_OpenInterest.
        /// </summary>
        [DataMember]
        public string MarketDataType_OpenInterest { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataType_Settlement.
        /// </summary>
        [DataMember]
        public string MarketDataType_Settlement { get; set; }
        /// <summary>
        /// Gets or sets the MarketPosition_Flat.
        /// </summary>
        [DataMember]
        public string MarketPosition_Flat { get; set; }
        /// <summary>
        /// Gets or sets the MarketPosition_Long.
        /// </summary>
        [DataMember]
        public string MarketPosition_Long { get; set; }
        /// <summary>
        /// Gets or sets the MarketPosition_Short.
        /// </summary>
        [DataMember]
        public string MarketPosition_Short { get; set; }
        /// <summary>
        /// Gets or sets the MaximumBarsLookBack_Infinite.
        /// </summary>
        [DataMember]
        public string MaximumBarsLookBack_Infinite { get; set; }
        /// <summary>
        /// Gets or sets the MaximumBarsLookBack_TwoHundredFiftySix.
        /// </summary>
        [DataMember]
        public string MaximumBarsLookBack_TwoHundredFiftySix { get; set; }
        /// <summary>
        /// Gets or sets the MergePolicy_DoNotMerge.
        /// </summary>
        [DataMember]
        public string MergePolicy_DoNotMerge { get; set; }
        /// <summary>
        /// Gets or sets the MergePolicy_MergeBackAdjusted.
        /// </summary>
        [DataMember]
        public string MergePolicy_MergeBackAdjusted { get; set; }
        /// <summary>
        /// Gets or sets the MergePolicy_MergeNonBackAdjusted.
        /// </summary>
        [DataMember]
        public string MergePolicy_MergeNonBackAdjusted { get; set; }
        /// <summary>
        /// Gets or sets the MergePolicy_UseDefault.
        /// </summary>
        [DataMember]
        public string MergePolicy_UseDefault { get; set; }
        /// <summary>
        /// Gets or sets the MergePolicy_UseGlobalSettings.
        /// </summary>
        [DataMember]
        public string MergePolicy_UseGlobalSettings { get; set; }
        /// <summary>
        /// Gets or sets the Mode_Live.
        /// </summary>
        [DataMember]
        public string Mode_Live { get; set; }
        /// <summary>
        /// Gets or sets the Mode_Simulation.
        /// </summary>
        [DataMember]
        public string Mode_Simulation { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_AfxCnf.
        /// </summary>
        [DataMember]
        public string NewsProvider_AfxCnf { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_AfxFocus.
        /// </summary>
        [DataMember]
        public string NewsProvider_AfxFocus { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_AfxUk.
        /// </summary>
        [DataMember]
        public string NewsProvider_AfxUk { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_Asia.
        /// </summary>
        [DataMember]
        public string NewsProvider_Asia { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_AssociatedPress.
        /// </summary>
        [DataMember]
        public string NewsProvider_AssociatedPress { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_BusinessWire.
        /// </summary>
        [DataMember]
        public string NewsProvider_BusinessWire { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_Canada.
        /// </summary>
        [DataMember]
        public string NewsProvider_Canada { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_Catalog.
        /// </summary>
        [DataMember]
        public string NewsProvider_Catalog { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_CbsMarketWatch.
        /// </summary>
        [DataMember]
        public string NewsProvider_CbsMarketWatch { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_CityFalcon.
        /// </summary>
        [DataMember]
        public string NewsProvider_CityFalcon { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_CMEGroup.
        /// </summary>
        [DataMember]
        public string NewsProvider_CMEGroup { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_CNBC.
        /// </summary>
        [DataMember]
        public string NewsProvider_CNBC { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_Commercial.
        /// </summary>
        [DataMember]
        public string NewsProvider_Commercial { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_Comtex.
        /// </summary>
        [DataMember]
        public string NewsProvider_Comtex { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_DailyFx.
        /// </summary>
        [DataMember]
        public string NewsProvider_DailyFx { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_Default.
        /// </summary>
        [DataMember]
        public string NewsProvider_Default { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_DowJones.
        /// </summary>
        [DataMember]
        public string NewsProvider_DowJones { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_Dtn.
        /// </summary>
        [DataMember]
        public string NewsProvider_Dtn { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_DtnNewsBreak.
        /// </summary>
        [DataMember]
        public string NewsProvider_DtnNewsBreak { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_EconomicNews.
        /// </summary>
        [DataMember]
        public string NewsProvider_EconomicNews { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_Europe.
        /// </summary>
        [DataMember]
        public string NewsProvider_Europe { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_Fastmarkets.
        /// </summary>
        [DataMember]
        public string NewsProvider_Fastmarkets { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_FirstCall.
        /// </summary>
        [DataMember]
        public string NewsProvider_FirstCall { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_FuturesWorld.
        /// </summary>
        [DataMember]
        public string NewsProvider_FuturesWorld { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_Google.
        /// </summary>
        [DataMember]
        public string NewsProvider_Google { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_InternetWire.
        /// </summary>
        [DataMember]
        public string NewsProvider_InternetWire { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_InvestingDotCom.
        /// </summary>
        [DataMember]
        public string NewsProvider_InvestingDotCom { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_JagNotes.
        /// </summary>
        [DataMember]
        public string NewsProvider_JagNotes { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_KnightRidder.
        /// </summary>
        [DataMember]
        public string NewsProvider_KnightRidder { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_M2.
        /// </summary>
        [DataMember]
        public string NewsProvider_M2 { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_MarketGuide.
        /// </summary>
        [DataMember]
        public string NewsProvider_MarketGuide { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_MarketNewsPub.
        /// </summary>
        [DataMember]
        public string NewsProvider_MarketNewsPub { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_MarketWire.
        /// </summary>
        [DataMember]
        public string NewsProvider_MarketWire { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_MidnightTrader.
        /// </summary>
        [DataMember]
        public string NewsProvider_MidnightTrader { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_PREuro.
        /// </summary>
        [DataMember]
        public string NewsProvider_PREuro { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_PrimeZone.
        /// </summary>
        [DataMember]
        public string NewsProvider_PrimeZone { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_PRNewswire.
        /// </summary>
        [DataMember]
        public string NewsProvider_PRNewswire { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_RealTimeTrader.
        /// </summary>
        [DataMember]
        public string NewsProvider_RealTimeTrader { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_Reuters.
        /// </summary>
        [DataMember]
        public string NewsProvider_Reuters { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_ReutersBasic.
        /// </summary>
        [DataMember]
        public string NewsProvider_ReutersBasic { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_ReutersPremium.
        /// </summary>
        [DataMember]
        public string NewsProvider_ReutersPremium { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_RssDailyFx.
        /// </summary>
        [DataMember]
        public string NewsProvider_RssDailyFx { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_RssEconomicNews.
        /// </summary>
        [DataMember]
        public string NewsProvider_RssEconomicNews { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_RssEconomicNewsForex.
        /// </summary>
        [DataMember]
        public string NewsProvider_RssEconomicNewsForex { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_RssGoogle.
        /// </summary>
        [DataMember]
        public string NewsProvider_RssGoogle { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_RssYahoo.
        /// </summary>
        [DataMember]
        public string NewsProvider_RssYahoo { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_RttProNews.
        /// </summary>
        [DataMember]
        public string NewsProvider_RttProNews { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_TheFlyOnTheWall.
        /// </summary>
        [DataMember]
        public string NewsProvider_TheFlyOnTheWall { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_TradovateTwitter.
        /// </summary>
        [DataMember]
        public string NewsProvider_TradovateTwitter { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_Upi.
        /// </summary>
        [DataMember]
        public string NewsProvider_Upi { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_Us.
        /// </summary>
        [DataMember]
        public string NewsProvider_Us { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_Usda.
        /// </summary>
        [DataMember]
        public string NewsProvider_Usda { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_Yahoo.
        /// </summary>
        [DataMember]
        public string NewsProvider_Yahoo { get; set; }
        /// <summary>
        /// Gets or sets the NewsProvider_ZacksTrader.
        /// </summary>
        [DataMember]
        public string NewsProvider_ZacksTrader { get; set; }
        /// <summary>
        /// Gets or sets the OhlcMode_HiLo.
        /// </summary>
        [DataMember]
        public string OhlcMode_HiLo { get; set; }
        /// <summary>
        /// Gets or sets the OhlcMode_HLC.
        /// </summary>
        [DataMember]
        public string OhlcMode_HLC { get; set; }
        /// <summary>
        /// Gets or sets the OhlcMode_OHLC.
        /// </summary>
        [DataMember]
        public string OhlcMode_OHLC { get; set; }
        /// <summary>
        /// Gets or sets the Operation_Insert.
        /// </summary>
        [DataMember]
        public string Operation_Insert { get; set; }
        /// <summary>
        /// Gets or sets the Operation_Remove.
        /// </summary>
        [DataMember]
        public string Operation_Remove { get; set; }
        /// <summary>
        /// Gets or sets the Operation_Update.
        /// </summary>
        [DataMember]
        public string Operation_Update { get; set; }
        /// <summary>
        /// Gets or sets the OptionRight_Call.
        /// </summary>
        [DataMember]
        public string OptionRight_Call { get; set; }
        /// <summary>
        /// Gets or sets the OptionRight_Put.
        /// </summary>
        [DataMember]
        public string OptionRight_Put { get; set; }
        /// <summary>
        /// Gets or sets the OptionRight_Unknown.
        /// </summary>
        [DataMember]
        public string OptionRight_Unknown { get; set; }
        /// <summary>
        /// Gets or sets the OrderAction_Buy.
        /// </summary>
        [DataMember]
        public string OrderAction_Buy { get; set; }
        /// <summary>
        /// Gets or sets the OrderAction_BuyToCover.
        /// </summary>
        [DataMember]
        public string OrderAction_BuyToCover { get; set; }
        /// <summary>
        /// Gets or sets the OrderAction_Sell.
        /// </summary>
        [DataMember]
        public string OrderAction_Sell { get; set; }
        /// <summary>
        /// Gets or sets the OrderAction_SellShort.
        /// </summary>
        [DataMember]
        public string OrderAction_SellShort { get; set; }
        /// <summary>
        /// Gets or sets the OrderFillResolution_High.
        /// </summary>
        [DataMember]
        public string OrderFillResolution_High { get; set; }
        /// <summary>
        /// Gets or sets the OrderFillResolution_Standard.
        /// </summary>
        [DataMember]
        public string OrderFillResolution_Standard { get; set; }
        /// <summary>
        /// Gets or sets the OrderState_Accepted.
        /// </summary>
        [DataMember]
        public string OrderState_Accepted { get; set; }
        /// <summary>
        /// Gets or sets the OrderState_AcceptedByRisk.
        /// </summary>
        [DataMember]
        public string OrderState_AcceptedByRisk { get; set; }
        /// <summary>
        /// Gets or sets the OrderState_Busted.
        /// </summary>
        [DataMember]
        public string OrderState_Busted { get; set; }
        /// <summary>
        /// Gets or sets the OrderState_Cancelled.
        /// </summary>
        [DataMember]
        public string OrderState_Cancelled { get; set; }
        /// <summary>
        /// Gets or sets the OrderState_CancelPending.
        /// </summary>
        [DataMember]
        public string OrderState_CancelPending { get; set; }
        /// <summary>
        /// Gets or sets the OrderState_CancelSubmitted.
        /// </summary>
        [DataMember]
        public string OrderState_CancelSubmitted { get; set; }
        /// <summary>
        /// Gets or sets the OrderState_ChangePending.
        /// </summary>
        [DataMember]
        public string OrderState_ChangePending { get; set; }
        /// <summary>
        /// Gets or sets the OrderState_ChangeSubmitted.
        /// </summary>
        [DataMember]
        public string OrderState_ChangeSubmitted { get; set; }
        /// <summary>
        /// Gets or sets the OrderState_Filled.
        /// </summary>
        [DataMember]
        public string OrderState_Filled { get; set; }
        /// <summary>
        /// Gets or sets the OrderState_Initialized.
        /// </summary>
        [DataMember]
        public string OrderState_Initialized { get; set; }
        /// <summary>
        /// Gets or sets the OrderState_PartFilled.
        /// </summary>
        [DataMember]
        public string OrderState_PartFilled { get; set; }
        /// <summary>
        /// Gets or sets the OrderState_Rejected.
        /// </summary>
        [DataMember]
        public string OrderState_Rejected { get; set; }
        /// <summary>
        /// Gets or sets the OrderState_Submitted.
        /// </summary>
        [DataMember]
        public string OrderState_Submitted { get; set; }
        /// <summary>
        /// Gets or sets the OrderState_Suspended.
        /// </summary>
        [DataMember]
        public string OrderState_Suspended { get; set; }
        /// <summary>
        /// Gets or sets the OrderState_TriggerPending.
        /// </summary>
        [DataMember]
        public string OrderState_TriggerPending { get; set; }
        /// <summary>
        /// Gets or sets the OrderState_Unknown.
        /// </summary>
        [DataMember]
        public string OrderState_Unknown { get; set; }
        /// <summary>
        /// Gets or sets the OrderState_Working.
        /// </summary>
        [DataMember]
        public string OrderState_Working { get; set; }
        /// <summary>
        /// Gets or sets the OrderType_Limit.
        /// </summary>
        [DataMember]
        public string OrderType_Limit { get; set; }
        /// <summary>
        /// Gets or sets the OrderType_Market.
        /// </summary>
        [DataMember]
        public string OrderType_Market { get; set; }
        /// <summary>
        /// Gets or sets the OrderType_MIT.
        /// </summary>
        [DataMember]
        public string OrderType_MIT { get; set; }
        /// <summary>
        /// Gets or sets the OrderType_StopLimit.
        /// </summary>
        [DataMember]
        public string OrderType_StopLimit { get; set; }
        /// <summary>
        /// Gets or sets the OrderType_StopMarket.
        /// </summary>
        [DataMember]
        public string OrderType_StopMarket { get; set; }
        /// <summary>
        /// Gets or sets the OrderType_Unknown.
        /// </summary>
        [DataMember]
        public string OrderType_Unknown { get; set; }
        /// <summary>
        /// Gets or sets the PerformanceUnit_Currency.
        /// </summary>
        [DataMember]
        public string PerformanceUnit_Currency { get; set; }
        /// <summary>
        /// Gets or sets the PerformanceUnit_Percent.
        /// </summary>
        [DataMember]
        public string PerformanceUnit_Percent { get; set; }
        /// <summary>
        /// Gets or sets the PerformanceUnit_Pips.
        /// </summary>
        [DataMember]
        public string PerformanceUnit_Pips { get; set; }
        /// <summary>
        /// Gets or sets the PerformanceUnit_Points.
        /// </summary>
        [DataMember]
        public string PerformanceUnit_Points { get; set; }
        /// <summary>
        /// Gets or sets the PerformanceUnit_Ticks.
        /// </summary>
        [DataMember]
        public string PerformanceUnit_Ticks { get; set; }
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
        /// Gets or sets the PlotStyle_Bar.
        /// </summary>
        [DataMember]
        public string PlotStyle_Bar { get; set; }
        /// <summary>
        /// Gets or sets the PlotStyle_Block.
        /// </summary>
        [DataMember]
        public string PlotStyle_Block { get; set; }
        /// <summary>
        /// Gets or sets the PlotStyle_Cross.
        /// </summary>
        [DataMember]
        public string PlotStyle_Cross { get; set; }
        /// <summary>
        /// Gets or sets the PlotStyle_Dot.
        /// </summary>
        [DataMember]
        public string PlotStyle_Dot { get; set; }
        /// <summary>
        /// Gets or sets the PlotStyle_Hash.
        /// </summary>
        [DataMember]
        public string PlotStyle_Hash { get; set; }
        /// <summary>
        /// Gets or sets the PlotStyle_HLine.
        /// </summary>
        [DataMember]
        public string PlotStyle_HLine { get; set; }
        /// <summary>
        /// Gets or sets the PlotStyle_Line.
        /// </summary>
        [DataMember]
        public string PlotStyle_Line { get; set; }
        /// <summary>
        /// Gets or sets the PlotStyle_PriceBox.
        /// </summary>
        [DataMember]
        public string PlotStyle_PriceBox { get; set; }
        /// <summary>
        /// Gets or sets the PlotStyle_Square.
        /// </summary>
        [DataMember]
        public string PlotStyle_Square { get; set; }
        /// <summary>
        /// Gets or sets the PlotStyle_TriangleDown.
        /// </summary>
        [DataMember]
        public string PlotStyle_TriangleDown { get; set; }
        /// <summary>
        /// Gets or sets the PlotStyle_TriangleLeft.
        /// </summary>
        [DataMember]
        public string PlotStyle_TriangleLeft { get; set; }
        /// <summary>
        /// Gets or sets the PlotStyle_TriangleRight.
        /// </summary>
        [DataMember]
        public string PlotStyle_TriangleRight { get; set; }
        /// <summary>
        /// Gets or sets the PlotStyle_TriangleUp.
        /// </summary>
        [DataMember]
        public string PlotStyle_TriangleUp { get; set; }
        /// <summary>
        /// Gets or sets the PointAndFigurePriceType_Close.
        /// </summary>
        [DataMember]
        public string PointAndFigurePriceType_Close { get; set; }
        /// <summary>
        /// Gets or sets the PointAndFigurePriceType_HighsAndLows.
        /// </summary>
        [DataMember]
        public string PointAndFigurePriceType_HighsAndLows { get; set; }
        /// <summary>
        /// Gets or sets the PriceType_Close.
        /// </summary>
        [DataMember]
        public string PriceType_Close { get; set; }
        /// <summary>
        /// Gets or sets the PriceType_High.
        /// </summary>
        [DataMember]
        public string PriceType_High { get; set; }
        /// <summary>
        /// Gets or sets the PriceType_Low.
        /// </summary>
        [DataMember]
        public string PriceType_Low { get; set; }
        /// <summary>
        /// Gets or sets the PriceType_Median.
        /// </summary>
        [DataMember]
        public string PriceType_Median { get; set; }
        /// <summary>
        /// Gets or sets the PriceType_Open.
        /// </summary>
        [DataMember]
        public string PriceType_Open { get; set; }
        /// <summary>
        /// Gets or sets the PriceType_Typical.
        /// </summary>
        [DataMember]
        public string PriceType_Typical { get; set; }
        /// <summary>
        /// Gets or sets the PriceType_Weighted.
        /// </summary>
        [DataMember]
        public string PriceType_Weighted { get; set; }
        /// <summary>
        /// Gets or sets the PrintTo_OutputTab1.
        /// </summary>
        [DataMember]
        public string PrintTo_OutputTab1 { get; set; }
        /// <summary>
        /// Gets or sets the PrintTo_OutputTab2.
        /// </summary>
        [DataMember]
        public string PrintTo_OutputTab2 { get; set; }
        /// <summary>
        /// Gets or sets the Priority_High.
        /// </summary>
        [DataMember]
        public string Priority_High { get; set; }
        /// <summary>
        /// Gets or sets the Priority_Low.
        /// </summary>
        [DataMember]
        public string Priority_Low { get; set; }
        /// <summary>
        /// Gets or sets the Priority_Medium.
        /// </summary>
        [DataMember]
        public string Priority_Medium { get; set; }
        /// <summary>
        /// Gets or sets the QuantityModificationForStocks_IncreaseQuantity.
        /// </summary>
        [DataMember]
        public string QuantityModificationForStocks_IncreaseQuantity { get; set; }
        /// <summary>
        /// Gets or sets the QuantityModificationForStocks_SubmitNewOrder.
        /// </summary>
        [DataMember]
        public string QuantityModificationForStocks_SubmitNewOrder { get; set; }
        /// <summary>
        /// Gets or sets the RangeType_Bars.
        /// </summary>
        [DataMember]
        public string RangeType_Bars { get; set; }
        /// <summary>
        /// Gets or sets the RangeType_CustomRange.
        /// </summary>
        [DataMember]
        public string RangeType_CustomRange { get; set; }
        /// <summary>
        /// Gets or sets the RangeType_Days.
        /// </summary>
        [DataMember]
        public string RangeType_Days { get; set; }
        /// <summary>
        /// Gets or sets the RealtimeErrorHandling_IgnoreAllErrors.
        /// </summary>
        [DataMember]
        public string RealtimeErrorHandling_IgnoreAllErrors { get; set; }
        /// <summary>
        /// Gets or sets the RealtimeErrorHandling_StopCancelClose.
        /// </summary>
        [DataMember]
        public string RealtimeErrorHandling_StopCancelClose { get; set; }
        /// <summary>
        /// Gets or sets the RealtimeErrorHandling_StopCancelCloseIgnoreRejects.
        /// </summary>
        [DataMember]
        public string RealtimeErrorHandling_StopCancelCloseIgnoreRejects { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_Apex.
        /// </summary>
        [DataMember]
        public string RithmicConnection_Apex { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_DayTradingAcademy.
        /// </summary>
        [DataMember]
        public string RithmicConnection_DayTradingAcademy { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_FundedFuturesNetwork.
        /// </summary>
        [DataMember]
        public string RithmicConnection_FundedFuturesNetwork { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_FuturesDE.
        /// </summary>
        [DataMember]
        public string RithmicConnection_FuturesDE { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_MesCapitalPaperTrading.
        /// </summary>
        [DataMember]
        public string RithmicConnection_MesCapitalPaperTrading { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_None.
        /// </summary>
        [DataMember]
        public string RithmicConnection_None { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_Rithmic01Chicago.
        /// </summary>
        [DataMember]
        public string RithmicConnection_Rithmic01Chicago { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_Rithmic01ChicagoAggregatedData.
        /// </summary>
        [DataMember]
        public string RithmicConnection_Rithmic01ChicagoAggregatedData { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_Rithmic01ChicagoMDP3.
        /// </summary>
        [DataMember]
        public string RithmicConnection_Rithmic01ChicagoMDP3 { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_Rithmic01ChicagoPaperTrading.
        /// </summary>
        [DataMember]
        public string RithmicConnection_Rithmic01ChicagoPaperTrading { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_Rithmic01ChicagoPaperTradingAggregatedData.
        /// </summary>
        [DataMember]
        public string RithmicConnection_Rithmic01ChicagoPaperTradingAggregatedData { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_Rithmic01Colocation75.
        /// </summary>
        [DataMember]
        public string RithmicConnection_Rithmic01Colocation75 { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_Rithmic01Europe.
        /// </summary>
        [DataMember]
        public string RithmicConnection_Rithmic01Europe { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_Rithmic01EuropeAggregatedData.
        /// </summary>
        [DataMember]
        public string RithmicConnection_Rithmic01EuropeAggregatedData { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_Rithmic01EuropePaperTrading.
        /// </summary>
        [DataMember]
        public string RithmicConnection_Rithmic01EuropePaperTrading { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_Rithmic01EuropePaperTradingAggregatedData.
        /// </summary>
        [DataMember]
        public string RithmicConnection_Rithmic01EuropePaperTradingAggregatedData { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_Rithmic01Singapore.
        /// </summary>
        [DataMember]
        public string RithmicConnection_Rithmic01Singapore { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_Rithmic01SingaporeAggregatedData.
        /// </summary>
        [DataMember]
        public string RithmicConnection_Rithmic01SingaporeAggregatedData { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_Rithmic01Test.
        /// </summary>
        [DataMember]
        public string RithmicConnection_Rithmic01Test { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_Rithmic01TestAggregatedData.
        /// </summary>
        [DataMember]
        public string RithmicConnection_Rithmic01TestAggregatedData { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_Rithmic01Tokyo.
        /// </summary>
        [DataMember]
        public string RithmicConnection_Rithmic01Tokyo { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_Rithmic01TokyoAggregatedData.
        /// </summary>
        [DataMember]
        public string RithmicConnection_Rithmic01TokyoAggregatedData { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_Rithmic01TokyoPaperTrading.
        /// </summary>
        [DataMember]
        public string RithmicConnection_Rithmic01TokyoPaperTrading { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_Rithmic01TokyoPaperTradingAggregatedData.
        /// </summary>
        [DataMember]
        public string RithmicConnection_Rithmic01TokyoPaperTradingAggregatedData { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_Rithmic01UsEast.
        /// </summary>
        [DataMember]
        public string RithmicConnection_Rithmic01UsEast { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_Rithmic01UsEastAggregatedData.
        /// </summary>
        [DataMember]
        public string RithmicConnection_Rithmic01UsEastAggregatedData { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_Rithmic01UsWest.
        /// </summary>
        [DataMember]
        public string RithmicConnection_Rithmic01UsWest { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_Rithmic01UsWestAggregatedData.
        /// </summary>
        [DataMember]
        public string RithmicConnection_Rithmic01UsWestAggregatedData { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_TopstepTraderPaperTrading.
        /// </summary>
        [DataMember]
        public string RithmicConnection_TopstepTraderPaperTrading { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_TradeFundrr.
        /// </summary>
        [DataMember]
        public string RithmicConnection_TradeFundrr { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection_UProfitTrader.
        /// </summary>
        [DataMember]
        public string RithmicConnection_UProfitTrader { get; set; }
        /// <summary>
        /// Gets or sets the ScaleJustification_Left.
        /// </summary>
        [DataMember]
        public string ScaleJustification_Left { get; set; }
        /// <summary>
        /// Gets or sets the ScaleJustification_Overlay.
        /// </summary>
        [DataMember]
        public string ScaleJustification_Overlay { get; set; }
        /// <summary>
        /// Gets or sets the ScaleJustification_Right.
        /// </summary>
        [DataMember]
        public string ScaleJustification_Right { get; set; }
        /// <summary>
        /// Gets or sets the ScanConditionItemType_CandleStickPattern.
        /// </summary>
        [DataMember]
        public string ScanConditionItemType_CandleStickPattern { get; set; }
        /// <summary>
        /// Gets or sets the ScanConditionItemType_Exchanges.
        /// </summary>
        [DataMember]
        public string ScanConditionItemType_Exchanges { get; set; }
        /// <summary>
        /// Gets or sets the ScanConditionItemType_FundamentalData.
        /// </summary>
        [DataMember]
        public string ScanConditionItemType_FundamentalData { get; set; }
        /// <summary>
        /// Gets or sets the ScanConditionItemType_Indicator.
        /// </summary>
        [DataMember]
        public string ScanConditionItemType_Indicator { get; set; }
        /// <summary>
        /// Gets or sets the ScanConditionItemType_LastPriceOfInstrument.
        /// </summary>
        [DataMember]
        public string ScanConditionItemType_LastPriceOfInstrument { get; set; }
        /// <summary>
        /// Gets or sets the ScanConditionItemType_MarketData.
        /// </summary>
        [DataMember]
        public string ScanConditionItemType_MarketData { get; set; }
        /// <summary>
        /// Gets or sets the ScanConditionItemType_NetChange.
        /// </summary>
        [DataMember]
        public string ScanConditionItemType_NetChange { get; set; }
        /// <summary>
        /// Gets or sets the ScanConditionItemType_NetChangeMaxDown.
        /// </summary>
        [DataMember]
        public string ScanConditionItemType_NetChangeMaxDown { get; set; }
        /// <summary>
        /// Gets or sets the ScanConditionItemType_NetChangeMaxUp.
        /// </summary>
        [DataMember]
        public string ScanConditionItemType_NetChangeMaxUp { get; set; }
        /// <summary>
        /// Gets or sets the ScanConditionItemType_NewDailyHigh.
        /// </summary>
        [DataMember]
        public string ScanConditionItemType_NewDailyHigh { get; set; }
        /// <summary>
        /// Gets or sets the ScanConditionItemType_NewDailyLow.
        /// </summary>
        [DataMember]
        public string ScanConditionItemType_NewDailyLow { get; set; }
        /// <summary>
        /// Gets or sets the ScanConditionItemType_NumericValue.
        /// </summary>
        [DataMember]
        public string ScanConditionItemType_NumericValue { get; set; }
        /// <summary>
        /// Gets or sets the ServerCalculationMode_Currency.
        /// </summary>
        [DataMember]
        public string ServerCalculationMode_Currency { get; set; }
        /// <summary>
        /// Gets or sets the ServerCalculationMode_Price.
        /// </summary>
        [DataMember]
        public string ServerCalculationMode_Price { get; set; }
        /// <summary>
        /// Gets or sets the ServerCalculationMode_Ticks.
        /// </summary>
        [DataMember]
        public string ServerCalculationMode_Ticks { get; set; }
        /// <summary>
        /// Gets or sets the SetOrderQuantity_AccountSize.
        /// </summary>
        [DataMember]
        public string SetOrderQuantity_AccountSize { get; set; }
        /// <summary>
        /// Gets or sets the SetOrderQuantity_DefaultQuantity.
        /// </summary>
        [DataMember]
        public string SetOrderQuantity_DefaultQuantity { get; set; }
        /// <summary>
        /// Gets or sets the SetOrderQuantity_Strategy.
        /// </summary>
        [DataMember]
        public string SetOrderQuantity_Strategy { get; set; }
        /// <summary>
        /// Gets or sets the ShareScreenshotType_Chart.
        /// </summary>
        [DataMember]
        public string ShareScreenshotType_Chart { get; set; }
        /// <summary>
        /// Gets or sets the ShareScreenshotType_Grid.
        /// </summary>
        [DataMember]
        public string ShareScreenshotType_Grid { get; set; }
        /// <summary>
        /// Gets or sets the ShareScreenshotType_None.
        /// </summary>
        [DataMember]
        public string ShareScreenshotType_None { get; set; }
        /// <summary>
        /// Gets or sets the ShareScreenshotType_Tab.
        /// </summary>
        [DataMember]
        public string ShareScreenshotType_Tab { get; set; }
        /// <summary>
        /// Gets or sets the ShareScreenshotType_Window.
        /// </summary>
        [DataMember]
        public string ShareScreenshotType_Window { get; set; }
        /// <summary>
        /// Gets or sets the Source_Chart.
        /// </summary>
        [DataMember]
        public string Source_Chart { get; set; }
        /// <summary>
        /// Gets or sets the Source_HotListAnalyzer.
        /// </summary>
        [DataMember]
        public string Source_HotListAnalyzer { get; set; }
        /// <summary>
        /// Gets or sets the Source_MarketAnalyzer.
        /// </summary>
        [DataMember]
        public string Source_MarketAnalyzer { get; set; }
        /// <summary>
        /// Gets or sets the Source_News.
        /// </summary>
        [DataMember]
        public string Source_News { get; set; }
        /// <summary>
        /// Gets or sets the Source_NinjaScript.
        /// </summary>
        [DataMember]
        public string Source_NinjaScript { get; set; }
        /// <summary>
        /// Gets or sets the StartBehavior_AdoptAccountPosition.
        /// </summary>
        [DataMember]
        public string StartBehavior_AdoptAccountPosition { get; set; }
        /// <summary>
        /// Gets or sets the StartBehavior_ImmediatelySubmit.
        /// </summary>
        [DataMember]
        public string StartBehavior_ImmediatelySubmit { get; set; }
        /// <summary>
        /// Gets or sets the StartBehavior_ImmediatelySubmitSynchronizeAccount.
        /// </summary>
        [DataMember]
        public string StartBehavior_ImmediatelySubmitSynchronizeAccount { get; set; }
        /// <summary>
        /// Gets or sets the StartBehavior_WaitUntilFlat.
        /// </summary>
        [DataMember]
        public string StartBehavior_WaitUntilFlat { get; set; }
        /// <summary>
        /// Gets or sets the StartBehavior_WaitUntilFlatSynchronizeAccount.
        /// </summary>
        [DataMember]
        public string StartBehavior_WaitUntilFlatSynchronizeAccount { get; set; }
        /// <summary>
        /// Gets or sets the State_Active.
        /// </summary>
        [DataMember]
        public string State_Active { get; set; }
        /// <summary>
        /// Gets or sets the State_Configure.
        /// </summary>
        [DataMember]
        public string State_Configure { get; set; }
        /// <summary>
        /// Gets or sets the State_Historical.
        /// </summary>
        [DataMember]
        public string State_Historical { get; set; }
        /// <summary>
        /// Gets or sets the State_Realtime.
        /// </summary>
        [DataMember]
        public string State_Realtime { get; set; }
        /// <summary>
        /// Gets or sets the State_SetDefaults.
        /// </summary>
        [DataMember]
        public string State_SetDefaults { get; set; }
        /// <summary>
        /// Gets or sets the State_Start.
        /// </summary>
        [DataMember]
        public string State_Start { get; set; }
        /// <summary>
        /// Gets or sets the State_Terminated.
        /// </summary>
        [DataMember]
        public string State_Terminated { get; set; }
        /// <summary>
        /// Gets or sets the State_Transition.
        /// </summary>
        [DataMember]
        public string State_Transition { get; set; }
        /// <summary>
        /// Gets or sets the State_Undefined.
        /// </summary>
        [DataMember]
        public string State_Undefined { get; set; }
        /// <summary>
        /// Gets or sets the StopTargetHandling_ByStrategyPosition.
        /// </summary>
        [DataMember]
        public string StopTargetHandling_ByStrategyPosition { get; set; }
        /// <summary>
        /// Gets or sets the StopTargetHandling_PerEntryExecution.
        /// </summary>
        [DataMember]
        public string StopTargetHandling_PerEntryExecution { get; set; }
        /// <summary>
        /// Gets or sets the SupportedLanguage_ChineseSimplified.
        /// </summary>
        [DataMember]
        public string SupportedLanguage_ChineseSimplified { get; set; }
        /// <summary>
        /// Gets or sets the SupportedLanguage_English.
        /// </summary>
        [DataMember]
        public string SupportedLanguage_English { get; set; }
        /// <summary>
        /// Gets or sets the SupportedLanguage_French.
        /// </summary>
        [DataMember]
        public string SupportedLanguage_French { get; set; }
        /// <summary>
        /// Gets or sets the SupportedLanguage_German.
        /// </summary>
        [DataMember]
        public string SupportedLanguage_German { get; set; }
        /// <summary>
        /// Gets or sets the SupportedLanguage_Italian.
        /// </summary>
        [DataMember]
        public string SupportedLanguage_Italian { get; set; }
        /// <summary>
        /// Gets or sets the SupportedLanguage_Korean.
        /// </summary>
        [DataMember]
        public string SupportedLanguage_Korean { get; set; }
        /// <summary>
        /// Gets or sets the SupportedLanguage_Portuguese.
        /// </summary>
        [DataMember]
        public string SupportedLanguage_Portuguese { get; set; }
        /// <summary>
        /// Gets or sets the SupportedLanguage_Russian.
        /// </summary>
        [DataMember]
        public string SupportedLanguage_Russian { get; set; }
        /// <summary>
        /// Gets or sets the SupportedLanguage_Spanish.
        /// </summary>
        [DataMember]
        public string SupportedLanguage_Spanish { get; set; }
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
        /// Gets or sets the TimeInForce_Day.
        /// </summary>
        [DataMember]
        public string TimeInForce_Day { get; set; }
        /// <summary>
        /// Gets or sets the TimeInForce_Gtc.
        /// </summary>
        [DataMember]
        public string TimeInForce_Gtc { get; set; }
        /// <summary>
        /// Gets or sets the TimeInForce_Gtd.
        /// </summary>
        [DataMember]
        public string TimeInForce_Gtd { get; set; }
        /// <summary>
        /// Gets or sets the TimeInForce_Ioc.
        /// </summary>
        [DataMember]
        public string TimeInForce_Ioc { get; set; }
        /// <summary>
        /// Gets or sets the TimeInForce_Opg.
        /// </summary>
        [DataMember]
        public string TimeInForce_Opg { get; set; }
        /// <summary>
        /// Gets or sets the TraceLevels_Alerts.
        /// </summary>
        [DataMember]
        public string TraceLevels_Alerts { get; set; }
        /// <summary>
        /// Gets or sets the TraceLevels_All.
        /// </summary>
        [DataMember]
        public string TraceLevels_All { get; set; }
        /// <summary>
        /// Gets or sets the TraceLevels_Bars.
        /// </summary>
        [DataMember]
        public string TraceLevels_Bars { get; set; }
        /// <summary>
        /// Gets or sets the TraceLevels_Connect.
        /// </summary>
        [DataMember]
        public string TraceLevels_Connect { get; set; }
        /// <summary>
        /// Gets or sets the TraceLevels_Database.
        /// </summary>
        [DataMember]
        public string TraceLevels_Database { get; set; }
        /// <summary>
        /// Gets or sets the TraceLevels_FundamentalData.
        /// </summary>
        [DataMember]
        public string TraceLevels_FundamentalData { get; set; }
        /// <summary>
        /// Gets or sets the TraceLevels_Gui.
        /// </summary>
        [DataMember]
        public string TraceLevels_Gui { get; set; }
        /// <summary>
        /// Gets or sets the TraceLevels_Hotlists.
        /// </summary>
        [DataMember]
        public string TraceLevels_Hotlists { get; set; }
        /// <summary>
        /// Gets or sets the TraceLevels_Indicator.
        /// </summary>
        [DataMember]
        public string TraceLevels_Indicator { get; set; }
        /// <summary>
        /// Gets or sets the TraceLevels_MarketData.
        /// </summary>
        [DataMember]
        public string TraceLevels_MarketData { get; set; }
        /// <summary>
        /// Gets or sets the TraceLevels_MarketDepth.
        /// </summary>
        [DataMember]
        public string TraceLevels_MarketDepth { get; set; }
        /// <summary>
        /// Gets or sets the TraceLevels_Native.
        /// </summary>
        [DataMember]
        public string TraceLevels_Native { get; set; }
        /// <summary>
        /// Gets or sets the TraceLevels_News.
        /// </summary>
        [DataMember]
        public string TraceLevels_News { get; set; }
        /// <summary>
        /// Gets or sets the TraceLevels_None.
        /// </summary>
        [DataMember]
        public string TraceLevels_None { get; set; }
        /// <summary>
        /// Gets or sets the TraceLevels_Order.
        /// </summary>
        [DataMember]
        public string TraceLevels_Order { get; set; }
        /// <summary>
        /// Gets or sets the TraceLevels_ResolveInstrument.
        /// </summary>
        [DataMember]
        public string TraceLevels_ResolveInstrument { get; set; }
        /// <summary>
        /// Gets or sets the TraceLevels_Server.
        /// </summary>
        [DataMember]
        public string TraceLevels_Server { get; set; }
        /// <summary>
        /// Gets or sets the TraceLevels_Strategy.
        /// </summary>
        [DataMember]
        public string TraceLevels_Strategy { get; set; }
        /// <summary>
        /// Gets or sets the TraceLevels_Strict.
        /// </summary>
        [DataMember]
        public string TraceLevels_Strict { get; set; }
        /// <summary>
        /// Gets or sets the TraceLevels_Test.
        /// </summary>
        [DataMember]
        public string TraceLevels_Test { get; set; }
        /// <summary>
        /// Gets or sets the TraceLevels_Timer.
        /// </summary>
        [DataMember]
        public string TraceLevels_Timer { get; set; }
        /// <summary>
        /// Gets or sets the TradingHoursBreakLineVisible_AllSessions.
        /// </summary>
        [DataMember]
        public string TradingHoursBreakLineVisible_AllSessions { get; set; }
        /// <summary>
        /// Gets or sets the TradingHoursBreakLineVisible_EodOnly.
        /// </summary>
        [DataMember]
        public string TradingHoursBreakLineVisible_EodOnly { get; set; }
        /// <summary>
        /// Gets or sets the TradingHoursBreakLineVisible_Off.
        /// </summary>
        [DataMember]
        public string TradingHoursBreakLineVisible_Off { get; set; }
        /// <summary>
        /// Gets or sets the TradovateAccountType_Live.
        /// </summary>
        [DataMember]
        public string TradovateAccountType_Live { get; set; }
        /// <summary>
        /// Gets or sets the TradovateAccountType_Simulation.
        /// </summary>
        [DataMember]
        public string TradovateAccountType_Simulation { get; set; }
        /// <summary>
        /// Gets or sets the TSOrderHandling_SubmitAndForget.
        /// </summary>
        [DataMember]
        public string TSOrderHandling_SubmitAndForget { get; set; }
        /// <summary>
        /// Gets or sets the TSOrderHandling_SubmitAsIs.
        /// </summary>
        [DataMember]
        public string TSOrderHandling_SubmitAsIs { get; set; }
        /// <summary>
        /// Gets or sets the TSOrderHandling_SubmitMarketOrder.
        /// </summary>
        [DataMember]
        public string TSOrderHandling_SubmitMarketOrder { get; set; }
        /// <summary>
        /// Gets or sets the TSStopOrderHandling_Convert2StopLimit.
        /// </summary>
        [DataMember]
        public string TSStopOrderHandling_Convert2StopLimit { get; set; }
        /// <summary>
        /// Gets or sets the TSStopOrderHandling_SubmitAsIs.
        /// </summary>
        [DataMember]
        public string TSStopOrderHandling_SubmitAsIs { get; set; }
        /// <summary>
        /// Gets or sets the TSStopOrderHandling_SubmitAsSimStop.
        /// </summary>
        [DataMember]
        public string TSStopOrderHandling_SubmitAsSimStop { get; set; }
        /// <summary>
        /// Gets or sets the UserSymbologySetting_Abbreviation.
        /// </summary>
        [DataMember]
        public string UserSymbologySetting_Abbreviation { get; set; }
        /// <summary>
        /// Gets or sets the UserSymbologySetting_Exchange.
        /// </summary>
        [DataMember]
        public string UserSymbologySetting_Exchange { get; set; }
        /// <summary>
        /// Gets or sets the UserSymbologySetting_Numeric.
        /// </summary>
        [DataMember]
        public string UserSymbologySetting_Numeric { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartStyleType_BidAsk.
        /// </summary>
        [DataMember]
        public string VolumetricChartStyleType_BidAsk { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartStyleType_Delta.
        /// </summary>
        [DataMember]
        public string VolumetricChartStyleType_Delta { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricChartStyleType_Volume.
        /// </summary>
        [DataMember]
        public string VolumetricChartStyleType_Volume { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricDeltaType_BidAsk.
        /// </summary>
        [DataMember]
        public string VolumetricDeltaType_BidAsk { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricDeltaType_UpDownTick.
        /// </summary>
        [DataMember]
        public string VolumetricDeltaType_UpDownTick { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricImbalanceMode_Diagonal.
        /// </summary>
        [DataMember]
        public string VolumetricImbalanceMode_Diagonal { get; set; }
        /// <summary>
        /// Gets or sets the VolumetricImbalanceMode_Horizontal.
        /// </summary>
        [DataMember]
        public string VolumetricImbalanceMode_Horizontal { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
