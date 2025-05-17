[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript
{
    public partial class NinjaScript : ICloneable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the EditGuid.
        /// </summary>
        [DataMember]
        public String EditGuid { get; set; }
        /// <summary>
        /// Gets or sets the IsStopWatchEnabled.
        /// </summary>
        [DataMember]
        public Boolean IsStopWatchEnabled { get; set; }
        /// <summary>
        /// Gets or sets the IsVisible.
        /// </summary>
        [DataMember]
        public Boolean IsVisible { get; set; }
        /// <summary>
        /// Gets or sets the PrintTo.
        /// </summary>
        [DataMember]
        public PrintTo PrintTo { get; set; }
        /// <summary>
        /// Gets or sets the StopwatchTimes.
        /// </summary>
        [DataMember]
        public Dictionary<String, StopwatchTime> StopwatchTimes { get; set; }
        /// <summary>
        /// Gets or sets the Description.
        /// </summary>
        [DataMember]
        public String Description { get; set; }
        /// <summary>
        /// Gets or sets the DisplayName.
        /// </summary>
        [DataMember]
        public String DisplayName { get; set; }
        /// <summary>
        /// Gets or sets the LogTypeName.
        /// </summary>
        [DataMember]
        public String LogTypeName { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public String Name { get; set; }
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
        public Void ClearOutputWindow();
        /// <summary>
        /// Decrypt method.
        /// </summary>
        /// <param name="text">String</param>
        /// <returns>String</returns>
        public String Decrypt(String text);
        /// <summary>
        /// MemberwiseClone method.
        /// </summary>
        /// <param name="obj">Object</param>
        /// <returns>Object</returns>
        [Obsolete]
        public Object MemberwiseClone(Object obj);
        /// <summary>
        /// PlaySound method.
        /// </summary>
        /// <param name="file">String</param>
        public Void PlaySound(String file);
        /// <summary>
        /// Print method.
        /// </summary>
        /// <param name="value">Object</param>
        public Void Print(Object value);
        /// <summary>
        /// SendMail method.
        /// </summary>
        /// <param name="to">String</param>
        /// <param name="subject">String</param>
        /// <param name="text">String</param>
        public Void SendMail(String to, String subject, String text);
        /// <summary>
        /// Share method.
        /// </summary>
        /// <param name="serviceName">String</param>
        /// <param name="message">String</param>
        public Void Share(String serviceName, String message);
        /// <summary>
        /// Share method.
        /// </summary>
        /// <param name="serviceName">String</param>
        /// <param name="message">String</param>
        /// <param name="args">Object[]</param>
        public Void Share(String serviceName, String message, Object[] args);
        /// <summary>
        /// Share method.
        /// </summary>
        /// <param name="serviceName">String</param>
        /// <param name="message">String</param>
        /// <param name="screenshotPath">String</param>
        public Void Share(String serviceName, String message, String screenshotPath);
        /// <summary>
        /// Share method.
        /// </summary>
        /// <param name="serviceName">String</param>
        /// <param name="message">String</param>
        /// <param name="screenshotPath">String</param>
        /// <param name="args">Object[]</param>
        public Void Share(String serviceName, String message, String screenshotPath, Object[] args);
        /// <summary>
        /// StartStopWatch method.
        /// </summary>
        public Void StartStopWatch();
        /// <summary>
        /// StopStopWatch method.
        /// </summary>
        public Void StopStopWatch();
        /// <summary>
        /// VerifyVendorLicense method.
        /// </summary>
        /// <returns>Boolean</returns>
        public Boolean VerifyVendorLicense();
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>Object</returns>
        public Object Clone();
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="ninjaScript">NinjaScript</param>
        public Void CopyTo(NinjaScript ninjaScript);
        /// <summary>
        /// Log method.
        /// </summary>
        /// <param name="message">String</param>
        /// <param name="logLevel">LogLevel</param>
        public Void Log(String message, LogLevel logLevel);
        /// <summary>
        /// LogAndPrint method.
        /// </summary>
        /// <param name="resourceType">Type</param>
        /// <param name="name">String</param>
        /// <param name="args">Object[]</param>
        /// <param name="logLevel">LogLevel</param>
        public Void LogAndPrint(Type resourceType, String name, Object[] args, LogLevel logLevel);
        /// <summary>
        /// SetState method.
        /// </summary>
        /// <param name="state">State</param>
        public Void SetState(State state);
        #endregion
    }
}
