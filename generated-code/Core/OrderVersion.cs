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
        public DateTime ExpireTime { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public Int64 Id { get; set; }
        /// <summary>
        /// Gets or sets the MaxShow.
        /// </summary>
        [DataMember]
        public Int32 MaxShow { get; set; }
        /// <summary>
        /// Gets or sets the OrderId.
        /// </summary>
        [DataMember]
        public Int64 OrderId { get; set; }
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
        /// Gets or sets the PegDifference.
        /// </summary>
        [DataMember]
        public Double PegDifference { get; set; }
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
        /// Gets or sets the Text.
        /// </summary>
        [DataMember]
        public String Text { get; set; }
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
