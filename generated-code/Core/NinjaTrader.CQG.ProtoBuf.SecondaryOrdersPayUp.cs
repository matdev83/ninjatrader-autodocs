[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class SecondaryOrdersPayUp : IMessage<SecondaryOrdersPayUp>, IMessage, IEquatable<SecondaryOrdersPayUp>, IDeepCloneable<SecondaryOrdersPayUp>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<SecondaryOrdersPayUp> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the Offset.
        /// </summary>
        [DataMember]
        public Double Offset { get; set; }
        /// <summary>
        /// Gets or sets the InitialOffset.
        /// </summary>
        [DataMember]
        public Double InitialOffset { get; set; }
        /// <summary>
        /// Gets or sets the ConditionTimeout.
        /// </summary>
        [DataMember]
        public UInt32 ConditionTimeout { get; set; }
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
        /// <returns>SecondaryOrdersPayUp</returns>
        public SecondaryOrdersPayUp Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">SecondaryOrdersPayUp</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(SecondaryOrdersPayUp other);
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
        /// <param name="other">SecondaryOrdersPayUp</param>
        public Void MergeFrom(SecondaryOrdersPayUp other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
