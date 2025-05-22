[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class CustomConnectOptions : NinjaTrader.Cbi.ConnectOptions
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AdapterClassType.
        /// </summary>
        [DataMember]
        public System.Type AdapterClassType { get; set; }
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
        #endregion
        #region Methods
        #endregion
    }
}
