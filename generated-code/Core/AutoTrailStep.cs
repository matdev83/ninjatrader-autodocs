[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class AutoTrailStep
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Frequency.
        /// </summary>
        [DataMember]
        public Double Frequency { get; set; }
        /// <summary>
        /// Gets or sets the ProfitTrigger.
        /// </summary>
        [DataMember]
        public Double ProfitTrigger { get; set; }
        /// <summary>
        /// Gets or sets the StopLoss.
        /// </summary>
        [DataMember]
        public Double StopLoss { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
