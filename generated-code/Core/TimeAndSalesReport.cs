[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class TimeAndSalesReport : IMessage<TimeAndSalesReport>, IMessage, IEquatable<TimeAndSalesReport>, IDeepCloneable<TimeAndSalesReport>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<TimeAndSalesReport> Parser { get; set; }
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
        /// Gets or sets the ResultCode.
        /// </summary>
        [DataMember]
        public UInt32 ResultCode { get; set; }
        /// <summary>
        /// Gets or sets the Quote.
        /// </summary>
        [DataMember]
        public RepeatedField<Quote> Quote { get; set; }
        /// <summary>
        /// Gets or sets the UpToUtcTime.
        /// </summary>
        [DataMember]
        public Int64 UpToUtcTime { get; set; }
        /// <summary>
        /// Gets or sets the IsReportComplete.
        /// </summary>
        [DataMember]
        public Boolean IsReportComplete { get; set; }
        /// <summary>
        /// Gets or sets the TextMessage.
        /// </summary>
        [DataMember]
        public String TextMessage { get; set; }
        /// <summary>
        /// Gets or sets the Truncated.
        /// </summary>
        [DataMember]
        public Boolean Truncated { get; set; }
        /// <summary>
        /// Gets or sets the IsReportCompletePresentCase.
        /// </summary>
        [DataMember]
        public IsReportCompletePresentOneofCase IsReportCompletePresentCase { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>TimeAndSalesReport</returns>
        public TimeAndSalesReport Clone();
        /// <summary>
        /// ClearIsReportCompletePresent method.
        /// </summary>
        public Void ClearIsReportCompletePresent();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">TimeAndSalesReport</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(TimeAndSalesReport other);
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
        /// <param name="other">TimeAndSalesReport</param>
        public Void MergeFrom(TimeAndSalesReport other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
