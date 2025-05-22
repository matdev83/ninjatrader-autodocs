namespace NinjaTrader.Server
{
    public partial interface ICqgCast : System.IDisposable
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// Update method.
        /// </summary>
        /// <param name="account">NinjaTrader.Cbi.Account</param>
        public void Update(NinjaTrader.Cbi.Account account);
        /// <summary>
        /// UpdateCommissions method.
        /// </summary>
        /// <param name="account">NinjaTrader.Cbi.Account</param>
        public void UpdateCommissions(NinjaTrader.Cbi.Account account);
        /// <summary>
        /// UpdateTransactions method.
        /// </summary>
        /// <param name="account">NinjaTrader.Cbi.Account</param>
        public void UpdateTransactions(NinjaTrader.Cbi.Account account);
        /// <summary>
        /// Update method.
        /// </summary>
        /// <param name="user">NinjaTrader.Cbi.User</param>
        public void Update(NinjaTrader.Cbi.User user);
        #endregion
    }
}
