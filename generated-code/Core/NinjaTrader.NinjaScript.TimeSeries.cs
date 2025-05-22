[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class TimeSeries
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
        public System.DateTime Item { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// GetValueAt method.
        /// </summary>
        /// <param name="barIndex">int</param>
        /// <returns>System.DateTime</returns>
        public System.DateTime GetValueAt(int barIndex)
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
        #endregion
    }
}
