[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.MarketAnalyzerColumns
{
    public partial class HurstExponentColumn : MarketAnalyzerColumn
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Length.
        /// </summary>
        [DataMember]
        public Int32 Length { get; set; }
        /// <summary>
        /// Gets or sets the BaseScale.
        /// </summary>
        [DataMember]
        public Int32 BaseScale { get; set; }
        /// <summary>
        /// Gets or sets the MaxScale.
        /// </summary>
        [DataMember]
        public Int32 MaxScale { get; set; }
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
