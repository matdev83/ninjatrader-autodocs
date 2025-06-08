# VendorLicensing

Namespace: `NinjaTrader.Cbi`
Type: class

This documentation is generated from reflection scaffolding and may be incomplete.

## Properties
- `DefaultProduct` (string)
- `DefaultProductPath` (string)

## Methods
- `Authorize(string vendorName, string vendorKey, System.Action<System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.VendorProduct>, bool, string> callback)` : void
- `ChangeLicense(string vendorName, string vendorKey, string oldProduct, string oldUserID, string oldMachineID, LicenseType oldLicenseType, System.DateTime oldFromDate, System.DateTime oldToDate, string newProduct, string newUserID, string newMachineID, LicenseType newLicenseType, System.DateTime newFromDate, System.DateTime newToDate, System.Action<bool, string> callback)` : void
- `CountVendorLicenses(string vendorName, string vendorKey, System.Action<int, bool, string> callback)` : void
- `GetMessages(string vendorName, System.Collections.ObjectModel.Collection<string> messages, System.Action<string> errorCallback)` : bool
- `GetVendorLicenses(string vendorName, string vendorKey, System.Collections.ObjectModel.Collection<string> products, string userID, string machineID, LicenseType licenseType, System.DateTime startDate, System.DateTime endDate, System.Action<System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.VendorLicense>, bool, string> callback)` : void
- `RemoveLicense(string vendorName, string vendorKey, string product, string machineID, LicenseType licenseType, System.Action<bool, string> callback)` : void
- `UpdateLicense(string vendorName, string vendorKey, string product, string userID, string machineID, LicenseType licenseType, System.DateTime fromDate, System.DateTime toDate, System.Action<bool, string> callback)` : void
- `UpdateMessages(string vendorName, string vendorKey, System.Collections.ObjectModel.Collection<string> messages, System.Action<bool, string> callback)` : void
- `UpdateProducts(string vendorName, string vendorKey, System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.VendorProduct> products, System.Action<bool, string> callback)` : void
