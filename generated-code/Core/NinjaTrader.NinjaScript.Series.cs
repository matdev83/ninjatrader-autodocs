[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class Series<T> : NinjaTrader.NinjaScript.ISeries<T>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Count.
        /// </summary>
        [DataMember]
        public int Count { get; set; }
        /// <summary>
        /// Gets or sets the NinjaScript.
        /// </summary>
        [DataMember]
        public NinjaTrader.NinjaScript.NinjaScriptBase NinjaScript { get; set; }
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
        public T GetValueAt(int barIndex)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// IsValidDataPoint method.
        /// </summary>
        /// <param name="barsAgo">int</param>
        /// <returns>bool</returns>
        public bool IsValidDataPoint(int barsAgo)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// IsValidDataPointAt method.
        /// </summary>
        /// <param name="barIndex">int</param>
        /// <returns>bool</returns>
        public bool IsValidDataPointAt(int barIndex)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Reset method.
        /// </summary>
        public void Reset()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Reset method.
        /// </summary>
        /// <param name="barsAgo">int</param>
        public void Reset(int barsAgo)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
