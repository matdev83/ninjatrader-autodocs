[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class RSS : NinjaTrader.NinjaScript.Indicators.Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the EMA1.
        /// </summary>
        [DataMember]
        public int EMA1 { get; set; }
        /// <summary>
        /// Gets or sets the EMA2.
        /// </summary>
        [DataMember]
        public int EMA2 { get; set; }
        /// <summary>
        /// Gets or sets the Length.
        /// </summary>
        [DataMember]
        public int Length { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
