[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Optimizers
{
    public partial class Optimizer : NinjaTrader.NinjaScript.NinjaScript
    {
        #region Properties
        /// <summary>
        /// Gets or sets the NumberOfIterations.
        /// </summary>
        [DataMember]
        public long NumberOfIterations { get; set; }
        /// <summary>
        /// Gets or sets the SupportsMultiObjectiveOptimization.
        /// </summary>
        [DataMember]
        public bool SupportsMultiObjectiveOptimization { get; set; }
        /// <summary>
        /// Gets or sets the IsStrategyGenerator.
        /// </summary>
        [DataMember]
        public bool IsStrategyGenerator { get; set; }
        /// <summary>
        /// Gets or sets the KeepBestResults.
        /// </summary>
        [DataMember]
        public int KeepBestResults { get; set; }
        /// <summary>
        /// Gets or sets the LogTypeName.
        /// </summary>
        [DataMember]
        public string LogTypeName { get; set; }
        /// <summary>
        /// Gets or sets the MultiObjectiveOptimizationFitnesses.
        /// </summary>
        [DataMember]
        public NinjaTrader.NinjaScript.OptimizationFitnesses.OptimizationFitness[] MultiObjectiveOptimizationFitnesses { get; set; }
        /// <summary>
        /// Gets or sets the MultiObjectiveValues.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.List<NinjaTrader.NinjaScript.MultiObjectiveValues> MultiObjectiveValues { get; set; }
        /// <summary>
        /// Gets or sets the OptimizationGraphValues.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.List<NinjaTrader.NinjaScript.OptimizationGraphValues> OptimizationGraphValues { get; set; }
        /// <summary>
        /// Gets or sets the PreviousKeepBestResults.
        /// </summary>
        [DataMember]
        public int PreviousKeepBestResults { get; set; }
        /// <summary>
        /// Gets or sets the Progress.
        /// </summary>
        [DataMember]
        public NinjaTrader.Core.IProgress Progress { get; set; }
        /// <summary>
        /// Gets or sets the Results.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.SystemPerformance[] Results { get; set; }
        /// <summary>
        /// Gets or sets the Strategies.
        /// </summary>
        [DataMember]
        public System.Collections.ObjectModel.Collection<NinjaTrader.NinjaScript.StrategyBase> Strategies { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// GetParametersCombinationsCount method.
        /// </summary>
        /// <param name="strategyBase">NinjaTrader.NinjaScript.StrategyBase</param>
        /// <returns>long</returns>
        public long GetParametersCombinationsCount(NinjaTrader.NinjaScript.StrategyBase strategyBase)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Reset method.
        /// </summary>
        /// <param name="startWith">int</param>
        public void Reset(int startWith)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// RunIteration method.
        /// </summary>
        public void RunIteration()
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
        /// <summary>
        /// WaitForIterationsCompleted method.
        /// </summary>
        public void WaitForIterationsCompleted()
        {
            // Method implementation goes here
        }
        #endregion
    }
}
