[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class VolumeUpDown : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the DownVolume.
        /// </summary>
        [DataMember]
        public Series<Double> DownVolume { get; set; }
        /// <summary>
        /// Gets or sets the UpVolume.
        /// </summary>
        [DataMember]
        public Series<Double> UpVolume { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
