[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class VolumeCounter : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the CountDown.
        /// </summary>
        [DataMember]
        public Boolean CountDown { get; set; }
        /// <summary>
        /// Gets or sets the ShowPercent.
        /// </summary>
        [DataMember]
        public Boolean ShowPercent { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
