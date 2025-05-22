[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class ParabolicSAR : NinjaTrader.NinjaScript.Indicators.Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Acceleration.
        /// </summary>
        [DataMember]
        public double Acceleration { get; set; }
        /// <summary>
        /// Gets or sets the AccelerationMax.
        /// </summary>
        [DataMember]
        public double AccelerationMax { get; set; }
        /// <summary>
        /// Gets or sets the AccelerationStep.
        /// </summary>
        [DataMember]
        public double AccelerationStep { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
