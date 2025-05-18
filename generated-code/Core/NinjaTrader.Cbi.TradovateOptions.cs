[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class TradovateOptions : ConnectOptions
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AccessToken.
        /// </summary>
        [DataMember]
        public String AccessToken { get; set; }
        /// <summary>
        /// Gets or sets the AuthCode.
        /// </summary>
        [DataMember]
        public String AuthCode { get; set; }
        /// <summary>
        /// Gets or sets the AccountType.
        /// </summary>
        [DataMember]
        public TradovateAccountType AccountType { get; set; }
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
        /// Gets or sets the MdAccessToken.
        /// </summary>
        [DataMember]
        public String MdAccessToken { get; set; }
        /// <summary>
        /// Gets or sets the SocialProvider.
        /// </summary>
        [DataMember]
        public String SocialProvider { get; set; }
        /// <summary>
        /// Gets or sets the UseDevEnvironment.
        /// </summary>
        [DataMember]
        public Boolean UseDevEnvironment { get; set; }
        /// <summary>
        /// Gets or sets the UseLocalOcoSimulation.
        /// </summary>
        [DataMember]
        public Boolean UseLocalOcoSimulation { get; set; }
        /// <summary>
        /// Gets or sets the UseNativeHistoricalData.
        /// </summary>
        [DataMember]
        public Boolean UseNativeHistoricalData { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
