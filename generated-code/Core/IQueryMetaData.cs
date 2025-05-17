namespace NinjaTrader.Adapter
{
    public partial interface IQueryMetaData
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// QueryAllMasterInstrumentsAsync method.
        /// </summary>
        /// <param name="progress">IProgress</param>
        /// <returns>Task`1</returns>
        public Task<MasterInstrument[]> QueryAllMasterInstrumentsAsync(IProgress progress);
        /// <summary>
        /// QueryFuturesExpiriesAsync method.
        /// </summary>
        /// <param name="rolloverInstruments">MetaDataRolloverInstrument[]</param>
        /// <param name="progress">IProgress</param>
        /// <returns>Task</returns>
        public Task QueryFuturesExpiriesAsync(MetaDataRolloverInstrument[] rolloverInstruments, IProgress progress);
        /// <summary>
        /// QueryTradingHoursHolidaysAsync method.
        /// </summary>
        /// <param name="tradingHours">TradingHours[]</param>
        /// <param name="progress">IProgress</param>
        /// <returns>Task</returns>
        public Task QueryTradingHoursHolidaysAsync(TradingHours[] tradingHours, IProgress progress);
        #endregion
    }
}
