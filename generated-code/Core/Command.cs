[Serializable]
[DataContract]
namespace NinjaTrader.Cbi.TradingServices
{
    public partial class Command
    {
        #region Properties
        /// <summary>
        /// Gets or sets the ActivationTime.
        /// </summary>
        [DataMember]
        public DateTime ActivationTime { get; set; }
        /// <summary>
        /// Gets or sets the ClOrdId.
        /// </summary>
        [DataMember]
        public String ClOrdId { get; set; }
        /// <summary>
        /// Gets or sets the CommandStatus.
        /// </summary>
        [DataMember]
        public CommandStatus CommandStatus { get; set; }
        /// <summary>
        /// Gets or sets the CommandType.
        /// </summary>
        [DataMember]
        public CommandType CommandType { get; set; }
        /// <summary>
        /// Gets or sets the CustomTag50.
        /// </summary>
        [DataMember]
        public String CustomTag50 { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public Int64 Id { get; set; }
        /// <summary>
        /// Gets or sets the IsAutomated.
        /// </summary>
        [DataMember]
        public Boolean IsAutomated { get; set; }
        /// <summary>
        /// Gets or sets the OrderId.
        /// </summary>
        [DataMember]
        public Int64 OrderId { get; set; }
        /// <summary>
        /// Gets or sets the SenderId.
        /// </summary>
        [DataMember]
        public Int64 SenderId { get; set; }
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
        #endregion
        #region Methods
        #endregion
    }
}
