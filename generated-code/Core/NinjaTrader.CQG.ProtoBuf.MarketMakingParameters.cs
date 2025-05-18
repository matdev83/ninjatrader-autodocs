[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class MarketMakingParameters : IMessage<MarketMakingParameters>, IMessage, IEquatable<MarketMakingParameters>, IDeepCloneable<MarketMakingParameters>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<MarketMakingParameters> Parser { get; set; }
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
        /// Gets or sets the Uint32VisibleQty.
        /// </summary>
        [DataMember]
        [Obsolete]
        public UInt32 Uint32VisibleQty { get; set; }
        /// <summary>
        /// Gets or sets the Uint32MinVisibleQty.
        /// </summary>
        [DataMember]
        [Obsolete]
        public UInt32 Uint32MinVisibleQty { get; set; }
        /// <summary>
        /// Gets or sets the Uint32NativeVisibleQty.
        /// </summary>
        [DataMember]
        [Obsolete]
        public UInt32 Uint32NativeVisibleQty { get; set; }
        /// <summary>
        /// Gets or sets the VisibleQty.
        /// </summary>
        [DataMember]
        public Decimal VisibleQty { get; set; }
        /// <summary>
        /// Gets or sets the MinVisibleQty.
        /// </summary>
        [DataMember]
        public Decimal MinVisibleQty { get; set; }
        /// <summary>
        /// Gets or sets the NativeVisibleQty.
        /// </summary>
        [DataMember]
        public Decimal NativeVisibleQty { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>MarketMakingParameters</returns>
        public MarketMakingParameters Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">MarketMakingParameters</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(MarketMakingParameters other);
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
        /// <param name="other">MarketMakingParameters</param>
        public Void MergeFrom(MarketMakingParameters other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
