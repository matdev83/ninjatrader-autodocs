[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class SessionIterator
    {
        #region Properties
        /// <summary>
        /// Gets or sets the ActualSessionEnd.
        /// </summary>
        [DataMember]
        public DateTime ActualSessionEnd { get; set; }
        /// <summary>
        /// Gets or sets the ActualSessionBegin.
        /// </summary>
        [DataMember]
        public DateTime ActualSessionBegin { get; set; }
        /// <summary>
        /// Gets or sets the ActualTradingDayEndLocal.
        /// </summary>
        [DataMember]
        public DateTime ActualTradingDayEndLocal { get; set; }
        /// <summary>
        /// Gets or sets the ActualTradingDayExchange.
        /// </summary>
        [DataMember]
        public DateTime ActualTradingDayExchange { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// IsTradingDayDefined method.
        /// </summary>
        /// <param name="date">DateTime</param>
        /// <returns>Boolean</returns>
        public Boolean IsTradingDayDefined(DateTime date);
        /// <summary>
        /// CalculateTradingDay method.
        /// </summary>
        /// <param name="timeLocal">DateTime</param>
        /// <param name="includesEndTimeStamp">Boolean</param>
        public Void CalculateTradingDay(DateTime timeLocal, Boolean includesEndTimeStamp);
        /// <summary>
        /// GetNextSession method.
        /// </summary>
        /// <param name="timeLocal">DateTime</param>
        /// <param name="includesEndTimeStamp">Boolean</param>
        /// <returns>Boolean</returns>
        public Boolean GetNextSession(DateTime timeLocal, Boolean includesEndTimeStamp);
        /// <summary>
        /// GetTradingDay method.
        /// </summary>
        /// <param name="timeLocal">DateTime</param>
        /// <returns>DateTime</returns>
        public DateTime GetTradingDay(DateTime timeLocal);
        /// <summary>
        /// GetTradingDayBeginLocal method.
        /// </summary>
        /// <param name="tradingDayExchange">DateTime</param>
        /// <returns>DateTime</returns>
        public DateTime GetTradingDayBeginLocal(DateTime tradingDayExchange);
        /// <summary>
        /// GetTradingDayEndLocal method.
        /// </summary>
        /// <param name="tradingDayExchange">DateTime</param>
        /// <returns>DateTime</returns>
        public DateTime GetTradingDayEndLocal(DateTime tradingDayExchange);
        /// <summary>
        /// IsInSession method.
        /// </summary>
        /// <param name="timeLocal">DateTime</param>
        /// <param name="includesEndTimeStamp">Boolean</param>
        /// <param name="isIntraday">Boolean</param>
        /// <returns>Boolean</returns>
        public Boolean IsInSession(DateTime timeLocal, Boolean includesEndTimeStamp, Boolean isIntraday);
        /// <summary>
        /// IsNewSession method.
        /// </summary>
        /// <param name="time">DateTime</param>
        /// <param name="includesEndTimeStamp">Boolean</param>
        /// <returns>Boolean</returns>
        public Boolean IsNewSession(DateTime time, Boolean includesEndTimeStamp);
        /// <summary>
        /// Reset method.
        /// </summary>
        public Void Reset();
        #endregion
    }
}
