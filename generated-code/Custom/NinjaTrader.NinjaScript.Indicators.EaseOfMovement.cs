[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class EaseOfMovement : NinjaTrader.NinjaScript.Indicators.Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Smoothing.
        /// </summary>
        [DataMember]
        public int Smoothing { get; set; }
        /// <summary>
        /// Gets or sets the VolumeDivisor.
        /// </summary>
        [DataMember]
        public int VolumeDivisor { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
