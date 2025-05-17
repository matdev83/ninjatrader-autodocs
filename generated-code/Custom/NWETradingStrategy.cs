[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Strategies
{
    public partial class NWETradingStrategy : Strategy
    {
        #region Properties
        /// <summary>
        /// Gets or sets the TPEnvelopeDistanceMult.
        /// </summary>
        [DataMember]
        public Double TPEnvelopeDistanceMult { get; set; }
        /// <summary>
        /// Gets or sets the SLEnvelopeDistanceMult.
        /// </summary>
        [DataMember]
        public Double SLEnvelopeDistanceMult { get; set; }
        /// <summary>
        /// Gets or sets the TradeLongs.
        /// </summary>
        [DataMember]
        public Boolean TradeLongs { get; set; }
        /// <summary>
        /// Gets or sets the TradeShorts.
        /// </summary>
        [DataMember]
        public Boolean TradeShorts { get; set; }
        /// <summary>
        /// Gets or sets the HurstExponentLength.
        /// </summary>
        [DataMember]
        public Int32 HurstExponentLength { get; set; }
        /// <summary>
        /// Gets or sets the HurstExponentBaseScale.
        /// </summary>
        [DataMember]
        public Int32 HurstExponentBaseScale { get; set; }
        /// <summary>
        /// Gets or sets the HurstExponentMaxScale.
        /// </summary>
        [DataMember]
        public Int32 HurstExponentMaxScale { get; set; }
        /// <summary>
        /// Gets or sets the HurstExponentMaxValue.
        /// </summary>
        [DataMember]
        public Double HurstExponentMaxValue { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
