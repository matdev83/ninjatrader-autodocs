[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class GatewayOptions : ConnectOptions
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
        /// Gets or sets the IsClient.
        /// </summary>
        [DataMember]
        public Boolean IsClient { get; set; }
        /// <summary>
        /// Gets or sets the NT.
        /// </summary>
        [DataMember]
        public NinjaTraderProxy NT { get; set; }
        /// <summary>
        /// Gets or sets the ServerType.
        /// </summary>
        [DataMember]
        public ConnectionType ServerType { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
