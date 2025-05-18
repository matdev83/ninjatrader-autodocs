[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class CompoundOrderStructureEntry : IMessage<CompoundOrderStructureEntry>, IMessage, IEquatable<CompoundOrderStructureEntry>, IDeepCloneable<CompoundOrderStructureEntry>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<CompoundOrderStructureEntry> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the ChainOrderId.
        /// </summary>
        [DataMember]
        public String ChainOrderId { get; set; }
        /// <summary>
        /// Gets or sets the CompoundOrderStructure.
        /// </summary>
        [DataMember]
        public CompoundOrderStructure CompoundOrderStructure { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>CompoundOrderStructureEntry</returns>
        public CompoundOrderStructureEntry Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">CompoundOrderStructureEntry</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(CompoundOrderStructureEntry other);
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
        /// <param name="other">CompoundOrderStructureEntry</param>
        public Void MergeFrom(CompoundOrderStructureEntry other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
