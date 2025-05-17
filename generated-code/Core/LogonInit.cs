[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class LogonInit : IMessage<LogonInit>, IMessage, IEquatable<LogonInit>, IDeepCloneable<LogonInit>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<LogonInit> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the UserName.
        /// </summary>
        [DataMember]
        public String UserName { get; set; }
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
        /// Gets or sets the ClientVersion.
        /// </summary>
        [DataMember]
        public String ClientVersion { get; set; }
        /// <summary>
        /// Gets or sets the DropConcurrentSession.
        /// </summary>
        [DataMember]
        public Boolean DropConcurrentSession { get; set; }
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
        /// Gets or sets the SessionSettings.
        /// </summary>
        [DataMember]
        public RepeatedField<UInt32> SessionSettings { get; set; }
        /// <summary>
        /// Gets or sets the Bandwidth.
        /// </summary>
        [DataMember]
        public UInt32 Bandwidth { get; set; }
        /// <summary>
        /// Gets or sets the DialectId.
        /// </summary>
        [DataMember]
        public String DialectId { get; set; }
        /// <summary>
        /// Gets or sets the Fingerprint.
        /// </summary>
        [DataMember]
        public String Fingerprint { get; set; }
        /// <summary>
        /// Gets or sets the OperatingSystem.
        /// </summary>
        [DataMember]
        public String OperatingSystem { get; set; }
        /// <summary>
        /// Gets or sets the Browser.
        /// </summary>
        [DataMember]
        public String Browser { get; set; }
        /// <summary>
        /// Gets or sets the DeviceModel.
        /// </summary>
        [DataMember]
        public String DeviceModel { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>LogonInit</returns>
        public LogonInit Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">LogonInit</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(LogonInit other);
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
        /// <param name="other">LogonInit</param>
        public Void MergeFrom(LogonInit other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
