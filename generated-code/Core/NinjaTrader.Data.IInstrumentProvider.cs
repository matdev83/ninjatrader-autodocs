namespace NinjaTrader.Data
{
    public partial interface IInstrumentProvider
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Instrument.
        /// </summary>
        [DataMember]
        public Instrument Instrument { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
