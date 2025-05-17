[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.AddOns
{
    public partial class DebuggingService
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Instance.
        /// </summary>
        [DataMember]
        public DebuggingService Instance { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Initialize method.
        /// </summary>
        public Void Initialize();
        /// <summary>
        /// StopIpcServer method.
        /// </summary>
        public Void StopIpcServer();
        /// <summary>
        /// RegisterInstance method.
        /// </summary>
        /// <param name="instance">Object</param>
        /// <param name="customId">String</param>
        /// <param name="description">String</param>
        /// <returns>String</returns>
        public String RegisterInstance(Object instance, String customId, String description);
        /// <summary>
        /// UnregisterInstance method.
        /// </summary>
        /// <param name="debugId">String</param>
        public Void UnregisterInstance(String debugId);
        /// <summary>
        /// GetRegisteredInstances method.
        /// </summary>
        /// <returns>Dictionary`2</returns>
        public Dictionary<String, String> GetRegisteredInstances();
        /// <summary>
        /// GetInstance method.
        /// </summary>
        /// <param name="debugId">String</param>
        /// <returns>Object</returns>
        public Object GetInstance(String debugId);
        /// <summary>
        /// DumpInstanceState method.
        /// </summary>
        /// <param name="debugId">String</param>
        /// <returns>Dictionary`2</returns>
        public Dictionary<String, Object> DumpInstanceState(String debugId);
        /// <summary>
        /// InvokeMethod method.
        /// </summary>
        /// <param name="debugId">String</param>
        /// <param name="methodName">String</param>
        /// <param name="parameters">Object[]</param>
        /// <returns>Object</returns>
        public Object InvokeMethod(String debugId, String methodName, Object[] parameters);
        /// <summary>
        /// GetAvailableMethods method.
        /// </summary>
        /// <param name="debugId">String</param>
        /// <returns>Dictionary`2</returns>
        public Dictionary<String, String> GetAvailableMethods(String debugId);
        /// <summary>
        /// LogMessage method.
        /// </summary>
        /// <param name="message">String</param>
        public Void LogMessage(String message);
        #endregion
    }
}
