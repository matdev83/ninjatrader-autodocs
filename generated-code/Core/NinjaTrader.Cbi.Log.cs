[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class Log
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// AddLicenseManagementLog method.
        /// </summary>
        /// <param name="affected">User</param>
        /// <param name="by">String</param>
        /// <param name="subject">String</param>
        /// <param name="body">String</param>
        /// <param name="isBodyHtml">Boolean</param>
        /// <param name="utcNow">Nullable`1</param>
        public Void AddLicenseManagementLog(User affected, String by, String subject, String body, Boolean isBodyHtml, Nullable<DateTime> utcNow);
        /// <summary>
        /// Assert method.
        /// </summary>
        /// <param name="condition">Boolean</param>
        /// <param name="showAssertDialog">Boolean</param>
        /// <returns>Boolean</returns>
        public Boolean Assert(Boolean condition, Boolean showAssertDialog);
        /// <summary>
        /// Assert method.
        /// </summary>
        /// <param name="condition">Boolean</param>
        /// <param name="message">String</param>
        /// <param name="showAssertDialog">Boolean</param>
        /// <returns>Boolean</returns>
        public Boolean Assert(Boolean condition, String message, Boolean showAssertDialog);
        /// <summary>
        /// Assert method.
        /// </summary>
        /// <param name="condition">Boolean</param>
        /// <param name="message">String</param>
        /// <param name="detailedMessage">String</param>
        /// <param name="showAssertDialog">Boolean</param>
        /// <returns>Boolean</returns>
        public Boolean Assert(Boolean condition, String message, String detailedMessage, Boolean showAssertDialog);
        /// <summary>
        /// CloseWriter method.
        /// </summary>
        public Void CloseWriter();
        /// <summary>
        /// Process method.
        /// </summary>
        /// <param name="resourceType">Type</param>
        /// <param name="name">String</param>
        /// <param name="args">Object[]</param>
        /// <param name="logLevel">LogLevel</param>
        /// <param name="logCategory">LogCategories</param>
        public Void Process(Type resourceType, String name, Object[] args, LogLevel logLevel, LogCategories logCategory);
        /// <summary>
        /// Process method.
        /// </summary>
        /// <param name="resourceType">Type</param>
        /// <param name="name">String</param>
        /// <param name="args">Object[]</param>
        /// <param name="logLevel">LogLevel</param>
        /// <param name="logCategory">LogCategories</param>
        /// <param name="user">User</param>
        public Void Process(Type resourceType, String name, Object[] args, LogLevel logLevel, LogCategories logCategory, User user);
        /// <summary>
        /// Process method.
        /// </summary>
        /// <param name="resourceType">Type</param>
        /// <param name="name">String</param>
        /// <param name="args">Object[]</param>
        /// <param name="logLevel">LogLevel</param>
        /// <param name="logCategory">LogCategories</param>
        /// <param name="account">Account</param>
        public Void Process(Type resourceType, String name, Object[] args, LogLevel logLevel, LogCategories logCategory, Account account);
        /// <summary>
        /// ProcessAsync method.
        /// </summary>
        /// <param name="func">Func`2</param>
        /// <param name="args">Object</param>
        public Void ProcessAsync(Func<Object, LogEventArgs> func, Object args);
        /// <summary>
        /// Shutdown method.
        /// </summary>
        public Void Shutdown();
        #endregion
    }
}
