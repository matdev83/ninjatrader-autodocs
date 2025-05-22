[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class User : NinjaTrader.Cbi.ISnapShotSerializable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the ApiPacing.
        /// </summary>
        [DataMember]
        public NinjaTrader.Server.ApiPacing ApiPacing { get; set; }
        /// <summary>
        /// Gets or sets the Auth0UserId.
        /// </summary>
        [DataMember]
        public string Auth0UserId { get; set; }
        /// <summary>
        /// Gets or sets the ExpirationTime.
        /// </summary>
        [DataMember]
        public System.DateTime ExpirationTime { get; set; }
        /// <summary>
        /// Gets or sets the RegisteredTime.
        /// </summary>
        [DataMember]
        public System.DateTime RegisteredTime { get; set; }
        /// <summary>
        /// Gets or sets the UserData.
        /// </summary>
        [DataMember]
        public System.Xml.Linq.XDocument UserData { get; set; }
        /// <summary>
        /// Gets or sets the Accounts.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<NinjaTrader.Cbi.Account, bool> Accounts { get; set; }
        /// <summary>
        /// Gets or sets the All.
        /// </summary>
        [DataMember]
        public System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.User> All { get; set; }
        /// <summary>
        /// Gets or sets the Address.
        /// </summary>
        [DataMember]
        public string Address { get; set; }
        /// <summary>
        /// Gets or sets the ApiRateMultiplier.
        /// </summary>
        [DataMember]
        public double ApiRateMultiplier { get; set; }
        /// <summary>
        /// Gets or sets the CanManageAccounts.
        /// </summary>
        [DataMember]
        public bool CanManageAccounts { get; set; }
        /// <summary>
        /// Gets or sets the CanManageMessages.
        /// </summary>
        [DataMember]
        public bool CanManageMessages { get; set; }
        /// <summary>
        /// Gets or sets the CanManagePermissions.
        /// </summary>
        [DataMember]
        public bool CanManagePermissions { get; set; }
        /// <summary>
        /// Gets or sets the CanManagePlatform.
        /// </summary>
        [DataMember]
        public bool CanManagePlatform { get; set; }
        /// <summary>
        /// Gets or sets the CanManageRisk.
        /// </summary>
        [DataMember]
        public bool CanManageRisk { get; set; }
        /// <summary>
        /// Gets or sets the CanManageTreasury.
        /// </summary>
        [DataMember]
        public bool CanManageTreasury { get; set; }
        /// <summary>
        /// Gets or sets the CanManageUsers.
        /// </summary>
        [DataMember]
        public bool CanManageUsers { get; set; }
        /// <summary>
        /// Gets or sets the CanRunReports.
        /// </summary>
        [DataMember]
        public bool CanRunReports { get; set; }
        /// <summary>
        /// Gets or sets the CanViewAccounts.
        /// </summary>
        [DataMember]
        public bool CanViewAccounts { get; set; }
        /// <summary>
        /// Gets or sets the CanViewUsers.
        /// </summary>
        [DataMember]
        public bool CanViewUsers { get; set; }
        /// <summary>
        /// Gets or sets the City.
        /// </summary>
        [DataMember]
        public string City { get; set; }
        /// <summary>
        /// Gets or sets the Company.
        /// </summary>
        [DataMember]
        public string Company { get; set; }
        /// <summary>
        /// Gets or sets the CqgPurchaseEligible.
        /// </summary>
        [DataMember]
        public System.DateTime CqgPurchaseEligible { get; set; }
        /// <summary>
        /// Gets or sets the Country.
        /// </summary>
        [DataMember]
        public string Country { get; set; }
        /// <summary>
        /// Gets or sets the CreatedByProvider.
        /// </summary>
        [DataMember]
        public Provider CreatedByProvider { get; set; }
        /// <summary>
        /// Gets or sets the Current.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.User Current { get; set; }
        /// <summary>
        /// Gets or sets the Description.
        /// </summary>
        [DataMember]
        public string Description { get; set; }
        /// <summary>
        /// Gets or sets the Email1.
        /// </summary>
        [DataMember]
        public string Email1 { get; set; }
        /// <summary>
        /// Gets or sets the Email2.
        /// </summary>
        [DataMember]
        public string Email2 { get; set; }
        /// <summary>
        /// Gets or sets the Email3.
        /// </summary>
        [DataMember]
        public string Email3 { get; set; }
        /// <summary>
        /// Gets or sets the FirstName.
        /// </summary>
        [DataMember]
        public string FirstName { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public long Id { get; set; }
        /// <summary>
        /// Gets or sets the IsEnabled.
        /// </summary>
        [DataMember]
        public bool IsEnabled { get; set; }
        /// <summary>
        /// Gets or sets the IsMonitor.
        /// </summary>
        [DataMember]
        public bool IsMonitor { get; set; }
        /// <summary>
        /// Gets or sets the IsProfessional.
        /// </summary>
        [DataMember]
        public bool IsProfessional { get; set; }
        /// <summary>
        /// Gets or sets the LastName.
        /// </summary>
        [DataMember]
        public string LastName { get; set; }
        /// <summary>
        /// Gets or sets the Licenses.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.List<NinjaTrader.Cbi.UserLicense> Licenses { get; set; }
        /// <summary>
        /// Gets or sets the ManagedProvider.
        /// </summary>
        [DataMember]
        public Provider ManagedProvider { get; set; }
        /// <summary>
        /// Gets or sets the ManagesAllAccounts.
        /// </summary>
        [DataMember]
        public bool ManagesAllAccounts { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataEntitlements.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<NinjaTrader.Data.MarketDataEntitlement, NinjaTrader.Cbi.UserMarketDataEntitlement> MarketDataEntitlements { get; set; }
        /// <summary>
        /// Gets or sets the MaxConcurrentLogins.
        /// </summary>
        [DataMember]
        public int MaxConcurrentLogins { get; set; }
        /// <summary>
        /// Gets or sets the MaxMarketDataSubscriptions.
        /// </summary>
        [DataMember]
        public int MaxMarketDataSubscriptions { get; set; }
        /// <summary>
        /// Gets or sets the MaxMarketDepthSubscriptions.
        /// </summary>
        [DataMember]
        public int MaxMarketDepthSubscriptions { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the NumSimulationAccounts.
        /// </summary>
        [DataMember]
        public int NumSimulationAccounts { get; set; }
        /// <summary>
        /// Gets or sets the Password.
        /// </summary>
        [DataMember]
        public string Password { get; set; }
        /// <summary>
        /// Gets or sets the Phone.
        /// </summary>
        [DataMember]
        public string Phone { get; set; }
        /// <summary>
        /// Gets or sets the PostalCode.
        /// </summary>
        [DataMember]
        public string PostalCode { get; set; }
        /// <summary>
        /// Gets or sets the Salt.
        /// </summary>
        [DataMember]
        public string Salt { get; set; }
        /// <summary>
        /// Gets or sets the State.
        /// </summary>
        [DataMember]
        public string State { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// DbAdd method.
        /// </summary>
        /// <param name="persist">bool</param>
        public void DbAdd(bool persist)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DbRemove method.
        /// </summary>
        public void DbRemove()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DbUpdate method.
        /// </summary>
        public void DbUpdate()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// SnapShotPersist method.
        /// </summary>
        /// <param name="updateVersion">bool</param>
        public void SnapShotPersist(bool updateVersion)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DbGet method.
        /// </summary>
        /// <param name="id">long</param>
        /// <returns>NinjaTrader.Cbi.User</returns>
        public NinjaTrader.Cbi.User DbGet(long id)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// DbGet method.
        /// </summary>
        /// <param name="name">string</param>
        /// <param name="forceDbQuery">bool</param>
        /// <returns>NinjaTrader.Cbi.User</returns>
        public NinjaTrader.Cbi.User DbGet(string name, bool forceDbQuery)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>string</returns>
        public string ToString()
        {
            // Method implementation goes here
        }
        #endregion
    }
}
