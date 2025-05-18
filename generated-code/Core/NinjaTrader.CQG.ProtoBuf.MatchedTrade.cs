[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class MatchedTrade : IMessage<MatchedTrade>, IMessage, IEquatable<MatchedTrade>, IDeepCloneable<MatchedTrade>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<MatchedTrade> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the Uint32Qty.
        /// </summary>
        [DataMember]
        [Obsolete]
        public UInt32 Uint32Qty { get; set; }
        /// <summary>
        /// Gets or sets the Qty.
        /// </summary>
        [DataMember]
        public Decimal Qty { get; set; }
        /// <summary>
        /// Gets or sets the IsShort.
        /// </summary>
        [DataMember]
        public Boolean IsShort { get; set; }
        /// <summary>
        /// Gets or sets the Price.
        /// </summary>
        [DataMember]
        public Double Price { get; set; }
        /// <summary>
        /// Gets or sets the TradeDate.
        /// </summary>
        [DataMember]
        public Int64 TradeDate { get; set; }
        /// <summary>
        /// Gets or sets the StatementDate.
        /// </summary>
        [DataMember]
        public Int64 StatementDate { get; set; }
        /// <summary>
        /// Gets or sets the TradeUtcTime.
        /// </summary>
        [DataMember]
        [Obsolete]
        public Int64 TradeUtcTime { get; set; }
        /// <summary>
        /// Gets or sets the TradeUtcTimestamp.
        /// </summary>
        [DataMember]
        public Timestamp TradeUtcTimestamp { get; set; }
        /// <summary>
        /// Gets or sets the IsAggregated.
        /// </summary>
        [DataMember]
        public Boolean IsAggregated { get; set; }
        /// <summary>
        /// Gets or sets the IsYesterday.
        /// </summary>
        [DataMember]
        public Boolean IsYesterday { get; set; }
        /// <summary>
        /// Gets or sets the IsClose.
        /// </summary>
        [DataMember]
        public Boolean IsClose { get; set; }
        /// <summary>
        /// Gets or sets the SpeculationType.
        /// </summary>
        [DataMember]
        public UInt32 SpeculationType { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>MatchedTrade</returns>
        public MatchedTrade Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">MatchedTrade</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(MatchedTrade other);
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
        /// <param name="other">MatchedTrade</param>
        public Void MergeFrom(MatchedTrade other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
