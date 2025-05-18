[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class FilterCondition : ICloneable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the ApplyTo.
        /// </summary>
        [DataMember]
        public String ApplyTo { get; set; }
        /// <summary>
        /// Gets or sets the Condition.
        /// </summary>
        [DataMember]
        public Condition Condition { get; set; }
        /// <summary>
        /// Gets or sets the ConditionSerialize.
        /// </summary>
        [DataMember]
        public String ConditionSerialize { get; set; }
        /// <summary>
        /// Gets or sets the Value.
        /// </summary>
        [DataMember]
        public String Value { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>Object</returns>
        public Object Clone();
        /// <summary>
        /// IsEqual method.
        /// </summary>
        /// <param name="filterCondition">FilterCondition</param>
        /// <returns>Boolean</returns>
        public Boolean IsEqual(FilterCondition filterCondition);
        /// <summary>
        /// Matches method.
        /// </summary>
        /// <param name="column">MarketAnalyzerColumnBase</param>
        /// <param name="priorValue">Double</param>
        /// <returns>Boolean</returns>
        public Boolean Matches(MarketAnalyzerColumnBase column, Double priorValue);
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>String</returns>
        public String ToString();
        #endregion
    }
}
