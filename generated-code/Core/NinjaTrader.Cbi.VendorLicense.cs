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
        public Func<Boolean> DoVerify { get; set; }
        /// <summary>
        /// Gets or sets the EndDate.
        /// </summary>
        [DataMember]
        public DateTime EndDate { get; set; }
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
        public String MachineId { get; set; }
        /// <summary>
        /// Gets or sets the Module.
        /// </summary>
        [DataMember]
        public String Module { get; set; }
        /// <summary>
        /// Gets or sets the StartDate.
        /// </summary>
        [DataMember]
        public DateTime StartDate { get; set; }
        /// <summary>
        /// Gets or sets the UserName.
        /// </summary>
        [DataMember]
        public String UserName { get; set; }
        /// <summary>
        /// Gets or sets the VendorMail.
        /// </summary>
        [DataMember]
        public String VendorMail { get; set; }
        /// <summary>
        /// Gets or sets the VendorName.
        /// </summary>
        [DataMember]
        public String VendorName { get; set; }
        /// <summary>
        /// Gets or sets the VendorUrl.
        /// </summary>
        [DataMember]
        public String VendorUrl { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
