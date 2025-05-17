[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class RIND : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the PeriodQ.
        /// </summary>
        [DataMember]
        public Int32 PeriodQ { get; set; }
        /// <summary>
        /// Gets or sets the Smooth.
        /// </summary>
        [DataMember]
        public Int32 Smooth { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
