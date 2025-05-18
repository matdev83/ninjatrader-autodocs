[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class TimeBarParameters : IMessage<TimeBarParameters>, IMessage, IEquatable<TimeBarParameters>, IDeepCloneable<TimeBarParameters>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<TimeBarParameters> Parser { get; set; }
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
        /// Gets or sets the BarUnit.
        /// </summary>
        [DataMember]
        public UInt32 BarUnit { get; set; }
        /// <summary>
        /// Gets or sets the UnitsNumber.
        /// </summary>
        [DataMember]
        public UInt32 UnitsNumber { get; set; }
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
        /// <summary>
        /// Gets or sets the UseSettlements.
        /// </summary>
        [DataMember]
        public Boolean UseSettlements { get; set; }
        /// <summary>
        /// Gets or sets the ContinuationParameters.
        /// </summary>
        [DataMember]
        public ContinuationParameters ContinuationParameters { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>TimeBarParameters</returns>
        public TimeBarParameters Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">TimeBarParameters</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(TimeBarParameters other);
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
        /// <param name="other">TimeBarParameters</param>
        public Void MergeFrom(TimeBarParameters other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
