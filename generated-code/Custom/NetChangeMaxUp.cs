[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.MarketAnalyzerColumns
{
    public partial class NetChangeMaxUp : MarketAnalyzerColumn
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Unit.
        /// </summary>
        [DataMember]
        public PerformanceUnit Unit { get; set; }
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
