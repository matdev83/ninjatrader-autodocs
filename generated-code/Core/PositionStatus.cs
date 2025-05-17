[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class PositionStatus : IMessage<PositionStatus>, IMessage, IEquatable<PositionStatus>, IDeepCloneable<PositionStatus>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<PositionStatus> Parser { get; set; }
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
        /// Gets or sets the AccountId.
        /// </summary>
        [DataMember]
        public Int32 AccountId { get; set; }
        /// <summary>
        /// Gets or sets the ContractId.
        /// </summary>
        [DataMember]
        public UInt32 ContractId { get; set; }
        /// <summary>
        /// Gets or sets the IsShortOpenPosition.
        /// </summary>
        [DataMember]
        [Obsolete]
        public Boolean IsShortOpenPosition { get; set; }
        /// <summary>
        /// Gets or sets the OpenPosition.
        /// </summary>
        [DataMember]
        public RepeatedField<OpenPosition> OpenPosition { get; set; }
        /// <summary>
        /// Gets or sets the PurchaseAndSalesGroup.
        /// </summary>
        [DataMember]
        public RepeatedField<PurchaseAndSalesGroup> PurchaseAndSalesGroup { get; set; }
        /// <summary>
        /// Gets or sets the ContractMetadata.
        /// </summary>
        [DataMember]
        public ContractMetadata ContractMetadata { get; set; }
        /// <summary>
        /// Gets or sets the TodayFillCommission.
        /// </summary>
        [DataMember]
        public RepeatedField<Commission> TodayFillCommission { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>PositionStatus</returns>
        public PositionStatus Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">PositionStatus</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(PositionStatus other);
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
        /// <param name="other">PositionStatus</param>
        public Void MergeFrom(PositionStatus other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
