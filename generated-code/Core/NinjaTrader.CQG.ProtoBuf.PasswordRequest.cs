[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class PasswordRequest : IMessage<PasswordRequest>, IMessage, IEquatable<PasswordRequest>, IDeepCloneable<PasswordRequest>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<PasswordRequest> Parser { get; set; }
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
        /// Gets or sets the PasswordType.
        /// </summary>
        [DataMember]
        public UInt32 PasswordType { get; set; }
        /// <summary>
        /// Gets or sets the UserPromptType.
        /// </summary>
        [DataMember]
        public String UserPromptType { get; set; }
        /// <summary>
        /// Gets or sets the UserPromptTypeAlt.
        /// </summary>
        [DataMember]
        public String UserPromptTypeAlt { get; set; }
        /// <summary>
        /// Gets or sets the UserPrompt.
        /// </summary>
        [DataMember]
        public String UserPrompt { get; set; }
        /// <summary>
        /// Gets or sets the Encoding.
        /// </summary>
        [DataMember]
        public RepeatedField<Encoding> Encoding { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>PasswordRequest</returns>
        public PasswordRequest Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">PasswordRequest</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(PasswordRequest other);
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
        /// <param name="other">PasswordRequest</param>
        public Void MergeFrom(PasswordRequest other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
