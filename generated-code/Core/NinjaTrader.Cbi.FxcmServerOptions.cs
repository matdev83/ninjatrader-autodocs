[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class FxcmServerOptions : NinjaTrader.Cbi.ConnectOptions
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
        /// Gets or sets the FxcmServerConnectionType.
        /// </summary>
        [DataMember]
        public FxcmServerConnectionType FxcmServerConnectionType { get; set; }
        /// <summary>
        /// Gets or sets the Host.
        /// </summary>
        [DataMember]
        public string Host { get; set; }
        /// <summary>
        /// Gets or sets the Port.
        /// </summary>
        [DataMember]
        public int Port { get; set; }
        /// <summary>
        /// Gets or sets the SenderCompID.
        /// </summary>
        [DataMember]
        public string SenderCompID { get; set; }
        /// <summary>
        /// Gets or sets the TargetCompID.
        /// </summary>
        [DataMember]
        public string TargetCompID { get; set; }
        /// <summary>
        /// Gets or sets the TargetSubID.
        /// </summary>
        [DataMember]
        public string TargetSubID { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
