[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class MarketValues : IMessage<MarketValues>, IMessage, IEquatable<MarketValues>, IDeepCloneable<MarketValues>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<MarketValues> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
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
        /// Gets or sets the YesterdaySettlement.
        /// </summary>
        [DataMember]
        public Int32 YesterdaySettlement { get; set; }
        /// <summary>
        /// Gets or sets the TotalVolume.
        /// </summary>
        [DataMember]
        public UInt64 TotalVolume { get; set; }
        /// <summary>
        /// Gets or sets the YesterdayClose.
        /// </summary>
        [DataMember]
        public Int32 YesterdayClose { get; set; }
        /// <summary>
        /// Gets or sets the IndicativeOpen.
        /// </summary>
        [DataMember]
        public Int32 IndicativeOpen { get; set; }
        /// <summary>
        /// Gets or sets the DayIndex.
        /// </summary>
        [DataMember]
        public Int32 DayIndex { get; set; }
        /// <summary>
        /// Gets or sets the OpenInterest.
        /// </summary>
        [DataMember]
        public Int64 OpenInterest { get; set; }
        /// <summary>
        /// Gets or sets the TickVolume.
        /// </summary>
        [DataMember]
        public UInt32 TickVolume { get; set; }
        /// <summary>
        /// Gets or sets the Settlement.
        /// </summary>
        [DataMember]
        public Int32 Settlement { get; set; }
        /// <summary>
        /// Gets or sets the ClearedFields.
        /// </summary>
        [DataMember]
        public RepeatedField<UInt32> ClearedFields { get; set; }
        /// <summary>
        /// Gets or sets the TradeDate.
        /// </summary>
        [DataMember]
        public Int64 TradeDate { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>MarketValues</returns>
        public MarketValues Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">MarketValues</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(MarketValues other);
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
        /// <param name="other">MarketValues</param>
        public Void MergeFrom(MarketValues other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
