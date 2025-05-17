[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class ServerMsg : IMessage<ServerMsg>, IMessage, IEquatable<ServerMsg>, IDeepCloneable<ServerMsg>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<ServerMsg> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the LogonResult.
        /// </summary>
        [DataMember]
        public LogonResult LogonResult { get; set; }
        /// <summary>
        /// Gets or sets the RestoreOrJoinSessionResult.
        /// </summary>
        [DataMember]
        public RestoreOrJoinSessionResult RestoreOrJoinSessionResult { get; set; }
        /// <summary>
        /// Gets or sets the ConcurrentConnectionJoin.
        /// </summary>
        [DataMember]
        public RepeatedField<ConcurrentConnectionJoin> ConcurrentConnectionJoin { get; set; }
        /// <summary>
        /// Gets or sets the LoggedOff.
        /// </summary>
        [DataMember]
        public LoggedOff LoggedOff { get; set; }
        /// <summary>
        /// Gets or sets the PasswordChangeResult.
        /// </summary>
        [DataMember]
        public PasswordChangeResult PasswordChangeResult { get; set; }
        /// <summary>
        /// Gets or sets the UserMessage.
        /// </summary>
        [DataMember]
        public RepeatedField<UserMessage> UserMessage { get; set; }
        /// <summary>
        /// Gets or sets the ObtainDemoCredentialsResult.
        /// </summary>
        [DataMember]
        public RepeatedField<ObtainDemoCredentialsResult> ObtainDemoCredentialsResult { get; set; }
        /// <summary>
        /// Gets or sets the UserSessionStateResult.
        /// </summary>
        [DataMember]
        public RepeatedField<UserSessionStateResult> UserSessionStateResult { get; set; }
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
        /// Gets or sets the LogonRoutineServer.
        /// </summary>
        [DataMember]
        public LogonRoutineServer LogonRoutineServer { get; set; }
        /// <summary>
        /// Gets or sets the PasswordChangeRoutineServer.
        /// </summary>
        [DataMember]
        public PasswordChangeRoutineServer PasswordChangeRoutineServer { get; set; }
        /// <summary>
        /// Gets or sets the InformationReport.
        /// </summary>
        [DataMember]
        public RepeatedField<InformationReport> InformationReport { get; set; }
        /// <summary>
        /// Gets or sets the OrderRequestReject.
        /// </summary>
        [DataMember]
        public RepeatedField<OrderRequestReject> OrderRequestReject { get; set; }
        /// <summary>
        /// Gets or sets the TradeSubscriptionStatus.
        /// </summary>
        [DataMember]
        public RepeatedField<TradeSubscriptionStatus> TradeSubscriptionStatus { get; set; }
        /// <summary>
        /// Gets or sets the TradeSnapshotCompletion.
        /// </summary>
        [DataMember]
        public RepeatedField<TradeSnapshotCompletion> TradeSnapshotCompletion { get; set; }
        /// <summary>
        /// Gets or sets the OrderStatus.
        /// </summary>
        [DataMember]
        public RepeatedField<OrderStatus> OrderStatus { get; set; }
        /// <summary>
        /// Gets or sets the PositionStatus.
        /// </summary>
        [DataMember]
        public RepeatedField<PositionStatus> PositionStatus { get; set; }
        /// <summary>
        /// Gets or sets the CollateralStatus.
        /// </summary>
        [DataMember]
        public RepeatedField<CollateralStatus> CollateralStatus { get; set; }
        /// <summary>
        /// Gets or sets the MarketDataSubscriptionStatus.
        /// </summary>
        [DataMember]
        public RepeatedField<MarketDataSubscriptionStatus> MarketDataSubscriptionStatus { get; set; }
        /// <summary>
        /// Gets or sets the RealTimeMarketData.
        /// </summary>
        [DataMember]
        public RepeatedField<RealTimeMarketData> RealTimeMarketData { get; set; }
        /// <summary>
        /// Gets or sets the ReadUserAttributeResult.
        /// </summary>
        [DataMember]
        public RepeatedField<ReadUserAttributeResult> ReadUserAttributeResult { get; set; }
        /// <summary>
        /// Gets or sets the ModifyUserAttributeResult.
        /// </summary>
        [DataMember]
        public RepeatedField<ModifyUserAttributeResult> ModifyUserAttributeResult { get; set; }
        /// <summary>
        /// Gets or sets the TimeAndSalesReport.
        /// </summary>
        [DataMember]
        public RepeatedField<TimeAndSalesReport> TimeAndSalesReport { get; set; }
        /// <summary>
        /// Gets or sets the TimeBarReport.
        /// </summary>
        [DataMember]
        public RepeatedField<TimeBarReport> TimeBarReport { get; set; }
        /// <summary>
        /// Gets or sets the VolumeProfileReport.
        /// </summary>
        [DataMember]
        public RepeatedField<VolumeProfileReport> VolumeProfileReport { get; set; }
        /// <summary>
        /// Gets or sets the RuleResult.
        /// </summary>
        [DataMember]
        public RepeatedField<RuleResult> RuleResult { get; set; }
        /// <summary>
        /// Gets or sets the AccountLogonResult.
        /// </summary>
        [DataMember]
        public RepeatedField<AccountLogonResult> AccountLogonResult { get; set; }
        /// <summary>
        /// Gets or sets the AccountPasswordChangeResult.
        /// </summary>
        [DataMember]
        public RepeatedField<AccountPasswordChangeResult> AccountPasswordChangeResult { get; set; }
        /// <summary>
        /// Gets or sets the AccountLogoffResult.
        /// </summary>
        [DataMember]
        public RepeatedField<AccountLogoffResult> AccountLogoffResult { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>ServerMsg</returns>
        public ServerMsg Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">ServerMsg</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(ServerMsg other);
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
        /// <param name="other">ServerMsg</param>
        public Void MergeFrom(ServerMsg other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
