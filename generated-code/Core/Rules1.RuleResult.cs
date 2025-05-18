[Serializable]
[DataContract]
namespace Rules1
{
    public partial class RuleResult : IMessage<RuleResult>, IMessage, IEquatable<RuleResult>, IDeepCloneable<RuleResult>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<RuleResult> Parser { get; set; }
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
        /// Gets or sets the ResultCode.
        /// </summary>
        [DataMember]
        public UInt32 ResultCode { get; set; }
        /// <summary>
        /// Gets or sets the Details.
        /// </summary>
        [DataMember]
        public Text Details { get; set; }
        /// <summary>
        /// Gets or sets the SetRuleResult.
        /// </summary>
        [DataMember]
        public SetRuleResult SetRuleResult { get; set; }
        /// <summary>
        /// Gets or sets the DeleteRuleResult.
        /// </summary>
        [DataMember]
        public DeleteRuleResult DeleteRuleResult { get; set; }
        /// <summary>
        /// Gets or sets the RulesListResult.
        /// </summary>
        [DataMember]
        public RulesListResult RulesListResult { get; set; }
        /// <summary>
        /// Gets or sets the NotificationHistoryResult.
        /// </summary>
        [DataMember]
        public NotificationHistoryResult NotificationHistoryResult { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>RuleResult</returns>
        public RuleResult Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">RuleResult</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(RuleResult other);
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
        /// <param name="other">RuleResult</param>
        public Void MergeFrom(RuleResult other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
