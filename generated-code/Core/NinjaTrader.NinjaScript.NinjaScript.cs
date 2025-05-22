[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class NinjaScript : System.ICloneable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the EditGuid.
        /// </summary>
        [DataMember]
        public string EditGuid { get; set; }
        /// <summary>
        /// Gets or sets the IsStopWatchEnabled.
        /// </summary>
        [DataMember]
        public bool IsStopWatchEnabled { get; set; }
        /// <summary>
        /// Gets or sets the IsVisible.
        /// </summary>
        [DataMember]
        public bool IsVisible { get; set; }
        /// <summary>
        /// Gets or sets the PrintTo.
        /// </summary>
        [DataMember]
        public PrintTo PrintTo { get; set; }
        /// <summary>
        /// Gets or sets the StopwatchTimes.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<string, NinjaTrader.NinjaScript.NinjaScript.StopwatchTime> StopwatchTimes { get; set; }
        /// <summary>
        /// Gets or sets the Description.
        /// </summary>
        [DataMember]
        public string Description { get; set; }
        /// <summary>
        /// Gets or sets the DisplayName.
        /// </summary>
        [DataMember]
        public string DisplayName { get; set; }
        /// <summary>
        /// Gets or sets the LogTypeName.
        /// </summary>
        [DataMember]
        public string LogTypeName { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the State.
        /// </summary>
        [DataMember]
        public State State { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// ClearOutputWindow method.
        /// </summary>
        public void ClearOutputWindow()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Decrypt method.
        /// </summary>
        /// <param name="text">string</param>
        /// <returns>string</returns>
        public string Decrypt(string text)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// MemberwiseClone method.
        /// </summary>
        /// <param name="obj">object</param>
        /// <returns>object</returns>
        [Obsolete]
        public object MemberwiseClone(object obj)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// PlaySound method.
        /// </summary>
        /// <param name="file">string</param>
        public void PlaySound(string file)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Print method.
        /// </summary>
        /// <param name="value">object</param>
        public void Print(object value)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SendMail method.
        /// </summary>
        /// <param name="to">string</param>
        /// <param name="subject">string</param>
        /// <param name="text">string</param>
        public void SendMail(string to, string subject, string text)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Share method.
        /// </summary>
        /// <param name="serviceName">string</param>
        /// <param name="message">string</param>
        public void Share(string serviceName, string message)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Share method.
        /// </summary>
        /// <param name="serviceName">string</param>
        /// <param name="message">string</param>
        /// <param name="args">System.Object[]</param>
        public void Share(string serviceName, string message, System.Object[] args)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Share method.
        /// </summary>
        /// <param name="serviceName">string</param>
        /// <param name="message">string</param>
        /// <param name="screenshotPath">string</param>
        public void Share(string serviceName, string message, string screenshotPath)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Share method.
        /// </summary>
        /// <param name="serviceName">string</param>
        /// <param name="message">string</param>
        /// <param name="screenshotPath">string</param>
        /// <param name="args">System.Object[]</param>
        public void Share(string serviceName, string message, string screenshotPath, System.Object[] args)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// StartStopWatch method.
        /// </summary>
        public void StartStopWatch()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// StopStopWatch method.
        /// </summary>
        public void StopStopWatch()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// VerifyVendorLicense method.
        /// </summary>
        /// <returns>bool</returns>
        public bool VerifyVendorLicense()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>object</returns>
        public object Clone()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="ninjaScript">NinjaTrader.NinjaScript.NinjaScript</param>
        public void CopyTo(NinjaTrader.NinjaScript.NinjaScript ninjaScript)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Log method.
        /// </summary>
        /// <param name="message">string</param>
        /// <param name="logLevel">LogLevel</param>
        public void Log(string message, LogLevel logLevel)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// LogAndPrint method.
        /// </summary>
        /// <param name="resourceType">System.Type</param>
        /// <param name="name">string</param>
        /// <param name="args">System.Object[]</param>
        /// <param name="logLevel">LogLevel</param>
        public void LogAndPrint(System.Type resourceType, string name, System.Object[] args, LogLevel logLevel)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SetState method.
        /// </summary>
        /// <param name="state">State</param>
        public void SetState(State state)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
