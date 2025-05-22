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
        public bool CanManageOrders { get; set; }
        /// <summary>
        /// Gets or sets the ConnectOnStartup.
        /// </summary>
        [DataMember]
        public bool ConnectOnStartup { get; set; }
        /// <summary>
        /// Gets or sets the DisableL2Data.
        /// </summary>
        [DataMember]
        public bool DisableL2Data { get; set; }
        /// <summary>
        /// Gets or sets the Disclaimer.
        /// </summary>
        [DataMember]
        public string Disclaimer { get; set; }
        /// <summary>
        /// Gets or sets the IsHdsEnabled.
        /// </summary>
        [DataMember]
        public bool IsHdsEnabled { get; set; }
        /// <summary>
        /// Gets or sets the IsDataProviderOnly.
        /// </summary>
        [DataMember]
        public bool IsDataProviderOnly { get; set; }
        /// <summary>
        /// Gets or sets the IsPasswordRequiredOnStartup.
        /// </summary>
        [DataMember]
        public bool IsPasswordRequiredOnStartup { get; set; }
        /// <summary>
        /// Gets or sets the RunAsProcess.
        /// </summary>
        [DataMember]
        public bool RunAsProcess { get; set; }
        /// <summary>
        /// Gets or sets the TypeName.
        /// </summary>
        [DataMember]
        public string TypeName { get; set; }
        /// <summary>
        /// Gets or sets the UseRandomDispatcher.
        /// </summary>
        [DataMember]
        public bool UseRandomDispatcher { get; set; }
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
        /// Gets or sets the HasHdsAlwaysEnabled.
        /// </summary>
        [DataMember]
        public bool HasHdsAlwaysEnabled { get; set; }
        /// <summary>
        /// Gets or sets the Mode.
        /// </summary>
        [DataMember]
        public Mode Mode { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the Password.
        /// </summary>
        [DataMember]
        public string Password { get; set; }
        /// <summary>
        /// Gets or sets the Provider.
        /// </summary>
        [DataMember]
        public Provider Provider { get; set; }
        /// <summary>
        /// Gets or sets the User.
        /// </summary>
        [DataMember]
        public string User { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// GetBrandName method.
        /// </summary>
        /// <param name="provider">Provider</param>
        /// <param name="returnEmptyIfNotExists">bool</param>
        /// <returns>string</returns>
        public string GetBrandName(Provider provider, bool returnEmptyIfNotExists)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SerializeConnections method.
        /// </summary>
        /// <param name="connectOptions">System.Collections.Generic.IEnumerable<NinjaTrader.Cbi.ConnectOptions></param>
        public void SerializeConnections(System.Collections.Generic.IEnumerable<NinjaTrader.Cbi.ConnectOptions> connectOptions)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ShallowCopy method.
        /// </summary>
        /// <returns>NinjaTrader.Cbi.ConnectOptions</returns>
        public NinjaTrader.Cbi.ConnectOptions ShallowCopy()
        {
            // Method implementation goes here
        }
        #endregion
    }
}
