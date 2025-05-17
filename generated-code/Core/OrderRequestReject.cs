[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class OrderRequestReject : IMessage<OrderRequestReject>, IMessage, IEquatable<OrderRequestReject>, IDeepCloneable<OrderRequestReject>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<OrderRequestReject> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the RequestId.
        /// </summary>
        [DataMember]
        public UInt32 RequestId { get; set; }
        /// <summary>
        /// Gets or sets the RejectCode.
        /// </summary>
        [DataMember]
        public UInt32 RejectCode { get; set; }
        /// <summary>
        /// Gets or sets the TextMessage.
        /// </summary>
        [DataMember]
        public String TextMessage { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>OrderRequestReject</returns>
        public OrderRequestReject Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">OrderRequestReject</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(OrderRequestReject other);
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
        /// <param name="other">OrderRequestReject</param>
        public Void MergeFrom(OrderRequestReject other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
