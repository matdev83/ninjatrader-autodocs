[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class CQGServerOptions : ConnectOptions
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
        /// Gets or sets the FeedIds.
        /// </summary>
        [DataMember]
        public String FeedIds { get; set; }
        /// <summary>
        /// Gets or sets the IsCertificationMode.
        /// </summary>
        [DataMember]
        public Boolean IsCertificationMode { get; set; }
        /// <summary>
        /// Gets or sets the OrderHost.
        /// </summary>
        [DataMember]
        public String OrderHost { get; set; }
        /// <summary>
        /// Gets or sets the OrderPort.
        /// </summary>
        [DataMember]
        public Int32 OrderPort { get; set; }
        /// <summary>
        /// Gets or sets the OrderPassword.
        /// </summary>
        [DataMember]
        public String OrderPassword { get; set; }
        /// <summary>
        /// Gets or sets the OrderUser.
        /// </summary>
        [DataMember]
        public String OrderUser { get; set; }
        /// <summary>
        /// Gets or sets the Password.
        /// </summary>
        [DataMember]
        public String Password { get; set; }
        /// <summary>
        /// Gets or sets the QuotesNetworkInterface.
        /// </summary>
        [DataMember]
        public String QuotesNetworkInterface { get; set; }
        /// <summary>
        /// Gets or sets the SecurityDefinitionHost.
        /// </summary>
        [DataMember]
        public String SecurityDefinitionHost { get; set; }
        /// <summary>
        /// Gets or sets the SecurityDefinitionIsDemo.
        /// </summary>
        [DataMember]
        public Boolean SecurityDefinitionIsDemo { get; set; }
        /// <summary>
        /// Gets or sets the SecurityDefinitionPort.
        /// </summary>
        [DataMember]
        public Int32 SecurityDefinitionPort { get; set; }
        /// <summary>
        /// Gets or sets the SecurityDefinitionPassword.
        /// </summary>
        [DataMember]
        public String SecurityDefinitionPassword { get; set; }
        /// <summary>
        /// Gets or sets the SecurityDefinitionUser.
        /// </summary>
        [DataMember]
        public String SecurityDefinitionUser { get; set; }
        /// <summary>
        /// Gets or sets the SenderSubID.
        /// </summary>
        [DataMember]
        public String SenderSubID { get; set; }
        /// <summary>
        /// Gets or sets the TargetCompID.
        /// </summary>
        [DataMember]
        public String TargetCompID { get; set; }
        /// <summary>
        /// Gets or sets the UseOnBehalfOf.
        /// </summary>
        [DataMember]
        public Boolean UseOnBehalfOf { get; set; }
        /// <summary>
        /// Gets or sets the User.
        /// </summary>
        [DataMember]
        public String User { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
