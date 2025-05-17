[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class RSS : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the EMA1.
        /// </summary>
        [DataMember]
        public Int32 EMA1 { get; set; }
        /// <summary>
        /// Gets or sets the EMA2.
        /// </summary>
        [DataMember]
        public Int32 EMA2 { get; set; }
        /// <summary>
        /// Gets or sets the Length.
        /// </summary>
        [DataMember]
        public Int32 Length { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
