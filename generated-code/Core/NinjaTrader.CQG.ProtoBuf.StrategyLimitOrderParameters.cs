[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class StrategyLimitOrderParameters : IMessage<StrategyLimitOrderParameters>, IMessage, IEquatable<StrategyLimitOrderParameters>, IDeepCloneable<StrategyLimitOrderParameters>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<StrategyLimitOrderParameters> Parser { get; set; }
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
        /// Gets or sets the ReplenishOnPrimaryFill.
        /// </summary>
        [DataMember]
        public Boolean ReplenishOnPrimaryFill { get; set; }
        /// <summary>
        /// Gets or sets the OverfillMode.
        /// </summary>
        [DataMember]
        public UInt32 OverfillMode { get; set; }
        /// <summary>
        /// Gets or sets the AlignToStrategyLots.
        /// </summary>
        [DataMember]
        public UInt32 AlignToStrategyLots { get; set; }
        /// <summary>
        /// Gets or sets the PricingMethod.
        /// </summary>
        [DataMember]
        public UInt32 PricingMethod { get; set; }
        /// <summary>
        /// Gets or sets the PriceShifting.
        /// </summary>
        [DataMember]
        public PriceShifting PriceShifting { get; set; }
        /// <summary>
        /// Gets or sets the LegDescription.
        /// </summary>
        [DataMember]
        public RepeatedField<LimitOrderLegDescription> LegDescription { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>StrategyLimitOrderParameters</returns>
        public StrategyLimitOrderParameters Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">StrategyLimitOrderParameters</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(StrategyLimitOrderParameters other);
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
        /// <param name="other">StrategyLimitOrderParameters</param>
        public Void MergeFrom(StrategyLimitOrderParameters other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
