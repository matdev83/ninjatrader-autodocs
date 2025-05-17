[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class RealTimeMarketData : IMessage<RealTimeMarketData>, IMessage, IEquatable<RealTimeMarketData>, IDeepCloneable<RealTimeMarketData>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<RealTimeMarketData> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the ContractId.
        /// </summary>
        [DataMember]
        public UInt32 ContractId { get; set; }
        /// <summary>
        /// Gets or sets the Quote.
        /// </summary>
        [DataMember]
        public RepeatedField<Quote> Quote { get; set; }
        /// <summary>
        /// Gets or sets the IsSnapshot.
        /// </summary>
        [DataMember]
        public Boolean IsSnapshot { get; set; }
        /// <summary>
        /// Gets or sets the CollapsingLevel.
        /// </summary>
        [DataMember]
        public UInt32 CollapsingLevel { get; set; }
        /// <summary>
        /// Gets or sets the MarketValues.
        /// </summary>
        [DataMember]
        public RepeatedField<MarketValues> MarketValues { get; set; }
        /// <summary>
        /// Gets or sets the AccountClusterId.
        /// </summary>
        [DataMember]
        public Int64 AccountClusterId { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>RealTimeMarketData</returns>
        public RealTimeMarketData Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">RealTimeMarketData</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(RealTimeMarketData other);
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
        /// <param name="other">RealTimeMarketData</param>
        public Void MergeFrom(RealTimeMarketData other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
