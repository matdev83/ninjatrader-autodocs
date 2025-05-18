[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class CQGOptions : ConnectOptions, ICQGOptions
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
        /// Gets or sets the Disclaimer.
        /// </summary>
        [DataMember]
        public String Disclaimer { get; set; }
        /// <summary>
        /// Gets or sets the Fcms.
        /// </summary>
        [DataMember]
        public String[] Fcms { get; set; }
        /// <summary>
        /// Gets or sets the IncludeFx.
        /// </summary>
        [DataMember]
        public Boolean IncludeFx { get; set; }
        /// <summary>
        /// Gets or sets the UseHistoricalTickData.
        /// </summary>
        [DataMember]
        public Boolean UseHistoricalTickData { get; set; }
        /// <summary>
        /// Gets or sets the UseLocalOcoSimulation.
        /// </summary>
        [DataMember]
        public Boolean UseLocalOcoSimulation { get; set; }
        /// <summary>
        /// Gets or sets the UseWebApi.
        /// </summary>
        [DataMember]
        public Boolean UseWebApi { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
