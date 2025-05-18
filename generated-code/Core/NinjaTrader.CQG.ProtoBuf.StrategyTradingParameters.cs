[Serializable]
[DataContract]
namespace NinjaTrader.CQG.ProtoBuf
{
    public partial class StrategyTradingParameters : IMessage<StrategyTradingParameters>, IMessage, IEquatable<StrategyTradingParameters>, IDeepCloneable<StrategyTradingParameters>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Parser.
        /// </summary>
        [DataMember]
        public MessageParser<StrategyTradingParameters> Parser { get; set; }
        /// <summary>
        /// Gets or sets the Descriptor.
        /// </summary>
        [DataMember]
        public MessageDescriptor Descriptor { get; set; }
        /// <summary>
        /// Gets or sets the MarketOrderParameters.
        /// </summary>
        [DataMember]
        public RepeatedField<StrategyMarketOrderParameters> MarketOrderParameters { get; set; }
        /// <summary>
        /// Gets or sets the LimitOrderParameters.
        /// </summary>
        [DataMember]
        public RepeatedField<StrategyLimitOrderParameters> LimitOrderParameters { get; set; }
        /// <summary>
        /// Gets or sets the StopOrderParameters.
        /// </summary>
        [DataMember]
        public RepeatedField<StrategyStopOrderParameters> StopOrderParameters { get; set; }
        /// <summary>
        /// Gets or sets the AggregationParameters.
        /// </summary>
        [DataMember]
        public RepeatedField<StrategyAggregationParameters> AggregationParameters { get; set; }
        /// <summary>
        /// Gets or sets the LegParameters.
        /// </summary>
        [DataMember]
        public RepeatedField<StrategyOrderLegParameters> LegParameters { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Clone method.
        /// </summary>
        /// <returns>StrategyTradingParameters</returns>
        public StrategyTradingParameters Clone();
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">Object</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(Object other);
        /// <summary>
        /// Equals method.
        /// </summary>
        /// <param name="other">StrategyTradingParameters</param>
        /// <returns>Boolean</returns>
        public Boolean Equals(StrategyTradingParameters other);
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
        /// <param name="other">StrategyTradingParameters</param>
        public Void MergeFrom(StrategyTradingParameters other);
        /// <summary>
        /// MergeFrom method.
        /// </summary>
        /// <param name="input">CodedInputStream</param>
        public Void MergeFrom(CodedInputStream input);
        #endregion
    }
}
