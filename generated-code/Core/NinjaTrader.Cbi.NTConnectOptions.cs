[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class NTConnectOptions : NinjaTrader.Cbi.ConnectOptions
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
        /// Gets or sets the LogConnectionLoss.
        /// </summary>
        [DataMember]
        public bool LogConnectionLoss { get; set; }
        /// <summary>
        /// Gets or sets the Port.
        /// </summary>
        [DataMember]
        public int Port { get; set; }
        /// <summary>
        /// Gets or sets the Server.
        /// </summary>
        [DataMember]
        public string Server { get; set; }
        /// <summary>
        /// Gets or sets the System.
        /// </summary>
        [DataMember]
        public string System { get; set; }
        /// <summary>
        /// Gets or sets the UseWebSockets.
        /// </summary>
        [DataMember]
        public bool UseWebSockets { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
