[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class VendorLicensing
    {
        #region Properties
        /// <summary>
        /// Gets or sets the DefaultProduct.
        /// </summary>
        [DataMember]
        public string DefaultProduct { get; set; }
        /// <summary>
        /// Gets or sets the DefaultProductPath.
        /// </summary>
        [DataMember]
        public string DefaultProductPath { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Authorize method.
        /// </summary>
        /// <param name="vendorName">string</param>
        /// <param name="vendorKey">string</param>
        /// <param name="callback">System.Action<System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.VendorProduct>, bool, string></param>
        public void Authorize(string vendorName, string vendorKey, System.Action<System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.VendorProduct>, bool, string> callback)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ChangeLicense method.
        /// </summary>
        /// <param name="vendorName">string</param>
        /// <param name="vendorKey">string</param>
        /// <param name="oldProduct">string</param>
        /// <param name="oldUserID">string</param>
        /// <param name="oldMachineID">string</param>
        /// <param name="oldLicenseType">LicenseType</param>
        /// <param name="oldFromDate">System.DateTime</param>
        /// <param name="oldToDate">System.DateTime</param>
        /// <param name="newProduct">string</param>
        /// <param name="newUserID">string</param>
        /// <param name="newMachineID">string</param>
        /// <param name="newLicenseType">LicenseType</param>
        /// <param name="newFromDate">System.DateTime</param>
        /// <param name="newToDate">System.DateTime</param>
        /// <param name="callback">System.Action<bool, string></param>
        public void ChangeLicense(string vendorName, string vendorKey, string oldProduct, string oldUserID, string oldMachineID, LicenseType oldLicenseType, System.DateTime oldFromDate, System.DateTime oldToDate, string newProduct, string newUserID, string newMachineID, LicenseType newLicenseType, System.DateTime newFromDate, System.DateTime newToDate, System.Action<bool, string> callback)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// CountVendorLicenses method.
        /// </summary>
        /// <param name="vendorName">string</param>
        /// <param name="vendorKey">string</param>
        /// <param name="callback">System.Action<int, bool, string></param>
        public void CountVendorLicenses(string vendorName, string vendorKey, System.Action<int, bool, string> callback)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetMessages method.
        /// </summary>
        /// <param name="vendorName">string</param>
        /// <param name="messages">System.Collections.ObjectModel.Collection<string></param>
        /// <param name="errorCallback">System.Action<string></param>
        /// <returns>bool</returns>
        public bool GetMessages(string vendorName, System.Collections.ObjectModel.Collection<string> messages, System.Action<string> errorCallback)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetVendorLicenses method.
        /// </summary>
        /// <param name="vendorName">string</param>
        /// <param name="vendorKey">string</param>
        /// <param name="products">System.Collections.ObjectModel.Collection<string></param>
        /// <param name="userID">string</param>
        /// <param name="machineID">string</param>
        /// <param name="licenseType">LicenseType</param>
        /// <param name="startDate">System.DateTime</param>
        /// <param name="endDate">System.DateTime</param>
        /// <param name="callback">System.Action<System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.VendorLicense>, bool, string></param>
        public void GetVendorLicenses(string vendorName, string vendorKey, System.Collections.ObjectModel.Collection<string> products, string userID, string machineID, LicenseType licenseType, System.DateTime startDate, System.DateTime endDate, System.Action<System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.VendorLicense>, bool, string> callback)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// RemoveLicense method.
        /// </summary>
        /// <param name="vendorName">string</param>
        /// <param name="vendorKey">string</param>
        /// <param name="product">string</param>
        /// <param name="machineID">string</param>
        /// <param name="licenseType">LicenseType</param>
        /// <param name="callback">System.Action<bool, string></param>
        public void RemoveLicense(string vendorName, string vendorKey, string product, string machineID, LicenseType licenseType, System.Action<bool, string> callback)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// UpdateLicense method.
        /// </summary>
        /// <param name="vendorName">string</param>
        /// <param name="vendorKey">string</param>
        /// <param name="product">string</param>
        /// <param name="userID">string</param>
        /// <param name="machineID">string</param>
        /// <param name="licenseType">LicenseType</param>
        /// <param name="fromDate">System.DateTime</param>
        /// <param name="toDate">System.DateTime</param>
        /// <param name="callback">System.Action<bool, string></param>
        public void UpdateLicense(string vendorName, string vendorKey, string product, string userID, string machineID, LicenseType licenseType, System.DateTime fromDate, System.DateTime toDate, System.Action<bool, string> callback)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// UpdateMessages method.
        /// </summary>
        /// <param name="vendorName">string</param>
        /// <param name="vendorKey">string</param>
        /// <param name="messages">System.Collections.ObjectModel.Collection<string></param>
        /// <param name="callback">System.Action<bool, string></param>
        public void UpdateMessages(string vendorName, string vendorKey, System.Collections.ObjectModel.Collection<string> messages, System.Action<bool, string> callback)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// UpdateProducts method.
        /// </summary>
        /// <param name="vendorName">string</param>
        /// <param name="vendorKey">string</param>
        /// <param name="products">System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.VendorProduct></param>
        /// <param name="callback">System.Action<bool, string></param>
        public void UpdateProducts(string vendorName, string vendorKey, System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.VendorProduct> products, System.Action<bool, string> callback)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
