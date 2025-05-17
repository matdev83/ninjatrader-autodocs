[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class Aroon : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Down.
        /// </summary>
        [DataMember]
        public Series<Double> Down { get; set; }
        /// <summary>
        /// Gets or sets the Period.
        /// </summary>
        [DataMember]
        public Int32 Period { get; set; }
        /// <summary>
        /// Gets or sets the Up.
        /// </summary>
        [DataMember]
        public Series<Double> Up { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
