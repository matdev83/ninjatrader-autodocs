[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class IQFeedOptions : ConnectOptions
    {
        #region Properties
        /// <summary>
        /// Gets or sets the BackadjustContinuousContracts.
        /// </summary>
        [DataMember]
        public Boolean BackadjustContinuousContracts { get; set; }
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
        /// Gets or sets the Host.
        /// </summary>
        [DataMember]
        public String Host { get; set; }
        /// <summary>
        /// Gets or sets the PortAdmin.
        /// </summary>
        [DataMember]
        public Int32 PortAdmin { get; set; }
        /// <summary>
        /// Gets or sets the PortLevel1.
        /// </summary>
        [DataMember]
        public Int32 PortLevel1 { get; set; }
        /// <summary>
        /// Gets or sets the PortLevel2.
        /// </summary>
        [DataMember]
        public Int32 PortLevel2 { get; set; }
        /// <summary>
        /// Gets or sets the PortLookup.
        /// </summary>
        [DataMember]
        public Int32 PortLookup { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
