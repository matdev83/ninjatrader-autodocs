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
        public double? AverageDailyVolume { get; set; }
        /// <summary>
        /// Gets or sets the Beta.
        /// </summary>
        [DataMember]
        public double? Beta { get; set; }
        /// <summary>
        /// Gets or sets the CalendarYearHigh.
        /// </summary>
        [DataMember]
        public double? CalendarYearHigh { get; set; }
        /// <summary>
        /// Gets or sets the CalendarYearHighDate.
        /// </summary>
        [DataMember]
        public System.DateTime? CalendarYearHighDate { get; set; }
        /// <summary>
        /// Gets or sets the CalendarYearLow.
        /// </summary>
        [DataMember]
        public double? CalendarYearLow { get; set; }
        /// <summary>
        /// Gets or sets the CalendarYearLowDate.
        /// </summary>
        [DataMember]
        public System.DateTime? CalendarYearLowDate { get; set; }
        /// <summary>
        /// Gets or sets the CurrentRatio.
        /// </summary>
        [DataMember]
        public double? CurrentRatio { get; set; }
        /// <summary>
        /// Gets or sets the Day200MovingAverage.
        /// </summary>
        [DataMember]
        public double? Day200MovingAverage { get; set; }
        /// <summary>
        /// Gets or sets the Day50MovingAverage.
        /// </summary>
        [DataMember]
        public double? Day50MovingAverage { get; set; }
        /// <summary>
        /// Gets or sets the DividendAmount.
        /// </summary>
        [DataMember]
        public double? DividendAmount { get; set; }
        /// <summary>
        /// Gets or sets the DividendHistory.
        /// </summary>
        [DataMember]
        public string DividendHistory { get; set; }
        /// <summary>
        /// Gets or sets the DividendPayDate.
        /// </summary>
        [DataMember]
        public System.DateTime? DividendPayDate { get; set; }
        /// <summary>
        /// Gets or sets the DividendYield.
        /// </summary>
        [DataMember]
        public double? DividendYield { get; set; }
        /// <summary>
        /// Gets or sets the EarningsPerShare.
        /// </summary>
        [DataMember]
        public double? EarningsPerShare { get; set; }
        /// <summary>
        /// Gets or sets the FiveYearsGrowthPercentage.
        /// </summary>
        [DataMember]
        public double? FiveYearsGrowthPercentage { get; set; }
        /// <summary>
        /// Gets or sets the High52Weeks.
        /// </summary>
        [DataMember]
        public double? High52Weeks { get; set; }
        /// <summary>
        /// Gets or sets the High52WeeksDate.
        /// </summary>
        [DataMember]
        public System.DateTime? High52WeeksDate { get; set; }
        /// <summary>
        /// Gets or sets the HistoricalVolatility.
        /// </summary>
        [DataMember]
        public double? HistoricalVolatility { get; set; }
        /// <summary>
        /// Gets or sets the InsiderOwned.
        /// </summary>
        [DataMember]
        public double? InsiderOwned { get; set; }
        /// <summary>
        /// Gets or sets the Low52Weeks.
        /// </summary>
        [DataMember]
        public double? Low52Weeks { get; set; }
        /// <summary>
        /// Gets or sets the Low52WeeksDate.
        /// </summary>
        [DataMember]
        public System.DateTime? Low52WeeksDate { get; set; }
        /// <summary>
        /// Gets or sets the MarketCap.
        /// </summary>
        [DataMember]
        public double? MarketCap { get; set; }
        /// <summary>
        /// Gets or sets the Instrument.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.Instrument Instrument { get; set; }
        /// <summary>
        /// Gets or sets the NextEarningsDate.
        /// </summary>
        [DataMember]
        public System.DateTime? NextEarningsDate { get; set; }
        /// <summary>
        /// Gets or sets the NextYearsEarningsPerShare.
        /// </summary>
        [DataMember]
        public double? NextYearsEarningsPerShare { get; set; }
        /// <summary>
        /// Gets or sets the PercentHeldByInstitutions.
        /// </summary>
        [DataMember]
        public double? PercentHeldByInstitutions { get; set; }
        /// <summary>
        /// Gets or sets the PriceEarningsRatio.
        /// </summary>
        [DataMember]
        public double? PriceEarningsRatio { get; set; }
        /// <summary>
        /// Gets or sets the RevenuePerShare.
        /// </summary>
        [DataMember]
        public double? RevenuePerShare { get; set; }
        /// <summary>
        /// Gets or sets the SharesOutstanding.
        /// </summary>
        [DataMember]
        public long? SharesOutstanding { get; set; }
        /// <summary>
        /// Gets or sets the ShortInterest.
        /// </summary>
        [DataMember]
        public double? ShortInterest { get; set; }
        /// <summary>
        /// Gets or sets the ShortInterestRatio.
        /// </summary>
        [DataMember]
        public double? ShortInterestRatio { get; set; }
        /// <summary>
        /// Gets or sets the SplitHistory.
        /// </summary>
        [DataMember]
        public string SplitHistory { get; set; }
        /// <summary>
        /// Gets or sets the VWAP.
        /// </summary>
        [DataMember]
        public double? VWAP { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// GetProperties method.
        /// </summary>
        /// <returns>System.Collections.Generic.Dictionary<FundamentalDataType, System.Tuple<System.Reflection.PropertyInfo, System.Type>></returns>
        public System.Collections.Generic.Dictionary<FundamentalDataType, System.Tuple<System.Reflection.PropertyInfo, System.Type>> GetProperties()
        {
            // Method implementation goes here
        }
        #endregion
    }
}
