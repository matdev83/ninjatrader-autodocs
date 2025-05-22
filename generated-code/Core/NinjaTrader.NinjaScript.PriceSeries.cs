[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class PriceSeries : NinjaTrader.NinjaScript.ISeries<double>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Bars.
        /// </summary>
        [DataMember]
        public NinjaTrader.Data.Bars Bars { get; set; }
        /// <summary>
        /// Gets or sets the Count.
        /// </summary>
        [DataMember]
        public int Count { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the PriceType.
        /// </summary>
        [DataMember]
        public PriceType PriceType { get; set; }
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
