[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class IEXOptions : ConnectOptions
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
        /// Gets or sets the IsDataProviderOnly.
        /// </summary>
        [DataMember]
        public Boolean IsDataProviderOnly { get; set; }
        /// <summary>
        /// Gets or sets the PublicToken.
        /// </summary>
        [DataMember]
        public String PublicToken { get; set; }
        /// <summary>
        /// Gets or sets the ReplayFile.
        /// </summary>
        [DataMember]
        public String ReplayFile { get; set; }
        /// <summary>
        /// Gets or sets the UseFundamentalData.
        /// </summary>
        [DataMember]
        public Boolean UseFundamentalData { get; set; }
        /// <summary>
        /// Gets or sets the UseNews.
        /// </summary>
        [DataMember]
        public Boolean UseNews { get; set; }
        /// <summary>
        /// Gets or sets the UseRealtimeData.
        /// </summary>
        [DataMember]
        public Boolean UseRealtimeData { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
