[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class ESignalOptions : NinjaTrader.Cbi.ConnectOptions
    {
        #region Properties
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
        /// Gets or sets the IsDataProviderOnly.
        /// </summary>
        [DataMember]
        public bool IsDataProviderOnly { get; set; }
        /// <summary>
        /// Gets or sets the DailyServer.
        /// </summary>
        [DataMember]
        public string DailyServer { get; set; }
        /// <summary>
        /// Gets or sets the DataManager.
        /// </summary>
        [DataMember]
        public string DataManager { get; set; }
        /// <summary>
        /// Gets or sets the EnableDebug.
        /// </summary>
        [DataMember]
        public bool EnableDebug { get; set; }
        /// <summary>
        /// Gets or sets the InternationalTickServer.
        /// </summary>
        [DataMember]
        public string InternationalTickServer { get; set; }
        /// <summary>
        /// Gets or sets the Level2Server.
        /// </summary>
        [DataMember]
        public string Level2Server { get; set; }
        /// <summary>
        /// Gets or sets the NewsServer.
        /// </summary>
        [DataMember]
        public string NewsServer { get; set; }
        /// <summary>
        /// Gets or sets the ProxyHost.
        /// </summary>
        [DataMember]
        public string ProxyHost { get; set; }
        /// <summary>
        /// Gets or sets the ProxyPassword.
        /// </summary>
        [DataMember]
        public string ProxyPassword { get; set; }
        /// <summary>
        /// Gets or sets the ProxyPort.
        /// </summary>
        [DataMember]
        public int ProxyPort { get; set; }
        /// <summary>
        /// Gets or sets the ProxyUser.
        /// </summary>
        [DataMember]
        public string ProxyUser { get; set; }
        /// <summary>
        /// Gets or sets the TickServer.
        /// </summary>
        [DataMember]
        public string TickServer { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
