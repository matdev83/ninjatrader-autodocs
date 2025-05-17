[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class PasswordChangeRoutineServer : IMessage<PasswordChangeRoutineServer>, IMessage, IEquatable<PasswordChangeRoutineServer>, IDeepCloneable<PasswordChangeRoutineServer>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<PasswordChangeRoutineServer> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the PasswordRequest.
        /// </summary>
        [DataMember]
        public RepeatedField<PasswordRequest> PasswordRequest { get; set; }
        /// <summary>
        /// Gets or sets the PasswordChangeResult.
        /// </summary>
        [DataMember]
        public PasswordChangeResult PasswordChangeResult { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>PasswordChangeRoutineServer</returns>
        public PasswordChangeRoutineServer Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">PasswordChangeRoutineServer</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(PasswordChangeRoutineServer other);
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
        /// <param name="other">PasswordChangeRoutineServer</param>
        public Void MergeFrom(PasswordChangeRoutineServer other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
