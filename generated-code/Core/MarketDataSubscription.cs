[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class MarketDataSubscription : IMessage<MarketDataSubscription>, IMessage, IEquatable<MarketDataSubscription>, IDeepCloneable<MarketDataSubscription>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<MarketDataSubscription> Parser { get; set; }
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
        /// Gets or sets the Level.
        /// </summary>
        [DataMember]
        public UInt32 Level { get; set; }
        /// <summary>
        /// Gets or sets the IncludePastMarketValues.
        /// </summary>
        [DataMember]
        public Boolean IncludePastMarketValues { get; set; }
        /// <summary>
        /// Gets or sets the AccountClusterId.
        /// </summary>
        [DataMember]
        public Int64 AccountClusterId { get; set; }
        /// <summary>
        /// Gets or sets the IncludePastQuotes.
        /// </summary>
        [DataMember]
        public Boolean IncludePastQuotes { get; set; }
        /// <summary>
        /// Gets or sets the IncludeDiscretionaryQuotes.
        /// </summary>
        [DataMember]
        public Boolean IncludeDiscretionaryQuotes { get; set; }
        /// <summary>
        /// Gets or sets the IsLevelPresentCase.
        /// </summary>
        [DataMember]
        public IsLevelPresentOneofCase IsLevelPresentCase { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>MarketDataSubscription</returns>
        public MarketDataSubscription Clone();
        /// <summary>
        /// ClearIsLevelPresent method.
        /// </summary>
        public Void ClearIsLevelPresent();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">MarketDataSubscription</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(MarketDataSubscription other);
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
        /// <param name="other">MarketDataSubscription</param>
        public Void MergeFrom(MarketDataSubscription other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
