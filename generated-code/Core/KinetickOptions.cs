[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class KinetickOptions : ConnectOptions
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
        /// Gets or sets the GlobexNonProFees.
        /// </summary>
        [DataMember]
        public Boolean GlobexNonProFees { get; set; }
        /// <summary>
        /// Gets or sets the IsDataProviderOnly.
        /// </summary>
        [DataMember]
        public Boolean IsDataProviderOnly { get; set; }
        /// <summary>
        /// Gets or sets the BackadjustContinuousContracts.
        /// </summary>
        [DataMember]
        public Boolean BackadjustContinuousContracts { get; set; }
        /// <summary>
        /// Gets or sets the Free.
        /// </summary>
        [DataMember]
        public Boolean Free { get; set; }
        /// <summary>
        /// Gets or sets the NewsDaysBack.
        /// </summary>
        [DataMember]
        public Int32 NewsDaysBack { get; set; }
        /// <summary>
        /// Gets or sets the UseFundamentalData.
        /// </summary>
        [DataMember]
        public Boolean UseFundamentalData { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
