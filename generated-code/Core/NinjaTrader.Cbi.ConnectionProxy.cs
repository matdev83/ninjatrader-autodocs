[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class ConnectionProxy : NinjaTrader.Cbi.IConnection
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AccountItems.
        /// </summary>
        [DataMember]
        public AccountItem[] AccountItems { get; set; }
        /// <summary>
        /// Gets or sets the Accounts.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.IList<NinjaTrader.Cbi.Account> Accounts { get; set; }
        /// <summary>
        /// Gets or sets the Currencies.
        /// </summary>
        [DataMember]
        public Currency[] Currencies { get; set; }
        /// <summary>
        /// Gets or sets the Features.
        /// </summary>
        [DataMember]
        public Feature[] Features { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataTypes.
        /// </summary>
        [DataMember]
        public FundamentalDataType[] FundamentalDataTypes { get; set; }
        /// <summary>
        /// Gets or sets the InstrumentTypes.
        /// </summary>
        [DataMember]
        public InstrumentType[] InstrumentTypes { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataTypes.
        /// </summary>
        [DataMember]
        public MarketDataType[] MarketDataTypes { get; set; }
        /// <summary>
        /// Gets or sets the NewsProviders.
        /// </summary>
        [DataMember]
        public NewsProvider[] NewsProviders { get; set; }
        /// <summary>
        /// Gets or sets the NT.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.NinjaTraderProxy NT { get; set; }
        /// <summary>
        /// Gets or sets the Options.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.ConnectOptions Options { get; set; }
        /// <summary>
        /// Gets or sets the OrderTypes.
        /// </summary>
        [DataMember]
        public OrderType[] OrderTypes { get; set; }
        /// <summary>
        /// Gets or sets the PriceStatus.
        /// </summary>
        [DataMember]
        public ConnectionStatus PriceStatus { get; set; }
        /// <summary>
        /// Gets or sets the Status.
        /// </summary>
        [DataMember]
        public ConnectionStatus Status { get; set; }
        /// <summary>
        /// Gets or sets the TimeInForces.
        /// </summary>
        [DataMember]
        public TimeInForce[] TimeInForces { get; set; }
        /// <summary>
        /// Gets or sets the Trace.
        /// </summary>
        [DataMember]
        public NinjaTrader.Core.Trace Trace { get; set; }
        /// <summary>
        /// Gets or sets the UseFifo4AveragePrice.
        /// </summary>
        [DataMember]
        public bool UseFifo4AveragePrice { get; set; }
        /// <summary>
        /// Gets or sets the UserEntitlement.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.IUserEntitlement UserEntitlement { get; set; }
        /// <summary>
        /// Gets or sets the Now.
        /// </summary>
        [DataMember]
        public System.DateTime Now { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// AccountItemUpdateCallback method.
        /// </summary>
        /// <param name="account">NinjaTrader.Cbi.Account</param>
        /// <param name="accountItem">AccountItem</param>
        /// <param name="currency">Currency</param>
        /// <param name="value">double</param>
        /// <param name="time">System.DateTime</param>
        public void AccountItemUpdateCallback(NinjaTrader.Cbi.Account account, AccountItem accountItem, Currency currency, double value, System.DateTime time)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ConnectionStatusCallback method.
        /// </summary>
        /// <param name="status">ConnectionStatus</param>
        /// <param name="priceStatus">ConnectionStatus</param>
        /// <param name="errorCode">ErrorCode</param>
        /// <param name="nativeError">string</param>
        public void ConnectionStatusCallback(ConnectionStatus status, ConnectionStatus priceStatus, ErrorCode errorCode, string nativeError)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// CreateAccount method.
        /// </summary>
        /// <param name="accountName">string</param>
        /// <param name="displayName">string</param>
        /// <param name="fcm">string</param>
        /// <param name="denomination">Currency</param>
        /// <param name="forexLotSize">int</param>
        /// <param name="callback">System.Action<NinjaTrader.Cbi.Account, ErrorCode, string, object></param>
        /// <param name="state">object</param>
        public void CreateAccount(string accountName, string displayName, string fcm, Currency denomination, int forexLotSize, System.Action<NinjaTrader.Cbi.Account, ErrorCode, string, object> callback, object state)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// CreateOrder method.
        /// </summary>
        /// <param name="account">NinjaTrader.Cbi.Account</param>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        /// <param name="orderAction">OrderAction</param>
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
        /// <param name="callback">System.Action<NinjaTrader.Cbi.Order, ErrorCode, string, object></param>
        /// <param name="state">object</param>
        public void CreateOrder(NinjaTrader.Cbi.Account account, NinjaTrader.Cbi.Instrument instrument, OrderAction orderAction, OrderType orderType, OrderEntry orderEntry, TimeInForce timeInForce, int quantity, double limitPrice, double stopPrice, int filled, double averageFillPrice, OrderState initialOrderState, string initialOrderId, System.DateTime time, string oco, string name, System.DateTime gtd, string comment, System.DateTime statementDate, System.Action<NinjaTrader.Cbi.Order, ErrorCode, string, object> callback, object state)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// CreateVolatileInstrument method.
        /// </summary>
        /// <param name="instrumentInfo">NinjaTrader.Adapter.InstrumentInfo</param>
        public void CreateVolatileInstrument(NinjaTrader.Adapter.InstrumentInfo instrumentInfo)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DelayedDataCallback method.
        /// </summary>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        public void DelayedDataCallback(NinjaTrader.Cbi.Instrument instrument)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Disconnect method.
        /// </summary>
        public void Disconnect()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ExecutionUpdateCallback method.
        /// </summary>
        /// <param name="account">NinjaTrader.Cbi.Account</param>
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
        public void ExecutionUpdateCallback(NinjaTrader.Cbi.Account account, NinjaTrader.Cbi.Instrument instrument, string executionId, Exchange exchange, System.DateTime time, MarketPosition marketPosition, string orderId, int quantity, double price, double commission, double fee, bool isSod, System.DateTime statementDate, Operation operation)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GenericCallback method.
        /// </summary>
        public void GenericCallback()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// LogCallback method.
        /// </summary>
        /// <param name="resourceType">System.Type</param>
        /// <param name="name">string</param>
        /// <param name="args">System.Object[]</param>
        /// <param name="logLevel">LogLevel</param>
        /// <param name="logCategory">LogCategories</param>
        /// <param name="account">NinjaTrader.Cbi.Account</param>
        public void LogCallback(System.Type resourceType, string name, System.Object[] args, LogLevel logLevel, LogCategories logCategory, NinjaTrader.Cbi.Account account)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// NewsCallback method.
        /// </summary>
        /// <param name="id">string</param>
        /// <param name="newsProvider">NewsProvider</param>
        /// <param name="time">System.DateTime</param>
        /// <param name="headline">string</param>
        /// <param name="text">string</param>
        /// <param name="url">System.Uri</param>
        public void NewsCallback(string id, NewsProvider newsProvider, System.DateTime time, string headline, string text, System.Uri url)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// NotificationCallback method.
        /// </summary>
        /// <param name="account">NinjaTrader.Cbi.Account</param>
        /// <param name="id">long</param>
        /// <param name="text">string</param>
        /// <param name="timestamp">System.DateTime</param>
        /// <param name="completed">System.DateTime</param>
        /// <param name="emailSent">bool</param>
        /// <param name="showAsPopup">bool</param>
        public void NotificationCallback(NinjaTrader.Cbi.Account account, long id, string text, System.DateTime timestamp, System.DateTime completed, bool emailSent, bool showAsPopup)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ServerAtmStrategyCallback method.
        /// </summary>
        /// <param name="account">NinjaTrader.Cbi.Account</param>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        /// <param name="strategyId">long</param>
        /// <param name="name">string</param>
        /// <param name="status">ServerStrategyStatus</param>
        /// <param name="orderId">string</param>
        /// <param name="errorMessage">string</param>
        /// <param name="time">System.DateTime</param>
        /// <param name="operation">Operation</param>
        public void ServerAtmStrategyCallback(NinjaTrader.Cbi.Account account, NinjaTrader.Cbi.Instrument instrument, long strategyId, string name, ServerStrategyStatus status, string orderId, string errorMessage, System.DateTime time, Operation operation)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// OrderUpdateCallback method.
        /// </summary>
        /// <param name="account">NinjaTrader.Cbi.Account</param>
        /// <param name="order">NinjaTrader.Cbi.Order</param>
        /// <param name="orderId">string</param>
        /// <param name="limitPrice">double</param>
        /// <param name="stopPrice">double</param>
        /// <param name="quantity">int</param>
        /// <param name="averageFillPrice">double</param>
        /// <param name="filled">int</param>
        /// <param name="orderState">OrderState</param>
        /// <param name="time">System.DateTime</param>
        /// <param name="errorCode">ErrorCode</param>
        /// <param name="comment">string</param>
        /// <param name="statementDate">System.DateTime</param>
        public void OrderUpdateCallback(NinjaTrader.Cbi.Account account, NinjaTrader.Cbi.Order order, string orderId, double limitPrice, double stopPrice, int quantity, double averageFillPrice, int filled, OrderState orderState, System.DateTime time, ErrorCode errorCode, string comment, System.DateTime statementDate)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// PositionUpdateCallback method.
        /// </summary>
        /// <param name="account">NinjaTrader.Cbi.Account</param>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        /// <param name="marketPosition">MarketPosition</param>
        /// <param name="quantity">int</param>
        /// <param name="averagePrice">double</param>
        /// <param name="operation">Operation</param>
        public void PositionUpdateCallback(NinjaTrader.Cbi.Account account, NinjaTrader.Cbi.Instrument instrument, MarketPosition marketPosition, int quantity, double averagePrice, Operation operation)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// RecaptchaCallback method.
        /// </summary>
        /// <param name="callback">System.Action<bool, string></param>
        public void RecaptchaCallback(System.Action<bool, string> callback)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ResolveSymbol method.
        /// </summary>
        /// <param name="symbol">string</param>
        /// <param name="instrumentType">InstrumentType</param>
        /// <param name="exchange">Exchange</param>
        /// <param name="expiry">System.DateTime</param>
        /// <param name="strikePrice">double</param>
        /// <param name="right">OptionRight</param>
        /// <param name="create">bool</param>
        /// <param name="callback">System.Action<NinjaTrader.Cbi.Instrument, ErrorCode, string, object></param>
        /// <param name="state">object</param>
        public void ResolveSymbol(string symbol, InstrumentType instrumentType, Exchange exchange, System.DateTime expiry, double strikePrice, OptionRight right, bool create, System.Action<NinjaTrader.Cbi.Instrument, ErrorCode, string, object> callback, object state)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// TimerCallback method.
        /// </summary>
        /// <param name="time">System.DateTime</param>
        public void TimerCallback(System.DateTime time)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// TraceCallback method.
        /// </summary>
        /// <param name="message">string</param>
        public void TraceCallback(string message)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// TraceCallback method.
        /// </summary>
        /// <param name="func">System.Func<object, string></param>
        /// <param name="args">object</param>
        public void TraceCallback(System.Func<object, string> func, object args)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
