[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class Account : ISnapShotSerializable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the LastTransactionsSum.
        /// </summary>
        [DataMember]
        public Double LastTransactionsSum { get; set; }
        /// <summary>
        /// Gets or sets the SyncGW.
        /// </summary>
        [DataMember]
        public Object SyncGW { get; set; }
        /// <summary>
        /// Gets or sets the Commission.
        /// </summary>
        [DataMember]
        public Commission Commission { get; set; }
        /// <summary>
        /// Gets or sets the ConnectionStatus.
        /// </summary>
        [DataMember]
        public ConnectionStatus ConnectionStatus { get; set; }
        /// <summary>
        /// Gets or sets the DailyLossLimit.
        /// </summary>
        [DataMember]
        public Double DailyLossLimit { get; set; }
        /// <summary>
        /// Gets or sets the FcmDate.
        /// </summary>
        [DataMember]
        public DateTime FcmDate { get; set; }
        /// <summary>
        /// Gets or sets the Fee.
        /// </summary>
        [DataMember]
        public Fee Fee { get; set; }
        /// <summary>
        /// Gets or sets the LookbackDaysExecutions.
        /// </summary>
        [DataMember]
        public Int32 LookbackDaysExecutions { get; set; }
        /// <summary>
        /// Gets or sets the LookbackDaysOrders.
        /// </summary>
        [DataMember]
        public Int32 LookbackDaysOrders { get; set; }
        /// <summary>
        /// Gets or sets the MarginMultiplier.
        /// </summary>
        [DataMember]
        public Double MarginMultiplier { get; set; }
        /// <summary>
        /// Gets or sets the MaxOrderSize.
        /// </summary>
        [DataMember]
        public Int32 MaxOrderSize { get; set; }
        /// <summary>
        /// Gets or sets the MaxPositionSize.
        /// </summary>
        [DataMember]
        public Int32 MaxPositionSize { get; set; }
        /// <summary>
        /// Gets or sets the MinimumCashValue.
        /// </summary>
        [DataMember]
        public Double MinimumCashValue { get; set; }
        /// <summary>
        /// Gets or sets the PrimaryUser.
        /// </summary>
        [DataMember]
        public User PrimaryUser { get; set; }
        /// <summary>
        /// Gets or sets the Provider.
        /// </summary>
        [DataMember]
        public Provider Provider { get; set; }
        /// <summary>
        /// Gets or sets the Risk.
        /// </summary>
        [DataMember]
        public Risk Risk { get; set; }
        /// <summary>
        /// Gets or sets the RiskByMasterInstrument.
        /// </summary>
        [DataMember]
        public Dictionary<MasterInstrument, InstrumentRisk> RiskByMasterInstrument { get; set; }
        /// <summary>
        /// Gets or sets the Transactions.
        /// </summary>
        [DataMember]
        public IList<Transaction> Transactions { get; set; }
        /// <summary>
        /// Gets or sets the UsersSerializable.
        /// </summary>
        [DataMember]
        public String UsersSerializable { get; set; }
        /// <summary>
        /// Gets or sets the AccountStatus.
        /// </summary>
        [DataMember]
        public AccountStatus AccountStatus { get; set; }
        /// <summary>
        /// Gets or sets the All.
        /// </summary>
        [DataMember]
        public Collection<Account> All { get; set; }
        /// <summary>
        /// Gets or sets the Connection.
        /// </summary>
        [DataMember]
        public Connection Connection { get; set; }
        /// <summary>
        /// Gets or sets the Denomination.
        /// </summary>
        [DataMember]
        public Currency Denomination { get; set; }
        /// <summary>
        /// Gets or sets the DisplayName.
        /// </summary>
        [DataMember]
        public String DisplayName { get; set; }
        /// <summary>
        /// Gets or sets the ExecutionPositions.
        /// </summary>
        [DataMember]
        public ExecutionPositions ExecutionPositions { get; set; }
        /// <summary>
        /// Gets or sets the Executions.
        /// </summary>
        [DataMember]
        public Collection<Execution> Executions { get; set; }
        /// <summary>
        /// Gets or sets the Fcm.
        /// </summary>
        [DataMember]
        public String Fcm { get; set; }
        /// <summary>
        /// Gets or sets the ForexLotSize.
        /// </summary>
        [DataMember]
        public Int32 ForexLotSize { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public Int64 Id { get; set; }
        /// <summary>
        /// Gets or sets the IsAutoLiquidationEnabled.
        /// </summary>
        [DataMember]
        public Boolean IsAutoLiquidationEnabled { get; set; }
        /// <summary>
        /// Gets or sets the LiquidationState.
        /// </summary>
        [DataMember]
        public LiquidationState LiquidationState { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public String Name { get; set; }
        /// <summary>
        /// Gets or sets the Orders.
        /// </summary>
        [DataMember]
        public Collection<Order> Orders { get; set; }
        /// <summary>
        /// Gets or sets the Positions.
        /// </summary>
        [DataMember]
        public Collection<Position> Positions { get; set; }
        /// <summary>
        /// Gets or sets the SimulatorInitialCash.
        /// </summary>
        [DataMember]
        public Double SimulatorInitialCash { get; set; }
        /// <summary>
        /// Gets or sets the SimulatorDelayExchange.
        /// </summary>
        [DataMember]
        public Int32 SimulatorDelayExchange { get; set; }
        /// <summary>
        /// Gets or sets the SimulatorDelayInternet.
        /// </summary>
        [DataMember]
        public Int32 SimulatorDelayInternet { get; set; }
        /// <summary>
        /// Gets or sets the ServerStrategies.
        /// </summary>
        [DataMember]
        public Collection<ServerAtmStrategy> ServerStrategies { get; set; }
        /// <summary>
        /// Gets or sets the Strategies.
        /// </summary>
        [DataMember]
        public Collection<StrategyBase> Strategies { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// RaiseAccountRoll method.
        /// </summary>
        /// <param name="e">AccountRollEventArgs</param>
        public Void RaiseAccountRoll(AccountRollEventArgs e);
        /// <summary>
        /// AccountItemUpdateCallback method.
        /// </summary>
        /// <param name="itemType">AccountItem</param>
        /// <param name="currency">Currency</param>
        /// <param name="value">Double</param>
        /// <param name="time">DateTime</param>
        public Void AccountItemUpdateCallback(AccountItem itemType, Currency currency, Double value, DateTime time);
        /// <summary>
        /// CancelAllOrders method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        public Void CancelAllOrders(Instrument instrument);
        /// <summary>
        /// CreateOrder method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        /// <param name="action">OrderAction</param>
        /// <param name="orderType">OrderType</param>
        /// <param name="timeInForce">TimeInForce</param>
        /// <param name="quantity">Int32</param>
        /// <param name="limitPrice">Double</param>
        /// <param name="stopPrice">Double</param>
        /// <param name="oco">String</param>
        /// <param name="name">String</param>
        /// <param name="customOrder">CustomOrder</param>
        /// <returns>Order</returns>
        [Obsolete]
        public Order CreateOrder(Instrument instrument, OrderAction action, OrderType orderType, TimeInForce timeInForce, Int32 quantity, Double limitPrice, Double stopPrice, String oco, String name, CustomOrder customOrder);
        /// <summary>
        /// CreateOrder method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        /// <param name="action">OrderAction</param>
        /// <param name="orderType">OrderType</param>
        /// <param name="orderEntry">OrderEntry</param>
        /// <param name="timeInForce">TimeInForce</param>
        /// <param name="quantity">Int32</param>
        /// <param name="limitPrice">Double</param>
        /// <param name="stopPrice">Double</param>
        /// <param name="oco">String</param>
        /// <param name="name">String</param>
        /// <param name="gtd">DateTime</param>
        /// <param name="customOrder">CustomOrder</param>
        /// <returns>Order</returns>
        public Order CreateOrder(Instrument instrument, OrderAction action, OrderType orderType, OrderEntry orderEntry, TimeInForce timeInForce, Int32 quantity, Double limitPrice, Double stopPrice, String oco, String name, DateTime gtd, CustomOrder customOrder);
        /// <summary>
        /// CreateOrder method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        /// <param name="action">OrderAction</param>
        /// <param name="orderType">OrderType</param>
        /// <param name="orderEntry">OrderEntry</param>
        /// <param name="timeInForce">TimeInForce</param>
        /// <param name="quantity">Int32</param>
        /// <param name="limitPrice">Double</param>
        /// <param name="stopPrice">Double</param>
        /// <param name="filled">Int32</param>
        /// <param name="averageFillPrice">Double</param>
        /// <param name="initialOrderState">OrderState</param>
        /// <param name="initialOrderId">String</param>
        /// <param name="time">DateTime</param>
        /// <param name="oco">String</param>
        /// <param name="name">String</param>
        /// <param name="gtd">DateTime</param>
        /// <param name="comment">String</param>
        /// <param name="statementDate">DateTime</param>
        /// <param name="customOrder">CustomOrder</param>
        /// <param name="raiseOrderUpdate">Boolean</param>
        /// <param name="id">Int64</param>
        /// <returns>Order</returns>
        public Order CreateOrder(Instrument instrument, OrderAction action, OrderType orderType, OrderEntry orderEntry, TimeInForce timeInForce, Int32 quantity, Double limitPrice, Double stopPrice, Int32 filled, Double averageFillPrice, OrderState initialOrderState, String initialOrderId, DateTime time, String oco, String name, DateTime gtd, String comment, DateTime statementDate, CustomOrder customOrder, Boolean raiseOrderUpdate, Int64 id);
        /// <summary>
        /// DbAdd method.
        /// </summary>
        /// <param name="persist">Boolean</param>
        public Void DbAdd(Boolean persist);
        /// <summary>
        /// DbGet method.
        /// </summary>
        /// <param name="id">Int64</param>
        /// <returns>Account</returns>
        public Account DbGet(Int64 id);
        /// <summary>
        /// DbGet method.
        /// </summary>
        /// <param name="name">String</param>
        /// <returns>Account</returns>
        public Account DbGet(String name);
        /// <summary>
        /// DbReload method.
        /// </summary>
        public Void DbReload();
        /// <summary>
        /// DbRemove method.
        /// </summary>
        public Void DbRemove();
        /// <summary>
        /// DbUpdate method.
        /// </summary>
        public Void DbUpdate();
        /// <summary>
        /// ExecutionUpdateCallback method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        /// <param name="executionId">String</param>
        /// <param name="exchange">Exchange</param>
        /// <param name="time">DateTime</param>
        /// <param name="marketPosition">MarketPosition</param>
        /// <param name="orderId">String</param>
        /// <param name="quantity">Int32</param>
        /// <param name="price">Double</param>
        /// <param name="commission">Double</param>
        /// <param name="fee">Double</param>
        /// <param name="isSod">Boolean</param>
        /// <param name="statementDate">DateTime</param>
        /// <param name="operation">Operation</param>
        public Void ExecutionUpdateCallback(Instrument instrument, String executionId, Exchange exchange, DateTime time, MarketPosition marketPosition, String orderId, Int32 quantity, Double price, Double commission, Double fee, Boolean isSod, DateTime statementDate, Operation operation);
        /// <summary>
        /// Flatten method.
        /// </summary>
        /// <param name="instruments">ICollection`1</param>
        public Void Flatten(ICollection<Instrument> instruments);
        /// <summary>
        /// FlattenEverything method.
        /// </summary>
        public Void FlattenEverything();
        /// <summary>
        /// GetAccountItem method.
        /// </summary>
        /// <param name="itemType">AccountItem</param>
        /// <param name="currency">Currency</param>
        /// <returns>AccountItemEventArgs</returns>
        public AccountItemEventArgs GetAccountItem(AccountItem itemType, Currency currency);
        /// <summary>
        /// GetExecution method.
        /// </summary>
        /// <param name="id">Int64</param>
        /// <returns>Execution</returns>
        public Execution GetExecution(Int64 id);
        /// <summary>
        /// GetPosition method.
        /// </summary>
        /// <param name="instrumentId">Int64</param>
        /// <returns>Position</returns>
        public Position GetPosition(Int64 instrumentId);
        /// <summary>
        /// IsOrderTypeSupported method.
        /// </summary>
        /// <param name="orderType">OrderType</param>
        /// <returns>Boolean</returns>
        public Boolean IsOrderTypeSupported(OrderType orderType);
        /// <summary>
        /// OnConnectionStatus method.
        /// </summary>
        /// <param name="status">ConnectionStatus</param>
        public Void OnConnectionStatus(ConnectionStatus status);
        /// <summary>
        /// OrderUpdateCallback method.
        /// </summary>
        /// <param name="order">Order</param>
        /// <param name="orderId">String</param>
        /// <param name="limitPrice">Double</param>
        /// <param name="stopPrice">Double</param>
        /// <param name="quantity">Int32</param>
        /// <param name="averageFillPrice">Double</param>
        /// <param name="filled">Int32</param>
        /// <param name="orderState">OrderState</param>
        /// <param name="time">DateTime</param>
        /// <param name="error">ErrorCode</param>
        /// <param name="comment">String</param>
        /// <param name="statementDate">DateTime</param>
        public Void OrderUpdateCallback(Order order, String orderId, Double limitPrice, Double stopPrice, Int32 quantity, Double averageFillPrice, Int32 filled, OrderState orderState, DateTime time, ErrorCode error, String comment, DateTime statementDate);
        /// <summary>
        /// QueueChange method.
        /// </summary>
        /// <param name="order">Order</param>
        /// <param name="latestOrderState">OrderState</param>
        public Void QueueChange(Order order, OrderState latestOrderState);
        /// <summary>
        /// RaiseAccountStatusUpdate method.
        /// </summary>
        /// <param name="e">AccountStatusEventArgs</param>
        public Void RaiseAccountStatusUpdate(AccountStatusEventArgs e);
        /// <summary>
        /// ResetSimulationAccount method.
        /// </summary>
        /// <param name="clearTradeData">Boolean</param>
        public Void ResetSimulationAccount(Boolean clearTradeData);
        /// <summary>
        /// Restore method.
        /// </summary>
        public Void Restore();
        /// <summary>
        /// Roll method.
        /// </summary>
        /// <param name="fcmDate">DateTime</param>
        /// <param name="persist">Boolean</param>
        public Void Roll(DateTime fcmDate, Boolean persist);
        /// <summary>
        /// SnapShotPersist method.
        /// </summary>
        /// <param name="updateVersion">Boolean</param>
        public Void SnapShotPersist(Boolean updateVersion);
        /// <summary>
        /// UpdateCashValue method.
        /// </summary>
        /// <param name="reset">Boolean</param>
        public Void UpdateCashValue(Boolean reset);
        /// <summary>
        /// Cancel method.
        /// </summary>
        /// <param name="orders">IEnumerable`1</param>
        public Void Cancel(IEnumerable<Order> orders);
        /// <summary>
        /// CancelOrdersByOcoID method.
        /// </summary>
        /// <param name="orders">IEnumerable`1</param>
        /// <param name="traceText">String</param>
        public Void CancelOrdersByOcoID(IEnumerable<Order> orders, String traceText);
        /// <summary>
        /// Change method.
        /// </summary>
        /// <param name="orders">IEnumerable`1</param>
        public Void Change(IEnumerable<Order> orders);
        /// <summary>
        /// DbGet method.
        /// </summary>
        /// <param name="name">String</param>
        /// <param name="fcm">String</param>
        /// <param name="forceDbQuery">Boolean</param>
        /// <returns>Account</returns>
        public Account DbGet(String name, String fcm, Boolean forceDbQuery);
        /// <summary>
        /// FindOrderById method.
        /// </summary>
        /// <param name="orders">IList`1</param>
        /// <param name="orderId">String</param>
        /// <returns>Order</returns>
        public Order FindOrderById(IList<Order> orders, String orderId);
        /// <summary>
        /// Get method.
        /// </summary>
        /// <param name="itemType">AccountItem</param>
        /// <param name="currency">Currency</param>
        /// <returns>Double</returns>
        public Double Get(AccountItem itemType, Currency currency);
        /// <summary>
        /// GetOrder method.
        /// </summary>
        /// <param name="id">Int64</param>
        /// <returns>Order</returns>
        public Order GetOrder(Int64 id);
        /// <summary>
        /// PositionUpdateCallback method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        /// <param name="marketPosition">MarketPosition</param>
        /// <param name="quantity">Int32</param>
        /// <param name="averagePrice">Double</param>
        /// <param name="operation">Operation</param>
        public Void PositionUpdateCallback(Instrument instrument, MarketPosition marketPosition, Int32 quantity, Double averagePrice, Operation operation);
        /// <summary>
        /// RaiseAccountLiquidationChanged method.
        /// </summary>
        /// <param name="e">AccountLiquidationEventArgs</param>
        public Void RaiseAccountLiquidationChanged(AccountLiquidationEventArgs e);
        /// <summary>
        /// RaiseAccountItemUpdate method.
        /// </summary>
        /// <param name="e">AccountItemEventArgs</param>
        public Void RaiseAccountItemUpdate(AccountItemEventArgs e);
        /// <summary>
        /// RaiseAccountItemUpdateCallbacks method.
        /// </summary>
        public Void RaiseAccountItemUpdateCallbacks();
        /// <summary>
        /// RaiseExecutionUpdate method.
        /// </summary>
        /// <param name="e">ExecutionEventArgs</param>
        public Void RaiseExecutionUpdate(ExecutionEventArgs e);
        /// <summary>
        /// RaisePositionUpdate method.
        /// </summary>
        /// <param name="e">PositionEventArgs</param>
        public Void RaisePositionUpdate(PositionEventArgs e);
        /// <summary>
        /// RaiseOrderUpdate method.
        /// </summary>
        /// <param name="e">OrderEventArgs</param>
        public Void RaiseOrderUpdate(OrderEventArgs e);
        /// <summary>
        /// Submit method.
        /// </summary>
        /// <param name="orders">IEnumerable`1</param>
        public Void Submit(IEnumerable<Order> orders);
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>String</returns>
        public String ToString();
        /// <summary>
        /// UpdateAccountItems method.
        /// </summary>
        /// <param name="now">DateTime</param>
        /// <param name="force">Boolean</param>
        public Void UpdateAccountItems(DateTime now, Boolean force);
        #endregion
    }
}
