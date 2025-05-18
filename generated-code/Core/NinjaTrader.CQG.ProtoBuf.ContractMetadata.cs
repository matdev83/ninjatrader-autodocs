[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class ContractMetadata : IMessage<ContractMetadata>, IMessage, IEquatable<ContractMetadata>, IDeepCloneable<ContractMetadata>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<ContractMetadata> Parser { get; set; }
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
        /// Gets or sets the ContractSymbol.
        /// </summary>
        [DataMember]
        public String ContractSymbol { get; set; }
        /// <summary>
        /// Gets or sets the CorrectPriceScale.
        /// </summary>
        [DataMember]
        public Double CorrectPriceScale { get; set; }
        /// <summary>
        /// Gets or sets the DisplayPriceScale.
        /// </summary>
        [DataMember]
        public UInt32 DisplayPriceScale { get; set; }
        /// <summary>
        /// Gets or sets the DiscretionaryDisplayPriceScale.
        /// </summary>
        [DataMember]
        public UInt32 DiscretionaryDisplayPriceScale { get; set; }
        /// <summary>
        /// Gets or sets the Description.
        /// </summary>
        [DataMember]
        public String Description { get; set; }
        /// <summary>
        /// Gets or sets the ExtendedDescription.
        /// </summary>
        [DataMember]
        public String ExtendedDescription { get; set; }
        /// <summary>
        /// Gets or sets the Title.
        /// </summary>
        [DataMember]
        public String Title { get; set; }
        /// <summary>
        /// Gets or sets the TickSize.
        /// </summary>
        [DataMember]
        public Double TickSize { get; set; }
        /// <summary>
        /// Gets or sets the DiscretionaryTickSize.
        /// </summary>
        [DataMember]
        public Double DiscretionaryTickSize { get; set; }
        /// <summary>
        /// Gets or sets the Currency.
        /// </summary>
        [DataMember]
        public String Currency { get; set; }
        /// <summary>
        /// Gets or sets the TickValue.
        /// </summary>
        [DataMember]
        public Double TickValue { get; set; }
        /// <summary>
        /// Gets or sets the CfiCode.
        /// </summary>
        [DataMember]
        public String CfiCode { get; set; }
        /// <summary>
        /// Gets or sets the IsMostActive.
        /// </summary>
        [DataMember]
        public Boolean IsMostActive { get; set; }
        /// <summary>
        /// Gets or sets the LastTradingDate.
        /// </summary>
        [DataMember]
        public Int64 LastTradingDate { get; set; }
        /// <summary>
        /// Gets or sets the FirstNoticeDate.
        /// </summary>
        [DataMember]
        public Int64 FirstNoticeDate { get; set; }
        /// <summary>
        /// Gets or sets the UnderlyingContractSymbol.
        /// </summary>
        [DataMember]
        public String UnderlyingContractSymbol { get; set; }
        /// <summary>
        /// Gets or sets the MarginStyle.
        /// </summary>
        [DataMember]
        public UInt32 MarginStyle { get; set; }
        /// <summary>
        /// Gets or sets the InstrumentGroupName.
        /// </summary>
        [DataMember]
        public String InstrumentGroupName { get; set; }
        /// <summary>
        /// Gets or sets the SessionInfoId.
        /// </summary>
        [DataMember]
        public Int32 SessionInfoId { get; set; }
        /// <summary>
        /// Gets or sets the Mic.
        /// </summary>
        [DataMember]
        public String Mic { get; set; }
        /// <summary>
        /// Gets or sets the MicDescription.
        /// </summary>
        [DataMember]
        public String MicDescription { get; set; }
        /// <summary>
        /// Gets or sets the Delay.
        /// </summary>
        [DataMember]
        public Int64 Delay { get; set; }
        /// <summary>
        /// Gets or sets the ShortInstrumentGroupName.
        /// </summary>
        [DataMember]
        public String ShortInstrumentGroupName { get; set; }
        /// <summary>
        /// Gets or sets the InstrumentGroupDescription.
        /// </summary>
        [DataMember]
        public String InstrumentGroupDescription { get; set; }
        /// <summary>
        /// Gets or sets the TickSizesByPrice.
        /// </summary>
        [DataMember]
        public RepeatedField<TickSizeByPrice> TickSizesByPrice { get; set; }
        /// <summary>
        /// Gets or sets the TickSizesByDte.
        /// </summary>
        [DataMember]
        public RepeatedField<TickSizeByDateTillExpiration> TickSizesByDte { get; set; }
        /// <summary>
        /// Gets or sets the TickSizesByDteId.
        /// </summary>
        [DataMember]
        public UInt32 TickSizesByDteId { get; set; }
        /// <summary>
        /// Gets or sets the Strike.
        /// </summary>
        [DataMember]
        public Int32 Strike { get; set; }
        /// <summary>
        /// Gets or sets the StrikePrice.
        /// </summary>
        [DataMember]
        public Double StrikePrice { get; set; }
        /// <summary>
        /// Gets or sets the DialectId.
        /// </summary>
        [DataMember]
        public String DialectId { get; set; }
        /// <summary>
        /// Gets or sets the CountryCode.
        /// </summary>
        [DataMember]
        public String CountryCode { get; set; }
        /// <summary>
        /// Gets or sets the StrategyDefinition.
        /// </summary>
        [DataMember]
        public StrategyDefinition StrategyDefinition { get; set; }
        /// <summary>
        /// Gets or sets the ContractSize.
        /// </summary>
        [DataMember]
        public String ContractSize { get; set; }
        /// <summary>
        /// Gets or sets the PositionTracking.
        /// </summary>
        [DataMember]
        public UInt32 PositionTracking { get; set; }
        /// <summary>
        /// Gets or sets the SpeculationTypeRequired.
        /// </summary>
        [DataMember]
        public Boolean SpeculationTypeRequired { get; set; }
        /// <summary>
        /// Gets or sets the MaturityMonthYear.
        /// </summary>
        [DataMember]
        public String MaturityMonthYear { get; set; }
        /// <summary>
        /// Gets or sets the PriceDisplayMode.
        /// </summary>
        [DataMember]
        public PriceDisplayMode PriceDisplayMode { get; set; }
        /// <summary>
        /// Gets or sets the DiscretionaryPriceDisplayMode.
        /// </summary>
        [DataMember]
        public PriceDisplayMode DiscretionaryPriceDisplayMode { get; set; }
        /// <summary>
        /// Gets or sets the ForeignCurrency.
        /// </summary>
        [DataMember]
        public String ForeignCurrency { get; set; }
        /// <summary>
        /// Gets or sets the VolumeScale.
        /// </summary>
        [DataMember]
        public Decimal VolumeScale { get; set; }
        /// <summary>
        /// Gets or sets the VolumeDisplayExponent.
        /// </summary>
        [DataMember]
        public Int32 VolumeDisplayExponent { get; set; }
        /// <summary>
        /// Gets or sets the TradeMinimumSize.
        /// </summary>
        [DataMember]
        public Decimal TradeMinimumSize { get; set; }
        /// <summary>
        /// Gets or sets the DomLadderCompressionRatio.
        /// </summary>
        [DataMember]
        public UInt32 DomLadderCompressionRatio { get; set; }
        /// <summary>
        /// Gets or sets the ExpectOffTickPrices.
        /// </summary>
        [DataMember]
        public Boolean ExpectOffTickPrices { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>ContractMetadata</returns>
        public ContractMetadata Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">ContractMetadata</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(ContractMetadata other);
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
        /// <param name="other">ContractMetadata</param>
        public Void MergeFrom(ContractMetadata other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
