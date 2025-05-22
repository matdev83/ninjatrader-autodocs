[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class FilterCondition : System.ICloneable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the ApplyTo.
        /// </summary>
        [DataMember]
        public string ApplyTo { get; set; }
        /// <summary>
        /// Gets or sets the Condition.
        /// </summary>
        [DataMember]
        public Condition Condition { get; set; }
        /// <summary>
        /// Gets or sets the ConditionSerialize.
        /// </summary>
        [DataMember]
        public string ConditionSerialize { get; set; }
        /// <summary>
        /// Gets or sets the Value.
        /// </summary>
        [DataMember]
        public string Value { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>object</returns>
        public object Clone()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// IsEqual method.
        /// </summary>
        /// <param name="filterCondition">NinjaTrader.NinjaScript.FilterCondition</param>
        /// <returns>bool</returns>
        public bool IsEqual(NinjaTrader.NinjaScript.FilterCondition filterCondition)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Matches method.
        /// </summary>
        /// <param name="column">NinjaTrader.NinjaScript.MarketAnalyzerColumnBase</param>
        /// <param name="priorValue">double</param>
        /// <returns>bool</returns>
        public bool Matches(NinjaTrader.NinjaScript.MarketAnalyzerColumnBase column, double priorValue)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>string</returns>
        public string ToString()
        {
            // Method implementation goes here
        }
        #endregion
    }
}
