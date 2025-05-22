[Serializable]
[DataContract]
namespace NinjaTrader.Core
{
    public partial class ServerOptions : System.ICloneable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AdapterServerPort.
        /// </summary>
        [DataMember]
        public int AdapterServerPort { get; set; }
        /// <summary>
        /// Gets or sets the AdminPort.
        /// </summary>
        [DataMember]
        public int AdminPort { get; set; }
        /// <summary>
        /// Gets or sets the BPDataPort.
        /// </summary>
        [DataMember]
        public int BPDataPort { get; set; }
        /// <summary>
        /// Gets or sets the BPDataPortWebSocket.
        /// </summary>
        [DataMember]
        public int BPDataPortWebSocket { get; set; }
        /// <summary>
        /// Gets or sets the BPDomainName.
        /// </summary>
        [DataMember]
        public string BPDomainName { get; set; }
        /// <summary>
        /// Gets or sets the BPFanOutMilliSeconds.
        /// </summary>
        [DataMember]
        public int BPFanOutMilliSeconds { get; set; }
        /// <summary>
        /// Gets or sets the BPUseNagleForFanningOutData.
        /// </summary>
        [DataMember]
        public bool BPUseNagleForFanningOutData { get; set; }
        /// <summary>
        /// Gets or sets the BPTradingPort.
        /// </summary>
        [DataMember]
        public int BPTradingPort { get; set; }
        /// <summary>
        /// Gets or sets the BPTradingPortWebSocket.
        /// </summary>
        [DataMember]
        public int BPTradingPortWebSocket { get; set; }
        /// <summary>
        /// Gets or sets the DbConnectionString.
        /// </summary>
        [DataMember]
        public string DbConnectionString { get; set; }
        /// <summary>
        /// Gets or sets the DbType.
        /// </summary>
        [DataMember]
        public DbType DbType { get; set; }
        /// <summary>
        /// Gets or sets the DSDomainName.
        /// </summary>
        [DataMember]
        public string DSDomainName { get; set; }
        /// <summary>
        /// Gets or sets the DSPort.
        /// </summary>
        [DataMember]
        public int DSPort { get; set; }
        /// <summary>
        /// Gets or sets the DSPortWebSocket.
        /// </summary>
        [DataMember]
        public int DSPortWebSocket { get; set; }
        /// <summary>
        /// Gets or sets the DSPrimaryLicenseServer.
        /// </summary>
        [DataMember]
        public string DSPrimaryLicenseServer { get; set; }
        /// <summary>
        /// Gets or sets the DSPrimaryLicenseServerPassword.
        /// </summary>
        [DataMember]
        public string DSPrimaryLicenseServerPassword { get; set; }
        /// <summary>
        /// Gets or sets the DSPrimaryLicenseServerUserName.
        /// </summary>
        [DataMember]
        public string DSPrimaryLicenseServerUserName { get; set; }
        /// <summary>
        /// Gets or sets the DSPrimaryLicenseServerUseSsl.
        /// </summary>
        [DataMember]
        public bool DSPrimaryLicenseServerUseSsl { get; set; }
        /// <summary>
        /// Gets or sets the DSRunWebServer.
        /// </summary>
        [DataMember]
        public bool DSRunWebServer { get; set; }
        /// <summary>
        /// Gets or sets the DSSecondaryLicenseServer.
        /// </summary>
        [DataMember]
        public string DSSecondaryLicenseServer { get; set; }
        /// <summary>
        /// Gets or sets the DSSecondaryLicenseServerPassword.
        /// </summary>
        [DataMember]
        public string DSSecondaryLicenseServerPassword { get; set; }
        /// <summary>
        /// Gets or sets the DSSecondaryLicenseServerUserName.
        /// </summary>
        [DataMember]
        public string DSSecondaryLicenseServerUserName { get; set; }
        /// <summary>
        /// Gets or sets the DSSecondaryLicenseServerUseSsl.
        /// </summary>
        [DataMember]
        public bool DSSecondaryLicenseServerUseSsl { get; set; }
        /// <summary>
        /// Gets or sets the DSTokenValidSeconds.
        /// </summary>
        [DataMember]
        public int DSTokenValidSeconds { get; set; }
        /// <summary>
        /// Gets or sets the GWPort.
        /// </summary>
        [DataMember]
        public int GWPort { get; set; }
        /// <summary>
        /// Gets or sets the HDSPort.
        /// </summary>
        [DataMember]
        public int HDSPort { get; set; }
        /// <summary>
        /// Gets or sets the HDSPortWebSocket.
        /// </summary>
        [DataMember]
        public int HDSPortWebSocket { get; set; }
        /// <summary>
        /// Gets or sets the HDSNoSSL.
        /// </summary>
        [DataMember]
        public bool HDSNoSSL { get; set; }
        /// <summary>
        /// Gets or sets the HDSTokenValidSeconds.
        /// </summary>
        [DataMember]
        public int HDSTokenValidSeconds { get; set; }
        /// <summary>
        /// Gets or sets the ISPort.
        /// </summary>
        [DataMember]
        public int ISPort { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the ServerId.
        /// </summary>
        [DataMember]
        public int ServerId { get; set; }
        /// <summary>
        /// Gets or sets the System.
        /// </summary>
        [DataMember]
        public string System { get; set; }
        /// <summary>
        /// Gets or sets the ApplicationType.
        /// </summary>
        [DataMember]
        public ApplicationType ApplicationType { get; set; }
        /// <summary>
        /// Gets or sets the ServerName.
        /// </summary>
        [DataMember]
        public string ServerName { get; set; }
        /// <summary>
        /// Gets or sets the UseNagle.
        /// </summary>
        [DataMember]
        public bool UseNagle { get; set; }
        #endregion
        #region Methods
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
        /// <param name="options">NinjaTrader.Core.ServerOptions</param>
        public void CopyTo(NinjaTrader.Core.ServerOptions options)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
