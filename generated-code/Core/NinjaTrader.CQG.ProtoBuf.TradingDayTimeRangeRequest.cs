[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class TradingDayTimeRangeRequest : IMessage<TradingDayTimeRangeRequest>, IMessage, IEquatable<TradingDayTimeRangeRequest>, IDeepCloneable<TradingDayTimeRangeRequest>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<TradingDayTimeRangeRequest> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the SessionInfoId.
        /// </summary>
        [DataMember]
        public Int32 SessionInfoId { get; set; }
        /// <summary>
        /// Gets or sets the IncludeHolidays.
        /// </summary>
        [DataMember]
        public Boolean IncludeHolidays { get; set; }
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
        /// Gets or sets the Count.
        /// </summary>
        [DataMember]
        public UInt32 Count { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>TradingDayTimeRangeRequest</returns>
        public TradingDayTimeRangeRequest Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">TradingDayTimeRangeRequest</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(TradingDayTimeRangeRequest other);
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
        /// <param name="other">TradingDayTimeRangeRequest</param>
        public Void MergeFrom(TradingDayTimeRangeRequest other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
