[Serializable]
[DataContract]
namespace NinjaTrader.Server
{
    public partial class NTServer : IDisposable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Clients.
        /// </summary>
        [DataMember]
        public Dictionary<String, NinjaTraderProxy> Clients { get; set; }
        /// <summary>
        /// Gets or sets the Port.
        /// </summary>
        [DataMember]
        public Int32 Port { get; set; }
        /// <summary>
        /// Gets or sets the PortWebSocket.
        /// </summary>
        [DataMember]
        public Int32 PortWebSocket { get; set; }
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
        public Boolean UseSsl { get; set; }
        /// <summary>
        /// Gets or sets the Impl.
        /// </summary>
        [DataMember]
        public IServer Impl { get; set; }
        /// <summary>
        /// Gets or sets the IsRunning.
        /// </summary>
        [DataMember]
        public Boolean IsRunning { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Dispose method.
        /// </summary>
        public Void Dispose();
        /// <summary>
        /// GetCurrent method.
        /// </summary>
        /// <param name="connectionType">ConnectionType</param>
        /// <returns>NTServer</returns>
        public NTServer GetCurrent(ConnectionType connectionType);
        /// <summary>
        /// Start method.
        /// </summary>
        public Void Start();
        /// <summary>
        /// StartNow method.
        /// </summary>
        public Void StartNow();
        /// <summary>
        /// Stop method.
        /// </summary>
        public Void Stop();
        /// <summary>
        /// UpdateStatus method.
        /// </summary>
        public Void UpdateStatus();
        #endregion
    }
}
