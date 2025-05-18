[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Strategies
{
    public partial class MatORBv2 : Strategy
    {
        #region Properties
        /// <summary>
        /// Gets or sets the ORStartHour.
        /// </summary>
        [DataMember]
        public Int32 ORStartHour { get; set; }
        /// <summary>
        /// Gets or sets the ORStartMinute.
        /// </summary>
        [DataMember]
        public Int32 ORStartMinute { get; set; }
        /// <summary>
        /// Gets or sets the ORDurationSeconds.
        /// </summary>
        [DataMember]
        public Int32 ORDurationSeconds { get; set; }
        /// <summary>
        /// Gets or sets the MaxORSizePts.
        /// </summary>
        [DataMember]
        public Double MaxORSizePts { get; set; }
        /// <summary>
        /// Gets or sets the TradeStartMinutesAfterOR.
        /// </summary>
        [DataMember]
        public Int32 TradeStartMinutesAfterOR { get; set; }
        /// <summary>
        /// Gets or sets the TradeWindowDurationMinutes.
        /// </summary>
        [DataMember]
        public Int32 TradeWindowDurationMinutes { get; set; }
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
        /// Gets or sets the UseORMultiplesInsteadATRAsTargets.
        /// </summary>
        [DataMember]
        public Boolean UseORMultiplesInsteadATRAsTargets { get; set; }
        /// <summary>
        /// Gets or sets the ATRLen.
        /// </summary>
        [DataMember]
        public Int32 ATRLen { get; set; }
        /// <summary>
        /// Gets or sets the TP1Mult.
        /// </summary>
        [DataMember]
        public Double TP1Mult { get; set; }
        /// <summary>
        /// Gets or sets the TP2Mult.
        /// </summary>
        [DataMember]
        public Double TP2Mult { get; set; }
        /// <summary>
        /// Gets or sets the TP3Mult.
        /// </summary>
        [DataMember]
        public Double TP3Mult { get; set; }
        /// <summary>
        /// Gets or sets the SLORMult.
        /// </summary>
        [DataMember]
        public Double SLORMult { get; set; }
        /// <summary>
        /// Gets or sets the TradeLimitLookback.
        /// </summary>
        [DataMember]
        public Int32 TradeLimitLookback { get; set; }
        /// <summary>
        /// Gets or sets the TradeLimitNumber.
        /// </summary>
        [DataMember]
        public Int32 TradeLimitNumber { get; set; }
        /// <summary>
        /// Gets or sets the TrailingStopTimeStep.
        /// </summary>
        [DataMember]
        public Double TrailingStopTimeStep { get; set; }
        /// <summary>
        /// Gets or sets the MaxGapUpPercentLongs.
        /// </summary>
        [DataMember]
        public Double MaxGapUpPercentLongs { get; set; }
        /// <summary>
        /// Gets or sets the GapUpRangeWidthFromTopPercentLongs.
        /// </summary>
        [DataMember]
        public Double GapUpRangeWidthFromTopPercentLongs { get; set; }
        /// <summary>
        /// Gets or sets the MaxGapDownPercentLongs.
        /// </summary>
        [DataMember]
        public Double MaxGapDownPercentLongs { get; set; }
        /// <summary>
        /// Gets or sets the GapDownRangeWidthFromBottomPercentLongs.
        /// </summary>
        [DataMember]
        public Double GapDownRangeWidthFromBottomPercentLongs { get; set; }
        /// <summary>
        /// Gets or sets the MaxGapUpPercentShorts.
        /// </summary>
        [DataMember]
        public Double MaxGapUpPercentShorts { get; set; }
        /// <summary>
        /// Gets or sets the GapUpRangeWidthFromTopPercentShorts.
        /// </summary>
        [DataMember]
        public Double GapUpRangeWidthFromTopPercentShorts { get; set; }
        /// <summary>
        /// Gets or sets the MaxGapDownPercentShorts.
        /// </summary>
        [DataMember]
        public Double MaxGapDownPercentShorts { get; set; }
        /// <summary>
        /// Gets or sets the GapDownRangeWidthFromBottomPercentShorts.
        /// </summary>
        [DataMember]
        public Double GapDownRangeWidthFromBottomPercentShorts { get; set; }
        /// <summary>
        /// Gets or sets the SettleHour.
        /// </summary>
        [DataMember]
        public Double SettleHour { get; set; }
        /// <summary>
        /// Gets or sets the SettleMinute.
        /// </summary>
        [DataMember]
        public Double SettleMinute { get; set; }
        /// <summary>
        /// Gets or sets the ORHLine.
        /// </summary>
        [DataMember]
        public Series<Double> ORHLine { get; set; }
        /// <summary>
        /// Gets or sets the ORLLine.
        /// </summary>
        [DataMember]
        public Series<Double> ORLLine { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
