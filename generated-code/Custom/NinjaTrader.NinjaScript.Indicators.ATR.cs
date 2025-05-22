[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class ATR : NinjaTrader.NinjaScript.Indicators.Indicator
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
