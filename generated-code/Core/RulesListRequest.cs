[Serializable]
[DataContract]
namespace Rules1
{
    public partial class RulesListRequest : IMessage<RulesListRequest>, IMessage, IEquatable<RulesListRequest>, IDeepCloneable<RulesListRequest>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<RulesListRequest> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the RuleTag.
        /// </summary>
        [DataMember]
        [Obsolete]
        public RepeatedField<String> RuleTag { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>RulesListRequest</returns>
        public RulesListRequest Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">RulesListRequest</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(RulesListRequest other);
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
        /// <param name="other">RulesListRequest</param>
        public Void MergeFrom(RulesListRequest other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
