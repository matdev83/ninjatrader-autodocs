[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class CancelOrder : IMessage<CancelOrder>, IMessage, IEquatable<CancelOrder>, IDeepCloneable<CancelOrder>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<CancelOrder> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the OrderId.
        /// </summary>
        [DataMember]
        public String OrderId { get; set; }
        /// <summary>
        /// Gets or sets the AccountId.
        /// </summary>
        [DataMember]
        public Int32 AccountId { get; set; }
        /// <summary>
        /// Gets or sets the OrigClOrderId.
        /// </summary>
        [DataMember]
        public String OrigClOrderId { get; set; }
        /// <summary>
        /// Gets or sets the ClOrderId.
        /// </summary>
        [DataMember]
        public String ClOrderId { get; set; }
        /// <summary>
        /// Gets or sets the WhenUtcTime.
        /// </summary>
        [DataMember]
        [Obsolete]
        public Int64 WhenUtcTime { get; set; }
        /// <summary>
        /// Gets or sets the WhenUtcTimestamp.
        /// </summary>
        [DataMember]
        public Timestamp WhenUtcTimestamp { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>CancelOrder</returns>
        public CancelOrder Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">CancelOrder</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(CancelOrder other);
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
        /// <param name="other">CancelOrder</param>
        public Void MergeFrom(CancelOrder other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
