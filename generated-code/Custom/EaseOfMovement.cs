[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class EaseOfMovement : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Smoothing.
        /// </summary>
        [DataMember]
        public Int32 Smoothing { get; set; }
        /// <summary>
        /// Gets or sets the VolumeDivisor.
        /// </summary>
        [DataMember]
        public Int32 VolumeDivisor { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
