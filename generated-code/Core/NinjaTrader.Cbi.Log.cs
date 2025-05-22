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
        /// <param name="affected">NinjaTrader.Cbi.User</param>
        /// <param name="by">string</param>
        /// <param name="subject">string</param>
        /// <param name="body">string</param>
        /// <param name="isBodyHtml">bool</param>
        /// <param name="utcNow">System.DateTime?</param>
        public void AddLicenseManagementLog(NinjaTrader.Cbi.User affected, string by, string subject, string body, bool isBodyHtml, System.DateTime? utcNow)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Assert method.
        /// </summary>
        /// <param name="condition">bool</param>
        /// <param name="showAssertDialog">bool</param>
        /// <returns>bool</returns>
        public bool Assert(bool condition, bool showAssertDialog)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Assert method.
        /// </summary>
        /// <param name="condition">bool</param>
        /// <param name="message">string</param>
        /// <param name="showAssertDialog">bool</param>
        /// <returns>bool</returns>
        public bool Assert(bool condition, string message, bool showAssertDialog)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Assert method.
        /// </summary>
        /// <param name="condition">bool</param>
        /// <param name="message">string</param>
        /// <param name="detailedMessage">string</param>
        /// <param name="showAssertDialog">bool</param>
        /// <returns>bool</returns>
        public bool Assert(bool condition, string message, string detailedMessage, bool showAssertDialog)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// CloseWriter method.
        /// </summary>
        public void CloseWriter()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Process method.
        /// </summary>
        /// <param name="resourceType">System.Type</param>
        /// <param name="name">string</param>
        /// <param name="args">System.Object[]</param>
        /// <param name="logLevel">LogLevel</param>
        /// <param name="logCategory">LogCategories</param>
        public void Process(System.Type resourceType, string name, System.Object[] args, LogLevel logLevel, LogCategories logCategory)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Process method.
        /// </summary>
        /// <param name="resourceType">System.Type</param>
        /// <param name="name">string</param>
        /// <param name="args">System.Object[]</param>
        /// <param name="logLevel">LogLevel</param>
        /// <param name="logCategory">LogCategories</param>
        /// <param name="user">NinjaTrader.Cbi.User</param>
        public void Process(System.Type resourceType, string name, System.Object[] args, LogLevel logLevel, LogCategories logCategory, NinjaTrader.Cbi.User user)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Process method.
        /// </summary>
        /// <param name="resourceType">System.Type</param>
        /// <param name="name">string</param>
        /// <param name="args">System.Object[]</param>
        /// <param name="logLevel">LogLevel</param>
        /// <param name="logCategory">LogCategories</param>
        /// <param name="account">NinjaTrader.Cbi.Account</param>
        public void Process(System.Type resourceType, string name, System.Object[] args, LogLevel logLevel, LogCategories logCategory, NinjaTrader.Cbi.Account account)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ProcessAsync method.
        /// </summary>
        /// <param name="func">System.Func<object, NinjaTrader.Cbi.LogEventArgs></param>
        /// <param name="args">object</param>
        public void ProcessAsync(System.Func<object, NinjaTrader.Cbi.LogEventArgs> func, object args)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Shutdown method.
        /// </summary>
        public void Shutdown()
        {
            // Method implementation goes here
        }
        #endregion
    }
}
