[Serializable]
[DataContract]
namespace NinjaTrader.Cbi
{
    public partial class TradesPerformance
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AverageBarsInTrade.
        /// </summary>
        [DataMember]
        public Double AverageBarsInTrade { get; set; }
        /// <summary>
        /// Gets or sets the AverageEntryEfficiency.
        /// </summary>
        [DataMember]
        public Double AverageEntryEfficiency { get; set; }
        /// <summary>
        /// Gets or sets the AverageExitEfficiency.
        /// </summary>
        [DataMember]
        public Double AverageExitEfficiency { get; set; }
        /// <summary>
        /// Gets or sets the AverageTimeInMarket.
        /// </summary>
        [DataMember]
        public TimeSpan AverageTimeInMarket { get; set; }
        /// <summary>
        /// Gets or sets the AverageTimeInMarketSerializable.
        /// </summary>
        [DataMember]
        public Int64 AverageTimeInMarketSerializable { get; set; }
        /// <summary>
        /// Gets or sets the AverageTotalEfficiency.
        /// </summary>
        [DataMember]
        public Double AverageTotalEfficiency { get; set; }
        /// <summary>
        /// Gets or sets the Currency.
        /// </summary>
        [DataMember]
        public TradesPerformanceValues Currency { get; set; }
        /// <summary>
        /// Gets or sets the GrossLoss.
        /// </summary>
        [DataMember]
        public Double GrossLoss { get; set; }
        /// <summary>
        /// Gets or sets the GrossProfit.
        /// </summary>
        [DataMember]
        public Double GrossProfit { get; set; }
        /// <summary>
        /// Gets or sets the LongestFlatPeriod.
        /// </summary>
        [DataMember]
        public TimeSpan LongestFlatPeriod { get; set; }
        /// <summary>
        /// Gets or sets the LongestFlatPeriodSerializable.
        /// </summary>
        [DataMember]
        public Int64 LongestFlatPeriodSerializable { get; set; }
        /// <summary>
        /// Gets or sets the MaxConsecutiveLoser.
        /// </summary>
        [DataMember]
        public Int32 MaxConsecutiveLoser { get; set; }
        /// <summary>
        /// Gets or sets the MaxConsecutiveWinner.
        /// </summary>
        [DataMember]
        public Int32 MaxConsecutiveWinner { get; set; }
        /// <summary>
        /// Gets or sets the MaxDate.
        /// </summary>
        [DataMember]
        public DateTime MaxDate { get; set; }
        /// <summary>
        /// Gets or sets the MaxTimeToRecover.
        /// </summary>
        [DataMember]
        public TimeSpan MaxTimeToRecover { get; set; }
        /// <summary>
        /// Gets or sets the MaxTime2RecoverSerializable.
        /// </summary>
        [DataMember]
        public Int64 MaxTime2RecoverSerializable { get; set; }
        /// <summary>
        /// Gets or sets the MinDate.
        /// </summary>
        [DataMember]
        public DateTime MinDate { get; set; }
        /// <summary>
        /// Gets or sets the MonthlyStdDev.
        /// </summary>
        [DataMember]
        public Double MonthlyStdDev { get; set; }
        /// <summary>
        /// Gets or sets the MonthlyUlcer.
        /// </summary>
        [DataMember]
        public Double MonthlyUlcer { get; set; }
        /// <summary>
        /// Gets or sets the MonthlyDownTarget.
        /// </summary>
        [DataMember]
        public Double MonthlyDownTarget { get; set; }
        /// <summary>
        /// Gets or sets the NeedsUpdate.
        /// </summary>
        [DataMember]
        public Boolean NeedsUpdate { get; set; }
        /// <summary>
        /// Gets or sets the NetProfit.
        /// </summary>
        [DataMember]
        public Double NetProfit { get; set; }
        /// <summary>
        /// Gets or sets the Percent.
        /// </summary>
        [DataMember]
        public TradesPerformanceValues Percent { get; set; }
        /// <summary>
        /// Gets or sets the PerformanceMetrics.
        /// </summary>
        [DataMember]
        public PerformanceMetricBase[] PerformanceMetrics { get; set; }
        /// <summary>
        /// Gets or sets the Pips.
        /// </summary>
        [DataMember]
        public TradesPerformanceValues Pips { get; set; }
        /// <summary>
        /// Gets or sets the Points.
        /// </summary>
        [DataMember]
        public TradesPerformanceValues Points { get; set; }
        /// <summary>
        /// Gets or sets the Probability.
        /// </summary>
        [DataMember]
        public Double Probability { get; set; }
        /// <summary>
        /// Gets or sets the ProfitFactor.
        /// </summary>
        [DataMember]
        public Double ProfitFactor { get; set; }
        /// <summary>
        /// Gets or sets the RiskFreeReturn.
        /// </summary>
        [DataMember]
        public Double RiskFreeReturn { get; set; }
        /// <summary>
        /// Gets or sets the RSquared.
        /// </summary>
        [DataMember]
        public Double RSquared { get; set; }
        /// <summary>
        /// Gets or sets the SharpeRatio.
        /// </summary>
        [DataMember]
        public Double SharpeRatio { get; set; }
        /// <summary>
        /// Gets or sets the SortinoRatio.
        /// </summary>
        [DataMember]
        public Double SortinoRatio { get; set; }
        /// <summary>
        /// Gets or sets the Ticks.
        /// </summary>
        [DataMember]
        public TradesPerformanceValues Ticks { get; set; }
        /// <summary>
        /// Gets or sets the TotalQuantity.
        /// </summary>
        [DataMember]
        public Int32 TotalQuantity { get; set; }
        /// <summary>
        /// Gets or sets the TradesCount.
        /// </summary>
        [DataMember]
        public Int32 TradesCount { get; set; }
        /// <summary>
        /// Gets or sets the TradesPerDay.
        /// </summary>
        [DataMember]
        public Double TradesPerDay { get; set; }
        /// <summary>
        /// Gets or sets the TotalCommission.
        /// </summary>
        [DataMember]
        public Double TotalCommission { get; set; }
        /// <summary>
        /// Gets or sets the TotalSlippage.
        /// </summary>
        [DataMember]
        public Double TotalSlippage { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
