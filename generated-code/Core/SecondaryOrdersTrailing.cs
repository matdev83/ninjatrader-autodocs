[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class SecondaryOrdersTrailing : IMessage<SecondaryOrdersTrailing>, IMessage, IEquatable<SecondaryOrdersTrailing>, IDeepCloneable<SecondaryOrdersTrailing>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<SecondaryOrdersTrailing> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the TrailingOffset.
        /// </summary>
        [DataMember]
        public Double TrailingOffset { get; set; }
        /// <summary>
        /// Gets or sets the TrailingPeg.
        /// </summary>
        [DataMember]
        public UInt32 TrailingPeg { get; set; }
        /// <summary>
        /// Gets or sets the InitialOffset.
        /// </summary>
        [DataMember]
        public Double InitialOffset { get; set; }
        /// <summary>
        /// Gets or sets the MaxTrail.
        /// </summary>
        [DataMember]
        public Double MaxTrail { get; set; }
        /// <summary>
        /// Gets or sets the Uint32ConditionAbsoluteVolume.
        /// </summary>
        [DataMember]
        [Obsolete]
        public UInt32 Uint32ConditionAbsoluteVolume { get; set; }
        /// <summary>
        /// Gets or sets the ConditionAbsoluteVolume.
        /// </summary>
        [DataMember]
        public Decimal ConditionAbsoluteVolume { get; set; }
        /// <summary>
        /// Gets or sets the ConditionOppositeVolumeRatio.
        /// </summary>
        [DataMember]
        public Double ConditionOppositeVolumeRatio { get; set; }
        /// <summary>
        /// Gets or sets the ConditionBbaVolumeRatio.
        /// </summary>
        [DataMember]
        public Double ConditionBbaVolumeRatio { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>SecondaryOrdersTrailing</returns>
        public SecondaryOrdersTrailing Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">SecondaryOrdersTrailing</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(SecondaryOrdersTrailing other);
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
        /// <param name="other">SecondaryOrdersTrailing</param>
        public Void MergeFrom(SecondaryOrdersTrailing other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
