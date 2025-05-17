[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class RithmicOptions : ConnectOptions, IRithmicOptions
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
        /// Gets or sets the RithmicConnection.
        /// </summary>
        [DataMember]
        public RithmicConnection RithmicConnection { get; set; }
        /// <summary>
        /// Gets or sets the RithmicEvalSystems.
        /// </summary>
        [DataMember]
        public List<RithmicEvalSystem> RithmicEvalSystems { get; set; }
        /// <summary>
        /// Gets or sets the UsePluginData.
        /// </summary>
        [DataMember]
        public Boolean UsePluginData { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
