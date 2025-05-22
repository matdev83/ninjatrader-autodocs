[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class LicenseData
    {
        #region Properties
        /// <summary>
        /// Gets or sets the EndDate.
        /// </summary>
        [DataMember]
        public System.DateTime EndDate { get; set; }
        /// <summary>
        /// Gets or sets the LicenseType.
        /// </summary>
        [DataMember]
        public LicenseType LicenseType { get; set; }
        /// <summary>
        /// Gets or sets the StartDate.
        /// </summary>
        [DataMember]
        public System.DateTime StartDate { get; set; }
        /// <summary>
        /// Gets or sets the LicensedFeatures.
        /// </summary>
        [DataMember]
        public LicensedFeature[] LicensedFeatures { get; set; }
        /// <summary>
        /// Gets or sets the LicensedProviders.
        /// </summary>
        [DataMember]
        public Provider[] LicensedProviders { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
