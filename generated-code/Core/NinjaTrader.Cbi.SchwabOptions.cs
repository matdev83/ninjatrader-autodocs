[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class SchwabOptions : NinjaTrader.Cbi.ConnectOptions
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AccessToken.
        /// </summary>
        [DataMember]
        public string AccessToken { get; set; }
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
        /// Gets or sets the Disclaimer.
        /// </summary>
        [DataMember]
        public string Disclaimer { get; set; }
        /// <summary>
        /// Gets or sets the ExpiresIn.
        /// </summary>
        [DataMember]
        public int ExpiresIn { get; set; }
        /// <summary>
        /// Gets or sets the IdToken.
        /// </summary>
        [DataMember]
        public string IdToken { get; set; }
        /// <summary>
        /// Gets or sets the RefreshToken.
        /// </summary>
        [DataMember]
        public string RefreshToken { get; set; }
        /// <summary>
        /// Gets or sets the RefreshTokenDateTime.
        /// </summary>
        [DataMember]
        public System.DateTime RefreshTokenDateTime { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
