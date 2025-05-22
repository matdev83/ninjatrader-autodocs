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
        public string MachineId { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Log method.
        /// </summary>
        /// <param name="action">string</param>
        /// <param name="mc2">string</param>
        /// <param name="licenseType">LicenseType</param>
        [Obsolete("License.Log is obsolete. Use UserEntitlement.Log")]
        public void Log(string action, string mc2, LicenseType licenseType)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
