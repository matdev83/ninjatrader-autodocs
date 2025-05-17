[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class MarketTakingParameters : IMessage<MarketTakingParameters>, IMessage, IEquatable<MarketTakingParameters>, IDeepCloneable<MarketTakingParameters>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<MarketTakingParameters> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the AllocationPercent.
        /// </summary>
        [DataMember]
        public Double AllocationPercent { get; set; }
        /// <summary>
        /// Gets or sets the WorkingTimeout.
        /// </summary>
        [DataMember]
        public UInt32 WorkingTimeout { get; set; }
        /// <summary>
        /// Gets or sets the OrderType.
        /// </summary>
        [DataMember]
        public UInt32 OrderType { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>MarketTakingParameters</returns>
        public MarketTakingParameters Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">MarketTakingParameters</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(MarketTakingParameters other);
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
        /// <param name="other">MarketTakingParameters</param>
        public Void MergeFrom(MarketTakingParameters other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
