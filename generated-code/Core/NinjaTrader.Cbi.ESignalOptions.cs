[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class ESignalOptions : ConnectOptions
    {
        #region Properties
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
        /// Gets or sets the IsDataProviderOnly.
        /// </summary>
        [DataMember]
        public Boolean IsDataProviderOnly { get; set; }
        /// <summary>
        /// Gets or sets the DailyServer.
        /// </summary>
        [DataMember]
        public String DailyServer { get; set; }
        /// <summary>
        /// Gets or sets the DataManager.
        /// </summary>
        [DataMember]
        public String DataManager { get; set; }
        /// <summary>
        /// Gets or sets the EnableDebug.
        /// </summary>
        [DataMember]
        public Boolean EnableDebug { get; set; }
        /// <summary>
        /// Gets or sets the InternationalTickServer.
        /// </summary>
        [DataMember]
        public String InternationalTickServer { get; set; }
        /// <summary>
        /// Gets or sets the Level2Server.
        /// </summary>
        [DataMember]
        public String Level2Server { get; set; }
        /// <summary>
        /// Gets or sets the NewsServer.
        /// </summary>
        [DataMember]
        public String NewsServer { get; set; }
        /// <summary>
        /// Gets or sets the ProxyHost.
        /// </summary>
        [DataMember]
        public String ProxyHost { get; set; }
        /// <summary>
        /// Gets or sets the ProxyPassword.
        /// </summary>
        [DataMember]
        public String ProxyPassword { get; set; }
        /// <summary>
        /// Gets or sets the ProxyPort.
        /// </summary>
        [DataMember]
        public Int32 ProxyPort { get; set; }
        /// <summary>
        /// Gets or sets the ProxyUser.
        /// </summary>
        [DataMember]
        public String ProxyUser { get; set; }
        /// <summary>
        /// Gets or sets the TickServer.
        /// </summary>
        [DataMember]
        public String TickServer { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
