[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class Vortex : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Period.
        /// </summary>
        [DataMember]
        public Int32 Period { get; set; }
        /// <summary>
        /// Gets or sets the VIPlus.
        /// </summary>
        [DataMember]
        public Series<Double> VIPlus { get; set; }
        /// <summary>
        /// Gets or sets the VIMinus.
        /// </summary>
        [DataMember]
        public Series<Double> VIMinus { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
