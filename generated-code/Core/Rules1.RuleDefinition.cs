[Serializable]
[DataContract]
namespace Rules1
{
    public partial class RuleDefinition : IMessage<RuleDefinition>, IMessage, IEquatable<RuleDefinition>, IDeepCloneable<RuleDefinition>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<RuleDefinition> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the RuleId.
        /// </summary>
        [DataMember]
        public String RuleId { get; set; }
        /// <summary>
        /// Gets or sets the RuleTag.
        /// </summary>
        [DataMember]
        [Obsolete]
        public RepeatedField<String> RuleTag { get; set; }
        /// <summary>
        /// Gets or sets the ExpirationUtcTimestamp.
        /// </summary>
        [DataMember]
        [Obsolete]
        public Timestamp ExpirationUtcTimestamp { get; set; }
        /// <summary>
        /// Gets or sets the Action.
        /// </summary>
        [DataMember]
        public RepeatedField<Action> Action { get; set; }
        /// <summary>
        /// Gets or sets the OrderEventRule.
        /// </summary>
        [DataMember]
        public OrderEventRule OrderEventRule { get; set; }
        /// <summary>
        /// Gets or sets the Enabled.
        /// </summary>
        [DataMember]
        public Boolean Enabled { get; set; }
        /// <summary>
        /// Gets or sets the EnabledPresentCase.
        /// </summary>
        [DataMember]
        public EnabledPresentOneofCase EnabledPresentCase { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>RuleDefinition</returns>
        public RuleDefinition Clone();
        /// <summary>
        /// ClearEnabledPresent method.
        /// </summary>
        public Void ClearEnabledPresent();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">RuleDefinition</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(RuleDefinition other);
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
        /// <param name="other">RuleDefinition</param>
        public Void MergeFrom(RuleDefinition other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
