[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class ConnectOptions
    {
        #region Properties
        /// <summary>
        /// Gets or sets the CanManageOrders.
        /// </summary>
        [DataMember]
        public Boolean CanManageOrders { get; set; }
        /// <summary>
        /// Gets or sets the ConnectOnStartup.
        /// </summary>
        [DataMember]
        public Boolean ConnectOnStartup { get; set; }
        /// <summary>
        /// Gets or sets the DisableL2Data.
        /// </summary>
        [DataMember]
        public Boolean DisableL2Data { get; set; }
        /// <summary>
        /// Gets or sets the Disclaimer.
        /// </summary>
        [DataMember]
        public String Disclaimer { get; set; }
        /// <summary>
        /// Gets or sets the IsHdsEnabled.
        /// </summary>
        [DataMember]
        public Boolean IsHdsEnabled { get; set; }
        /// <summary>
        /// Gets or sets the IsDataProviderOnly.
        /// </summary>
        [DataMember]
        public Boolean IsDataProviderOnly { get; set; }
        /// <summary>
        /// Gets or sets the IsPasswordRequiredOnStartup.
        /// </summary>
        [DataMember]
        public Boolean IsPasswordRequiredOnStartup { get; set; }
        /// <summary>
        /// Gets or sets the RunAsProcess.
        /// </summary>
        [DataMember]
        public Boolean RunAsProcess { get; set; }
        /// <summary>
        /// Gets or sets the TypeName.
        /// </summary>
        [DataMember]
        public String TypeName { get; set; }
        /// <summary>
        /// Gets or sets the UseRandomDispatcher.
        /// </summary>
        [DataMember]
        public Boolean UseRandomDispatcher { get; set; }
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
        /// Gets or sets the HasHdsAlwaysEnabled.
        /// </summary>
        [DataMember]
        public Boolean HasHdsAlwaysEnabled { get; set; }
        /// <summary>
        /// Gets or sets the Mode.
        /// </summary>
        [DataMember]
        public Mode Mode { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public String Name { get; set; }
        /// <summary>
        /// Gets or sets the Password.
        /// </summary>
        [DataMember]
        public String Password { get; set; }
        /// <summary>
        /// Gets or sets the Provider.
        /// </summary>
        [DataMember]
        public Provider Provider { get; set; }
        /// <summary>
        /// Gets or sets the User.
        /// </summary>
        [DataMember]
        public String User { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// GetBrandName method.
        /// </summary>
        /// <param name="provider">Provider</param>
        /// <param name="returnEmptyIfNotExists">Boolean</param>
        /// <returns>String</returns>
        public String GetBrandName(Provider provider, Boolean returnEmptyIfNotExists);
        /// <summary>
        /// SerializeConnections method.
        /// </summary>
        /// <param name="connectOptions">IEnumerable`1</param>
        public Void SerializeConnections(IEnumerable<ConnectOptions> connectOptions);
        /// <summary>
        /// ShallowCopy method.
        /// </summary>
        /// <returns>ConnectOptions</returns>
        public ConnectOptions ShallowCopy();
        #endregion
    }
}
