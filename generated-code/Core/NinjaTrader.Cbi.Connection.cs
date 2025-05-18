[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class Connection : IConnection, IDisposable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Dispatcher.
        /// </summary>
        [DataMember]
        public Dispatcher Dispatcher { get; set; }
        /// <summary>
        /// Gets or sets the FundamentalDataTypes.
        /// </summary>
        [DataMember]
        public FundamentalDataType[] FundamentalDataTypes { get; set; }
        /// <summary>
        /// Gets or sets the NewsProviders.
        /// </summary>
        [DataMember]
        public NewsProvider[] NewsProviders { get; set; }
        /// <summary>
        /// Gets or sets the Now.
        /// </summary>
        [DataMember]
        public DateTime Now { get; set; }
        /// <summary>
        /// Gets or sets the PlaybackConnection.
        /// </summary>
        [DataMember]
        public Connection PlaybackConnection { get; set; }
        /// <summary>
        /// Gets or sets the UseFifo4AveragePrice.
        /// </summary>
        [DataMember]
        public Boolean UseFifo4AveragePrice { get; set; }
        /// <summary>
        /// Gets or sets the UserEntitlement.
        /// </summary>
        [DataMember]
        public IUserEntitlement UserEntitlement { get; set; }
        /// <summary>
        /// Gets or sets the AccountItems.
        /// </summary>
        [DataMember]
        public AccountItem[] AccountItems { get; set; }
        /// <summary>
        /// Gets or sets the Accounts.
        /// </summary>
        [DataMember]
        public IList<Account> Accounts { get; set; }
        /// <summary>
        /// Gets or sets the Adapter.
        /// </summary>
        [DataMember]
        public IAdapter Adapter { get; set; }
        /// <summary>
        /// Gets or sets the ClientConnection.
        /// </summary>
        [DataMember]
        public Connection ClientConnection { get; set; }
        /// <summary>
        /// Gets or sets the Connections.
        /// </summary>
        [DataMember]
        public Collection<Connection> Connections { get; set; }
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
        /// Gets or sets the Options.
        /// </summary>
        [DataMember]
        public ConnectOptions Options { get; set; }
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
        public Trace Trace { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// CancelAllOrders method.
        /// </summary>
        public Void CancelAllOrders();
        /// <summary>
        /// Connect method.
        /// </summary>
        /// <param name="options">ConnectOptions</param>
        /// <returns>Connection</returns>
        public Connection Connect(ConnectOptions options);
        /// <summary>
        /// ConnectionStatusCallback method.
        /// </summary>
        /// <param name="status">ConnectionStatus</param>
        /// <param name="priceStatus">ConnectionStatus</param>
        /// <param name="errorCode">ErrorCode</param>
        /// <param name="nativeError">String</param>
        public Void ConnectionStatusCallback(ConnectionStatus status, ConnectionStatus priceStatus, ErrorCode errorCode, String nativeError);
        /// <summary>
        /// CreateAccount method.
        /// </summary>
        /// <param name="accountName">String</param>
        /// <param name="displayName">String</param>
        /// <param name="fcm">String</param>
        /// <param name="denomination">Currency</param>
        /// <param name="forexLotSize">Int32</param>
        /// <param name="callback">Action`4</param>
        /// <param name="state">Object</param>
        public Void CreateAccount(String accountName, String displayName, String fcm, Currency denomination, Int32 forexLotSize, Action<Account, ErrorCode, String, Object> callback, Object state);
        /// <summary>
        /// CreateOrder method.
        /// </summary>
        /// <param name="account">Account</param>
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
        /// <param name="callback">Action`4</param>
        /// <param name="state">Object</param>
        public Void CreateOrder(Account account, Instrument instrument, OrderAction action, OrderType orderType, OrderEntry orderEntry, TimeInForce timeInForce, Int32 quantity, Double limitPrice, Double stopPrice, Int32 filled, Double averageFillPrice, OrderState initialOrderState, String initialOrderId, DateTime time, String oco, String name, DateTime gtd, String comment, DateTime statementDate, Action<Order, ErrorCode, String, Object> callback, Object state);
        /// <summary>
        /// Dispose method.
        /// </summary>
        public Void Dispose();
        /// <summary>
        /// NewsCallback method.
        /// </summary>
        /// <param name="id">String</param>
        /// <param name="newsProvider">NewsProvider</param>
        /// <param name="time">DateTime</param>
        /// <param name="headline">String</param>
        /// <param name="newsText">String</param>
        /// <param name="url">Uri</param>
        public Void NewsCallback(String id, NewsProvider newsProvider, DateTime time, String headline, String newsText, Uri url);
        /// <summary>
        /// RecaptchaCallback method.
        /// </summary>
        /// <param name="callback">Action`2</param>
        public Void RecaptchaCallback(Action<Boolean, String> callback);
        /// <summary>
        /// ResolveInstrument method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        /// <param name="callback">Action`3</param>
        public Void ResolveInstrument(Instrument instrument, Action<Instrument, ErrorCode, String> callback);
        /// <summary>
        /// ResolveSymbol method.
        /// </summary>
        /// <param name="symbol">String</param>
        /// <param name="instrumentType">InstrumentType</param>
        /// <param name="exchange">Exchange</param>
        /// <param name="expiry">DateTime</param>
        /// <param name="strikePrice">Double</param>
        /// <param name="right">OptionRight</param>
        /// <param name="create">Boolean</param>
        /// <param name="callback">Action`4</param>
        /// <param name="state">Object</param>
        public Void ResolveSymbol(String symbol, InstrumentType instrumentType, Exchange exchange, DateTime expiry, Double strikePrice, OptionRight right, Boolean create, Action<Instrument, ErrorCode, String, Object> callback, Object state);
        /// <summary>
        /// TimerCallback method.
        /// </summary>
        /// <param name="localTime">DateTime</param>
        public Void TimerCallback(DateTime localTime);
        /// <summary>
        /// AccountItemUpdateCallback method.
        /// </summary>
        /// <param name="account">Account</param>
        /// <param name="accountItem">AccountItem</param>
        /// <param name="currency">Currency</param>
        /// <param name="value">Double</param>
        /// <param name="time">DateTime</param>
        public Void AccountItemUpdateCallback(Account account, AccountItem accountItem, Currency currency, Double value, DateTime time);
        /// <summary>
        /// CreateVolatileInstrument method.
        /// </summary>
        /// <param name="instrumentInfo">InstrumentInfo</param>
        public Void CreateVolatileInstrument(InstrumentInfo instrumentInfo);
        /// <summary>
        /// DelayedDataCallback method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        public Void DelayedDataCallback(Instrument instrument);
        /// <summary>
        /// Disconnect method.
        /// </summary>
        public Void Disconnect();
        /// <summary>
        /// ExecutionUpdateCallback method.
        /// </summary>
        /// <param name="account">Account</param>
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
        /// <param name="sod">Boolean</param>
        /// <param name="statementDate">DateTime</param>
        /// <param name="operation">Operation</param>
        public Void ExecutionUpdateCallback(Account account, Instrument instrument, String executionId, Exchange exchange, DateTime time, MarketPosition marketPosition, String orderId, Int32 quantity, Double price, Double commission, Double fee, Boolean sod, DateTime statementDate, Operation operation);
        /// <summary>
        /// LogCallback method.
        /// </summary>
        /// <param name="resourceType">Type</param>
        /// <param name="name">String</param>
        /// <param name="args">Object[]</param>
        /// <param name="logLevel">LogLevel</param>
        /// <param name="logCategory">LogCategories</param>
        /// <param name="account">Account</param>
        public Void LogCallback(Type resourceType, String name, Object[] args, LogLevel logLevel, LogCategories logCategory, Account account);
        /// <summary>
        /// NotificationCallback method.
        /// </summary>
        /// <param name="account">Account</param>
        /// <param name="id">Int64</param>
        /// <param name="text">String</param>
        /// <param name="timestamp">DateTime</param>
        /// <param name="completed">DateTime</param>
        /// <param name="emailSent">Boolean</param>
        /// <param name="showAsPopup">Boolean</param>
        public Void NotificationCallback(Account account, Int64 id, String text, DateTime timestamp, DateTime completed, Boolean emailSent, Boolean showAsPopup);
        /// <summary>
        /// OrderUpdateCallback method.
        /// </summary>
        /// <param name="account">Account</param>
        /// <param name="order">Order</param>
        /// <param name="orderId">String</param>
        /// <param name="limitPrice">Double</param>
        /// <param name="stopPrice">Double</param>
        /// <param name="quantity">Int32</param>
        /// <param name="averageFillPrice">Double</param>
        /// <param name="filled">Int32</param>
        /// <param name="orderState">OrderState</param>
        /// <param name="time">DateTime</param>
        /// <param name="errorCode">ErrorCode</param>
        /// <param name="comment">String</param>
        /// <param name="statementDate">DateTime</param>
        public Void OrderUpdateCallback(Account account, Order order, String orderId, Double limitPrice, Double stopPrice, Int32 quantity, Double averageFillPrice, Int32 filled, OrderState orderState, DateTime time, ErrorCode errorCode, String comment, DateTime statementDate);
        /// <summary>
        /// PositionUpdateCallback method.
        /// </summary>
        /// <param name="account">Account</param>
        /// <param name="instrument">Instrument</param>
        /// <param name="marketPosition">MarketPosition</param>
        /// <param name="quantity">Int32</param>
        /// <param name="averagePrice">Double</param>
        /// <param name="operation">Operation</param>
        public Void PositionUpdateCallback(Account account, Instrument instrument, MarketPosition marketPosition, Int32 quantity, Double averagePrice, Operation operation);
        /// <summary>
        /// QueryOptionChainAsync method.
        /// </summary>
        /// <param name="underlying">Instrument</param>
        /// <returns>Task`1</returns>
        public Task<Instrument[]> QueryOptionChainAsync(Instrument underlying);
        /// <summary>
        /// RaiseDelayedDataEvent method.
        /// </summary>
        /// <param name="e">DelayedDataArgs</param>
        public Void RaiseDelayedDataEvent(DelayedDataArgs e);
        /// <summary>
        /// RaiseServerAtmStrategyUpdate method.
        /// </summary>
        /// <param name="e">ServerAtmStrategyUpdateArgs</param>
        public Void RaiseServerAtmStrategyUpdate(ServerAtmStrategyUpdateArgs e);
        /// <summary>
        /// ServerAtmStrategyCallback method.
        /// </summary>
        /// <param name="account">Account</param>
        /// <param name="instrument">Instrument</param>
        /// <param name="strategyId">Int64</param>
        /// <param name="name">String</param>
        /// <param name="status">ServerStrategyStatus</param>
        /// <param name="orderId">String</param>
        /// <param name="errorMessage">String</param>
        /// <param name="time">DateTime</param>
        /// <param name="operation">Operation</param>
        public Void ServerAtmStrategyCallback(Account account, Instrument instrument, Int64 strategyId, String name, ServerStrategyStatus status, String orderId, String errorMessage, DateTime time, Operation operation);
        /// <summary>
        /// TraceCallback method.
        /// </summary>
        /// <param name="message">String</param>
        public Void TraceCallback(String message);
        #endregion
    }
}
