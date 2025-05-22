[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class VolumeSeries : NinjaTrader.NinjaScript.ISeries<double>
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
        public double Item { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// GetValueAt method.
        /// </summary>
        /// <param name="barIndex">int</param>
        /// <returns>double</returns>
        public double GetValueAt(int barIndex)
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
