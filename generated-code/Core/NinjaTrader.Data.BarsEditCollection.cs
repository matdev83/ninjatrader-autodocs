[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class BarsEditCollection : System.Collections.ObjectModel.Collection<NinjaTrader.Data.BarsEdit>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Item.
        /// </summary>
        [DataMember]
        public NinjaTrader.Data.BarsEdit Item { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Add method.
        /// </summary>
        /// <param name="barsEdit">NinjaTrader.Data.BarsEdit</param>
        public void Add(NinjaTrader.Data.BarsEdit barsEdit)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetFileName method.
        /// </summary>
        /// <param name="periodType">BarsPeriodType</param>
        /// <param name="marketDataType">MarketDataType</param>
        /// <param name="instrument">NinjaTrader.Cbi.Instrument</param>
        /// <returns>string</returns>
        public string GetFileName(BarsPeriodType periodType, MarketDataType marketDataType, NinjaTrader.Cbi.Instrument instrument)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Remove method.
        /// </summary>
        /// <param name="barsEdit">NinjaTrader.Data.BarsEdit</param>
        public void Remove(NinjaTrader.Data.BarsEdit barsEdit)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Write method.
        /// </summary>
        /// <param name="path">string</param>
        public void Write(string path)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
