[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.OptimizationFitnesses
{
    public partial class OptimizationFitness : NinjaTrader.NinjaScript.NinjaScript
    {
        #region Properties
        /// <summary>
        /// Gets or sets the LogTypeName.
        /// </summary>
        [DataMember]
        public string LogTypeName { get; set; }
        /// <summary>
        /// Gets or sets the Strategy.
        /// </summary>
        [DataMember]
        public NinjaTrader.NinjaScript.StrategyBase Strategy { get; set; }
        /// <summary>
        /// Gets or sets the Value.
        /// </summary>
        [DataMember]
        public double Value { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// CalculatePerformanceValue method.
        /// </summary>
        /// <param name="strategy">NinjaTrader.NinjaScript.StrategyBase</param>
        public void CalculatePerformanceValue(NinjaTrader.NinjaScript.StrategyBase strategy)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SetState method.
        /// </summary>
        /// <param name="state">State</param>
        public void SetState(State state)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
