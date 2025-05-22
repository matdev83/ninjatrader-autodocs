[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class RIND : NinjaTrader.NinjaScript.Indicators.Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the PeriodQ.
        /// </summary>
        [DataMember]
        public int PeriodQ { get; set; }
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
