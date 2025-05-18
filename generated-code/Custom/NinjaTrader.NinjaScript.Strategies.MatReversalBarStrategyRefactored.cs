[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Strategies
{
    public partial class MatReversalBarStrategyRefactored : Strategy
    {
        #region Properties
        /// <summary>
        /// Gets or sets the TrendTicks.
        /// </summary>
        [DataMember]
        public Int32 TrendTicks { get; set; }
        /// <summary>
        /// Gets or sets the OpenOffset.
        /// </summary>
        [DataMember]
        public Int32 OpenOffset { get; set; }
        /// <summary>
        /// Gets or sets the TicksReversal.
        /// </summary>
        [DataMember]
        public Int32 TicksReversal { get; set; }
        /// <summary>
        /// Gets or sets the StopLossAtrMultiplier.
        /// </summary>
        [DataMember]
        public Double StopLossAtrMultiplier { get; set; }
        /// <summary>
        /// Gets or sets the TakeProfit1AtrMultiplier.
        /// </summary>
        [DataMember]
        public Double TakeProfit1AtrMultiplier { get; set; }
        /// <summary>
        /// Gets or sets the TakeProfit2AtrMultiplier.
        /// </summary>
        [DataMember]
        public Double TakeProfit2AtrMultiplier { get; set; }
        /// <summary>
        /// Gets or sets the ExitOnOppositeSignal.
        /// </summary>
        [DataMember]
        public Boolean ExitOnOppositeSignal { get; set; }
        /// <summary>
        /// Gets or sets the BreakevenOffsetTicks.
        /// </summary>
        [DataMember]
        public Int32 BreakevenOffsetTicks { get; set; }
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
        /// Gets or sets the MaxDistanceFromEMAPercent.
        /// </summary>
        [DataMember]
        public Double MaxDistanceFromEMAPercent { get; set; }
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
        /// Gets or sets the AtrPeriod.
        /// </summary>
        [DataMember]
        public Int32 AtrPeriod { get; set; }
        /// <summary>
        /// Gets or sets the VolumePerBar.
        /// </summary>
        [DataMember]
        public Int32 VolumePerBar { get; set; }
        /// <summary>
        /// Gets or sets the MinEmaChange.
        /// </summary>
        [DataMember]
        public Double MinEmaChange { get; set; }
        /// <summary>
        /// Gets or sets the VolumeEmaPeriod.
        /// </summary>
        [DataMember]
        public Int32 VolumeEmaPeriod { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
