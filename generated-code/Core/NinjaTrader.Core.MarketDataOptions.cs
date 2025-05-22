[Serializable]
[DataContract]
namespace NinjaTrader.Core
{
    public partial class MarketDataOptions : System.ICloneable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AdjustForSplitsOnDaily.
        /// </summary>
        [DataMember]
        public bool AdjustForSplitsOnDaily { get; set; }
        /// <summary>
        /// Gets or sets the AdjustForSplitsOnIntraday.
        /// </summary>
        [DataMember]
        public bool AdjustForSplitsOnIntraday { get; set; }
        /// <summary>
        /// Gets or sets the AdjustForDividends.
        /// </summary>
        [DataMember]
        public bool AdjustForDividends { get; set; }
        /// <summary>
        /// Gets or sets the AutoSubscribe.
        /// </summary>
        [DataMember]
        public bool AutoSubscribe { get; set; }
        /// <summary>
        /// Gets or sets the DownloadCotData.
        /// </summary>
        [DataMember]
        public bool DownloadCotData { get; set; }
        /// <summary>
        /// Gets or sets the FilterBadTicks.
        /// </summary>
        [DataMember]
        public bool FilterBadTicks { get; set; }
        /// <summary>
        /// Gets or sets the FilterBadTicksPercent.
        /// </summary>
        [DataMember]
        public double FilterBadTicksPercent { get; set; }
        /// <summary>
        /// Gets or sets the GetDataFromServer.
        /// </summary>
        [DataMember]
        public bool GetDataFromServer { get; set; }
        /// <summary>
        /// Gets or sets the GlobalMergePolicy.
        /// </summary>
        [DataMember]
        public MergePolicy GlobalMergePolicy { get; set; }
        /// <summary>
        /// Gets or sets the IsTickReplayEnabled.
        /// </summary>
        [DataMember]
        public bool IsTickReplayEnabled { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the PreferredCfdConnection.
        /// </summary>
        [DataMember]
        public Provider PreferredCfdConnection { get; set; }
        /// <summary>
        /// Gets or sets the PreferredCryptocurrencyConnection.
        /// </summary>
        [DataMember]
        public Provider PreferredCryptocurrencyConnection { get; set; }
        /// <summary>
        /// Gets or sets the PreferredForexConnection.
        /// </summary>
        [DataMember]
        public Provider PreferredForexConnection { get; set; }
        /// <summary>
        /// Gets or sets the PreferredFutureConnection.
        /// </summary>
        [DataMember]
        public Provider PreferredFutureConnection { get; set; }
        /// <summary>
        /// Gets or sets the PreferredIndexConnection.
        /// </summary>
        [DataMember]
        public Provider PreferredIndexConnection { get; set; }
        /// <summary>
        /// Gets or sets the PreferredOptionConnection.
        /// </summary>
        [DataMember]
        public Provider PreferredOptionConnection { get; set; }
        /// <summary>
        /// Gets or sets the PreferredStockConnection.
        /// </summary>
        [DataMember]
        public Provider PreferredStockConnection { get; set; }
        /// <summary>
        /// Gets or sets the PreferredRealtimeCfdConnection.
        /// </summary>
        [DataMember]
        public Provider PreferredRealtimeCfdConnection { get; set; }
        /// <summary>
        /// Gets or sets the PreferredRealtimeCryptocurrencyConnection.
        /// </summary>
        [DataMember]
        public Provider PreferredRealtimeCryptocurrencyConnection { get; set; }
        /// <summary>
        /// Gets or sets the PreferredRealtimeForexConnection.
        /// </summary>
        [DataMember]
        public Provider PreferredRealtimeForexConnection { get; set; }
        /// <summary>
        /// Gets or sets the PreferredRealtimeFutureConnection.
        /// </summary>
        [DataMember]
        public Provider PreferredRealtimeFutureConnection { get; set; }
        /// <summary>
        /// Gets or sets the PreferredRealtimeIndexConnection.
        /// </summary>
        [DataMember]
        public Provider PreferredRealtimeIndexConnection { get; set; }
        /// <summary>
        /// Gets or sets the PreferredRealtimeOptionConnection.
        /// </summary>
        [DataMember]
        public Provider PreferredRealtimeOptionConnection { get; set; }
        /// <summary>
        /// Gets or sets the PreferredRealtimeStockConnection.
        /// </summary>
        [DataMember]
        public Provider PreferredRealtimeStockConnection { get; set; }
        /// <summary>
        /// Gets or sets the RecordForPlayback.
        /// </summary>
        [DataMember]
        public bool RecordForPlayback { get; set; }
        /// <summary>
        /// Gets or sets the SaveDataAsHistorical.
        /// </summary>
        [DataMember]
        public bool SaveDataAsHistorical { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>object</returns>
        public object Clone()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="options">NinjaTrader.Core.MarketDataOptions</param>
        public void CopyTo(NinjaTrader.Core.MarketDataOptions options)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
