[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class SessionSchedule : IMessage<SessionSchedule>, IMessage, IEquatable<SessionSchedule>, IDeepCloneable<SessionSchedule>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<SessionSchedule> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [DataMember]
        public String Name { get; set; }
        /// <summary>
        /// Gets or sets the SessionDay.
        /// </summary>
        [DataMember]
        public RepeatedField<SessionDay> SessionDay { get; set; }
        /// <summary>
        /// Gets or sets the SessionHoliday.
        /// </summary>
        [DataMember]
        public RepeatedField<SessionHoliday> SessionHoliday { get; set; }
        /// <summary>
        /// Gets or sets the IsPrimary.
        /// </summary>
        [DataMember]
        public Boolean IsPrimary { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>SessionSchedule</returns>
        public SessionSchedule Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">SessionSchedule</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(SessionSchedule other);
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
        /// <param name="other">SessionSchedule</param>
        public Void MergeFrom(SessionSchedule other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
