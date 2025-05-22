namespace NinjaTrader.NinjaScript
{
    public partial interface IConditionOffsetValueProvider
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the Value.
        /// </summary>
        [DataMember]
        public double Value { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
