[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class BarsEditKeyedCollection : KeyedCollection<String, BarsEditCollection>
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// Add method.
        /// </summary>
        /// <param name="key">String</param>
        /// <param name="barsEditCollection">BarsEditCollection</param>
        public Void Add(String key, BarsEditCollection barsEditCollection);
        /// <summary>
        /// GetKey method.
        /// </summary>
        /// <param name="instrument">Instrument</param>
        /// <param name="dataType">MarketDataType</param>
        /// <param name="periodType">BarsPeriodType</param>
        /// <returns>String</returns>
        public String GetKey(Instrument instrument, MarketDataType dataType, BarsPeriodType periodType);
        #endregion
    }
}
