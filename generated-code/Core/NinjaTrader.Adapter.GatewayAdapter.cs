[Serializable]
[DataContract]
namespace NinjaTrader.Adapter
{
    public partial class GatewayAdapter : NinjaTrader.Adapter.IAdapter
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Adapters.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.List<NinjaTrader.Adapter.GatewayAdapter> Adapters { get; set; }
        /// <summary>
        /// Gets or sets the Connection.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.IConnection Connection { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Cancel method.
        /// </summary>
        /// <param name="orders">NinjaTrader.Cbi.Order[]</param>
        public void Cancel(NinjaTrader.Cbi.Order[] orders)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Change method.
        /// </summary>
        /// <param name="orders">NinjaTrader.Cbi.Order[]</param>
        public void Change(NinjaTrader.Cbi.Order[] orders)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Connect method.
        /// </summary>
        /// <param name="connection">NinjaTrader.Cbi.IConnection</param>
        public void Connect(NinjaTrader.Cbi.IConnection connection)
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
        /// OnAccountItemUpdate method.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">NinjaTrader.Cbi.AccountItemEventArgs</param>
        public void OnAccountItemUpdate(object sender, NinjaTrader.Cbi.AccountItemEventArgs e)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// OnAccountRoll method.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">NinjaTrader.Cbi.AccountRollEventArgs</param>
        public void OnAccountRoll(object sender, NinjaTrader.Cbi.AccountRollEventArgs e)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// OnExecutionUpdate method.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">NinjaTrader.Cbi.ExecutionEventArgs</param>
        public void OnExecutionUpdate(object sender, NinjaTrader.Cbi.ExecutionEventArgs e)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// OnOrderUpdate method.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">NinjaTrader.Cbi.OrderEventArgs</param>
        public void OnOrderUpdate(object sender, NinjaTrader.Cbi.OrderEventArgs e)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Submit method.
        /// </summary>
        /// <param name="orders">NinjaTrader.Cbi.Order[]</param>
        public void Submit(NinjaTrader.Cbi.Order[] orders)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SubscribeAccount method.
        /// </summary>
        /// <param name="account">NinjaTrader.Cbi.Account</param>
        public void SubscribeAccount(NinjaTrader.Cbi.Account account)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SubscribeFundamentalData method.
        /// </summary>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        /// <param name="callback">System.Action<FundamentalDataType, object></param>
        public void SubscribeFundamentalData(NinjaTrader.Cbi.Instrument instrument, System.Action<FundamentalDataType, object> callback)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SubscribeMarketData method.
        /// </summary>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        /// <param name="callback">System.Action<MarketDataType, double, long, System.DateTime, long></param>
        public void SubscribeMarketData(NinjaTrader.Cbi.Instrument instrument, System.Action<MarketDataType, double, long, System.DateTime, long> callback)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SubscribeMarketDepth method.
        /// </summary>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        /// <param name="callback">System.Action<int, string, Operation, MarketDataType, double, long, System.DateTime></param>
        public void SubscribeMarketDepth(NinjaTrader.Cbi.Instrument instrument, System.Action<int, string, Operation, MarketDataType, double, long, System.DateTime> callback)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SubscribeNews method.
        /// </summary>
        public void SubscribeNews()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// UnsubscribeAccount method.
        /// </summary>
        /// <param name="account">NinjaTrader.Cbi.Account</param>
        public void UnsubscribeAccount(NinjaTrader.Cbi.Account account)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// UnsubscribeFundamentalData method.
        /// </summary>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        public void UnsubscribeFundamentalData(NinjaTrader.Cbi.Instrument instrument)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// UnsubscribeMarketData method.
        /// </summary>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        public void UnsubscribeMarketData(NinjaTrader.Cbi.Instrument instrument)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// UnsubscribeMarketDepth method.
        /// </summary>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        public void UnsubscribeMarketDepth(NinjaTrader.Cbi.Instrument instrument)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// UnsubscribeNews method.
        /// </summary>
        public void UnsubscribeNews()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// RequestBars method.
        /// </summary>
        /// <param name="bars">NinjaTrader.Data.IBars</param>
        /// <param name="callback">System.Action<NinjaTrader.Data.IBars, ErrorCode, string></param>
        /// <param name="progress">NinjaTrader.Core.IProgress</param>
        public void RequestBars(NinjaTrader.Data.IBars bars, System.Action<NinjaTrader.Data.IBars, ErrorCode, string> callback, NinjaTrader.Core.IProgress progress)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// RequestHotlistNames method.
        /// </summary>
        /// <param name="callback">System.Action<System.String[], ErrorCode, string></param>
        public void RequestHotlistNames(System.Action<System.String[], ErrorCode, string> callback)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ResolveInstrument method.
        /// </summary>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        /// <param name="callback">System.Action<NinjaTrader.Cbi.Instrument, ErrorCode, string></param>
        public void ResolveInstrument(NinjaTrader.Cbi.Instrument instrument, System.Action<NinjaTrader.Cbi.Instrument, ErrorCode, string> callback)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SubscribeHotlist method.
        /// </summary>
        /// <param name="hotlist">NinjaTrader.Data.Hotlist</param>
        /// <param name="callback">System.Action</param>
        public void SubscribeHotlist(NinjaTrader.Data.Hotlist hotlist, System.Action callback)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// UnsubscribeHotlist method.
        /// </summary>
        /// <param name="hotlist">NinjaTrader.Data.Hotlist</param>
        public void UnsubscribeHotlist(NinjaTrader.Data.Hotlist hotlist)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
