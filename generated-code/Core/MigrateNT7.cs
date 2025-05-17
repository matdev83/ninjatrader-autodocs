[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class MigrateNT7
    {
        #region Properties
        /// <summary>
        /// Gets or sets the DBDir.
        /// </summary>
        [DataMember]
        public String DBDir { get; set; }
        /// <summary>
        /// Gets or sets the ProgressCallback.
        /// </summary>
        [DataMember]
        public Action<String> ProgressCallback { get; set; }
        /// <summary>
        /// Gets or sets the UserDataDir.
        /// </summary>
        [DataMember]
        public String UserDataDir { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// MigrateDB method.
        /// </summary>
        public Void MigrateDB();
        /// <summary>
        /// MigrateHistoricalData method.
        /// </summary>
        public Void MigrateHistoricalData();
        /// <summary>
        /// MigrateReplayData method.
        /// </summary>
        public Void MigrateReplayData();
        /// <summary>
        /// MigrateSettings method.
        /// </summary>
        public Void MigrateSettings();
        #endregion
    }
}
