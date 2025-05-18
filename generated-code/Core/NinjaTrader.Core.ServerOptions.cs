[Serializable]
[DataContract]
namespace NinjaTrader.Core
{
    public partial class ServerOptions : ICloneable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AdapterServerPort.
        /// </summary>
        [DataMember]
        public Int32 AdapterServerPort { get; set; }
        /// <summary>
        /// Gets or sets the AdminPort.
        /// </summary>
        [DataMember]
        public Int32 AdminPort { get; set; }
        /// <summary>
        /// Gets or sets the BPDataPort.
        /// </summary>
        [DataMember]
        public Int32 BPDataPort { get; set; }
        /// <summary>
        /// Gets or sets the BPDataPortWebSocket.
        /// </summary>
        [DataMember]
        public Int32 BPDataPortWebSocket { get; set; }
        /// <summary>
        /// Gets or sets the BPDomainName.
        /// </summary>
        [DataMember]
        public String BPDomainName { get; set; }
        /// <summary>
        /// Gets or sets the BPFanOutMilliSeconds.
        /// </summary>
        [DataMember]
        public Int32 BPFanOutMilliSeconds { get; set; }
        /// <summary>
        /// Gets or sets the BPUseNagleForFanningOutData.
        /// </summary>
        [DataMember]
        public Boolean BPUseNagleForFanningOutData { get; set; }
        /// <summary>
        /// Gets or sets the BPTradingPort.
        /// </summary>
        [DataMember]
        public Int32 BPTradingPort { get; set; }
        /// <summary>
        /// Gets or sets the BPTradingPortWebSocket.
        /// </summary>
        [DataMember]
        public Int32 BPTradingPortWebSocket { get; set; }
        /// <summary>
        /// Gets or sets the DbConnectionString.
        /// </summary>
        [DataMember]
        public String DbConnectionString { get; set; }
        /// <summary>
        /// Gets or sets the DbType.
        /// </summary>
        [DataMember]
        public DbType DbType { get; set; }
        /// <summary>
        /// Gets or sets the DSDomainName.
        /// </summary>
        [DataMember]
        public String DSDomainName { get; set; }
        /// <summary>
        /// Gets or sets the DSPort.
        /// </summary>
        [DataMember]
        public Int32 DSPort { get; set; }
        /// <summary>
        /// Gets or sets the DSPortWebSocket.
        /// </summary>
        [DataMember]
        public Int32 DSPortWebSocket { get; set; }
        /// <summary>
        /// Gets or sets the DSPrimaryLicenseServer.
        /// </summary>
        [DataMember]
        public String DSPrimaryLicenseServer { get; set; }
        /// <summary>
        /// Gets or sets the DSPrimaryLicenseServerPassword.
        /// </summary>
        [DataMember]
        public String DSPrimaryLicenseServerPassword { get; set; }
        /// <summary>
        /// Gets or sets the DSPrimaryLicenseServerUserName.
        /// </summary>
        [DataMember]
        public String DSPrimaryLicenseServerUserName { get; set; }
        /// <summary>
        /// Gets or sets the DSPrimaryLicenseServerUseSsl.
        /// </summary>
        [DataMember]
        public Boolean DSPrimaryLicenseServerUseSsl { get; set; }
        /// <summary>
        /// Gets or sets the DSRunWebServer.
        /// </summary>
        [DataMember]
        public Boolean DSRunWebServer { get; set; }
        /// <summary>
        /// Gets or sets the DSSecondaryLicenseServer.
        /// </summary>
        [DataMember]
        public String DSSecondaryLicenseServer { get; set; }
        /// <summary>
        /// Gets or sets the DSSecondaryLicenseServerPassword.
        /// </summary>
        [DataMember]
        public String DSSecondaryLicenseServerPassword { get; set; }
        /// <summary>
        /// Gets or sets the DSSecondaryLicenseServerUserName.
        /// </summary>
        [DataMember]
        public String DSSecondaryLicenseServerUserName { get; set; }
        /// <summary>
        /// Gets or sets the DSSecondaryLicenseServerUseSsl.
        /// </summary>
        [DataMember]
        public Boolean DSSecondaryLicenseServerUseSsl { get; set; }
        /// <summary>
        /// Gets or sets the DSTokenValidSeconds.
        /// </summary>
        [DataMember]
        public Int32 DSTokenValidSeconds { get; set; }
        /// <summary>
        /// Gets or sets the GWPort.
        /// </summary>
        [DataMember]
        public Int32 GWPort { get; set; }
        /// <summary>
        /// Gets or sets the HDSPort.
        /// </summary>
        [DataMember]
        public Int32 HDSPort { get; set; }
        /// <summary>
        /// Gets or sets the HDSPortWebSocket.
        /// </summary>
        [DataMember]
        public Int32 HDSPortWebSocket { get; set; }
        /// <summary>
        /// Gets or sets the HDSNoSSL.
        /// </summary>
        [DataMember]
        public Boolean HDSNoSSL { get; set; }
        /// <summary>
        /// Gets or sets the HDSTokenValidSeconds.
        /// </summary>
        [DataMember]
        public Int32 HDSTokenValidSeconds { get; set; }
        /// <summary>
        /// Gets or sets the ISPort.
        /// </summary>
        [DataMember]
        public Int32 ISPort { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public String Name { get; set; }
        /// <summary>
        /// Gets or sets the ServerId.
        /// </summary>
        [DataMember]
        public Int32 ServerId { get; set; }
        /// <summary>
        /// Gets or sets the System.
        /// </summary>
        [DataMember]
        public String System { get; set; }
        /// <summary>
        /// Gets or sets the ApplicationType.
        /// </summary>
        [DataMember]
        public ApplicationType ApplicationType { get; set; }
        /// <summary>
        /// Gets or sets the ServerName.
        /// </summary>
        [DataMember]
        public String ServerName { get; set; }
        /// <summary>
        /// Gets or sets the UseNagle.
        /// </summary>
        [DataMember]
        public Boolean UseNagle { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>Object</returns>
        public Object Clone();
        /// <summary>
        /// CopyTo method.
        /// </summary>
        /// <param name="options">ServerOptions</param>
        public Void CopyTo(ServerOptions options);
        #endregion
    }
}
