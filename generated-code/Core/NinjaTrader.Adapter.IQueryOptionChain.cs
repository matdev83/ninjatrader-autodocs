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
        /// <param name="underlying">NinjaTrader.Cbi.Instrument</param>
        /// <returns>System.Threading.Tasks.Task<NinjaTrader.Adapter.InstrumentInfo[]></returns>
        public System.Threading.Tasks.Task<NinjaTrader.Adapter.InstrumentInfo[]> QueryOptionChainAsync(NinjaTrader.Cbi.Instrument underlying);
        #endregion
    }
}
