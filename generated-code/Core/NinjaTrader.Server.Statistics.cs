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
        public NinjaTrader.Server.Statistics Current { get; set; }
        /// <summary>
        /// Gets or sets the ServerStatisticsCurrent.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<string, NinjaTrader.Server.Statistics> ServerStatisticsCurrent { get; set; }
        /// <summary>
        /// Gets or sets the ServerStatisticsHistory.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<NinjaTrader.Server.Statistics>> ServerStatisticsHistory { get; set; }
        /// <summary>
        /// Gets or sets the ActualClients.
        /// </summary>
        [DataMember]
        public System.Int32[] ActualClients { get; set; }
        /// <summary>
        /// Gets or sets the AverageRealtimeDataQueueLength.
        /// </summary>
        [DataMember]
        public double AverageRealtimeDataQueueLength { get; set; }
        /// <summary>
        /// Gets or sets the BPAccountStatistics.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<NinjaTrader.Cbi.Account, NinjaTrader.Server.BPAccountStatistics> BPAccountStatistics { get; set; }
        /// <summary>
        /// Gets or sets the BPAccounts.
        /// </summary>
        [DataMember]
        public int BPAccounts { get; set; }
        /// <summary>
        /// Gets or sets the BPFanoutTicks.
        /// </summary>
        [DataMember]
        public long BPFanoutTicks { get; set; }
        /// <summary>
        /// Gets or sets the BPDataStatistics.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<NinjaTrader.Cbi.Instrument, NinjaTrader.Server.BPDataStatistics> BPDataStatistics { get; set; }
        /// <summary>
        /// Gets or sets the BPMaxAccounts.
        /// </summary>
        [DataMember]
        public int BPMaxAccounts { get; set; }
        /// <summary>
        /// Gets or sets the BPOrderStatistics.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.OrderStatistics BPOrderStatistics { get; set; }
        /// <summary>
        /// Gets or sets the BPTradingStatistics.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<NinjaTrader.Cbi.Instrument, NinjaTrader.Server.BPTradingStatistics> BPTradingStatistics { get; set; }
        /// <summary>
        /// Gets or sets the BPUserStatistics.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<NinjaTrader.Cbi.User, NinjaTrader.Server.BPUserStatistics> BPUserStatistics { get; set; }
        /// <summary>
        /// Gets or sets the BytesReceivedPerSecond.
        /// </summary>
        [DataMember]
        public int BytesReceivedPerSecond { get; set; }
        /// <summary>
        /// Gets or sets the BytesSentPerSecond.
        /// </summary>
        [DataMember]
        public int BytesSentPerSecond { get; set; }
        /// <summary>
        /// Gets or sets the BufferOverflows.
        /// </summary>
        [DataMember]
        public System.Int32[] BufferOverflows { get; set; }
        /// <summary>
        /// Gets or sets the CpuUsage.
        /// </summary>
        [DataMember]
        public double CpuUsage { get; set; }
        /// <summary>
        /// Gets or sets the DSMaxConcurrentLoginsExcess.
        /// </summary>
        [DataMember]
        public int DSMaxConcurrentLoginsExcess { get; set; }
        /// <summary>
        /// Gets or sets the DSWebRequestsPerSecond.
        /// </summary>
        [DataMember]
        public double DSWebRequestsPerSecond { get; set; }
        /// <summary>
        /// Gets or sets the DSWebRequestPacingViolations.
        /// </summary>
        [DataMember]
        public int DSWebRequestPacingViolations { get; set; }
        /// <summary>
        /// Gets or sets the GWFeedErrors.
        /// </summary>
        [DataMember]
        public int GWFeedErrors { get; set; }
        /// <summary>
        /// Gets or sets the GWOrdersCancelled.
        /// </summary>
        [DataMember]
        public int GWOrdersCancelled { get; set; }
        /// <summary>
        /// Gets or sets the GWOrdersChanged.
        /// </summary>
        [DataMember]
        public int GWOrdersChanged { get; set; }
        /// <summary>
        /// Gets or sets the GWOrdersSubmitted.
        /// </summary>
        [DataMember]
        public int GWOrdersSubmitted { get; set; }
        /// <summary>
        /// Gets or sets the GWTicksOrdersCancelled.
        /// </summary>
        [DataMember]
        public long GWTicksOrdersCancelled { get; set; }
        /// <summary>
        /// Gets or sets the GWTicksOrdersChanged.
        /// </summary>
        [DataMember]
        public long GWTicksOrdersChanged { get; set; }
        /// <summary>
        /// Gets or sets the GWTicksOrdersSubmitted.
        /// </summary>
        [DataMember]
        public long GWTicksOrdersSubmitted { get; set; }
        /// <summary>
        /// Gets or sets the HasStatistics.
        /// </summary>
        [DataMember]
        public System.Boolean[] HasStatistics { get; set; }
        /// <summary>
        /// Gets or sets the HDSInstruments.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<NinjaTrader.Cbi.Instrument, NinjaTrader.Server.HDSStatistics> HDSInstruments { get; set; }
        /// <summary>
        /// Gets or sets the HDSNewsEvents.
        /// </summary>
        [DataMember]
        public int HDSNewsEvents { get; set; }
        /// <summary>
        /// Gets or sets the HDSNewsRequests.
        /// </summary>
        [DataMember]
        public int HDSNewsRequests { get; set; }
        /// <summary>
        /// Gets or sets the HDSRequestsDailyBars.
        /// </summary>
        [DataMember]
        public int HDSRequestsDailyBars { get; set; }
        /// <summary>
        /// Gets or sets the HDSRequestsMinuteBars.
        /// </summary>
        [DataMember]
        public int HDSRequestsMinuteBars { get; set; }
        /// <summary>
        /// Gets or sets the HDSRequestsPlayback.
        /// </summary>
        [DataMember]
        public int HDSRequestsPlayback { get; set; }
        /// <summary>
        /// Gets or sets the HDSRequestsTickBars.
        /// </summary>
        [DataMember]
        public int HDSRequestsTickBars { get; set; }
        /// <summary>
        /// Gets or sets the HDSTicksDailyBars.
        /// </summary>
        [DataMember]
        public long HDSTicksDailyBars { get; set; }
        /// <summary>
        /// Gets or sets the HDSTicksMinuteBars.
        /// </summary>
        [DataMember]
        public long HDSTicksMinuteBars { get; set; }
        /// <summary>
        /// Gets or sets the HDSTicksPlayback.
        /// </summary>
        [DataMember]
        public long HDSTicksPlayback { get; set; }
        /// <summary>
        /// Gets or sets the HDSTicksTickBars.
        /// </summary>
        [DataMember]
        public long HDSTicksTickBars { get; set; }
        /// <summary>
        /// Gets or sets the HealthStatus.
        /// </summary>
        [DataMember]
        public HealthStatus[] HealthStatus { get; set; }
        /// <summary>
        /// Gets or sets the HeartbeatTimeout.
        /// </summary>
        [DataMember]
        public int HeartbeatTimeout { get; set; }
        /// <summary>
        /// Gets or sets the InvalidPasswords.
        /// </summary>
        [DataMember]
        public int InvalidPasswords { get; set; }
        /// <summary>
        /// Gets or sets the IsHistorical.
        /// </summary>
        [DataMember]
        public bool IsHistorical { get; set; }
        /// <summary>
        /// Gets or sets the IsLocal.
        /// </summary>
        [DataMember]
        public bool IsLocal { get; set; }
        /// <summary>
        /// Gets or sets the ISCommissionData.
        /// </summary>
        [DataMember]
        public int ISCommissionData { get; set; }
        /// <summary>
        /// Gets or sets the ISInstrumentListData.
        /// </summary>
        [DataMember]
        public int ISInstrumentListData { get; set; }
        /// <summary>
        /// Gets or sets the ISMasterInstrumentData.
        /// </summary>
        [DataMember]
        public int ISMasterInstrumentData { get; set; }
        /// <summary>
        /// Gets or sets the ISMessages.
        /// </summary>
        [DataMember]
        public int ISMessages { get; set; }
        /// <summary>
        /// Gets or sets the ISRiskData.
        /// </summary>
        [DataMember]
        public int ISRiskData { get; set; }
        /// <summary>
        /// Gets or sets the ISRollovers.
        /// </summary>
        [DataMember]
        public int ISRollovers { get; set; }
        /// <summary>
        /// Gets or sets the ISTradingHoursData.
        /// </summary>
        [DataMember]
        public int ISTradingHoursData { get; set; }
        /// <summary>
        /// Gets or sets the MaxActualClients.
        /// </summary>
        [DataMember]
        public System.Int32[] MaxActualClients { get; set; }
        /// <summary>
        /// Gets or sets the ProtocolError.
        /// </summary>
        [DataMember]
        public int ProtocolError { get; set; }
        /// <summary>
        /// Gets or sets the RamAvailable.
        /// </summary>
        [DataMember]
        public long RamAvailable { get; set; }
        /// <summary>
        /// Gets or sets the RamUsage.
        /// </summary>
        [DataMember]
        public long RamUsage { get; set; }
        /// <summary>
        /// Gets or sets the RunningSince.
        /// </summary>
        [DataMember]
        public System.DateTime[] RunningSince { get; set; }
        /// <summary>
        /// Gets or sets the SentBytes.
        /// </summary>
        [DataMember]
        public System.Double[] SentBytes { get; set; }
        /// <summary>
        /// Gets or sets the SentBytesBuffered.
        /// </summary>
        [DataMember]
        public System.Double[] SentBytesBuffered { get; set; }
        /// <summary>
        /// Gets or sets the SentMessages.
        /// </summary>
        [DataMember]
        public System.Double[] SentMessages { get; set; }
        /// <summary>
        /// Gets or sets the SentTicks.
        /// </summary>
        [DataMember]
        public System.Int64[] SentTicks { get; set; }
        /// <summary>
        /// Gets or sets the ServerName.
        /// </summary>
        [DataMember]
        public string ServerName { get; set; }
        /// <summary>
        /// Gets or sets the TarPittedConnections.
        /// </summary>
        [DataMember]
        public int TarPittedConnections { get; set; }
        /// <summary>
        /// Gets or sets the TotalClients.
        /// </summary>
        [DataMember]
        public System.Int32[] TotalClients { get; set; }
        /// <summary>
        /// Gets or sets the UnknownUser.
        /// </summary>
        [DataMember]
        public int UnknownUser { get; set; }
        /// <summary>
        /// Gets or sets the UserAlreadyExists.
        /// </summary>
        [DataMember]
        public int UserAlreadyExists { get; set; }
        /// <summary>
        /// Gets or sets the UserNameTooLong.
        /// </summary>
        [DataMember]
        public int UserNameTooLong { get; set; }
        /// <summary>
        /// Gets or sets the UtcTime.
        /// </summary>
        [DataMember]
        public System.DateTime UtcTime { get; set; }
        /// <summary>
        /// Gets or sets the AreAllServersStopped.
        /// </summary>
        [DataMember]
        public bool AreAllServersStopped { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// ApplicationExit method.
        /// </summary>
        public void ApplicationExit()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ApplicationStart method.
        /// </summary>
        public void ApplicationStart()
        {
            // Method implementation goes here
        }
        #endregion
    }
}
