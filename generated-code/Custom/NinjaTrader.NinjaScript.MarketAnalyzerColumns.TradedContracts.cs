[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.MarketAnalyzerColumns
{
    public partial class TradedContracts : NinjaTrader.NinjaScript.MarketAnalyzerColumns.MarketAnalyzerColumn
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AccountName.
        /// </summary>
        [DataMember]
        public string AccountName { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
