[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Optimizers
{
    public partial class Optimizer : NinjaScript
    {
        #region Properties
        /// <summary>
        /// Gets or sets the NumberOfIterations.
        /// </summary>
        [DataMember]
        public Int64 NumberOfIterations { get; set; }
        /// <summary>
        /// Gets or sets the SupportsMultiObjectiveOptimization.
        /// </summary>
        [DataMember]
        public Boolean SupportsMultiObjectiveOptimization { get; set; }
        /// <summary>
        /// Gets or sets the IsStrategyGenerator.
        /// </summary>
        [DataMember]
        public Boolean IsStrategyGenerator { get; set; }
        /// <summary>
        /// Gets or sets the KeepBestResults.
        /// </summary>
        [DataMember]
        public Int32 KeepBestResults { get; set; }
        /// <summary>
        /// Gets or sets the LogTypeName.
        /// </summary>
        [DataMember]
        public String LogTypeName { get; set; }
        /// <summary>
        /// Gets or sets the MultiObjectiveOptimizationFitnesses.
        /// </summary>
        [DataMember]
        public OptimizationFitness[] MultiObjectiveOptimizationFitnesses { get; set; }
        /// <summary>
        /// Gets or sets the MultiObjectiveValues.
        /// </summary>
        [DataMember]
        public List<MultiObjectiveValues> MultiObjectiveValues { get; set; }
        /// <summary>
        /// Gets or sets the OptimizationGraphValues.
        /// </summary>
        [DataMember]
        public List<OptimizationGraphValues> OptimizationGraphValues { get; set; }
        /// <summary>
        /// Gets or sets the PreviousKeepBestResults.
        /// </summary>
        [DataMember]
        public Int32 PreviousKeepBestResults { get; set; }
        /// <summary>
        /// Gets or sets the Progress.
        /// </summary>
        [DataMember]
        public IProgress Progress { get; set; }
        /// <summary>
        /// Gets or sets the Results.
        /// </summary>
        [DataMember]
        public SystemPerformance[] Results { get; set; }
        /// <summary>
        /// Gets or sets the Strategies.
        /// </summary>
        [DataMember]
        public Collection<StrategyBase> Strategies { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// GetParametersCombinationsCount method.
        /// </summary>
        /// <param name="strategyBase">StrategyBase</param>
        /// <returns>Int64</returns>
        public Int64 GetParametersCombinationsCount(StrategyBase strategyBase);
        /// <summary>
        /// Reset method.
        /// </summary>
        /// <param name="startWith">Int32</param>
        public Void Reset(Int32 startWith);
        /// <summary>
        /// RunIteration method.
        /// </summary>
        public Void RunIteration();
        /// <summary>
        /// SetState method.
        /// </summary>
        /// <param name="state">State</param>
        public Void SetState(State state);
        /// <summary>
        /// WaitForIterationsCompleted method.
        /// </summary>
        public Void WaitForIterationsCompleted();
        #endregion
    }
}
