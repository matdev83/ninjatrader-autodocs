[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class SyntheticHang : IMessage<SyntheticHang>, IMessage, IEquatable<SyntheticHang>, IDeepCloneable<SyntheticHang>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<SyntheticHang> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the HangId.
        /// </summary>
        [DataMember]
        public Int32 HangId { get; set; }
        /// <summary>
        /// Gets or sets the Uint32HungQty.
        /// </summary>
        [DataMember]
        [Obsolete]
        public UInt32 Uint32HungQty { get; set; }
        /// <summary>
        /// Gets or sets the HungQty.
        /// </summary>
        [DataMember]
        public Decimal HungQty { get; set; }
        /// <summary>
        /// Gets or sets the OrderId.
        /// </summary>
        [DataMember]
        public RepeatedField<String> OrderId { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>SyntheticHang</returns>
        public SyntheticHang Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">SyntheticHang</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(SyntheticHang other);
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
        /// <param name="other">SyntheticHang</param>
        public Void MergeFrom(SyntheticHang other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
