[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class TradeCollection : Collection<Trade>
    {
        #region Properties
        /// <summary>
        /// Gets or sets the ByHalfHour.
        /// </summary>
        [DataMember]
        public Dictionary<Object, TradeCollection> ByHalfHour { get; set; }
        /// <summary>
        /// Gets or sets the ByHalfHourEntry.
        /// </summary>
        [DataMember]
        public Dictionary<Object, TradeCollection> ByHalfHourEntry { get; set; }
        /// <summary>
        /// Gets or sets the ByHour.
        /// </summary>
        [DataMember]
        public Dictionary<Object, TradeCollection> ByHour { get; set; }
        /// <summary>
        /// Gets or sets the ByHourEntry.
        /// </summary>
        [DataMember]
        public Dictionary<Object, TradeCollection> ByHourEntry { get; set; }
        /// <summary>
        /// Gets or sets the ByDay.
        /// </summary>
        [DataMember]
        public Dictionary<Object, TradeCollection> ByDay { get; set; }
        /// <summary>
        /// Gets or sets the ByDayEntry.
        /// </summary>
        [DataMember]
        public Dictionary<Object, TradeCollection> ByDayEntry { get; set; }
        /// <summary>
        /// Gets or sets the ByDayOfWeek.
        /// </summary>
        [DataMember]
        public Dictionary<Object, TradeCollection> ByDayOfWeek { get; set; }
        /// <summary>
        /// Gets or sets the ByDayOfWeekEntry.
        /// </summary>
        [DataMember]
        public Dictionary<Object, TradeCollection> ByDayOfWeekEntry { get; set; }
        /// <summary>
        /// Gets or sets the ByMonth.
        /// </summary>
        [DataMember]
        public Dictionary<Object, TradeCollection> ByMonth { get; set; }
        /// <summary>
        /// Gets or sets the ByMonthEntry.
        /// </summary>
        [DataMember]
        public Dictionary<Object, TradeCollection> ByMonthEntry { get; set; }
        /// <summary>
        /// Gets or sets the ByMonthOfYear.
        /// </summary>
        [DataMember]
        public Dictionary<Object, TradeCollection> ByMonthOfYear { get; set; }
        /// <summary>
        /// Gets or sets the ByMonthOfYearEntry.
        /// </summary>
        [DataMember]
        public Dictionary<Object, TradeCollection> ByMonthOfYearEntry { get; set; }
        /// <summary>
        /// Gets or sets the ByWeek.
        /// </summary>
        [DataMember]
        public Dictionary<Object, TradeCollection> ByWeek { get; set; }
        /// <summary>
        /// Gets or sets the ByWeekEntry.
        /// </summary>
        [DataMember]
        public Dictionary<Object, TradeCollection> ByWeekEntry { get; set; }
        /// <summary>
        /// Gets or sets the ByYear.
        /// </summary>
        [DataMember]
        public Dictionary<Object, TradeCollection> ByYear { get; set; }
        /// <summary>
        /// Gets or sets the ByYearEntry.
        /// </summary>
        [DataMember]
        public Dictionary<Object, TradeCollection> ByYearEntry { get; set; }
        /// <summary>
        /// Gets or sets the EvenTrades.
        /// </summary>
        [DataMember]
        public TradeCollection EvenTrades { get; set; }
        /// <summary>
        /// Gets or sets the LosingTrades.
        /// </summary>
        [DataMember]
        public TradeCollection LosingTrades { get; set; }
        /// <summary>
        /// Gets or sets the MinTickSize.
        /// </summary>
        [DataMember]
        public Double MinTickSize { get; set; }
        /// <summary>
        /// Gets or sets the TradesPerformance.
        /// </summary>
        [DataMember]
        public TradesPerformance TradesPerformance { get; set; }
        /// <summary>
        /// Gets or sets the WinningTrades.
        /// </summary>
        [DataMember]
        public TradeCollection WinningTrades { get; set; }
        /// <summary>
        /// Gets or sets the TradesCount.
        /// </summary>
        [DataMember]
        public Int32 TradesCount { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Add method.
        /// </summary>
        /// <param name="trade">Trade</param>
        public Void Add(Trade trade);
        /// <summary>
        /// GetTrades method.
        /// </summary>
        /// <param name="instrumentName">String</param>
        /// <param name="entrySignalName">String</param>
        /// <param name="instance">Int32</param>
        /// <returns>TradeCollection</returns>
        public TradeCollection GetTrades(String instrumentName, String entrySignalName, Int32 instance);
        #endregion
    }
}
