[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class LogonResult : IMessage<LogonResult>, IMessage, IEquatable<LogonResult>, IDeepCloneable<LogonResult>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<LogonResult> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the ResultCode.
        /// </summary>
        [DataMember]
        public UInt32 ResultCode { get; set; }
        /// <summary>
        /// Gets or sets the BaseTime.
        /// </summary>
        [DataMember]
        public String BaseTime { get; set; }
        /// <summary>
        /// Gets or sets the SessionToken.
        /// </summary>
        [DataMember]
        public String SessionToken { get; set; }
        /// <summary>
        /// Gets or sets the TextMessage.
        /// </summary>
        [DataMember]
        public String TextMessage { get; set; }
        /// <summary>
        /// Gets or sets the RedirectUrl.
        /// </summary>
        [DataMember]
        public String RedirectUrl { get; set; }
        /// <summary>
        /// Gets or sets the ProtocolVersionMinor.
        /// </summary>
        [DataMember]
        public UInt32 ProtocolVersionMinor { get; set; }
        /// <summary>
        /// Gets or sets the ProtocolVersionMajor.
        /// </summary>
        [DataMember]
        public UInt32 ProtocolVersionMajor { get; set; }
        /// <summary>
        /// Gets or sets the UserId.
        /// </summary>
        [DataMember]
        public Int32 UserId { get; set; }
        /// <summary>
        /// Gets or sets the ServerTime.
        /// </summary>
        [DataMember]
        public Int64 ServerTime { get; set; }
        /// <summary>
        /// Gets or sets the InactivityTimeout.
        /// </summary>
        [DataMember]
        public UInt32 InactivityTimeout { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>LogonResult</returns>
        public LogonResult Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">LogonResult</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(LogonResult other);
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
        /// <param name="other">LogonResult</param>
        public Void MergeFrom(LogonResult other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
