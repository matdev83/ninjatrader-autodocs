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
        public NinjaTrader.Cbi.UserEntitlement Instance { get; set; }
        /// <summary>
        /// Gets or sets the HasStaticSuperDOM.
        /// </summary>
        [DataMember]
        public bool HasStaticSuperDOM { get; set; }
        /// <summary>
        /// Gets or sets the IsAdmin.
        /// </summary>
        [DataMember]
        public bool IsAdmin { get; set; }
        /// <summary>
        /// Gets or sets the IsAMP.
        /// </summary>
        [DataMember]
        public bool IsAMP { get; set; }
        /// <summary>
        /// Gets or sets the IsEvaluation.
        /// </summary>
        [DataMember]
        public bool IsEvaluation { get; set; }
        /// <summary>
        /// Gets or sets the IsGFF.
        /// </summary>
        [DataMember]
        public bool IsGFF { get; set; }
        /// <summary>
        /// Gets or sets the IsLifeTime.
        /// </summary>
        [DataMember]
        public bool IsLifeTime { get; set; }
        /// <summary>
        /// Gets or sets the IsMarketReplay.
        /// </summary>
        [DataMember]
        public bool IsMarketReplay { get; set; }
        /// <summary>
        /// Gets or sets the IsMultiBroker.
        /// </summary>
        [DataMember]
        public bool IsMultiBroker { get; set; }
        /// <summary>
        /// Gets or sets the IsOrderFlowPlus.
        /// </summary>
        [DataMember]
        public bool IsOrderFlowPlus { get; set; }
        /// <summary>
        /// Gets or sets the IsRiskManagement.
        /// </summary>
        [DataMember]
        public bool IsRiskManagement { get; set; }
        /// <summary>
        /// Gets or sets the IsRithmic.
        /// </summary>
        [DataMember]
        public bool IsRithmic { get; set; }
        /// <summary>
        /// Gets or sets the IsServer.
        /// </summary>
        [DataMember]
        public bool IsServer { get; set; }
        /// <summary>
        /// Gets or sets the LicensedProviders.
        /// </summary>
        [DataMember]
        public Provider[] LicensedProviders { get; set; }
        /// <summary>
        /// Gets or sets the MachineId.
        /// </summary>
        [DataMember]
        public string MachineId { get; set; }
        /// <summary>
        /// Gets or sets the MachineId2.
        /// </summary>
        [DataMember]
        public string MachineId2 { get; set; }
        /// <summary>
        /// Gets or sets the NTLMUrl.
        /// </summary>
        [DataMember]
        public string NTLMUrl { get; set; }
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
        public long UserId { get; set; }
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
        /// <param name="rithmicConnection">RithmicConnection?</param>
        /// <returns>bool</returns>
        public bool IsTradingAndAccountAvailable(Provider provider, RithmicConnection? rithmicConnection)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Log method.
        /// </summary>
        /// <param name="action">string</param>
        public void Log(string action)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// ResetProviders method.
        /// </summary>
        public void ResetProviders()
        {
            // Method implementation goes here
        }
        /// <summary>
        /// VerifyAsync method.
        /// </summary>
        /// <param name="accessToken">string</param>
        /// <param name="authUserId">long</param>
        /// <returns>System.Threading.Tasks.Task<System.DateTime></returns>
        public System.Threading.Tasks.Task<System.DateTime> VerifyAsync(string accessToken, long authUserId)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
