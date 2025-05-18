[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class CompoundOrderStructure : IMessage<CompoundOrderStructure>, IMessage, IEquatable<CompoundOrderStructure>, IDeepCloneable<CompoundOrderStructure>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<CompoundOrderStructure> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the Type.
        /// </summary>
        [DataMember]
        public UInt32 Type { get; set; }
        /// <summary>
        /// Gets or sets the ClCompoundId.
        /// </summary>
        [DataMember]
        public String ClCompoundId { get; set; }
        /// <summary>
        /// Gets or sets the CompoundOrderEntry.
        /// </summary>
        [DataMember]
        public RepeatedField<CompoundOrderStructureEntry> CompoundOrderEntry { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>CompoundOrderStructure</returns>
        public CompoundOrderStructure Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">CompoundOrderStructure</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(CompoundOrderStructure other);
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
        /// <param name="other">CompoundOrderStructure</param>
        public Void MergeFrom(CompoundOrderStructure other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
