[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class KinetickOptions : NinjaTrader.Cbi.ConnectOptions
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
        /// Gets or sets the GlobexNonProFees.
        /// </summary>
        [DataMember]
        public bool GlobexNonProFees { get; set; }
        /// <summary>
        /// Gets or sets the IsDataProviderOnly.
        /// </summary>
        [DataMember]
        public bool IsDataProviderOnly { get; set; }
        /// <summary>
        /// Gets or sets the BackadjustContinuousContracts.
        /// </summary>
        [DataMember]
        public bool BackadjustContinuousContracts { get; set; }
        /// <summary>
        /// Gets or sets the Free.
        /// </summary>
        [DataMember]
        public bool Free { get; set; }
        /// <summary>
        /// Gets or sets the NewsDaysBack.
        /// </summary>
        [DataMember]
        public int NewsDaysBack { get; set; }
        /// <summary>
        /// Gets or sets the UseFundamentalData.
        /// </summary>
        [DataMember]
        public bool UseFundamentalData { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
