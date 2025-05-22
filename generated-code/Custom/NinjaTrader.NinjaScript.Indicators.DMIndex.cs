[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class DMIndex : NinjaTrader.NinjaScript.Indicators.Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Smooth.
        /// </summary>
        [DataMember]
        public int Smooth { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
