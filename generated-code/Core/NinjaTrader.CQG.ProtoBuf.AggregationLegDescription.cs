[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class AggregationLegDescription : IMessage<AggregationLegDescription>, IMessage, IEquatable<AggregationLegDescription>, IDeepCloneable<AggregationLegDescription>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<AggregationLegDescription> Parser { get; set; }
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
        /// Gets or sets the Uint32WorkingThreshold.
        /// </summary>
        [DataMember]
        [Obsolete]
        public UInt32 Uint32WorkingThreshold { get; set; }
        /// <summary>
        /// Gets or sets the WorkingThreshold.
        /// </summary>
        [DataMember]
        public Decimal WorkingThreshold { get; set; }
        /// <summary>
        /// Gets or sets the MarketTakingParameters.
        /// </summary>
        [DataMember]
        public MarketTakingParameters MarketTakingParameters { get; set; }
        /// <summary>
        /// Gets or sets the MarketMakingParameters.
        /// </summary>
        [DataMember]
        public MarketMakingParameters MarketMakingParameters { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>AggregationLegDescription</returns>
        public AggregationLegDescription Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">AggregationLegDescription</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(AggregationLegDescription other);
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
        /// <param name="other">AggregationLegDescription</param>
        public Void MergeFrom(AggregationLegDescription other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
