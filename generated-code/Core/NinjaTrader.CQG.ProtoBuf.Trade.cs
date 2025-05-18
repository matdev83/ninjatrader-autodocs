[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class Trade : IMessage<Trade>, IMessage, IEquatable<Trade>, IDeepCloneable<Trade>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<Trade> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the TradeId.
        /// </summary>
        [DataMember]
        public String TradeId { get; set; }
        /// <summary>
        /// Gets or sets the ContractId.
        /// </summary>
        [DataMember]
        public UInt32 ContractId { get; set; }
        /// <summary>
        /// Gets or sets the StatementDate.
        /// </summary>
        [DataMember]
        public Int64 StatementDate { get; set; }
        /// <summary>
        /// Gets or sets the TradeUtcTime.
        /// </summary>
        [DataMember]
        [Obsolete]
        public Int64 TradeUtcTime { get; set; }
        /// <summary>
        /// Gets or sets the TradeUtcTimestamp.
        /// </summary>
        [DataMember]
        public Timestamp TradeUtcTimestamp { get; set; }
        /// <summary>
        /// Gets or sets the TradeDate.
        /// </summary>
        [DataMember]
        public Int64 TradeDate { get; set; }
        /// <summary>
        /// Gets or sets the Price.
        /// </summary>
        [DataMember]
        public Int64 Price { get; set; }
        /// <summary>
        /// Gets or sets the PriceCorrect.
        /// </summary>
        [DataMember]
        public Double PriceCorrect { get; set; }
        /// <summary>
        /// Gets or sets the Side.
        /// </summary>
        [DataMember]
        public UInt32 Side { get; set; }
        /// <summary>
        /// Gets or sets the Uint32Qty.
        /// </summary>
        [DataMember]
        [Obsolete]
        public UInt32 Uint32Qty { get; set; }
        /// <summary>
        /// Gets or sets the Qty.
        /// </summary>
        [DataMember]
        public Decimal Qty { get; set; }
        /// <summary>
        /// Gets or sets the TradeCounterparty.
        /// </summary>
        [DataMember]
        public String TradeCounterparty { get; set; }
        /// <summary>
        /// Gets or sets the IsAggressive.
        /// </summary>
        [DataMember]
        public Boolean IsAggressive { get; set; }
        /// <summary>
        /// Gets or sets the LegExecutionId.
        /// </summary>
        [DataMember]
        public String LegExecutionId { get; set; }
        /// <summary>
        /// Gets or sets the OpenCloseEffect.
        /// </summary>
        [DataMember]
        public UInt32 OpenCloseEffect { get; set; }
        /// <summary>
        /// Gets or sets the SpeculationType.
        /// </summary>
        [DataMember]
        public UInt32 SpeculationType { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>Trade</returns>
        public Trade Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Trade</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Trade other);
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
        /// <param name="other">Trade</param>
        public Void MergeFrom(Trade other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
