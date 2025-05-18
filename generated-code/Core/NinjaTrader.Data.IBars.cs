namespace NinjaTrader.Data
{
    public partial interface IBars
    {
        #region Properties
        /// <summary>
        /// Gets or sets the BarsPeriod.
        /// </summary>
        [DataMember]
        public BarsPeriod BarsPeriod { get; set; }
        /// <summary>
        /// Gets or sets the FromDate.
        /// </summary>
        [DataMember]
        public DateTime FromDate { get; set; }
        /// <summary>
        /// Gets or sets the Instrument.
        /// </summary>
        [DataMember]
        public Instrument Instrument { get; set; }
        /// <summary>
        /// Gets or sets the ToDate.
        /// </summary>
        [DataMember]
        public DateTime ToDate { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Add method.
        /// </summary>
        /// <param name="open">Double</param>
        /// <param name="high">Double</param>
        /// <param name="low">Double</param>
        /// <param name="close">Double</param>
        /// <param name="time">DateTime</param>
        /// <param name="volume">Int64</param>
        /// <param name="bid">Double</param>
        /// <param name="ask">Double</param>
        public Void Add(Double open, Double high, Double low, Double close, DateTime time, Int64 volume, Double bid, Double ask);
        #endregion
    }
}
