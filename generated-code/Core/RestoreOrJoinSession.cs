[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class RestoreOrJoinSession : IMessage<RestoreOrJoinSession>, IMessage, IEquatable<RestoreOrJoinSession>, IDeepCloneable<RestoreOrJoinSession>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<RestoreOrJoinSession> Parser { get; set; }
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
        /// Gets or sets the PrivateLabel.
        /// </summary>
        [DataMember]
        public String PrivateLabel { get; set; }
        /// <summary>
        /// Gets or sets the ClientAppId.
        /// </summary>
        [DataMember]
        public String ClientAppId { get; set; }
        /// <summary>
        /// Gets or sets the CollapsingLevel.
        /// </summary>
        [DataMember]
        public UInt32 CollapsingLevel { get; set; }
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
        /// Gets or sets the Bandwidth.
        /// </summary>
        [DataMember]
        public UInt32 Bandwidth { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>RestoreOrJoinSession</returns>
        public RestoreOrJoinSession Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">RestoreOrJoinSession</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(RestoreOrJoinSession other);
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
        /// <param name="other">RestoreOrJoinSession</param>
        public Void MergeFrom(RestoreOrJoinSession other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
