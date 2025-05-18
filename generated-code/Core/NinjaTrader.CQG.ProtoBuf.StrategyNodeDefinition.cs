[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class StrategyNodeDefinition : IMessage<StrategyNodeDefinition>, IMessage, IEquatable<StrategyNodeDefinition>, IDeepCloneable<StrategyNodeDefinition>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<StrategyNodeDefinition> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the NodeOperation.
        /// </summary>
        [DataMember]
        public UInt32 NodeOperation { get; set; }
        /// <summary>
        /// Gets or sets the Leg.
        /// </summary>
        [DataMember]
        public LegDefinition Leg { get; set; }
        /// <summary>
        /// Gets or sets the NestedStrategy.
        /// </summary>
        [DataMember]
        public NestedStrategy NestedStrategy { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>StrategyNodeDefinition</returns>
        public StrategyNodeDefinition Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">StrategyNodeDefinition</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(StrategyNodeDefinition other);
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
        /// <param name="other">StrategyNodeDefinition</param>
        public Void MergeFrom(StrategyNodeDefinition other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
