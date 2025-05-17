[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class NestedStrategy : IMessage<NestedStrategy>, IMessage, IEquatable<NestedStrategy>, IDeepCloneable<NestedStrategy>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<NestedStrategy> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the Definition.
        /// </summary>
        [DataMember]
        public StrategyDefinition Definition { get; set; }
        /// <summary>
        /// Gets or sets the QtyRatio.
        /// </summary>
        [DataMember]
        public Double QtyRatio { get; set; }
        /// <summary>
        /// Gets or sets the PriceRatio.
        /// </summary>
        [DataMember]
        public Double PriceRatio { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>NestedStrategy</returns>
        public NestedStrategy Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">NestedStrategy</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(NestedStrategy other);
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
        /// <param name="other">NestedStrategy</param>
        public Void MergeFrom(NestedStrategy other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
