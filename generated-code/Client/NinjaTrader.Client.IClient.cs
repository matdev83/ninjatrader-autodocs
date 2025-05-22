namespace NinjaTrader.Client
{
    public partial interface IClient
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// Ask method.
        /// </summary>
        /// <param name="instrument">string</param>
        /// <param name="price">double</param>
        /// <param name="size">int</param>
        /// <returns>int</returns>
        public int Ask(string instrument, double price, int size);
        /// <summary>
        /// AskPlayback method.
        /// </summary>
        /// <param name="instrument">string</param>
        /// <param name="price">double</param>
        /// <param name="size">int</param>
        /// <param name="timestamp">string</param>
        /// <returns>int</returns>
        public int AskPlayback(string instrument, double price, int size, string timestamp);
        /// <summary>
        /// AvgEntryPrice method.
        /// </summary>
        /// <param name="instrument">string</param>
        /// <param name="account">string</param>
        /// <returns>double</returns>
        public double AvgEntryPrice(string instrument, string account);
        /// <summary>
        /// AvgFillPrice method.
        /// </summary>
        /// <param name="orderId">string</param>
        /// <returns>double</returns>
        public double AvgFillPrice(string orderId);
        /// <summary>
        /// Bid method.
        /// </summary>
        /// <param name="instrument">string</param>
        /// <param name="price">double</param>
        /// <param name="size">int</param>
        /// <returns>int</returns>
        public int Bid(string instrument, double price, int size);
        /// <summary>
        /// BidPlayback method.
        /// </summary>
        /// <param name="instrument">string</param>
        /// <param name="price">double</param>
        /// <param name="size">int</param>
        /// <param name="timestamp">string</param>
        /// <returns>int</returns>
        public int BidPlayback(string instrument, double price, int size, string timestamp);
        /// <summary>
        /// BuyingPower method.
        /// </summary>
        /// <param name="account">string</param>
        /// <returns>double</returns>
        public double BuyingPower(string account);
        /// <summary>
        /// CashValue method.
        /// </summary>
        /// <param name="account">string</param>
        /// <returns>double</returns>
        public double CashValue(string account);
        /// <summary>
        /// Command method.
        /// </summary>
        /// <param name="command">string</param>
        /// <param name="account">string</param>
        /// <param name="instrument">string</param>
        /// <param name="action">string</param>
        /// <param name="quantity">int</param>
        /// <param name="orderType">string</param>
        /// <param name="limitPrice">double</param>
        /// <param name="stopPrice">double</param>
        /// <param name="timeInForce">string</param>
        /// <param name="oco">string</param>
        /// <param name="orderId">string</param>
        /// <param name="tpl">string</param>
        /// <param name="strategy">string</param>
        /// <returns>int</returns>
        public int Command(string command, string account, string instrument, string action, int quantity, string orderType, double limitPrice, double stopPrice, string timeInForce, string oco, string orderId, string tpl, string strategy);
        /// <summary>
        /// ConfirmOrders method.
        /// </summary>
        /// <param name="confirm">int</param>
        /// <returns>int</returns>
        public int ConfirmOrders(int confirm);
        /// <summary>
        /// Connected method.
        /// </summary>
        /// <param name="showMessage">int</param>
        /// <returns>int</returns>
        public int Connected(int showMessage);
        /// <summary>
        /// Filled method.
        /// </summary>
        /// <param name="orderId">string</param>
        /// <returns>int</returns>
        public int Filled(string orderId);
        /// <summary>
        /// GetDouble method.
        /// </summary>
        /// <param name="key">string</param>
        /// <returns>double</returns>
        public double GetDouble(string key);
        /// <summary>
        /// GetInt method.
        /// </summary>
        /// <param name="key">string</param>
        /// <returns>int</returns>
        public int GetInt(string key);
        /// <summary>
        /// GetString method.
        /// </summary>
        /// <param name="key">string</param>
        /// <returns>string</returns>
        public string GetString(string key);
        /// <summary>
        /// Last method.
        /// </summary>
        /// <param name="instrument">string</param>
        /// <param name="price">double</param>
        /// <param name="size">int</param>
        /// <returns>int</returns>
        public int Last(string instrument, double price, int size);
        /// <summary>
        /// LastPlayback method.
        /// </summary>
        /// <param name="instrument">string</param>
        /// <param name="price">double</param>
        /// <param name="size">int</param>
        /// <param name="timestamp">string</param>
        /// <returns>int</returns>
        public int LastPlayback(string instrument, double price, int size, string timestamp);
        /// <summary>
        /// MarketData method.
        /// </summary>
        /// <param name="instrument">string</param>
        /// <param name="type">int</param>
        /// <returns>double</returns>
        public double MarketData(string instrument, int type);
        /// <summary>
        /// MarketPosition method.
        /// </summary>
        /// <param name="instrument">string</param>
        /// <param name="account">string</param>
        /// <returns>int</returns>
        public int MarketPosition(string instrument, string account);
        /// <summary>
        /// NewOrderId method.
        /// </summary>
        /// <returns>string</returns>
        public string NewOrderId();
        /// <summary>
        /// Orders method.
        /// </summary>
        /// <param name="account">string</param>
        /// <returns>string</returns>
        public string Orders(string account);
        /// <summary>
        /// OrderStatus method.
        /// </summary>
        /// <param name="orderId">string</param>
        /// <returns>string</returns>
        public string OrderStatus(string orderId);
        /// <summary>
        /// QueryInstrument method.
        /// </summary>
        /// <returns>string</returns>
        public string QueryInstrument();
        /// <summary>
        /// RealizedPnL method.
        /// </summary>
        /// <param name="account">string</param>
        /// <returns>double</returns>
        public double RealizedPnL(string account);
        /// <summary>
        /// SetAllocReturnString method.
        /// </summary>
        /// <param name="value">int</param>
        /// <returns>int</returns>
        public int SetAllocReturnString(int value);
        /// <summary>
        /// SetMaxReturnStringLength method.
        /// </summary>
        /// <param name="value">int</param>
        /// <returns>int</returns>
        public int SetMaxReturnStringLength(int value);
        /// <summary>
        /// SetUp method.
        /// </summary>
        /// <param name="host">string</param>
        /// <param name="port">int</param>
        /// <returns>int</returns>
        public int SetUp(string host, int port);
        /// <summary>
        /// StopOrders method.
        /// </summary>
        /// <param name="strategyId">string</param>
        /// <returns>string</returns>
        public string StopOrders(string strategyId);
        /// <summary>
        /// SubscribeMarketData method.
        /// </summary>
        /// <param name="instrument">string</param>
        /// <returns>int</returns>
        public int SubscribeMarketData(string instrument);
        /// <summary>
        /// Strategies method.
        /// </summary>
        /// <param name="account">string</param>
        /// <returns>string</returns>
        public string Strategies(string account);
        /// <summary>
        /// StrategyPosition method.
        /// </summary>
        /// <param name="strategyId">string</param>
        /// <returns>int</returns>
        public int StrategyPosition(string strategyId);
        /// <summary>
        /// TargetOrders method.
        /// </summary>
        /// <param name="strategyId">string</param>
        /// <returns>string</returns>
        public string TargetOrders(string strategyId);
        /// <summary>
        /// TearDown method.
        /// </summary>
        /// <returns>int</returns>
        public int TearDown();
        /// <summary>
        /// UnsubscribeMarketData method.
        /// </summary>
        /// <param name="instrument">string</param>
        /// <returns>int</returns>
        public int UnsubscribeMarketData(string instrument);
        #endregion
    }
}
