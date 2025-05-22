namespace NinjaTrader.Data
{
    public partial interface IBarsPeriodProvider
    {
        #region Properties
        /// <summary>
        /// Gets or sets the BarsPeriod.
        /// </summary>
        [DataMember]
        public NinjaTrader.Data.BarsPeriod BarsPeriod { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
