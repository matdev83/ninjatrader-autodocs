[Serializable]
[DataContract]
namespace NinjaTrader.Cbi.TradingServices
{
    public partial class ModifyDemoAccountBalanceRequest
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AccountId.
        /// </summary>
        [DataMember]
        public Int64 AccountId { get; set; }
        /// <summary>
        /// Gets or sets the Amount.
        /// </summary>
        [DataMember]
        public Double Amount { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
