[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class InformationRequest : IMessage<InformationRequest>, IMessage, IEquatable<InformationRequest>, IDeepCloneable<InformationRequest>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<InformationRequest> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public UInt32 Id { get; set; }
        /// <summary>
        /// Gets or sets the Subscribe.
        /// </summary>
        [DataMember]
        public Boolean Subscribe { get; set; }
        /// <summary>
        /// Gets or sets the AccountsRequest.
        /// </summary>
        [DataMember]
        public AccountsRequest AccountsRequest { get; set; }
        /// <summary>
        /// Gets or sets the SymbolResolutionRequest.
        /// </summary>
        [DataMember]
        public SymbolResolutionRequest SymbolResolutionRequest { get; set; }
        /// <summary>
        /// Gets or sets the LastStatementBalancesRequest.
        /// </summary>
        [DataMember]
        public LastStatementBalancesRequest LastStatementBalancesRequest { get; set; }
        /// <summary>
        /// Gets or sets the CurrencyRatesRequest.
        /// </summary>
        [DataMember]
        public CurrencyRatesRequest CurrencyRatesRequest { get; set; }
        /// <summary>
        /// Gets or sets the SessionInformationRequest.
        /// </summary>
        [DataMember]
        public SessionInformationRequest SessionInformationRequest { get; set; }
        /// <summary>
        /// Gets or sets the HistoricalOrdersRequest.
        /// </summary>
        [DataMember]
        public HistoricalOrdersRequest HistoricalOrdersRequest { get; set; }
        /// <summary>
        /// Gets or sets the SymbolsByUnderlyingRequest.
        /// </summary>
        [DataMember]
        public SymbolsByUnderlyingRequest SymbolsByUnderlyingRequest { get; set; }
        /// <summary>
        /// Gets or sets the ChildSymbolsRequest.
        /// </summary>
        [DataMember]
        public ChildSymbolsRequest ChildSymbolsRequest { get; set; }
        /// <summary>
        /// Gets or sets the AtTheMoneyStrikeRequest.
        /// </summary>
        [DataMember]
        public AtTheMoneyStrikeRequest AtTheMoneyStrikeRequest { get; set; }
        /// <summary>
        /// Gets or sets the StrategyDefinitionRequest.
        /// </summary>
        [DataMember]
        public StrategyDefinitionRequest StrategyDefinitionRequest { get; set; }
        /// <summary>
        /// Gets or sets the SessionTimerangeRequest.
        /// </summary>
        [DataMember]
        public SessionTimeRangeRequest SessionTimerangeRequest { get; set; }
        /// <summary>
        /// Gets or sets the TradingDayTimerangeRequest.
        /// </summary>
        [DataMember]
        public TradingDayTimeRangeRequest TradingDayTimerangeRequest { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>InformationRequest</returns>
        public InformationRequest Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">InformationRequest</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(InformationRequest other);
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
        /// <param name="other">InformationRequest</param>
        public Void MergeFrom(InformationRequest other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
