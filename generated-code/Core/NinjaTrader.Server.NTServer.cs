[Serializable]
[DataContract]
namespace NinjaTrader.Server
{
    public partial class NTServer : System.IDisposable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Clients.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<string, NinjaTrader.Cbi.NinjaTraderProxy> Clients { get; set; }
        /// <summary>
        /// Gets or sets the Port.
        /// </summary>
        [DataMember]
        public int Port { get; set; }
        /// <summary>
        /// Gets or sets the PortWebSocket.
        /// </summary>
        [DataMember]
        public int PortWebSocket { get; set; }
        /// <summary>
        /// Gets or sets the ServerType.
        /// </summary>
        [DataMember]
        public ConnectionType ServerType { get; set; }
        /// <summary>
        /// Gets or sets the Status.
        /// </summary>
        [DataMember]
        public ConnectionStatus Status { get; set; }
        /// <summary>
        /// Gets or sets the StatusAdmin.
        /// </summary>
        [DataMember]
        public ConnectionStatus StatusAdmin { get; set; }
        /// <summary>
        /// Gets or sets the StatusGW.
        /// </summary>
        [DataMember]
        public ConnectionStatus StatusGW { get; set; }
        /// <summary>
        /// Gets or sets the UseSsl.
        /// </summary>
        [DataMember]
        public bool UseSsl { get; set; }
        /// <summary>
        /// Gets or sets the Impl.
        /// </summary>
        [DataMember]
        public NinjaTrader.Server.IServer Impl { get; set; }
        /// <summary>
        /// Gets or sets the IsRunning.
        /// </summary>
        [DataMember]
        public bool IsRunning { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Dispose method.
        /// </summary>
        public void Dispose()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetCurrent method.
        /// </summary>
        /// <param name="connectionType">ConnectionType</param>
        /// <returns>NinjaTrader.Server.NTServer</returns>
        public NinjaTrader.Server.NTServer GetCurrent(ConnectionType connectionType)
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
        /// StartNow method.
        /// </summary>
        public void StartNow()
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
        /// <summary>
        /// UpdateStatus method.
        /// </summary>
        public void UpdateStatus()
        {
            // Method implementation goes here
        }
        #endregion
    }
}
