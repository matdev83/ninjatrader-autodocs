[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.StrategyGenerator
{
    public partial class GeneratedStrategyLogic : GeneratedStrategyLogicBase
    {
        #region Properties
        /// <summary>
        /// Gets or sets the ChartIndicators.
        /// </summary>
        [DataMember]
        public List<String> ChartIndicators { get; set; }
        /// <summary>
        /// Gets or sets the EnterOnDayOfWeek.
        /// </summary>
        [DataMember]
        public Boolean[] EnterOnDayOfWeek { get; set; }
        /// <summary>
        /// Gets or sets the ExitOnDayOfWeek.
        /// </summary>
        [DataMember]
        public Boolean[] ExitOnDayOfWeek { get; set; }
        /// <summary>
        /// Gets or sets the HasCandleStickPatternExpression.
        /// </summary>
        [DataMember]
        public Boolean HasCandleStickPatternExpression { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public Int64 Id { get; set; }
        /// <summary>
        /// Gets or sets the IsConsistent.
        /// </summary>
        [DataMember]
        public Boolean IsConsistent { get; set; }
        /// <summary>
        /// Gets or sets the IsLong.
        /// </summary>
        [DataMember]
        public Boolean IsLong { get; set; }
        /// <summary>
        /// Gets or sets the IsShort.
        /// </summary>
        [DataMember]
        public Boolean IsShort { get; set; }
        /// <summary>
        /// Gets or sets the ParabolicStopPercent.
        /// </summary>
        [DataMember]
        public Double ParabolicStopPercent { get; set; }
        /// <summary>
        /// Gets or sets the PriorPerformance.
        /// </summary>
        [DataMember]
        public Double PriorPerformance { get; set; }
        /// <summary>
        /// Gets or sets the ProfitTargetPercent.
        /// </summary>
        [DataMember]
        public Double ProfitTargetPercent { get; set; }
        /// <summary>
        /// Gets or sets the SessionMinutesForLongEntries.
        /// </summary>
        [DataMember]
        public Int32 SessionMinutesForLongEntries { get; set; }
        /// <summary>
        /// Gets or sets the SessionMinutesForLongExits.
        /// </summary>
        [DataMember]
        public Int32 SessionMinutesForLongExits { get; set; }
        /// <summary>
        /// Gets or sets the SessionMinutesForShortEntries.
        /// </summary>
        [DataMember]
        public Int32 SessionMinutesForShortEntries { get; set; }
        /// <summary>
        /// Gets or sets the SessionMinutesForShortExits.
        /// </summary>
        [DataMember]
        public Int32 SessionMinutesForShortExits { get; set; }
        /// <summary>
        /// Gets or sets the SessionMinutesOffsetForLongEntries.
        /// </summary>
        [DataMember]
        public Int32 SessionMinutesOffsetForLongEntries { get; set; }
        /// <summary>
        /// Gets or sets the SessionMinutesOffsetForLongExits.
        /// </summary>
        [DataMember]
        public Int32 SessionMinutesOffsetForLongExits { get; set; }
        /// <summary>
        /// Gets or sets the SessionMinutesOffsetForShortEntries.
        /// </summary>
        [DataMember]
        public Int32 SessionMinutesOffsetForShortEntries { get; set; }
        /// <summary>
        /// Gets or sets the SessionMinutesOffsetForShortExits.
        /// </summary>
        [DataMember]
        public Int32 SessionMinutesOffsetForShortExits { get; set; }
        /// <summary>
        /// Gets or sets the StopLossPercent.
        /// </summary>
        [DataMember]
        public Double StopLossPercent { get; set; }
        /// <summary>
        /// Gets or sets the TrailStopPercent.
        /// </summary>
        [DataMember]
        public Double TrailStopPercent { get; set; }
        /// <summary>
        /// Gets or sets the TrendStrength.
        /// </summary>
        [DataMember]
        public Int32 TrendStrength { get; set; }
        /// <summary>
        /// Gets or sets the TryLinearMutation.
        /// </summary>
        [DataMember]
        public Boolean TryLinearMutation { get; set; }
        /// <summary>
        /// Gets or sets the StrategyGenerator.
        /// </summary>
        [DataMember]
        public StrategyGenerator StrategyGenerator { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>Object</returns>
        public Object Clone();
        /// <summary>
        /// FromXml method.
        /// </summary>
        /// <param name="element">XElement</param>
        public Void FromXml(XElement element);
        /// <summary>
        /// GetCandleStickPatternLogic method.
        /// </summary>
        /// <param name="strategy">StrategyBase</param>
        /// <returns>CandleStickPatternLogic</returns>
        public CandleStickPatternLogic GetCandleStickPatternLogic(StrategyBase strategy);
        /// <summary>
        /// OnBarUpdate method.
        /// </summary>
        /// <param name="strategy">StrategyBase</param>
        public Void OnBarUpdate(StrategyBase strategy);
        /// <summary>
        /// OnStateChange method.
        /// </summary>
        /// <param name="strategy">StrategyBase</param>
        public Void OnStateChange(StrategyBase strategy);
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <param name="templateStrategy">StrategyBase</param>
        /// <returns>String</returns>
        public String ToString(StrategyBase templateStrategy);
        /// <summary>
        /// ToXml method.
        /// </summary>
        /// <returns>XElement</returns>
        public XElement ToXml();
        #endregion
    }
}
