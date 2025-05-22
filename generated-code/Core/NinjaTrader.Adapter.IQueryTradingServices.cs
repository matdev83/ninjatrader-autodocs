namespace NinjaTrader.Adapter
{
    public partial interface IQueryTradingServices
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// CompleteNotificationAsync method.
        /// </summary>
        /// <param name="id">long</param>
        /// <returns>System.Threading.Tasks.Task</returns>
        public System.Threading.Tasks.Task CompleteNotificationAsync(long id);
        /// <summary>
        /// ModifiyDemoAccountBalance method.
        /// </summary>
        /// <param name="account">NinjaTrader.Cbi.Account</param>
        /// <param name="amount">double</param>
        /// <returns>System.Threading.Tasks.Task</returns>
        public System.Threading.Tasks.Task ModifiyDemoAccountBalance(NinjaTrader.Cbi.Account account, double amount);
        /// <summary>
        /// ModifiyDemoAccountNickname method.
        /// </summary>
        /// <param name="account">NinjaTrader.Cbi.Account</param>
        /// <param name="nickname">string</param>
        /// <param name="taskCompletionSource">System.Threading.Tasks.TaskCompletionSource<string></param>
        /// <returns>System.Threading.Tasks.Task<string></returns>
        public System.Threading.Tasks.Task<string> ModifiyDemoAccountNickname(NinjaTrader.Cbi.Account account, string nickname, System.Threading.Tasks.TaskCompletionSource<string> taskCompletionSource);
        /// <summary>
        /// QueryNotificationsAsync method.
        /// </summary>
        /// <returns>System.Threading.Tasks.Task</returns>
        public System.Threading.Tasks.Task QueryNotificationsAsync();
        /// <summary>
        /// StartAtmStrategyAsync method.
        /// </summary>
        /// <param name="account">NinjaTrader.Cbi.Account</param>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        /// <param name="action">OrderAction</param>
        /// <param name="entryInfo">NinjaTrader.ServerAtm.StrategyEntryInfo</param>
        /// <param name="serverAtmStrategy">NinjaTrader.ServerAtm.ServerAtmStrategy</param>
        /// <param name="isSimulatedOrder">bool</param>
        /// <returns>System.Threading.Tasks.Task</returns>
        public System.Threading.Tasks.Task StartAtmStrategyAsync(NinjaTrader.Cbi.Account account, NinjaTrader.Cbi.Instrument instrument, OrderAction action, NinjaTrader.ServerAtm.StrategyEntryInfo entryInfo, NinjaTrader.ServerAtm.ServerAtmStrategy serverAtmStrategy, bool isSimulatedOrder);
        /// <summary>
        /// StopAtmStrategyAsync method.
        /// </summary>
        /// <param name="strategyId">long</param>
        /// <returns>System.Threading.Tasks.Task</returns>
        public System.Threading.Tasks.Task StopAtmStrategyAsync(long strategyId);
        /// <summary>
        /// UploadUserAtmTemplates method.
        /// </summary>
        /// <returns>System.Threading.Tasks.Task</returns>
        public System.Threading.Tasks.Task UploadUserAtmTemplates();
        #endregion
    }
}
