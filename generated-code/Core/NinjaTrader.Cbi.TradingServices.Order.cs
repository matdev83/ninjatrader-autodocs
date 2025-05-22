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
        public long AccountId { get; set; }
        /// <summary>
        /// Gets or sets the Action.
        /// </summary>
        [DataMember]
        public Action Action { get; set; }
        /// <summary>
        /// Gets or sets the Admin.
        /// </summary>
        [DataMember]
        public bool Admin { get; set; }
        /// <summary>
        /// Gets or sets the ContractId.
        /// </summary>
        [DataMember]
        public long ContractId { get; set; }
        /// <summary>
        /// Gets or sets the ExecutionProviderId.
        /// </summary>
        [DataMember]
        public long ExecutionProviderId { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public long Id { get; set; }
        /// <summary>
        /// Gets or sets the LinkedId.
        /// </summary>
        [DataMember]
        public long LinkedId { get; set; }
        /// <summary>
        /// Gets or sets the OcoId.
        /// </summary>
        [DataMember]
        public long OcoId { get; set; }
        /// <summary>
        /// Gets or sets the OrdStatus.
        /// </summary>
        [DataMember]
        public OrdStatus OrdStatus { get; set; }
        /// <summary>
        /// Gets or sets the ParentId.
        /// </summary>
        [DataMember]
        public long ParentId { get; set; }
        /// <summary>
        /// Gets or sets the Quantity.
        /// </summary>
        [DataMember]
        public int Quantity { get; set; }
        /// <summary>
        /// Gets or sets the SpreadDefinitionId.
        /// </summary>
        [DataMember]
        public long SpreadDefinitionId { get; set; }
        /// <summary>
        /// Gets or sets the Type.
        /// </summary>
        [DataMember]
        public ReportingOrderType Type { get; set; }
        /// <summary>
        /// Gets or sets the Timestamp.
        /// </summary>
        [DataMember]
        public System.DateTime Timestamp { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
