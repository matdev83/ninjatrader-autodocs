[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class StochasticsFast : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the D.
        /// </summary>
        [DataMember]
        public Series<Double> D { get; set; }
        /// <summary>
        /// Gets or sets the K.
        /// </summary>
        [DataMember]
        public Series<Double> K { get; set; }
        /// <summary>
        /// Gets or sets the PeriodD.
        /// </summary>
        [DataMember]
        public Int32 PeriodD { get; set; }
        /// <summary>
        /// Gets or sets the PeriodK.
        /// </summary>
        [DataMember]
        public Int32 PeriodK { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
