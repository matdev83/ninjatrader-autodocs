[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class TradeSnapshotCompletion : IMessage<TradeSnapshotCompletion>, IMessage, IEquatable<TradeSnapshotCompletion>, IDeepCloneable<TradeSnapshotCompletion>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<TradeSnapshotCompletion> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the SubscriptionId.
        /// </summary>
        [DataMember]
        public UInt32 SubscriptionId { get; set; }
        /// <summary>
        /// Gets or sets the SubscriptionScope.
        /// </summary>
        [DataMember]
        public RepeatedField<UInt32> SubscriptionScope { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>TradeSnapshotCompletion</returns>
        public TradeSnapshotCompletion Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">TradeSnapshotCompletion</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(TradeSnapshotCompletion other);
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
        /// <param name="other">TradeSnapshotCompletion</param>
        public Void MergeFrom(TradeSnapshotCompletion other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
