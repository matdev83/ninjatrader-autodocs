[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.MarketAnalyzerColumns
{
    public partial class DailyVolume : MarketAnalyzerColumn
    {
        #region Properties
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
