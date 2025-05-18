[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class InformationReport : IMessage<InformationReport>, IMessage, IEquatable<InformationReport>, IDeepCloneable<InformationReport>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<InformationReport> Parser { get; set; }
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
        /// Gets or sets the IsReportComplete.
        /// </summary>
        [DataMember]
        public Boolean IsReportComplete { get; set; }
        /// <summary>
        /// Gets or sets the StatusCode.
        /// </summary>
        [DataMember]
        public UInt32 StatusCode { get; set; }
        /// <summary>
        /// Gets or sets the TextMessage.
        /// </summary>
        [DataMember]
        public String TextMessage { get; set; }
        /// <summary>
        /// Gets or sets the AccountsReport.
        /// </summary>
        [DataMember]
        public AccountsReport AccountsReport { get; set; }
        /// <summary>
        /// Gets or sets the SymbolResolutionReport.
        /// </summary>
        [DataMember]
        public SymbolResolutionReport SymbolResolutionReport { get; set; }
        /// <summary>
        /// Gets or sets the LastStatementBalancesReport.
        /// </summary>
        [DataMember]
        public LastStatementBalancesReport LastStatementBalancesReport { get; set; }
        /// <summary>
        /// Gets or sets the CurrencyRatesReport.
        /// </summary>
        [DataMember]
        public CurrencyRatesReport CurrencyRatesReport { get; set; }
        /// <summary>
        /// Gets or sets the SessionInformationReport.
        /// </summary>
        [DataMember]
        public SessionInformationReport SessionInformationReport { get; set; }
        /// <summary>
        /// Gets or sets the HistoricalOrdersReport.
        /// </summary>
        [DataMember]
        public HistoricalOrdersReport HistoricalOrdersReport { get; set; }
        /// <summary>
        /// Gets or sets the SymbolsByUnderlyingReport.
        /// </summary>
        [DataMember]
        public SymbolsByUnderlyingReport SymbolsByUnderlyingReport { get; set; }
        /// <summary>
        /// Gets or sets the ChildSymbolsReport.
        /// </summary>
        [DataMember]
        public ChildSymbolsReport ChildSymbolsReport { get; set; }
        /// <summary>
        /// Gets or sets the AtTheMoneyStrikeReport.
        /// </summary>
        [DataMember]
        public AtTheMoneyStrikeReport AtTheMoneyStrikeReport { get; set; }
        /// <summary>
        /// Gets or sets the StrategyDefinitionReport.
        /// </summary>
        [DataMember]
        public StrategyDefinitionReport StrategyDefinitionReport { get; set; }
        /// <summary>
        /// Gets or sets the SessionTimerangeReport.
        /// </summary>
        [DataMember]
        public SessionTimeRangeReport SessionTimerangeReport { get; set; }
        /// <summary>
        /// Gets or sets the TradingDayTimerangeReport.
        /// </summary>
        [DataMember]
        public TradingDayTimeRangeReport TradingDayTimerangeReport { get; set; }
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
        /// <returns>InformationReport</returns>
        public InformationReport Clone();
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
        /// <param name="other">InformationReport</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(InformationReport other);
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
        /// <param name="other">InformationReport</param>
        public Void MergeFrom(InformationReport other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
