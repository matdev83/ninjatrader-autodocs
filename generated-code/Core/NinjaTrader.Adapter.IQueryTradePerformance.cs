namespace NinjaTrader.Adapter
{
    public partial interface IQueryTradePerformance
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// QueryPastExecutionsAsync method.
        /// </summary>
        /// <param name="startDate">System.DateTime</param>
        /// <param name="endDate">System.DateTime</param>
        /// <param name="penalty">NinjaTrader.Cbi.TimePenalty</param>
        /// <returns>System.Threading.Tasks.Task<System.Collections.Generic.List<NinjaTrader.Cbi.Execution>></returns>
        public System.Threading.Tasks.Task<System.Collections.Generic.List<NinjaTrader.Cbi.Execution>> QueryPastExecutionsAsync(System.DateTime startDate, System.DateTime endDate, NinjaTrader.Cbi.TimePenalty penalty);
        /// <summary>
        /// QueryPastOrdersAsync method.
        /// </summary>
        /// <param name="startDate">System.DateTime</param>
        /// <param name="endDate">System.DateTime</param>
        /// <param name="retry">bool</param>
        /// <param name="penalty">NinjaTrader.Cbi.TimePenalty</param>
        /// <returns>System.Threading.Tasks.Task<System.Collections.Generic.List<NinjaTrader.Cbi.Order>></returns>
        public System.Threading.Tasks.Task<System.Collections.Generic.List<NinjaTrader.Cbi.Order>> QueryPastOrdersAsync(System.DateTime startDate, System.DateTime endDate, bool retry, NinjaTrader.Cbi.TimePenalty penalty);
        #endregion
    }
}
