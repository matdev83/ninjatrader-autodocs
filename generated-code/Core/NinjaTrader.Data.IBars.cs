namespace NinjaTrader.Data
{
    public partial interface IBars
    {
        #region Properties
        /// <summary>
        /// Gets or sets the BarsPeriod.
        /// </summary>
        [DataMember]
        public NinjaTrader.Data.BarsPeriod BarsPeriod { get; set; }
        /// <summary>
        /// Gets or sets the FromDate.
        /// </summary>
        [DataMember]
        public System.DateTime FromDate { get; set; }
        /// <summary>
        /// Gets or sets the Instrument.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Instrument Instrument { get; set; }
        /// <summary>
        /// Gets or sets the ToDate.
        /// </summary>
        [DataMember]
        public System.DateTime ToDate { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Add method.
        /// </summary>
        /// <param name="open">double</param>
        /// <param name="high">double</param>
        /// <param name="low">double</param>
        /// <param name="close">double</param>
        /// <param name="time">System.DateTime</param>
        /// <param name="volume">long</param>
        /// <param name="bid">double</param>
        /// <param name="ask">double</param>
        public void Add(double open, double high, double low, double close, System.DateTime time, long volume, double bid, double ask);
        #endregion
    }
}
