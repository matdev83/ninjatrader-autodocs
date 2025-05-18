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
        /// <param name="startDate">DateTime</param>
        /// <param name="endDate">DateTime</param>
        /// <param name="penalty">TimePenalty</param>
        /// <returns>Task`1</returns>
        public Task<List<Execution>> QueryPastExecutionsAsync(DateTime startDate, DateTime endDate, TimePenalty penalty);
        /// <summary>
        /// QueryPastOrdersAsync method.
        /// </summary>
        /// <param name="startDate">DateTime</param>
        /// <param name="endDate">DateTime</param>
        /// <param name="retry">Boolean</param>
        /// <param name="penalty">TimePenalty</param>
        /// <returns>Task`1</returns>
        public Task<List<Order>> QueryPastOrdersAsync(DateTime startDate, DateTime endDate, Boolean retry, TimePenalty penalty);
        #endregion
    }
}
