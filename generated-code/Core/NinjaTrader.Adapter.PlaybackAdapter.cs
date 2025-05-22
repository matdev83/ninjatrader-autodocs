[Serializable]
[DataContract]
namespace NinjaTrader.Adapter
{
    public partial class PlaybackAdapter : NinjaTrader.Adapter.IAdapter
    {
        #region Properties
        /// <summary>
        /// Gets or sets the FromAvailableDataEst.
        /// </summary>
        [DataMember]
        public System.DateTime FromAvailableDataEst { get; set; }
        /// <summary>
        /// Gets or sets the FromLocal.
        /// </summary>
        [DataMember]
        public System.DateTime FromLocal { get; set; }
        /// <summary>
        /// Gets or sets the InstrumentNameToPlaybackFiles.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.SortedList<System.DateTime, NinjaTrader.Adapter.PlaybackFile>> InstrumentNameToPlaybackFiles { get; set; }
        /// <summary>
        /// Gets or sets the IsSourceHistoricalData.
        /// </summary>
        [DataMember]
        public bool IsSourceHistoricalData { get; set; }
        /// <summary>
        /// Gets or sets the NowEst.
        /// </summary>
        [DataMember]
        public System.DateTime NowEst { get; set; }
        /// <summary>
        /// Gets or sets the NowLocal.
        /// </summary>
        [DataMember]
        public System.DateTime NowLocal { get; set; }
        /// <summary>
        /// Gets or sets the PlaybackFromMode.
        /// </summary>
        [DataMember]
        public PlaybackFromMode PlaybackFromMode { get; set; }
        /// <summary>
        /// Gets or sets the SaveFromEstHistorical.
        /// </summary>
        [DataMember]
        public System.DateTime SaveFromEstHistorical { get; set; }
        /// <summary>
        /// Gets or sets the SaveFromEstMarketReplay.
        /// </summary>
        [DataMember]
        public System.DateTime SaveFromEstMarketReplay { get; set; }
        /// <summary>
        /// Gets or sets the SaveToEstHistorical.
        /// </summary>
        [DataMember]
        public System.DateTime SaveToEstHistorical { get; set; }
        /// <summary>
        /// Gets or sets the SaveToEstMarketReplay.
        /// </summary>
        [DataMember]
        public System.DateTime SaveToEstMarketReplay { get; set; }
        /// <summary>
        /// Gets or sets the ToAvailableDataEst.
        /// </summary>
        [DataMember]
        public System.DateTime ToAvailableDataEst { get; set; }
        /// <summary>
        /// Gets or sets the FromEst.
        /// </summary>
        [DataMember]
        public System.DateTime FromEst { get; set; }
        /// <summary>
        /// Gets or sets the IsAvailable.
        /// </summary>
        [DataMember]
        public bool IsAvailable { get; set; }
        /// <summary>
        /// Gets or sets the PlaybackSpeed.
        /// </summary>
        [DataMember]
        public int PlaybackSpeed { get; set; }
        /// <summary>
        /// Gets or sets the ToEst.
        /// </summary>
        [DataMember]
        public System.DateTime ToEst { get; set; }
        #endregion
        #region Methods
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
        /// GetReplayMinMaxDates method.
        /// </summary>
        /// <param name="replayFile">string</param>
        /// <param name="minDate">System.DateTime&</param>
        /// <param name="maxDate">System.DateTime&</param>
        public void GetReplayMinMaxDates(string replayFile, System.DateTime& minDate, System.DateTime& maxDate)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// RecalculateDaylightSavings method.
        /// </summary>
        public void RecalculateDaylightSavings()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ReloadAvailableData method.
        /// </summary>
        /// <param name="isConnecting">bool</param>
        public void ReloadAvailableData(bool isConnecting)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Reset method.
        /// </summary>
        /// <param name="targetTimeEst">System.DateTime</param>
        /// <param name="callback">System.Action<bool></param>
        public void Reset(System.DateTime targetTimeEst, System.Action<bool> callback)
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
        /// SyncBars method.
        /// </summary>
        /// <param name="bars">NinjaTrader.Data.Bars</param>
        /// <param name="state">object</param>
        public void SyncBars(NinjaTrader.Data.Bars bars, object state)
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
        /// SubscribeAccount method.
        /// </summary>
        /// <param name="account">NinjaTrader.Cbi.Account</param>
        public void SubscribeAccount(NinjaTrader.Cbi.Account account)
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
        /// UnsubscribeFundamentalData method.
        /// </summary>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        public void UnsubscribeFundamentalData(NinjaTrader.Cbi.Instrument instrument)
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
        /// UnsubscribeNews method.
        /// </summary>
        public void UnsubscribeNews()
        {
            // Method implementation goes here
        }
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
        /// Submit method.
        /// </summary>
        /// <param name="orders">NinjaTrader.Cbi.Order[]</param>
        public void Submit(NinjaTrader.Cbi.Order[] orders)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
