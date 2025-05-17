[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class TimeAndSalesParameters : IMessage<TimeAndSalesParameters>, IMessage, IEquatable<TimeAndSalesParameters>, IDeepCloneable<TimeAndSalesParameters>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<TimeAndSalesParameters> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the ContractId.
        /// </summary>
        [DataMember]
        public UInt32 ContractId { get; set; }
        /// <summary>
        /// Gets or sets the Level.
        /// </summary>
        [DataMember]
        public UInt32 Level { get; set; }
        /// <summary>
        /// Gets or sets the FromUtcTime.
        /// </summary>
        [DataMember]
        public Int64 FromUtcTime { get; set; }
        /// <summary>
        /// Gets or sets the ToUtcTime.
        /// </summary>
        [DataMember]
        public Int64 ToUtcTime { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>TimeAndSalesParameters</returns>
        public TimeAndSalesParameters Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">TimeAndSalesParameters</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(TimeAndSalesParameters other);
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
        /// <param name="other">TimeAndSalesParameters</param>
        public Void MergeFrom(TimeAndSalesParameters other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
