[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class TransactionStatus : IMessage<TransactionStatus>, IMessage, IEquatable<TransactionStatus>, IDeepCloneable<TransactionStatus>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<TransactionStatus> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the Status.
        /// </summary>
        [DataMember]
        public UInt32 Status { get; set; }
        /// <summary>
        /// Gets or sets the TransId.
        /// </summary>
        [DataMember]
        public UInt64 TransId { get; set; }
        /// <summary>
        /// Gets or sets the TransUtcTime.
        /// </summary>
        [DataMember]
        [Obsolete]
        public Int64 TransUtcTime { get; set; }
        /// <summary>
        /// Gets or sets the TransUtcTimestamp.
        /// </summary>
        [DataMember]
        public Timestamp TransUtcTimestamp { get; set; }
        /// <summary>
        /// Gets or sets the RefTransId.
        /// </summary>
        [DataMember]
        public UInt64 RefTransId { get; set; }
        /// <summary>
        /// Gets or sets the OrigClOrderId.
        /// </summary>
        [DataMember]
        public String OrigClOrderId { get; set; }
        /// <summary>
        /// Gets or sets the ClOrderId.
        /// </summary>
        [DataMember]
        public String ClOrderId { get; set; }
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
        /// Gets or sets the FillPrice.
        /// </summary>
        [DataMember]
        public Int64 FillPrice { get; set; }
        /// <summary>
        /// Gets or sets the Trade.
        /// </summary>
        [DataMember]
        public RepeatedField<Trade> Trade { get; set; }
        /// <summary>
        /// Gets or sets the StrategyLegFills.
        /// </summary>
        [DataMember]
        public RepeatedField<StrategyLegFill> StrategyLegFills { get; set; }
        /// <summary>
        /// Gets or sets the SyntheticHang.
        /// </summary>
        [DataMember]
        public SyntheticHang SyntheticHang { get; set; }
        /// <summary>
        /// Gets or sets the Uint32PrevOrderQty.
        /// </summary>
        [DataMember]
        [Obsolete]
        public UInt32 Uint32PrevOrderQty { get; set; }
        /// <summary>
        /// Gets or sets the PrevOrderQty.
        /// </summary>
        [DataMember]
        public Decimal PrevOrderQty { get; set; }
        /// <summary>
        /// Gets or sets the Uint32OrderQty.
        /// </summary>
        [DataMember]
        [Obsolete]
        public UInt32 Uint32OrderQty { get; set; }
        /// <summary>
        /// Gets or sets the OrderQty.
        /// </summary>
        [DataMember]
        public Decimal OrderQty { get; set; }
        /// <summary>
        /// Gets or sets the PrevLimitPrice.
        /// </summary>
        [DataMember]
        public Int64 PrevLimitPrice { get; set; }
        /// <summary>
        /// Gets or sets the LimitPrice.
        /// </summary>
        [DataMember]
        public Int64 LimitPrice { get; set; }
        /// <summary>
        /// Gets or sets the PrevStopPrice.
        /// </summary>
        [DataMember]
        public Int64 PrevStopPrice { get; set; }
        /// <summary>
        /// Gets or sets the StopPrice.
        /// </summary>
        [DataMember]
        public Int64 StopPrice { get; set; }
        /// <summary>
        /// Gets or sets the Uint32PrevVisibleQty.
        /// </summary>
        [DataMember]
        [Obsolete]
        public UInt32 Uint32PrevVisibleQty { get; set; }
        /// <summary>
        /// Gets or sets the PrevVisibleQty.
        /// </summary>
        [DataMember]
        public Decimal PrevVisibleQty { get; set; }
        /// <summary>
        /// Gets or sets the Uint32VisibleQty.
        /// </summary>
        [DataMember]
        [Obsolete]
        public UInt32 Uint32VisibleQty { get; set; }
        /// <summary>
        /// Gets or sets the VisibleQty.
        /// </summary>
        [DataMember]
        public Decimal VisibleQty { get; set; }
        /// <summary>
        /// Gets or sets the Uint32PrevMinVisibleQty.
        /// </summary>
        [DataMember]
        [Obsolete]
        public UInt32 Uint32PrevMinVisibleQty { get; set; }
        /// <summary>
        /// Gets or sets the PrevMinVisibleQty.
        /// </summary>
        [DataMember]
        public Decimal PrevMinVisibleQty { get; set; }
        /// <summary>
        /// Gets or sets the Uint32MinVisibleQty.
        /// </summary>
        [DataMember]
        [Obsolete]
        public UInt32 Uint32MinVisibleQty { get; set; }
        /// <summary>
        /// Gets or sets the MinVisibleQty.
        /// </summary>
        [DataMember]
        public Decimal MinVisibleQty { get; set; }
        /// <summary>
        /// Gets or sets the Uint32PrevFillQty.
        /// </summary>
        [DataMember]
        [Obsolete]
        public UInt32 Uint32PrevFillQty { get; set; }
        /// <summary>
        /// Gets or sets the PrevFillQty.
        /// </summary>
        [DataMember]
        public Decimal PrevFillQty { get; set; }
        /// <summary>
        /// Gets or sets the PrevFillPrice.
        /// </summary>
        [DataMember]
        public Int64 PrevFillPrice { get; set; }
        /// <summary>
        /// Gets or sets the PrevOrderType.
        /// </summary>
        [DataMember]
        public UInt32 PrevOrderType { get; set; }
        /// <summary>
        /// Gets or sets the OrderType.
        /// </summary>
        [DataMember]
        public UInt32 OrderType { get; set; }
        /// <summary>
        /// Gets or sets the PrevExecInstruction.
        /// </summary>
        [DataMember]
        public RepeatedField<UInt32> PrevExecInstruction { get; set; }
        /// <summary>
        /// Gets or sets the ExecInstruction.
        /// </summary>
        [DataMember]
        public RepeatedField<UInt32> ExecInstruction { get; set; }
        /// <summary>
        /// Gets or sets the PrevDuration.
        /// </summary>
        [DataMember]
        public UInt32 PrevDuration { get; set; }
        /// <summary>
        /// Gets or sets the Duration.
        /// </summary>
        [DataMember]
        public UInt32 Duration { get; set; }
        /// <summary>
        /// Gets or sets the PrevGoodThruDate.
        /// </summary>
        [DataMember]
        public Int64 PrevGoodThruDate { get; set; }
        /// <summary>
        /// Gets or sets the GoodThruDate.
        /// </summary>
        [DataMember]
        public Int64 GoodThruDate { get; set; }
        /// <summary>
        /// Gets or sets the RejectCode.
        /// </summary>
        [DataMember]
        public UInt32 RejectCode { get; set; }
        /// <summary>
        /// Gets or sets the FillCounterparty.
        /// </summary>
        [DataMember]
        public String FillCounterparty { get; set; }
        /// <summary>
        /// Gets or sets the RouteClOrderId.
        /// </summary>
        [DataMember]
        public String RouteClOrderId { get; set; }
        /// <summary>
        /// Gets or sets the TextMessage.
        /// </summary>
        [DataMember]
        public String TextMessage { get; set; }
        /// <summary>
        /// Gets or sets the PrevGoodThruUtcTime.
        /// </summary>
        [DataMember]
        [Obsolete]
        public Int64 PrevGoodThruUtcTime { get; set; }
        /// <summary>
        /// Gets or sets the PrevGoodThruUtcTimestamp.
        /// </summary>
        [DataMember]
        public Timestamp PrevGoodThruUtcTimestamp { get; set; }
        /// <summary>
        /// Gets or sets the GoodThruUtcTime.
        /// </summary>
        [DataMember]
        [Obsolete]
        public Int64 GoodThruUtcTime { get; set; }
        /// <summary>
        /// Gets or sets the GoodThruUtcTimestamp.
        /// </summary>
        [DataMember]
        public Timestamp GoodThruUtcTimestamp { get; set; }
        /// <summary>
        /// Gets or sets the ClientRegulatoryAlgorithmId.
        /// </summary>
        [DataMember]
        public UInt32 ClientRegulatoryAlgorithmId { get; set; }
        /// <summary>
        /// Gets or sets the EffectiveRegulatoryAlgorithmId.
        /// </summary>
        [DataMember]
        public UInt32 EffectiveRegulatoryAlgorithmId { get; set; }
        /// <summary>
        /// Gets or sets the MifidAlgorithmId.
        /// </summary>
        [DataMember]
        public String MifidAlgorithmId { get; set; }
        /// <summary>
        /// Gets or sets the MifidAlgorithmIdType.
        /// </summary>
        [DataMember]
        public UInt32 MifidAlgorithmIdType { get; set; }
        /// <summary>
        /// Gets or sets the MifidAppliedAlgorithmId.
        /// </summary>
        [DataMember]
        public String MifidAppliedAlgorithmId { get; set; }
        /// <summary>
        /// Gets or sets the MifidAppliedAlgorithmIdType.
        /// </summary>
        [DataMember]
        public UInt32 MifidAppliedAlgorithmIdType { get; set; }
        /// <summary>
        /// Gets or sets the MifidExecutionDecision.
        /// </summary>
        [DataMember]
        public String MifidExecutionDecision { get; set; }
        /// <summary>
        /// Gets or sets the OpenCloseEffect.
        /// </summary>
        [DataMember]
        public UInt32 OpenCloseEffect { get; set; }
        /// <summary>
        /// Gets or sets the SpeculationType.
        /// </summary>
        [DataMember]
        public UInt32 SpeculationType { get; set; }
        /// <summary>
        /// Gets or sets the PrevDiscretionaryOffset.
        /// </summary>
        [DataMember]
        public UInt32 PrevDiscretionaryOffset { get; set; }
        /// <summary>
        /// Gets or sets the DiscretionaryOffset.
        /// </summary>
        [DataMember]
        public UInt32 DiscretionaryOffset { get; set; }
        /// <summary>
        /// Gets or sets the FillCommission.
        /// </summary>
        [DataMember]
        public Commission FillCommission { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>TransactionStatus</returns>
        public TransactionStatus Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">TransactionStatus</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(TransactionStatus other);
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
        /// <param name="other">TransactionStatus</param>
        public Void MergeFrom(TransactionStatus other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
