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
        public String DefaultProduct { get; set; }
        /// <summary>
        /// Gets or sets the DefaultProductPath.
        /// </summary>
        [DataMember]
        public String DefaultProductPath { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Authorize method.
        /// </summary>
        /// <param name="vendorName">String</param>
        /// <param name="vendorKey">String</param>
        /// <param name="callback">Action`3</param>
        public Void Authorize(String vendorName, String vendorKey, Action<Collection<VendorProduct>, Boolean, String> callback);
        /// <summary>
        /// ChangeLicense method.
        /// </summary>
        /// <param name="vendorName">String</param>
        /// <param name="vendorKey">String</param>
        /// <param name="oldProduct">String</param>
        /// <param name="oldUserID">String</param>
        /// <param name="oldMachineID">String</param>
        /// <param name="oldLicenseType">LicenseType</param>
        /// <param name="oldFromDate">DateTime</param>
        /// <param name="oldToDate">DateTime</param>
        /// <param name="newProduct">String</param>
        /// <param name="newUserID">String</param>
        /// <param name="newMachineID">String</param>
        /// <param name="newLicenseType">LicenseType</param>
        /// <param name="newFromDate">DateTime</param>
        /// <param name="newToDate">DateTime</param>
        /// <param name="callback">Action`2</param>
        public Void ChangeLicense(String vendorName, String vendorKey, String oldProduct, String oldUserID, String oldMachineID, LicenseType oldLicenseType, DateTime oldFromDate, DateTime oldToDate, String newProduct, String newUserID, String newMachineID, LicenseType newLicenseType, DateTime newFromDate, DateTime newToDate, Action<Boolean, String> callback);
        /// <summary>
        /// CountVendorLicenses method.
        /// </summary>
        /// <param name="vendorName">String</param>
        /// <param name="vendorKey">String</param>
        /// <param name="callback">Action`3</param>
        public Void CountVendorLicenses(String vendorName, String vendorKey, Action<Int32, Boolean, String> callback);
        /// <summary>
        /// GetMessages method.
        /// </summary>
        /// <param name="vendorName">String</param>
        /// <param name="messages">Collection`1</param>
        /// <param name="errorCallback">Action`1</param>
        /// <returns>Boolean</returns>
        public Boolean GetMessages(String vendorName, Collection<String> messages, Action<String> errorCallback);
        /// <summary>
        /// GetVendorLicenses method.
        /// </summary>
        /// <param name="vendorName">String</param>
        /// <param name="vendorKey">String</param>
        /// <param name="products">Collection`1</param>
        /// <param name="userID">String</param>
        /// <param name="machineID">String</param>
        /// <param name="licenseType">LicenseType</param>
        /// <param name="startDate">DateTime</param>
        /// <param name="endDate">DateTime</param>
        /// <param name="callback">Action`3</param>
        public Void GetVendorLicenses(String vendorName, String vendorKey, Collection<String> products, String userID, String machineID, LicenseType licenseType, DateTime startDate, DateTime endDate, Action<Collection<VendorLicense>, Boolean, String> callback);
        /// <summary>
        /// RemoveLicense method.
        /// </summary>
        /// <param name="vendorName">String</param>
        /// <param name="vendorKey">String</param>
        /// <param name="product">String</param>
        /// <param name="machineID">String</param>
        /// <param name="licenseType">LicenseType</param>
        /// <param name="callback">Action`2</param>
        public Void RemoveLicense(String vendorName, String vendorKey, String product, String machineID, LicenseType licenseType, Action<Boolean, String> callback);
        /// <summary>
        /// UpdateLicense method.
        /// </summary>
        /// <param name="vendorName">String</param>
        /// <param name="vendorKey">String</param>
        /// <param name="product">String</param>
        /// <param name="userID">String</param>
        /// <param name="machineID">String</param>
        /// <param name="licenseType">LicenseType</param>
        /// <param name="fromDate">DateTime</param>
        /// <param name="toDate">DateTime</param>
        /// <param name="callback">Action`2</param>
        public Void UpdateLicense(String vendorName, String vendorKey, String product, String userID, String machineID, LicenseType licenseType, DateTime fromDate, DateTime toDate, Action<Boolean, String> callback);
        /// <summary>
        /// UpdateMessages method.
        /// </summary>
        /// <param name="vendorName">String</param>
        /// <param name="vendorKey">String</param>
        /// <param name="messages">Collection`1</param>
        /// <param name="callback">Action`2</param>
        public Void UpdateMessages(String vendorName, String vendorKey, Collection<String> messages, Action<Boolean, String> callback);
        /// <summary>
        /// UpdateProducts method.
        /// </summary>
        /// <param name="vendorName">String</param>
        /// <param name="vendorKey">String</param>
        /// <param name="products">Collection`1</param>
        /// <param name="callback">Action`2</param>
        public Void UpdateProducts(String vendorName, String vendorKey, Collection<VendorProduct> products, Action<Boolean, String> callback);
        #endregion
    }
}
