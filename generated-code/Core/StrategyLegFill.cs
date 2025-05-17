[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class StrategyLegFill : IMessage<StrategyLegFill>, IMessage, IEquatable<StrategyLegFill>, IDeepCloneable<StrategyLegFill>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<StrategyLegFill> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the LegOrderId.
        /// </summary>
        [DataMember]
        public String LegOrderId { get; set; }
        /// <summary>
        /// Gets or sets the LegExecutionId.
        /// </summary>
        [DataMember]
        public String LegExecutionId { get; set; }
        /// <summary>
        /// Gets or sets the Qty.
        /// </summary>
        [DataMember]
        public Double Qty { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>StrategyLegFill</returns>
        public StrategyLegFill Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">StrategyLegFill</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(StrategyLegFill other);
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
        /// <param name="other">StrategyLegFill</param>
        public Void MergeFrom(StrategyLegFill other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
