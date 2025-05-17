[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class SchwabOptions : ConnectOptions
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AccessToken.
        /// </summary>
        [DataMember]
        public String AccessToken { get; set; }
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
        /// Gets or sets the Disclaimer.
        /// </summary>
        [DataMember]
        public String Disclaimer { get; set; }
        /// <summary>
        /// Gets or sets the ExpiresIn.
        /// </summary>
        [DataMember]
        public Int32 ExpiresIn { get; set; }
        /// <summary>
        /// Gets or sets the IdToken.
        /// </summary>
        [DataMember]
        public String IdToken { get; set; }
        /// <summary>
        /// Gets or sets the RefreshToken.
        /// </summary>
        [DataMember]
        public String RefreshToken { get; set; }
        /// <summary>
        /// Gets or sets the RefreshTokenDateTime.
        /// </summary>
        [DataMember]
        public DateTime RefreshTokenDateTime { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
