[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.MarketAnalyzerColumns
{
    public partial class RelativeVolumeImproved : MarketAnalyzerColumn
    {
        #region Properties
        /// <summary>
        /// Gets or sets the OutlierRemovalRuns.
        /// </summary>
        [DataMember]
        public Int32 OutlierRemovalRuns { get; set; }
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
