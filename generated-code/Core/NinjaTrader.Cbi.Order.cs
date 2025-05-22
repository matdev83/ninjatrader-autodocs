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
        public long ClientId { get; set; }
        /// <summary>
        /// Gets or sets the Stopwatch.
        /// </summary>
        [DataMember]
        public System.Diagnostics.Stopwatch Stopwatch { get; set; }
        /// <summary>
        /// Gets or sets the BacktestPassNumber.
        /// </summary>
        [DataMember]
        public long BacktestPassNumber { get; set; }
        /// <summary>
        /// Gets or sets the FromEntrySignal.
        /// </summary>
        [DataMember]
        public string FromEntrySignal { get; set; }
        /// <summary>
        /// Gets or sets the HasOverfill.
        /// </summary>
        [DataMember]
        public bool HasOverfill { get; set; }
        /// <summary>
        /// Gets or sets the IsLiveUntilCancelled.
        /// </summary>
        [DataMember]
        public bool IsLiveUntilCancelled { get; set; }
        /// <summary>
        /// Gets or sets the IsTrackingConfigured.
        /// </summary>
        [DataMember]
        public bool IsTrackingConfigured { get; set; }
        /// <summary>
        /// Gets or sets the OnBehalfOf.
        /// </summary>
        [DataMember]
        public string OnBehalfOf { get; set; }
        /// <summary>
        /// Gets or sets the OrderEntry.
        /// </summary>
        [DataMember]
        public OrderEntry OrderEntry { get; set; }
        /// <summary>
        /// Gets or sets the StatementDate.
        /// </summary>
        [DataMember]
        public System.DateTime StatementDate { get; set; }
        /// <summary>
        /// Gets or sets the IsTrackingEnabled.
        /// </summary>
        [DataMember]
        public bool IsTrackingEnabled { get; set; }
        /// <summary>
        /// Gets or sets the IsBacktestOrder.
        /// </summary>
        [DataMember]
        public bool IsBacktestOrder { get; set; }
        /// <summary>
        /// Gets or sets the TrackingIndicator.
        /// </summary>
        [DataMember]
        public NinjaTrader.NinjaScript.IndicatorBase TrackingIndicator { get; set; }
        /// <summary>
        /// Gets or sets the UserData.
        /// </summary>
        [DataMember]
        public System.Xml.Linq.XDocument UserData { get; set; }
        /// <summary>
        /// Gets or sets the Account.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Account Account { get; set; }
        /// <summary>
        /// Gets or sets the AverageFillPrice.
        /// </summary>
        [DataMember]
        public double AverageFillPrice { get; set; }
        /// <summary>
        /// Gets or sets the CustomOrder.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.CustomOrder CustomOrder { get; set; }
        /// <summary>
        /// Gets or sets the Filled.
        /// </summary>
        [DataMember]
        public int Filled { get; set; }
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
        /// Gets or sets the Instrument.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Instrument Instrument { get; set; }
        /// <summary>
        /// Gets or sets the IsLimit.
        /// </summary>
        [DataMember]
        public bool IsLimit { get; set; }
        /// <summary>
        /// Gets or sets the IsMarket.
        /// </summary>
        [DataMember]
        public bool IsMarket { get; set; }
        /// <summary>
        /// Gets or sets the IsMarketIfTouched.
        /// </summary>
        [DataMember]
        public bool IsMarketIfTouched { get; set; }
        /// <summary>
        /// Gets or sets the IsSimulatedStop.
        /// </summary>
        [DataMember]
        public bool IsSimulatedStop { get; set; }
        /// <summary>
        /// Gets or sets the IsLong.
        /// </summary>
        [DataMember]
        public bool IsLong { get; set; }
        /// <summary>
        /// Gets or sets the IsShort.
        /// </summary>
        [DataMember]
        public bool IsShort { get; set; }
        /// <summary>
        /// Gets or sets the IsStopMarket.
        /// </summary>
        [DataMember]
        public bool IsStopMarket { get; set; }
        /// <summary>
        /// Gets or sets the IsStopLimit.
        /// </summary>
        [DataMember]
        public bool IsStopLimit { get; set; }
        /// <summary>
        /// Gets or sets the LimitPrice.
        /// </summary>
        [DataMember]
        public double LimitPrice { get; set; }
        /// <summary>
        /// Gets or sets the LimitPriceChanged.
        /// </summary>
        [DataMember]
        public double LimitPriceChanged { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the Oco.
        /// </summary>
        [DataMember]
        public string Oco { get; set; }
        /// <summary>
        /// Gets or sets the OrderAction.
        /// </summary>
        [DataMember]
        public OrderAction OrderAction { get; set; }
        /// <summary>
        /// Gets or sets the OrderId.
        /// </summary>
        [DataMember]
        public string OrderId { get; set; }
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
        public string OrderTypeString { get; set; }
        /// <summary>
        /// Gets or sets the OrderUpdates.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.IList<NinjaTrader.Cbi.OrderEventArgs> OrderUpdates { get; set; }
        /// <summary>
        /// Gets or sets the Quantity.
        /// </summary>
        [DataMember]
        public int Quantity { get; set; }
        /// <summary>
        /// Gets or sets the QuantityChanged.
        /// </summary>
        [DataMember]
        public int QuantityChanged { get; set; }
        /// <summary>
        /// Gets or sets the StopPrice.
        /// </summary>
        [DataMember]
        public double StopPrice { get; set; }
        /// <summary>
        /// Gets or sets the StopPriceChanged.
        /// </summary>
        [DataMember]
        public double StopPriceChanged { get; set; }
        /// <summary>
        /// Gets or sets the Time.
        /// </summary>
        [DataMember]
        public System.DateTime Time { get; set; }
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
        /// <param name="orders">System.Collections.Generic.ICollection<NinjaTrader.Cbi.Order></param>
        /// <param name="newQuantity">int</param>
        /// <param name="quantityModification">QuantityModificationForStocks</param>
        /// <param name="onBehalfOf">string</param>
        public void ChangeQuantity(System.Collections.Generic.ICollection<NinjaTrader.Cbi.Order> orders, int newQuantity, QuantityModificationForStocks quantityModification, string onBehalfOf)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DbGet method.
        /// </summary>
        /// <param name="account">NinjaTrader.Cbi.Account</param>
        /// <param name="minTime">System.DateTime</param>
        /// <param name="maxTime">System.DateTime</param>
        /// <returns>System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Order></returns>
        public System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Order> DbGet(NinjaTrader.Cbi.Account account, System.DateTime minTime, System.DateTime maxTime)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DbGet method.
        /// </summary>
        /// <param name="orderId">string</param>
        /// <returns>System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Order></returns>
        public System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Order> DbGet(string orderId)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DbRemoveAll method.
        /// </summary>
        public void DbRemoveAll()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetOutstandingQuantity method.
        /// </summary>
        /// <param name="orders">System.Collections.Generic.ICollection<NinjaTrader.Cbi.Order></param>
        /// <returns>int</returns>
        public int GetOutstandingQuantity(System.Collections.Generic.ICollection<NinjaTrader.Cbi.Order> orders)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Init method.
        /// </summary>
        public void Init()
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
        /// GetOwnerStrategy method.
        /// </summary>
        /// <returns>NinjaTrader.NinjaScript.StrategyBase</returns>
        public NinjaTrader.NinjaScript.StrategyBase GetOwnerStrategy()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetOwnerServerStrategy method.
        /// </summary>
        /// <returns>NinjaTrader.ServerAtm.ServerAtmStrategy</returns>
        public NinjaTrader.ServerAtm.ServerAtmStrategy GetOwnerServerStrategy()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// IsTerminalState method.
        /// </summary>
        /// <param name="orderState">OrderState</param>
        /// <returns>bool</returns>
        public bool IsTerminalState(OrderState orderState)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Rewind method.
        /// </summary>
        /// <param name="connection">NinjaTrader.Cbi.IConnection</param>
        /// <param name="message">string</param>
        public void Rewind(NinjaTrader.Cbi.IConnection connection, string message)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
