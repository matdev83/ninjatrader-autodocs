[Serializable]
[DataContract]
namespace NinjaTrader.Server
{
    public partial class HdsMaintenance
    {
        #region Properties
        /// <summary>
        /// Gets or sets the BackupCallback.
        /// </summary>
        [DataMember]
        public Action<String> BackupCallback { get; set; }
        /// <summary>
        /// Gets or sets the BackupClearCallback.
        /// </summary>
        [DataMember]
        public Action BackupClearCallback { get; set; }
        /// <summary>
        /// Gets or sets the BackupCompleteCallback.
        /// </summary>
        [DataMember]
        public Action BackupCompleteCallback { get; set; }
        /// <summary>
        /// Gets or sets the BackupFileDoneCallback.
        /// </summary>
        [DataMember]
        public Action<String> BackupFileDoneCallback { get; set; }
        /// <summary>
        /// Gets or sets the BackupStartedCallback.
        /// </summary>
        [DataMember]
        public Action BackupStartedCallback { get; set; }
        /// <summary>
        /// Gets or sets the MaintenanceCallback.
        /// </summary>
        [DataMember]
        public Action<String> MaintenanceCallback { get; set; }
        /// <summary>
        /// Gets or sets the MaintenanceClearCallback.
        /// </summary>
        [DataMember]
        public Action MaintenanceClearCallback { get; set; }
        /// <summary>
        /// Gets or sets the MaintenanceCompleteCallback.
        /// </summary>
        [DataMember]
        public Action MaintenanceCompleteCallback { get; set; }
        /// <summary>
        /// Gets or sets the MaintenanceStartedCallback.
        /// </summary>
        [DataMember]
        public Action MaintenanceStartedCallback { get; set; }
        /// <summary>
        /// Gets or sets the BackupDirectory.
        /// </summary>
        [DataMember]
        public String BackupDirectory { get; set; }
        /// <summary>
        /// Gets or sets the BackupPassword.
        /// </summary>
        [DataMember]
        public String BackupPassword { get; set; }
        /// <summary>
        /// Gets or sets the BackupServer.
        /// </summary>
        [DataMember]
        public String BackupServer { get; set; }
        /// <summary>
        /// Gets or sets the BackupUser.
        /// </summary>
        [DataMember]
        public String BackupUser { get; set; }
        /// <summary>
        /// Gets or sets the DailyDataUnzipped.
        /// </summary>
        [DataMember]
        public Double DailyDataUnzipped { get; set; }
        /// <summary>
        /// Gets or sets the DailyDataZipped.
        /// </summary>
        [DataMember]
        public Double DailyDataZipped { get; set; }
        /// <summary>
        /// Gets or sets the IsInBackup.
        /// </summary>
        [DataMember]
        public Boolean IsInBackup { get; set; }
        /// <summary>
        /// Gets or sets the IsInMaintenance.
        /// </summary>
        [DataMember]
        public Boolean IsInMaintenance { get; set; }
        /// <summary>
        /// Gets or sets the LastTimeBackup.
        /// </summary>
        [DataMember]
        public DateTime LastTimeBackup { get; set; }
        /// <summary>
        /// Gets or sets the LastTimeMaintenance.
        /// </summary>
        [DataMember]
        public DateTime LastTimeMaintenance { get; set; }
        /// <summary>
        /// Gets or sets the MigrationDirectory.
        /// </summary>
        [DataMember]
        public String MigrationDirectory { get; set; }
        /// <summary>
        /// Gets or sets the MinuteDataUnzipped.
        /// </summary>
        [DataMember]
        public Double MinuteDataUnzipped { get; set; }
        /// <summary>
        /// Gets or sets the MinuteDataZipped.
        /// </summary>
        [DataMember]
        public Double MinuteDataZipped { get; set; }
        /// <summary>
        /// Gets or sets the ReplayDataUnzipped.
        /// </summary>
        [DataMember]
        public Double ReplayDataUnzipped { get; set; }
        /// <summary>
        /// Gets or sets the ReplayDataZipped.
        /// </summary>
        [DataMember]
        public Double ReplayDataZipped { get; set; }
        /// <summary>
        /// Gets or sets the TickDataUnzipped.
        /// </summary>
        [DataMember]
        public Double TickDataUnzipped { get; set; }
        /// <summary>
        /// Gets or sets the TickDataZipped.
        /// </summary>
        [DataMember]
        public Double TickDataZipped { get; set; }
        /// <summary>
        /// Gets or sets the DataServers.
        /// </summary>
        [DataMember]
        public Collection<String> DataServers { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// RestoreFromXml method.
        /// </summary>
        public Void RestoreFromXml();
        /// <summary>
        /// RunBackup method.
        /// </summary>
        /// <param name="callback">Action</param>
        public Void RunBackup(Action callback);
        /// <summary>
        /// RunMaintenance method.
        /// </summary>
        /// <param name="callback">Action</param>
        public Void RunMaintenance(Action callback);
        /// <summary>
        /// Start method.
        /// </summary>
        public Void Start();
        /// <summary>
        /// Stop method.
        /// </summary>
        public Void Stop();
        #endregion
    }
}
