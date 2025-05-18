[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class StrategyBase : NinjaScriptBase
    {
        #region Properties
        /// <summary>
        /// Gets or sets the BacktestCommissionTemplate.
        /// </summary>
        [DataMember]
        public String BacktestCommissionTemplate { get; set; }
        /// <summary>
        /// Gets or sets the BarsPeriodParameter.
        /// </summary>
        [DataMember]
        public Parameter BarsPeriodParameter { get; set; }
        /// <summary>
        /// Gets or sets the BarsRequiredToTrade.
        /// </summary>
        [DataMember]
        public Int32 BarsRequiredToTrade { get; set; }
        /// <summary>
        /// Gets or sets the Category.
        /// </summary>
        [DataMember]
        public Category Category { get; set; }
        /// <summary>
        /// Gets or sets the ChartIndicators.
        /// </summary>
        [DataMember]
        public IndicatorBase[] ChartIndicators { get; set; }
        /// <summary>
        /// Gets or sets the ConnectionLossHandling.
        /// </summary>
        [DataMember]
        public ConnectionLossHandling ConnectionLossHandling { get; set; }
        /// <summary>
        /// Gets or sets the DaysToLoad.
        /// </summary>
        [DataMember]
        public Int32 DaysToLoad { get; set; }
        /// <summary>
        /// Gets or sets the DefaultName.
        /// </summary>
        [DataMember]
        public String DefaultName { get; set; }
        /// <summary>
        /// Gets or sets the DefaultQuantity.
        /// </summary>
        [DataMember]
        public Int32 DefaultQuantity { get; set; }
        /// <summary>
        /// Gets or sets the DisconnectDelaySeconds.
        /// </summary>
        [DataMember]
        public Int32 DisconnectDelaySeconds { get; set; }
        /// <summary>
        /// Gets or sets the DisplayName.
        /// </summary>
        [DataMember]
        public String DisplayName { get; set; }
        /// <summary>
        /// Gets or sets the DisplayParameters.
        /// </summary>
        [DataMember]
        public String DisplayParameters { get; set; }
        /// <summary>
        /// Gets or sets the EntriesPerDirection.
        /// </summary>
        [DataMember]
        public Int32 EntriesPerDirection { get; set; }
        /// <summary>
        /// Gets or sets the EntryHandling.
        /// </summary>
        [DataMember]
        public EntryHandling EntryHandling { get; set; }
        /// <summary>
        /// Gets or sets the ExitOnSessionCloseSeconds.
        /// </summary>
        [DataMember]
        public Int32 ExitOnSessionCloseSeconds { get; set; }
        /// <summary>
        /// Gets or sets the FillType.
        /// </summary>
        [DataMember]
        public FillType FillType { get; set; }
        /// <summary>
        /// Gets or sets the IgnoreOverfill.
        /// </summary>
        [DataMember]
        public Boolean IgnoreOverfill { get; set; }
        /// <summary>
        /// Gets or sets the IncludeCommission.
        /// </summary>
        [DataMember]
        public Boolean IncludeCommission { get; set; }
        /// <summary>
        /// Gets or sets the IncludeTradeHistoryInBacktest.
        /// </summary>
        [DataMember]
        public Boolean IncludeTradeHistoryInBacktest { get; set; }
        /// <summary>
        /// Gets or sets the InitBarsSeriesIndex.
        /// </summary>
        [DataMember]
        public Index2BarsString InitBarsSeriesIndex { get; set; }
        /// <summary>
        /// Gets or sets the InstrumentOrInstrumentList.
        /// </summary>
        [DataMember]
        public String InstrumentOrInstrumentList { get; set; }
        /// <summary>
        /// Gets or sets the IsAdoptAccountPositionAware.
        /// </summary>
        [DataMember]
        public Boolean IsAdoptAccountPositionAware { get; set; }
        /// <summary>
        /// Gets or sets the IsAggregated.
        /// </summary>
        [DataMember]
        public Boolean IsAggregated { get; set; }
        /// <summary>
        /// Gets or sets the IsExitOnSessionCloseStrategy.
        /// </summary>
        [DataMember]
        public Boolean IsExitOnSessionCloseStrategy { get; set; }
        /// <summary>
        /// Gets or sets the IsFillLimitOnTouch.
        /// </summary>
        [DataMember]
        public Boolean IsFillLimitOnTouch { get; set; }
        /// <summary>
        /// Gets or sets the IsInstantiatedOnEachOptimizationIteration.
        /// </summary>
        [DataMember]
        public Boolean IsInstantiatedOnEachOptimizationIteration { get; set; }
        /// <summary>
        /// Gets or sets the IsOptimizeDataSeries.
        /// </summary>
        [DataMember]
        public Boolean IsOptimizeDataSeries { get; set; }
        /// <summary>
        /// Gets or sets the IsStableSession.
        /// </summary>
        [DataMember]
        public Boolean IsStableSession { get; set; }
        /// <summary>
        /// Gets or sets the IsTerminal.
        /// </summary>
        [DataMember]
        public Boolean IsTerminal { get; set; }
        /// <summary>
        /// Gets or sets the IsTickReplay.
        /// </summary>
        [DataMember]
        public Boolean IsTickReplay { get; set; }
        /// <summary>
        /// Gets or sets the IsTradingHoursBreakLineVisible.
        /// </summary>
        [DataMember]
        public Boolean IsTradingHoursBreakLineVisible { get; set; }
        /// <summary>
        /// Gets or sets the IsUnmanaged.
        /// </summary>
        [DataMember]
        public Boolean IsUnmanaged { get; set; }
        /// <summary>
        /// Gets or sets the IsWaitUntilFlat.
        /// </summary>
        [DataMember]
        public Boolean IsWaitUntilFlat { get; set; }
        /// <summary>
        /// Gets or sets the NumberRestartAttempts.
        /// </summary>
        [DataMember]
        public Int32 NumberRestartAttempts { get; set; }
        /// <summary>
        /// Gets or sets the Optimizer.
        /// </summary>
        [DataMember]
        public Optimizer Optimizer { get; set; }
        /// <summary>
        /// Gets or sets the OptimizationFitness.
        /// </summary>
        [DataMember]
        public OptimizationFitness OptimizationFitness { get; set; }
        /// <summary>
        /// Gets or sets the OptimizationParameters.
        /// </summary>
        [DataMember]
        public Collection<Parameter> OptimizationParameters { get; set; }
        /// <summary>
        /// Gets or sets the OptimizationPeriod.
        /// </summary>
        [DataMember]
        public Int32 OptimizationPeriod { get; set; }
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
        public Int32 OrderFillResolutionValue { get; set; }
        /// <summary>
        /// Gets or sets the InputsProvider.
        /// </summary>
        [DataMember]
        public IStrategyInputsProvider InputsProvider { get; set; }
        /// <summary>
        /// Gets or sets the PerformanceMetrics.
        /// </summary>
        [DataMember]
        public PerformanceMetricBase[] PerformanceMetrics { get; set; }
        /// <summary>
        /// Gets or sets the Position.
        /// </summary>
        [DataMember]
        public Position Position { get; set; }
        /// <summary>
        /// Gets or sets the PositionAccount.
        /// </summary>
        [DataMember]
        public Position PositionAccount { get; set; }
        /// <summary>
        /// Gets or sets the Positions.
        /// </summary>
        [DataMember]
        public Position[] Positions { get; set; }
        /// <summary>
        /// Gets or sets the PositionsAccount.
        /// </summary>
        [DataMember]
        public Position[] PositionsAccount { get; set; }
        /// <summary>
        /// Gets or sets the RealtimeErrorHandling.
        /// </summary>
        [DataMember]
        public RealtimeErrorHandling RealtimeErrorHandling { get; set; }
        /// <summary>
        /// Gets or sets the RestartsWithinMinutes.
        /// </summary>
        [DataMember]
        public Int32 RestartsWithinMinutes { get; set; }
        /// <summary>
        /// Gets or sets the SetOrderQuantity.
        /// </summary>
        [DataMember]
        public SetOrderQuantity SetOrderQuantity { get; set; }
        /// <summary>
        /// Gets or sets the Slippage.
        /// </summary>
        [DataMember]
        public Double Slippage { get; set; }
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
        public Boolean SupportsOptimizationGraph { get; set; }
        /// <summary>
        /// Gets or sets the SystemPerformance.
        /// </summary>
        [DataMember]
        public SystemPerformance SystemPerformance { get; set; }
        /// <summary>
        /// Gets or sets the TimeElapsedForOptimizer.
        /// </summary>
        [DataMember]
        public TimeSpan TimeElapsedForOptimizer { get; set; }
        /// <summary>
        /// Gets or sets the TestPeriod.
        /// </summary>
        [DataMember]
        public Int32 TestPeriod { get; set; }
        /// <summary>
        /// Gets or sets the TraceOrders.
        /// </summary>
        [DataMember]
        public Boolean TraceOrders { get; set; }
        /// <summary>
        /// Gets or sets the TradingHoursInstance.
        /// </summary>
        [DataMember]
        public TradingHours TradingHoursInstance { get; set; }
        /// <summary>
        /// Gets or sets the TradingHoursSerializable.
        /// </summary>
        [DataMember]
        public String TradingHoursSerializable { get; set; }
        /// <summary>
        /// Gets or sets the GeneratedStrategyLogic.
        /// </summary>
        [DataMember]
        public GeneratedStrategyLogicBase GeneratedStrategyLogic { get; set; }
        /// <summary>
        /// Gets or sets the ValidOrderFillResolutions.
        /// </summary>
        [DataMember]
        public List<BarsPeriodType> ValidOrderFillResolutions { get; set; }
        /// <summary>
        /// Gets or sets the Variable0.
        /// </summary>
        [DataMember]
        public Double Variable0 { get; set; }
        /// <summary>
        /// Gets or sets the Variable1.
        /// </summary>
        [DataMember]
        public Double Variable1 { get; set; }
        /// <summary>
        /// Gets or sets the Variable2.
        /// </summary>
        [DataMember]
        public Double Variable2 { get; set; }
        /// <summary>
        /// Gets or sets the Variable3.
        /// </summary>
        [DataMember]
        public Double Variable3 { get; set; }
        /// <summary>
        /// Gets or sets the Variable4.
        /// </summary>
        [DataMember]
        public Double Variable4 { get; set; }
        /// <summary>
        /// Gets or sets the Variable5.
        /// </summary>
        [DataMember]
        public Double Variable5 { get; set; }
        /// <summary>
        /// Gets or sets the Variable6.
        /// </summary>
        [DataMember]
        public Double Variable6 { get; set; }
        /// <summary>
        /// Gets or sets the Variable7.
        /// </summary>
        [DataMember]
        public Double Variable7 { get; set; }
        /// <summary>
        /// Gets or sets the Variable8.
        /// </summary>
        [DataMember]
        public Double Variable8 { get; set; }
        /// <summary>
        /// Gets or sets the Variable9.
        /// </summary>
        [DataMember]
        public Double Variable9 { get; set; }
        /// <summary>
        /// Gets or sets the WaitForOcoClosingBracket.
        /// </summary>
        [DataMember]
        public Boolean WaitForOcoClosingBracket { get; set; }
        /// <summary>
        /// Gets or sets the Workspace.
        /// </summary>
        [DataMember]
        public String Workspace { get; set; }
        /// <summary>
        /// Gets or sets the Account.
        /// </summary>
        [DataMember]
        public Account Account { get; set; }
        /// <summary>
        /// Gets or sets the All.
        /// </summary>
        [DataMember]
        public Collection<StrategyBase> All { get; set; }
        /// <summary>
        /// Gets or sets the Executions.
        /// </summary>
        [DataMember]
        public Collection<Execution> Executions { get; set; }
        /// <summary>
        /// Gets or sets the Gtd.
        /// </summary>
        [DataMember]
        public DateTime Gtd { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public Int64 Id { get; set; }
        /// <summary>
        /// Gets or sets the LogTypeName.
        /// </summary>
        [DataMember]
        public String LogTypeName { get; set; }
        /// <summary>
        /// Gets or sets the Orders.
        /// </summary>
        [DataMember]
        public Collection<Order> Orders { get; set; }
        /// <summary>
        /// Gets or sets the ServerId.
        /// </summary>
        [DataMember]
        public Int64 ServerId { get; set; }
        /// <summary>
        /// Gets or sets the Template.
        /// </summary>
        [DataMember]
        public String Template { get; set; }
        /// <summary>
        /// Gets or sets the TimeInForce.
        /// </summary>
        [DataMember]
        public TimeInForce TimeInForce { get; set; }
        /// <summary>
        /// Gets or sets the UserData.
        /// </summary>
        [DataMember]
        public XDocument UserData { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// AddChartIndicator method.
        /// </summary>
        /// <param name="indicator">IndicatorBase</param>
        public Void AddChartIndicator(IndicatorBase indicator);
        /// <summary>
        /// AddPerformanceMetric method.
        /// </summary>
        /// <param name="performanceMetric">PerformanceMetricBase</param>
        public Void AddPerformanceMetric(PerformanceMetricBase performanceMetric);
        /// <summary>
        /// BarsSinceEntryExecution method.
        /// </summary>
        /// <returns>Int32</returns>
        public Int32 BarsSinceEntryExecution();
        /// <summary>
        /// BarsSinceEntryExecution method.
        /// </summary>
        /// <param name="signalName">String</param>
        /// <returns>Int32</returns>
        public Int32 BarsSinceEntryExecution(String signalName);
        /// <summary>
        /// BarsSinceEntryExecution method.
        /// </summary>
        /// <param name="barsInProgressIndex">Int32</param>
        /// <param name="signalName">String</param>
        /// <param name="entryExecutionsAgo">Int32</param>
        /// <returns>Int32</returns>
        public Int32 BarsSinceEntryExecution(Int32 barsInProgressIndex, String signalName, Int32 entryExecutionsAgo);
        /// <summary>
        /// BarsSinceExitExecution method.
        /// </summary>
        /// <returns>Int32</returns>
        public Int32 BarsSinceExitExecution();
        /// <summary>
        /// BarsSinceExitExecution method.
        /// </summary>
        /// <param name="signalName">String</param>
        /// <returns>Int32</returns>
        public Int32 BarsSinceExitExecution(String signalName);
        /// <summary>
        /// BarsSinceExitExecution method.
        /// </summary>
        /// <param name="barsInProgressIndex">Int32</param>
        /// <param name="signalName">String</param>
        /// <param name="exitExecutionsAgo">Int32</param>
        /// <returns>Int32</returns>
        public Int32 BarsSinceExitExecution(Int32 barsInProgressIndex, String signalName, Int32 exitExecutionsAgo);
        /// <summary>
        /// CopyOrdersAndExecutionsTo method.
        /// </summary>
        /// <param name="strategyBase">StrategyBase</param>
        public Void CopyOrdersAndExecutionsTo(StrategyBase strategyBase);
        /// <summary>
        /// CreateNewGeneration method.
        /// </summary>
        /// <param name="copyOrdersAndExecutions">Boolean</param>
        /// <param name="inclTradeHistoryInBacktest">Nullable`1</param>
        /// <returns>StrategyBase</returns>
        public StrategyBase CreateNewGeneration(Boolean copyOrdersAndExecutions, Nullable<Boolean> inclTradeHistoryInBacktest);
        /// <summary>
        /// DbGet method.
        /// </summary>
        /// <param name="id">Int64</param>
        /// <returns>StrategyBase</returns>
        public StrategyBase DbGet(Int64 id);
        /// <summary>
        /// DbRemove method.
        /// </summary>
        public Void DbRemove();
        /// <summary>
        /// DbRemoveByCategory method.
        /// </summary>
        /// <param name="category">Category</param>
        /// <param name="useMailDB">Boolean</param>
        public Void DbRemoveByCategory(Category category, Boolean useMailDB);
        /// <summary>
        /// EnterReadLock method.
        /// </summary>
        /// <returns>List`1</returns>
        public List<BarsSeries> EnterReadLock();
        /// <summary>
        /// ExitReadLock method.
        /// </summary>
        /// <param name="readLockList">List`1</param>
        public Void ExitReadLock(List<BarsSeries> readLockList);
        /// <summary>
        /// GetQuantity method.
        /// </summary>
        /// <param name="marketPosition">MarketPosition</param>
        /// <param name="quantity">Int32</param>
        /// <returns>Int32</returns>
        public Int32 GetQuantity(MarketPosition marketPosition, Int32 quantity);
        /// <summary>
        /// GetRealtimeOrder method.
        /// </summary>
        /// <param name="historicalOrder">Order</param>
        /// <returns>Order</returns>
        public Order GetRealtimeOrder(Order historicalOrder);
        /// <summary>
        /// GetTradingHours method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        /// <returns>TradingHours</returns>
        public TradingHours GetTradingHours(Instrument instrument);
        /// <summary>
        /// MergePerformance method.
        /// </summary>
        /// <param name="performance">SystemPerformance</param>
        public Void MergePerformance(SystemPerformance performance);
        /// <summary>
        /// RunBacktest method.
        /// </summary>
        public Void RunBacktest();
        /// <summary>
        /// RunOptimization method.
        /// </summary>
        /// <param name="callback">Action`1</param>
        public Void RunOptimization(Action<StrategyBase> callback);
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>String</returns>
        public String ToString();
        /// <summary>
        /// AddExecution method.
        /// </summary>
        /// <param name="position">Position</param>
        /// <param name="execution">Execution</param>
        /// <param name="order">Order</param>
        public Void AddExecution(Position position, Execution execution, Order order);
        /// <summary>
        /// CancelOrder method.
        /// </summary>
        /// <param name="order">Order</param>
        public Void CancelOrder(Order order);
        /// <summary>
        /// ChangeOrder method.
        /// </summary>
        /// <param name="order">Order</param>
        /// <param name="quantity">Int32</param>
        /// <param name="limitPrice">Double</param>
        /// <param name="stopPrice">Double</param>
        public Void ChangeOrder(Order order, Int32 quantity, Double limitPrice, Double stopPrice);
        /// <summary>
        /// CloseStrategy method.
        /// </summary>
        /// <param name="signalName">String</param>
        public Void CloseStrategy(String signalName);
        /// <summary>
        /// EnterLong method.
        /// </summary>
        /// <returns>Order</returns>
        public Order EnterLong();
        /// <summary>
        /// EnterLong method.
        /// </summary>
        /// <param name="signalName">String</param>
        /// <returns>Order</returns>
        public Order EnterLong(String signalName);
        /// <summary>
        /// EnterLong method.
        /// </summary>
        /// <param name="quantity">Int32</param>
        /// <returns>Order</returns>
        public Order EnterLong(Int32 quantity);
        /// <summary>
        /// EnterLong method.
        /// </summary>
        /// <param name="quantity">Int32</param>
        /// <param name="signalName">String</param>
        /// <returns>Order</returns>
        public Order EnterLong(Int32 quantity, String signalName);
        /// <summary>
        /// EnterLong method.
        /// </summary>
        /// <param name="barsInProgressIndex">Int32</param>
        /// <param name="quantity">Int32</param>
        /// <param name="signalName">String</param>
        /// <returns>Order</returns>
        public Order EnterLong(Int32 barsInProgressIndex, Int32 quantity, String signalName);
        /// <summary>
        /// EnterLongLimit method.
        /// </summary>
        /// <param name="limitPrice">Double</param>
        /// <returns>Order</returns>
        public Order EnterLongLimit(Double limitPrice);
        /// <summary>
        /// EnterLongLimit method.
        /// </summary>
        /// <param name="limitPrice">Double</param>
        /// <param name="signalName">String</param>
        /// <returns>Order</returns>
        public Order EnterLongLimit(Double limitPrice, String signalName);
        /// <summary>
        /// EnterLongLimit method.
        /// </summary>
        /// <param name="quantity">Int32</param>
        /// <param name="limitPrice">Double</param>
        /// <returns>Order</returns>
        public Order EnterLongLimit(Int32 quantity, Double limitPrice);
        /// <summary>
        /// EnterLongLimit method.
        /// </summary>
        /// <param name="quantity">Int32</param>
        /// <param name="limitPrice">Double</param>
        /// <param name="signalName">String</param>
        /// <returns>Order</returns>
        public Order EnterLongLimit(Int32 quantity, Double limitPrice, String signalName);
        /// <summary>
        /// EnterLongLimit method.
        /// </summary>
        /// <param name="barsInProgressIndex">Int32</param>
        /// <param name="isLiveUntilCancelled">Boolean</param>
        /// <param name="quantity">Int32</param>
        /// <param name="limitPrice">Double</param>
        /// <param name="signalName">String</param>
        /// <returns>Order</returns>
        public Order EnterLongLimit(Int32 barsInProgressIndex, Boolean isLiveUntilCancelled, Int32 quantity, Double limitPrice, String signalName);
        /// <summary>
        /// EnterLongMIT method.
        /// </summary>
        /// <param name="stopPrice">Double</param>
        /// <returns>Order</returns>
        public Order EnterLongMIT(Double stopPrice);
        /// <summary>
        /// EnterLongMIT method.
        /// </summary>
        /// <param name="stopPrice">Double</param>
        /// <param name="signalName">String</param>
        /// <returns>Order</returns>
        public Order EnterLongMIT(Double stopPrice, String signalName);
        /// <summary>
        /// EnterLongMIT method.
        /// </summary>
        /// <param name="quantity">Int32</param>
        /// <param name="stopPrice">Double</param>
        /// <returns>Order</returns>
        public Order EnterLongMIT(Int32 quantity, Double stopPrice);
        /// <summary>
        /// EnterLongMIT method.
        /// </summary>
        /// <param name="quantity">Int32</param>
        /// <param name="stopPrice">Double</param>
        /// <param name="signalName">String</param>
        /// <returns>Order</returns>
        public Order EnterLongMIT(Int32 quantity, Double stopPrice, String signalName);
        /// <summary>
        /// EnterLongMIT method.
        /// </summary>
        /// <param name="barsInProgressIndex">Int32</param>
        /// <param name="isLiveUntilCancelled">Boolean</param>
        /// <param name="quantity">Int32</param>
        /// <param name="stopPrice">Double</param>
        /// <param name="signalName">String</param>
        /// <returns>Order</returns>
        public Order EnterLongMIT(Int32 barsInProgressIndex, Boolean isLiveUntilCancelled, Int32 quantity, Double stopPrice, String signalName);
        /// <summary>
        /// EnterLongStopLimit method.
        /// </summary>
        /// <param name="limitPrice">Double</param>
        /// <param name="stopPrice">Double</param>
        /// <returns>Order</returns>
        public Order EnterLongStopLimit(Double limitPrice, Double stopPrice);
        /// <summary>
        /// EnterLongStopLimit method.
        /// </summary>
        /// <param name="limitPrice">Double</param>
        /// <param name="stopPrice">Double</param>
        /// <param name="signalName">String</param>
        /// <returns>Order</returns>
        public Order EnterLongStopLimit(Double limitPrice, Double stopPrice, String signalName);
        /// <summary>
        /// EnterLongStopLimit method.
        /// </summary>
        /// <param name="quantity">Int32</param>
        /// <param name="limitPrice">Double</param>
        /// <param name="stopPrice">Double</param>
        /// <returns>Order</returns>
        public Order EnterLongStopLimit(Int32 quantity, Double limitPrice, Double stopPrice);
        /// <summary>
        /// EnterLongStopLimit method.
        /// </summary>
        /// <param name="quantity">Int32</param>
        /// <param name="limitPrice">Double</param>
        /// <param name="stopPrice">Double</param>
        /// <param name="signalName">String</param>
        /// <returns>Order</returns>
        public Order EnterLongStopLimit(Int32 quantity, Double limitPrice, Double stopPrice, String signalName);
        /// <summary>
        /// EnterLongStopLimit method.
        /// </summary>
        /// <param name="barsInProgressIndex">Int32</param>
        /// <param name="isLiveUntilCancelled">Boolean</param>
        /// <param name="quantity">Int32</param>
        /// <param name="limitPrice">Double</param>
        /// <param name="stopPrice">Double</param>
        /// <param name="signalName">String</param>
        /// <returns>Order</returns>
        public Order EnterLongStopLimit(Int32 barsInProgressIndex, Boolean isLiveUntilCancelled, Int32 quantity, Double limitPrice, Double stopPrice, String signalName);
        /// <summary>
        /// EnterLongStopMarket method.
        /// </summary>
        /// <param name="stopPrice">Double</param>
        /// <returns>Order</returns>
        public Order EnterLongStopMarket(Double stopPrice);
        /// <summary>
        /// EnterLongStopMarket method.
        /// </summary>
        /// <param name="stopPrice">Double</param>
        /// <param name="signalName">String</param>
        /// <returns>Order</returns>
        public Order EnterLongStopMarket(Double stopPrice, String signalName);
        /// <summary>
        /// EnterLongStopMarket method.
        /// </summary>
        /// <param name="quantity">Int32</param>
        /// <param name="stopPrice">Double</param>
        /// <returns>Order</returns>
        public Order EnterLongStopMarket(Int32 quantity, Double stopPrice);
        /// <summary>
        /// EnterLongStopMarket method.
        /// </summary>
        /// <param name="quantity">Int32</param>
        /// <param name="stopPrice">Double</param>
        /// <param name="signalName">String</param>
        /// <returns>Order</returns>
        public Order EnterLongStopMarket(Int32 quantity, Double stopPrice, String signalName);
        /// <summary>
        /// EnterLongStopMarket method.
        /// </summary>
        /// <param name="barsInProgressIndex">Int32</param>
        /// <param name="isLiveUntilCancelled">Boolean</param>
        /// <param name="quantity">Int32</param>
        /// <param name="stopPrice">Double</param>
        /// <param name="signalName">String</param>
        /// <returns>Order</returns>
        public Order EnterLongStopMarket(Int32 barsInProgressIndex, Boolean isLiveUntilCancelled, Int32 quantity, Double stopPrice, String signalName);
        /// <summary>
        /// EnterShort method.
        /// </summary>
        /// <returns>Order</returns>
        public Order EnterShort();
        /// <summary>
        /// EnterShort method.
        /// </summary>
        /// <param name="signalName">String</param>
        /// <returns>Order</returns>
        public Order EnterShort(String signalName);
        /// <summary>
        /// EnterShort method.
        /// </summary>
        /// <param name="quantity">Int32</param>
        /// <returns>Order</returns>
        public Order EnterShort(Int32 quantity);
        /// <summary>
        /// EnterShort method.
        /// </summary>
        /// <param name="quantity">Int32</param>
        /// <param name="signalName">String</param>
        /// <returns>Order</returns>
        public Order EnterShort(Int32 quantity, String signalName);
        /// <summary>
        /// EnterShort method.
        /// </summary>
        /// <param name="barsInProgressIndex">Int32</param>
        /// <param name="quantity">Int32</param>
        /// <param name="signalName">String</param>
        /// <returns>Order</returns>
        public Order EnterShort(Int32 barsInProgressIndex, Int32 quantity, String signalName);
        /// <summary>
        /// EnterShortLimit method.
        /// </summary>
        /// <param name="limitPrice">Double</param>
        /// <returns>Order</returns>
        public Order EnterShortLimit(Double limitPrice);
        /// <summary>
        /// EnterShortLimit method.
        /// </summary>
        /// <param name="limitPrice">Double</param>
        /// <param name="signalName">String</param>
        /// <returns>Order</returns>
        public Order EnterShortLimit(Double limitPrice, String signalName);
        /// <summary>
        /// EnterShortLimit method.
        /// </summary>
        /// <param name="quantity">Int32</param>
        /// <param name="limitPrice">Double</param>
        /// <returns>Order</returns>
        public Order EnterShortLimit(Int32 quantity, Double limitPrice);
        /// <summary>
        /// EnterShortLimit method.
        /// </summary>
        /// <param name="quantity">Int32</param>
        /// <param name="limitPrice">Double</param>
        /// <param name="signalName">String</param>
        /// <returns>Order</returns>
        public Order EnterShortLimit(Int32 quantity, Double limitPrice, String signalName);
        /// <summary>
        /// EnterShortLimit method.
        /// </summary>
        /// <param name="barsInProgressIndex">Int32</param>
        /// <param name="isLiveUntilCancelled">Boolean</param>
        /// <param name="quantity">Int32</param>
        /// <param name="limitPrice">Double</param>
        /// <param name="signalName">String</param>
        /// <returns>Order</returns>
        public Order EnterShortLimit(Int32 barsInProgressIndex, Boolean isLiveUntilCancelled, Int32 quantity, Double limitPrice, String signalName);
        /// <summary>
        /// EnterShortMIT method.
        /// </summary>
        /// <param name="stopPrice">Double</param>
        /// <returns>Order</returns>
        public Order EnterShortMIT(Double stopPrice);
        /// <summary>
        /// EnterShortMIT method.
        /// </summary>
        /// <param name="stopPrice">Double</param>
        /// <param name="signalName">String</param>
        /// <returns>Order</returns>
        public Order EnterShortMIT(Double stopPrice, String signalName);
        /// <summary>
        /// EnterShortMIT method.
        /// </summary>
        /// <param name="quantity">Int32</param>
        /// <param name="stopPrice">Double</param>
        /// <returns>Order</returns>
        public Order EnterShortMIT(Int32 quantity, Double stopPrice);
        /// <summary>
        /// EnterShortMIT method.
        /// </summary>
        /// <param name="quantity">Int32</param>
        /// <param name="stopPrice">Double</param>
        /// <param name="signalName">String</param>
        /// <returns>Order</returns>
        public Order EnterShortMIT(Int32 quantity, Double stopPrice, String signalName);
        /// <summary>
        /// EnterShortMIT method.
        /// </summary>
        /// <param name="barsInProgressIndex">Int32</param>
        /// <param name="isLiveUntilCancelled">Boolean</param>
        /// <param name="quantity">Int32</param>
        /// <param name="stopPrice">Double</param>
        /// <param name="signalName">String</param>
        /// <returns>Order</returns>
        public Order EnterShortMIT(Int32 barsInProgressIndex, Boolean isLiveUntilCancelled, Int32 quantity, Double stopPrice, String signalName);
        /// <summary>
        /// EnterShortStopLimit method.
        /// </summary>
        /// <param name="limitPrice">Double</param>
        /// <param name="stopPrice">Double</param>
        /// <returns>Order</returns>
        public Order EnterShortStopLimit(Double limitPrice, Double stopPrice);
        /// <summary>
        /// EnterShortStopLimit method.
        /// </summary>
        /// <param name="limitPrice">Double</param>
        /// <param name="stopPrice">Double</param>
        /// <param name="signalName">String</param>
        /// <returns>Order</returns>
        public Order EnterShortStopLimit(Double limitPrice, Double stopPrice, String signalName);
        /// <summary>
        /// EnterShortStopLimit method.
        /// </summary>
        /// <param name="quantity">Int32</param>
        /// <param name="limitPrice">Double</param>
        /// <param name="stopPrice">Double</param>
        /// <returns>Order</returns>
        public Order EnterShortStopLimit(Int32 quantity, Double limitPrice, Double stopPrice);
        /// <summary>
        /// EnterShortStopLimit method.
        /// </summary>
        /// <param name="quantity">Int32</param>
        /// <param name="limitPrice">Double</param>
        /// <param name="stopPrice">Double</param>
        /// <param name="signalName">String</param>
        /// <returns>Order</returns>
        public Order EnterShortStopLimit(Int32 quantity, Double limitPrice, Double stopPrice, String signalName);
        /// <summary>
        /// EnterShortStopLimit method.
        /// </summary>
        /// <param name="barsInProgressIndex">Int32</param>
        /// <param name="isLiveUntilCancelled">Boolean</param>
        /// <param name="quantity">Int32</param>
        /// <param name="limitPrice">Double</param>
        /// <param name="stopPrice">Double</param>
        /// <param name="signalName">String</param>
        /// <returns>Order</returns>
        public Order EnterShortStopLimit(Int32 barsInProgressIndex, Boolean isLiveUntilCancelled, Int32 quantity, Double limitPrice, Double stopPrice, String signalName);
        /// <summary>
        /// EnterShortStopMarket method.
        /// </summary>
        /// <param name="stopPrice">Double</param>
        /// <returns>Order</returns>
        public Order EnterShortStopMarket(Double stopPrice);
        /// <summary>
        /// EnterShortStopMarket method.
        /// </summary>
        /// <param name="stopPrice">Double</param>
        /// <param name="signalName">String</param>
        /// <returns>Order</returns>
        public Order EnterShortStopMarket(Double stopPrice, String signalName);
        /// <summary>
        /// EnterShortStopMarket method.
        /// </summary>
        /// <param name="quantity">Int32</param>
        /// <param name="stopPrice">Double</param>
        /// <returns>Order</returns>
        public Order EnterShortStopMarket(Int32 quantity, Double stopPrice);
        /// <summary>
        /// EnterShortStopMarket method.
        /// </summary>
        /// <param name="quantity">Int32</param>
        /// <param name="stopPrice">Double</param>
        /// <param name="signalName">String</param>
        /// <returns>Order</returns>
        public Order EnterShortStopMarket(Int32 quantity, Double stopPrice, String signalName);
        /// <summary>
        /// EnterShortStopMarket method.
        /// </summary>
        /// <param name="barsInProgressIndex">Int32</param>
        /// <param name="isLiveUntilCancelled">Boolean</param>
        /// <param name="quantity">Int32</param>
        /// <param name="stopPrice">Double</param>
        /// <param name="signalName">String</param>
        /// <returns>Order</returns>
        public Order EnterShortStopMarket(Int32 barsInProgressIndex, Boolean isLiveUntilCancelled, Int32 quantity, Double stopPrice, String signalName);
        /// <summary>
        /// ExitLong method.
        /// </summary>
        /// <returns>Order</returns>
        public Order ExitLong();
        /// <summary>
        /// ExitLong method.
        /// </summary>
        /// <param name="quantity">Int32</param>
        /// <returns>Order</returns>
        public Order ExitLong(Int32 quantity);
        /// <summary>
        /// ExitLong method.
        /// </summary>
        /// <param name="fromEntrySignal">String</param>
        /// <returns>Order</returns>
        public Order ExitLong(String fromEntrySignal);
        /// <summary>
        /// ExitLong method.
        /// </summary>
        /// <param name="signalName">String</param>
        /// <param name="fromEntrySignal">String</param>
        /// <returns>Order</returns>
        public Order ExitLong(String signalName, String fromEntrySignal);
        /// <summary>
        /// ExitLong method.
        /// </summary>
        /// <param name="quantity">Int32</param>
        /// <param name="signalName">String</param>
        /// <param name="fromEntrySignal">String</param>
        /// <returns>Order</returns>
        public Order ExitLong(Int32 quantity, String signalName, String fromEntrySignal);
        /// <summary>
        /// ExitLong method.
        /// </summary>
        /// <param name="barsInProgressIndex">Int32</param>
        /// <param name="quantity">Int32</param>
        /// <param name="signalName">String</param>
        /// <param name="fromEntrySignal">String</param>
        /// <returns>Order</returns>
        public Order ExitLong(Int32 barsInProgressIndex, Int32 quantity, String signalName, String fromEntrySignal);
        /// <summary>
        /// ExitLongLimit method.
        /// </summary>
        /// <param name="limitPrice">Double</param>
        /// <returns>Order</returns>
        public Order ExitLongLimit(Double limitPrice);
        /// <summary>
        /// ExitLongLimit method.
        /// </summary>
        /// <param name="quantity">Int32</param>
        /// <param name="limitPrice">Double</param>
        /// <returns>Order</returns>
        public Order ExitLongLimit(Int32 quantity, Double limitPrice);
        /// <summary>
        /// ExitLongLimit method.
        /// </summary>
        /// <param name="limitPrice">Double</param>
        /// <param name="fromEntrySignal">String</param>
        /// <returns>Order</returns>
        public Order ExitLongLimit(Double limitPrice, String fromEntrySignal);
        /// <summary>
        /// ExitLongLimit method.
        /// </summary>
        /// <param name="limitPrice">Double</param>
        /// <param name="signalName">String</param>
        /// <param name="fromEntrySignal">String</param>
        /// <returns>Order</returns>
        public Order ExitLongLimit(Double limitPrice, String signalName, String fromEntrySignal);
        /// <summary>
        /// ExitLongLimit method.
        /// </summary>
        /// <param name="quantity">Int32</param>
        /// <param name="limitPrice">Double</param>
        /// <param name="signalName">String</param>
        /// <param name="fromEntrySignal">String</param>
        /// <returns>Order</returns>
        public Order ExitLongLimit(Int32 quantity, Double limitPrice, String signalName, String fromEntrySignal);
        /// <summary>
        /// ExitLongLimit method.
        /// </summary>
        /// <param name="barsInProgressIndex">Int32</param>
        /// <param name="isLiveUntilCancelled">Boolean</param>
        /// <param name="quantity">Int32</param>
        /// <param name="limitPrice">Double</param>
        /// <param name="signalName">String</param>
        /// <param name="fromEntrySignal">String</param>
        /// <returns>Order</returns>
        public Order ExitLongLimit(Int32 barsInProgressIndex, Boolean isLiveUntilCancelled, Int32 quantity, Double limitPrice, String signalName, String fromEntrySignal);
        /// <summary>
        /// ExitLongMIT method.
        /// </summary>
        /// <param name="stopPrice">Double</param>
        /// <returns>Order</returns>
        public Order ExitLongMIT(Double stopPrice);
        /// <summary>
        /// ExitLongMIT method.
        /// </summary>
        /// <param name="quantity">Int32</param>
        /// <param name="stopPrice">Double</param>
        /// <returns>Order</returns>
        public Order ExitLongMIT(Int32 quantity, Double stopPrice);
        /// <summary>
        /// ExitLongMIT method.
        /// </summary>
        /// <param name="stopPrice">Double</param>
        /// <param name="fromEntrySignal">String</param>
        /// <returns>Order</returns>
        public Order ExitLongMIT(Double stopPrice, String fromEntrySignal);
        /// <summary>
        /// ExitLongMIT method.
        /// </summary>
        /// <param name="stopPrice">Double</param>
        /// <param name="signalName">String</param>
        /// <param name="fromEntrySignal">String</param>
        /// <returns>Order</returns>
        public Order ExitLongMIT(Double stopPrice, String signalName, String fromEntrySignal);
        /// <summary>
        /// ExitLongMIT method.
        /// </summary>
        /// <param name="quantity">Int32</param>
        /// <param name="stopPrice">Double</param>
        /// <param name="signalName">String</param>
        /// <param name="fromEntrySignal">String</param>
        /// <returns>Order</returns>
        public Order ExitLongMIT(Int32 quantity, Double stopPrice, String signalName, String fromEntrySignal);
        /// <summary>
        /// ExitLongMIT method.
        /// </summary>
        /// <param name="barsInProgressIndex">Int32</param>
        /// <param name="isLiveUntilCancelled">Boolean</param>
        /// <param name="quantity">Int32</param>
        /// <param name="stopPrice">Double</param>
        /// <param name="signalName">String</param>
        /// <param name="fromEntrySignal">String</param>
        /// <returns>Order</returns>
        public Order ExitLongMIT(Int32 barsInProgressIndex, Boolean isLiveUntilCancelled, Int32 quantity, Double stopPrice, String signalName, String fromEntrySignal);
        /// <summary>
        /// ExitLongStopLimit method.
        /// </summary>
        /// <param name="limitPrice">Double</param>
        /// <param name="stopPrice">Double</param>
        /// <returns>Order</returns>
        public Order ExitLongStopLimit(Double limitPrice, Double stopPrice);
        /// <summary>
        /// ExitLongStopLimit method.
        /// </summary>
        /// <param name="quantity">Int32</param>
        /// <param name="limitPrice">Double</param>
        /// <param name="stopPrice">Double</param>
        /// <returns>Order</returns>
        public Order ExitLongStopLimit(Int32 quantity, Double limitPrice, Double stopPrice);
        /// <summary>
        /// ExitLongStopLimit method.
        /// </summary>
        /// <param name="limitPrice">Double</param>
        /// <param name="stopPrice">Double</param>
        /// <param name="fromEntrySignal">String</param>
        /// <returns>Order</returns>
        public Order ExitLongStopLimit(Double limitPrice, Double stopPrice, String fromEntrySignal);
        /// <summary>
        /// ExitLongStopLimit method.
        /// </summary>
        /// <param name="limitPrice">Double</param>
        /// <param name="stopPrice">Double</param>
        /// <param name="signalName">String</param>
        /// <param name="fromEntrySignal">String</param>
        /// <returns>Order</returns>
        public Order ExitLongStopLimit(Double limitPrice, Double stopPrice, String signalName, String fromEntrySignal);
        /// <summary>
        /// ExitLongStopLimit method.
        /// </summary>
        /// <param name="quantity">Int32</param>
        /// <param name="limitPrice">Double</param>
        /// <param name="stopPrice">Double</param>
        /// <param name="signalName">String</param>
        /// <param name="fromEntrySignal">String</param>
        /// <returns>Order</returns>
        public Order ExitLongStopLimit(Int32 quantity, Double limitPrice, Double stopPrice, String signalName, String fromEntrySignal);
        /// <summary>
        /// ExitLongStopLimit method.
        /// </summary>
        /// <param name="barsInProgressIndex">Int32</param>
        /// <param name="isLiveUntilCancelled">Boolean</param>
        /// <param name="quantity">Int32</param>
        /// <param name="limitPrice">Double</param>
        /// <param name="stopPrice">Double</param>
        /// <param name="signalName">String</param>
        /// <param name="fromEntrySignal">String</param>
        /// <returns>Order</returns>
        public Order ExitLongStopLimit(Int32 barsInProgressIndex, Boolean isLiveUntilCancelled, Int32 quantity, Double limitPrice, Double stopPrice, String signalName, String fromEntrySignal);
        /// <summary>
        /// ExitLongStopMarket method.
        /// </summary>
        /// <param name="stopPrice">Double</param>
        /// <returns>Order</returns>
        public Order ExitLongStopMarket(Double stopPrice);
        /// <summary>
        /// ExitLongStopMarket method.
        /// </summary>
        /// <param name="quantity">Int32</param>
        /// <param name="stopPrice">Double</param>
        /// <returns>Order</returns>
        public Order ExitLongStopMarket(Int32 quantity, Double stopPrice);
        /// <summary>
        /// ExitLongStopMarket method.
        /// </summary>
        /// <param name="stopPrice">Double</param>
        /// <param name="fromEntrySignal">String</param>
        /// <returns>Order</returns>
        public Order ExitLongStopMarket(Double stopPrice, String fromEntrySignal);
        /// <summary>
        /// ExitLongStopMarket method.
        /// </summary>
        /// <param name="stopPrice">Double</param>
        /// <param name="signalName">String</param>
        /// <param name="fromEntrySignal">String</param>
        /// <returns>Order</returns>
        public Order ExitLongStopMarket(Double stopPrice, String signalName, String fromEntrySignal);
        /// <summary>
        /// ExitLongStopMarket method.
        /// </summary>
        /// <param name="quantity">Int32</param>
        /// <param name="stopPrice">Double</param>
        /// <param name="signalName">String</param>
        /// <param name="fromEntrySignal">String</param>
        /// <returns>Order</returns>
        public Order ExitLongStopMarket(Int32 quantity, Double stopPrice, String signalName, String fromEntrySignal);
        /// <summary>
        /// ExitLongStopMarket method.
        /// </summary>
        /// <param name="barsInProgressIndex">Int32</param>
        /// <param name="isLiveUntilCancelled">Boolean</param>
        /// <param name="quantity">Int32</param>
        /// <param name="stopPrice">Double</param>
        /// <param name="signalName">String</param>
        /// <param name="fromEntrySignal">String</param>
        /// <returns>Order</returns>
        public Order ExitLongStopMarket(Int32 barsInProgressIndex, Boolean isLiveUntilCancelled, Int32 quantity, Double stopPrice, String signalName, String fromEntrySignal);
        /// <summary>
        /// ExitShort method.
        /// </summary>
        /// <returns>Order</returns>
        public Order ExitShort();
        /// <summary>
        /// ExitShort method.
        /// </summary>
        /// <param name="quantity">Int32</param>
        /// <returns>Order</returns>
        public Order ExitShort(Int32 quantity);
        /// <summary>
        /// ExitShort method.
        /// </summary>
        /// <param name="fromEntrySignal">String</param>
        /// <returns>Order</returns>
        public Order ExitShort(String fromEntrySignal);
        /// <summary>
        /// ExitShort method.
        /// </summary>
        /// <param name="signalName">String</param>
        /// <param name="fromEntrySignal">String</param>
        /// <returns>Order</returns>
        public Order ExitShort(String signalName, String fromEntrySignal);
        /// <summary>
        /// ExitShort method.
        /// </summary>
        /// <param name="quantity">Int32</param>
        /// <param name="signalName">String</param>
        /// <param name="fromEntrySignal">String</param>
        /// <returns>Order</returns>
        public Order ExitShort(Int32 quantity, String signalName, String fromEntrySignal);
        /// <summary>
        /// ExitShort method.
        /// </summary>
        /// <param name="barsInProgressIndex">Int32</param>
        /// <param name="quantity">Int32</param>
        /// <param name="signalName">String</param>
        /// <param name="fromEntrySignal">String</param>
        /// <returns>Order</returns>
        public Order ExitShort(Int32 barsInProgressIndex, Int32 quantity, String signalName, String fromEntrySignal);
        /// <summary>
        /// ExitShortLimit method.
        /// </summary>
        /// <param name="limitPrice">Double</param>
        /// <returns>Order</returns>
        public Order ExitShortLimit(Double limitPrice);
        /// <summary>
        /// ExitShortLimit method.
        /// </summary>
        /// <param name="quantity">Int32</param>
        /// <param name="limitPrice">Double</param>
        /// <returns>Order</returns>
        public Order ExitShortLimit(Int32 quantity, Double limitPrice);
        /// <summary>
        /// ExitShortLimit method.
        /// </summary>
        /// <param name="limitPrice">Double</param>
        /// <param name="fromEntrySignal">String</param>
        /// <returns>Order</returns>
        public Order ExitShortLimit(Double limitPrice, String fromEntrySignal);
        /// <summary>
        /// ExitShortLimit method.
        /// </summary>
        /// <param name="limitPrice">Double</param>
        /// <param name="signalName">String</param>
        /// <param name="fromEntrySignal">String</param>
        /// <returns>Order</returns>
        public Order ExitShortLimit(Double limitPrice, String signalName, String fromEntrySignal);
        /// <summary>
        /// ExitShortLimit method.
        /// </summary>
        /// <param name="quantity">Int32</param>
        /// <param name="limitPrice">Double</param>
        /// <param name="signalName">String</param>
        /// <param name="fromEntrySignal">String</param>
        /// <returns>Order</returns>
        public Order ExitShortLimit(Int32 quantity, Double limitPrice, String signalName, String fromEntrySignal);
        /// <summary>
        /// ExitShortLimit method.
        /// </summary>
        /// <param name="barsInProgressIndex">Int32</param>
        /// <param name="isLiveUntilCancelled">Boolean</param>
        /// <param name="quantity">Int32</param>
        /// <param name="limitPrice">Double</param>
        /// <param name="signalName">String</param>
        /// <param name="fromEntrySignal">String</param>
        /// <returns>Order</returns>
        public Order ExitShortLimit(Int32 barsInProgressIndex, Boolean isLiveUntilCancelled, Int32 quantity, Double limitPrice, String signalName, String fromEntrySignal);
        /// <summary>
        /// ExitShortMIT method.
        /// </summary>
        /// <param name="stopPrice">Double</param>
        /// <returns>Order</returns>
        public Order ExitShortMIT(Double stopPrice);
        /// <summary>
        /// ExitShortMIT method.
        /// </summary>
        /// <param name="quantity">Int32</param>
        /// <param name="stopPrice">Double</param>
        /// <returns>Order</returns>
        public Order ExitShortMIT(Int32 quantity, Double stopPrice);
        /// <summary>
        /// ExitShortMIT method.
        /// </summary>
        /// <param name="stopPrice">Double</param>
        /// <param name="fromEntrySignal">String</param>
        /// <returns>Order</returns>
        public Order ExitShortMIT(Double stopPrice, String fromEntrySignal);
        /// <summary>
        /// ExitShortMIT method.
        /// </summary>
        /// <param name="stopPrice">Double</param>
        /// <param name="signalName">String</param>
        /// <param name="fromEntrySignal">String</param>
        /// <returns>Order</returns>
        public Order ExitShortMIT(Double stopPrice, String signalName, String fromEntrySignal);
        /// <summary>
        /// ExitShortMIT method.
        /// </summary>
        /// <param name="quantity">Int32</param>
        /// <param name="stopPrice">Double</param>
        /// <param name="signalName">String</param>
        /// <param name="fromEntrySignal">String</param>
        /// <returns>Order</returns>
        public Order ExitShortMIT(Int32 quantity, Double stopPrice, String signalName, String fromEntrySignal);
        /// <summary>
        /// ExitShortMIT method.
        /// </summary>
        /// <param name="barsInProgressIndex">Int32</param>
        /// <param name="isLiveUntilCancelled">Boolean</param>
        /// <param name="quantity">Int32</param>
        /// <param name="stopPrice">Double</param>
        /// <param name="signalName">String</param>
        /// <param name="fromEntrySignal">String</param>
        /// <returns>Order</returns>
        public Order ExitShortMIT(Int32 barsInProgressIndex, Boolean isLiveUntilCancelled, Int32 quantity, Double stopPrice, String signalName, String fromEntrySignal);
        /// <summary>
        /// ExitShortStopLimit method.
        /// </summary>
        /// <param name="limitPrice">Double</param>
        /// <param name="stopPrice">Double</param>
        /// <returns>Order</returns>
        public Order ExitShortStopLimit(Double limitPrice, Double stopPrice);
        /// <summary>
        /// ExitShortStopLimit method.
        /// </summary>
        /// <param name="quantity">Int32</param>
        /// <param name="limitPrice">Double</param>
        /// <param name="stopPrice">Double</param>
        /// <returns>Order</returns>
        public Order ExitShortStopLimit(Int32 quantity, Double limitPrice, Double stopPrice);
        /// <summary>
        /// ExitShortStopLimit method.
        /// </summary>
        /// <param name="limitPrice">Double</param>
        /// <param name="stopPrice">Double</param>
        /// <param name="fromEntrySignal">String</param>
        /// <returns>Order</returns>
        public Order ExitShortStopLimit(Double limitPrice, Double stopPrice, String fromEntrySignal);
        /// <summary>
        /// ExitShortStopLimit method.
        /// </summary>
        /// <param name="limitPrice">Double</param>
        /// <param name="stopPrice">Double</param>
        /// <param name="signalName">String</param>
        /// <param name="fromEntrySignal">String</param>
        /// <returns>Order</returns>
        public Order ExitShortStopLimit(Double limitPrice, Double stopPrice, String signalName, String fromEntrySignal);
        /// <summary>
        /// ExitShortStopLimit method.
        /// </summary>
        /// <param name="quantity">Int32</param>
        /// <param name="limitPrice">Double</param>
        /// <param name="stopPrice">Double</param>
        /// <param name="signalName">String</param>
        /// <param name="fromEntrySignal">String</param>
        /// <returns>Order</returns>
        public Order ExitShortStopLimit(Int32 quantity, Double limitPrice, Double stopPrice, String signalName, String fromEntrySignal);
        /// <summary>
        /// ExitShortStopLimit method.
        /// </summary>
        /// <param name="barsInProgressIndex">Int32</param>
        /// <param name="isLiveUntilCancelled">Boolean</param>
        /// <param name="quantity">Int32</param>
        /// <param name="limitPrice">Double</param>
        /// <param name="stopPrice">Double</param>
        /// <param name="signalName">String</param>
        /// <param name="fromEntrySignal">String</param>
        /// <returns>Order</returns>
        public Order ExitShortStopLimit(Int32 barsInProgressIndex, Boolean isLiveUntilCancelled, Int32 quantity, Double limitPrice, Double stopPrice, String signalName, String fromEntrySignal);
        /// <summary>
        /// ExitShortStopMarket method.
        /// </summary>
        /// <param name="stopPrice">Double</param>
        /// <returns>Order</returns>
        public Order ExitShortStopMarket(Double stopPrice);
        /// <summary>
        /// ExitShortStopMarket method.
        /// </summary>
        /// <param name="quantity">Int32</param>
        /// <param name="stopPrice">Double</param>
        /// <returns>Order</returns>
        public Order ExitShortStopMarket(Int32 quantity, Double stopPrice);
        /// <summary>
        /// ExitShortStopMarket method.
        /// </summary>
        /// <param name="stopPrice">Double</param>
        /// <param name="fromEntrySignal">String</param>
        /// <returns>Order</returns>
        public Order ExitShortStopMarket(Double stopPrice, String fromEntrySignal);
        /// <summary>
        /// ExitShortStopMarket method.
        /// </summary>
        /// <param name="stopPrice">Double</param>
        /// <param name="signalName">String</param>
        /// <param name="fromEntrySignal">String</param>
        /// <returns>Order</returns>
        public Order ExitShortStopMarket(Double stopPrice, String signalName, String fromEntrySignal);
        /// <summary>
        /// ExitShortStopMarket method.
        /// </summary>
        /// <param name="quantity">Int32</param>
        /// <param name="stopPrice">Double</param>
        /// <param name="signalName">String</param>
        /// <param name="fromEntrySignal">String</param>
        /// <returns>Order</returns>
        public Order ExitShortStopMarket(Int32 quantity, Double stopPrice, String signalName, String fromEntrySignal);
        /// <summary>
        /// ExitShortStopMarket method.
        /// </summary>
        /// <param name="barsInProgressIndex">Int32</param>
        /// <param name="isLiveUntilCancelled">Boolean</param>
        /// <param name="quantity">Int32</param>
        /// <param name="stopPrice">Double</param>
        /// <param name="signalName">String</param>
        /// <param name="fromEntrySignal">String</param>
        /// <returns>Order</returns>
        public Order ExitShortStopMarket(Int32 barsInProgressIndex, Boolean isLiveUntilCancelled, Int32 quantity, Double stopPrice, String signalName, String fromEntrySignal);
        /// <summary>
        /// AtmStrategyCancelEntryOrder method.
        /// </summary>
        /// <param name="orderId">String</param>
        /// <returns>Boolean</returns>
        public Boolean AtmStrategyCancelEntryOrder(String orderId);
        /// <summary>
        /// AtmStrategyChangeEntryOrder method.
        /// </summary>
        /// <param name="limitPrice">Double</param>
        /// <param name="stopPrice">Double</param>
        /// <param name="orderId">String</param>
        /// <returns>Boolean</returns>
        public Boolean AtmStrategyChangeEntryOrder(Double limitPrice, Double stopPrice, String orderId);
        /// <summary>
        /// AtmStrategyChangeStopTarget method.
        /// </summary>
        /// <param name="limitPrice">Double</param>
        /// <param name="stopPrice">Double</param>
        /// <param name="orderName">String</param>
        /// <param name="atmStrategyId">String</param>
        /// <returns>Boolean</returns>
        public Boolean AtmStrategyChangeStopTarget(Double limitPrice, Double stopPrice, String orderName, String atmStrategyId);
        /// <summary>
        /// AtmStrategyClose method.
        /// </summary>
        /// <param name="atmStrategyId">String</param>
        /// <returns>Boolean</returns>
        public Boolean AtmStrategyClose(String atmStrategyId);
        /// <summary>
        /// AtmStrategyCreate method.
        /// </summary>
        /// <param name="action">OrderAction</param>
        /// <param name="orderType">OrderType</param>
        /// <param name="limitPrice">Double</param>
        /// <param name="stopPrice">Double</param>
        /// <param name="timeInForce">TimeInForce</param>
        /// <param name="orderId">String</param>
        /// <param name="strategyTemplateName">String</param>
        /// <param name="atmStrategyId">String</param>
        /// <param name="callback">Action`2</param>
        public Void AtmStrategyCreate(OrderAction action, OrderType orderType, Double limitPrice, Double stopPrice, TimeInForce timeInForce, String orderId, String strategyTemplateName, String atmStrategyId, Action<ErrorCode, String> callback);
        /// <summary>
        /// GetAtmStrategyEntryOrderStatus method.
        /// </summary>
        /// <param name="orderId">String</param>
        /// <returns>String[]</returns>
        public String[] GetAtmStrategyEntryOrderStatus(String orderId);
        /// <summary>
        /// GetAtmStrategyMarketPosition method.
        /// </summary>
        /// <param name="atmStrategyId">String</param>
        /// <returns>MarketPosition</returns>
        public MarketPosition GetAtmStrategyMarketPosition(String atmStrategyId);
        /// <summary>
        /// GetAtmStrategyPositionAveragePrice method.
        /// </summary>
        /// <param name="atmStrategyId">String</param>
        /// <returns>Double</returns>
        public Double GetAtmStrategyPositionAveragePrice(String atmStrategyId);
        /// <summary>
        /// GetAtmStrategyPositionQuantity method.
        /// </summary>
        /// <param name="atmStrategyId">String</param>
        /// <returns>Int32</returns>
        public Int32 GetAtmStrategyPositionQuantity(String atmStrategyId);
        /// <summary>
        /// GetAtmStrategyRealizedProfitLoss method.
        /// </summary>
        /// <param name="atmStrategyId">String</param>
        /// <returns>Double</returns>
        public Double GetAtmStrategyRealizedProfitLoss(String atmStrategyId);
        /// <summary>
        /// GetAtmStrategyStopTargetOrderStatus method.
        /// </summary>
        /// <param name="orderName">String</param>
        /// <param name="atmStrategyId">String</param>
        /// <returns>String[0...,0...]</returns>
        public String[0...,0...] GetAtmStrategyStopTargetOrderStatus(String orderName, String atmStrategyId);
        /// <summary>
        /// GetAtmStrategyUnrealizedProfitLoss method.
        /// </summary>
        /// <param name="atmStrategyId">String</param>
        /// <returns>Double</returns>
        public Double GetAtmStrategyUnrealizedProfitLoss(String atmStrategyId);
        /// <summary>
        /// GetAtmStrategyUniqueId method.
        /// </summary>
        /// <returns>String</returns>
        public String GetAtmStrategyUniqueId();
        /// <summary>
        /// FillOrder method.
        /// </summary>
        /// <param name="order">Order</param>
        /// <param name="fillPrice">Double</param>
        /// <param name="slippage">Double</param>
        /// <returns>Boolean</returns>
        public Boolean FillOrder(Order order, Double fillPrice, Double slippage);
        /// <summary>
        /// SetParabolicStop method.
        /// </summary>
        /// <param name="mode">CalculationMode</param>
        /// <param name="value">Double</param>
        public Void SetParabolicStop(CalculationMode mode, Double value);
        /// <summary>
        /// SetParabolicStop method.
        /// </summary>
        /// <param name="fromEntrySignal">String</param>
        /// <param name="mode">CalculationMode</param>
        /// <param name="value">Double</param>
        /// <param name="isSimulatedStop">Boolean</param>
        /// <param name="acceleration">Double</param>
        /// <param name="accelerationMax">Double</param>
        /// <param name="accelerationStep">Double</param>
        public Void SetParabolicStop(String fromEntrySignal, CalculationMode mode, Double value, Boolean isSimulatedStop, Double acceleration, Double accelerationMax, Double accelerationStep);
        /// <summary>
        /// SetProfitTarget method.
        /// </summary>
        /// <param name="mode">CalculationMode</param>
        /// <param name="value">Double</param>
        public Void SetProfitTarget(CalculationMode mode, Double value);
        /// <summary>
        /// SetProfitTarget method.
        /// </summary>
        /// <param name="mode">CalculationMode</param>
        /// <param name="value">Double</param>
        /// <param name="isMIT">Boolean</param>
        public Void SetProfitTarget(CalculationMode mode, Double value, Boolean isMIT);
        /// <summary>
        /// SetProfitTarget method.
        /// </summary>
        /// <param name="fromEntrySignal">String</param>
        /// <param name="mode">CalculationMode</param>
        /// <param name="value">Double</param>
        public Void SetProfitTarget(String fromEntrySignal, CalculationMode mode, Double value);
        /// <summary>
        /// SetProfitTarget method.
        /// </summary>
        /// <param name="fromEntrySignal">String</param>
        /// <param name="mode">CalculationMode</param>
        /// <param name="value">Double</param>
        /// <param name="isMIT">Boolean</param>
        public Void SetProfitTarget(String fromEntrySignal, CalculationMode mode, Double value, Boolean isMIT);
        /// <summary>
        /// SetStopLoss method.
        /// </summary>
        /// <param name="mode">CalculationMode</param>
        /// <param name="value">Double</param>
        public Void SetStopLoss(CalculationMode mode, Double value);
        /// <summary>
        /// SetStopLoss method.
        /// </summary>
        /// <param name="fromEntrySignal">String</param>
        /// <param name="mode">CalculationMode</param>
        /// <param name="value">Double</param>
        /// <param name="isSimulatedStop">Boolean</param>
        public Void SetStopLoss(String fromEntrySignal, CalculationMode mode, Double value, Boolean isSimulatedStop);
        /// <summary>
        /// SetTrailStop method.
        /// </summary>
        /// <param name="mode">CalculationMode</param>
        /// <param name="value">Double</param>
        public Void SetTrailStop(CalculationMode mode, Double value);
        /// <summary>
        /// SetTrailStop method.
        /// </summary>
        /// <param name="fromEntrySignal">String</param>
        /// <param name="mode">CalculationMode</param>
        /// <param name="value">Double</param>
        /// <param name="isSimulatedStop">Boolean</param>
        public Void SetTrailStop(String fromEntrySignal, CalculationMode mode, Double value, Boolean isSimulatedStop);
        /// <summary>
        /// SubmitOrderUnmanaged method.
        /// </summary>
        /// <param name="selectedBarsInProgress">Int32</param>
        /// <param name="orderAction">OrderAction</param>
        /// <param name="orderType">OrderType</param>
        /// <param name="quantity">Int32</param>
        /// <returns>Order</returns>
        public Order SubmitOrderUnmanaged(Int32 selectedBarsInProgress, OrderAction orderAction, OrderType orderType, Int32 quantity);
        /// <summary>
        /// SubmitOrderUnmanaged method.
        /// </summary>
        /// <param name="selectedBarsInProgress">Int32</param>
        /// <param name="orderAction">OrderAction</param>
        /// <param name="orderType">OrderType</param>
        /// <param name="quantity">Int32</param>
        /// <param name="limitPrice">Double</param>
        /// <returns>Order</returns>
        public Order SubmitOrderUnmanaged(Int32 selectedBarsInProgress, OrderAction orderAction, OrderType orderType, Int32 quantity, Double limitPrice);
        /// <summary>
        /// SubmitOrderUnmanaged method.
        /// </summary>
        /// <param name="selectedBarsInProgress">Int32</param>
        /// <param name="orderAction">OrderAction</param>
        /// <param name="orderType">OrderType</param>
        /// <param name="quantity">Int32</param>
        /// <param name="limitPrice">Double</param>
        /// <param name="stopPrice">Double</param>
        /// <returns>Order</returns>
        public Order SubmitOrderUnmanaged(Int32 selectedBarsInProgress, OrderAction orderAction, OrderType orderType, Int32 quantity, Double limitPrice, Double stopPrice);
        /// <summary>
        /// SubmitOrderUnmanaged method.
        /// </summary>
        /// <param name="selectedBarsInProgress">Int32</param>
        /// <param name="orderAction">OrderAction</param>
        /// <param name="orderType">OrderType</param>
        /// <param name="quantity">Int32</param>
        /// <param name="limitPrice">Double</param>
        /// <param name="stopPrice">Double</param>
        /// <param name="oco">String</param>
        /// <returns>Order</returns>
        public Order SubmitOrderUnmanaged(Int32 selectedBarsInProgress, OrderAction orderAction, OrderType orderType, Int32 quantity, Double limitPrice, Double stopPrice, String oco);
        /// <summary>
        /// SubmitOrderUnmanaged method.
        /// </summary>
        /// <param name="selectedBarsInProgress">Int32</param>
        /// <param name="orderAction">OrderAction</param>
        /// <param name="orderType">OrderType</param>
        /// <param name="quantity">Int32</param>
        /// <param name="limitPrice">Double</param>
        /// <param name="stopPrice">Double</param>
        /// <param name="oco">String</param>
        /// <param name="signalName">String</param>
        /// <returns>Order</returns>
        public Order SubmitOrderUnmanaged(Int32 selectedBarsInProgress, OrderAction orderAction, OrderType orderType, Int32 quantity, Double limitPrice, Double stopPrice, String oco, String signalName);
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="ninjaScript">NinjaScript</param>
        public Void CopyTo(NinjaScript ninjaScript);
        /// <summary>
        /// SetUniqueId method.
        /// </summary>
        public Void SetUniqueId();
        #endregion
    }
}
