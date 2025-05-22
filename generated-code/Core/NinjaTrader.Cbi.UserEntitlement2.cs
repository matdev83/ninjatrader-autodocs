[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class UserEntitlement2 : NinjaTrader.Cbi.IUserEntitlement
    {
        #region Properties
        /// <summary>
        /// Gets or sets the ApplicationType.
        /// </summary>
        [DataMember]
        public ApplicationType ApplicationType { get; set; }
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
        /// Gets or sets the IsEvaluation.
        /// </summary>
        [DataMember]
        public bool IsEvaluation { get; set; }
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
        /// Gets or sets the IsTradingAndAccountsAvailable.
        /// </summary>
        [DataMember]
        public bool IsTradingAndAccountsAvailable { get; set; }
        /// <summary>
        /// Gets or sets the MachineId.
        /// </summary>
        [DataMember]
        public string MachineId { get; set; }
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
        #endregion
        #region Methods
        #endregion
    }
}
