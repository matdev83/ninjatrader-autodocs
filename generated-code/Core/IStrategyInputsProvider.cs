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
        /// <returns>List`1</returns>
        public List<Tuple<String, BarsPeriod>> GetInputs();
        #endregion
    }
}
