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
        public System.Action<string> BackupCallback { get; set; }
        /// <summary>
        /// Gets or sets the BackupClearCallback.
        /// </summary>
        [DataMember]
        public System.Action BackupClearCallback { get; set; }
        /// <summary>
        /// Gets or sets the BackupCompleteCallback.
        /// </summary>
        [DataMember]
        public System.Action BackupCompleteCallback { get; set; }
        /// <summary>
        /// Gets or sets the BackupFileDoneCallback.
        /// </summary>
        [DataMember]
        public System.Action<string> BackupFileDoneCallback { get; set; }
        /// <summary>
        /// Gets or sets the BackupStartedCallback.
        /// </summary>
        [DataMember]
        public System.Action BackupStartedCallback { get; set; }
        /// <summary>
        /// Gets or sets the MaintenanceCallback.
        /// </summary>
        [DataMember]
        public System.Action<string> MaintenanceCallback { get; set; }
        /// <summary>
        /// Gets or sets the MaintenanceClearCallback.
        /// </summary>
        [DataMember]
        public System.Action MaintenanceClearCallback { get; set; }
        /// <summary>
        /// Gets or sets the MaintenanceCompleteCallback.
        /// </summary>
        [DataMember]
        public System.Action MaintenanceCompleteCallback { get; set; }
        /// <summary>
        /// Gets or sets the MaintenanceStartedCallback.
        /// </summary>
        [DataMember]
        public System.Action MaintenanceStartedCallback { get; set; }
        /// <summary>
        /// Gets or sets the BackupDirectory.
        /// </summary>
        [DataMember]
        public string BackupDirectory { get; set; }
        /// <summary>
        /// Gets or sets the BackupPassword.
        /// </summary>
        [DataMember]
        public string BackupPassword { get; set; }
        /// <summary>
        /// Gets or sets the BackupServer.
        /// </summary>
        [DataMember]
        public string BackupServer { get; set; }
        /// <summary>
        /// Gets or sets the BackupUser.
        /// </summary>
        [DataMember]
        public string BackupUser { get; set; }
        /// <summary>
        /// Gets or sets the DailyDataUnzipped.
        /// </summary>
        [DataMember]
        public double DailyDataUnzipped { get; set; }
        /// <summary>
        /// Gets or sets the DailyDataZipped.
        /// </summary>
        [DataMember]
        public double DailyDataZipped { get; set; }
        /// <summary>
        /// Gets or sets the IsInBackup.
        /// </summary>
        [DataMember]
        public bool IsInBackup { get; set; }
        /// <summary>
        /// Gets or sets the IsInMaintenance.
        /// </summary>
        [DataMember]
        public bool IsInMaintenance { get; set; }
        /// <summary>
        /// Gets or sets the LastTimeBackup.
        /// </summary>
        [DataMember]
        public System.DateTime LastTimeBackup { get; set; }
        /// <summary>
        /// Gets or sets the LastTimeMaintenance.
        /// </summary>
        [DataMember]
        public System.DateTime LastTimeMaintenance { get; set; }
        /// <summary>
        /// Gets or sets the MigrationDirectory.
        /// </summary>
        [DataMember]
        public string MigrationDirectory { get; set; }
        /// <summary>
        /// Gets or sets the MinuteDataUnzipped.
        /// </summary>
        [DataMember]
        public double MinuteDataUnzipped { get; set; }
        /// <summary>
        /// Gets or sets the MinuteDataZipped.
        /// </summary>
        [DataMember]
        public double MinuteDataZipped { get; set; }
        /// <summary>
        /// Gets or sets the ReplayDataUnzipped.
        /// </summary>
        [DataMember]
        public double ReplayDataUnzipped { get; set; }
        /// <summary>
        /// Gets or sets the ReplayDataZipped.
        /// </summary>
        [DataMember]
        public double ReplayDataZipped { get; set; }
        /// <summary>
        /// Gets or sets the TickDataUnzipped.
        /// </summary>
        [DataMember]
        public double TickDataUnzipped { get; set; }
        /// <summary>
        /// Gets or sets the TickDataZipped.
        /// </summary>
        [DataMember]
        public double TickDataZipped { get; set; }
        /// <summary>
        /// Gets or sets the DataServers.
        /// </summary>
        [DataMember]
        public System.Collections.ObjectModel.Collection<string> DataServers { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// RestoreFromXml method.
        /// </summary>
        public void RestoreFromXml()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// RunBackup method.
        /// </summary>
        /// <param name="callback">System.Action</param>
        public void RunBackup(System.Action callback)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// RunMaintenance method.
        /// </summary>
        /// <param name="callback">System.Action</param>
        public void RunMaintenance(System.Action callback)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Start method.
        /// </summary>
        public void Start()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Stop method.
        /// </summary>
        public void Stop()
        {
            // Method implementation goes here
        }
        #endregion
    }
}
