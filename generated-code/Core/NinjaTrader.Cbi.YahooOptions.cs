[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class YahooOptions : ConnectOptions
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
        /// Gets or sets the UpdateMarketDataSeconds.
        /// </summary>
        [DataMember]
        public Int32 UpdateMarketDataSeconds { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
