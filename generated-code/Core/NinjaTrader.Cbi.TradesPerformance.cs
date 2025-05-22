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
        public double AverageBarsInTrade { get; set; }
        /// <summary>
        /// Gets or sets the AverageEntryEfficiency.
        /// </summary>
        [DataMember]
        public double AverageEntryEfficiency { get; set; }
        /// <summary>
        /// Gets or sets the AverageExitEfficiency.
        /// </summary>
        [DataMember]
        public double AverageExitEfficiency { get; set; }
        /// <summary>
        /// Gets or sets the AverageTimeInMarket.
        /// </summary>
        [DataMember]
        public System.TimeSpan AverageTimeInMarket { get; set; }
        /// <summary>
        /// Gets or sets the AverageTimeInMarketSerializable.
        /// </summary>
        [DataMember]
        public long AverageTimeInMarketSerializable { get; set; }
        /// <summary>
        /// Gets or sets the AverageTotalEfficiency.
        /// </summary>
        [DataMember]
        public double AverageTotalEfficiency { get; set; }
        /// <summary>
        /// Gets or sets the Currency.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.TradesPerformanceValues Currency { get; set; }
        /// <summary>
        /// Gets or sets the GrossLoss.
        /// </summary>
        [DataMember]
        public double GrossLoss { get; set; }
        /// <summary>
        /// Gets or sets the GrossProfit.
        /// </summary>
        [DataMember]
        public double GrossProfit { get; set; }
        /// <summary>
        /// Gets or sets the LongestFlatPeriod.
        /// </summary>
        [DataMember]
        public System.TimeSpan LongestFlatPeriod { get; set; }
        /// <summary>
        /// Gets or sets the LongestFlatPeriodSerializable.
        /// </summary>
        [DataMember]
        public long LongestFlatPeriodSerializable { get; set; }
        /// <summary>
        /// Gets or sets the MaxConsecutiveLoser.
        /// </summary>
        [DataMember]
        public int MaxConsecutiveLoser { get; set; }
        /// <summary>
        /// Gets or sets the MaxConsecutiveWinner.
        /// </summary>
        [DataMember]
        public int MaxConsecutiveWinner { get; set; }
        /// <summary>
        /// Gets or sets the MaxDate.
        /// </summary>
        [DataMember]
        public System.DateTime MaxDate { get; set; }
        /// <summary>
        /// Gets or sets the MaxTimeToRecover.
        /// </summary>
        [DataMember]
        public System.TimeSpan MaxTimeToRecover { get; set; }
        /// <summary>
        /// Gets or sets the MaxTime2RecoverSerializable.
        /// </summary>
        [DataMember]
        public long MaxTime2RecoverSerializable { get; set; }
        /// <summary>
        /// Gets or sets the MinDate.
        /// </summary>
        [DataMember]
        public System.DateTime MinDate { get; set; }
        /// <summary>
        /// Gets or sets the MonthlyStdDev.
        /// </summary>
        [DataMember]
        public double MonthlyStdDev { get; set; }
        /// <summary>
        /// Gets or sets the MonthlyUlcer.
        /// </summary>
        [DataMember]
        public double MonthlyUlcer { get; set; }
        /// <summary>
        /// Gets or sets the MonthlyDownTarget.
        /// </summary>
        [DataMember]
        public double MonthlyDownTarget { get; set; }
        /// <summary>
        /// Gets or sets the NeedsUpdate.
        /// </summary>
        [DataMember]
        public bool NeedsUpdate { get; set; }
        /// <summary>
        /// Gets or sets the NetProfit.
        /// </summary>
        [DataMember]
        public double NetProfit { get; set; }
        /// <summary>
        /// Gets or sets the Percent.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.TradesPerformanceValues Percent { get; set; }
        /// <summary>
        /// Gets or sets the PerformanceMetrics.
        /// </summary>
        [DataMember]
        public NinjaTrader.NinjaScript.PerformanceMetricBase[] PerformanceMetrics { get; set; }
        /// <summary>
        /// Gets or sets the Pips.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.TradesPerformanceValues Pips { get; set; }
        /// <summary>
        /// Gets or sets the Points.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.TradesPerformanceValues Points { get; set; }
        /// <summary>
        /// Gets or sets the Probability.
        /// </summary>
        [DataMember]
        public double Probability { get; set; }
        /// <summary>
        /// Gets or sets the ProfitFactor.
        /// </summary>
        [DataMember]
        public double ProfitFactor { get; set; }
        /// <summary>
        /// Gets or sets the RiskFreeReturn.
        /// </summary>
        [DataMember]
        public double RiskFreeReturn { get; set; }
        /// <summary>
        /// Gets or sets the RSquared.
        /// </summary>
        [DataMember]
        public double RSquared { get; set; }
        /// <summary>
        /// Gets or sets the SharpeRatio.
        /// </summary>
        [DataMember]
        public double SharpeRatio { get; set; }
        /// <summary>
        /// Gets or sets the SortinoRatio.
        /// </summary>
        [DataMember]
        public double SortinoRatio { get; set; }
        /// <summary>
        /// Gets or sets the Ticks.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.TradesPerformanceValues Ticks { get; set; }
        /// <summary>
        /// Gets or sets the TotalQuantity.
        /// </summary>
        [DataMember]
        public int TotalQuantity { get; set; }
        /// <summary>
        /// Gets or sets the TradesCount.
        /// </summary>
        [DataMember]
        public int TradesCount { get; set; }
        /// <summary>
        /// Gets or sets the TradesPerDay.
        /// </summary>
        [DataMember]
        public double TradesPerDay { get; set; }
        /// <summary>
        /// Gets or sets the TotalCommission.
        /// </summary>
        [DataMember]
        public double TotalCommission { get; set; }
        /// <summary>
        /// Gets or sets the TotalSlippage.
        /// </summary>
        [DataMember]
        public double TotalSlippage { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
