namespace NinjaTrader.NinjaScript
{
    public partial interface IConditionProvider
    {
        #region Properties
        /// <summary>
        /// Gets or sets the GetNewCondition.
        /// </summary>
        [DataMember]
        public Func<ConditionBase> GetNewCondition { get; set; }
        /// <summary>
        /// Gets or sets the GetConditionItems.
        /// </summary>
        [DataMember]
        public Func<IEnumerable<ConditionItem>> GetConditionItems { get; set; }
        /// <summary>
        /// Gets or sets the GetValidConditions.
        /// </summary>
        [DataMember]
        public Func<ConditionItem, ConditionItem, Collection<Condition>> GetValidConditions { get; set; }
        /// <summary>
        /// Gets or sets the GetDefaultCondition.
        /// </summary>
        [DataMember]
        public Func<ConditionItem, ConditionItem, Condition> GetDefaultCondition { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
