[Serializable]
[DataContract]
namespace NinjaTrader.Client
{
    public partial class Client : NinjaTrader.Client.IClient, System.IDisposable
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
        public int Ask(string instrument, double price, int size)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// AskPlayback method.
        /// </summary>
        /// <param name="instrument">string</param>
        /// <param name="price">double</param>
        /// <param name="size">int</param>
        /// <param name="timestamp">string</param>
        /// <returns>int</returns>
        public int AskPlayback(string instrument, double price, int size, string timestamp)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// AvgEntryPrice method.
        /// </summary>
        /// <param name="instrument">string</param>
        /// <param name="account">string</param>
        /// <returns>double</returns>
        public double AvgEntryPrice(string instrument, string account)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// AvgFillPrice method.
        /// </summary>
        /// <param name="orderId">string</param>
        /// <returns>double</returns>
        public double AvgFillPrice(string orderId)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Bid method.
        /// </summary>
        /// <param name="instrument">string</param>
        /// <param name="price">double</param>
        /// <param name="size">int</param>
        /// <returns>int</returns>
        public int Bid(string instrument, double price, int size)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// BidPlayback method.
        /// </summary>
        /// <param name="instrument">string</param>
        /// <param name="price">double</param>
        /// <param name="size">int</param>
        /// <param name="timestamp">string</param>
        /// <returns>int</returns>
        public int BidPlayback(string instrument, double price, int size, string timestamp)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// BuyingPower method.
        /// </summary>
        /// <param name="account">string</param>
        /// <returns>double</returns>
        public double BuyingPower(string account)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// CashValue method.
        /// </summary>
        /// <param name="account">string</param>
        /// <returns>double</returns>
        public double CashValue(string account)
        {
            // Method implementation goes here
        }
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
        public int Command(string command, string account, string instrument, string action, int quantity, string orderType, double limitPrice, double stopPrice, string timeInForce, string oco, string orderId, string tpl, string strategy)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ConfirmOrders method.
        /// </summary>
        /// <param name="confirm">int</param>
        /// <returns>int</returns>
        public int ConfirmOrders(int confirm)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Connected method.
        /// </summary>
        /// <param name="showMessage">int</param>
        /// <returns>int</returns>
        public int Connected(int showMessage)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Dispose method.
        /// </summary>
        public void Dispose()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Filled method.
        /// </summary>
        /// <param name="orderId">string</param>
        /// <returns>int</returns>
        public int Filled(string orderId)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetDouble method.
        /// </summary>
        /// <param name="key">string</param>
        /// <returns>double</returns>
        public double GetDouble(string key)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetInt method.
        /// </summary>
        /// <param name="key">string</param>
        /// <returns>int</returns>
        public int GetInt(string key)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetString method.
        /// </summary>
        /// <param name="key">string</param>
        /// <returns>string</returns>
        public string GetString(string key)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Last method.
        /// </summary>
        /// <param name="instrument">string</param>
        /// <param name="price">double</param>
        /// <param name="size">int</param>
        /// <returns>int</returns>
        public int Last(string instrument, double price, int size)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// LastPlayback method.
        /// </summary>
        /// <param name="instrument">string</param>
        /// <param name="price">double</param>
        /// <param name="size">int</param>
        /// <param name="timestamp">string</param>
        /// <returns>int</returns>
        public int LastPlayback(string instrument, double price, int size, string timestamp)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// MarketData method.
        /// </summary>
        /// <param name="instrument">string</param>
        /// <param name="type">int</param>
        /// <returns>double</returns>
        public double MarketData(string instrument, int type)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// MarketPosition method.
        /// </summary>
        /// <param name="instrument">string</param>
        /// <param name="account">string</param>
        /// <returns>int</returns>
        public int MarketPosition(string instrument, string account)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// NewOrderId method.
        /// </summary>
        /// <returns>string</returns>
        public string NewOrderId()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Orders method.
        /// </summary>
        /// <param name="account">string</param>
        /// <returns>string</returns>
        public string Orders(string account)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// OrderStatus method.
        /// </summary>
        /// <param name="orderId">string</param>
        /// <returns>string</returns>
        public string OrderStatus(string orderId)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// QueryInstrument method.
        /// </summary>
        /// <returns>string</returns>
        public string QueryInstrument()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// RealizedPnL method.
        /// </summary>
        /// <param name="account">string</param>
        /// <returns>double</returns>
        public double RealizedPnL(string account)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SetAllocReturnString method.
        /// </summary>
        /// <param name="value">int</param>
        /// <returns>int</returns>
        public int SetAllocReturnString(int value)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SetMaxReturnStringLength method.
        /// </summary>
        /// <param name="value">int</param>
        /// <returns>int</returns>
        public int SetMaxReturnStringLength(int value)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SetUp method.
        /// </summary>
        /// <param name="host">string</param>
        /// <param name="port">int</param>
        /// <returns>int</returns>
        public int SetUp(string host, int port)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// StopOrders method.
        /// </summary>
        /// <param name="strategyId">string</param>
        /// <returns>string</returns>
        public string StopOrders(string strategyId)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Strategies method.
        /// </summary>
        /// <param name="account">string</param>
        /// <returns>string</returns>
        public string Strategies(string account)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// StrategyPosition method.
        /// </summary>
        /// <param name="strategyId">string</param>
        /// <returns>int</returns>
        public int StrategyPosition(string strategyId)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SubscribeMarketData method.
        /// </summary>
        /// <param name="instrument">string</param>
        /// <returns>int</returns>
        public int SubscribeMarketData(string instrument)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// TargetOrders method.
        /// </summary>
        /// <param name="strategyId">string</param>
        /// <returns>string</returns>
        public string TargetOrders(string strategyId)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// TearDown method.
        /// </summary>
        /// <returns>int</returns>
        public int TearDown()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// UnsubscribeMarketData method.
        /// </summary>
        /// <param name="instrument">string</param>
        /// <returns>int</returns>
        public int UnsubscribeMarketData(string instrument)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
