[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class EngulfingSignalIndicator : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the SignalFileName.
        /// </summary>
        [DataMember]
        public String SignalFileName { get; set; }
        /// <summary>
        /// Gets or sets the BullishAlertText.
        /// </summary>
        [DataMember]
        public String BullishAlertText { get; set; }
        /// <summary>
        /// Gets or sets the BearishAlertText.
        /// </summary>
        [DataMember]
        public String BearishAlertText { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
