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
        public Int32 CommissionVersion { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public String Id { get; set; }
        /// <summary>
        /// Gets or sets the InstrumentListVersion.
        /// </summary>
        [DataMember]
        public Int32 InstrumentListVersion { get; set; }
        /// <summary>
        /// Gets or sets the MasterInstrumentVersion.
        /// </summary>
        [DataMember]
        public Int32 MasterInstrumentVersion { get; set; }
        /// <summary>
        /// Gets or sets the RiskVersion.
        /// </summary>
        [DataMember]
        public Int32 RiskVersion { get; set; }
        /// <summary>
        /// Gets or sets the TradingHoursVersion.
        /// </summary>
        [DataMember]
        public Int32 TradingHoursVersion { get; set; }
        /// <summary>
        /// Gets or sets the TransferMessages.
        /// </summary>
        [DataMember]
        public Boolean TransferMessages { get; set; }
        /// <summary>
        /// Gets or sets the TransferRollovers.
        /// </summary>
        [DataMember]
        public Boolean TransferRollovers { get; set; }
        /// <summary>
        /// Gets or sets the Version.
        /// </summary>
        [DataMember]
        public Int32 Version { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
