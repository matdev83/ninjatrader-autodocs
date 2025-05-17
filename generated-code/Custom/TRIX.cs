[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class TRIX : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Default.
        /// </summary>
        [DataMember]
        public Series<Double> Default { get; set; }
        /// <summary>
        /// Gets or sets the Period.
        /// </summary>
        [DataMember]
        public Int32 Period { get; set; }
        /// <summary>
        /// Gets or sets the Signal.
        /// </summary>
        [DataMember]
        public Series<Double> Signal { get; set; }
        /// <summary>
        /// Gets or sets the SignalPeriod.
        /// </summary>
        [DataMember]
        public Int32 SignalPeriod { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
