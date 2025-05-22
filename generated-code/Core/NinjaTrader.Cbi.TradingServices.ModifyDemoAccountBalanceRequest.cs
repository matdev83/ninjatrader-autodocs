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
        public long AccountId { get; set; }
        /// <summary>
        /// Gets or sets the Amount.
        /// </summary>
        [DataMember]
        public double Amount { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
