namespace NinjaTrader.NinjaScript.StrategyGenerator
{
    public partial interface IGeneratedStrategy
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// OnEnterLong method.
        /// </summary>
        /// <returns>Order</returns>
        public Order OnEnterLong();
        /// <summary>
        /// OnEnterShort method.
        /// </summary>
        /// <returns>Order</returns>
        public Order OnEnterShort();
        /// <summary>
        /// OnExitLong method.
        /// </summary>
        /// <returns>Order</returns>
        public Order OnExitLong();
        /// <summary>
        /// OnExitShort method.
        /// </summary>
        /// <returns>Order</returns>
        public Order OnExitShort();
        #endregion
    }
}
