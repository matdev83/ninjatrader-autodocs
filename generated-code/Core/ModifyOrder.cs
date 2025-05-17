[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class ModifyOrder : IMessage<ModifyOrder>, IMessage, IEquatable<ModifyOrder>, IDeepCloneable<ModifyOrder>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<ModifyOrder> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the OrderId.
        /// </summary>
        [DataMember]
        public String OrderId { get; set; }
        /// <summary>
        /// Gets or sets the AccountId.
        /// </summary>
        [DataMember]
        public Int32 AccountId { get; set; }
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
        /// Gets or sets the RemoveActivationTime.
        /// </summary>
        [DataMember]
        public Boolean RemoveActivationTime { get; set; }
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
        /// Gets or sets the RemoveSuspensionUtcTime.
        /// </summary>
        [DataMember]
        public Boolean RemoveSuspensionUtcTime { get; set; }
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
        /// Gets or sets the DiscretionaryOffset.
        /// </summary>
        [DataMember]
        public UInt32 DiscretionaryOffset { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>ModifyOrder</returns>
        public ModifyOrder Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">ModifyOrder</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(ModifyOrder other);
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
        /// <param name="other">ModifyOrder</param>
        public Void MergeFrom(ModifyOrder other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
