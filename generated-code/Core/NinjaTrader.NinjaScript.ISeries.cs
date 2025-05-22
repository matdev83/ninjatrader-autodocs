namespace NinjaTrader.NinjaScript
{
    public partial interface ISeries<T>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Count.
        /// </summary>
        [DataMember]
        public int Count { get; set; }
        /// <summary>
        /// Gets or sets the Item.
        /// </summary>
        [DataMember]
        public T Item { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// GetValueAt method.
        /// </summary>
        /// <param name="barIndex">int</param>
        /// <returns>T</returns>
        public T GetValueAt(int barIndex);
        /// <summary>
        /// IsValidDataPoint method.
        /// </summary>
        /// <param name="barsAgo">int</param>
        /// <returns>bool</returns>
        public bool IsValidDataPoint(int barsAgo);
        /// <summary>
        /// IsValidDataPointAt method.
        /// </summary>
        /// <param name="barIndex">int</param>
        /// <returns>bool</returns>
        public bool IsValidDataPointAt(int barIndex);
        #endregion
    }
}
