[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class IBOptions : ConnectOptions
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AutoLogonDelaySeconds.
        /// </summary>
        [DataMember]
        public Int32 AutoLogonDelaySeconds { get; set; }
        /// <summary>
        /// Gets or sets the AssemblyName.
        /// </summary>
        [DataMember]
        public String AssemblyName { get; set; }
        /// <summary>
        /// Gets or sets the BrandName.
        /// </summary>
        [DataMember]
        public String BrandName { get; set; }
        /// <summary>
        /// Gets or sets the CheckForMarketData.
        /// </summary>
        [DataMember]
        public Boolean CheckForMarketData { get; set; }
        /// <summary>
        /// Gets or sets the ClientId.
        /// </summary>
        [DataMember]
        public Int32 ClientId { get; set; }
        /// <summary>
        /// Gets or sets the Disclaimer.
        /// </summary>
        [DataMember]
        public String Disclaimer { get; set; }
        /// <summary>
        /// Gets or sets the Host.
        /// </summary>
        [DataMember]
        public String Host { get; set; }
        /// <summary>
        /// Gets or sets the IsAfterHoursTradingEnabled.
        /// </summary>
        [DataMember]
        public Boolean IsAfterHoursTradingEnabled { get; set; }
        /// <summary>
        /// Gets or sets the IsAutoLogOnEnabled.
        /// </summary>
        [DataMember]
        public Boolean IsAutoLogOnEnabled { get; set; }
        /// <summary>
        /// Gets or sets the IsPopupHandlingEnabled.
        /// </summary>
        [DataMember]
        public Boolean IsPopupHandlingEnabled { get; set; }
        /// <summary>
        /// Gets or sets the LogLevel.
        /// </summary>
        [DataMember]
        public IBLogLevel LogLevel { get; set; }
        /// <summary>
        /// Gets or sets the NewFeatures.
        /// </summary>
        [DataMember]
        public Boolean NewFeatures { get; set; }
        /// <summary>
        /// Gets or sets the PortGateway.
        /// </summary>
        [DataMember]
        public Int32 PortGateway { get; set; }
        /// <summary>
        /// Gets or sets the PortTws.
        /// </summary>
        [DataMember]
        public Int32 PortTws { get; set; }
        /// <summary>
        /// Gets or sets the UseLocalOcoSimulation.
        /// </summary>
        [DataMember]
        public Boolean UseLocalOcoSimulation { get; set; }
        /// <summary>
        /// Gets or sets the UseSsl.
        /// </summary>
        [DataMember]
        public Boolean UseSsl { get; set; }
        /// <summary>
        /// Gets or sets the UIConnectUsing.
        /// </summary>
        [DataMember]
        public IBConnectUsing UIConnectUsing { get; set; }
        /// <summary>
        /// Gets or sets the UseTws.
        /// </summary>
        [DataMember]
        public Boolean UseTws { get; set; }
        /// <summary>
        /// Gets or sets the AutoLogonPath.
        /// </summary>
        [DataMember]
        public String AutoLogonPath { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
