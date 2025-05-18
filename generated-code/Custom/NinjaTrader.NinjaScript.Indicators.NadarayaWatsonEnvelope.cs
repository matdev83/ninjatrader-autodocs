[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class NadarayaWatsonEnvelope : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Bandwidth.
        /// </summary>
        [DataMember]
        public Double Bandwidth { get; set; }
        /// <summary>
        /// Gets or sets the Multiplier.
        /// </summary>
        [DataMember]
        public Double Multiplier { get; set; }
        /// <summary>
        /// Gets or sets the RepaintingSmoothing.
        /// </summary>
        [DataMember]
        public Boolean RepaintingSmoothing { get; set; }
        /// <summary>
        /// Gets or sets the UpColor.
        /// </summary>
        [DataMember]
        public Brush UpColor { get; set; }
        /// <summary>
        /// Gets or sets the DownColor.
        /// </summary>
        [DataMember]
        public Brush DownColor { get; set; }
        /// <summary>
        /// Gets or sets the EnvelopeUpperValue.
        /// </summary>
        [DataMember]
        public Double EnvelopeUpperValue { get; set; }
        /// <summary>
        /// Gets or sets the EnvelopeLowerValue.
        /// </summary>
        [DataMember]
        public Double EnvelopeLowerValue { get; set; }
        /// <summary>
        /// Gets or sets the LongSignal.
        /// </summary>
        [DataMember]
        public Boolean LongSignal { get; set; }
        /// <summary>
        /// Gets or sets the ShortSignal.
        /// </summary>
        [DataMember]
        public Boolean ShortSignal { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
