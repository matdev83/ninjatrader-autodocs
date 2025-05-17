[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class BarsEditCollection : Collection<BarsEdit>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Item.
        /// </summary>
        [DataMember]
        public BarsEdit Item { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Add method.
        /// </summary>
        /// <param name="barsEdit">BarsEdit</param>
        public Void Add(BarsEdit barsEdit);
        /// <summary>
        /// GetFileName method.
        /// </summary>
        /// <param name="periodType">BarsPeriodType</param>
        /// <param name="marketDataType">MarketDataType</param>
        /// <param name="instrument">Instrument</param>
        /// <returns>String</returns>
        public String GetFileName(BarsPeriodType periodType, MarketDataType marketDataType, Instrument instrument);
        /// <summary>
        /// Remove method.
        /// </summary>
        /// <param name="barsEdit">BarsEdit</param>
        public Void Remove(BarsEdit barsEdit);
        /// <summary>
        /// Write method.
        /// </summary>
        /// <param name="path">String</param>
        public Void Write(String path);
        #endregion
    }
}
