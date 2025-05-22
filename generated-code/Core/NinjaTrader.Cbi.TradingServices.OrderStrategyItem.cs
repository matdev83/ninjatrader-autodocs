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
        public long AccountId { get; set; }
        /// <summary>
        /// Gets or sets the Action.
        /// </summary>
        [DataMember]
        public Action Action { get; set; }
        /// <summary>
        /// Gets or sets the ContractId.
        /// </summary>
        [DataMember]
        public long ContractId { get; set; }
        /// <summary>
        /// Gets or sets the CustomTag50.
        /// </summary>
        [DataMember]
        public long CustomTag50 { get; set; }
        /// <summary>
        /// Gets or sets the FailureMessage.
        /// </summary>
        [DataMember]
        public string FailureMessage { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public long Id { get; set; }
        /// <summary>
        /// Gets or sets the InitiatorId.
        /// </summary>
        [DataMember]
        public long InitiatorId { get; set; }
        /// <summary>
        /// Gets or sets the OrderStrategyTypeId.
        /// </summary>
        [DataMember]
        public long OrderStrategyTypeId { get; set; }
        /// <summary>
        /// Gets or sets the Params.
        /// </summary>
        [DataMember]
        public string Params { get; set; }
        /// <summary>
        /// Gets or sets the SenderId.
        /// </summary>
        [DataMember]
        public long SenderId { get; set; }
        /// <summary>
        /// Gets or sets the Status.
        /// </summary>
        [DataMember]
        public ServerStrategyStatus Status { get; set; }
        /// <summary>
        /// Gets or sets the Timestamp.
        /// </summary>
        [DataMember]
        public System.DateTime Timestamp { get; set; }
        /// <summary>
        /// Gets or sets the UserSessionId.
        /// </summary>
        [DataMember]
        public long UserSessionId { get; set; }
        /// <summary>
        /// Gets or sets the Uuid.
        /// </summary>
        [DataMember]
        public long Uuid { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
