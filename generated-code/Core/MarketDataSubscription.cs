[Serializable]
[DataContract]
    public partial class MarketDataSubscription
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Callbacks.
        /// </summary>
        [DataMember]
        public List<Action<MarketDataType, Double, Int64, DateTime, Int64>> Callbacks { get; set; }
        /// <summary>
        /// Gets or sets the Instrument2Callback.
        /// </summary>
        [DataMember]
        public Dictionary<Instrument, Action<MarketDataType, Double, Int64, DateTime, Int64>> Instrument2Callback { get; set; }
        /// <summary>
        /// Gets or sets the Instrument.
        /// </summary>
        [DataMember]
        public Instrument Instrument { get; set; }
        /// <summary>
        /// Gets or sets the InstrumentId.
        /// </summary>
        [DataMember]
        public Int64 InstrumentId { get; set; }
        #endregion
        #region Methods
        #endregion
    }
