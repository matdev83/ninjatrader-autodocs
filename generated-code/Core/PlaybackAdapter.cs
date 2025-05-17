[Serializable]
[DataContract]
namespace NinjaTrader.Adapter
{
    public partial class PlaybackAdapter : IAdapter
    {
        #region Properties
        /// <summary>
        /// Gets or sets the FromAvailableDataEst.
        /// </summary>
        [DataMember]
        public DateTime FromAvailableDataEst { get; set; }
        /// <summary>
        /// Gets or sets the FromLocal.
        /// </summary>
        [DataMember]
        public DateTime FromLocal { get; set; }
        /// <summary>
        /// Gets or sets the InstrumentNameToPlaybackFiles.
        /// </summary>
        [DataMember]
        public Dictionary<String, SortedList<DateTime, PlaybackFile>> InstrumentNameToPlaybackFiles { get; set; }
        /// <summary>
        /// Gets or sets the IsSourceHistoricalData.
        /// </summary>
        [DataMember]
        public Boolean IsSourceHistoricalData { get; set; }
        /// <summary>
        /// Gets or sets the NowEst.
        /// </summary>
        [DataMember]
        public DateTime NowEst { get; set; }
        /// <summary>
        /// Gets or sets the NowLocal.
        /// </summary>
        [DataMember]
        public DateTime NowLocal { get; set; }
        /// <summary>
        /// Gets or sets the PlaybackFromMode.
        /// </summary>
        [DataMember]
        public PlaybackFromMode PlaybackFromMode { get; set; }
        /// <summary>
        /// Gets or sets the SaveFromEstHistorical.
        /// </summary>
        [DataMember]
        public DateTime SaveFromEstHistorical { get; set; }
        /// <summary>
        /// Gets or sets the SaveFromEstMarketReplay.
        /// </summary>
        [DataMember]
        public DateTime SaveFromEstMarketReplay { get; set; }
        /// <summary>
        /// Gets or sets the SaveToEstHistorical.
        /// </summary>
        [DataMember]
        public DateTime SaveToEstHistorical { get; set; }
        /// <summary>
        /// Gets or sets the SaveToEstMarketReplay.
        /// </summary>
        [DataMember]
        public DateTime SaveToEstMarketReplay { get; set; }
        /// <summary>
        /// Gets or sets the ToAvailableDataEst.
        /// </summary>
        [DataMember]
        public DateTime ToAvailableDataEst { get; set; }
        /// <summary>
        /// Gets or sets the FromEst.
        /// </summary>
        [DataMember]
        public DateTime FromEst { get; set; }
        /// <summary>
        /// Gets or sets the IsAvailable.
        /// </summary>
        [DataMember]
        public Boolean IsAvailable { get; set; }
        /// <summary>
        /// Gets or sets the PlaybackSpeed.
        /// </summary>
        [DataMember]
        public Int32 PlaybackSpeed { get; set; }
        /// <summary>
        /// Gets or sets the ToEst.
        /// </summary>
        [DataMember]
        public DateTime ToEst { get; set; }
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
        /// GetReplayMinMaxDates method.
        /// </summary>
        /// <param name="replayFile">String</param>
        /// <param name="minDate">DateTime&</param>
        /// <param name="maxDate">DateTime&</param>
        public Void GetReplayMinMaxDates(String replayFile, DateTime& minDate, DateTime& maxDate);
        /// <summary>
        /// RecalculateDaylightSavings method.
        /// </summary>
        public Void RecalculateDaylightSavings();
        /// <summary>
        /// ReloadAvailableData method.
        /// </summary>
        /// <param name="isConnecting">Boolean</param>
        public Void ReloadAvailableData(Boolean isConnecting);
        /// <summary>
        /// Reset method.
        /// </summary>
        /// <param name="targetTimeEst">DateTime</param>
        /// <param name="callback">Action`1</param>
        public Void Reset(DateTime targetTimeEst, Action<Boolean> callback);
        /// <summary>
        /// ResolveInstrument method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        /// <param name="callback">Action`3</param>
        public Void ResolveInstrument(Instrument instrument, Action<Instrument, ErrorCode, String> callback);
        /// <summary>
        /// SubscribeMarketData method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        /// <param name="callback">Action`5</param>
        public Void SubscribeMarketData(Instrument instrument, Action<MarketDataType, Double, Int64, DateTime, Int64> callback);
        /// <summary>
        /// SubscribeMarketDepth method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        /// <param name="callback">Action`7</param>
        public Void SubscribeMarketDepth(Instrument instrument, Action<Int32, String, Operation, MarketDataType, Double, Int64, DateTime> callback);
        /// <summary>
        /// SyncBars method.
        /// </summary>
        /// <param name="bars">Bars</param>
        /// <param name="state">Object</param>
        public Void SyncBars(Bars bars, Object state);
        /// <summary>
        /// UnsubscribeMarketData method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        public Void UnsubscribeMarketData(Instrument instrument);
        /// <summary>
        /// UnsubscribeMarketDepth method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        public Void UnsubscribeMarketDepth(Instrument instrument);
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
        /// SubscribeNews method.
        /// </summary>
        public Void SubscribeNews();
        /// <summary>
        /// UnsubscribeNews method.
        /// </summary>
        public Void UnsubscribeNews();
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
        #endregion
    }
}
