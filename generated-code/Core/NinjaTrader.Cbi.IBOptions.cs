[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class IBOptions : NinjaTrader.Cbi.ConnectOptions
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AutoLogonDelaySeconds.
        /// </summary>
        [DataMember]
        public int AutoLogonDelaySeconds { get; set; }
        /// <summary>
        /// Gets or sets the AssemblyName.
        /// </summary>
        [DataMember]
        public string AssemblyName { get; set; }
        /// <summary>
        /// Gets or sets the BrandName.
        /// </summary>
        [DataMember]
        public string BrandName { get; set; }
        /// <summary>
        /// Gets or sets the CheckForMarketData.
        /// </summary>
        [DataMember]
        public bool CheckForMarketData { get; set; }
        /// <summary>
        /// Gets or sets the ClientId.
        /// </summary>
        [DataMember]
        public int ClientId { get; set; }
        /// <summary>
        /// Gets or sets the Disclaimer.
        /// </summary>
        [DataMember]
        public string Disclaimer { get; set; }
        /// <summary>
        /// Gets or sets the Host.
        /// </summary>
        [DataMember]
        public string Host { get; set; }
        /// <summary>
        /// Gets or sets the IsAfterHoursTradingEnabled.
        /// </summary>
        [DataMember]
        public bool IsAfterHoursTradingEnabled { get; set; }
        /// <summary>
        /// Gets or sets the IsAutoLogOnEnabled.
        /// </summary>
        [DataMember]
        public bool IsAutoLogOnEnabled { get; set; }
        /// <summary>
        /// Gets or sets the IsPopupHandlingEnabled.
        /// </summary>
        [DataMember]
        public bool IsPopupHandlingEnabled { get; set; }
        /// <summary>
        /// Gets or sets the LogLevel.
        /// </summary>
        [DataMember]
        public IBLogLevel LogLevel { get; set; }
        /// <summary>
        /// Gets or sets the NewFeatures.
        /// </summary>
        [DataMember]
        public bool NewFeatures { get; set; }
        /// <summary>
        /// Gets or sets the PortGateway.
        /// </summary>
        [DataMember]
        public int PortGateway { get; set; }
        /// <summary>
        /// Gets or sets the PortTws.
        /// </summary>
        [DataMember]
        public int PortTws { get; set; }
        /// <summary>
        /// Gets or sets the UseLocalOcoSimulation.
        /// </summary>
        [DataMember]
        public bool UseLocalOcoSimulation { get; set; }
        /// <summary>
        /// Gets or sets the UseSsl.
        /// </summary>
        [DataMember]
        public bool UseSsl { get; set; }
        /// <summary>
        /// Gets or sets the UIConnectUsing.
        /// </summary>
        [DataMember]
        public IBConnectUsing UIConnectUsing { get; set; }
        /// <summary>
        /// Gets or sets the UseTws.
        /// </summary>
        [DataMember]
        public bool UseTws { get; set; }
        /// <summary>
        /// Gets or sets the AutoLogonPath.
        /// </summary>
        [DataMember]
        public string AutoLogonPath { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
