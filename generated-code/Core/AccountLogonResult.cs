[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class AccountLogonResult : IMessage<AccountLogonResult>, IMessage, IEquatable<AccountLogonResult>, IDeepCloneable<AccountLogonResult>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<AccountLogonResult> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the AccountId.
        /// </summary>
        [DataMember]
        public Int32 AccountId { get; set; }
        /// <summary>
        /// Gets or sets the ResultCode.
        /// </summary>
        [DataMember]
        public UInt32 ResultCode { get; set; }
        /// <summary>
        /// Gets or sets the TextMessage.
        /// </summary>
        [DataMember]
        public Text TextMessage { get; set; }
        /// <summary>
        /// Gets or sets the ServerUtcTimestamp.
        /// </summary>
        [DataMember]
        public Timestamp ServerUtcTimestamp { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>AccountLogonResult</returns>
        public AccountLogonResult Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">AccountLogonResult</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(AccountLogonResult other);
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
        /// <param name="other">AccountLogonResult</param>
        public Void MergeFrom(AccountLogonResult other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
