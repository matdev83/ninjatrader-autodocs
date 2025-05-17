[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class OrderStatus : IMessage<OrderStatus>, IMessage, IEquatable<OrderStatus>, IDeepCloneable<OrderStatus>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<OrderStatus> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the SubscriptionId.
        /// </summary>
        [DataMember]
        public RepeatedField<UInt32> SubscriptionId { get; set; }
        /// <summary>
        /// Gets or sets the IsSnapshot.
        /// </summary>
        [DataMember]
        public Boolean IsSnapshot { get; set; }
        /// <summary>
        /// Gets or sets the Status.
        /// </summary>
        [DataMember]
        public UInt32 Status { get; set; }
        /// <summary>
        /// Gets or sets the OrderId.
        /// </summary>
        [DataMember]
        public String OrderId { get; set; }
        /// <summary>
        /// Gets or sets the ChainOrderId.
        /// </summary>
        [DataMember]
        public String ChainOrderId { get; set; }
        /// <summary>
        /// Gets or sets the ExecOrderId.
        /// </summary>
        [DataMember]
        public String ExecOrderId { get; set; }
        /// <summary>
        /// Gets or sets the StatusUtcTime.
        /// </summary>
        [DataMember]
        [Obsolete]
        public Int64 StatusUtcTime { get; set; }
        /// <summary>
        /// Gets or sets the StatusUtcTimestamp.
        /// </summary>
        [DataMember]
        public Timestamp StatusUtcTimestamp { get; set; }
        /// <summary>
        /// Gets or sets the SubmissionUtcTime.
        /// </summary>
        [DataMember]
        [Obsolete]
        public Int64 SubmissionUtcTime { get; set; }
        /// <summary>
        /// Gets or sets the SubmissionUtcTimestamp.
        /// </summary>
        [DataMember]
        public Timestamp SubmissionUtcTimestamp { get; set; }
        /// <summary>
        /// Gets or sets the Uint32FillQty.
        /// </summary>
        [DataMember]
        [Obsolete]
        public UInt32 Uint32FillQty { get; set; }
        /// <summary>
        /// Gets or sets the FillQty.
        /// </summary>
        [DataMember]
        public Decimal FillQty { get; set; }
        /// <summary>
        /// Gets or sets the FillCnt.
        /// </summary>
        [DataMember]
        public UInt32 FillCnt { get; set; }
        /// <summary>
        /// Gets or sets the AvgFillPrice.
        /// </summary>
        [DataMember]
        public Int64 AvgFillPrice { get; set; }
        /// <summary>
        /// Gets or sets the AvgFillPriceCorrect.
        /// </summary>
        [DataMember]
        public Double AvgFillPriceCorrect { get; set; }
        /// <summary>
        /// Gets or sets the ActiveAtUtcTime.
        /// </summary>
        [DataMember]
        [Obsolete]
        public Int64 ActiveAtUtcTime { get; set; }
        /// <summary>
        /// Gets or sets the ActiveAtUtcTimestamp.
        /// </summary>
        [DataMember]
        public Timestamp ActiveAtUtcTimestamp { get; set; }
        /// <summary>
        /// Gets or sets the Uint32RemainingQty.
        /// </summary>
        [DataMember]
        [Obsolete]
        public UInt32 Uint32RemainingQty { get; set; }
        /// <summary>
        /// Gets or sets the RemainingQty.
        /// </summary>
        [DataMember]
        public Decimal RemainingQty { get; set; }
        /// <summary>
        /// Gets or sets the Order.
        /// </summary>
        [DataMember]
        public Order Order { get; set; }
        /// <summary>
        /// Gets or sets the TransactionStatus.
        /// </summary>
        [DataMember]
        public RepeatedField<TransactionStatus> TransactionStatus { get; set; }
        /// <summary>
        /// Gets or sets the EnteredByUser.
        /// </summary>
        [DataMember]
        public String EnteredByUser { get; set; }
        /// <summary>
        /// Gets or sets the FirstStatementDate.
        /// </summary>
        [DataMember]
        public Int64 FirstStatementDate { get; set; }
        /// <summary>
        /// Gets or sets the LastStatementDate.
        /// </summary>
        [DataMember]
        public Int64 LastStatementDate { get; set; }
        /// <summary>
        /// Gets or sets the ContractMetadata.
        /// </summary>
        [DataMember]
        public RepeatedField<ContractMetadata> ContractMetadata { get; set; }
        /// <summary>
        /// Gets or sets the AccountId.
        /// </summary>
        [DataMember]
        public Int32 AccountId { get; set; }
        /// <summary>
        /// Gets or sets the CompoundOrderStructure.
        /// </summary>
        [DataMember]
        public CompoundOrderStructure CompoundOrderStructure { get; set; }
        /// <summary>
        /// Gets or sets the HangCount.
        /// </summary>
        [DataMember]
        public UInt32 HangCount { get; set; }
        /// <summary>
        /// Gets or sets the StrategyProperties.
        /// </summary>
        [DataMember]
        public SyntheticStrategyProperties StrategyProperties { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>OrderStatus</returns>
        public OrderStatus Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">OrderStatus</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(OrderStatus other);
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
        /// <param name="other">OrderStatus</param>
        public Void MergeFrom(OrderStatus other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
