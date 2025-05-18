[Serializable]
[DataContract]
    public partial class MarketDepthSubscription
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Callbacks.
        /// </summary>
        [DataMember]
        public List<Action<Int32, String, Operation, MarketDataType, Double, Int64, DateTime>> Callbacks { get; set; }
        /// <summary>
        /// Gets or sets the Instrument2Callback.
        /// </summary>
        [DataMember]
        public Dictionary<Instrument, Action<Int32, String, Operation, MarketDataType, Double, Int64, DateTime>> Instrument2Callback { get; set; }
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
