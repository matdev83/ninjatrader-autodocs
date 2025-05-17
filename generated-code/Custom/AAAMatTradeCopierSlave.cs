[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Strategies
{
    public partial class AAAMatTradeCopierSlave : Strategy
    {
        #region Properties
        /// <summary>
        /// Gets or sets the MasterAccountName.
        /// </summary>
        [DataMember]
        public String MasterAccountName { get; set; }
        /// <summary>
        /// Gets or sets the MasterContractName.
        /// </summary>
        [DataMember]
        public String MasterContractName { get; set; }
        /// <summary>
        /// Gets or sets the ContractMultiplier.
        /// </summary>
        [DataMember]
        public Double ContractMultiplier { get; set; }
        /// <summary>
        /// Gets or sets the TimerMs.
        /// </summary>
        [DataMember]
        public Int32 TimerMs { get; set; }
        /// <summary>
        /// Gets or sets the GuardianCheckIntervalSeconds.
        /// </summary>
        [DataMember]
        public Int32 GuardianCheckIntervalSeconds { get; set; }
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
        /// Gets or sets the HourStart1.
        /// </summary>
        [DataMember]
        public Int32 HourStart1 { get; set; }
        /// <summary>
        /// Gets or sets the MinuteStart1.
        /// </summary>
        [DataMember]
        public Int32 MinuteStart1 { get; set; }
        /// <summary>
        /// Gets or sets the HourEnd1.
        /// </summary>
        [DataMember]
        public Int32 HourEnd1 { get; set; }
        /// <summary>
        /// Gets or sets the MinuteEnd1.
        /// </summary>
        [DataMember]
        public Int32 MinuteEnd1 { get; set; }
        /// <summary>
        /// Gets or sets the HourStart2.
        /// </summary>
        [DataMember]
        public Int32 HourStart2 { get; set; }
        /// <summary>
        /// Gets or sets the MinuteStart2.
        /// </summary>
        [DataMember]
        public Int32 MinuteStart2 { get; set; }
        /// <summary>
        /// Gets or sets the HourEnd2.
        /// </summary>
        [DataMember]
        public Int32 HourEnd2 { get; set; }
        /// <summary>
        /// Gets or sets the MinuteEnd2.
        /// </summary>
        [DataMember]
        public Int32 MinuteEnd2 { get; set; }
        /// <summary>
        /// Gets or sets the HourStart3.
        /// </summary>
        [DataMember]
        public Int32 HourStart3 { get; set; }
        /// <summary>
        /// Gets or sets the MinuteStart3.
        /// </summary>
        [DataMember]
        public Int32 MinuteStart3 { get; set; }
        /// <summary>
        /// Gets or sets the HourEnd3.
        /// </summary>
        [DataMember]
        public Int32 HourEnd3 { get; set; }
        /// <summary>
        /// Gets or sets the MinuteEnd3.
        /// </summary>
        [DataMember]
        public Int32 MinuteEnd3 { get; set; }
        /// <summary>
        /// Gets or sets the HourStart4.
        /// </summary>
        [DataMember]
        public Int32 HourStart4 { get; set; }
        /// <summary>
        /// Gets or sets the MinuteStart4.
        /// </summary>
        [DataMember]
        public Int32 MinuteStart4 { get; set; }
        /// <summary>
        /// Gets or sets the HourEnd4.
        /// </summary>
        [DataMember]
        public Int32 HourEnd4 { get; set; }
        /// <summary>
        /// Gets or sets the MinuteEnd4.
        /// </summary>
        [DataMember]
        public Int32 MinuteEnd4 { get; set; }
        /// <summary>
        /// Gets or sets the TradeSunday.
        /// </summary>
        [DataMember]
        public Boolean TradeSunday { get; set; }
        /// <summary>
        /// Gets or sets the TradeMonday.
        /// </summary>
        [DataMember]
        public Boolean TradeMonday { get; set; }
        /// <summary>
        /// Gets or sets the TradeTuesday.
        /// </summary>
        [DataMember]
        public Boolean TradeTuesday { get; set; }
        /// <summary>
        /// Gets or sets the TradeWednesday.
        /// </summary>
        [DataMember]
        public Boolean TradeWednesday { get; set; }
        /// <summary>
        /// Gets or sets the TradeThursday.
        /// </summary>
        [DataMember]
        public Boolean TradeThursday { get; set; }
        /// <summary>
        /// Gets or sets the TradeFriday.
        /// </summary>
        [DataMember]
        public Boolean TradeFriday { get; set; }
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
        /// Gets or sets the DebugTimeRanges.
        /// </summary>
        [DataMember]
        public Boolean DebugTimeRanges { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
