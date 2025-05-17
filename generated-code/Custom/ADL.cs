[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Indicators
{
    public partial class ADL : Indicator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AD.
        /// </summary>
        [DataMember]
        public Series<Double> AD { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
