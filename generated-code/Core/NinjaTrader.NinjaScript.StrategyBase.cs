[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class StrategyBase : NinjaTrader.NinjaScript.NinjaScriptBase
    {
        #region Properties
        /// <summary>
        /// Gets or sets the BacktestCommissionTemplate.
        /// </summary>
        [DataMember]
        public string BacktestCommissionTemplate { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodParameter.
        /// </summary>
        [DataMember]
        public NinjaTrader.NinjaScript.Parameter BarsPeriodParameter { get; set; }
        /// <summary>
        /// Gets or sets the BarsRequiredToTrade.
        /// </summary>
        [DataMember]
        public int BarsRequiredToTrade { get; set; }
        /// <summary>
        /// Gets or sets the Category.
        /// </summary>
        [DataMember]
        public Category Category { get; set; }
        /// <summary>
        /// Gets or sets the ChartIndicators.
        /// </summary>
        [DataMember]
        public NinjaTrader.NinjaScript.IndicatorBase[] ChartIndicators { get; set; }
        /// <summary>
        /// Gets or sets the ConnectionLossHandling.
        /// </summary>
        [DataMember]
        public ConnectionLossHandling ConnectionLossHandling { get; set; }
        /// <summary>
        /// Gets or sets the DaysToLoad.
        /// </summary>
        [DataMember]
        public int DaysToLoad { get; set; }
        /// <summary>
        /// Gets or sets the DefaultName.
        /// </summary>
        [DataMember]
        public string DefaultName { get; set; }
        /// <summary>
        /// Gets or sets the DefaultQuantity.
        /// </summary>
        [DataMember]
        public int DefaultQuantity { get; set; }
        /// <summary>
        /// Gets or sets the DisconnectDelaySeconds.
        /// </summary>
        [DataMember]
        public int DisconnectDelaySeconds { get; set; }
        /// <summary>
        /// Gets or sets the DisplayName.
        /// </summary>
        [DataMember]
        public string DisplayName { get; set; }
        /// <summary>
        /// Gets or sets the DisplayParameters.
        /// </summary>
        [DataMember]
        public string DisplayParameters { get; set; }
        /// <summary>
        /// Gets or sets the EntriesPerDirection.
        /// </summary>
        [DataMember]
        public int EntriesPerDirection { get; set; }
        /// <summary>
        /// Gets or sets the EntryHandling.
        /// </summary>
        [DataMember]
        public EntryHandling EntryHandling { get; set; }
        /// <summary>
        /// Gets or sets the ExitOnSessionCloseSeconds.
        /// </summary>
        [DataMember]
        public int ExitOnSessionCloseSeconds { get; set; }
        /// <summary>
        /// Gets or sets the FillType.
        /// </summary>
        [DataMember]
        public NinjaTrader.NinjaScript.FillType FillType { get; set; }
        /// <summary>
        /// Gets or sets the IgnoreOverfill.
        /// </summary>
        [DataMember]
        public bool IgnoreOverfill { get; set; }
        /// <summary>
        /// Gets or sets the IncludeCommission.
        /// </summary>
        [DataMember]
        public bool IncludeCommission { get; set; }
        /// <summary>
        /// Gets or sets the IncludeTradeHistoryInBacktest.
        /// </summary>
        [DataMember]
        public bool IncludeTradeHistoryInBacktest { get; set; }
        /// <summary>
        /// Gets or sets the InitBarsSeriesIndex.
        /// </summary>
        [DataMember]
        public NinjaTrader.NinjaScript.Index2BarsString InitBarsSeriesIndex { get; set; }
        /// <summary>
        /// Gets or sets the InstrumentOrInstrumentList.
        /// </summary>
        [DataMember]
        public string InstrumentOrInstrumentList { get; set; }
        /// <summary>
        /// Gets or sets the IsAdoptAccountPositionAware.
        /// </summary>
        [DataMember]
        public bool IsAdoptAccountPositionAware { get; set; }
        /// <summary>
        /// Gets or sets the IsAggregated.
        /// </summary>
        [DataMember]
        public bool IsAggregated { get; set; }
        /// <summary>
        /// Gets or sets the IsExitOnSessionCloseStrategy.
        /// </summary>
        [DataMember]
        public bool IsExitOnSessionCloseStrategy { get; set; }
        /// <summary>
        /// Gets or sets the IsFillLimitOnTouch.
        /// </summary>
        [DataMember]
        public bool IsFillLimitOnTouch { get; set; }
        /// <summary>
        /// Gets or sets the IsInstantiatedOnEachOptimizationIteration.
        /// </summary>
        [DataMember]
        public bool IsInstantiatedOnEachOptimizationIteration { get; set; }
        /// <summary>
        /// Gets or sets the IsOptimizeDataSeries.
        /// </summary>
        [DataMember]
        public bool IsOptimizeDataSeries { get; set; }
        /// <summary>
        /// Gets or sets the IsStableSession.
        /// </summary>
        [DataMember]
        public bool IsStableSession { get; set; }
        /// <summary>
        /// Gets or sets the IsTerminal.
        /// </summary>
        [DataMember]
        public bool IsTerminal { get; set; }
        /// <summary>
        /// Gets or sets the IsTickReplay.
        /// </summary>
        [DataMember]
        public bool IsTickReplay { get; set; }
        /// <summary>
        /// Gets or sets the IsTradingHoursBreakLineVisible.
        /// </summary>
        [DataMember]
        public bool IsTradingHoursBreakLineVisible { get; set; }
        /// <summary>
        /// Gets or sets the IsUnmanaged.
        /// </summary>
        [DataMember]
        public bool IsUnmanaged { get; set; }
        /// <summary>
        /// Gets or sets the IsWaitUntilFlat.
        /// </summary>
        [DataMember]
        public bool IsWaitUntilFlat { get; set; }
        /// <summary>
        /// Gets or sets the NumberRestartAttempts.
        /// </summary>
        [DataMember]
        public int NumberRestartAttempts { get; set; }
        /// <summary>
        /// Gets or sets the Optimizer.
        /// </summary>
        [DataMember]
        public NinjaTrader.NinjaScript.Optimizers.Optimizer Optimizer { get; set; }
        /// <summary>
        /// Gets or sets the OptimizationFitness.
        /// </summary>
        [DataMember]
        public NinjaTrader.NinjaScript.OptimizationFitnesses.OptimizationFitness OptimizationFitness { get; set; }
        /// <summary>
        /// Gets or sets the OptimizationParameters.
        /// </summary>
        [DataMember]
        public System.Collections.ObjectModel.Collection<NinjaTrader.NinjaScript.Parameter> OptimizationParameters { get; set; }
        /// <summary>
        /// Gets or sets the OptimizationPeriod.
        /// </summary>
        [DataMember]
        public int OptimizationPeriod { get; set; }
        /// <summary>
        /// Gets or sets the OrderFillResolution.
        /// </summary>
        [DataMember]
        public OrderFillResolution OrderFillResolution { get; set; }
        /// <summary>
        /// Gets or sets the OrderFillResolutionType.
        /// </summary>
        [DataMember]
        public BarsPeriodType OrderFillResolutionType { get; set; }
        /// <summary>
        /// Gets or sets the OrderFillResolutionValue.
        /// </summary>
        [DataMember]
        public int OrderFillResolutionValue { get; set; }
        /// <summary>
        /// Gets or sets the InputsProvider.
        /// </summary>
        [DataMember]
        public NinjaTrader.NinjaScript.IStrategyInputsProvider InputsProvider { get; set; }
        /// <summary>
        /// Gets or sets the PerformanceMetrics.
        /// </summary>
        [DataMember]
        public NinjaTrader.NinjaScript.PerformanceMetricBase[] PerformanceMetrics { get; set; }
        /// <summary>
        /// Gets or sets the Position.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Position Position { get; set; }
        /// <summary>
        /// Gets or sets the PositionAccount.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Position PositionAccount { get; set; }
        /// <summary>
        /// Gets or sets the Positions.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Position[] Positions { get; set; }
        /// <summary>
        /// Gets or sets the PositionsAccount.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Position[] PositionsAccount { get; set; }
        /// <summary>
        /// Gets or sets the RealtimeErrorHandling.
        /// </summary>
        [DataMember]
        public RealtimeErrorHandling RealtimeErrorHandling { get; set; }
        /// <summary>
        /// Gets or sets the RestartsWithinMinutes.
        /// </summary>
        [DataMember]
        public int RestartsWithinMinutes { get; set; }
        /// <summary>
        /// Gets or sets the SetOrderQuantity.
        /// </summary>
        [DataMember]
        public SetOrderQuantity SetOrderQuantity { get; set; }
        /// <summary>
        /// Gets or sets the Slippage.
        /// </summary>
        [DataMember]
        public double Slippage { get; set; }
        /// <summary>
        /// Gets or sets the StartBehavior.
        /// </summary>
        [DataMember]
        public StartBehavior StartBehavior { get; set; }
        /// <summary>
        /// Gets or sets the StopTargetHandling.
        /// </summary>
        [DataMember]
        public StopTargetHandling StopTargetHandling { get; set; }
        /// <summary>
        /// Gets or sets the SupportsOptimizationGraph.
        /// </summary>
        [DataMember]
        public bool SupportsOptimizationGraph { get; set; }
        /// <summary>
        /// Gets or sets the SystemPerformance.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.SystemPerformance SystemPerformance { get; set; }
        /// <summary>
        /// Gets or sets the TimeElapsedForOptimizer.
        /// </summary>
        [DataMember]
        public System.TimeSpan TimeElapsedForOptimizer { get; set; }
        /// <summary>
        /// Gets or sets the TestPeriod.
        /// </summary>
        [DataMember]
        public int TestPeriod { get; set; }
        /// <summary>
        /// Gets or sets the TraceOrders.
        /// </summary>
        [DataMember]
        public bool TraceOrders { get; set; }
        /// <summary>
        /// Gets or sets the TradingHoursInstance.
        /// </summary>
        [DataMember]
        public NinjaTrader.Data.TradingHours TradingHoursInstance { get; set; }
        /// <summary>
        /// Gets or sets the TradingHoursSerializable.
        /// </summary>
        [DataMember]
        public string TradingHoursSerializable { get; set; }
        /// <summary>
        /// Gets or sets the GeneratedStrategyLogic.
        /// </summary>
        [DataMember]
        public NinjaTrader.NinjaScript.StrategyGenerator.GeneratedStrategyLogicBase GeneratedStrategyLogic { get; set; }
        /// <summary>
        /// Gets or sets the ValidOrderFillResolutions.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.List<BarsPeriodType> ValidOrderFillResolutions { get; set; }
        /// <summary>
        /// Gets or sets the Variable0.
        /// </summary>
        [DataMember]
        public double Variable0 { get; set; }
        /// <summary>
        /// Gets or sets the Variable1.
        /// </summary>
        [DataMember]
        public double Variable1 { get; set; }
        /// <summary>
        /// Gets or sets the Variable2.
        /// </summary>
        [DataMember]
        public double Variable2 { get; set; }
        /// <summary>
        /// Gets or sets the Variable3.
        /// </summary>
        [DataMember]
        public double Variable3 { get; set; }
        /// <summary>
        /// Gets or sets the Variable4.
        /// </summary>
        [DataMember]
        public double Variable4 { get; set; }
        /// <summary>
        /// Gets or sets the Variable5.
        /// </summary>
        [DataMember]
        public double Variable5 { get; set; }
        /// <summary>
        /// Gets or sets the Variable6.
        /// </summary>
        [DataMember]
        public double Variable6 { get; set; }
        /// <summary>
        /// Gets or sets the Variable7.
        /// </summary>
        [DataMember]
        public double Variable7 { get; set; }
        /// <summary>
        /// Gets or sets the Variable8.
        /// </summary>
        [DataMember]
        public double Variable8 { get; set; }
        /// <summary>
        /// Gets or sets the Variable9.
        /// </summary>
        [DataMember]
        public double Variable9 { get; set; }
        /// <summary>
        /// Gets or sets the WaitForOcoClosingBracket.
        /// </summary>
        [DataMember]
        public bool WaitForOcoClosingBracket { get; set; }
        /// <summary>
        /// Gets or sets the Workspace.
        /// </summary>
        [DataMember]
        public string Workspace { get; set; }
        /// <summary>
        /// Gets or sets the Account.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Account Account { get; set; }
        /// <summary>
        /// Gets or sets the All.
        /// </summary>
        [DataMember]
        public System.Collections.ObjectModel.Collection<NinjaTrader.NinjaScript.StrategyBase> All { get; set; }
        /// <summary>
        /// Gets or sets the Executions.
        /// </summary>
        [DataMember]
        public System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Execution> Executions { get; set; }
        /// <summary>
        /// Gets or sets the Gtd.
        /// </summary>
        [DataMember]
        public System.DateTime Gtd { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public long Id { get; set; }
        /// <summary>
        /// Gets or sets the LogTypeName.
        /// </summary>
        [DataMember]
        public string LogTypeName { get; set; }
        /// <summary>
        /// Gets or sets the Orders.
        /// </summary>
        [DataMember]
        public System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Order> Orders { get; set; }
        /// <summary>
        /// Gets or sets the ServerId.
        /// </summary>
        [DataMember]
        public long ServerId { get; set; }
        /// <summary>
        /// Gets or sets the Template.
        /// </summary>
        [DataMember]
        public string Template { get; set; }
        /// <summary>
        /// Gets or sets the TimeInForce.
        /// </summary>
        [DataMember]
        public TimeInForce TimeInForce { get; set; }
        /// <summary>
        /// Gets or sets the UserData.
        /// </summary>
        [DataMember]
        public System.Xml.Linq.XDocument UserData { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// AddChartIndicator method.
        /// </summary>
        /// <param name="indicator">NinjaTrader.NinjaScript.IndicatorBase</param>
        public void AddChartIndicator(NinjaTrader.NinjaScript.IndicatorBase indicator)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// AddPerformanceMetric method.
        /// </summary>
        /// <param name="performanceMetric">NinjaTrader.NinjaScript.PerformanceMetricBase</param>
        public void AddPerformanceMetric(NinjaTrader.NinjaScript.PerformanceMetricBase performanceMetric)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// BarsSinceEntryExecution method.
        /// </summary>
        /// <returns>int</returns>
        public int BarsSinceEntryExecution()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// BarsSinceEntryExecution method.
        /// </summary>
        /// <param name="signalName">string</param>
        /// <returns>int</returns>
        public int BarsSinceEntryExecution(string signalName)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// BarsSinceEntryExecution method.
        /// </summary>
        /// <param name="barsInProgressIndex">int</param>
        /// <param name="signalName">string</param>
        /// <param name="entryExecutionsAgo">int</param>
        /// <returns>int</returns>
        public int BarsSinceEntryExecution(int barsInProgressIndex, string signalName, int entryExecutionsAgo)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// BarsSinceExitExecution method.
        /// </summary>
        /// <returns>int</returns>
        public int BarsSinceExitExecution()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// BarsSinceExitExecution method.
        /// </summary>
        /// <param name="signalName">string</param>
        /// <returns>int</returns>
        public int BarsSinceExitExecution(string signalName)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// BarsSinceExitExecution method.
        /// </summary>
        /// <param name="barsInProgressIndex">int</param>
        /// <param name="signalName">string</param>
        /// <param name="exitExecutionsAgo">int</param>
        /// <returns>int</returns>
        public int BarsSinceExitExecution(int barsInProgressIndex, string signalName, int exitExecutionsAgo)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// CopyOrdersAndExecutionsTo method.
        /// </summary>
        /// <param name="strategyBase">NinjaTrader.NinjaScript.StrategyBase</param>
        public void CopyOrdersAndExecutionsTo(NinjaTrader.NinjaScript.StrategyBase strategyBase)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// CreateNewGeneration method.
        /// </summary>
        /// <param name="copyOrdersAndExecutions">bool</param>
        /// <param name="inclTradeHistoryInBacktest">bool?</param>
        /// <returns>NinjaTrader.NinjaScript.StrategyBase</returns>
        public NinjaTrader.NinjaScript.StrategyBase CreateNewGeneration(bool copyOrdersAndExecutions, bool? inclTradeHistoryInBacktest)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DbGet method.
        /// </summary>
        /// <param name="id">long</param>
        /// <returns>NinjaTrader.NinjaScript.StrategyBase</returns>
        public NinjaTrader.NinjaScript.StrategyBase DbGet(long id)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DbRemove method.
        /// </summary>
        public void DbRemove()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DbRemoveByCategory method.
        /// </summary>
        /// <param name="category">Category</param>
        /// <param name="useMailDB">bool</param>
        public void DbRemoveByCategory(Category category, bool useMailDB)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// EnterReadLock method.
        /// </summary>
        /// <returns>System.Collections.Generic.List<NinjaTrader.Data.BarsSeries></returns>
        public System.Collections.Generic.List<NinjaTrader.Data.BarsSeries> EnterReadLock()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitReadLock method.
        /// </summary>
        /// <param name="readLockList">System.Collections.Generic.List<NinjaTrader.Data.BarsSeries></param>
        public void ExitReadLock(System.Collections.Generic.List<NinjaTrader.Data.BarsSeries> readLockList)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetQuantity method.
        /// </summary>
        /// <param name="marketPosition">MarketPosition</param>
        /// <param name="quantity">int</param>
        /// <returns>int</returns>
        public int GetQuantity(MarketPosition marketPosition, int quantity)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetRealtimeOrder method.
        /// </summary>
        /// <param name="historicalOrder">NinjaTrader.Cbi.Order</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order GetRealtimeOrder(NinjaTrader.Cbi.Order historicalOrder)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetTradingHours method.
        /// </summary>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        /// <returns>NinjaTrader.Data.TradingHours</returns>
        public NinjaTrader.Data.TradingHours GetTradingHours(NinjaTrader.Cbi.Instrument instrument)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// MergePerformance method.
        /// </summary>
        /// <param name="performance">NinjaTrader.Cbi.SystemPerformance</param>
        public void MergePerformance(NinjaTrader.Cbi.SystemPerformance performance)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// RunBacktest method.
        /// </summary>
        public void RunBacktest()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// RunOptimization method.
        /// </summary>
        /// <param name="callback">System.Action<NinjaTrader.NinjaScript.StrategyBase></param>
        public void RunOptimization(System.Action<NinjaTrader.NinjaScript.StrategyBase> callback)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>string</returns>
        public string ToString()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// AddExecution method.
        /// </summary>
        /// <param name="position">NinjaTrader.Cbi.Position</param>
        /// <param name="execution">NinjaTrader.Cbi.Execution</param>
        /// <param name="order">NinjaTrader.Cbi.Order</param>
        public void AddExecution(NinjaTrader.Cbi.Position position, NinjaTrader.Cbi.Execution execution, NinjaTrader.Cbi.Order order)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// CancelOrder method.
        /// </summary>
        /// <param name="order">NinjaTrader.Cbi.Order</param>
        public void CancelOrder(NinjaTrader.Cbi.Order order)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ChangeOrder method.
        /// </summary>
        /// <param name="order">NinjaTrader.Cbi.Order</param>
        /// <param name="quantity">int</param>
        /// <param name="limitPrice">double</param>
        /// <param name="stopPrice">double</param>
        public void ChangeOrder(NinjaTrader.Cbi.Order order, int quantity, double limitPrice, double stopPrice)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// CloseStrategy method.
        /// </summary>
        /// <param name="signalName">string</param>
        public void CloseStrategy(string signalName)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// EnterLong method.
        /// </summary>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order EnterLong()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// EnterLong method.
        /// </summary>
        /// <param name="signalName">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order EnterLong(string signalName)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// EnterLong method.
        /// </summary>
        /// <param name="quantity">int</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order EnterLong(int quantity)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// EnterLong method.
        /// </summary>
        /// <param name="quantity">int</param>
        /// <param name="signalName">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order EnterLong(int quantity, string signalName)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// EnterLong method.
        /// </summary>
        /// <param name="barsInProgressIndex">int</param>
        /// <param name="quantity">int</param>
        /// <param name="signalName">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order EnterLong(int barsInProgressIndex, int quantity, string signalName)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// EnterLongLimit method.
        /// </summary>
        /// <param name="limitPrice">double</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order EnterLongLimit(double limitPrice)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// EnterLongLimit method.
        /// </summary>
        /// <param name="limitPrice">double</param>
        /// <param name="signalName">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order EnterLongLimit(double limitPrice, string signalName)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// EnterLongLimit method.
        /// </summary>
        /// <param name="quantity">int</param>
        /// <param name="limitPrice">double</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order EnterLongLimit(int quantity, double limitPrice)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// EnterLongLimit method.
        /// </summary>
        /// <param name="quantity">int</param>
        /// <param name="limitPrice">double</param>
        /// <param name="signalName">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order EnterLongLimit(int quantity, double limitPrice, string signalName)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// EnterLongLimit method.
        /// </summary>
        /// <param name="barsInProgressIndex">int</param>
        /// <param name="isLiveUntilCancelled">bool</param>
        /// <param name="quantity">int</param>
        /// <param name="limitPrice">double</param>
        /// <param name="signalName">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order EnterLongLimit(int barsInProgressIndex, bool isLiveUntilCancelled, int quantity, double limitPrice, string signalName)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// EnterLongMIT method.
        /// </summary>
        /// <param name="stopPrice">double</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order EnterLongMIT(double stopPrice)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// EnterLongMIT method.
        /// </summary>
        /// <param name="stopPrice">double</param>
        /// <param name="signalName">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order EnterLongMIT(double stopPrice, string signalName)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// EnterLongMIT method.
        /// </summary>
        /// <param name="quantity">int</param>
        /// <param name="stopPrice">double</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order EnterLongMIT(int quantity, double stopPrice)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// EnterLongMIT method.
        /// </summary>
        /// <param name="quantity">int</param>
        /// <param name="stopPrice">double</param>
        /// <param name="signalName">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order EnterLongMIT(int quantity, double stopPrice, string signalName)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// EnterLongMIT method.
        /// </summary>
        /// <param name="barsInProgressIndex">int</param>
        /// <param name="isLiveUntilCancelled">bool</param>
        /// <param name="quantity">int</param>
        /// <param name="stopPrice">double</param>
        /// <param name="signalName">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order EnterLongMIT(int barsInProgressIndex, bool isLiveUntilCancelled, int quantity, double stopPrice, string signalName)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// EnterLongStopLimit method.
        /// </summary>
        /// <param name="limitPrice">double</param>
        /// <param name="stopPrice">double</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order EnterLongStopLimit(double limitPrice, double stopPrice)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// EnterLongStopLimit method.
        /// </summary>
        /// <param name="limitPrice">double</param>
        /// <param name="stopPrice">double</param>
        /// <param name="signalName">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order EnterLongStopLimit(double limitPrice, double stopPrice, string signalName)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// EnterLongStopLimit method.
        /// </summary>
        /// <param name="quantity">int</param>
        /// <param name="limitPrice">double</param>
        /// <param name="stopPrice">double</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order EnterLongStopLimit(int quantity, double limitPrice, double stopPrice)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// EnterLongStopLimit method.
        /// </summary>
        /// <param name="quantity">int</param>
        /// <param name="limitPrice">double</param>
        /// <param name="stopPrice">double</param>
        /// <param name="signalName">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order EnterLongStopLimit(int quantity, double limitPrice, double stopPrice, string signalName)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// EnterLongStopLimit method.
        /// </summary>
        /// <param name="barsInProgressIndex">int</param>
        /// <param name="isLiveUntilCancelled">bool</param>
        /// <param name="quantity">int</param>
        /// <param name="limitPrice">double</param>
        /// <param name="stopPrice">double</param>
        /// <param name="signalName">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order EnterLongStopLimit(int barsInProgressIndex, bool isLiveUntilCancelled, int quantity, double limitPrice, double stopPrice, string signalName)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// EnterLongStopMarket method.
        /// </summary>
        /// <param name="stopPrice">double</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order EnterLongStopMarket(double stopPrice)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// EnterLongStopMarket method.
        /// </summary>
        /// <param name="stopPrice">double</param>
        /// <param name="signalName">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order EnterLongStopMarket(double stopPrice, string signalName)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// EnterLongStopMarket method.
        /// </summary>
        /// <param name="quantity">int</param>
        /// <param name="stopPrice">double</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order EnterLongStopMarket(int quantity, double stopPrice)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// EnterLongStopMarket method.
        /// </summary>
        /// <param name="quantity">int</param>
        /// <param name="stopPrice">double</param>
        /// <param name="signalName">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order EnterLongStopMarket(int quantity, double stopPrice, string signalName)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// EnterLongStopMarket method.
        /// </summary>
        /// <param name="barsInProgressIndex">int</param>
        /// <param name="isLiveUntilCancelled">bool</param>
        /// <param name="quantity">int</param>
        /// <param name="stopPrice">double</param>
        /// <param name="signalName">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order EnterLongStopMarket(int barsInProgressIndex, bool isLiveUntilCancelled, int quantity, double stopPrice, string signalName)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// EnterShort method.
        /// </summary>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order EnterShort()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// EnterShort method.
        /// </summary>
        /// <param name="signalName">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order EnterShort(string signalName)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// EnterShort method.
        /// </summary>
        /// <param name="quantity">int</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order EnterShort(int quantity)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// EnterShort method.
        /// </summary>
        /// <param name="quantity">int</param>
        /// <param name="signalName">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order EnterShort(int quantity, string signalName)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// EnterShort method.
        /// </summary>
        /// <param name="barsInProgressIndex">int</param>
        /// <param name="quantity">int</param>
        /// <param name="signalName">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order EnterShort(int barsInProgressIndex, int quantity, string signalName)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// EnterShortLimit method.
        /// </summary>
        /// <param name="limitPrice">double</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order EnterShortLimit(double limitPrice)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// EnterShortLimit method.
        /// </summary>
        /// <param name="limitPrice">double</param>
        /// <param name="signalName">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order EnterShortLimit(double limitPrice, string signalName)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// EnterShortLimit method.
        /// </summary>
        /// <param name="quantity">int</param>
        /// <param name="limitPrice">double</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order EnterShortLimit(int quantity, double limitPrice)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// EnterShortLimit method.
        /// </summary>
        /// <param name="quantity">int</param>
        /// <param name="limitPrice">double</param>
        /// <param name="signalName">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order EnterShortLimit(int quantity, double limitPrice, string signalName)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// EnterShortLimit method.
        /// </summary>
        /// <param name="barsInProgressIndex">int</param>
        /// <param name="isLiveUntilCancelled">bool</param>
        /// <param name="quantity">int</param>
        /// <param name="limitPrice">double</param>
        /// <param name="signalName">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order EnterShortLimit(int barsInProgressIndex, bool isLiveUntilCancelled, int quantity, double limitPrice, string signalName)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// EnterShortMIT method.
        /// </summary>
        /// <param name="stopPrice">double</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order EnterShortMIT(double stopPrice)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// EnterShortMIT method.
        /// </summary>
        /// <param name="stopPrice">double</param>
        /// <param name="signalName">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order EnterShortMIT(double stopPrice, string signalName)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// EnterShortMIT method.
        /// </summary>
        /// <param name="quantity">int</param>
        /// <param name="stopPrice">double</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order EnterShortMIT(int quantity, double stopPrice)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// EnterShortMIT method.
        /// </summary>
        /// <param name="quantity">int</param>
        /// <param name="stopPrice">double</param>
        /// <param name="signalName">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order EnterShortMIT(int quantity, double stopPrice, string signalName)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// EnterShortMIT method.
        /// </summary>
        /// <param name="barsInProgressIndex">int</param>
        /// <param name="isLiveUntilCancelled">bool</param>
        /// <param name="quantity">int</param>
        /// <param name="stopPrice">double</param>
        /// <param name="signalName">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order EnterShortMIT(int barsInProgressIndex, bool isLiveUntilCancelled, int quantity, double stopPrice, string signalName)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// EnterShortStopLimit method.
        /// </summary>
        /// <param name="limitPrice">double</param>
        /// <param name="stopPrice">double</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order EnterShortStopLimit(double limitPrice, double stopPrice)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// EnterShortStopLimit method.
        /// </summary>
        /// <param name="limitPrice">double</param>
        /// <param name="stopPrice">double</param>
        /// <param name="signalName">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order EnterShortStopLimit(double limitPrice, double stopPrice, string signalName)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// EnterShortStopLimit method.
        /// </summary>
        /// <param name="quantity">int</param>
        /// <param name="limitPrice">double</param>
        /// <param name="stopPrice">double</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order EnterShortStopLimit(int quantity, double limitPrice, double stopPrice)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// EnterShortStopLimit method.
        /// </summary>
        /// <param name="quantity">int</param>
        /// <param name="limitPrice">double</param>
        /// <param name="stopPrice">double</param>
        /// <param name="signalName">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order EnterShortStopLimit(int quantity, double limitPrice, double stopPrice, string signalName)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// EnterShortStopLimit method.
        /// </summary>
        /// <param name="barsInProgressIndex">int</param>
        /// <param name="isLiveUntilCancelled">bool</param>
        /// <param name="quantity">int</param>
        /// <param name="limitPrice">double</param>
        /// <param name="stopPrice">double</param>
        /// <param name="signalName">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order EnterShortStopLimit(int barsInProgressIndex, bool isLiveUntilCancelled, int quantity, double limitPrice, double stopPrice, string signalName)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// EnterShortStopMarket method.
        /// </summary>
        /// <param name="stopPrice">double</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order EnterShortStopMarket(double stopPrice)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// EnterShortStopMarket method.
        /// </summary>
        /// <param name="stopPrice">double</param>
        /// <param name="signalName">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order EnterShortStopMarket(double stopPrice, string signalName)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// EnterShortStopMarket method.
        /// </summary>
        /// <param name="quantity">int</param>
        /// <param name="stopPrice">double</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order EnterShortStopMarket(int quantity, double stopPrice)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// EnterShortStopMarket method.
        /// </summary>
        /// <param name="quantity">int</param>
        /// <param name="stopPrice">double</param>
        /// <param name="signalName">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order EnterShortStopMarket(int quantity, double stopPrice, string signalName)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// EnterShortStopMarket method.
        /// </summary>
        /// <param name="barsInProgressIndex">int</param>
        /// <param name="isLiveUntilCancelled">bool</param>
        /// <param name="quantity">int</param>
        /// <param name="stopPrice">double</param>
        /// <param name="signalName">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order EnterShortStopMarket(int barsInProgressIndex, bool isLiveUntilCancelled, int quantity, double stopPrice, string signalName)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitLong method.
        /// </summary>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitLong()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitLong method.
        /// </summary>
        /// <param name="quantity">int</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitLong(int quantity)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitLong method.
        /// </summary>
        /// <param name="fromEntrySignal">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitLong(string fromEntrySignal)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitLong method.
        /// </summary>
        /// <param name="signalName">string</param>
        /// <param name="fromEntrySignal">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitLong(string signalName, string fromEntrySignal)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitLong method.
        /// </summary>
        /// <param name="quantity">int</param>
        /// <param name="signalName">string</param>
        /// <param name="fromEntrySignal">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitLong(int quantity, string signalName, string fromEntrySignal)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitLong method.
        /// </summary>
        /// <param name="barsInProgressIndex">int</param>
        /// <param name="quantity">int</param>
        /// <param name="signalName">string</param>
        /// <param name="fromEntrySignal">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitLong(int barsInProgressIndex, int quantity, string signalName, string fromEntrySignal)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitLongLimit method.
        /// </summary>
        /// <param name="limitPrice">double</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitLongLimit(double limitPrice)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitLongLimit method.
        /// </summary>
        /// <param name="quantity">int</param>
        /// <param name="limitPrice">double</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitLongLimit(int quantity, double limitPrice)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitLongLimit method.
        /// </summary>
        /// <param name="limitPrice">double</param>
        /// <param name="fromEntrySignal">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitLongLimit(double limitPrice, string fromEntrySignal)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitLongLimit method.
        /// </summary>
        /// <param name="limitPrice">double</param>
        /// <param name="signalName">string</param>
        /// <param name="fromEntrySignal">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitLongLimit(double limitPrice, string signalName, string fromEntrySignal)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitLongLimit method.
        /// </summary>
        /// <param name="quantity">int</param>
        /// <param name="limitPrice">double</param>
        /// <param name="signalName">string</param>
        /// <param name="fromEntrySignal">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitLongLimit(int quantity, double limitPrice, string signalName, string fromEntrySignal)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitLongLimit method.
        /// </summary>
        /// <param name="barsInProgressIndex">int</param>
        /// <param name="isLiveUntilCancelled">bool</param>
        /// <param name="quantity">int</param>
        /// <param name="limitPrice">double</param>
        /// <param name="signalName">string</param>
        /// <param name="fromEntrySignal">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitLongLimit(int barsInProgressIndex, bool isLiveUntilCancelled, int quantity, double limitPrice, string signalName, string fromEntrySignal)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitLongMIT method.
        /// </summary>
        /// <param name="stopPrice">double</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitLongMIT(double stopPrice)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitLongMIT method.
        /// </summary>
        /// <param name="quantity">int</param>
        /// <param name="stopPrice">double</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitLongMIT(int quantity, double stopPrice)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitLongMIT method.
        /// </summary>
        /// <param name="stopPrice">double</param>
        /// <param name="fromEntrySignal">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitLongMIT(double stopPrice, string fromEntrySignal)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitLongMIT method.
        /// </summary>
        /// <param name="stopPrice">double</param>
        /// <param name="signalName">string</param>
        /// <param name="fromEntrySignal">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitLongMIT(double stopPrice, string signalName, string fromEntrySignal)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitLongMIT method.
        /// </summary>
        /// <param name="quantity">int</param>
        /// <param name="stopPrice">double</param>
        /// <param name="signalName">string</param>
        /// <param name="fromEntrySignal">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitLongMIT(int quantity, double stopPrice, string signalName, string fromEntrySignal)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitLongMIT method.
        /// </summary>
        /// <param name="barsInProgressIndex">int</param>
        /// <param name="isLiveUntilCancelled">bool</param>
        /// <param name="quantity">int</param>
        /// <param name="stopPrice">double</param>
        /// <param name="signalName">string</param>
        /// <param name="fromEntrySignal">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitLongMIT(int barsInProgressIndex, bool isLiveUntilCancelled, int quantity, double stopPrice, string signalName, string fromEntrySignal)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitLongStopLimit method.
        /// </summary>
        /// <param name="limitPrice">double</param>
        /// <param name="stopPrice">double</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitLongStopLimit(double limitPrice, double stopPrice)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitLongStopLimit method.
        /// </summary>
        /// <param name="quantity">int</param>
        /// <param name="limitPrice">double</param>
        /// <param name="stopPrice">double</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitLongStopLimit(int quantity, double limitPrice, double stopPrice)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitLongStopLimit method.
        /// </summary>
        /// <param name="limitPrice">double</param>
        /// <param name="stopPrice">double</param>
        /// <param name="fromEntrySignal">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitLongStopLimit(double limitPrice, double stopPrice, string fromEntrySignal)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitLongStopLimit method.
        /// </summary>
        /// <param name="limitPrice">double</param>
        /// <param name="stopPrice">double</param>
        /// <param name="signalName">string</param>
        /// <param name="fromEntrySignal">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitLongStopLimit(double limitPrice, double stopPrice, string signalName, string fromEntrySignal)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitLongStopLimit method.
        /// </summary>
        /// <param name="quantity">int</param>
        /// <param name="limitPrice">double</param>
        /// <param name="stopPrice">double</param>
        /// <param name="signalName">string</param>
        /// <param name="fromEntrySignal">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitLongStopLimit(int quantity, double limitPrice, double stopPrice, string signalName, string fromEntrySignal)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitLongStopLimit method.
        /// </summary>
        /// <param name="barsInProgressIndex">int</param>
        /// <param name="isLiveUntilCancelled">bool</param>
        /// <param name="quantity">int</param>
        /// <param name="limitPrice">double</param>
        /// <param name="stopPrice">double</param>
        /// <param name="signalName">string</param>
        /// <param name="fromEntrySignal">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitLongStopLimit(int barsInProgressIndex, bool isLiveUntilCancelled, int quantity, double limitPrice, double stopPrice, string signalName, string fromEntrySignal)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitLongStopMarket method.
        /// </summary>
        /// <param name="stopPrice">double</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitLongStopMarket(double stopPrice)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitLongStopMarket method.
        /// </summary>
        /// <param name="quantity">int</param>
        /// <param name="stopPrice">double</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitLongStopMarket(int quantity, double stopPrice)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitLongStopMarket method.
        /// </summary>
        /// <param name="stopPrice">double</param>
        /// <param name="fromEntrySignal">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitLongStopMarket(double stopPrice, string fromEntrySignal)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitLongStopMarket method.
        /// </summary>
        /// <param name="stopPrice">double</param>
        /// <param name="signalName">string</param>
        /// <param name="fromEntrySignal">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitLongStopMarket(double stopPrice, string signalName, string fromEntrySignal)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitLongStopMarket method.
        /// </summary>
        /// <param name="quantity">int</param>
        /// <param name="stopPrice">double</param>
        /// <param name="signalName">string</param>
        /// <param name="fromEntrySignal">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitLongStopMarket(int quantity, double stopPrice, string signalName, string fromEntrySignal)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitLongStopMarket method.
        /// </summary>
        /// <param name="barsInProgressIndex">int</param>
        /// <param name="isLiveUntilCancelled">bool</param>
        /// <param name="quantity">int</param>
        /// <param name="stopPrice">double</param>
        /// <param name="signalName">string</param>
        /// <param name="fromEntrySignal">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitLongStopMarket(int barsInProgressIndex, bool isLiveUntilCancelled, int quantity, double stopPrice, string signalName, string fromEntrySignal)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitShort method.
        /// </summary>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitShort()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitShort method.
        /// </summary>
        /// <param name="quantity">int</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitShort(int quantity)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitShort method.
        /// </summary>
        /// <param name="fromEntrySignal">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitShort(string fromEntrySignal)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitShort method.
        /// </summary>
        /// <param name="signalName">string</param>
        /// <param name="fromEntrySignal">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitShort(string signalName, string fromEntrySignal)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitShort method.
        /// </summary>
        /// <param name="quantity">int</param>
        /// <param name="signalName">string</param>
        /// <param name="fromEntrySignal">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitShort(int quantity, string signalName, string fromEntrySignal)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitShort method.
        /// </summary>
        /// <param name="barsInProgressIndex">int</param>
        /// <param name="quantity">int</param>
        /// <param name="signalName">string</param>
        /// <param name="fromEntrySignal">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitShort(int barsInProgressIndex, int quantity, string signalName, string fromEntrySignal)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitShortLimit method.
        /// </summary>
        /// <param name="limitPrice">double</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitShortLimit(double limitPrice)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitShortLimit method.
        /// </summary>
        /// <param name="quantity">int</param>
        /// <param name="limitPrice">double</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitShortLimit(int quantity, double limitPrice)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitShortLimit method.
        /// </summary>
        /// <param name="limitPrice">double</param>
        /// <param name="fromEntrySignal">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitShortLimit(double limitPrice, string fromEntrySignal)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitShortLimit method.
        /// </summary>
        /// <param name="limitPrice">double</param>
        /// <param name="signalName">string</param>
        /// <param name="fromEntrySignal">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitShortLimit(double limitPrice, string signalName, string fromEntrySignal)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitShortLimit method.
        /// </summary>
        /// <param name="quantity">int</param>
        /// <param name="limitPrice">double</param>
        /// <param name="signalName">string</param>
        /// <param name="fromEntrySignal">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitShortLimit(int quantity, double limitPrice, string signalName, string fromEntrySignal)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitShortLimit method.
        /// </summary>
        /// <param name="barsInProgressIndex">int</param>
        /// <param name="isLiveUntilCancelled">bool</param>
        /// <param name="quantity">int</param>
        /// <param name="limitPrice">double</param>
        /// <param name="signalName">string</param>
        /// <param name="fromEntrySignal">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitShortLimit(int barsInProgressIndex, bool isLiveUntilCancelled, int quantity, double limitPrice, string signalName, string fromEntrySignal)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitShortMIT method.
        /// </summary>
        /// <param name="stopPrice">double</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitShortMIT(double stopPrice)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitShortMIT method.
        /// </summary>
        /// <param name="quantity">int</param>
        /// <param name="stopPrice">double</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitShortMIT(int quantity, double stopPrice)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitShortMIT method.
        /// </summary>
        /// <param name="stopPrice">double</param>
        /// <param name="fromEntrySignal">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitShortMIT(double stopPrice, string fromEntrySignal)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitShortMIT method.
        /// </summary>
        /// <param name="stopPrice">double</param>
        /// <param name="signalName">string</param>
        /// <param name="fromEntrySignal">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitShortMIT(double stopPrice, string signalName, string fromEntrySignal)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitShortMIT method.
        /// </summary>
        /// <param name="quantity">int</param>
        /// <param name="stopPrice">double</param>
        /// <param name="signalName">string</param>
        /// <param name="fromEntrySignal">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitShortMIT(int quantity, double stopPrice, string signalName, string fromEntrySignal)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitShortMIT method.
        /// </summary>
        /// <param name="barsInProgressIndex">int</param>
        /// <param name="isLiveUntilCancelled">bool</param>
        /// <param name="quantity">int</param>
        /// <param name="stopPrice">double</param>
        /// <param name="signalName">string</param>
        /// <param name="fromEntrySignal">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitShortMIT(int barsInProgressIndex, bool isLiveUntilCancelled, int quantity, double stopPrice, string signalName, string fromEntrySignal)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitShortStopLimit method.
        /// </summary>
        /// <param name="limitPrice">double</param>
        /// <param name="stopPrice">double</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitShortStopLimit(double limitPrice, double stopPrice)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitShortStopLimit method.
        /// </summary>
        /// <param name="quantity">int</param>
        /// <param name="limitPrice">double</param>
        /// <param name="stopPrice">double</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitShortStopLimit(int quantity, double limitPrice, double stopPrice)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitShortStopLimit method.
        /// </summary>
        /// <param name="limitPrice">double</param>
        /// <param name="stopPrice">double</param>
        /// <param name="fromEntrySignal">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitShortStopLimit(double limitPrice, double stopPrice, string fromEntrySignal)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitShortStopLimit method.
        /// </summary>
        /// <param name="limitPrice">double</param>
        /// <param name="stopPrice">double</param>
        /// <param name="signalName">string</param>
        /// <param name="fromEntrySignal">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitShortStopLimit(double limitPrice, double stopPrice, string signalName, string fromEntrySignal)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitShortStopLimit method.
        /// </summary>
        /// <param name="quantity">int</param>
        /// <param name="limitPrice">double</param>
        /// <param name="stopPrice">double</param>
        /// <param name="signalName">string</param>
        /// <param name="fromEntrySignal">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitShortStopLimit(int quantity, double limitPrice, double stopPrice, string signalName, string fromEntrySignal)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitShortStopLimit method.
        /// </summary>
        /// <param name="barsInProgressIndex">int</param>
        /// <param name="isLiveUntilCancelled">bool</param>
        /// <param name="quantity">int</param>
        /// <param name="limitPrice">double</param>
        /// <param name="stopPrice">double</param>
        /// <param name="signalName">string</param>
        /// <param name="fromEntrySignal">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitShortStopLimit(int barsInProgressIndex, bool isLiveUntilCancelled, int quantity, double limitPrice, double stopPrice, string signalName, string fromEntrySignal)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitShortStopMarket method.
        /// </summary>
        /// <param name="stopPrice">double</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitShortStopMarket(double stopPrice)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitShortStopMarket method.
        /// </summary>
        /// <param name="quantity">int</param>
        /// <param name="stopPrice">double</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitShortStopMarket(int quantity, double stopPrice)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitShortStopMarket method.
        /// </summary>
        /// <param name="stopPrice">double</param>
        /// <param name="fromEntrySignal">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitShortStopMarket(double stopPrice, string fromEntrySignal)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitShortStopMarket method.
        /// </summary>
        /// <param name="stopPrice">double</param>
        /// <param name="signalName">string</param>
        /// <param name="fromEntrySignal">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitShortStopMarket(double stopPrice, string signalName, string fromEntrySignal)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitShortStopMarket method.
        /// </summary>
        /// <param name="quantity">int</param>
        /// <param name="stopPrice">double</param>
        /// <param name="signalName">string</param>
        /// <param name="fromEntrySignal">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitShortStopMarket(int quantity, double stopPrice, string signalName, string fromEntrySignal)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExitShortStopMarket method.
        /// </summary>
        /// <param name="barsInProgressIndex">int</param>
        /// <param name="isLiveUntilCancelled">bool</param>
        /// <param name="quantity">int</param>
        /// <param name="stopPrice">double</param>
        /// <param name="signalName">string</param>
        /// <param name="fromEntrySignal">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order ExitShortStopMarket(int barsInProgressIndex, bool isLiveUntilCancelled, int quantity, double stopPrice, string signalName, string fromEntrySignal)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// AtmStrategyCancelEntryOrder method.
        /// </summary>
        /// <param name="orderId">string</param>
        /// <returns>bool</returns>
        public bool AtmStrategyCancelEntryOrder(string orderId)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// AtmStrategyChangeEntryOrder method.
        /// </summary>
        /// <param name="limitPrice">double</param>
        /// <param name="stopPrice">double</param>
        /// <param name="orderId">string</param>
        /// <returns>bool</returns>
        public bool AtmStrategyChangeEntryOrder(double limitPrice, double stopPrice, string orderId)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// AtmStrategyChangeStopTarget method.
        /// </summary>
        /// <param name="limitPrice">double</param>
        /// <param name="stopPrice">double</param>
        /// <param name="orderName">string</param>
        /// <param name="atmStrategyId">string</param>
        /// <returns>bool</returns>
        public bool AtmStrategyChangeStopTarget(double limitPrice, double stopPrice, string orderName, string atmStrategyId)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// AtmStrategyClose method.
        /// </summary>
        /// <param name="atmStrategyId">string</param>
        /// <returns>bool</returns>
        public bool AtmStrategyClose(string atmStrategyId)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// AtmStrategyCreate method.
        /// </summary>
        /// <param name="action">OrderAction</param>
        /// <param name="orderType">OrderType</param>
        /// <param name="limitPrice">double</param>
        /// <param name="stopPrice">double</param>
        /// <param name="timeInForce">TimeInForce</param>
        /// <param name="orderId">string</param>
        /// <param name="strategyTemplateName">string</param>
        /// <param name="atmStrategyId">string</param>
        /// <param name="callback">System.Action<ErrorCode, string></param>
        public void AtmStrategyCreate(OrderAction action, OrderType orderType, double limitPrice, double stopPrice, TimeInForce timeInForce, string orderId, string strategyTemplateName, string atmStrategyId, System.Action<ErrorCode, string> callback)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetAtmStrategyEntryOrderStatus method.
        /// </summary>
        /// <param name="orderId">string</param>
        /// <returns>System.String[]</returns>
        public System.String[] GetAtmStrategyEntryOrderStatus(string orderId)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetAtmStrategyMarketPosition method.
        /// </summary>
        /// <param name="atmStrategyId">string</param>
        /// <returns>MarketPosition</returns>
        public MarketPosition GetAtmStrategyMarketPosition(string atmStrategyId)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetAtmStrategyPositionAveragePrice method.
        /// </summary>
        /// <param name="atmStrategyId">string</param>
        /// <returns>double</returns>
        public double GetAtmStrategyPositionAveragePrice(string atmStrategyId)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetAtmStrategyPositionQuantity method.
        /// </summary>
        /// <param name="atmStrategyId">string</param>
        /// <returns>int</returns>
        public int GetAtmStrategyPositionQuantity(string atmStrategyId)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetAtmStrategyRealizedProfitLoss method.
        /// </summary>
        /// <param name="atmStrategyId">string</param>
        /// <returns>double</returns>
        public double GetAtmStrategyRealizedProfitLoss(string atmStrategyId)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetAtmStrategyStopTargetOrderStatus method.
        /// </summary>
        /// <param name="orderName">string</param>
        /// <param name="atmStrategyId">string</param>
        /// <returns>System.String[0...,0...]</returns>
        public System.String[0...,0...] GetAtmStrategyStopTargetOrderStatus(string orderName, string atmStrategyId)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetAtmStrategyUnrealizedProfitLoss method.
        /// </summary>
        /// <param name="atmStrategyId">string</param>
        /// <returns>double</returns>
        public double GetAtmStrategyUnrealizedProfitLoss(string atmStrategyId)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetAtmStrategyUniqueId method.
        /// </summary>
        /// <returns>string</returns>
        public string GetAtmStrategyUniqueId()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// FillOrder method.
        /// </summary>
        /// <param name="order">NinjaTrader.Cbi.Order</param>
        /// <param name="fillPrice">double</param>
        /// <param name="slippage">double</param>
        /// <returns>bool</returns>
        public bool FillOrder(NinjaTrader.Cbi.Order order, double fillPrice, double slippage)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SetParabolicStop method.
        /// </summary>
        /// <param name="mode">CalculationMode</param>
        /// <param name="value">double</param>
        public void SetParabolicStop(CalculationMode mode, double value)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SetParabolicStop method.
        /// </summary>
        /// <param name="fromEntrySignal">string</param>
        /// <param name="mode">CalculationMode</param>
        /// <param name="value">double</param>
        /// <param name="isSimulatedStop">bool</param>
        /// <param name="acceleration">double</param>
        /// <param name="accelerationMax">double</param>
        /// <param name="accelerationStep">double</param>
        public void SetParabolicStop(string fromEntrySignal, CalculationMode mode, double value, bool isSimulatedStop, double acceleration, double accelerationMax, double accelerationStep)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SetProfitTarget method.
        /// </summary>
        /// <param name="mode">CalculationMode</param>
        /// <param name="value">double</param>
        public void SetProfitTarget(CalculationMode mode, double value)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SetProfitTarget method.
        /// </summary>
        /// <param name="mode">CalculationMode</param>
        /// <param name="value">double</param>
        /// <param name="isMIT">bool</param>
        public void SetProfitTarget(CalculationMode mode, double value, bool isMIT)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SetProfitTarget method.
        /// </summary>
        /// <param name="fromEntrySignal">string</param>
        /// <param name="mode">CalculationMode</param>
        /// <param name="value">double</param>
        public void SetProfitTarget(string fromEntrySignal, CalculationMode mode, double value)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SetProfitTarget method.
        /// </summary>
        /// <param name="fromEntrySignal">string</param>
        /// <param name="mode">CalculationMode</param>
        /// <param name="value">double</param>
        /// <param name="isMIT">bool</param>
        public void SetProfitTarget(string fromEntrySignal, CalculationMode mode, double value, bool isMIT)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SetStopLoss method.
        /// </summary>
        /// <param name="mode">CalculationMode</param>
        /// <param name="value">double</param>
        public void SetStopLoss(CalculationMode mode, double value)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SetStopLoss method.
        /// </summary>
        /// <param name="fromEntrySignal">string</param>
        /// <param name="mode">CalculationMode</param>
        /// <param name="value">double</param>
        /// <param name="isSimulatedStop">bool</param>
        public void SetStopLoss(string fromEntrySignal, CalculationMode mode, double value, bool isSimulatedStop)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SetTrailStop method.
        /// </summary>
        /// <param name="mode">CalculationMode</param>
        /// <param name="value">double</param>
        public void SetTrailStop(CalculationMode mode, double value)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SetTrailStop method.
        /// </summary>
        /// <param name="fromEntrySignal">string</param>
        /// <param name="mode">CalculationMode</param>
        /// <param name="value">double</param>
        /// <param name="isSimulatedStop">bool</param>
        public void SetTrailStop(string fromEntrySignal, CalculationMode mode, double value, bool isSimulatedStop)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SubmitOrderUnmanaged method.
        /// </summary>
        /// <param name="selectedBarsInProgress">int</param>
        /// <param name="orderAction">OrderAction</param>
        /// <param name="orderType">OrderType</param>
        /// <param name="quantity">int</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order SubmitOrderUnmanaged(int selectedBarsInProgress, OrderAction orderAction, OrderType orderType, int quantity)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SubmitOrderUnmanaged method.
        /// </summary>
        /// <param name="selectedBarsInProgress">int</param>
        /// <param name="orderAction">OrderAction</param>
        /// <param name="orderType">OrderType</param>
        /// <param name="quantity">int</param>
        /// <param name="limitPrice">double</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order SubmitOrderUnmanaged(int selectedBarsInProgress, OrderAction orderAction, OrderType orderType, int quantity, double limitPrice)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SubmitOrderUnmanaged method.
        /// </summary>
        /// <param name="selectedBarsInProgress">int</param>
        /// <param name="orderAction">OrderAction</param>
        /// <param name="orderType">OrderType</param>
        /// <param name="quantity">int</param>
        /// <param name="limitPrice">double</param>
        /// <param name="stopPrice">double</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order SubmitOrderUnmanaged(int selectedBarsInProgress, OrderAction orderAction, OrderType orderType, int quantity, double limitPrice, double stopPrice)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SubmitOrderUnmanaged method.
        /// </summary>
        /// <param name="selectedBarsInProgress">int</param>
        /// <param name="orderAction">OrderAction</param>
        /// <param name="orderType">OrderType</param>
        /// <param name="quantity">int</param>
        /// <param name="limitPrice">double</param>
        /// <param name="stopPrice">double</param>
        /// <param name="oco">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order SubmitOrderUnmanaged(int selectedBarsInProgress, OrderAction orderAction, OrderType orderType, int quantity, double limitPrice, double stopPrice, string oco)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SubmitOrderUnmanaged method.
        /// </summary>
        /// <param name="selectedBarsInProgress">int</param>
        /// <param name="orderAction">OrderAction</param>
        /// <param name="orderType">OrderType</param>
        /// <param name="quantity">int</param>
        /// <param name="limitPrice">double</param>
        /// <param name="stopPrice">double</param>
        /// <param name="oco">string</param>
        /// <param name="signalName">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order SubmitOrderUnmanaged(int selectedBarsInProgress, OrderAction orderAction, OrderType orderType, int quantity, double limitPrice, double stopPrice, string oco, string signalName)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="ninjaScript">NinjaTrader.NinjaScript.NinjaScript</param>
        public void CopyTo(NinjaTrader.NinjaScript.NinjaScript ninjaScript)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SetUniqueId method.
        /// </summary>
        public void SetUniqueId()
        {
            // Method implementation goes here
        }
        #endregion
    }
}
