[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.MarketAnalyzerColumns
{
    public partial class RealizedProfitLoss : NinjaTrader.NinjaScript.MarketAnalyzerColumns.MarketAnalyzerColumn
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AccountName.
        /// </summary>
        [DataMember]
        public string AccountName { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Format method.
        /// </summary>
        /// <param name="value">double</param>
        /// <returns>string</returns>
        public string Format(double value)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
