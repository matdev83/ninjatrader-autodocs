[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class SessionDay : IMessage<SessionDay>, IMessage, IEquatable<SessionDay>, IDeepCloneable<SessionDay>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<SessionDay> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the DayOfWeek.
        /// </summary>
        [DataMember]
        public RepeatedField<DayOfWeek> DayOfWeek { get; set; }
        /// <summary>
        /// Gets or sets the PreOpenOffset.
        /// </summary>
        [DataMember]
        public Int64 PreOpenOffset { get; set; }
        /// <summary>
        /// Gets or sets the OpenOffset.
        /// </summary>
        [DataMember]
        public Int64 OpenOffset { get; set; }
        /// <summary>
        /// Gets or sets the CloseOffset.
        /// </summary>
        [DataMember]
        public Int64 CloseOffset { get; set; }
        /// <summary>
        /// Gets or sets the PostCloseOffset.
        /// </summary>
        [DataMember]
        public Int64 PostCloseOffset { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>SessionDay</returns>
        public SessionDay Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">SessionDay</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(SessionDay other);
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
        /// <param name="other">SessionDay</param>
        public Void MergeFrom(SessionDay other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
