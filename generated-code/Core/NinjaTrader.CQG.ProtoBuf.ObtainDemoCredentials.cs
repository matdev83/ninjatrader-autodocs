[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class ObtainDemoCredentials : IMessage<ObtainDemoCredentials>, IMessage, IEquatable<ObtainDemoCredentials>, IDeepCloneable<ObtainDemoCredentials>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<ObtainDemoCredentials> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the ClientAppId.
        /// </summary>
        [DataMember]
        public String ClientAppId { get; set; }
        /// <summary>
        /// Gets or sets the FirstName.
        /// </summary>
        [DataMember]
        public String FirstName { get; set; }
        /// <summary>
        /// Gets or sets the SecondName.
        /// </summary>
        [DataMember]
        public String SecondName { get; set; }
        /// <summary>
        /// Gets or sets the EMail.
        /// </summary>
        [DataMember]
        public String EMail { get; set; }
        /// <summary>
        /// Gets or sets the PrivateLabel.
        /// </summary>
        [DataMember]
        public String PrivateLabel { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>ObtainDemoCredentials</returns>
        public ObtainDemoCredentials Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">ObtainDemoCredentials</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(ObtainDemoCredentials other);
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
        /// <param name="other">ObtainDemoCredentials</param>
        public Void MergeFrom(ObtainDemoCredentials other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
