[Serializable]
[DataContract]
namespace Rules1
{
    public partial class OrderEventRule : IMessage<OrderEventRule>, IMessage, IEquatable<OrderEventRule>, IDeepCloneable<OrderEventRule>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<OrderEventRule> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the AccountId.
        /// </summary>
        [DataMember]
        public RepeatedField<Int32> AccountId { get; set; }
        /// <summary>
        /// Gets or sets the OrderStatus.
        /// </summary>
        [DataMember]
        public RepeatedField<UInt32> OrderStatus { get; set; }
        /// <summary>
        /// Gets or sets the TransactionStatus.
        /// </summary>
        [DataMember]
        public RepeatedField<UInt32> TransactionStatus { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>OrderEventRule</returns>
        public OrderEventRule Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">OrderEventRule</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(OrderEventRule other);
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
        /// <param name="other">OrderEventRule</param>
        public Void MergeFrom(OrderEventRule other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
