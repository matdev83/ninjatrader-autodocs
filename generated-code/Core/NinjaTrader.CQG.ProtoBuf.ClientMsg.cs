[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class ClientMsg : IMessage<ClientMsg>, IMessage, IEquatable<ClientMsg>, IDeepCloneable<ClientMsg>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<ClientMsg> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the Logon.
        /// </summary>
        [DataMember]
        public Logon Logon { get; set; }
        /// <summary>
        /// Gets or sets the RestoreOrJoinSession.
        /// </summary>
        [DataMember]
        public RestoreOrJoinSession RestoreOrJoinSession { get; set; }
        /// <summary>
        /// Gets or sets the Logoff.
        /// </summary>
        [DataMember]
        public Logoff Logoff { get; set; }
        /// <summary>
        /// Gets or sets the PasswordChange.
        /// </summary>
        [DataMember]
        public PasswordChange PasswordChange { get; set; }
        /// <summary>
        /// Gets or sets the ObtainDemoCredentials.
        /// </summary>
        [DataMember]
        public ObtainDemoCredentials ObtainDemoCredentials { get; set; }
        /// <summary>
        /// Gets or sets the UserSessionStateRequest.
        /// </summary>
        [DataMember]
        public UserSessionStateRequest UserSessionStateRequest { get; set; }
        /// <summary>
        /// Gets or sets the Ping.
        /// </summary>
        [DataMember]
        public Ping Ping { get; set; }
        /// <summary>
        /// Gets or sets the Pong.
        /// </summary>
        [DataMember]
        public Pong Pong { get; set; }
        /// <summary>
        /// Gets or sets the LogonRoutineClient.
        /// </summary>
        [DataMember]
        public LogonRoutineClient LogonRoutineClient { get; set; }
        /// <summary>
        /// Gets or sets the PasswordChangeRoutineClient.
        /// </summary>
        [DataMember]
        public PasswordChangeRoutineClient PasswordChangeRoutineClient { get; set; }
        /// <summary>
        /// Gets or sets the InformationRequest.
        /// </summary>
        [DataMember]
        public RepeatedField<InformationRequest> InformationRequest { get; set; }
        /// <summary>
        /// Gets or sets the TradeSubscription.
        /// </summary>
        [DataMember]
        public RepeatedField<TradeSubscription> TradeSubscription { get; set; }
        /// <summary>
        /// Gets or sets the OrderRequest.
        /// </summary>
        [DataMember]
        public RepeatedField<OrderRequest> OrderRequest { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataSubscription.
        /// </summary>
        [DataMember]
        public RepeatedField<MarketDataSubscription> MarketDataSubscription { get; set; }
        /// <summary>
        /// Gets or sets the ReadUserAttributeRequest.
        /// </summary>
        [DataMember]
        public RepeatedField<ReadUserAttributeRequest> ReadUserAttributeRequest { get; set; }
        /// <summary>
        /// Gets or sets the ModifyUserAttributeRequest.
        /// </summary>
        [DataMember]
        public RepeatedField<ModifyUserAttributeRequest> ModifyUserAttributeRequest { get; set; }
        /// <summary>
        /// Gets or sets the TimeAndSalesRequest.
        /// </summary>
        [DataMember]
        public RepeatedField<TimeAndSalesRequest> TimeAndSalesRequest { get; set; }
        /// <summary>
        /// Gets or sets the TimeBarRequest.
        /// </summary>
        [DataMember]
        public RepeatedField<TimeBarRequest> TimeBarRequest { get; set; }
        /// <summary>
        /// Gets or sets the VolumeProfileRequest.
        /// </summary>
        [DataMember]
        public RepeatedField<VolumeProfileRequest> VolumeProfileRequest { get; set; }
        /// <summary>
        /// Gets or sets the RuleRequest.
        /// </summary>
        [DataMember]
        public RepeatedField<RuleRequest> RuleRequest { get; set; }
        /// <summary>
        /// Gets or sets the AccountLogon.
        /// </summary>
        [DataMember]
        public RepeatedField<AccountLogon> AccountLogon { get; set; }
        /// <summary>
        /// Gets or sets the AccountPasswordChange.
        /// </summary>
        [DataMember]
        public RepeatedField<AccountPasswordChange> AccountPasswordChange { get; set; }
        /// <summary>
        /// Gets or sets the AccountLogoff.
        /// </summary>
        [DataMember]
        public RepeatedField<AccountLogoff> AccountLogoff { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>ClientMsg</returns>
        public ClientMsg Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">ClientMsg</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(ClientMsg other);
        /// <summary>
        /// GetHashCode method.
        /// </summary>
        /// <returns>Int32</returns>
        public Int32 GetHashCode();
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>String</returns>
        public String ToString();
        /// <summary>
        /// WriteTo method.
        /// </summary>
        /// <param name="output">CodedOutputStream</param>
        public Void WriteTo(CodedOutputStream output);
        /// <summary>
        /// CalculateSize method.
        /// </summary>
        /// <returns>Int32</returns>
        public Int32 CalculateSize();
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="other">ClientMsg</param>
        public Void MergeFrom(ClientMsg other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
