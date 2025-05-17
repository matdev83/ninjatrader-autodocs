[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class StrategyOrderLegParameters : IMessage<StrategyOrderLegParameters>, IMessage, IEquatable<StrategyOrderLegParameters>, IDeepCloneable<StrategyOrderLegParameters>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<StrategyOrderLegParameters> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the NodeIndex.
        /// </summary>
        [DataMember]
        public UInt32 NodeIndex { get; set; }
        /// <summary>
        /// Gets or sets the AccountId.
        /// </summary>
        [DataMember]
        public Int32 AccountId { get; set; }
        /// <summary>
        /// Gets or sets the OpenCloseInstruction.
        /// </summary>
        [DataMember]
        public UInt32 OpenCloseInstruction { get; set; }
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
        /// <returns>StrategyOrderLegParameters</returns>
        public StrategyOrderLegParameters Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">StrategyOrderLegParameters</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(StrategyOrderLegParameters other);
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
        /// <param name="other">StrategyOrderLegParameters</param>
        public Void MergeFrom(StrategyOrderLegParameters other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
