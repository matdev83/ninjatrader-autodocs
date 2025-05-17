[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class TimeAndSalesRequest : IMessage<TimeAndSalesRequest>, IMessage, IEquatable<TimeAndSalesRequest>, IDeepCloneable<TimeAndSalesRequest>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<TimeAndSalesRequest> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the RequestId.
        /// </summary>
        [DataMember]
        public UInt32 RequestId { get; set; }
        /// <summary>
        /// Gets or sets the TimeAndSalesParameters.
        /// </summary>
        [DataMember]
        public TimeAndSalesParameters TimeAndSalesParameters { get; set; }
        /// <summary>
        /// Gets or sets the RequestType.
        /// </summary>
        [DataMember]
        public UInt32 RequestType { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>TimeAndSalesRequest</returns>
        public TimeAndSalesRequest Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">TimeAndSalesRequest</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(TimeAndSalesRequest other);
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
        /// <param name="other">TimeAndSalesRequest</param>
        public Void MergeFrom(TimeAndSalesRequest other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
