[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class SessionTimeRange : IMessage<SessionTimeRange>, IMessage, IEquatable<SessionTimeRange>, IDeepCloneable<SessionTimeRange>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<SessionTimeRange> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the PreOpenUtcTime.
        /// </summary>
        [DataMember]
        public Int64 PreOpenUtcTime { get; set; }
        /// <summary>
        /// Gets or sets the OpenUtcTime.
        /// </summary>
        [DataMember]
        public Int64 OpenUtcTime { get; set; }
        /// <summary>
        /// Gets or sets the CloseUtcTime.
        /// </summary>
        [DataMember]
        public Int64 CloseUtcTime { get; set; }
        /// <summary>
        /// Gets or sets the PostCloseUtcTime.
        /// </summary>
        [DataMember]
        public Int64 PostCloseUtcTime { get; set; }
        /// <summary>
        /// Gets or sets the TradeDate.
        /// </summary>
        [DataMember]
        public Int64 TradeDate { get; set; }
        /// <summary>
        /// Gets or sets the SessionName.
        /// </summary>
        [DataMember]
        public String SessionName { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>SessionTimeRange</returns>
        public SessionTimeRange Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">SessionTimeRange</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(SessionTimeRange other);
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
        /// <param name="other">SessionTimeRange</param>
        public Void MergeFrom(SessionTimeRange other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
