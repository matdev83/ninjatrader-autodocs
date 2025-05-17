namespace NinjaTrader.Adapter
{
    public partial interface IQueryOptionChain
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// QueryOptionChainAsync method.
        /// </summary>
        /// <param name="underlying">Instrument</param>
        /// <returns>Task`1</returns>
        public Task<InstrumentInfo[]> QueryOptionChainAsync(Instrument underlying);
        #endregion
    }
}
