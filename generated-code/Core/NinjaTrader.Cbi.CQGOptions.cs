[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class CQGOptions : NinjaTrader.Cbi.ConnectOptions, NinjaTrader.Cbi.ICQGOptions
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
        /// Gets or sets the Disclaimer.
        /// </summary>
        [DataMember]
        public string Disclaimer { get; set; }
        /// <summary>
        /// Gets or sets the Fcms.
        /// </summary>
        [DataMember]
        public System.String[] Fcms { get; set; }
        /// <summary>
        /// Gets or sets the IncludeFx.
        /// </summary>
        [DataMember]
        public bool IncludeFx { get; set; }
        /// <summary>
        /// Gets or sets the UseHistoricalTickData.
        /// </summary>
        [DataMember]
        public bool UseHistoricalTickData { get; set; }
        /// <summary>
        /// Gets or sets the UseLocalOcoSimulation.
        /// </summary>
        [DataMember]
        public bool UseLocalOcoSimulation { get; set; }
        /// <summary>
        /// Gets or sets the UseWebApi.
        /// </summary>
        [DataMember]
        public bool UseWebApi { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
