[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class MoneyFlowOscillator : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Period.
        /// </summary>
        [DataMember]
        public Int32 Period { get; set; }
        /// <summary>
        /// Gets or sets the MoneyFlow.
        /// </summary>
        [DataMember]
        public Series<Double> MoneyFlow { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
