[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class License
    {
        #region Properties
        /// <summary>
        /// Gets or sets the MachineId.
        /// </summary>
        [DataMember]
        [Obsolete("License.MachineId is obsolete. Use UserEntitlement.MachineId")]
        public String MachineId { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Log method.
        /// </summary>
        /// <param name="action">String</param>
        /// <param name="mc2">String</param>
        /// <param name="licenseType">LicenseType</param>
        [Obsolete("License.Log is obsolete. Use UserEntitlement.Log")]
        public Void Log(String action, String mc2, LicenseType licenseType);
        #endregion
    }
}
