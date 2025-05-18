[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class UserEntitlement
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Entitlements.
        /// </summary>
        [DataMember]
        public Entitlement[] Entitlements { get; set; }
        /// <summary>
        /// Gets or sets the Instance.
        /// </summary>
        [DataMember]
        public UserEntitlement Instance { get; set; }
        /// <summary>
        /// Gets or sets the HasStaticSuperDOM.
        /// </summary>
        [DataMember]
        public Boolean HasStaticSuperDOM { get; set; }
        /// <summary>
        /// Gets or sets the IsAdmin.
        /// </summary>
        [DataMember]
        public Boolean IsAdmin { get; set; }
        /// <summary>
        /// Gets or sets the IsAMP.
        /// </summary>
        [DataMember]
        public Boolean IsAMP { get; set; }
        /// <summary>
        /// Gets or sets the IsEvaluation.
        /// </summary>
        [DataMember]
        public Boolean IsEvaluation { get; set; }
        /// <summary>
        /// Gets or sets the IsGFF.
        /// </summary>
        [DataMember]
        public Boolean IsGFF { get; set; }
        /// <summary>
        /// Gets or sets the IsLifeTime.
        /// </summary>
        [DataMember]
        public Boolean IsLifeTime { get; set; }
        /// <summary>
        /// Gets or sets the IsMarketReplay.
        /// </summary>
        [DataMember]
        public Boolean IsMarketReplay { get; set; }
        /// <summary>
        /// Gets or sets the IsMultiBroker.
        /// </summary>
        [DataMember]
        public Boolean IsMultiBroker { get; set; }
        /// <summary>
        /// Gets or sets the IsOrderFlowPlus.
        /// </summary>
        [DataMember]
        public Boolean IsOrderFlowPlus { get; set; }
        /// <summary>
        /// Gets or sets the IsRiskManagement.
        /// </summary>
        [DataMember]
        public Boolean IsRiskManagement { get; set; }
        /// <summary>
        /// Gets or sets the IsRithmic.
        /// </summary>
        [DataMember]
        public Boolean IsRithmic { get; set; }
        /// <summary>
        /// Gets or sets the IsServer.
        /// </summary>
        [DataMember]
        public Boolean IsServer { get; set; }
        /// <summary>
        /// Gets or sets the LicensedProviders.
        /// </summary>
        [DataMember]
        public Provider[] LicensedProviders { get; set; }
        /// <summary>
        /// Gets or sets the MachineId.
        /// </summary>
        [DataMember]
        public String MachineId { get; set; }
        /// <summary>
        /// Gets or sets the MachineId2.
        /// </summary>
        [DataMember]
        public String MachineId2 { get; set; }
        /// <summary>
        /// Gets or sets the NTLMUrl.
        /// </summary>
        [DataMember]
        public String NTLMUrl { get; set; }
        /// <summary>
        /// Gets or sets the TradableRithmicSystems.
        /// </summary>
        [DataMember]
        public RithmicConnection[] TradableRithmicSystems { get; set; }
        /// <summary>
        /// Gets or sets the TradingProviders.
        /// </summary>
        [DataMember]
        public Provider[] TradingProviders { get; set; }
        /// <summary>
        /// Gets or sets the Subscription.
        /// </summary>
        [DataMember]
        public UserSubscriptionType Subscription { get; set; }
        /// <summary>
        /// Gets or sets the UserEntitlements.
        /// </summary>
        [DataMember]
        public Entitlement[] UserEntitlements { get; set; }
        /// <summary>
        /// Gets or sets the UserId.
        /// </summary>
        [DataMember]
        public Int64 UserId { get; set; }
        /// <summary>
        /// Gets or sets the UserSubscription.
        /// </summary>
        [DataMember]
        public UserSubscriptionType UserSubscription { get; set; }
        /// <summary>
        /// Gets or sets the VerificationState.
        /// </summary>
        [DataMember]
        public VerificationState VerificationState { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// IsTradingAndAccountAvailable method.
        /// </summary>
        /// <param name="provider">Provider</param>
        /// <param name="rithmicConnection">Nullable`1</param>
        /// <returns>Boolean</returns>
        public Boolean IsTradingAndAccountAvailable(Provider provider, Nullable<RithmicConnection> rithmicConnection);
        /// <summary>
        /// Log method.
        /// </summary>
        /// <param name="action">String</param>
        public Void Log(String action);
        /// <summary>
        /// ResetProviders method.
        /// </summary>
        public Void ResetProviders();
        /// <summary>
        /// VerifyAsync method.
        /// </summary>
        /// <param name="accessToken">String</param>
        /// <param name="authUserId">Int64</param>
        /// <returns>Task`1</returns>
        public Task<DateTime> VerifyAsync(String accessToken, Int64 authUserId);
        #endregion
    }
}
