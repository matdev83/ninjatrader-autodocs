[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class CTraderOptions : NinjaTrader.Cbi.ConnectOptions
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
        /// Gets or sets the Brokers.
        /// </summary>
        [DataMember]
        public System.String[] Brokers { get; set; }
        /// <summary>
        /// Gets or sets the Disclaimer.
        /// </summary>
        [DataMember]
        public string Disclaimer { get; set; }
        /// <summary>
        /// Gets or sets the RefreshToken.
        /// </summary>
        [DataMember]
        public string RefreshToken { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
