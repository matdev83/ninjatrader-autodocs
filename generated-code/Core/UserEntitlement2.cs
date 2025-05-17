[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class UserEntitlement2 : IUserEntitlement
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
        public Boolean HasStaticSuperDOM { get; set; }
        /// <summary>
        /// Gets or sets the IsAdmin.
        /// </summary>
        [DataMember]
        public Boolean IsAdmin { get; set; }
        /// <summary>
        /// Gets or sets the IsEvaluation.
        /// </summary>
        [DataMember]
        public Boolean IsEvaluation { get; set; }
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
        /// Gets or sets the IsTradingAndAccountsAvailable.
        /// </summary>
        [DataMember]
        public Boolean IsTradingAndAccountsAvailable { get; set; }
        /// <summary>
        /// Gets or sets the MachineId.
        /// </summary>
        [DataMember]
        public String MachineId { get; set; }
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
        #endregion
        #region Methods
        #endregion
    }
}
