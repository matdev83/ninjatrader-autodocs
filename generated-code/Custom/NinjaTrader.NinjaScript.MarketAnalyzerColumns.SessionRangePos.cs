[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.MarketAnalyzerColumns
{
    public partial class SessionRangePos : MarketAnalyzerColumn
    {
        #region Properties
        /// <summary>
        /// Gets or sets the RangePeriodType.
        /// </summary>
        [DataMember]
        public RangeTimeFrame RangePeriodType { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Format method.
        /// </summary>
        /// <param name="value">Double</param>
        /// <returns>String</returns>
        public String Format(Double value);
        #endregion
    }
}
