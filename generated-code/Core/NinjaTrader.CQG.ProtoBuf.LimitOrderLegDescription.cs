[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class LimitOrderLegDescription : IMessage<LimitOrderLegDescription>, IMessage, IEquatable<LimitOrderLegDescription>, IDeepCloneable<LimitOrderLegDescription>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<LimitOrderLegDescription> Parser { get; set; }
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
        /// Gets or sets the PrimaryOrderLimit.
        /// </summary>
        [DataMember]
        public PrimaryOrdersLimit PrimaryOrderLimit { get; set; }
        /// <summary>
        /// Gets or sets the PrimaryOrderSniper.
        /// </summary>
        [DataMember]
        public PrimaryOrdersSniper PrimaryOrderSniper { get; set; }
        /// <summary>
        /// Gets or sets the SecondaryOrdersLimit.
        /// </summary>
        [DataMember]
        public SecondaryOrdersLimit SecondaryOrdersLimit { get; set; }
        /// <summary>
        /// Gets or sets the SecondaryOrdersMarket.
        /// </summary>
        [DataMember]
        public SecondaryOrdersMarket SecondaryOrdersMarket { get; set; }
        /// <summary>
        /// Gets or sets the SecondaryOrdersPayup.
        /// </summary>
        [DataMember]
        public SecondaryOrdersPayUp SecondaryOrdersPayup { get; set; }
        /// <summary>
        /// Gets or sets the SecondaryOrdersTrailing.
        /// </summary>
        [DataMember]
        public SecondaryOrdersTrailing SecondaryOrdersTrailing { get; set; }
        /// <summary>
        /// Gets or sets the ProportionalExecutionRatio.
        /// </summary>
        [DataMember]
        public Double ProportionalExecutionRatio { get; set; }
        /// <summary>
        /// Gets or sets the VolumeMultiplier.
        /// </summary>
        [DataMember]
        public Double VolumeMultiplier { get; set; }
        /// <summary>
        /// Gets or sets the Uint32WorkThreshold.
        /// </summary>
        [DataMember]
        [Obsolete]
        public UInt32 Uint32WorkThreshold { get; set; }
        /// <summary>
        /// Gets or sets the WorkThreshold.
        /// </summary>
        [DataMember]
        public Decimal WorkThreshold { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>LimitOrderLegDescription</returns>
        public LimitOrderLegDescription Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">LimitOrderLegDescription</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(LimitOrderLegDescription other);
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
        /// <param name="other">LimitOrderLegDescription</param>
        public Void MergeFrom(LimitOrderLegDescription other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
