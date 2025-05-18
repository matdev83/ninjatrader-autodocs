[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.MarketAnalyzerColumns
{
    public partial class ProfitLoss : MarketAnalyzerColumn
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AccountName.
        /// </summary>
        [DataMember]
        public String AccountName { get; set; }
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
