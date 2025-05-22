[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class PFE : NinjaTrader.NinjaScript.Indicators.Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Period.
        /// </summary>
        [DataMember]
        public int Period { get; set; }
        /// <summary>
        /// Gets or sets the Smooth.
        /// </summary>
        [DataMember]
        public int Smooth { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
