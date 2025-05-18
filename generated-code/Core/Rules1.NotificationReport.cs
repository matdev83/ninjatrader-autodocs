[Serializable]
[DataContract]
namespace Rules1
{
    public partial class NotificationReport : IMessage<NotificationReport>, IMessage, IEquatable<NotificationReport>, IDeepCloneable<NotificationReport>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<NotificationReport> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the Title.
        /// </summary>
        [DataMember]
        public Text Title { get; set; }
        /// <summary>
        /// Gets or sets the Body.
        /// </summary>
        [DataMember]
        public Text Body { get; set; }
        /// <summary>
        /// Gets or sets the RuleId.
        /// </summary>
        [DataMember]
        public String RuleId { get; set; }
        /// <summary>
        /// Gets or sets the NotificationProperty.
        /// </summary>
        [DataMember]
        public RepeatedField<NotificationProperty> NotificationProperty { get; set; }
        /// <summary>
        /// Gets or sets the WhenUtcTimestamp.
        /// </summary>
        [DataMember]
        public Timestamp WhenUtcTimestamp { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>NotificationReport</returns>
        public NotificationReport Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">NotificationReport</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(NotificationReport other);
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
        /// <param name="other">NotificationReport</param>
        public Void MergeFrom(NotificationReport other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
