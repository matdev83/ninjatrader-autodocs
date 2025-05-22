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
        public string DBDir { get; set; }
        /// <summary>
        /// Gets or sets the ProgressCallback.
        /// </summary>
        [DataMember]
        public System.Action<string> ProgressCallback { get; set; }
        /// <summary>
        /// Gets or sets the UserDataDir.
        /// </summary>
        [DataMember]
        public string UserDataDir { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// MigrateDB method.
        /// </summary>
        public void MigrateDB()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// MigrateHistoricalData method.
        /// </summary>
        public void MigrateHistoricalData()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// MigrateReplayData method.
        /// </summary>
        public void MigrateReplayData()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// MigrateSettings method.
        /// </summary>
        public void MigrateSettings()
        {
            // Method implementation goes here
        }
        #endregion
    }
}
