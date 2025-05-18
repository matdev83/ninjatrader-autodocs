[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class LogonRoutineClient : IMessage<LogonRoutineClient>, IMessage, IEquatable<LogonRoutineClient>, IDeepCloneable<LogonRoutineClient>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<LogonRoutineClient> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the LogonInit.
        /// </summary>
        [DataMember]
        public LogonInit LogonInit { get; set; }
        /// <summary>
        /// Gets or sets the PasswordResponse.
        /// </summary>
        [DataMember]
        public RepeatedField<PasswordResponse> PasswordResponse { get; set; }
        /// <summary>
        /// Gets or sets the TraderAgreementAccepted.
        /// </summary>
        [DataMember]
        public Boolean TraderAgreementAccepted { get; set; }
        /// <summary>
        /// Gets or sets the AbortLogon.
        /// </summary>
        [DataMember]
        public AbortRoutine AbortLogon { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>LogonRoutineClient</returns>
        public LogonRoutineClient Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">LogonRoutineClient</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(LogonRoutineClient other);
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
        /// <param name="other">LogonRoutineClient</param>
        public Void MergeFrom(LogonRoutineClient other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
