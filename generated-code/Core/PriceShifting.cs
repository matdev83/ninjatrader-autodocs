[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class PriceShifting : IMessage<PriceShifting>, IMessage, IEquatable<PriceShifting>, IDeepCloneable<PriceShifting>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<PriceShifting> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the PriceStep.
        /// </summary>
        [DataMember]
        public Int32 PriceStep { get; set; }
        /// <summary>
        /// Gets or sets the Uint32FilledQtyDelta.
        /// </summary>
        [DataMember]
        [Obsolete]
        public UInt32 Uint32FilledQtyDelta { get; set; }
        /// <summary>
        /// Gets or sets the FilledQtyDelta.
        /// </summary>
        [DataMember]
        public Decimal FilledQtyDelta { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>PriceShifting</returns>
        public PriceShifting Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">PriceShifting</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(PriceShifting other);
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
        /// <param name="other">PriceShifting</param>
        public Void MergeFrom(PriceShifting other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
