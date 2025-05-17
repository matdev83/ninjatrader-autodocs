[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class TradingDayTimeRange : IMessage<TradingDayTimeRange>, IMessage, IEquatable<TradingDayTimeRange>, IDeepCloneable<TradingDayTimeRange>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<TradingDayTimeRange> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the TradeDate.
        /// </summary>
        [DataMember]
        public Int64 TradeDate { get; set; }
        /// <summary>
        /// Gets or sets the StartUtcTime.
        /// </summary>
        [DataMember]
        public Int64 StartUtcTime { get; set; }
        /// <summary>
        /// Gets or sets the EndUtcTime.
        /// </summary>
        [DataMember]
        public Int64 EndUtcTime { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>TradingDayTimeRange</returns>
        public TradingDayTimeRange Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">TradingDayTimeRange</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(TradingDayTimeRange other);
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
        /// <param name="other">TradingDayTimeRange</param>
        public Void MergeFrom(TradingDayTimeRange other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
