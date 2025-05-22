[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class HandshakeReply
    {
        #region Properties
        /// <summary>
        /// Gets or sets the ClientType.
        /// </summary>
        [DataMember]
        public ClientType ClientType { get; set; }
        /// <summary>
        /// Gets or sets the CommissionVersion.
        /// </summary>
        [DataMember]
        public int CommissionVersion { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public string Id { get; set; }
        /// <summary>
        /// Gets or sets the InstrumentListVersion.
        /// </summary>
        [DataMember]
        public int InstrumentListVersion { get; set; }
        /// <summary>
        /// Gets or sets the MasterInstrumentVersion.
        /// </summary>
        [DataMember]
        public int MasterInstrumentVersion { get; set; }
        /// <summary>
        /// Gets or sets the RiskVersion.
        /// </summary>
        [DataMember]
        public int RiskVersion { get; set; }
        /// <summary>
        /// Gets or sets the TradingHoursVersion.
        /// </summary>
        [DataMember]
        public int TradingHoursVersion { get; set; }
        /// <summary>
        /// Gets or sets the TransferMessages.
        /// </summary>
        [DataMember]
        public bool TransferMessages { get; set; }
        /// <summary>
        /// Gets or sets the TransferRollovers.
        /// </summary>
        [DataMember]
        public bool TransferRollovers { get; set; }
        /// <summary>
        /// Gets or sets the Version.
        /// </summary>
        [DataMember]
        public int Version { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
