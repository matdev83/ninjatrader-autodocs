[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class GatewayOptions : NinjaTrader.Cbi.ConnectOptions
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
        /// Gets or sets the IsClient.
        /// </summary>
        [DataMember]
        public bool IsClient { get; set; }
        /// <summary>
        /// Gets or sets the NT.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.NinjaTraderProxy NT { get; set; }
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
