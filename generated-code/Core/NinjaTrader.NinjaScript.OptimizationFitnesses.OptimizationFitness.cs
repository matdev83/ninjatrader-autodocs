[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.OptimizationFitnesses
{
    public partial class OptimizationFitness : NinjaScript
    {
        #region Properties
        /// <summary>
        /// Gets or sets the LogTypeName.
        /// </summary>
        [DataMember]
        public String LogTypeName { get; set; }
        /// <summary>
        /// Gets or sets the Strategy.
        /// </summary>
        [DataMember]
        public StrategyBase Strategy { get; set; }
        /// <summary>
        /// Gets or sets the Value.
        /// </summary>
        [DataMember]
        public Double Value { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// CalculatePerformanceValue method.
        /// </summary>
        /// <param name="strategy">StrategyBase</param>
        public Void CalculatePerformanceValue(StrategyBase strategy);
        /// <summary>
        /// SetState method.
        /// </summary>
        /// <param name="state">State</param>
        public Void SetState(State state);
        #endregion
    }
}
