[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class TradovateOptions : NinjaTrader.Cbi.ConnectOptions
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AccessToken.
        /// </summary>
        [DataMember]
        public string AccessToken { get; set; }
        /// <summary>
        /// Gets or sets the AuthCode.
        /// </summary>
        [DataMember]
        public string AuthCode { get; set; }
        /// <summary>
        /// Gets or sets the AccountType.
        /// </summary>
        [DataMember]
        public TradovateAccountType AccountType { get; set; }
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
        /// Gets or sets the MdAccessToken.
        /// </summary>
        [DataMember]
        public string MdAccessToken { get; set; }
        /// <summary>
        /// Gets or sets the SocialProvider.
        /// </summary>
        [DataMember]
        public string SocialProvider { get; set; }
        /// <summary>
        /// Gets or sets the UseDevEnvironment.
        /// </summary>
        [DataMember]
        public bool UseDevEnvironment { get; set; }
        /// <summary>
        /// Gets or sets the UseLocalOcoSimulation.
        /// </summary>
        [DataMember]
        public bool UseLocalOcoSimulation { get; set; }
        /// <summary>
        /// Gets or sets the UseNativeHistoricalData.
        /// </summary>
        [DataMember]
        public bool UseNativeHistoricalData { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
