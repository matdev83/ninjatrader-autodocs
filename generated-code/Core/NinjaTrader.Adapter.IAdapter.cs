namespace NinjaTrader.Adapter
{
    public partial interface IAdapter
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// Connect method.
        /// </summary>
        /// <param name="connection">NinjaTrader.Cbi.IConnection</param>
        public void Connect(NinjaTrader.Cbi.IConnection connection);
        /// <summary>
        /// Disconnect method.
        /// </summary>
        public void Disconnect();
        /// <summary>
        /// SubscribeFundamentalData method.
        /// </summary>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        /// <param name="callback">System.Action<FundamentalDataType, object></param>
        public void SubscribeFundamentalData(NinjaTrader.Cbi.Instrument instrument, System.Action<FundamentalDataType, object> callback);
        /// <summary>
        /// UnsubscribeFundamentalData method.
        /// </summary>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        public void UnsubscribeFundamentalData(NinjaTrader.Cbi.Instrument instrument);
        /// <summary>
        /// SubscribeMarketData method.
        /// </summary>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        /// <param name="callback">System.Action<MarketDataType, double, long, System.DateTime, long></param>
        public void SubscribeMarketData(NinjaTrader.Cbi.Instrument instrument, System.Action<MarketDataType, double, long, System.DateTime, long> callback);
        /// <summary>
        /// UnsubscribeMarketData method.
        /// </summary>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        public void UnsubscribeMarketData(NinjaTrader.Cbi.Instrument instrument);
        /// <summary>
        /// SubscribeMarketDepth method.
        /// </summary>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        /// <param name="callback">System.Action<int, string, Operation, MarketDataType, double, long, System.DateTime></param>
        public void SubscribeMarketDepth(NinjaTrader.Cbi.Instrument instrument, System.Action<int, string, Operation, MarketDataType, double, long, System.DateTime> callback);
        /// <summary>
        /// UnsubscribeMarketDepth method.
        /// </summary>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        public void UnsubscribeMarketDepth(NinjaTrader.Cbi.Instrument instrument);
        /// <summary>
        /// Cancel method.
        /// </summary>
        /// <param name="orders">NinjaTrader.Cbi.Order[]</param>
        public void Cancel(NinjaTrader.Cbi.Order[] orders);
        /// <summary>
        /// Change method.
        /// </summary>
        /// <param name="orders">NinjaTrader.Cbi.Order[]</param>
        public void Change(NinjaTrader.Cbi.Order[] orders);
        /// <summary>
        /// Submit method.
        /// </summary>
        /// <param name="orders">NinjaTrader.Cbi.Order[]</param>
        public void Submit(NinjaTrader.Cbi.Order[] orders);
        /// <summary>
        /// ResolveInstrument method.
        /// </summary>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        /// <param name="callback">System.Action<NinjaTrader.Cbi.Instrument, ErrorCode, string></param>
        public void ResolveInstrument(NinjaTrader.Cbi.Instrument instrument, System.Action<NinjaTrader.Cbi.Instrument, ErrorCode, string> callback);
        /// <summary>
        /// SubscribeAccount method.
        /// </summary>
        /// <param name="account">NinjaTrader.Cbi.Account</param>
        public void SubscribeAccount(NinjaTrader.Cbi.Account account);
        /// <summary>
        /// UnsubscribeAccount method.
        /// </summary>
        /// <param name="account">NinjaTrader.Cbi.Account</param>
        public void UnsubscribeAccount(NinjaTrader.Cbi.Account account);
        /// <summary>
        /// RequestBars method.
        /// </summary>
        /// <param name="bars">NinjaTrader.Data.IBars</param>
        /// <param name="callback">System.Action<NinjaTrader.Data.IBars, ErrorCode, string></param>
        /// <param name="progress">NinjaTrader.Core.IProgress</param>
        public void RequestBars(NinjaTrader.Data.IBars bars, System.Action<NinjaTrader.Data.IBars, ErrorCode, string> callback, NinjaTrader.Core.IProgress progress);
        /// <summary>
        /// RequestHotlistNames method.
        /// </summary>
        /// <param name="callback">System.Action<System.String[], ErrorCode, string></param>
        public void RequestHotlistNames(System.Action<System.String[], ErrorCode, string> callback);
        /// <summary>
        /// SubscribeHotlist method.
        /// </summary>
        /// <param name="hotlist">NinjaTrader.Data.Hotlist</param>
        /// <param name="callback">System.Action</param>
        public void SubscribeHotlist(NinjaTrader.Data.Hotlist hotlist, System.Action callback);
        /// <summary>
        /// UnsubscribeHotlist method.
        /// </summary>
        /// <param name="hotlist">NinjaTrader.Data.Hotlist</param>
        public void UnsubscribeHotlist(NinjaTrader.Data.Hotlist hotlist);
        /// <summary>
        /// SubscribeNews method.
        /// </summary>
        public void SubscribeNews();
        /// <summary>
        /// UnsubscribeNews method.
        /// </summary>
        public void UnsubscribeNews();
        #endregion
    }
}
