[Serializable]
[DataContract]
namespace NinjaTrader.Cbi.TradingServices
{
    public partial class Fill
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Action.
        /// </summary>
        [DataMember]
        public Action Action { get; set; }
        /// <summary>
        /// Gets or sets the Active.
        /// </summary>
        [DataMember]
        public bool Active { get; set; }
        /// <summary>
        /// Gets or sets the ContractId.
        /// </summary>
        [DataMember]
        public long ContractId { get; set; }
        /// <summary>
        /// Gets or sets the FinallyPaired.
        /// </summary>
        [DataMember]
        public int FinallyPaired { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public long Id { get; set; }
        /// <summary>
        /// Gets or sets the OrderId.
        /// </summary>
        [DataMember]
        public long OrderId { get; set; }
        /// <summary>
        /// Gets or sets the Price.
        /// </summary>
        [DataMember]
        public double Price { get; set; }
        /// <summary>
        /// Gets or sets the Qty.
        /// </summary>
        [DataMember]
        public int Qty { get; set; }
        /// <summary>
        /// Gets or sets the Timestamp.
        /// </summary>
        [DataMember]
        public System.DateTime Timestamp { get; set; }
        /// <summary>
        /// Gets or sets the TradeDate.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.TradingServices.TradeDate TradeDate { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
