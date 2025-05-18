[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Strategies
{
    public partial class MatReversalBarStrategyLimit : Strategy
    {
        #region Properties
        /// <summary>
        /// Gets or sets the StopLossOffsetPercent.
        /// </summary>
        [DataMember]
        public Double StopLossOffsetPercent { get; set; }
        /// <summary>
        /// Gets or sets the TakeProfit1OffsetPercent.
        /// </summary>
        [DataMember]
        public Double TakeProfit1OffsetPercent { get; set; }
        /// <summary>
        /// Gets or sets the TakeProfit2OffsetPercent.
        /// </summary>
        [DataMember]
        public Double TakeProfit2OffsetPercent { get; set; }
        /// <summary>
        /// Gets or sets the ExitOnOppositeSignal.
        /// </summary>
        [DataMember]
        public Boolean ExitOnOppositeSignal { get; set; }
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
        /// Gets or sets the TradeSundays.
        /// </summary>
        [DataMember]
        public Boolean TradeSundays { get; set; }
        /// <summary>
        /// Gets or sets the TradeMondays.
        /// </summary>
        [DataMember]
        public Boolean TradeMondays { get; set; }
        /// <summary>
        /// Gets or sets the TradeTuesdays.
        /// </summary>
        [DataMember]
        public Boolean TradeTuesdays { get; set; }
        /// <summary>
        /// Gets or sets the TradeWednesdays.
        /// </summary>
        [DataMember]
        public Boolean TradeWednesdays { get; set; }
        /// <summary>
        /// Gets or sets the TradeThursdays.
        /// </summary>
        [DataMember]
        public Boolean TradeThursdays { get; set; }
        /// <summary>
        /// Gets or sets the TradeFridays.
        /// </summary>
        [DataMember]
        public Boolean TradeFridays { get; set; }
        /// <summary>
        /// Gets or sets the TradeSaturdays.
        /// </summary>
        [DataMember]
        public Boolean TradeSaturdays { get; set; }
        /// <summary>
        /// Gets or sets the BreakevenOffsetTicks.
        /// </summary>
        [DataMember]
        public Int32 BreakevenOffsetTicks { get; set; }
        /// <summary>
        /// Gets or sets the EmaPeriod.
        /// </summary>
        [DataMember]
        public Int32 EmaPeriod { get; set; }
        /// <summary>
        /// Gets or sets the AdxPeriod.
        /// </summary>
        [DataMember]
        public Int32 AdxPeriod { get; set; }
        /// <summary>
        /// Gets or sets the AdxThreshold.
        /// </summary>
        [DataMember]
        public Int32 AdxThreshold { get; set; }
        /// <summary>
        /// Gets or sets the SessionEndTime.
        /// </summary>
        [DataMember]
        public Int32 SessionEndTime { get; set; }
        /// <summary>
        /// Gets or sets the SecondsToExitAheadOfClose.
        /// </summary>
        [DataMember]
        public Int32 SecondsToExitAheadOfClose { get; set; }
        /// <summary>
        /// Gets or sets the MinPriceDifferenceToRecalculate.
        /// </summary>
        [DataMember]
        public Int32 MinPriceDifferenceToRecalculate { get; set; }
        /// <summary>
        /// Gets or sets the MinTimeBetweenRangeRecalculations.
        /// </summary>
        [DataMember]
        public Int32 MinTimeBetweenRangeRecalculations { get; set; }
        /// <summary>
        /// Gets or sets the MaxDistanceFromEMAPercent.
        /// </summary>
        [DataMember]
        public Double MaxDistanceFromEMAPercent { get; set; }
        /// <summary>
        /// Gets or sets the MaxBarsToWait.
        /// </summary>
        [DataMember]
        public Int32 MaxBarsToWait { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
