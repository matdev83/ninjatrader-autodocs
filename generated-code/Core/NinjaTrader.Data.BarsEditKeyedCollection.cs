[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class BarsEditKeyedCollection : System.Collections.ObjectModel.KeyedCollection<string, NinjaTrader.Data.BarsEditCollection>
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// Add method.
        /// </summary>
        /// <param name="key">string</param>
        /// <param name="barsEditCollection">NinjaTrader.Data.BarsEditCollection</param>
        public void Add(string key, NinjaTrader.Data.BarsEditCollection barsEditCollection)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetKey method.
        /// </summary>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        /// <param name="dataType">MarketDataType</param>
        /// <param name="periodType">BarsPeriodType</param>
        /// <returns>string</returns>
        public string GetKey(NinjaTrader.Cbi.Instrument instrument, MarketDataType dataType, BarsPeriodType periodType)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
