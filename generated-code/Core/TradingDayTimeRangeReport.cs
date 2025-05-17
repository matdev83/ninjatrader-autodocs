[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class TradingDayTimeRangeReport : IMessage<TradingDayTimeRangeReport>, IMessage, IEquatable<TradingDayTimeRangeReport>, IDeepCloneable<TradingDayTimeRangeReport>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<TradingDayTimeRangeReport> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the TradingDayTimeRanges.
        /// </summary>
        [DataMember]
        public RepeatedField<TradingDayTimeRange> TradingDayTimeRanges { get; set; }
        /// <summary>
        /// Gets or sets the Truncated.
        /// </summary>
        [DataMember]
        public Boolean Truncated { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>TradingDayTimeRangeReport</returns>
        public TradingDayTimeRangeReport Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">TradingDayTimeRangeReport</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(TradingDayTimeRangeReport other);
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
        /// <param name="other">TradingDayTimeRangeReport</param>
        public Void MergeFrom(TradingDayTimeRangeReport other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
