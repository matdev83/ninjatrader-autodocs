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
        public Int64 AccountId { get; set; }
        /// <summary>
        /// Gets or sets the Action.
        /// </summary>
        [DataMember]
        public Action Action { get; set; }
        /// <summary>
        /// Gets or sets the AvgPx.
        /// </summary>
        [DataMember]
        public Double AvgPx { get; set; }
        /// <summary>
        /// Gets or sets the CommandId.
        /// </summary>
        [DataMember]
        public Int64 CommandId { get; set; }
        /// <summary>
        /// Gets or sets the ContractId.
        /// </summary>
        [DataMember]
        public Int64 ContractId { get; set; }
        /// <summary>
        /// Gets or sets the CumQty.
        /// </summary>
        [DataMember]
        public Int32 CumQty { get; set; }
        /// <summary>
        /// Gets or sets the ExchangeOrderId.
        /// </summary>
        [DataMember]
        public String ExchangeOrderId { get; set; }
        /// <summary>
        /// Gets or sets the ExecRefId.
        /// </summary>
        [DataMember]
        public String ExecRefId { get; set; }
        /// <summary>
        /// Gets or sets the ExecType.
        /// </summary>
        [DataMember]
        public ExecType ExecType { get; set; }
        /// <summary>
        /// Gets or sets the ExternalClOrdId.
        /// </summary>
        [DataMember]
        public String ExternalClOrdId { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public Int64 Id { get; set; }
        /// <summary>
        /// Gets or sets the LastPx.
        /// </summary>
        [DataMember]
        public Double LastPx { get; set; }
        /// <summary>
        /// Gets or sets the LastQty.
        /// </summary>
        [DataMember]
        public Int32 LastQty { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public String Name { get; set; }
        /// <summary>
        /// Gets or sets the OrderId.
        /// </summary>
        [DataMember]
        public Int64 OrderId { get; set; }
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
        public String Text { get; set; }
        /// <summary>
        /// Gets or sets the Timestamp.
        /// </summary>
        [DataMember]
        public DateTime Timestamp { get; set; }
        /// <summary>
        /// Gets or sets the TradeDate.
        /// </summary>
        [DataMember]
        public TradeDate TradeDate { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
