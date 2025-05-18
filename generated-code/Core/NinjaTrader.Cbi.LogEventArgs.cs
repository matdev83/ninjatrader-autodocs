[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class LogEventArgs : EventArgs
    {
        #region Properties
        /// <summary>
        /// Gets or sets the IgnoreAsServerOrRms.
        /// </summary>
        [DataMember]
        public Boolean IgnoreAsServerOrRms { get; set; }
        /// <summary>
        /// Gets or sets the Args.
        /// </summary>
        [DataMember]
        public Object[] Args { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public String Name { get; set; }
        /// <summary>
        /// Gets or sets the RaiseAccountEvent.
        /// </summary>
        [DataMember]
        public Boolean RaiseAccountEvent { get; set; }
        /// <summary>
        /// Gets or sets the ResourceType.
        /// </summary>
        [DataMember]
        public Type ResourceType { get; set; }
        /// <summary>
        /// Gets or sets the Account.
        /// </summary>
        [DataMember]
        public Account Account { get; set; }
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
        public String ServerName { get; set; }
        /// <summary>
        /// Gets or sets the Time.
        /// </summary>
        [DataMember]
        public DateTime Time { get; set; }
        /// <summary>
        /// Gets or sets the User.
        /// </summary>
        [DataMember]
        public User User { get; set; }
        /// <summary>
        /// Gets or sets the Message.
        /// </summary>
        [DataMember]
        public String Message { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// DbAdd method.
        /// </summary>
        public Void DbAdd();
        /// <summary>
        /// DbGet method.
        /// </summary>
        /// <param name="fromUtc">Nullable`1</param>
        /// <param name="toUtc">Nullable`1</param>
        /// <param name="account">Account</param>
        /// <param name="user">User</param>
        /// <param name="serverName">String</param>
        /// <param name="logLevel">Nullable`1</param>
        /// <param name="logCategory">Nullable`1</param>
        /// <returns>Collection`1</returns>
        public Collection<LogEventArgs> DbGet(Nullable<DateTime> fromUtc, Nullable<DateTime> toUtc, Account account, User user, String serverName, Nullable<LogLevel> logLevel, Nullable<LogCategories> logCategory);
        /// <summary>
        /// GetResource method.
        /// </summary>
        /// <param name="resourceType">Type</param>
        /// <param name="name">String</param>
        /// <returns>String</returns>
        public String GetResource(Type resourceType, String name);
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>String</returns>
        public String ToString();
        #endregion
    }
}
