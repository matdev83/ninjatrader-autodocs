[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class StartupInfo
    {
        #region Properties
        /// <summary>
        /// Gets or sets the CountCommission.
        /// </summary>
        [DataMember]
        public Int32 CountCommission { get; set; }
        /// <summary>
        /// Gets or sets the CountInstrumentList.
        /// </summary>
        [DataMember]
        public Int32 CountInstrumentList { get; set; }
        /// <summary>
        /// Gets or sets the CountMasterInstruments.
        /// </summary>
        [DataMember]
        public Int32 CountMasterInstruments { get; set; }
        /// <summary>
        /// Gets or sets the CountMessages.
        /// </summary>
        [DataMember]
        public Int32 CountMessages { get; set; }
        /// <summary>
        /// Gets or sets the CountRisk.
        /// </summary>
        [DataMember]
        public Int32 CountRisk { get; set; }
        /// <summary>
        /// Gets or sets the CountRolloverCollection.
        /// </summary>
        [DataMember]
        public Int32 CountRolloverCollection { get; set; }
        /// <summary>
        /// Gets or sets the CountTradingHours.
        /// </summary>
        [DataMember]
        public Int32 CountTradingHours { get; set; }
        /// <summary>
        /// Gets or sets the Commissions.
        /// </summary>
        [DataMember]
        public Collection<Commission> Commissions { get; set; }
        /// <summary>
        /// Gets or sets the InstrumentLists.
        /// </summary>
        [DataMember]
        public Collection<InstrumentList> InstrumentLists { get; set; }
        /// <summary>
        /// Gets or sets the MasterInstruments.
        /// </summary>
        [DataMember]
        public Collection<MasterInstrument> MasterInstruments { get; set; }
        /// <summary>
        /// Gets or sets the MessagePollingSeconds.
        /// </summary>
        [DataMember]
        public Int32 MessagePollingSeconds { get; set; }
        /// <summary>
        /// Gets or sets the Messages.
        /// </summary>
        [DataMember]
        public Collection<Message> Messages { get; set; }
        /// <summary>
        /// Gets or sets the Risks.
        /// </summary>
        [DataMember]
        public Collection<Risk> Risks { get; set; }
        /// <summary>
        /// Gets or sets the RolloverCollection.
        /// </summary>
        [DataMember]
        public Dictionary<String, RolloverCollection> RolloverCollection { get; set; }
        /// <summary>
        /// Gets or sets the TradingHours.
        /// </summary>
        [DataMember]
        public Collection<TradingHours> TradingHours { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
