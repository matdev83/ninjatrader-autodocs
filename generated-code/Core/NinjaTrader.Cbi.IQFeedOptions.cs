[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class IQFeedOptions : NinjaTrader.Cbi.ConnectOptions
    {
        #region Properties
        /// <summary>
        /// Gets or sets the BackadjustContinuousContracts.
        /// </summary>
        [DataMember]
        public bool BackadjustContinuousContracts { get; set; }
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
        /// Gets or sets the Host.
        /// </summary>
        [DataMember]
        public string Host { get; set; }
        /// <summary>
        /// Gets or sets the PortAdmin.
        /// </summary>
        [DataMember]
        public int PortAdmin { get; set; }
        /// <summary>
        /// Gets or sets the PortLevel1.
        /// </summary>
        [DataMember]
        public int PortLevel1 { get; set; }
        /// <summary>
        /// Gets or sets the PortLevel2.
        /// </summary>
        [DataMember]
        public int PortLevel2 { get; set; }
        /// <summary>
        /// Gets or sets the PortLookup.
        /// </summary>
        [DataMember]
        public int PortLookup { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
