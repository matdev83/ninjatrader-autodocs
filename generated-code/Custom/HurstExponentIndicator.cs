[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class HurstExponentIndicator : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Length.
        /// </summary>
        [DataMember]
        public Int32 Length { get; set; }
        /// <summary>
        /// Gets or sets the BaseScale.
        /// </summary>
        [DataMember]
        public Int32 BaseScale { get; set; }
        /// <summary>
        /// Gets or sets the MaxScale.
        /// </summary>
        [DataMember]
        public Int32 MaxScale { get; set; }
        /// <summary>
        /// Gets or sets the HurstExp.
        /// </summary>
        [DataMember]
        public Series<Double> HurstExp { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
