[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Optimizers
{
    public partial class StrategyGenerator : Optimizer
    {
        #region Properties
        /// <summary>
        /// Gets or sets the IsStrategyGenerator.
        /// </summary>
        [DataMember]
        public Boolean IsStrategyGenerator { get; set; }
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
        /// Gets or sets the OptimizeEntries.
        /// </summary>
        [DataMember]
        public Boolean OptimizeEntries { get; set; }
        /// <summary>
        /// Gets or sets the OptimizeExits.
        /// </summary>
        [DataMember]
        public Boolean OptimizeExits { get; set; }
        /// <summary>
        /// Gets or sets the SelectedCandleStickPattern.
        /// </summary>
        [DataMember]
        public ChartPattern[] SelectedCandleStickPattern { get; set; }
        /// <summary>
        /// Gets or sets the SelectedIndicatorTypes.
        /// </summary>
        [DataMember]
        public Type[] SelectedIndicatorTypes { get; set; }
        /// <summary>
        /// Gets or sets the ThresholdGenerations.
        /// </summary>
        [DataMember]
        public Int32 ThresholdGenerations { get; set; }
        /// <summary>
        /// Gets or sets the UseCandleStickPatternForEntries.
        /// </summary>
        [DataMember]
        public Boolean UseCandleStickPatternForEntries { get; set; }
        /// <summary>
        /// Gets or sets the UseCandleStickPatternForExits.
        /// </summary>
        [DataMember]
        public Boolean UseCandleStickPatternForExits { get; set; }
        /// <summary>
        /// Gets or sets the UseDayOfWeekForEntries.
        /// </summary>
        [DataMember]
        public Boolean UseDayOfWeekForEntries { get; set; }
        /// <summary>
        /// Gets or sets the UseDayOfWeekForExits.
        /// </summary>
        [DataMember]
        public Boolean UseDayOfWeekForExits { get; set; }
        /// <summary>
        /// Gets or sets the UseIndicatorsForEntries.
        /// </summary>
        [DataMember]
        public Boolean UseIndicatorsForEntries { get; set; }
        /// <summary>
        /// Gets or sets the UseIndicatorsForExits.
        /// </summary>
        [DataMember]
        public Boolean UseIndicatorsForExits { get; set; }
        /// <summary>
        /// Gets or sets the UseParabolicStopForExits.
        /// </summary>
        [DataMember]
        public Boolean UseParabolicStopForExits { get; set; }
        /// <summary>
        /// Gets or sets the UseSessionCloseForExits.
        /// </summary>
        [DataMember]
        public Boolean UseSessionCloseForExits { get; set; }
        /// <summary>
        /// Gets or sets the UseSessionTimeForEntries.
        /// </summary>
        [DataMember]
        public Boolean UseSessionTimeForEntries { get; set; }
        /// <summary>
        /// Gets or sets the UseSessionTimeForExits.
        /// </summary>
        [DataMember]
        public Boolean UseSessionTimeForExits { get; set; }
        /// <summary>
        /// Gets or sets the UseStopTargetsForExits.
        /// </summary>
        [DataMember]
        public Boolean UseStopTargetsForExits { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="ninjaScript">NinjaScript</param>
        public Void CopyTo(NinjaScript ninjaScript);
        #endregion
    }
}
