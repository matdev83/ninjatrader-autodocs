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
        public Int64 AccountId { get; set; }
        /// <summary>
        /// Gets or sets the AccountSpec.
        /// </summary>
        [DataMember]
        public String AccountSpec { get; set; }
        /// <summary>
        /// Gets or sets the Action.
        /// </summary>
        [DataMember]
        public Action Action { get; set; }
        /// <summary>
        /// Gets or sets the OrderStrategyTypeId.
        /// </summary>
        [DataMember]
        public Int32 OrderStrategyTypeId { get; set; }
        /// <summary>
        /// Gets or sets the Params.
        /// </summary>
        [DataMember]
        public String Params { get; set; }
        /// <summary>
        /// Gets or sets the Symbol.
        /// </summary>
        [DataMember]
        public String Symbol { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
