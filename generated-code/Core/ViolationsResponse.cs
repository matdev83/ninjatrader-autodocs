[Serializable]
[DataContract]
namespace NinjaTrader.Cbi.TradingServices
{
    public partial class ViolationsResponse
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Violations.
        /// </summary>
        [DataMember]
        public Violation[] Violations { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
