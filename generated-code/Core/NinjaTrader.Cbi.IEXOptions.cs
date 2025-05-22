[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class IEXOptions : NinjaTrader.Cbi.ConnectOptions
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
        /// Gets or sets the IsDataProviderOnly.
        /// </summary>
        [DataMember]
        public bool IsDataProviderOnly { get; set; }
        /// <summary>
        /// Gets or sets the PublicToken.
        /// </summary>
        [DataMember]
        public string PublicToken { get; set; }
        /// <summary>
        /// Gets or sets the ReplayFile.
        /// </summary>
        [DataMember]
        public string ReplayFile { get; set; }
        /// <summary>
        /// Gets or sets the UseFundamentalData.
        /// </summary>
        [DataMember]
        public bool UseFundamentalData { get; set; }
        /// <summary>
        /// Gets or sets the UseNews.
        /// </summary>
        [DataMember]
        public bool UseNews { get; set; }
        /// <summary>
        /// Gets or sets the UseRealtimeData.
        /// </summary>
        [DataMember]
        public bool UseRealtimeData { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
