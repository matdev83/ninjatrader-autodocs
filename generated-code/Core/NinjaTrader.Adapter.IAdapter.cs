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
        /// <param name="connection">IConnection</param>
        public Void Connect(IConnection connection);
        /// <summary>
        /// Disconnect method.
        /// </summary>
        public Void Disconnect();
        /// <summary>
        /// SubscribeFundamentalData method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        /// <param name="callback">Action`2</param>
        public Void SubscribeFundamentalData(Instrument instrument, Action<FundamentalDataType, Object> callback);
        /// <summary>
        /// UnsubscribeFundamentalData method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        public Void UnsubscribeFundamentalData(Instrument instrument);
        /// <summary>
        /// SubscribeMarketData method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        /// <param name="callback">Action`5</param>
        public Void SubscribeMarketData(Instrument instrument, Action<MarketDataType, Double, Int64, DateTime, Int64> callback);
        /// <summary>
        /// UnsubscribeMarketData method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        public Void UnsubscribeMarketData(Instrument instrument);
        /// <summary>
        /// SubscribeMarketDepth method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        /// <param name="callback">Action`7</param>
        public Void SubscribeMarketDepth(Instrument instrument, Action<Int32, String, Operation, MarketDataType, Double, Int64, DateTime> callback);
        /// <summary>
        /// UnsubscribeMarketDepth method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        public Void UnsubscribeMarketDepth(Instrument instrument);
        /// <summary>
        /// Cancel method.
        /// </summary>
        /// <param name="orders">Order[]</param>
        public Void Cancel(Order[] orders);
        /// <summary>
        /// Change method.
        /// </summary>
        /// <param name="orders">Order[]</param>
        public Void Change(Order[] orders);
        /// <summary>
        /// Submit method.
        /// </summary>
        /// <param name="orders">Order[]</param>
        public Void Submit(Order[] orders);
        /// <summary>
        /// ResolveInstrument method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        /// <param name="callback">Action`3</param>
        public Void ResolveInstrument(Instrument instrument, Action<Instrument, ErrorCode, String> callback);
        /// <summary>
        /// SubscribeAccount method.
        /// </summary>
        /// <param name="account">Account</param>
        public Void SubscribeAccount(Account account);
        /// <summary>
        /// UnsubscribeAccount method.
        /// </summary>
        /// <param name="account">Account</param>
        public Void UnsubscribeAccount(Account account);
        /// <summary>
        /// RequestBars method.
        /// </summary>
        /// <param name="bars">IBars</param>
        /// <param name="callback">Action`3</param>
        /// <param name="progress">IProgress</param>
        public Void RequestBars(IBars bars, Action<IBars, ErrorCode, String> callback, IProgress progress);
        /// <summary>
        /// RequestHotlistNames method.
        /// </summary>
        /// <param name="callback">Action`3</param>
        public Void RequestHotlistNames(Action<String[], ErrorCode, String> callback);
        /// <summary>
        /// SubscribeHotlist method.
        /// </summary>
        /// <param name="hotlist">Hotlist</param>
        /// <param name="callback">Action</param>
        public Void SubscribeHotlist(Hotlist hotlist, Action callback);
        /// <summary>
        /// UnsubscribeHotlist method.
        /// </summary>
        /// <param name="hotlist">Hotlist</param>
        public Void UnsubscribeHotlist(Hotlist hotlist);
        /// <summary>
        /// SubscribeNews method.
        /// </summary>
        public Void SubscribeNews();
        /// <summary>
        /// UnsubscribeNews method.
        /// </summary>
        public Void UnsubscribeNews();
        #endregion
    }
}
