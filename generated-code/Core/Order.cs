[Serializable]
[DataContract]
namespace NinjaTrader.Cbi.TradingServices
{
    public partial class Order
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
        /// Gets or sets the Admin.
        /// </summary>
        [DataMember]
        public Boolean Admin { get; set; }
        /// <summary>
        /// Gets or sets the ContractId.
        /// </summary>
        [DataMember]
        public Int64 ContractId { get; set; }
        /// <summary>
        /// Gets or sets the ExecutionProviderId.
        /// </summary>
        [DataMember]
        public Int64 ExecutionProviderId { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public Int64 Id { get; set; }
        /// <summary>
        /// Gets or sets the LinkedId.
        /// </summary>
        [DataMember]
        public Int64 LinkedId { get; set; }
        /// <summary>
        /// Gets or sets the OcoId.
        /// </summary>
        [DataMember]
        public Int64 OcoId { get; set; }
        /// <summary>
        /// Gets or sets the OrdStatus.
        /// </summary>
        [DataMember]
        public OrdStatus OrdStatus { get; set; }
        /// <summary>
        /// Gets or sets the ParentId.
        /// </summary>
        [DataMember]
        public Int64 ParentId { get; set; }
        /// <summary>
        /// Gets or sets the Quantity.
        /// </summary>
        [DataMember]
        public Int32 Quantity { get; set; }
        /// <summary>
        /// Gets or sets the SpreadDefinitionId.
        /// </summary>
        [DataMember]
        public Int64 SpreadDefinitionId { get; set; }
        /// <summary>
        /// Gets or sets the Type.
        /// </summary>
        [DataMember]
        public ReportingOrderType Type { get; set; }
        /// <summary>
        /// Gets or sets the Timestamp.
        /// </summary>
        [DataMember]
        public DateTime Timestamp { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
