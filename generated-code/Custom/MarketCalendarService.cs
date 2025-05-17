[Serializable]
[DataContract]
namespace NinjaTrader.NinjaScript.AddOns
{
    public partial class MarketCalendarService
    {
        #region Properties
        #endregion
        #region Methods
        /// <summary>
        /// GetInstance method.
        /// </summary>
        /// <returns>MarketCalendarService</returns>
        public MarketCalendarService GetInstance();
        /// <summary>
        /// GetEventType method.
        /// </summary>
        /// <param name="date">DateTime</param>
        /// <returns>DayOfWeekExtended</returns>
        public DayOfWeekExtended GetEventType(DateTime date);
        /// <summary>
        /// GetEventType method.
        /// </summary>
        /// <param name="dateStr">String</param>
        /// <returns>DayOfWeekExtended</returns>
        public DayOfWeekExtended GetEventType(String dateStr);
        /// <summary>
        /// GetDayOfWeekExtended method.
        /// </summary>
        /// <param name="date">DateTime</param>
        /// <returns>DayOfWeekExtended</returns>
        public DayOfWeekExtended GetDayOfWeekExtended(DateTime date);
        /// <summary>
        /// IsTwoDaysAheadOfLongWeekend method.
        /// </summary>
        /// <param name="date">DateTime</param>
        /// <returns>Boolean</returns>
        public Boolean IsTwoDaysAheadOfLongWeekend(DateTime date);
        /// <summary>
        /// IsOneDayAheadOfLongWeekend method.
        /// </summary>
        /// <param name="date">DateTime</param>
        /// <returns>Boolean</returns>
        public Boolean IsOneDayAheadOfLongWeekend(DateTime date);
        /// <summary>
        /// IsFullTradingDay method.
        /// </summary>
        /// <param name="date">DateTime</param>
        /// <returns>Boolean</returns>
        public Boolean IsFullTradingDay(DateTime date);
        /// <summary>
        /// IsTomorrowHoliday method.
        /// </summary>
        /// <param name="date">DateTime</param>
        /// <returns>Boolean</returns>
        public Boolean IsTomorrowHoliday(DateTime date);
        /// <summary>
        /// IsOpexWeek method.
        /// </summary>
        /// <param name="date">DateTime</param>
        /// <returns>Boolean</returns>
        public Boolean IsOpexWeek(DateTime date);
        /// <summary>
        /// IsQuarterlyOpexWeek method.
        /// </summary>
        /// <param name="date">DateTime</param>
        /// <returns>Boolean</returns>
        public Boolean IsQuarterlyOpexWeek(DateTime date);
        /// <summary>
        /// TestIsLongWeekend method.
        /// </summary>
        public Void TestIsLongWeekend();
        /// <summary>
        /// TestIsFullTradingDay method.
        /// </summary>
        public Void TestIsFullTradingDay();
        /// <summary>
        /// TestIsTomorrowHoliday method.
        /// </summary>
        public Void TestIsTomorrowHoliday();
        #endregion
    }
}
