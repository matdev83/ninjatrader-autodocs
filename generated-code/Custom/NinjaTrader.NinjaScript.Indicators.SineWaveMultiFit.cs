[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class SineWaveMultiFit : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the ZigZagDeviation.
        /// </summary>
        [DataMember]
        public Double ZigZagDeviation { get; set; }
        /// <summary>
        /// Gets or sets the MaxPivots.
        /// </summary>
        [DataMember]
        public Int32 MaxPivots { get; set; }
        /// <summary>
        /// Gets or sets the NumWaves.
        /// </summary>
        [DataMember]
        public Int32 NumWaves { get; set; }
        /// <summary>
        /// Gets or sets the MinPeriod.
        /// </summary>
        [DataMember]
        public Int32 MinPeriod { get; set; }
        /// <summary>
        /// Gets or sets the MaxPeriod.
        /// </summary>
        [DataMember]
        public Int32 MaxPeriod { get; set; }
        /// <summary>
        /// Gets or sets the ProjectionFactor.
        /// </summary>
        [DataMember]
        public Int32 ProjectionFactor { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
