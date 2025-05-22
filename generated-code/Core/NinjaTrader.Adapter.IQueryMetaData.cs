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
        /// <param name="progress">NinjaTrader.Core.IProgress</param>
        /// <returns>System.Threading.Tasks.Task<NinjaTrader.Cbi.MasterInstrument[]></returns>
        public System.Threading.Tasks.Task<NinjaTrader.Cbi.MasterInstrument[]> QueryAllMasterInstrumentsAsync(NinjaTrader.Core.IProgress progress);
        /// <summary>
        /// QueryFuturesExpiriesAsync method.
        /// </summary>
        /// <param name="rolloverInstruments">NinjaTrader.Cbi.MetaDataRolloverInstrument[]</param>
        /// <param name="progress">NinjaTrader.Core.IProgress</param>
        /// <returns>System.Threading.Tasks.Task</returns>
        public System.Threading.Tasks.Task QueryFuturesExpiriesAsync(NinjaTrader.Cbi.MetaDataRolloverInstrument[] rolloverInstruments, NinjaTrader.Core.IProgress progress);
        /// <summary>
        /// QueryTradingHoursHolidaysAsync method.
        /// </summary>
        /// <param name="tradingHours">NinjaTrader.Data.TradingHours[]</param>
        /// <param name="progress">NinjaTrader.Core.IProgress</param>
        /// <returns>System.Threading.Tasks.Task</returns>
        public System.Threading.Tasks.Task QueryTradingHoursHolidaysAsync(NinjaTrader.Data.TradingHours[] tradingHours, NinjaTrader.Core.IProgress progress);
        #endregion
    }
}
