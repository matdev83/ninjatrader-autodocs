[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class NTConnectOptions : ConnectOptions
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
        /// Gets or sets the LogConnectionLoss.
        /// </summary>
        [DataMember]
        public Boolean LogConnectionLoss { get; set; }
        /// <summary>
        /// Gets or sets the Port.
        /// </summary>
        [DataMember]
        public Int32 Port { get; set; }
        /// <summary>
        /// Gets or sets the Server.
        /// </summary>
        [DataMember]
        public String Server { get; set; }
        /// <summary>
        /// Gets or sets the System.
        /// </summary>
        [DataMember]
        public String System { get; set; }
        /// <summary>
        /// Gets or sets the UseWebSockets.
        /// </summary>
        [DataMember]
        public Boolean UseWebSockets { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
