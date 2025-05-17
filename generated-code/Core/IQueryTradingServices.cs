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
        /// <param name="id">Int64</param>
        /// <returns>Task</returns>
        public Task CompleteNotificationAsync(Int64 id);
        /// <summary>
        /// ModifiyDemoAccountBalance method.
        /// </summary>
        /// <param name="account">Account</param>
        /// <param name="amount">Double</param>
        /// <returns>Task</returns>
        public Task ModifiyDemoAccountBalance(Account account, Double amount);
        /// <summary>
        /// ModifiyDemoAccountNickname method.
        /// </summary>
        /// <param name="account">Account</param>
        /// <param name="nickname">String</param>
        /// <param name="taskCompletionSource">TaskCompletionSource`1</param>
        /// <returns>Task`1</returns>
        public Task<String> ModifiyDemoAccountNickname(Account account, String nickname, TaskCompletionSource<String> taskCompletionSource);
        /// <summary>
        /// QueryNotificationsAsync method.
        /// </summary>
        /// <returns>Task</returns>
        public Task QueryNotificationsAsync();
        /// <summary>
        /// StartAtmStrategyAsync method.
        /// </summary>
        /// <param name="account">Account</param>
        /// <param name="instrument">Instrument</param>
        /// <param name="action">OrderAction</param>
        /// <param name="entryInfo">StrategyEntryInfo</param>
        /// <param name="serverAtmStrategy">ServerAtmStrategy</param>
        /// <param name="isSimulatedOrder">Boolean</param>
        /// <returns>Task</returns>
        public Task StartAtmStrategyAsync(Account account, Instrument instrument, OrderAction action, StrategyEntryInfo entryInfo, ServerAtmStrategy serverAtmStrategy, Boolean isSimulatedOrder);
        /// <summary>
        /// StopAtmStrategyAsync method.
        /// </summary>
        /// <param name="strategyId">Int64</param>
        /// <returns>Task</returns>
        public Task StopAtmStrategyAsync(Int64 strategyId);
        /// <summary>
        /// UploadUserAtmTemplates method.
        /// </summary>
        /// <returns>Task</returns>
        public Task UploadUserAtmTemplates();
        #endregion
    }
}
