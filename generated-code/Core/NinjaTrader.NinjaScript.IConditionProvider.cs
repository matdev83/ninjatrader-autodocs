namespace NinjaTrader.NinjaScript
{
    public partial interface IConditionProvider
    {
        #region Properties
        /// <summary>
        /// Gets or sets the GetNewCondition.
        /// </summary>
        [DataMember]
        public System.Func<NinjaTrader.NinjaScript.ConditionBase> GetNewCondition { get; set; }
        /// <summary>
        /// Gets or sets the GetConditionItems.
        /// </summary>
        [DataMember]
        public System.Func<System.Collections.Generic.IEnumerable<NinjaTrader.NinjaScript.ConditionItem>> GetConditionItems { get; set; }
        /// <summary>
        /// Gets or sets the GetValidConditions.
        /// </summary>
        [DataMember]
        public System.Func<NinjaTrader.NinjaScript.ConditionItem, NinjaTrader.NinjaScript.ConditionItem, System.Collections.ObjectModel.Collection<Condition>> GetValidConditions { get; set; }
        /// <summary>
        /// Gets or sets the GetDefaultCondition.
        /// </summary>
        [DataMember]
        public System.Func<NinjaTrader.NinjaScript.ConditionItem, NinjaTrader.NinjaScript.ConditionItem, Condition> GetDefaultCondition { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
