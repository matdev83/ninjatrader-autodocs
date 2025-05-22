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
        public System.DateTime ActivationTime { get; set; }
        /// <summary>
        /// Gets or sets the ClOrdId.
        /// </summary>
        [DataMember]
        public string ClOrdId { get; set; }
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
        public string CustomTag50 { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public long Id { get; set; }
        /// <summary>
        /// Gets or sets the IsAutomated.
        /// </summary>
        [DataMember]
        public bool IsAutomated { get; set; }
        /// <summary>
        /// Gets or sets the OrderId.
        /// </summary>
        [DataMember]
        public long OrderId { get; set; }
        /// <summary>
        /// Gets or sets the SenderId.
        /// </summary>
        [DataMember]
        public long SenderId { get; set; }
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
        #endregion
        #region Methods
        #endregion
    }
}
