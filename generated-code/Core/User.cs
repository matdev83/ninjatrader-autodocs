[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class User : ISnapShotSerializable
    {
        #region Properties
        /// <summary>
        /// Gets or sets the ApiPacing.
        /// </summary>
        [DataMember]
        public ApiPacing ApiPacing { get; set; }
        /// <summary>
        /// Gets or sets the Auth0UserId.
        /// </summary>
        [DataMember]
        public String Auth0UserId { get; set; }
        /// <summary>
        /// Gets or sets the ExpirationTime.
        /// </summary>
        [DataMember]
        public DateTime ExpirationTime { get; set; }
        /// <summary>
        /// Gets or sets the RegisteredTime.
        /// </summary>
        [DataMember]
        public DateTime RegisteredTime { get; set; }
        /// <summary>
        /// Gets or sets the UserData.
        /// </summary>
        [DataMember]
        public XDocument UserData { get; set; }
        /// <summary>
        /// Gets or sets the Accounts.
        /// </summary>
        [DataMember]
        public Dictionary<Account, Boolean> Accounts { get; set; }
        /// <summary>
        /// Gets or sets the All.
        /// </summary>
        [DataMember]
        public Collection<User> All { get; set; }
        /// <summary>
        /// Gets or sets the Address.
        /// </summary>
        [DataMember]
        public String Address { get; set; }
        /// <summary>
        /// Gets or sets the ApiRateMultiplier.
        /// </summary>
        [DataMember]
        public Double ApiRateMultiplier { get; set; }
        /// <summary>
        /// Gets or sets the CanManageAccounts.
        /// </summary>
        [DataMember]
        public Boolean CanManageAccounts { get; set; }
        /// <summary>
        /// Gets or sets the CanManageMessages.
        /// </summary>
        [DataMember]
        public Boolean CanManageMessages { get; set; }
        /// <summary>
        /// Gets or sets the CanManagePermissions.
        /// </summary>
        [DataMember]
        public Boolean CanManagePermissions { get; set; }
        /// <summary>
        /// Gets or sets the CanManagePlatform.
        /// </summary>
        [DataMember]
        public Boolean CanManagePlatform { get; set; }
        /// <summary>
        /// Gets or sets the CanManageRisk.
        /// </summary>
        [DataMember]
        public Boolean CanManageRisk { get; set; }
        /// <summary>
        /// Gets or sets the CanManageTreasury.
        /// </summary>
        [DataMember]
        public Boolean CanManageTreasury { get; set; }
        /// <summary>
        /// Gets or sets the CanManageUsers.
        /// </summary>
        [DataMember]
        public Boolean CanManageUsers { get; set; }
        /// <summary>
        /// Gets or sets the CanRunReports.
        /// </summary>
        [DataMember]
        public Boolean CanRunReports { get; set; }
        /// <summary>
        /// Gets or sets the CanViewAccounts.
        /// </summary>
        [DataMember]
        public Boolean CanViewAccounts { get; set; }
        /// <summary>
        /// Gets or sets the CanViewUsers.
        /// </summary>
        [DataMember]
        public Boolean CanViewUsers { get; set; }
        /// <summary>
        /// Gets or sets the City.
        /// </summary>
        [DataMember]
        public String City { get; set; }
        /// <summary>
        /// Gets or sets the Company.
        /// </summary>
        [DataMember]
        public String Company { get; set; }
        /// <summary>
        /// Gets or sets the CqgPurchaseEligible.
        /// </summary>
        [DataMember]
        public DateTime CqgPurchaseEligible { get; set; }
        /// <summary>
        /// Gets or sets the Country.
        /// </summary>
        [DataMember]
        public String Country { get; set; }
        /// <summary>
        /// Gets or sets the CreatedByProvider.
        /// </summary>
        [DataMember]
        public Provider CreatedByProvider { get; set; }
        /// <summary>
        /// Gets or sets the Current.
        /// </summary>
        [DataMember]
        public User Current { get; set; }
        /// <summary>
        /// Gets or sets the Description.
        /// </summary>
        [DataMember]
        public String Description { get; set; }
        /// <summary>
        /// Gets or sets the Email1.
        /// </summary>
        [DataMember]
        public String Email1 { get; set; }
        /// <summary>
        /// Gets or sets the Email2.
        /// </summary>
        [DataMember]
        public String Email2 { get; set; }
        /// <summary>
        /// Gets or sets the Email3.
        /// </summary>
        [DataMember]
        public String Email3 { get; set; }
        /// <summary>
        /// Gets or sets the FirstName.
        /// </summary>
        [DataMember]
        public String FirstName { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public Int64 Id { get; set; }
        /// <summary>
        /// Gets or sets the IsEnabled.
        /// </summary>
        [DataMember]
        public Boolean IsEnabled { get; set; }
        /// <summary>
        /// Gets or sets the IsMonitor.
        /// </summary>
        [DataMember]
        public Boolean IsMonitor { get; set; }
        /// <summary>
        /// Gets or sets the IsProfessional.
        /// </summary>
        [DataMember]
        public Boolean IsProfessional { get; set; }
        /// <summary>
        /// Gets or sets the LastName.
        /// </summary>
        [DataMember]
        public String LastName { get; set; }
        /// <summary>
        /// Gets or sets the Licenses.
        /// </summary>
        [DataMember]
        public List<UserLicense> Licenses { get; set; }
        /// <summary>
        /// Gets or sets the ManagedProvider.
        /// </summary>
        [DataMember]
        public Provider ManagedProvider { get; set; }
        /// <summary>
        /// Gets or sets the ManagesAllAccounts.
        /// </summary>
        [DataMember]
        public Boolean ManagesAllAccounts { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataEntitlements.
        /// </summary>
        [DataMember]
        public Dictionary<MarketDataEntitlement, UserMarketDataEntitlement> MarketDataEntitlements { get; set; }
        /// <summary>
        /// Gets or sets the MaxConcurrentLogins.
        /// </summary>
        [DataMember]
        public Int32 MaxConcurrentLogins { get; set; }
        /// <summary>
        /// Gets or sets the MaxMarketDataSubscriptions.
        /// </summary>
        [DataMember]
        public Int32 MaxMarketDataSubscriptions { get; set; }
        /// <summary>
        /// Gets or sets the MaxMarketDepthSubscriptions.
        /// </summary>
        [DataMember]
        public Int32 MaxMarketDepthSubscriptions { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public String Name { get; set; }
        /// <summary>
        /// Gets or sets the NumSimulationAccounts.
        /// </summary>
        [DataMember]
        public Int32 NumSimulationAccounts { get; set; }
        /// <summary>
        /// Gets or sets the Password.
        /// </summary>
        [DataMember]
        public String Password { get; set; }
        /// <summary>
        /// Gets or sets the Phone.
        /// </summary>
        [DataMember]
        public String Phone { get; set; }
        /// <summary>
        /// Gets or sets the PostalCode.
        /// </summary>
        [DataMember]
        public String PostalCode { get; set; }
        /// <summary>
        /// Gets or sets the Salt.
        /// </summary>
        [DataMember]
        public String Salt { get; set; }
        /// <summary>
        /// Gets or sets the State.
        /// </summary>
        [DataMember]
        public String State { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// DbAdd method.
        /// </summary>
        /// <param name="persist">Boolean</param>
        public Void DbAdd(Boolean persist);
        /// <summary>
        /// DbRemove method.
        /// </summary>
        public Void DbRemove();
        /// <summary>
        /// DbUpdate method.
        /// </summary>
        public Void DbUpdate();
        /// <summary>
        /// SnapShotPersist method.
        /// </summary>
        /// <param name="updateVersion">Boolean</param>
        public Void SnapShotPersist(Boolean updateVersion);
        /// <summary>
        /// DbGet method.
        /// </summary>
        /// <param name="id">Int64</param>
        /// <returns>User</returns>
        public User DbGet(Int64 id);
        /// <summary>
        /// DbGet method.
        /// </summary>
        /// <param name="name">String</param>
        /// <param name="forceDbQuery">Boolean</param>
        /// <returns>User</returns>
        public User DbGet(String name, Boolean forceDbQuery);
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>String</returns>
        public String ToString();
        #endregion
    }
}
