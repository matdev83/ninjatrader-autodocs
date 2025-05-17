namespace NinjaTrader.NinjaScript
{
    public partial interface ISeries`1
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Count.
        /// </summary>
        [DataMember]
        public Int32 Count { get; set; }
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
        /// <param name="barIndex">Int32</param>
        /// <returns>T</returns>
        public T GetValueAt(Int32 barIndex);
        /// <summary>
        /// IsValidDataPoint method.
        /// </summary>
        /// <param name="barsAgo">Int32</param>
        /// <returns>Boolean</returns>
        public Boolean IsValidDataPoint(Int32 barsAgo);
        /// <summary>
        /// IsValidDataPointAt method.
        /// </summary>
        /// <param name="barIndex">Int32</param>
        /// <returns>Boolean</returns>
        public Boolean IsValidDataPointAt(Int32 barIndex);
        #endregion
    }
}
