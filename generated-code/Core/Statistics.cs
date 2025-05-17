[Serializable]
[DataContract]
namespace NinjaTrader.Server
{
    public partial class Statistics
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Current.
        /// </summary>
        [DataMember]
        public Statistics Current { get; set; }
        /// <summary>
        /// Gets or sets the ServerStatisticsCurrent.
        /// </summary>
        [DataMember]
        public Dictionary<String, Statistics> ServerStatisticsCurrent { get; set; }
        /// <summary>
        /// Gets or sets the ServerStatisticsHistory.
        /// </summary>
        [DataMember]
        public Dictionary<String, List<Statistics>> ServerStatisticsHistory { get; set; }
        /// <summary>
        /// Gets or sets the ActualClients.
        /// </summary>
        [DataMember]
        public Int32[] ActualClients { get; set; }
        /// <summary>
        /// Gets or sets the AverageRealtimeDataQueueLength.
        /// </summary>
        [DataMember]
        public Double AverageRealtimeDataQueueLength { get; set; }
        /// <summary>
        /// Gets or sets the BPAccountStatistics.
        /// </summary>
        [DataMember]
        public Dictionary<Account, BPAccountStatistics> BPAccountStatistics { get; set; }
        /// <summary>
        /// Gets or sets the BPAccounts.
        /// </summary>
        [DataMember]
        public Int32 BPAccounts { get; set; }
        /// <summary>
        /// Gets or sets the BPFanoutTicks.
        /// </summary>
        [DataMember]
        public Int64 BPFanoutTicks { get; set; }
        /// <summary>
        /// Gets or sets the BPDataStatistics.
        /// </summary>
        [DataMember]
        public Dictionary<Instrument, BPDataStatistics> BPDataStatistics { get; set; }
        /// <summary>
        /// Gets or sets the BPMaxAccounts.
        /// </summary>
        [DataMember]
        public Int32 BPMaxAccounts { get; set; }
        /// <summary>
        /// Gets or sets the BPOrderStatistics.
        /// </summary>
        [DataMember]
        public OrderStatistics BPOrderStatistics { get; set; }
        /// <summary>
        /// Gets or sets the BPTradingStatistics.
        /// </summary>
        [DataMember]
        public Dictionary<Instrument, BPTradingStatistics> BPTradingStatistics { get; set; }
        /// <summary>
        /// Gets or sets the BPUserStatistics.
        /// </summary>
        [DataMember]
        public Dictionary<User, BPUserStatistics> BPUserStatistics { get; set; }
        /// <summary>
        /// Gets or sets the BytesReceivedPerSecond.
        /// </summary>
        [DataMember]
        public Int32 BytesReceivedPerSecond { get; set; }
        /// <summary>
        /// Gets or sets the BytesSentPerSecond.
        /// </summary>
        [DataMember]
        public Int32 BytesSentPerSecond { get; set; }
        /// <summary>
        /// Gets or sets the BufferOverflows.
        /// </summary>
        [DataMember]
        public Int32[] BufferOverflows { get; set; }
        /// <summary>
        /// Gets or sets the CpuUsage.
        /// </summary>
        [DataMember]
        public Double CpuUsage { get; set; }
        /// <summary>
        /// Gets or sets the DSMaxConcurrentLoginsExcess.
        /// </summary>
        [DataMember]
        public Int32 DSMaxConcurrentLoginsExcess { get; set; }
        /// <summary>
        /// Gets or sets the DSWebRequestsPerSecond.
        /// </summary>
        [DataMember]
        public Double DSWebRequestsPerSecond { get; set; }
        /// <summary>
        /// Gets or sets the DSWebRequestPacingViolations.
        /// </summary>
        [DataMember]
        public Int32 DSWebRequestPacingViolations { get; set; }
        /// <summary>
        /// Gets or sets the GWFeedErrors.
        /// </summary>
        [DataMember]
        public Int32 GWFeedErrors { get; set; }
        /// <summary>
        /// Gets or sets the GWOrdersCancelled.
        /// </summary>
        [DataMember]
        public Int32 GWOrdersCancelled { get; set; }
        /// <summary>
        /// Gets or sets the GWOrdersChanged.
        /// </summary>
        [DataMember]
        public Int32 GWOrdersChanged { get; set; }
        /// <summary>
        /// Gets or sets the GWOrdersSubmitted.
        /// </summary>
        [DataMember]
        public Int32 GWOrdersSubmitted { get; set; }
        /// <summary>
        /// Gets or sets the GWTicksOrdersCancelled.
        /// </summary>
        [DataMember]
        public Int64 GWTicksOrdersCancelled { get; set; }
        /// <summary>
        /// Gets or sets the GWTicksOrdersChanged.
        /// </summary>
        [DataMember]
        public Int64 GWTicksOrdersChanged { get; set; }
        /// <summary>
        /// Gets or sets the GWTicksOrdersSubmitted.
        /// </summary>
        [DataMember]
        public Int64 GWTicksOrdersSubmitted { get; set; }
        /// <summary>
        /// Gets or sets the HasStatistics.
        /// </summary>
        [DataMember]
        public Boolean[] HasStatistics { get; set; }
        /// <summary>
        /// Gets or sets the HDSInstruments.
        /// </summary>
        [DataMember]
        public Dictionary<Instrument, HDSStatistics> HDSInstruments { get; set; }
        /// <summary>
        /// Gets or sets the HDSNewsEvents.
        /// </summary>
        [DataMember]
        public Int32 HDSNewsEvents { get; set; }
        /// <summary>
        /// Gets or sets the HDSNewsRequests.
        /// </summary>
        [DataMember]
        public Int32 HDSNewsRequests { get; set; }
        /// <summary>
        /// Gets or sets the HDSRequestsDailyBars.
        /// </summary>
        [DataMember]
        public Int32 HDSRequestsDailyBars { get; set; }
        /// <summary>
        /// Gets or sets the HDSRequestsMinuteBars.
        /// </summary>
        [DataMember]
        public Int32 HDSRequestsMinuteBars { get; set; }
        /// <summary>
        /// Gets or sets the HDSRequestsPlayback.
        /// </summary>
        [DataMember]
        public Int32 HDSRequestsPlayback { get; set; }
        /// <summary>
        /// Gets or sets the HDSRequestsTickBars.
        /// </summary>
        [DataMember]
        public Int32 HDSRequestsTickBars { get; set; }
        /// <summary>
        /// Gets or sets the HDSTicksDailyBars.
        /// </summary>
        [DataMember]
        public Int64 HDSTicksDailyBars { get; set; }
        /// <summary>
        /// Gets or sets the HDSTicksMinuteBars.
        /// </summary>
        [DataMember]
        public Int64 HDSTicksMinuteBars { get; set; }
        /// <summary>
        /// Gets or sets the HDSTicksPlayback.
        /// </summary>
        [DataMember]
        public Int64 HDSTicksPlayback { get; set; }
        /// <summary>
        /// Gets or sets the HDSTicksTickBars.
        /// </summary>
        [DataMember]
        public Int64 HDSTicksTickBars { get; set; }
        /// <summary>
        /// Gets or sets the HealthStatus.
        /// </summary>
        [DataMember]
        public HealthStatus[] HealthStatus { get; set; }
        /// <summary>
        /// Gets or sets the HeartbeatTimeout.
        /// </summary>
        [DataMember]
        public Int32 HeartbeatTimeout { get; set; }
        /// <summary>
        /// Gets or sets the InvalidPasswords.
        /// </summary>
        [DataMember]
        public Int32 InvalidPasswords { get; set; }
        /// <summary>
        /// Gets or sets the IsHistorical.
        /// </summary>
        [DataMember]
        public Boolean IsHistorical { get; set; }
        /// <summary>
        /// Gets or sets the IsLocal.
        /// </summary>
        [DataMember]
        public Boolean IsLocal { get; set; }
        /// <summary>
        /// Gets or sets the ISCommissionData.
        /// </summary>
        [DataMember]
        public Int32 ISCommissionData { get; set; }
        /// <summary>
        /// Gets or sets the ISInstrumentListData.
        /// </summary>
        [DataMember]
        public Int32 ISInstrumentListData { get; set; }
        /// <summary>
        /// Gets or sets the ISMasterInstrumentData.
        /// </summary>
        [DataMember]
        public Int32 ISMasterInstrumentData { get; set; }
        /// <summary>
        /// Gets or sets the ISMessages.
        /// </summary>
        [DataMember]
        public Int32 ISMessages { get; set; }
        /// <summary>
        /// Gets or sets the ISRiskData.
        /// </summary>
        [DataMember]
        public Int32 ISRiskData { get; set; }
        /// <summary>
        /// Gets or sets the ISRollovers.
        /// </summary>
        [DataMember]
        public Int32 ISRollovers { get; set; }
        /// <summary>
        /// Gets or sets the ISTradingHoursData.
        /// </summary>
        [DataMember]
        public Int32 ISTradingHoursData { get; set; }
        /// <summary>
        /// Gets or sets the MaxActualClients.
        /// </summary>
        [DataMember]
        public Int32[] MaxActualClients { get; set; }
        /// <summary>
        /// Gets or sets the ProtocolError.
        /// </summary>
        [DataMember]
        public Int32 ProtocolError { get; set; }
        /// <summary>
        /// Gets or sets the RamAvailable.
        /// </summary>
        [DataMember]
        public Int64 RamAvailable { get; set; }
        /// <summary>
        /// Gets or sets the RamUsage.
        /// </summary>
        [DataMember]
        public Int64 RamUsage { get; set; }
        /// <summary>
        /// Gets or sets the RunningSince.
        /// </summary>
        [DataMember]
        public DateTime[] RunningSince { get; set; }
        /// <summary>
        /// Gets or sets the SentBytes.
        /// </summary>
        [DataMember]
        public Double[] SentBytes { get; set; }
        /// <summary>
        /// Gets or sets the SentBytesBuffered.
        /// </summary>
        [DataMember]
        public Double[] SentBytesBuffered { get; set; }
        /// <summary>
        /// Gets or sets the SentMessages.
        /// </summary>
        [DataMember]
        public Double[] SentMessages { get; set; }
        /// <summary>
        /// Gets or sets the SentTicks.
        /// </summary>
        [DataMember]
        public Int64[] SentTicks { get; set; }
        /// <summary>
        /// Gets or sets the ServerName.
        /// </summary>
        [DataMember]
        public String ServerName { get; set; }
        /// <summary>
        /// Gets or sets the TarPittedConnections.
        /// </summary>
        [DataMember]
        public Int32 TarPittedConnections { get; set; }
        /// <summary>
        /// Gets or sets the TotalClients.
        /// </summary>
        [DataMember]
        public Int32[] TotalClients { get; set; }
        /// <summary>
        /// Gets or sets the UnknownUser.
        /// </summary>
        [DataMember]
        public Int32 UnknownUser { get; set; }
        /// <summary>
        /// Gets or sets the UserAlreadyExists.
        /// </summary>
        [DataMember]
        public Int32 UserAlreadyExists { get; set; }
        /// <summary>
        /// Gets or sets the UserNameTooLong.
        /// </summary>
        [DataMember]
        public Int32 UserNameTooLong { get; set; }
        /// <summary>
        /// Gets or sets the UtcTime.
        /// </summary>
        [DataMember]
        public DateTime UtcTime { get; set; }
        /// <summary>
        /// Gets or sets the AreAllServersStopped.
        /// </summary>
        [DataMember]
        public Boolean AreAllServersStopped { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// ApplicationExit method.
        /// </summary>
        public Void ApplicationExit();
        /// <summary>
        /// ApplicationStart method.
        /// </summary>
        public Void ApplicationStart();
        #endregion
    }
}
