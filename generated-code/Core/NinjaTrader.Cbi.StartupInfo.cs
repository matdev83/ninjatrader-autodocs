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
        public int CountCommission { get; set; }
        /// <summary>
        /// Gets or sets the CountInstrumentList.
        /// </summary>
        [DataMember]
        public int CountInstrumentList { get; set; }
        /// <summary>
        /// Gets or sets the CountMasterInstruments.
        /// </summary>
        [DataMember]
        public int CountMasterInstruments { get; set; }
        /// <summary>
        /// Gets or sets the CountMessages.
        /// </summary>
        [DataMember]
        public int CountMessages { get; set; }
        /// <summary>
        /// Gets or sets the CountRisk.
        /// </summary>
        [DataMember]
        public int CountRisk { get; set; }
        /// <summary>
        /// Gets or sets the CountRolloverCollection.
        /// </summary>
        [DataMember]
        public int CountRolloverCollection { get; set; }
        /// <summary>
        /// Gets or sets the CountTradingHours.
        /// </summary>
        [DataMember]
        public int CountTradingHours { get; set; }
        /// <summary>
        /// Gets or sets the Commissions.
        /// </summary>
        [DataMember]
        public System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Commission> Commissions { get; set; }
        /// <summary>
        /// Gets or sets the InstrumentLists.
        /// </summary>
        [DataMember]
        public System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.InstrumentList> InstrumentLists { get; set; }
        /// <summary>
        /// Gets or sets the MasterInstruments.
        /// </summary>
        [DataMember]
        public System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.MasterInstrument> MasterInstruments { get; set; }
        /// <summary>
        /// Gets or sets the MessagePollingSeconds.
        /// </summary>
        [DataMember]
        public int MessagePollingSeconds { get; set; }
        /// <summary>
        /// Gets or sets the Messages.
        /// </summary>
        [DataMember]
        public System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Message> Messages { get; set; }
        /// <summary>
        /// Gets or sets the Risks.
        /// </summary>
        [DataMember]
        public System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Risk> Risks { get; set; }
        /// <summary>
        /// Gets or sets the RolloverCollection.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<string, NinjaTrader.Cbi.RolloverCollection> RolloverCollection { get; set; }
        /// <summary>
        /// Gets or sets the TradingHours.
        /// </summary>
        [DataMember]
        public System.Collections.ObjectModel.Collection<NinjaTrader.Data.TradingHours> TradingHours { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
