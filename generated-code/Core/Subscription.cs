[Serializable]
[DataContract]
    public partial class Subscription : IDisposable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the DoMoveNext.
        /// </summary>
        [DataMember]
        public Boolean DoMoveNext { get; set; }
        /// <summary>
        /// Gets or sets the Event.
        /// </summary>
        [DataMember]
        public EventArgs Event { get; set; }
        /// <summary>
        /// Gets or sets the HistoricalData.
        /// </summary>
        [DataMember]
        public PlaybackIterator HistoricalData { get; set; }
        /// <summary>
        /// Gets or sets the Instrument.
        /// </summary>
        [DataMember]
        public Instrument Instrument { get; set; }
        /// <summary>
        /// Gets or sets the L1Callbacks.
        /// </summary>
        [DataMember]
        public Dictionary<Instrument, Action<MarketDataType, Double, Int64, DateTime, Int64>> L1Callbacks { get; set; }
        /// <summary>
        /// Gets or sets the L2Callbacks.
        /// </summary>
        [DataMember]
        public Dictionary<Instrument, Action<Int32, String, Operation, MarketDataType, Double, Int64, DateTime>> L2Callbacks { get; set; }
        /// <summary>
        /// Gets or sets the MarketReplayData.
        /// </summary>
        [DataMember]
        public MarketReplay MarketReplayData { get; set; }
        /// <summary>
        /// Gets or sets the MaxLocalTimeOfDataFile.
        /// </summary>
        [DataMember]
        public DateTime MaxLocalTimeOfDataFile { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Dispose method.
        /// </summary>
        public Void Dispose();
        #endregion
    }
