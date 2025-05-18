[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class FxcmServerOptions : ConnectOptions
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
        /// Gets or sets the FxcmServerConnectionType.
        /// </summary>
        [DataMember]
        public FxcmServerConnectionType FxcmServerConnectionType { get; set; }
        /// <summary>
        /// Gets or sets the Host.
        /// </summary>
        [DataMember]
        public String Host { get; set; }
        /// <summary>
        /// Gets or sets the Port.
        /// </summary>
        [DataMember]
        public Int32 Port { get; set; }
        /// <summary>
        /// Gets or sets the SenderCompID.
        /// </summary>
        [DataMember]
        public String SenderCompID { get; set; }
        /// <summary>
        /// Gets or sets the TargetCompID.
        /// </summary>
        [DataMember]
        public String TargetCompID { get; set; }
        /// <summary>
        /// Gets or sets the TargetSubID.
        /// </summary>
        [DataMember]
        public String TargetSubID { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
