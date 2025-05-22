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
        public long Id { get; set; }
        /// <summary>
        /// Gets or sets the OrderStrategyId.
        /// </summary>
        [DataMember]
        public long OrderStrategyId { get; set; }
        /// <summary>
        /// Gets or sets the OrderId.
        /// </summary>
        [DataMember]
        public long OrderId { get; set; }
        /// <summary>
        /// Gets or sets the Label.
        /// </summary>
        [DataMember]
        public string Label { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
