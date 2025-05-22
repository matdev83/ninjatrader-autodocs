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
        public double Frequency { get; set; }
        /// <summary>
        /// Gets or sets the ProfitTrigger.
        /// </summary>
        [DataMember]
        public double ProfitTrigger { get; set; }
        /// <summary>
        /// Gets or sets the StopLoss.
        /// </summary>
        [DataMember]
        public double StopLoss { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
