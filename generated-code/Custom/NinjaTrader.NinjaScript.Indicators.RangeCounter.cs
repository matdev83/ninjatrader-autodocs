[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class RangeCounter : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the CountDown.
        /// </summary>
        [DataMember]
        public Boolean CountDown { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
