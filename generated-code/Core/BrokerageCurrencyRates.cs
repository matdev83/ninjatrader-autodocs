[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class BrokerageCurrencyRates : IMessage<BrokerageCurrencyRates>, IMessage, IEquatable<BrokerageCurrencyRates>, IDeepCloneable<BrokerageCurrencyRates>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<BrokerageCurrencyRates> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the BrokerageId.
        /// </summary>
        [DataMember]
        public UInt32 BrokerageId { get; set; }
        /// <summary>
        /// Gets or sets the MasterCurrency.
        /// </summary>
        [DataMember]
        public String MasterCurrency { get; set; }
        /// <summary>
        /// Gets or sets the StatementDate.
        /// </summary>
        [DataMember]
        public Int64 StatementDate { get; set; }
        /// <summary>
        /// Gets or sets the CurrencyRate.
        /// </summary>
        [DataMember]
        public RepeatedField<CurrencyRate> CurrencyRate { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>BrokerageCurrencyRates</returns>
        public BrokerageCurrencyRates Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">BrokerageCurrencyRates</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(BrokerageCurrencyRates other);
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
        /// <param name="other">BrokerageCurrencyRates</param>
        public Void MergeFrom(BrokerageCurrencyRates other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
