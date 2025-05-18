[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Optimizers
{
    public partial class GeneticOptimizer : Optimizer
    {
        #region Properties
        /// <summary>
        /// Gets or sets the ConvergenceThreshold.
        /// </summary>
        [DataMember]
        public Int32 ConvergenceThreshold { get; set; }
        /// <summary>
        /// Gets or sets the CrossoverRatePecent.
        /// </summary>
        [DataMember]
        public Double CrossoverRatePecent { get; set; }
        /// <summary>
        /// Gets or sets the Generations.
        /// </summary>
        [DataMember]
        public Int32 Generations { get; set; }
        /// <summary>
        /// Gets or sets the GenerationSize.
        /// </summary>
        [DataMember]
        public Int32 GenerationSize { get; set; }
        /// <summary>
        /// Gets or sets the MinimumPerformance.
        /// </summary>
        [DataMember]
        public Double MinimumPerformance { get; set; }
        /// <summary>
        /// Gets or sets the MutationRatePercent.
        /// </summary>
        [DataMember]
        public Double MutationRatePercent { get; set; }
        /// <summary>
        /// Gets or sets the MutationStrengthPercent.
        /// </summary>
        [DataMember]
        public Double MutationStrengthPercent { get; set; }
        /// <summary>
        /// Gets or sets the ResetSizePercent.
        /// </summary>
        [DataMember]
        public Double ResetSizePercent { get; set; }
        /// <summary>
        /// Gets or sets the StabilitySizePercent.
        /// </summary>
        [DataMember]
        public Double StabilitySizePercent { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// MutateIndividual method.
        /// </summary>
        /// <param name="individual">Individual</param>
        public Void MutateIndividual(Individual individual);
        #endregion
    }
}
