[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class NewCompoundOrder : IMessage<NewCompoundOrder>, IMessage, IEquatable<NewCompoundOrder>, IDeepCloneable<NewCompoundOrder>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<NewCompoundOrder> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the CompoundOrder.
        /// </summary>
        [DataMember]
        public CompoundOrder CompoundOrder { get; set; }
        /// <summary>
        /// Gets or sets the PartialFillsHandling.
        /// </summary>
        [DataMember]
        public Boolean PartialFillsHandling { get; set; }
        /// <summary>
        /// Gets or sets the PartialFillsHandlingPresentCase.
        /// </summary>
        [DataMember]
        public PartialFillsHandlingPresentOneofCase PartialFillsHandlingPresentCase { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>NewCompoundOrder</returns>
        public NewCompoundOrder Clone();
        /// <summary>
        /// ClearPartialFillsHandlingPresent method.
        /// </summary>
        public Void ClearPartialFillsHandlingPresent();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">NewCompoundOrder</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(NewCompoundOrder other);
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
        /// <param name="other">NewCompoundOrder</param>
        public Void MergeFrom(NewCompoundOrder other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
