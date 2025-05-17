[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class ParabolicSAR : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Acceleration.
        /// </summary>
        [DataMember]
        public Double Acceleration { get; set; }
        /// <summary>
        /// Gets or sets the AccelerationMax.
        /// </summary>
        [DataMember]
        public Double AccelerationMax { get; set; }
        /// <summary>
        /// Gets or sets the AccelerationStep.
        /// </summary>
        [DataMember]
        public Double AccelerationStep { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
