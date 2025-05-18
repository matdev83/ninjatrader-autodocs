[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class TradeSubscription : IMessage<TradeSubscription>, IMessage, IEquatable<TradeSubscription>, IDeepCloneable<TradeSubscription>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<TradeSubscription> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public UInt32 Id { get; set; }
        /// <summary>
        /// Gets or sets the SubscriptionScope.
        /// </summary>
        [DataMember]
        public RepeatedField<UInt32> SubscriptionScope { get; set; }
        /// <summary>
        /// Gets or sets the PublicationType.
        /// </summary>
        [DataMember]
        public UInt32 PublicationType { get; set; }
        /// <summary>
        /// Gets or sets the AccountId.
        /// </summary>
        [DataMember]
        public UInt32 AccountId { get; set; }
        /// <summary>
        /// Gets or sets the SalesSeriesNumber.
        /// </summary>
        [DataMember]
        public String SalesSeriesNumber { get; set; }
        /// <summary>
        /// Gets or sets the BrokerageId.
        /// </summary>
        [DataMember]
        public UInt32 BrokerageId { get; set; }
        /// <summary>
        /// Gets or sets the Subscribe.
        /// </summary>
        [DataMember]
        public Boolean Subscribe { get; set; }
        /// <summary>
        /// Gets or sets the LastOrderUpdateUtcTime.
        /// </summary>
        [DataMember]
        [Obsolete]
        public Int64 LastOrderUpdateUtcTime { get; set; }
        /// <summary>
        /// Gets or sets the LastOrderUpdateUtcTimestamp.
        /// </summary>
        [DataMember]
        public Timestamp LastOrderUpdateUtcTimestamp { get; set; }
        /// <summary>
        /// Gets or sets the SkipOrdersSnapshot.
        /// </summary>
        [DataMember]
        public Boolean SkipOrdersSnapshot { get; set; }
        /// <summary>
        /// Gets or sets the ConfirmedPositionsOnly.
        /// </summary>
        [DataMember]
        public Boolean ConfirmedPositionsOnly { get; set; }
        /// <summary>
        /// Gets or sets the MatchingAlgorithm.
        /// </summary>
        [DataMember]
        public UInt32 MatchingAlgorithm { get; set; }
        /// <summary>
        /// Gets or sets the MatchIntradayFirst.
        /// </summary>
        [DataMember]
        public Boolean MatchIntradayFirst { get; set; }
        /// <summary>
        /// Gets or sets the HistoricalMatchingAlgorithm.
        /// </summary>
        [DataMember]
        public UInt32 HistoricalMatchingAlgorithm { get; set; }
        /// <summary>
        /// Gets or sets the MatchIntradayFirstPresentCase.
        /// </summary>
        [DataMember]
        public MatchIntradayFirstPresentOneofCase MatchIntradayFirstPresentCase { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>TradeSubscription</returns>
        public TradeSubscription Clone();
        /// <summary>
        /// ClearMatchIntradayFirstPresent method.
        /// </summary>
        public Void ClearMatchIntradayFirstPresent();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">TradeSubscription</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(TradeSubscription other);
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
        /// <param name="other">TradeSubscription</param>
        public Void MergeFrom(TradeSubscription other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
