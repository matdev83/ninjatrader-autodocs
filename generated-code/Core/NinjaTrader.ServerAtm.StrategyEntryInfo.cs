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
        public int OrderQty { get; set; }
        /// <summary>
        /// Gets or sets the OrderType.
        /// </summary>
        [DataMember]
        public TradingServicesOrderType OrderType { get; set; }
        /// <summary>
        /// Gets or sets the Price.
        /// </summary>
        [DataMember]
        public double Price { get; set; }
        /// <summary>
        /// Gets or sets the StopPrice.
        /// </summary>
        [DataMember]
        public double StopPrice { get; set; }
        /// <summary>
        /// Gets or sets the TimeInForce.
        /// </summary>
        [DataMember]
        public TradingServicesTimeInForce TimeInForce { get; set; }
        /// <summary>
        /// Gets or sets the ExpireTime.
        /// </summary>
        [DataMember]
        public System.DateTime ExpireTime { get; set; }
        /// <summary>
        /// Gets or sets the Text.
        /// </summary>
        [DataMember]
        public string Text { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
