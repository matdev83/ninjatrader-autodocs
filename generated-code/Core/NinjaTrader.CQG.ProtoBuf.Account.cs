[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class Account : IMessage<Account>, IMessage, IEquatable<Account>, IDeepCloneable<Account>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<Account> Parser { get; set; }
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
        /// Gets or sets the BrokerageAccountId.
        /// </summary>
        [DataMember]
        public String BrokerageAccountId { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public String Name { get; set; }
        /// <summary>
        /// Gets or sets the LastStatementDate.
        /// </summary>
        [DataMember]
        public Int64 LastStatementDate { get; set; }
        /// <summary>
        /// Gets or sets the IsViewOnly.
        /// </summary>
        [DataMember]
        public Boolean IsViewOnly { get; set; }
        /// <summary>
        /// Gets or sets the IsUnauthorized.
        /// </summary>
        [DataMember]
        public Boolean IsUnauthorized { get; set; }
        /// <summary>
        /// Gets or sets the AccountClusterId.
        /// </summary>
        [DataMember]
        public Int64 AccountClusterId { get; set; }
        /// <summary>
        /// Gets or sets the AccountConnectionStatus.
        /// </summary>
        [DataMember]
        public UInt32 AccountConnectionStatus { get; set; }
        /// <summary>
        /// Gets or sets the AccountConnectionStatusUtcTimestamp.
        /// </summary>
        [DataMember]
        public Timestamp AccountConnectionStatusUtcTimestamp { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>Account</returns>
        public Account Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Account</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Account other);
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
        /// <param name="other">Account</param>
        public Void MergeFrom(Account other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
