[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class TSF : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Forecast.
        /// </summary>
        [DataMember]
        public Int32 Forecast { get; set; }
        /// <summary>
        /// Gets or sets the Period.
        /// </summary>
        [DataMember]
        public Int32 Period { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
