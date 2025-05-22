[Serializable]
[DataContract]
namespace NinjaTrader.Cbi.TradingServices
{
    public partial class ExecutionReport
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AccountId.
        /// </summary>
        [DataMember]
        public long AccountId { get; set; }
        /// <summary>
        /// Gets or sets the Action.
        /// </summary>
        [DataMember]
        public Action Action { get; set; }
        /// <summary>
        /// Gets or sets the AvgPx.
        /// </summary>
        [DataMember]
        public double AvgPx { get; set; }
        /// <summary>
        /// Gets or sets the CommandId.
        /// </summary>
        [DataMember]
        public long CommandId { get; set; }
        /// <summary>
        /// Gets or sets the ContractId.
        /// </summary>
        [DataMember]
        public long ContractId { get; set; }
        /// <summary>
        /// Gets or sets the CumQty.
        /// </summary>
        [DataMember]
        public int CumQty { get; set; }
        /// <summary>
        /// Gets or sets the ExchangeOrderId.
        /// </summary>
        [DataMember]
        public string ExchangeOrderId { get; set; }
        /// <summary>
        /// Gets or sets the ExecRefId.
        /// </summary>
        [DataMember]
        public string ExecRefId { get; set; }
        /// <summary>
        /// Gets or sets the ExecType.
        /// </summary>
        [DataMember]
        public ExecType ExecType { get; set; }
        /// <summary>
        /// Gets or sets the ExternalClOrdId.
        /// </summary>
        [DataMember]
        public string ExternalClOrdId { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public long Id { get; set; }
        /// <summary>
        /// Gets or sets the LastPx.
        /// </summary>
        [DataMember]
        public double LastPx { get; set; }
        /// <summary>
        /// Gets or sets the LastQty.
        /// </summary>
        [DataMember]
        public int LastQty { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the OrderId.
        /// </summary>
        [DataMember]
        public long OrderId { get; set; }
        /// <summary>
        /// Gets or sets the OrdStatus.
        /// </summary>
        [DataMember]
        public OrdStatus OrdStatus { get; set; }
        /// <summary>
        /// Gets or sets the RejectReason.
        /// </summary>
        [DataMember]
        public RejectReason RejectReason { get; set; }
        /// <summary>
        /// Gets or sets the Text.
        /// </summary>
        [DataMember]
        public string Text { get; set; }
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
