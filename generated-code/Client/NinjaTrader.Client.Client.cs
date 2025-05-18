[Serializable]
[DataContract]
namespace NinjaTrader.Client
{
    public partial class Client : IClient, IDisposable
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// Ask method.
        /// </summary>
        /// <param name="instrument">String</param>
        /// <param name="price">Double</param>
        /// <param name="size">Int32</param>
        /// <returns>Int32</returns>
        public Int32 Ask(String instrument, Double price, Int32 size);
        /// <summary>
        /// AskPlayback method.
        /// </summary>
        /// <param name="instrument">String</param>
        /// <param name="price">Double</param>
        /// <param name="size">Int32</param>
        /// <param name="timestamp">String</param>
        /// <returns>Int32</returns>
        public Int32 AskPlayback(String instrument, Double price, Int32 size, String timestamp);
        /// <summary>
        /// AvgEntryPrice method.
        /// </summary>
        /// <param name="instrument">String</param>
        /// <param name="account">String</param>
        /// <returns>Double</returns>
        public Double AvgEntryPrice(String instrument, String account);
        /// <summary>
        /// AvgFillPrice method.
        /// </summary>
        /// <param name="orderId">String</param>
        /// <returns>Double</returns>
        public Double AvgFillPrice(String orderId);
        /// <summary>
        /// Bid method.
        /// </summary>
        /// <param name="instrument">String</param>
        /// <param name="price">Double</param>
        /// <param name="size">Int32</param>
        /// <returns>Int32</returns>
        public Int32 Bid(String instrument, Double price, Int32 size);
        /// <summary>
        /// BidPlayback method.
        /// </summary>
        /// <param name="instrument">String</param>
        /// <param name="price">Double</param>
        /// <param name="size">Int32</param>
        /// <param name="timestamp">String</param>
        /// <returns>Int32</returns>
        public Int32 BidPlayback(String instrument, Double price, Int32 size, String timestamp);
        /// <summary>
        /// BuyingPower method.
        /// </summary>
        /// <param name="account">String</param>
        /// <returns>Double</returns>
        public Double BuyingPower(String account);
        /// <summary>
        /// CashValue method.
        /// </summary>
        /// <param name="account">String</param>
        /// <returns>Double</returns>
        public Double CashValue(String account);
        /// <summary>
        /// Command method.
        /// </summary>
        /// <param name="command">String</param>
        /// <param name="account">String</param>
        /// <param name="instrument">String</param>
        /// <param name="action">String</param>
        /// <param name="quantity">Int32</param>
        /// <param name="orderType">String</param>
        /// <param name="limitPrice">Double</param>
        /// <param name="stopPrice">Double</param>
        /// <param name="timeInForce">String</param>
        /// <param name="oco">String</param>
        /// <param name="orderId">String</param>
        /// <param name="tpl">String</param>
        /// <param name="strategy">String</param>
        /// <returns>Int32</returns>
        public Int32 Command(String command, String account, String instrument, String action, Int32 quantity, String orderType, Double limitPrice, Double stopPrice, String timeInForce, String oco, String orderId, String tpl, String strategy);
        /// <summary>
        /// ConfirmOrders method.
        /// </summary>
        /// <param name="confirm">Int32</param>
        /// <returns>Int32</returns>
        public Int32 ConfirmOrders(Int32 confirm);
        /// <summary>
        /// Connected method.
        /// </summary>
        /// <param name="showMessage">Int32</param>
        /// <returns>Int32</returns>
        public Int32 Connected(Int32 showMessage);
        /// <summary>
        /// Dispose method.
        /// </summary>
        public Void Dispose();
        /// <summary>
        /// Filled method.
        /// </summary>
        /// <param name="orderId">String</param>
        /// <returns>Int32</returns>
        public Int32 Filled(String orderId);
        /// <summary>
        /// GetDouble method.
        /// </summary>
        /// <param name="key">String</param>
        /// <returns>Double</returns>
        public Double GetDouble(String key);
        /// <summary>
        /// GetInt method.
        /// </summary>
        /// <param name="key">String</param>
        /// <returns>Int32</returns>
        public Int32 GetInt(String key);
        /// <summary>
        /// GetString method.
        /// </summary>
        /// <param name="key">String</param>
        /// <returns>String</returns>
        public String GetString(String key);
        /// <summary>
        /// Last method.
        /// </summary>
        /// <param name="instrument">String</param>
        /// <param name="price">Double</param>
        /// <param name="size">Int32</param>
        /// <returns>Int32</returns>
        public Int32 Last(String instrument, Double price, Int32 size);
        /// <summary>
        /// LastPlayback method.
        /// </summary>
        /// <param name="instrument">String</param>
        /// <param name="price">Double</param>
        /// <param name="size">Int32</param>
        /// <param name="timestamp">String</param>
        /// <returns>Int32</returns>
        public Int32 LastPlayback(String instrument, Double price, Int32 size, String timestamp);
        /// <summary>
        /// MarketData method.
        /// </summary>
        /// <param name="instrument">String</param>
        /// <param name="type">Int32</param>
        /// <returns>Double</returns>
        public Double MarketData(String instrument, Int32 type);
        /// <summary>
        /// MarketPosition method.
        /// </summary>
        /// <param name="instrument">String</param>
        /// <param name="account">String</param>
        /// <returns>Int32</returns>
        public Int32 MarketPosition(String instrument, String account);
        /// <summary>
        /// NewOrderId method.
        /// </summary>
        /// <returns>String</returns>
        public String NewOrderId();
        /// <summary>
        /// Orders method.
        /// </summary>
        /// <param name="account">String</param>
        /// <returns>String</returns>
        public String Orders(String account);
        /// <summary>
        /// OrderStatus method.
        /// </summary>
        /// <param name="orderId">String</param>
        /// <returns>String</returns>
        public String OrderStatus(String orderId);
        /// <summary>
        /// QueryInstrument method.
        /// </summary>
        /// <returns>String</returns>
        public String QueryInstrument();
        /// <summary>
        /// RealizedPnL method.
        /// </summary>
        /// <param name="account">String</param>
        /// <returns>Double</returns>
        public Double RealizedPnL(String account);
        /// <summary>
        /// SetAllocReturnString method.
        /// </summary>
        /// <param name="value">Int32</param>
        /// <returns>Int32</returns>
        public Int32 SetAllocReturnString(Int32 value);
        /// <summary>
        /// SetMaxReturnStringLength method.
        /// </summary>
        /// <param name="value">Int32</param>
        /// <returns>Int32</returns>
        public Int32 SetMaxReturnStringLength(Int32 value);
        /// <summary>
        /// SetUp method.
        /// </summary>
        /// <param name="host">String</param>
        /// <param name="port">Int32</param>
        /// <returns>Int32</returns>
        public Int32 SetUp(String host, Int32 port);
        /// <summary>
        /// StopOrders method.
        /// </summary>
        /// <param name="strategyId">String</param>
        /// <returns>String</returns>
        public String StopOrders(String strategyId);
        /// <summary>
        /// Strategies method.
        /// </summary>
        /// <param name="account">String</param>
        /// <returns>String</returns>
        public String Strategies(String account);
        /// <summary>
        /// StrategyPosition method.
        /// </summary>
        /// <param name="strategyId">String</param>
        /// <returns>Int32</returns>
        public Int32 StrategyPosition(String strategyId);
        /// <summary>
        /// SubscribeMarketData method.
        /// </summary>
        /// <param name="instrument">String</param>
        /// <returns>Int32</returns>
        public Int32 SubscribeMarketData(String instrument);
        /// <summary>
        /// TargetOrders method.
        /// </summary>
        /// <param name="strategyId">String</param>
        /// <returns>String</returns>
        public String TargetOrders(String strategyId);
        /// <summary>
        /// TearDown method.
        /// </summary>
        /// <returns>Int32</returns>
        public Int32 TearDown();
        /// <summary>
        /// UnsubscribeMarketData method.
        /// </summary>
        /// <param name="instrument">String</param>
        /// <returns>Int32</returns>
        public Int32 UnsubscribeMarketData(String instrument);
        #endregion
    }
}
