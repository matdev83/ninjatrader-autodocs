[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class UserSessionStateResult : IMessage<UserSessionStateResult>, IMessage, IEquatable<UserSessionStateResult>, IDeepCloneable<UserSessionStateResult>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<UserSessionStateResult> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the SessionToken.
        /// </summary>
        [DataMember]
        public String SessionToken { get; set; }
        /// <summary>
        /// Gets or sets the ResultCode.
        /// </summary>
        [DataMember]
        public UInt32 ResultCode { get; set; }
        /// <summary>
        /// Gets or sets the UserId.
        /// </summary>
        [DataMember]
        public Int32 UserId { get; set; }
        /// <summary>
        /// Gets or sets the Username.
        /// </summary>
        [DataMember]
        public String Username { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>UserSessionStateResult</returns>
        public UserSessionStateResult Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">UserSessionStateResult</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(UserSessionStateResult other);
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
        /// <param name="other">UserSessionStateResult</param>
        public Void MergeFrom(UserSessionStateResult other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
