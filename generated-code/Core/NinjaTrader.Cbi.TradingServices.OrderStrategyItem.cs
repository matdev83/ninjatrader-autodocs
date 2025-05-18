[Serializable]
[DataContract]
namespace NinjaTrader.Cbi.TradingServices
{
    public partial class OrderStrategyItem
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
        /// Gets or sets the ContractId.
        /// </summary>
        [DataMember]
        public Int64 ContractId { get; set; }
        /// <summary>
        /// Gets or sets the CustomTag50.
        /// </summary>
        [DataMember]
        public Int64 CustomTag50 { get; set; }
        /// <summary>
        /// Gets or sets the FailureMessage.
        /// </summary>
        [DataMember]
        public String FailureMessage { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public Int64 Id { get; set; }
        /// <summary>
        /// Gets or sets the InitiatorId.
        /// </summary>
        [DataMember]
        public Int64 InitiatorId { get; set; }
        /// <summary>
        /// Gets or sets the OrderStrategyTypeId.
        /// </summary>
        [DataMember]
        public Int64 OrderStrategyTypeId { get; set; }
        /// <summary>
        /// Gets or sets the Params.
        /// </summary>
        [DataMember]
        public String Params { get; set; }
        /// <summary>
        /// Gets or sets the SenderId.
        /// </summary>
        [DataMember]
        public Int64 SenderId { get; set; }
        /// <summary>
        /// Gets or sets the Status.
        /// </summary>
        [DataMember]
        public ServerStrategyStatus Status { get; set; }
        /// <summary>
        /// Gets or sets the Timestamp.
        /// </summary>
        [DataMember]
        public DateTime Timestamp { get; set; }
        /// <summary>
        /// Gets or sets the UserSessionId.
        /// </summary>
        [DataMember]
        public Int64 UserSessionId { get; set; }
        /// <summary>
        /// Gets or sets the Uuid.
        /// </summary>
        [DataMember]
        public Int64 Uuid { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
