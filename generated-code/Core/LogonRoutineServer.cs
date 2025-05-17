[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class LogonRoutineServer : IMessage<LogonRoutineServer>, IMessage, IEquatable<LogonRoutineServer>, IDeepCloneable<LogonRoutineServer>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<LogonRoutineServer> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the LogonResult.
        /// </summary>
        [DataMember]
        public LogonResult LogonResult { get; set; }
        /// <summary>
        /// Gets or sets the PasswordRequest.
        /// </summary>
        [DataMember]
        public RepeatedField<PasswordRequest> PasswordRequest { get; set; }
        /// <summary>
        /// Gets or sets the TraderAgreementUrl.
        /// </summary>
        [DataMember]
        public String TraderAgreementUrl { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>LogonRoutineServer</returns>
        public LogonRoutineServer Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">LogonRoutineServer</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(LogonRoutineServer other);
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
        /// <param name="other">LogonRoutineServer</param>
        public Void MergeFrom(LogonRoutineServer other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
