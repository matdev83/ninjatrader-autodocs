namespace NinjaTrader.NinjaScript
{
    public partial interface IStrategyInputsProvider
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// GetInputs method.
        /// </summary>
        /// <returns>System.Collections.Generic.List<System.Tuple<string, NinjaTrader.Data.BarsPeriod>></returns>
        public System.Collections.Generic.List<System.Tuple<string, NinjaTrader.Data.BarsPeriod>> GetInputs();
        #endregion
    }
}
