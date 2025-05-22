[Serializable]
[DataContract]
namespace NinjaTrader.Cbi.TradingServices
{
    public partial class OrderVersion
    {
        #region Properties
        /// <summary>
        /// Gets or sets the ExpireTime.
        /// </summary>
        [DataMember]
        public System.DateTime ExpireTime { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public long Id { get; set; }
        /// <summary>
        /// Gets or sets the MaxShow.
        /// </summary>
        [DataMember]
        public int MaxShow { get; set; }
        /// <summary>
        /// Gets or sets the OrderId.
        /// </summary>
        [DataMember]
        public long OrderId { get; set; }
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
        /// Gets or sets the PegDifference.
        /// </summary>
        [DataMember]
        public double PegDifference { get; set; }
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
        /// Gets or sets the Text.
        /// </summary>
        [DataMember]
        public string Text { get; set; }
        /// <summary>
        /// Gets or sets the TimeInForce.
        /// </summary>
        [DataMember]
        public TradingServicesTimeInForce TimeInForce { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
