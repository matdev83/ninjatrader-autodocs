[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class CCI : NinjaTrader.NinjaScript.Indicators.Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Period.
        /// </summary>
        [DataMember]
        public int Period { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
