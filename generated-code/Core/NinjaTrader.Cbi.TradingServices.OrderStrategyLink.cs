[Serializable]
[DataContract]
namespace NinjaTrader.Cbi.TradingServices
{
    public partial class OrderStrategyLink
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public Int64 Id { get; set; }
        /// <summary>
        /// Gets or sets the OrderStrategyId.
        /// </summary>
        [DataMember]
        public Int64 OrderStrategyId { get; set; }
        /// <summary>
        /// Gets or sets the OrderId.
        /// </summary>
        [DataMember]
        public Int64 OrderId { get; set; }
        /// <summary>
        /// Gets or sets the Label.
        /// </summary>
        [DataMember]
        public String Label { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
