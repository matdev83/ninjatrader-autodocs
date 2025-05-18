namespace NinjaTrader.Server
{
    public partial interface ICqgCast : IDisposable
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// Update method.
        /// </summary>
        /// <param name="account">Account</param>
        public Void Update(Account account);
        /// <summary>
        /// UpdateCommissions method.
        /// </summary>
        /// <param name="account">Account</param>
        public Void UpdateCommissions(Account account);
        /// <summary>
        /// UpdateTransactions method.
        /// </summary>
        /// <param name="account">Account</param>
        public Void UpdateTransactions(Account account);
        /// <summary>
        /// Update method.
        /// </summary>
        /// <param name="user">User</param>
        public Void Update(User user);
        #endregion
    }
}
