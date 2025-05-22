[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class CQGServerOptions : NinjaTrader.Cbi.ConnectOptions
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
        /// Gets or sets the FeedIds.
        /// </summary>
        [DataMember]
        public string FeedIds { get; set; }
        /// <summary>
        /// Gets or sets the IsCertificationMode.
        /// </summary>
        [DataMember]
        public bool IsCertificationMode { get; set; }
        /// <summary>
        /// Gets or sets the OrderHost.
        /// </summary>
        [DataMember]
        public string OrderHost { get; set; }
        /// <summary>
        /// Gets or sets the OrderPort.
        /// </summary>
        [DataMember]
        public int OrderPort { get; set; }
        /// <summary>
        /// Gets or sets the OrderPassword.
        /// </summary>
        [DataMember]
        public string OrderPassword { get; set; }
        /// <summary>
        /// Gets or sets the OrderUser.
        /// </summary>
        [DataMember]
        public string OrderUser { get; set; }
        /// <summary>
        /// Gets or sets the Password.
        /// </summary>
        [DataMember]
        public string Password { get; set; }
        /// <summary>
        /// Gets or sets the QuotesNetworkInterface.
        /// </summary>
        [DataMember]
        public string QuotesNetworkInterface { get; set; }
        /// <summary>
        /// Gets or sets the SecurityDefinitionHost.
        /// </summary>
        [DataMember]
        public string SecurityDefinitionHost { get; set; }
        /// <summary>
        /// Gets or sets the SecurityDefinitionIsDemo.
        /// </summary>
        [DataMember]
        public bool SecurityDefinitionIsDemo { get; set; }
        /// <summary>
        /// Gets or sets the SecurityDefinitionPort.
        /// </summary>
        [DataMember]
        public int SecurityDefinitionPort { get; set; }
        /// <summary>
        /// Gets or sets the SecurityDefinitionPassword.
        /// </summary>
        [DataMember]
        public string SecurityDefinitionPassword { get; set; }
        /// <summary>
        /// Gets or sets the SecurityDefinitionUser.
        /// </summary>
        [DataMember]
        public string SecurityDefinitionUser { get; set; }
        /// <summary>
        /// Gets or sets the SenderSubID.
        /// </summary>
        [DataMember]
        public string SenderSubID { get; set; }
        /// <summary>
        /// Gets or sets the TargetCompID.
        /// </summary>
        [DataMember]
        public string TargetCompID { get; set; }
        /// <summary>
        /// Gets or sets the UseOnBehalfOf.
        /// </summary>
        [DataMember]
        public bool UseOnBehalfOf { get; set; }
        /// <summary>
        /// Gets or sets the User.
        /// </summary>
        [DataMember]
        public string User { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
