[Serializable]
[DataContract]
    public partial class FundamentalDataUnsubscribe : IInstrumentProvider
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Instrument.
        /// </summary>
        [DataMember]
        public Instrument Instrument { get; set; }
        /// <summary>
        /// Gets or sets the NT.
        /// </summary>
        [DataMember]
        public NinjaTraderProxy NT { get; set; }
        #endregion
        #region Methods
        #endregion
    }
