[Serializable]
[DataContract]
namespace NinjaTrader.Cbi.TradingServices
{
    public partial class OrderStrategyRequest
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AccountId.
        /// </summary>
        [DataMember]
        public long AccountId { get; set; }
        /// <summary>
        /// Gets or sets the AccountSpec.
        /// </summary>
        [DataMember]
        public string AccountSpec { get; set; }
        /// <summary>
        /// Gets or sets the Action.
        /// </summary>
        [DataMember]
        public Action Action { get; set; }
        /// <summary>
        /// Gets or sets the OrderStrategyTypeId.
        /// </summary>
        [DataMember]
        public int OrderStrategyTypeId { get; set; }
        /// <summary>
        /// Gets or sets the Params.
        /// </summary>
        [DataMember]
        public string Params { get; set; }
        /// <summary>
        /// Gets or sets the Symbol.
        /// </summary>
        [DataMember]
        public string Symbol { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
