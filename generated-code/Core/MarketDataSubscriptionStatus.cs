[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class MarketDataSubscriptionStatus : IMessage<MarketDataSubscriptionStatus>, IMessage, IEquatable<MarketDataSubscriptionStatus>, IDeepCloneable<MarketDataSubscriptionStatus>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<MarketDataSubscriptionStatus> Parser { get; set; }
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
        /// Gets or sets the StatusCode.
        /// </summary>
        [DataMember]
        public UInt32 StatusCode { get; set; }
        /// <summary>
        /// Gets or sets the Level.
        /// </summary>
        [DataMember]
        public UInt32 Level { get; set; }
        /// <summary>
        /// Gets or sets the TextMessage.
        /// </summary>
        [DataMember]
        public String TextMessage { get; set; }
        /// <summary>
        /// Gets or sets the AccountClusterId.
        /// </summary>
        [DataMember]
        public Int64 AccountClusterId { get; set; }
        /// <summary>
        /// Gets or sets the PastQuotesIncluded.
        /// </summary>
        [DataMember]
        public Boolean PastQuotesIncluded { get; set; }
        /// <summary>
        /// Gets or sets the DiscretionaryQuotesIncluded.
        /// </summary>
        [DataMember]
        public Boolean DiscretionaryQuotesIncluded { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>MarketDataSubscriptionStatus</returns>
        public MarketDataSubscriptionStatus Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">MarketDataSubscriptionStatus</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(MarketDataSubscriptionStatus other);
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
        /// <param name="other">MarketDataSubscriptionStatus</param>
        public Void MergeFrom(MarketDataSubscriptionStatus other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
