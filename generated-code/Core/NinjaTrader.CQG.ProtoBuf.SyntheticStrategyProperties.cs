[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class SyntheticStrategyProperties : IMessage<SyntheticStrategyProperties>, IMessage, IEquatable<SyntheticStrategyProperties>, IDeepCloneable<SyntheticStrategyProperties>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<SyntheticStrategyProperties> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the StrategyTradingParameters.
        /// </summary>
        [DataMember]
        public StrategyTradingParameters StrategyTradingParameters { get; set; }
        /// <summary>
        /// Gets or sets the OriginOrderId.
        /// </summary>
        [DataMember]
        public String OriginOrderId { get; set; }
        /// <summary>
        /// Gets or sets the RootOrderId.
        /// </summary>
        [DataMember]
        public String RootOrderId { get; set; }
        /// <summary>
        /// Gets or sets the NodeIndex.
        /// </summary>
        [DataMember]
        public UInt32 NodeIndex { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>SyntheticStrategyProperties</returns>
        public SyntheticStrategyProperties Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">SyntheticStrategyProperties</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(SyntheticStrategyProperties other);
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
        /// <param name="other">SyntheticStrategyProperties</param>
        public Void MergeFrom(SyntheticStrategyProperties other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
