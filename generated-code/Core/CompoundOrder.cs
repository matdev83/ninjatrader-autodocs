[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class CompoundOrder : IMessage<CompoundOrder>, IMessage, IEquatable<CompoundOrder>, IDeepCloneable<CompoundOrder>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<CompoundOrder> Parser { get; set; }
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
        public RepeatedField<CompoundOrderEntry> CompoundOrderEntry { get; set; }
        /// <summary>
        /// Gets or sets the ProfitTickOffset.
        /// </summary>
        [DataMember]
        public Int32 ProfitTickOffset { get; set; }
        /// <summary>
        /// Gets or sets the LossTickOffset.
        /// </summary>
        [DataMember]
        public Int32 LossTickOffset { get; set; }
        /// <summary>
        /// Gets or sets the StopLimitTickOffset.
        /// </summary>
        [DataMember]
        public Int32 StopLimitTickOffset { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>CompoundOrder</returns>
        public CompoundOrder Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">CompoundOrder</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(CompoundOrder other);
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
        /// <param name="other">CompoundOrder</param>
        public Void MergeFrom(CompoundOrder other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
