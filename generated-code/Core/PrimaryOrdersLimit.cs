[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class PrimaryOrdersLimit : IMessage<PrimaryOrdersLimit>, IMessage, IEquatable<PrimaryOrdersLimit>, IDeepCloneable<PrimaryOrdersLimit>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<PrimaryOrdersLimit> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the Uint32MinQtyIncrement.
        /// </summary>
        [DataMember]
        [Obsolete]
        public UInt32 Uint32MinQtyIncrement { get; set; }
        /// <summary>
        /// Gets or sets the MinQtyIncrement.
        /// </summary>
        [DataMember]
        public Decimal MinQtyIncrement { get; set; }
        /// <summary>
        /// Gets or sets the QueueHoldersMinSize.
        /// </summary>
        [DataMember]
        public UInt32 QueueHoldersMinSize { get; set; }
        /// <summary>
        /// Gets or sets the QueueHoldersMaxSize.
        /// </summary>
        [DataMember]
        public UInt32 QueueHoldersMaxSize { get; set; }
        /// <summary>
        /// Gets or sets the QueueHoldersDistance.
        /// </summary>
        [DataMember]
        public UInt32 QueueHoldersDistance { get; set; }
        /// <summary>
        /// Gets or sets the OrderSizeRestoreThreshold.
        /// </summary>
        [DataMember]
        public UInt32 OrderSizeRestoreThreshold { get; set; }
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
        /// Gets or sets the WorkingOrdersPriceRange.
        /// </summary>
        [DataMember]
        public UInt32 WorkingOrdersPriceRange { get; set; }
        /// <summary>
        /// Gets or sets the MinPriceChange.
        /// </summary>
        [DataMember]
        public UInt32 MinPriceChange { get; set; }
        /// <summary>
        /// Gets or sets the PrimaryOrdersFifoQueueSize.
        /// </summary>
        [DataMember]
        public UInt32 PrimaryOrdersFifoQueueSize { get; set; }
        /// <summary>
        /// Gets or sets the ForceUpdatePeriod.
        /// </summary>
        [DataMember]
        public UInt32 ForceUpdatePeriod { get; set; }
        /// <summary>
        /// Gets or sets the IgnoreObservedMarkets.
        /// </summary>
        [DataMember]
        public Boolean IgnoreObservedMarkets { get; set; }
        /// <summary>
        /// Gets or sets the MaxDimming.
        /// </summary>
        [DataMember]
        public UInt32 MaxDimming { get; set; }
        /// <summary>
        /// Gets or sets the FarFromMarketMode.
        /// </summary>
        [DataMember]
        public UInt32 FarFromMarketMode { get; set; }
        /// <summary>
        /// Gets or sets the TicksAwayToWork.
        /// </summary>
        [DataMember]
        public Int32 TicksAwayToWork { get; set; }
        /// <summary>
        /// Gets or sets the DomUsage.
        /// </summary>
        [DataMember]
        public UInt32 DomUsage { get; set; }
        /// <summary>
        /// Gets or sets the DomMultilevelQty.
        /// </summary>
        [DataMember]
        public UInt32 DomMultilevelQty { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>PrimaryOrdersLimit</returns>
        public PrimaryOrdersLimit Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">PrimaryOrdersLimit</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(PrimaryOrdersLimit other);
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
        /// <param name="other">PrimaryOrdersLimit</param>
        public Void MergeFrom(PrimaryOrdersLimit other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
