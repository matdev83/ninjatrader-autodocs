[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class RestoreOrJoinSessionResult : IMessage<RestoreOrJoinSessionResult>, IMessage, IEquatable<RestoreOrJoinSessionResult>, IDeepCloneable<RestoreOrJoinSessionResult>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<RestoreOrJoinSessionResult> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the ResultCode.
        /// </summary>
        [DataMember]
        public UInt32 ResultCode { get; set; }
        /// <summary>
        /// Gets or sets the BaseTime.
        /// </summary>
        [DataMember]
        public String BaseTime { get; set; }
        /// <summary>
        /// Gets or sets the TextMessage.
        /// </summary>
        [DataMember]
        public String TextMessage { get; set; }
        /// <summary>
        /// Gets or sets the ServerTime.
        /// </summary>
        [DataMember]
        public Int64 ServerTime { get; set; }
        /// <summary>
        /// Gets or sets the DialectId.
        /// </summary>
        [DataMember]
        public String DialectId { get; set; }
        /// <summary>
        /// Gets or sets the InactivityTimeout.
        /// </summary>
        [DataMember]
        public UInt32 InactivityTimeout { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>RestoreOrJoinSessionResult</returns>
        public RestoreOrJoinSessionResult Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">RestoreOrJoinSessionResult</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(RestoreOrJoinSessionResult other);
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
        /// <param name="other">RestoreOrJoinSessionResult</param>
        public Void MergeFrom(RestoreOrJoinSessionResult other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
