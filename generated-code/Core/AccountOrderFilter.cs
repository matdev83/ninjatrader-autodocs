[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class AccountOrderFilter : IMessage<AccountOrderFilter>, IMessage, IEquatable<AccountOrderFilter>, IDeepCloneable<AccountOrderFilter>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<AccountOrderFilter> Parser { get; set; }
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
        /// Gets or sets the Mine.
        /// </summary>
        [DataMember]
        public Boolean Mine { get; set; }
        /// <summary>
        /// Gets or sets the Suspended.
        /// </summary>
        [DataMember]
        public Boolean Suspended { get; set; }
        /// <summary>
        /// Gets or sets the Side.
        /// </summary>
        [DataMember]
        public UInt32 Side { get; set; }
        /// <summary>
        /// Gets or sets the ContractId.
        /// </summary>
        [DataMember]
        public UInt32 ContractId { get; set; }
        /// <summary>
        /// Gets or sets the CurrentDayOnly.
        /// </summary>
        [DataMember]
        public Boolean CurrentDayOnly { get; set; }
        /// <summary>
        /// Gets or sets the MinePresentCase.
        /// </summary>
        [DataMember]
        public MinePresentOneofCase MinePresentCase { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>AccountOrderFilter</returns>
        public AccountOrderFilter Clone();
        /// <summary>
        /// ClearMinePresent method.
        /// </summary>
        public Void ClearMinePresent();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">AccountOrderFilter</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(AccountOrderFilter other);
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
        /// <param name="other">AccountOrderFilter</param>
        public Void MergeFrom(AccountOrderFilter other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
