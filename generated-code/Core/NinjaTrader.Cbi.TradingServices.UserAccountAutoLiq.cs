[Serializable]
[DataContract]
namespace NinjaTrader.Cbi.TradingServices
{
    public partial class UserAccountAutoLiq
    {
        #region Properties
        /// <summary>
        /// Gets or sets the ChangesLocked.
        /// </summary>
        [DataMember]
        public bool ChangesLocked { get; set; }
        /// <summary>
        /// Gets or sets the DailyLossAlert.
        /// </summary>
        [DataMember]
        public double DailyLossAlert { get; set; }
        /// <summary>
        /// Gets or sets the DailyLossAutoLiq.
        /// </summary>
        [DataMember]
        public double DailyLossAutoLiq { get; set; }
        /// <summary>
        /// Gets or sets the DailyLossLiqOnly.
        /// </summary>
        [DataMember]
        public double DailyLossLiqOnly { get; set; }
        /// <summary>
        /// Gets or sets the DailyLossPercentageAlert.
        /// </summary>
        [DataMember]
        public double DailyLossPercentageAlert { get; set; }
        /// <summary>
        /// Gets or sets the DailyLossPercentageAutoLiq.
        /// </summary>
        [DataMember]
        public double DailyLossPercentageAutoLiq { get; set; }
        /// <summary>
        /// Gets or sets the DailyLosspercentageLiqOnly.
        /// </summary>
        [DataMember]
        public double DailyLosspercentageLiqOnly { get; set; }
        /// <summary>
        /// Gets or sets the DailyProfitAutoLiq.
        /// </summary>
        [DataMember]
        public double DailyProfitAutoLiq { get; set; }
        /// <summary>
        /// Gets or sets the DoNotUnlock.
        /// </summary>
        [DataMember]
        public bool DoNotUnlock { get; set; }
        /// <summary>
        /// Gets or sets the FlattenTimestamp.
        /// </summary>
        [DataMember]
        public System.DateTime FlattenTimestamp { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public long Id { get; set; }
        /// <summary>
        /// Gets or sets the MarginPercentageAlert.
        /// </summary>
        [DataMember]
        public double MarginPercentageAlert { get; set; }
        /// <summary>
        /// Gets or sets the MarginPercentageAutoLiq.
        /// </summary>
        [DataMember]
        public double MarginPercentageAutoLiq { get; set; }
        /// <summary>
        /// Gets or sets the MarginPercentageLiqOnly.
        /// </summary>
        [DataMember]
        public double MarginPercentageLiqOnly { get; set; }
        /// <summary>
        /// Gets or sets the TrailingMaxDrawdown.
        /// </summary>
        [DataMember]
        public double TrailingMaxDrawdown { get; set; }
        /// <summary>
        /// Gets or sets the TrailingMaxDrawdownLimit.
        /// </summary>
        [DataMember]
        public double TrailingMaxDrawdownLimit { get; set; }
        /// <summary>
        /// Gets or sets the TrailingMaxDrawdownMode.
        /// </summary>
        [DataMember]
        public string TrailingMaxDrawdownMode { get; set; }
        /// <summary>
        /// Gets or sets the WeeklyLossAutoLiq.
        /// </summary>
        [DataMember]
        public double WeeklyLossAutoLiq { get; set; }
        /// <summary>
        /// Gets or sets the WeeklyProfitAutoLiq.
        /// </summary>
        [DataMember]
        public double WeeklyProfitAutoLiq { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
