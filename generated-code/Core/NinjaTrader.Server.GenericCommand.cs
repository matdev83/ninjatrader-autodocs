namespace NinjaTrader.Server
{
    public enum GenericCommand : int
    {
        AddLicenseManagementLog = 0,
        CancelLicense = 1,
        DeleteUser = 2,
        GenerateLicense = 3,
        TransactionCreditPurchase = 4,
        SendLifetimeLicenseTerms = 5
    }
}
