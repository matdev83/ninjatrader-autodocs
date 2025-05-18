[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class Order : IMessage<Order>, IMessage, IEquatable<Order>, IDeepCloneable<Order>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<Order> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the AccountId.
        /// </summary>
        [DataMember]
        public Int32 AccountId { get; set; }
        /// <summary>
        /// Gets or sets the WhenUtcTime.
        /// </summary>
        [DataMember]
        [Obsolete]
        public Int64 WhenUtcTime { get; set; }
        /// <summary>
        /// Gets or sets the WhenUtcTimestamp.
        /// </summary>
        [DataMember]
        public Timestamp WhenUtcTimestamp { get; set; }
        /// <summary>
        /// Gets or sets the ContractId.
        /// </summary>
        [DataMember]
        public UInt32 ContractId { get; set; }
        /// <summary>
        /// Gets or sets the ClOrderId.
        /// </summary>
        [DataMember]
        public String ClOrderId { get; set; }
        /// <summary>
        /// Gets or sets the OrderType.
        /// </summary>
        [DataMember]
        public UInt32 OrderType { get; set; }
        /// <summary>
        /// Gets or sets the ExecInstruction.
        /// </summary>
        [DataMember]
        public RepeatedField<UInt32> ExecInstruction { get; set; }
        /// <summary>
        /// Gets or sets the Duration.
        /// </summary>
        [DataMember]
        public UInt32 Duration { get; set; }
        /// <summary>
        /// Gets or sets the GoodThruDate.
        /// </summary>
        [DataMember]
        public Int64 GoodThruDate { get; set; }
        /// <summary>
        /// Gets or sets the Side.
        /// </summary>
        [DataMember]
        public UInt32 Side { get; set; }
        /// <summary>
        /// Gets or sets the LimitPrice.
        /// </summary>
        [DataMember]
        public Int64 LimitPrice { get; set; }
        /// <summary>
        /// Gets or sets the StopPrice.
        /// </summary>
        [DataMember]
        public Int64 StopPrice { get; set; }
        /// <summary>
        /// Gets or sets the Uint32Qty.
        /// </summary>
        [DataMember]
        [Obsolete]
        public UInt32 Uint32Qty { get; set; }
        /// <summary>
        /// Gets or sets the Uint32VisibleQty.
        /// </summary>
        [DataMember]
        [Obsolete]
        public UInt32 Uint32VisibleQty { get; set; }
        /// <summary>
        /// Gets or sets the Uint32MinVisibleQty.
        /// </summary>
        [DataMember]
        [Obsolete]
        public UInt32 Uint32MinVisibleQty { get; set; }
        /// <summary>
        /// Gets or sets the Qty.
        /// </summary>
        [DataMember]
        public Decimal Qty { get; set; }
        /// <summary>
        /// Gets or sets the VisibleQty.
        /// </summary>
        [DataMember]
        public Decimal VisibleQty { get; set; }
        /// <summary>
        /// Gets or sets the MinVisibleQty.
        /// </summary>
        [DataMember]
        public Decimal MinVisibleQty { get; set; }
        /// <summary>
        /// Gets or sets the IsManual.
        /// </summary>
        [DataMember]
        public Boolean IsManual { get; set; }
        /// <summary>
        /// Gets or sets the IsClose.
        /// </summary>
        [DataMember]
        [Obsolete]
        public Boolean IsClose { get; set; }
        /// <summary>
        /// Gets or sets the IsAggressive.
        /// </summary>
        [DataMember]
        public Boolean IsAggressive { get; set; }
        /// <summary>
        /// Gets or sets the TrailOffset.
        /// </summary>
        [DataMember]
        public Int32 TrailOffset { get; set; }
        /// <summary>
        /// Gets or sets the TrailingPeg.
        /// </summary>
        [DataMember]
        public UInt32 TrailingPeg { get; set; }
        /// <summary>
        /// Gets or sets the Uint32TriggerQty.
        /// </summary>
        [DataMember]
        [Obsolete]
        public UInt32 Uint32TriggerQty { get; set; }
        /// <summary>
        /// Gets or sets the TriggerQty.
        /// </summary>
        [DataMember]
        public Decimal TriggerQty { get; set; }
        /// <summary>
        /// Gets or sets the ActivationUtcTime.
        /// </summary>
        [DataMember]
        [Obsolete]
        public Int64 ActivationUtcTime { get; set; }
        /// <summary>
        /// Gets or sets the ActivationUtcTimestamp.
        /// </summary>
        [DataMember]
        public Timestamp ActivationUtcTimestamp { get; set; }
        /// <summary>
        /// Gets or sets the SuspensionUtcTime.
        /// </summary>
        [DataMember]
        [Obsolete]
        public Int64 SuspensionUtcTime { get; set; }
        /// <summary>
        /// Gets or sets the SuspensionUtcTimestamp.
        /// </summary>
        [DataMember]
        public Timestamp SuspensionUtcTimestamp { get; set; }
        /// <summary>
        /// Gets or sets the UserAttribute.
        /// </summary>
        [DataMember]
        public RepeatedField<UserAttribute> UserAttribute { get; set; }
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
        /// Gets or sets the IsUserAttributeChecked.
        /// </summary>
        [DataMember]
        public Boolean IsUserAttributeChecked { get; set; }
        /// <summary>
        /// Gets or sets the StrategyTradingParameters.
        /// </summary>
        [DataMember]
        public StrategyTradingParameters StrategyTradingParameters { get; set; }
        /// <summary>
        /// Gets or sets the OpenCloseInstruction.
        /// </summary>
        [DataMember]
        public UInt32 OpenCloseInstruction { get; set; }
        /// <summary>
        /// Gets or sets the SpeculationType.
        /// </summary>
        [DataMember]
        public UInt32 SpeculationType { get; set; }
        /// <summary>
        /// Gets or sets the DiscretionaryOffset.
        /// </summary>
        [DataMember]
        public UInt32 DiscretionaryOffset { get; set; }
        /// <summary>
        /// Gets or sets the IsManualPresentCase.
        /// </summary>
        [DataMember]
        public IsManualPresentOneofCase IsManualPresentCase { get; set; }
        /// <summary>
        /// Gets or sets the IsUserAttributeCheckedPresentCase.
        /// </summary>
        [DataMember]
        public IsUserAttributeCheckedPresentOneofCase IsUserAttributeCheckedPresentCase { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>Order</returns>
        public Order Clone();
        /// <summary>
        /// ClearIsManualPresent method.
        /// </summary>
        public Void ClearIsManualPresent();
        /// <summary>
        /// ClearIsUserAttributeCheckedPresent method.
        /// </summary>
        public Void ClearIsUserAttributeCheckedPresent();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Order</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Order other);
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
        /// <param name="other">Order</param>
        public Void MergeFrom(Order other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
