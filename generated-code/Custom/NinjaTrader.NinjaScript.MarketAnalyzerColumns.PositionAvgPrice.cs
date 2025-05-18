[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.MarketAnalyzerColumns
{
    public partial class PositionAvgPrice : MarketAnalyzerColumn
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AccountName.
        /// </summary>
        [DataMember]
        public String AccountName { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
