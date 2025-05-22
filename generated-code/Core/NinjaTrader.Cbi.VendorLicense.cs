[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class VendorLicense
    {
        #region Properties
        /// <summary>
        /// Gets or sets the DoVerify.
        /// </summary>
        [DataMember]
        public System.Func<bool> DoVerify { get; set; }
        /// <summary>
        /// Gets or sets the EndDate.
        /// </summary>
        [DataMember]
        public System.DateTime EndDate { get; set; }
        /// <summary>
        /// Gets or sets the LicenseState.
        /// </summary>
        [DataMember]
        public LicenseState LicenseState { get; set; }
        /// <summary>
        /// Gets or sets the LicenseType.
        /// </summary>
        [DataMember]
        public LicenseType LicenseType { get; set; }
        /// <summary>
        /// Gets or sets the MachineId.
        /// </summary>
        [DataMember]
        public string MachineId { get; set; }
        /// <summary>
        /// Gets or sets the Module.
        /// </summary>
        [DataMember]
        public string Module { get; set; }
        /// <summary>
        /// Gets or sets the StartDate.
        /// </summary>
        [DataMember]
        public System.DateTime StartDate { get; set; }
        /// <summary>
        /// Gets or sets the UserName.
        /// </summary>
        [DataMember]
        public string UserName { get; set; }
        /// <summary>
        /// Gets or sets the VendorMail.
        /// </summary>
        [DataMember]
        public string VendorMail { get; set; }
        /// <summary>
        /// Gets or sets the VendorName.
        /// </summary>
        [DataMember]
        public string VendorName { get; set; }
        /// <summary>
        /// Gets or sets the VendorUrl.
        /// </summary>
        [DataMember]
        public string VendorUrl { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
