[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class LogEventArgs : System.EventArgs
    {
        #region Properties
        /// <summary>
        /// Gets or sets the IgnoreAsServerOrRms.
        /// </summary>
        [DataMember]
        public bool IgnoreAsServerOrRms { get; set; }
        /// <summary>
        /// Gets or sets the Args.
        /// </summary>
        [DataMember]
        public System.Object[] Args { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the RaiseAccountEvent.
        /// </summary>
        [DataMember]
        public bool RaiseAccountEvent { get; set; }
        /// <summary>
        /// Gets or sets the ResourceType.
        /// </summary>
        [DataMember]
        public System.Type ResourceType { get; set; }
        /// <summary>
        /// Gets or sets the Account.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Account Account { get; set; }
        /// <summary>
        /// Gets or sets the LogCategory.
        /// </summary>
        [DataMember]
        public LogCategories LogCategory { get; set; }
        /// <summary>
        /// Gets or sets the LogLevel.
        /// </summary>
        [DataMember]
        public LogLevel LogLevel { get; set; }
        /// <summary>
        /// Gets or sets the ServerName.
        /// </summary>
        [DataMember]
        public string ServerName { get; set; }
        /// <summary>
        /// Gets or sets the Time.
        /// </summary>
        [DataMember]
        public System.DateTime Time { get; set; }
        /// <summary>
        /// Gets or sets the User.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.User User { get; set; }
        /// <summary>
        /// Gets or sets the Message.
        /// </summary>
        [DataMember]
        public string Message { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// DbAdd method.
        /// </summary>
        public void DbAdd()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DbGet method.
        /// </summary>
        /// <param name="fromUtc">System.DateTime?</param>
        /// <param name="toUtc">System.DateTime?</param>
        /// <param name="account">NinjaTrader.Cbi.Account</param>
        /// <param name="user">NinjaTrader.Cbi.User</param>
        /// <param name="serverName">string</param>
        /// <param name="logLevel">LogLevel?</param>
        /// <param name="logCategory">LogCategories?</param>
        /// <returns>System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.LogEventArgs></returns>
        public System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.LogEventArgs> DbGet(System.DateTime? fromUtc, System.DateTime? toUtc, NinjaTrader.Cbi.Account account, NinjaTrader.Cbi.User user, string serverName, LogLevel? logLevel, LogCategories? logCategory)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetResource method.
        /// </summary>
        /// <param name="resourceType">System.Type</param>
        /// <param name="name">string</param>
        /// <returns>string</returns>
        public string GetResource(System.Type resourceType, string name)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>string</returns>
        public string ToString()
        {
            // Method implementation goes here
        }
        #endregion
    }
}
