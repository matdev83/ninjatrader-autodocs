[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.Strategies
{
    public partial class MatPriorHodLodReversal : Strategy
    {
        #region Properties
        /// <summary>
        /// Gets or sets the StopLossPercent.
        /// </summary>
        [DataMember]
        public Double StopLossPercent { get; set; }
        /// <summary>
        /// Gets or sets the TakeProfitPercent.
        /// </summary>
        [DataMember]
        public Double TakeProfitPercent { get; set; }
        /// <summary>
        /// Gets or sets the DailyTradeLimit.
        /// </summary>
        [DataMember]
        public Int32 DailyTradeLimit { get; set; }
        /// <summary>
        /// Gets or sets the WarmUpBars.
        /// </summary>
        [DataMember]
        public Int32 WarmUpBars { get; set; }
        /// <summary>
        /// Gets or sets the DebugOutput.
        /// </summary>
        [DataMember]
        public Boolean DebugOutput { get; set; }
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
        /// Gets or sets the HourStart1.
        /// </summary>
        [DataMember]
        public Int32 HourStart1 { get; set; }
        /// <summary>
        /// Gets or sets the MinuteStart1.
        /// </summary>
        [DataMember]
        public Int32 MinuteStart1 { get; set; }
        /// <summary>
        /// Gets or sets the HourEnd1.
        /// </summary>
        [DataMember]
        public Int32 HourEnd1 { get; set; }
        /// <summary>
        /// Gets or sets the MinuteEnd1.
        /// </summary>
        [DataMember]
        public Int32 MinuteEnd1 { get; set; }
        /// <summary>
        /// Gets or sets the HourStart2.
        /// </summary>
        [DataMember]
        public Int32 HourStart2 { get; set; }
        /// <summary>
        /// Gets or sets the MinuteStart2.
        /// </summary>
        [DataMember]
        public Int32 MinuteStart2 { get; set; }
        /// <summary>
        /// Gets or sets the HourEnd2.
        /// </summary>
        [DataMember]
        public Int32 HourEnd2 { get; set; }
        /// <summary>
        /// Gets or sets the MinuteEnd2.
        /// </summary>
        [DataMember]
        public Int32 MinuteEnd2 { get; set; }
        /// <summary>
        /// Gets or sets the HourStart3.
        /// </summary>
        [DataMember]
        public Int32 HourStart3 { get; set; }
        /// <summary>
        /// Gets or sets the MinuteStart3.
        /// </summary>
        [DataMember]
        public Int32 MinuteStart3 { get; set; }
        /// <summary>
        /// Gets or sets the HourEnd3.
        /// </summary>
        [DataMember]
        public Int32 HourEnd3 { get; set; }
        /// <summary>
        /// Gets or sets the MinuteEnd3.
        /// </summary>
        [DataMember]
        public Int32 MinuteEnd3 { get; set; }
        /// <summary>
        /// Gets or sets the HourStart4.
        /// </summary>
        [DataMember]
        public Int32 HourStart4 { get; set; }
        /// <summary>
        /// Gets or sets the MinuteStart4.
        /// </summary>
        [DataMember]
        public Int32 MinuteStart4 { get; set; }
        /// <summary>
        /// Gets or sets the HourEnd4.
        /// </summary>
        [DataMember]
        public Int32 HourEnd4 { get; set; }
        /// <summary>
        /// Gets or sets the MinuteEnd4.
        /// </summary>
        [DataMember]
        public Int32 MinuteEnd4 { get; set; }
        /// <summary>
        /// Gets or sets the HourStart5.
        /// </summary>
        [DataMember]
        public Int32 HourStart5 { get; set; }
        /// <summary>
        /// Gets or sets the MinuteStart5.
        /// </summary>
        [DataMember]
        public Int32 MinuteStart5 { get; set; }
        /// <summary>
        /// Gets or sets the HourEnd5.
        /// </summary>
        [DataMember]
        public Int32 HourEnd5 { get; set; }
        /// <summary>
        /// Gets or sets the MinuteEnd5.
        /// </summary>
        [DataMember]
        public Int32 MinuteEnd5 { get; set; }
        /// <summary>
        /// Gets or sets the HourStart6.
        /// </summary>
        [DataMember]
        public Int32 HourStart6 { get; set; }
        /// <summary>
        /// Gets or sets the MinuteStart6.
        /// </summary>
        [DataMember]
        public Int32 MinuteStart6 { get; set; }
        /// <summary>
        /// Gets or sets the HourEnd6.
        /// </summary>
        [DataMember]
        public Int32 HourEnd6 { get; set; }
        /// <summary>
        /// Gets or sets the MinuteEnd6.
        /// </summary>
        [DataMember]
        public Int32 MinuteEnd6 { get; set; }
        /// <summary>
        /// Gets or sets the TradeSunday.
        /// </summary>
        [DataMember]
        public Boolean TradeSunday { get; set; }
        /// <summary>
        /// Gets or sets the TradeMonday.
        /// </summary>
        [DataMember]
        public Boolean TradeMonday { get; set; }
        /// <summary>
        /// Gets or sets the TradeTuesday.
        /// </summary>
        [DataMember]
        public Boolean TradeTuesday { get; set; }
        /// <summary>
        /// Gets or sets the TradeWednesday.
        /// </summary>
        [DataMember]
        public Boolean TradeWednesday { get; set; }
        /// <summary>
        /// Gets or sets the TradeThursday.
        /// </summary>
        [DataMember]
        public Boolean TradeThursday { get; set; }
        /// <summary>
        /// Gets or sets the TradeFriday.
        /// </summary>
        [DataMember]
        public Boolean TradeFriday { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
