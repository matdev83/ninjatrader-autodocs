[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class Order
    {
        #region Properties
        /// <summary>
        /// Gets or sets the ClientId.
        /// </summary>
        [DataMember]
        public Int64 ClientId { get; set; }
        /// <summary>
        /// Gets or sets the Stopwatch.
        /// </summary>
        [DataMember]
        public Stopwatch Stopwatch { get; set; }
        /// <summary>
        /// Gets or sets the BacktestPassNumber.
        /// </summary>
        [DataMember]
        public Int64 BacktestPassNumber { get; set; }
        /// <summary>
        /// Gets or sets the FromEntrySignal.
        /// </summary>
        [DataMember]
        public String FromEntrySignal { get; set; }
        /// <summary>
        /// Gets or sets the HasOverfill.
        /// </summary>
        [DataMember]
        public Boolean HasOverfill { get; set; }
        /// <summary>
        /// Gets or sets the IsLiveUntilCancelled.
        /// </summary>
        [DataMember]
        public Boolean IsLiveUntilCancelled { get; set; }
        /// <summary>
        /// Gets or sets the IsTrackingConfigured.
        /// </summary>
        [DataMember]
        public Boolean IsTrackingConfigured { get; set; }
        /// <summary>
        /// Gets or sets the OnBehalfOf.
        /// </summary>
        [DataMember]
        public String OnBehalfOf { get; set; }
        /// <summary>
        /// Gets or sets the OrderEntry.
        /// </summary>
        [DataMember]
        public OrderEntry OrderEntry { get; set; }
        /// <summary>
        /// Gets or sets the StatementDate.
        /// </summary>
        [DataMember]
        public DateTime StatementDate { get; set; }
        /// <summary>
        /// Gets or sets the IsTrackingEnabled.
        /// </summary>
        [DataMember]
        public Boolean IsTrackingEnabled { get; set; }
        /// <summary>
        /// Gets or sets the IsBacktestOrder.
        /// </summary>
        [DataMember]
        public Boolean IsBacktestOrder { get; set; }
        /// <summary>
        /// Gets or sets the TrackingIndicator.
        /// </summary>
        [DataMember]
        public IndicatorBase TrackingIndicator { get; set; }
        /// <summary>
        /// Gets or sets the UserData.
        /// </summary>
        [DataMember]
        public XDocument UserData { get; set; }
        /// <summary>
        /// Gets or sets the Account.
        /// </summary>
        [DataMember]
        public Account Account { get; set; }
        /// <summary>
        /// Gets or sets the AverageFillPrice.
        /// </summary>
        [DataMember]
        public Double AverageFillPrice { get; set; }
        /// <summary>
        /// Gets or sets the CustomOrder.
        /// </summary>
        [DataMember]
        public CustomOrder CustomOrder { get; set; }
        /// <summary>
        /// Gets or sets the Filled.
        /// </summary>
        [DataMember]
        public Int32 Filled { get; set; }
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
        /// Gets or sets the Instrument.
        /// </summary>
        [DataMember]
        public Instrument Instrument { get; set; }
        /// <summary>
        /// Gets or sets the IsLimit.
        /// </summary>
        [DataMember]
        public Boolean IsLimit { get; set; }
        /// <summary>
        /// Gets or sets the IsMarket.
        /// </summary>
        [DataMember]
        public Boolean IsMarket { get; set; }
        /// <summary>
        /// Gets or sets the IsMarketIfTouched.
        /// </summary>
        [DataMember]
        public Boolean IsMarketIfTouched { get; set; }
        /// <summary>
        /// Gets or sets the IsSimulatedStop.
        /// </summary>
        [DataMember]
        public Boolean IsSimulatedStop { get; set; }
        /// <summary>
        /// Gets or sets the IsLong.
        /// </summary>
        [DataMember]
        public Boolean IsLong { get; set; }
        /// <summary>
        /// Gets or sets the IsShort.
        /// </summary>
        [DataMember]
        public Boolean IsShort { get; set; }
        /// <summary>
        /// Gets or sets the IsStopMarket.
        /// </summary>
        [DataMember]
        public Boolean IsStopMarket { get; set; }
        /// <summary>
        /// Gets or sets the IsStopLimit.
        /// </summary>
        [DataMember]
        public Boolean IsStopLimit { get; set; }
        /// <summary>
        /// Gets or sets the LimitPrice.
        /// </summary>
        [DataMember]
        public Double LimitPrice { get; set; }
        /// <summary>
        /// Gets or sets the LimitPriceChanged.
        /// </summary>
        [DataMember]
        public Double LimitPriceChanged { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public String Name { get; set; }
        /// <summary>
        /// Gets or sets the Oco.
        /// </summary>
        [DataMember]
        public String Oco { get; set; }
        /// <summary>
        /// Gets or sets the OrderAction.
        /// </summary>
        [DataMember]
        public OrderAction OrderAction { get; set; }
        /// <summary>
        /// Gets or sets the OrderId.
        /// </summary>
        [DataMember]
        public String OrderId { get; set; }
        /// <summary>
        /// Gets or sets the OrderState.
        /// </summary>
        [DataMember]
        public OrderState OrderState { get; set; }
        /// <summary>
        /// Gets or sets the OrderType.
        /// </summary>
        [DataMember]
        public OrderType OrderType { get; set; }
        /// <summary>
        /// Gets or sets the OrderTypeString.
        /// </summary>
        [DataMember]
        public String OrderTypeString { get; set; }
        /// <summary>
        /// Gets or sets the OrderUpdates.
        /// </summary>
        [DataMember]
        public IList<OrderEventArgs> OrderUpdates { get; set; }
        /// <summary>
        /// Gets or sets the Quantity.
        /// </summary>
        [DataMember]
        public Int32 Quantity { get; set; }
        /// <summary>
        /// Gets or sets the QuantityChanged.
        /// </summary>
        [DataMember]
        public Int32 QuantityChanged { get; set; }
        /// <summary>
        /// Gets or sets the StopPrice.
        /// </summary>
        [DataMember]
        public Double StopPrice { get; set; }
        /// <summary>
        /// Gets or sets the StopPriceChanged.
        /// </summary>
        [DataMember]
        public Double StopPriceChanged { get; set; }
        /// <summary>
        /// Gets or sets the Time.
        /// </summary>
        [DataMember]
        public DateTime Time { get; set; }
        /// <summary>
        /// Gets or sets the TimeInForce.
        /// </summary>
        [DataMember]
        public TimeInForce TimeInForce { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// ChangeQuantity method.
        /// </summary>
        /// <param name="orders">ICollection`1</param>
        /// <param name="newQuantity">Int32</param>
        /// <param name="quantityModification">QuantityModificationForStocks</param>
        /// <param name="onBehalfOf">String</param>
        public Void ChangeQuantity(ICollection<Order> orders, Int32 newQuantity, QuantityModificationForStocks quantityModification, String onBehalfOf);
        /// <summary>
        /// DbGet method.
        /// </summary>
        /// <param name="account">Account</param>
        /// <param name="minTime">DateTime</param>
        /// <param name="maxTime">DateTime</param>
        /// <returns>Collection`1</returns>
        public Collection<Order> DbGet(Account account, DateTime minTime, DateTime maxTime);
        /// <summary>
        /// DbGet method.
        /// </summary>
        /// <param name="orderId">String</param>
        /// <returns>Collection`1</returns>
        public Collection<Order> DbGet(String orderId);
        /// <summary>
        /// DbRemoveAll method.
        /// </summary>
        public Void DbRemoveAll();
        /// <summary>
        /// GetOutstandingQuantity method.
        /// </summary>
        /// <param name="orders">ICollection`1</param>
        /// <returns>Int32</returns>
        public Int32 GetOutstandingQuantity(ICollection<Order> orders);
        /// <summary>
        /// Init method.
        /// </summary>
        public Void Init();
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>String</returns>
        public String ToString();
        /// <summary>
        /// GetOwnerStrategy method.
        /// </summary>
        /// <returns>StrategyBase</returns>
        public StrategyBase GetOwnerStrategy();
        /// <summary>
        /// GetOwnerServerStrategy method.
        /// </summary>
        /// <returns>ServerAtmStrategy</returns>
        public ServerAtmStrategy GetOwnerServerStrategy();
        /// <summary>
        /// IsTerminalState method.
        /// </summary>
        /// <param name="orderState">OrderState</param>
        /// <returns>Boolean</returns>
        public Boolean IsTerminalState(OrderState orderState);
        /// <summary>
        /// Rewind method.
        /// </summary>
        /// <param name="connection">IConnection</param>
        /// <param name="message">String</param>
        public Void Rewind(IConnection connection, String message);
        #endregion
    }
}
