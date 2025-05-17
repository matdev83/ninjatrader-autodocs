[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class PasswordChangeRoutineClient : IMessage<PasswordChangeRoutineClient>, IMessage, IEquatable<PasswordChangeRoutineClient>, IDeepCloneable<PasswordChangeRoutineClient>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<PasswordChangeRoutineClient> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the InitPasswordChange.
        /// </summary>
        [DataMember]
        public Boolean InitPasswordChange { get; set; }
        /// <summary>
        /// Gets or sets the PasswordResponse.
        /// </summary>
        [DataMember]
        public RepeatedField<PasswordResponse> PasswordResponse { get; set; }
        /// <summary>
        /// Gets or sets the AbortPasswordChange.
        /// </summary>
        [DataMember]
        public AbortRoutine AbortPasswordChange { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>PasswordChangeRoutineClient</returns>
        public PasswordChangeRoutineClient Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">PasswordChangeRoutineClient</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(PasswordChangeRoutineClient other);
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
        /// <param name="other">PasswordChangeRoutineClient</param>
        public Void MergeFrom(PasswordChangeRoutineClient other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
