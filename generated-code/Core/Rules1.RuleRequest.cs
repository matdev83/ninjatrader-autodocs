[Serializable]
[DataContract]
namespace Rules1
{
    public partial class RuleRequest : IMessage<RuleRequest>, IMessage, IEquatable<RuleRequest>, IDeepCloneable<RuleRequest>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<RuleRequest> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the RequestId.
        /// </summary>
        [DataMember]
        public String RequestId { get; set; }
        /// <summary>
        /// Gets or sets the SetRuleRequest.
        /// </summary>
        [DataMember]
        public SetRuleRequest SetRuleRequest { get; set; }
        /// <summary>
        /// Gets or sets the DeleteRuleRequest.
        /// </summary>
        [DataMember]
        public DeleteRuleRequest DeleteRuleRequest { get; set; }
        /// <summary>
        /// Gets or sets the RulesListRequest.
        /// </summary>
        [DataMember]
        public RulesListRequest RulesListRequest { get; set; }
        /// <summary>
        /// Gets or sets the NotificationHistoryRequest.
        /// </summary>
        [DataMember]
        public NotificationHistoryRequest NotificationHistoryRequest { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>RuleRequest</returns>
        public RuleRequest Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">RuleRequest</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(RuleRequest other);
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
        /// <param name="other">RuleRequest</param>
        public Void MergeFrom(RuleRequest other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
