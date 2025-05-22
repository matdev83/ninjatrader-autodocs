[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class TradeCollection : System.Collections.ObjectModel.Collection<NinjaTrader.Cbi.Trade>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the ByHalfHour.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<object, NinjaTrader.Cbi.TradeCollection> ByHalfHour { get; set; }
        /// <summary>
        /// Gets or sets the ByHalfHourEntry.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<object, NinjaTrader.Cbi.TradeCollection> ByHalfHourEntry { get; set; }
        /// <summary>
        /// Gets or sets the ByHour.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<object, NinjaTrader.Cbi.TradeCollection> ByHour { get; set; }
        /// <summary>
        /// Gets or sets the ByHourEntry.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<object, NinjaTrader.Cbi.TradeCollection> ByHourEntry { get; set; }
        /// <summary>
        /// Gets or sets the ByDay.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<object, NinjaTrader.Cbi.TradeCollection> ByDay { get; set; }
        /// <summary>
        /// Gets or sets the ByDayEntry.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<object, NinjaTrader.Cbi.TradeCollection> ByDayEntry { get; set; }
        /// <summary>
        /// Gets or sets the ByDayOfWeek.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<object, NinjaTrader.Cbi.TradeCollection> ByDayOfWeek { get; set; }
        /// <summary>
        /// Gets or sets the ByDayOfWeekEntry.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<object, NinjaTrader.Cbi.TradeCollection> ByDayOfWeekEntry { get; set; }
        /// <summary>
        /// Gets or sets the ByMonth.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<object, NinjaTrader.Cbi.TradeCollection> ByMonth { get; set; }
        /// <summary>
        /// Gets or sets the ByMonthEntry.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<object, NinjaTrader.Cbi.TradeCollection> ByMonthEntry { get; set; }
        /// <summary>
        /// Gets or sets the ByMonthOfYear.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<object, NinjaTrader.Cbi.TradeCollection> ByMonthOfYear { get; set; }
        /// <summary>
        /// Gets or sets the ByMonthOfYearEntry.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<object, NinjaTrader.Cbi.TradeCollection> ByMonthOfYearEntry { get; set; }
        /// <summary>
        /// Gets or sets the ByWeek.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<object, NinjaTrader.Cbi.TradeCollection> ByWeek { get; set; }
        /// <summary>
        /// Gets or sets the ByWeekEntry.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<object, NinjaTrader.Cbi.TradeCollection> ByWeekEntry { get; set; }
        /// <summary>
        /// Gets or sets the ByYear.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<object, NinjaTrader.Cbi.TradeCollection> ByYear { get; set; }
        /// <summary>
        /// Gets or sets the ByYearEntry.
        /// </summary>
        [DataMember]
        public System.Collections.Generic.Dictionary<object, NinjaTrader.Cbi.TradeCollection> ByYearEntry { get; set; }
        /// <summary>
        /// Gets or sets the EvenTrades.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.TradeCollection EvenTrades { get; set; }
        /// <summary>
        /// Gets or sets the LosingTrades.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.TradeCollection LosingTrades { get; set; }
        /// <summary>
        /// Gets or sets the MinTickSize.
        /// </summary>
        [DataMember]
        public double MinTickSize { get; set; }
        /// <summary>
        /// Gets or sets the TradesPerformance.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.TradesPerformance TradesPerformance { get; set; }
        /// <summary>
        /// Gets or sets the WinningTrades.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.TradeCollection WinningTrades { get; set; }
        /// <summary>
        /// Gets or sets the TradesCount.
        /// </summary>
        [DataMember]
        public int TradesCount { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Add method.
        /// </summary>
        /// <param name="trade">NinjaTrader.Cbi.Trade</param>
        public void Add(NinjaTrader.Cbi.Trade trade)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetTrades method.
        /// </summary>
        /// <param name="instrumentName">string</param>
        /// <param name="entrySignalName">string</param>
        /// <param name="instance">int</param>
        /// <returns>NinjaTrader.Cbi.TradeCollection</returns>
        public NinjaTrader.Cbi.TradeCollection GetTrades(string instrumentName, string entrySignalName, int instance)
        {
            // Method implementation goes here
        }
        #endregion
    }
}
