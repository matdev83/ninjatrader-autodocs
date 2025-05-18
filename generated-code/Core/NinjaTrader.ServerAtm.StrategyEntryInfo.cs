[Serializable]
[DataContract]
namespace NinjaTrader.ServerAtm
{
    public partial class StrategyEntryInfo
    {
        #region Properties
        /// <summary>
        /// Gets or sets the OrderQty.
        /// </summary>
        [DataMember]
        public Int32 OrderQty { get; set; }
        /// <summary>
        /// Gets or sets the OrderType.
        /// </summary>
        [DataMember]
        public TradingServicesOrderType OrderType { get; set; }
        /// <summary>
        /// Gets or sets the Price.
        /// </summary>
        [DataMember]
        public Double Price { get; set; }
        /// <summary>
        /// Gets or sets the StopPrice.
        /// </summary>
        [DataMember]
        public Double StopPrice { get; set; }
        /// <summary>
        /// Gets or sets the TimeInForce.
        /// </summary>
        [DataMember]
        public TradingServicesTimeInForce TimeInForce { get; set; }
        /// <summary>
        /// Gets or sets the ExpireTime.
        /// </summary>
        [DataMember]
        public DateTime ExpireTime { get; set; }
        /// <summary>
        /// Gets or sets the Text.
        /// </summary>
        [DataMember]
        public String Text { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
