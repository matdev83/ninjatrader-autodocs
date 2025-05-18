[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class StrategyDefinition : IMessage<StrategyDefinition>, IMessage, IEquatable<StrategyDefinition>, IDeepCloneable<StrategyDefinition>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<StrategyDefinition> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the Aggregation.
        /// </summary>
        [DataMember]
        public Boolean Aggregation { get; set; }
        /// <summary>
        /// Gets or sets the ExchangeStrategy.
        /// </summary>
        [DataMember]
        public ExchangeStrategy ExchangeStrategy { get; set; }
        /// <summary>
        /// Gets or sets the TickSize.
        /// </summary>
        [DataMember]
        public Double TickSize { get; set; }
        /// <summary>
        /// Gets or sets the PriceOffset.
        /// </summary>
        [DataMember]
        public Double PriceOffset { get; set; }
        /// <summary>
        /// Gets or sets the RoundLegMode.
        /// </summary>
        [DataMember]
        public UInt32 RoundLegMode { get; set; }
        /// <summary>
        /// Gets or sets the NodeIndex.
        /// </summary>
        [DataMember]
        public UInt32 NodeIndex { get; set; }
        /// <summary>
        /// Gets or sets the NodeDefinition.
        /// </summary>
        [DataMember]
        public RepeatedField<StrategyNodeDefinition> NodeDefinition { get; set; }
        /// <summary>
        /// Gets or sets the UserDescription.
        /// </summary>
        [DataMember]
        public String UserDescription { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>StrategyDefinition</returns>
        public StrategyDefinition Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">StrategyDefinition</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(StrategyDefinition other);
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
        /// <param name="other">StrategyDefinition</param>
        public Void MergeFrom(StrategyDefinition other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
