[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Strategies
{
    public partial class AAAMatTradeCopierObserverSlave : Strategy
    {
        #region Properties
        /// <summary>
        /// Gets or sets the MasterAccountName.
        /// </summary>
        [DataMember]
        public String MasterAccountName { get; set; }
        /// <summary>
        /// Gets or sets the MasterInstrument.
        /// </summary>
        [DataMember]
        public String MasterInstrument { get; set; }
        /// <summary>
        /// Gets or sets the ContractMultiplier.
        /// </summary>
        [DataMember]
        public Double ContractMultiplier { get; set; }
        /// <summary>
        /// Gets or sets the GuardianIntervalSeconds.
        /// </summary>
        [DataMember]
        public Int32 GuardianIntervalSeconds { get; set; }
        /// <summary>
        /// Gets or sets the GuardianMaxInconsistentCycles.
        /// </summary>
        [DataMember]
        public Int32 GuardianMaxInconsistentCycles { get; set; }
        /// <summary>
        /// Gets or sets the CopyLongs.
        /// </summary>
        [DataMember]
        public Boolean CopyLongs { get; set; }
        /// <summary>
        /// Gets or sets the CopyShorts.
        /// </summary>
        [DataMember]
        public Boolean CopyShorts { get; set; }
        /// <summary>
        /// Gets or sets the DisableOppositePositionsAcrossIndexFutures.
        /// </summary>
        [DataMember]
        public Boolean DisableOppositePositionsAcrossIndexFutures { get; set; }
        /// <summary>
        /// Gets or sets the DebugOutput.
        /// </summary>
        [DataMember]
        public Boolean DebugOutput { get; set; }
        /// <summary>
        /// Gets or sets the DebugGuardian.
        /// </summary>
        [DataMember]
        public Boolean DebugGuardian { get; set; }
        /// <summary>
        /// Gets or sets the DebugTimeRange.
        /// </summary>
        [DataMember]
        public Boolean DebugTimeRange { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
