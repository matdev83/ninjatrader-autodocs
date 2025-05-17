[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class FundamentalData
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AverageDailyVolume.
        /// </summary>
        [DataMember]
        public Nullable<Double> AverageDailyVolume { get; set; }
        /// <summary>
        /// Gets or sets the Beta.
        /// </summary>
        [DataMember]
        public Nullable<Double> Beta { get; set; }
        /// <summary>
        /// Gets or sets the CalendarYearHigh.
        /// </summary>
        [DataMember]
        public Nullable<Double> CalendarYearHigh { get; set; }
        /// <summary>
        /// Gets or sets the CalendarYearHighDate.
        /// </summary>
        [DataMember]
        public Nullable<DateTime> CalendarYearHighDate { get; set; }
        /// <summary>
        /// Gets or sets the CalendarYearLow.
        /// </summary>
        [DataMember]
        public Nullable<Double> CalendarYearLow { get; set; }
        /// <summary>
        /// Gets or sets the CalendarYearLowDate.
        /// </summary>
        [DataMember]
        public Nullable<DateTime> CalendarYearLowDate { get; set; }
        /// <summary>
        /// Gets or sets the CurrentRatio.
        /// </summary>
        [DataMember]
        public Nullable<Double> CurrentRatio { get; set; }
        /// <summary>
        /// Gets or sets the Day200MovingAverage.
        /// </summary>
        [DataMember]
        public Nullable<Double> Day200MovingAverage { get; set; }
        /// <summary>
        /// Gets or sets the Day50MovingAverage.
        /// </summary>
        [DataMember]
        public Nullable<Double> Day50MovingAverage { get; set; }
        /// <summary>
        /// Gets or sets the DividendAmount.
        /// </summary>
        [DataMember]
        public Nullable<Double> DividendAmount { get; set; }
        /// <summary>
        /// Gets or sets the DividendHistory.
        /// </summary>
        [DataMember]
        public String DividendHistory { get; set; }
        /// <summary>
        /// Gets or sets the DividendPayDate.
        /// </summary>
        [DataMember]
        public Nullable<DateTime> DividendPayDate { get; set; }
        /// <summary>
        /// Gets or sets the DividendYield.
        /// </summary>
        [DataMember]
        public Nullable<Double> DividendYield { get; set; }
        /// <summary>
        /// Gets or sets the EarningsPerShare.
        /// </summary>
        [DataMember]
        public Nullable<Double> EarningsPerShare { get; set; }
        /// <summary>
        /// Gets or sets the FiveYearsGrowthPercentage.
        /// </summary>
        [DataMember]
        public Nullable<Double> FiveYearsGrowthPercentage { get; set; }
        /// <summary>
        /// Gets or sets the High52Weeks.
        /// </summary>
        [DataMember]
        public Nullable<Double> High52Weeks { get; set; }
        /// <summary>
        /// Gets or sets the High52WeeksDate.
        /// </summary>
        [DataMember]
        public Nullable<DateTime> High52WeeksDate { get; set; }
        /// <summary>
        /// Gets or sets the HistoricalVolatility.
        /// </summary>
        [DataMember]
        public Nullable<Double> HistoricalVolatility { get; set; }
        /// <summary>
        /// Gets or sets the InsiderOwned.
        /// </summary>
        [DataMember]
        public Nullable<Double> InsiderOwned { get; set; }
        /// <summary>
        /// Gets or sets the Low52Weeks.
        /// </summary>
        [DataMember]
        public Nullable<Double> Low52Weeks { get; set; }
        /// <summary>
        /// Gets or sets the Low52WeeksDate.
        /// </summary>
        [DataMember]
        public Nullable<DateTime> Low52WeeksDate { get; set; }
        /// <summary>
        /// Gets or sets the MarketCap.
        /// </summary>
        [DataMember]
        public Nullable<Double> MarketCap { get; set; }
        /// <summary>
        /// Gets or sets the Instrument.
        /// </summary>
        [DataMember]
        public Instrument Instrument { get; set; }
        /// <summary>
        /// Gets or sets the NextEarningsDate.
        /// </summary>
        [DataMember]
        public Nullable<DateTime> NextEarningsDate { get; set; }
        /// <summary>
        /// Gets or sets the NextYearsEarningsPerShare.
        /// </summary>
        [DataMember]
        public Nullable<Double> NextYearsEarningsPerShare { get; set; }
        /// <summary>
        /// Gets or sets the PercentHeldByInstitutions.
        /// </summary>
        [DataMember]
        public Nullable<Double> PercentHeldByInstitutions { get; set; }
        /// <summary>
        /// Gets or sets the PriceEarningsRatio.
        /// </summary>
        [DataMember]
        public Nullable<Double> PriceEarningsRatio { get; set; }
        /// <summary>
        /// Gets or sets the RevenuePerShare.
        /// </summary>
        [DataMember]
        public Nullable<Double> RevenuePerShare { get; set; }
        /// <summary>
        /// Gets or sets the SharesOutstanding.
        /// </summary>
        [DataMember]
        public Nullable<Int64> SharesOutstanding { get; set; }
        /// <summary>
        /// Gets or sets the ShortInterest.
        /// </summary>
        [DataMember]
        public Nullable<Double> ShortInterest { get; set; }
        /// <summary>
        /// Gets or sets the ShortInterestRatio.
        /// </summary>
        [DataMember]
        public Nullable<Double> ShortInterestRatio { get; set; }
        /// <summary>
        /// Gets or sets the SplitHistory.
        /// </summary>
        [DataMember]
        public String SplitHistory { get; set; }
        /// <summary>
        /// Gets or sets the VWAP.
        /// </summary>
        [DataMember]
        public Nullable<Double> VWAP { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// GetProperties method.
        /// </summary>
        /// <returns>Dictionary`2</returns>
        public Dictionary<FundamentalDataType, Tuple<PropertyInfo, Type>> GetProperties();
        #endregion
    }
}
