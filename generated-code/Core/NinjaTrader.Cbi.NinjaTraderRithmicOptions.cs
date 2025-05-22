[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class NinjaTraderRithmicOptions : NinjaTrader.Cbi.ConnectOptions, NinjaTrader.Cbi.IRithmicOptions
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
        /// Gets or sets the Ibs.
        /// </summary>
        [DataMember]
        public System.String[] Ibs { get; set; }
        /// <summary>
        /// Gets or sets the RithmicConnection.
        /// </summary>
        [DataMember]
        public RithmicConnection RithmicConnection { get; set; }
        /// <summary>
        /// Gets or sets the UsePluginData.
        /// </summary>
        [DataMember]
        public bool UsePluginData { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
