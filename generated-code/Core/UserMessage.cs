[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class UserMessage : IMessage<UserMessage>, IMessage, IEquatable<UserMessage>, IDeepCloneable<UserMessage>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<UserMessage> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the MessageType.
        /// </summary>
        [DataMember]
        public UInt32 MessageType { get; set; }
        /// <summary>
        /// Gets or sets the Source.
        /// </summary>
        [DataMember]
        public String Source { get; set; }
        /// <summary>
        /// Gets or sets the Subject.
        /// </summary>
        [DataMember]
        public String Subject { get; set; }
        /// <summary>
        /// Gets or sets the Text.
        /// </summary>
        [DataMember]
        public String Text { get; set; }
        /// <summary>
        /// Gets or sets the ExpirationUtcTime.
        /// </summary>
        [DataMember]
        public Int64 ExpirationUtcTime { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>UserMessage</returns>
        public UserMessage Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">UserMessage</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(UserMessage other);
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
        /// <param name="other">UserMessage</param>
        public Void MergeFrom(UserMessage other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
