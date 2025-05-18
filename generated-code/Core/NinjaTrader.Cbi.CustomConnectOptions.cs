[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class CustomConnectOptions : ConnectOptions
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AdapterClassType.
        /// </summary>
        [DataMember]
        public Type AdapterClassType { get; set; }
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
        #endregion
        #region Methods
        #endregion
    }
}
