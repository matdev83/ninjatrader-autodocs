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
        public Boolean ChangesLocked { get; set; }
        /// <summary>
        /// Gets or sets the DailyLossAlert.
        /// </summary>
        [DataMember]
        public Double DailyLossAlert { get; set; }
        /// <summary>
        /// Gets or sets the DailyLossAutoLiq.
        /// </summary>
        [DataMember]
        public Double DailyLossAutoLiq { get; set; }
        /// <summary>
        /// Gets or sets the DailyLossLiqOnly.
        /// </summary>
        [DataMember]
        public Double DailyLossLiqOnly { get; set; }
        /// <summary>
        /// Gets or sets the DailyLossPercentageAlert.
        /// </summary>
        [DataMember]
        public Double DailyLossPercentageAlert { get; set; }
        /// <summary>
        /// Gets or sets the DailyLossPercentageAutoLiq.
        /// </summary>
        [DataMember]
        public Double DailyLossPercentageAutoLiq { get; set; }
        /// <summary>
        /// Gets or sets the DailyLosspercentageLiqOnly.
        /// </summary>
        [DataMember]
        public Double DailyLosspercentageLiqOnly { get; set; }
        /// <summary>
        /// Gets or sets the DailyProfitAutoLiq.
        /// </summary>
        [DataMember]
        public Double DailyProfitAutoLiq { get; set; }
        /// <summary>
        /// Gets or sets the DoNotUnlock.
        /// </summary>
        [DataMember]
        public Boolean DoNotUnlock { get; set; }
        /// <summary>
        /// Gets or sets the FlattenTimestamp.
        /// </summary>
        [DataMember]
        public DateTime FlattenTimestamp { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public Int64 Id { get; set; }
        /// <summary>
        /// Gets or sets the MarginPercentageAlert.
        /// </summary>
        [DataMember]
        public Double MarginPercentageAlert { get; set; }
        /// <summary>
        /// Gets or sets the MarginPercentageAutoLiq.
        /// </summary>
        [DataMember]
        public Double MarginPercentageAutoLiq { get; set; }
        /// <summary>
        /// Gets or sets the MarginPercentageLiqOnly.
        /// </summary>
        [DataMember]
        public Double MarginPercentageLiqOnly { get; set; }
        /// <summary>
        /// Gets or sets the TrailingMaxDrawdown.
        /// </summary>
        [DataMember]
        public Double TrailingMaxDrawdown { get; set; }
        /// <summary>
        /// Gets or sets the TrailingMaxDrawdownLimit.
        /// </summary>
        [DataMember]
        public Double TrailingMaxDrawdownLimit { get; set; }
        /// <summary>
        /// Gets or sets the TrailingMaxDrawdownMode.
        /// </summary>
        [DataMember]
        public String TrailingMaxDrawdownMode { get; set; }
        /// <summary>
        /// Gets or sets the WeeklyLossAutoLiq.
        /// </summary>
        [DataMember]
        public Double WeeklyLossAutoLiq { get; set; }
        /// <summary>
        /// Gets or sets the WeeklyProfitAutoLiq.
        /// </summary>
        [DataMember]
        public Double WeeklyProfitAutoLiq { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
