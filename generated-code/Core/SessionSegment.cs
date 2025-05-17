[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class SessionSegment : IMessage<SessionSegment>, IMessage, IEquatable<SessionSegment>, IDeepCloneable<SessionSegment>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<SessionSegment> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the SessionSegmentId.
        /// </summary>
        [DataMember]
        public Int64 SessionSegmentId { get; set; }
        /// <summary>
        /// Gets or sets the Deleted.
        /// </summary>
        [DataMember]
        public Boolean Deleted { get; set; }
        /// <summary>
        /// Gets or sets the FromUtcTime.
        /// </summary>
        [DataMember]
        public Int64 FromUtcTime { get; set; }
        /// <summary>
        /// Gets or sets the ToUtcTime.
        /// </summary>
        [DataMember]
        public Int64 ToUtcTime { get; set; }
        /// <summary>
        /// Gets or sets the SessionSchedule.
        /// </summary>
        [DataMember]
        public RepeatedField<SessionSchedule> SessionSchedule { get; set; }
        /// <summary>
        /// Gets or sets the TradingDay.
        /// </summary>
        [DataMember]
        public RepeatedField<TradingDay> TradingDay { get; set; }
        /// <summary>
        /// Gets or sets the DailyHoliday.
        /// </summary>
        [DataMember]
        public RepeatedField<SessionHoliday> DailyHoliday { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>SessionSegment</returns>
        public SessionSegment Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">SessionSegment</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(SessionSegment other);
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
        /// <param name="other">SessionSegment</param>
        public Void MergeFrom(SessionSegment other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
