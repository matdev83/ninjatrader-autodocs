[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class YahooOptions : NinjaTrader.Cbi.ConnectOptions
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
        /// Gets or sets the UpdateMarketDataSeconds.
        /// </summary>
        [DataMember]
        public int UpdateMarketDataSeconds { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
