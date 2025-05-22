[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class Account : NinjaTrader.Cbi.ISnapShotSerializable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the LastTransactionsSum.
        /// </summary>
        [DataMember]
        public double LastTransactionsSum { get; set; }
        /// <summary>
        /// Gets or sets the SyncGW.
        /// </summary>
        [DataMember]
        public object SyncGW { get; set; }
        /// <summary>
        /// Gets or sets the Commission.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Commission Commission { get; set; }
        /// <summary>
        /// Gets or sets the ConnectionStatus.
        /// </summary>
        [DataMember]
        public ConnectionStatus ConnectionStatus { get; set; }
        /// <summary>
        /// Gets or sets the DailyLossLimit.
        /// </summary>
        [DataMember]
        public double DailyLossLimit { get; set; }
        /// <summary>
        /// Gets or sets the FcmDate.
        /// </summary>
        [DataMember]
        public System.DateTime FcmDate { get; set; }
        /// <summary>
        /// Gets or sets the Fee.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Fee Fee { get; set; }
        /// <summary>
        /// Gets or sets the LookbackDaysExecutions.
        /// </summary>
        [DataMember]
        public int LookbackDaysExecutions { get; set; }
        /// <summary>
        /// Gets or sets the LookbackDaysOrders.
        /// </summary>
        [DataMember]
        public int LookbackDaysOrders { get; set; }
        /// <summary>
        /// Gets or sets the MarginMultiplier.
        /// </summary>
        [DataMember]
        public double MarginMultiplier { get; set; }
        /// <summary>
        /// Gets or sets the MaxOrderSize.
        /// </summary>
        [DataMember]
        public int MaxOrderSize { get; set; }
        /// <summary>
        /// Gets or sets the MaxPositionSize.
        /// </summary>
        [DataMember]
        public int MaxPositionSize { get; set; }
        /// <summary>
        /// Gets or sets the MinimumCashValue.
        /// </summary>
        [DataMember]
        public double MinimumCashValue { get; set; }
        /// <summary>
        /// Gets or sets the PrimaryUser.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.User PrimaryUser { get; set; }
        /// <summary>
        /// Gets or sets the Provider.
        /// </summary>
        [DataMember]
        public Provider Provider { get; set; }
        /// <summary>
        /// Gets or sets the Risk.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Risk Risk { get; set; }
        /// <summary>
        /// Gets or sets the RiskByMasterInstrument.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<NinjaTrader.Cbi.MasterInstrument, NinjaTrader.Cbi.InstrumentRisk> RiskByMasterInstrument { get; set; }
        /// <summary>
        /// Gets or sets the Transactions.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.IList<NinjaTrader.Cbi.Transaction> Transactions { get; set; }
        /// <summary>
        /// Gets or sets the UsersSerializable.
        /// </summary>
        [DataMember]
        public string UsersSerializable { get; set; }
        /// <summary>
        /// Gets or sets the AccountStatus.
        /// </summary>
        [DataMember]
        public AccountStatus AccountStatus { get; set; }
        /// <summary>
        /// Gets or sets the All.
        /// </summary>
        [DataMember]
        public System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Account> All { get; set; }
        /// <summary>
        /// Gets or sets the Connection.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Connection Connection { get; set; }
        /// <summary>
        /// Gets or sets the Denomination.
        /// </summary>
        [DataMember]
        public Currency Denomination { get; set; }
        /// <summary>
        /// Gets or sets the DisplayName.
        /// </summary>
        [DataMember]
        public string DisplayName { get; set; }
        /// <summary>
        /// Gets or sets the ExecutionPositions.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.ExecutionPositions ExecutionPositions { get; set; }
        /// <summary>
        /// Gets or sets the Executions.
        /// </summary>
        [DataMember]
        public System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Execution> Executions { get; set; }
        /// <summary>
        /// Gets or sets the Fcm.
        /// </summary>
        [DataMember]
        public string Fcm { get; set; }
        /// <summary>
        /// Gets or sets the ForexLotSize.
        /// </summary>
        [DataMember]
        public int ForexLotSize { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public long Id { get; set; }
        /// <summary>
        /// Gets or sets the IsAutoLiquidationEnabled.
        /// </summary>
        [DataMember]
        public bool IsAutoLiquidationEnabled { get; set; }
        /// <summary>
        /// Gets or sets the LiquidationState.
        /// </summary>
        [DataMember]
        public LiquidationState LiquidationState { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the Orders.
        /// </summary>
        [DataMember]
        public System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Order> Orders { get; set; }
        /// <summary>
        /// Gets or sets the Positions.
        /// </summary>
        [DataMember]
        public System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Position> Positions { get; set; }
        /// <summary>
        /// Gets or sets the SimulatorInitialCash.
        /// </summary>
        [DataMember]
        public double SimulatorInitialCash { get; set; }
        /// <summary>
        /// Gets or sets the SimulatorDelayExchange.
        /// </summary>
        [DataMember]
        public int SimulatorDelayExchange { get; set; }
        /// <summary>
        /// Gets or sets the SimulatorDelayInternet.
        /// </summary>
        [DataMember]
        public int SimulatorDelayInternet { get; set; }
        /// <summary>
        /// Gets or sets the ServerStrategies.
        /// </summary>
        [DataMember]
        public System.Collections.ObjectModel.Collection<NinjaTrader.ServerAtm.ServerAtmStrategy> ServerStrategies { get; set; }
        /// <summary>
        /// Gets or sets the Strategies.
        /// </summary>
        [DataMember]
        public System.Collections.ObjectModel.Collection<NinjaTrader.NinjaScript.StrategyBase> Strategies { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// RaiseAccountRoll method.
        /// </summary>
        /// <param name="e">NinjaTrader.Cbi.AccountRollEventArgs</param>
        public void RaiseAccountRoll(NinjaTrader.Cbi.AccountRollEventArgs e)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// AccountItemUpdateCallback method.
        /// </summary>
        /// <param name="itemType">AccountItem</param>
        /// <param name="currency">Currency</param>
        /// <param name="value">double</param>
        /// <param name="time">System.DateTime</param>
        public void AccountItemUpdateCallback(AccountItem itemType, Currency currency, double value, System.DateTime time)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// CancelAllOrders method.
        /// </summary>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        public void CancelAllOrders(NinjaTrader.Cbi.Instrument instrument)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// CreateOrder method.
        /// </summary>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        /// <param name="action">OrderAction</param>
        /// <param name="orderType">OrderType</param>
        /// <param name="timeInForce">TimeInForce</param>
        /// <param name="quantity">int</param>
        /// <param name="limitPrice">double</param>
        /// <param name="stopPrice">double</param>
        /// <param name="oco">string</param>
        /// <param name="name">string</param>
        /// <param name="customOrder">NinjaTrader.Cbi.CustomOrder</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        [Obsolete]
        public NinjaTrader.Cbi.Order CreateOrder(NinjaTrader.Cbi.Instrument instrument, OrderAction action, OrderType orderType, TimeInForce timeInForce, int quantity, double limitPrice, double stopPrice, string oco, string name, NinjaTrader.Cbi.CustomOrder customOrder)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// CreateOrder method.
        /// </summary>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        /// <param name="action">OrderAction</param>
        /// <param name="orderType">OrderType</param>
        /// <param name="orderEntry">OrderEntry</param>
        /// <param name="timeInForce">TimeInForce</param>
        /// <param name="quantity">int</param>
        /// <param name="limitPrice">double</param>
        /// <param name="stopPrice">double</param>
        /// <param name="oco">string</param>
        /// <param name="name">string</param>
        /// <param name="gtd">System.DateTime</param>
        /// <param name="customOrder">NinjaTrader.Cbi.CustomOrder</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order CreateOrder(NinjaTrader.Cbi.Instrument instrument, OrderAction action, OrderType orderType, OrderEntry orderEntry, TimeInForce timeInForce, int quantity, double limitPrice, double stopPrice, string oco, string name, System.DateTime gtd, NinjaTrader.Cbi.CustomOrder customOrder)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// CreateOrder method.
        /// </summary>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        /// <param name="action">OrderAction</param>
        /// <param name="orderType">OrderType</param>
        /// <param name="orderEntry">OrderEntry</param>
        /// <param name="timeInForce">TimeInForce</param>
        /// <param name="quantity">int</param>
        /// <param name="limitPrice">double</param>
        /// <param name="stopPrice">double</param>
        /// <param name="filled">int</param>
        /// <param name="averageFillPrice">double</param>
        /// <param name="initialOrderState">OrderState</param>
        /// <param name="initialOrderId">string</param>
        /// <param name="time">System.DateTime</param>
        /// <param name="oco">string</param>
        /// <param name="name">string</param>
        /// <param name="gtd">System.DateTime</param>
        /// <param name="comment">string</param>
        /// <param name="statementDate">System.DateTime</param>
        /// <param name="customOrder">NinjaTrader.Cbi.CustomOrder</param>
        /// <param name="raiseOrderUpdate">bool</param>
        /// <param name="id">long</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order CreateOrder(NinjaTrader.Cbi.Instrument instrument, OrderAction action, OrderType orderType, OrderEntry orderEntry, TimeInForce timeInForce, int quantity, double limitPrice, double stopPrice, int filled, double averageFillPrice, OrderState initialOrderState, string initialOrderId, System.DateTime time, string oco, string name, System.DateTime gtd, string comment, System.DateTime statementDate, NinjaTrader.Cbi.CustomOrder customOrder, bool raiseOrderUpdate, long id)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DbAdd method.
        /// </summary>
        /// <param name="persist">bool</param>
        public void DbAdd(bool persist)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DbGet method.
        /// </summary>
        /// <param name="id">long</param>
        /// <returns>NinjaTrader.Cbi.Account</returns>
        public NinjaTrader.Cbi.Account DbGet(long id)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DbGet method.
        /// </summary>
        /// <param name="name">string</param>
        /// <returns>NinjaTrader.Cbi.Account</returns>
        public NinjaTrader.Cbi.Account DbGet(string name)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DbReload method.
        /// </summary>
        public void DbReload()
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
        /// DbUpdate method.
        /// </summary>
        public void DbUpdate()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExecutionUpdateCallback method.
        /// </summary>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        /// <param name="executionId">string</param>
        /// <param name="exchange">Exchange</param>
        /// <param name="time">System.DateTime</param>
        /// <param name="marketPosition">MarketPosition</param>
        /// <param name="orderId">string</param>
        /// <param name="quantity">int</param>
        /// <param name="price">double</param>
        /// <param name="commission">double</param>
        /// <param name="fee">double</param>
        /// <param name="isSod">bool</param>
        /// <param name="statementDate">System.DateTime</param>
        /// <param name="operation">Operation</param>
        public void ExecutionUpdateCallback(NinjaTrader.Cbi.Instrument instrument, string executionId, Exchange exchange, System.DateTime time, MarketPosition marketPosition, string orderId, int quantity, double price, double commission, double fee, bool isSod, System.DateTime statementDate, Operation operation)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Flatten method.
        /// </summary>
        /// <param name="instruments">System.Collections.Generic.ICollection<NinjaTrader.Cbi.Instrument></param>
        public void Flatten(System.Collections.Generic.ICollection<NinjaTrader.Cbi.Instrument> instruments)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// FlattenEverything method.
        /// </summary>
        public void FlattenEverything()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetAccountItem method.
        /// </summary>
        /// <param name="itemType">AccountItem</param>
        /// <param name="currency">Currency</param>
        /// <returns>NinjaTrader.Cbi.AccountItemEventArgs</returns>
        public NinjaTrader.Cbi.AccountItemEventArgs GetAccountItem(AccountItem itemType, Currency currency)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetExecution method.
        /// </summary>
        /// <param name="id">long</param>
        /// <returns>NinjaTrader.Cbi.Execution</returns>
        public NinjaTrader.Cbi.Execution GetExecution(long id)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetPosition method.
        /// </summary>
        /// <param name="instrumentId">long</param>
        /// <returns>NinjaTrader.Cbi.Position</returns>
        public NinjaTrader.Cbi.Position GetPosition(long instrumentId)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// IsOrderTypeSupported method.
        /// </summary>
        /// <param name="orderType">OrderType</param>
        /// <returns>bool</returns>
        public bool IsOrderTypeSupported(OrderType orderType)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// OnConnectionStatus method.
        /// </summary>
        /// <param name="status">ConnectionStatus</param>
        public void OnConnectionStatus(ConnectionStatus status)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// OrderUpdateCallback method.
        /// </summary>
        /// <param name="order">NinjaTrader.Cbi.Order</param>
        /// <param name="orderId">string</param>
        /// <param name="limitPrice">double</param>
        /// <param name="stopPrice">double</param>
        /// <param name="quantity">int</param>
        /// <param name="averageFillPrice">double</param>
        /// <param name="filled">int</param>
        /// <param name="orderState">OrderState</param>
        /// <param name="time">System.DateTime</param>
        /// <param name="error">ErrorCode</param>
        /// <param name="comment">string</param>
        /// <param name="statementDate">System.DateTime</param>
        public void OrderUpdateCallback(NinjaTrader.Cbi.Order order, string orderId, double limitPrice, double stopPrice, int quantity, double averageFillPrice, int filled, OrderState orderState, System.DateTime time, ErrorCode error, string comment, System.DateTime statementDate)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// QueueChange method.
        /// </summary>
        /// <param name="order">NinjaTrader.Cbi.Order</param>
        /// <param name="latestOrderState">OrderState</param>
        public void QueueChange(NinjaTrader.Cbi.Order order, OrderState latestOrderState)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// RaiseAccountStatusUpdate method.
        /// </summary>
        /// <param name="e">NinjaTrader.Cbi.AccountStatusEventArgs</param>
        public void RaiseAccountStatusUpdate(NinjaTrader.Cbi.AccountStatusEventArgs e)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ResetSimulationAccount method.
        /// </summary>
        /// <param name="clearTradeData">bool</param>
        public void ResetSimulationAccount(bool clearTradeData)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Restore method.
        /// </summary>
        public void Restore()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Roll method.
        /// </summary>
        /// <param name="fcmDate">System.DateTime</param>
        /// <param name="persist">bool</param>
        public void Roll(System.DateTime fcmDate, bool persist)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SnapShotPersist method.
        /// </summary>
        /// <param name="updateVersion">bool</param>
        public void SnapShotPersist(bool updateVersion)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// UpdateCashValue method.
        /// </summary>
        /// <param name="reset">bool</param>
        public void UpdateCashValue(bool reset)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Cancel method.
        /// </summary>
        /// <param name="orders">System.Collections.Generic.IEnumerable<NinjaTrader.Cbi.Order></param>
        public void Cancel(System.Collections.Generic.IEnumerable<NinjaTrader.Cbi.Order> orders)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// CancelOrdersByOcoID method.
        /// </summary>
        /// <param name="orders">System.Collections.Generic.IEnumerable<NinjaTrader.Cbi.Order></param>
        /// <param name="traceText">string</param>
        public void CancelOrdersByOcoID(System.Collections.Generic.IEnumerable<NinjaTrader.Cbi.Order> orders, string traceText)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Change method.
        /// </summary>
        /// <param name="orders">System.Collections.Generic.IEnumerable<NinjaTrader.Cbi.Order></param>
        public void Change(System.Collections.Generic.IEnumerable<NinjaTrader.Cbi.Order> orders)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DbGet method.
        /// </summary>
        /// <param name="name">string</param>
        /// <param name="fcm">string</param>
        /// <param name="forceDbQuery">bool</param>
        /// <returns>NinjaTrader.Cbi.Account</returns>
        public NinjaTrader.Cbi.Account DbGet(string name, string fcm, bool forceDbQuery)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// FindOrderById method.
        /// </summary>
        /// <param name="orders">System.Collections.Generic.IList<NinjaTrader.Cbi.Order></param>
        /// <param name="orderId">string</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order FindOrderById(System.Collections.Generic.IList<NinjaTrader.Cbi.Order> orders, string orderId)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Get method.
        /// </summary>
        /// <param name="itemType">AccountItem</param>
        /// <param name="currency">Currency</param>
        /// <returns>double</returns>
        public double Get(AccountItem itemType, Currency currency)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetOrder method.
        /// </summary>
        /// <param name="id">long</param>
        /// <returns>NinjaTrader.Cbi.Order</returns>
        public NinjaTrader.Cbi.Order GetOrder(long id)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// PositionUpdateCallback method.
        /// </summary>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        /// <param name="marketPosition">MarketPosition</param>
        /// <param name="quantity">int</param>
        /// <param name="averagePrice">double</param>
        /// <param name="operation">Operation</param>
        public void PositionUpdateCallback(NinjaTrader.Cbi.Instrument instrument, MarketPosition marketPosition, int quantity, double averagePrice, Operation operation)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// RaiseAccountLiquidationChanged method.
        /// </summary>
        /// <param name="e">NinjaTrader.Cbi.AccountLiquidationEventArgs</param>
        public void RaiseAccountLiquidationChanged(NinjaTrader.Cbi.AccountLiquidationEventArgs e)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// RaiseAccountItemUpdate method.
        /// </summary>
        /// <param name="e">NinjaTrader.Cbi.AccountItemEventArgs</param>
        public void RaiseAccountItemUpdate(NinjaTrader.Cbi.AccountItemEventArgs e)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// RaiseAccountItemUpdateCallbacks method.
        /// </summary>
        public void RaiseAccountItemUpdateCallbacks()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// RaiseExecutionUpdate method.
        /// </summary>
        /// <param name="e">NinjaTrader.Cbi.ExecutionEventArgs</param>
        public void RaiseExecutionUpdate(NinjaTrader.Cbi.ExecutionEventArgs e)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// RaisePositionUpdate method.
        /// </summary>
        /// <param name="e">NinjaTrader.Cbi.PositionEventArgs</param>
        public void RaisePositionUpdate(NinjaTrader.Cbi.PositionEventArgs e)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// RaiseOrderUpdate method.
        /// </summary>
        /// <param name="e">NinjaTrader.Cbi.OrderEventArgs</param>
        public void RaiseOrderUpdate(NinjaTrader.Cbi.OrderEventArgs e)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Submit method.
        /// </summary>
        /// <param name="orders">System.Collections.Generic.IEnumerable<NinjaTrader.Cbi.Order></param>
        public void Submit(System.Collections.Generic.IEnumerable<NinjaTrader.Cbi.Order> orders)
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
        /// UpdateAccountItems method.
        /// </summary>
        /// <param name="now">System.DateTime</param>
        /// <param name="force">bool</param>
        public void UpdateAccountItems(System.DateTime now, bool force)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
