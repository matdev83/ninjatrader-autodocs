[Serializable]
[DataContract]
namespace Rules1
{
    public partial class NotificationHistoryRequest : IMessage<NotificationHistoryRequest>, IMessage, IEquatable<NotificationHistoryRequest>, IDeepCloneable<NotificationHistoryRequest>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<NotificationHistoryRequest> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the FromUtcTimestamp.
        /// </summary>
        [DataMember]
        public Timestamp FromUtcTimestamp { get; set; }
        /// <summary>
        /// Gets or sets the ToUtcTimestamp.
        /// </summary>
        [DataMember]
        public Timestamp ToUtcTimestamp { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>NotificationHistoryRequest</returns>
        public NotificationHistoryRequest Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">NotificationHistoryRequest</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(NotificationHistoryRequest other);
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
        /// <param name="other">NotificationHistoryRequest</param>
        public Void MergeFrom(NotificationHistoryRequest other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
