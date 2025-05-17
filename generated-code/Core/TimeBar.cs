[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class TimeBar : IMessage<TimeBar>, IMessage, IEquatable<TimeBar>, IDeepCloneable<TimeBar>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<TimeBar> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the BarUtcTime.
        /// </summary>
        [DataMember]
        public Int64 BarUtcTime { get; set; }
        /// <summary>
        /// Gets or sets the OpenPrice.
        /// </summary>
        [DataMember]
        public Int32 OpenPrice { get; set; }
        /// <summary>
        /// Gets or sets the HighPrice.
        /// </summary>
        [DataMember]
        public Int32 HighPrice { get; set; }
        /// <summary>
        /// Gets or sets the LowPrice.
        /// </summary>
        [DataMember]
        public Int32 LowPrice { get; set; }
        /// <summary>
        /// Gets or sets the ClosePrice.
        /// </summary>
        [DataMember]
        public Int32 ClosePrice { get; set; }
        /// <summary>
        /// Gets or sets the Volume.
        /// </summary>
        [DataMember]
        public UInt64 Volume { get; set; }
        /// <summary>
        /// Gets or sets the TradeDate.
        /// </summary>
        [DataMember]
        public Int64 TradeDate { get; set; }
        /// <summary>
        /// Gets or sets the CommodityVolume.
        /// </summary>
        [DataMember]
        public UInt64 CommodityVolume { get; set; }
        /// <summary>
        /// Gets or sets the OpenInterest.
        /// </summary>
        [DataMember]
        public UInt64 OpenInterest { get; set; }
        /// <summary>
        /// Gets or sets the CommodityOpenInterest.
        /// </summary>
        [DataMember]
        public UInt64 CommodityOpenInterest { get; set; }
        /// <summary>
        /// Gets or sets the SettlementPrice.
        /// </summary>
        [DataMember]
        public Int32 SettlementPrice { get; set; }
        /// <summary>
        /// Gets or sets the TickVolume.
        /// </summary>
        [DataMember]
        public UInt64 TickVolume { get; set; }
        /// <summary>
        /// Gets or sets the CommodityTickVolume.
        /// </summary>
        [DataMember]
        public UInt64 CommodityTickVolume { get; set; }
        /// <summary>
        /// Gets or sets the ContinuationSegment.
        /// </summary>
        [DataMember]
        public ContinuationSegment ContinuationSegment { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>TimeBar</returns>
        public TimeBar Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">TimeBar</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(TimeBar other);
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
        /// <param name="other">TimeBar</param>
        public Void MergeFrom(TimeBar other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
