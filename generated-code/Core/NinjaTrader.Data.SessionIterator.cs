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
        public System.DateTime ActualSessionEnd { get; set; }
        /// <summary>
        /// Gets or sets the ActualSessionBegin.
        /// </summary>
        [DataMember]
        public System.DateTime ActualSessionBegin { get; set; }
        /// <summary>
        /// Gets or sets the ActualTradingDayEndLocal.
        /// </summary>
        [DataMember]
        public System.DateTime ActualTradingDayEndLocal { get; set; }
        /// <summary>
        /// Gets or sets the ActualTradingDayExchange.
        /// </summary>
        [DataMember]
        public System.DateTime ActualTradingDayExchange { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// IsTradingDayDefined method.
        /// </summary>
        /// <param name="date">System.DateTime</param>
        /// <returns>bool</returns>
        public bool IsTradingDayDefined(System.DateTime date)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// CalculateTradingDay method.
        /// </summary>
        /// <param name="timeLocal">System.DateTime</param>
        /// <param name="includesEndTimeStamp">bool</param>
        public void CalculateTradingDay(System.DateTime timeLocal, bool includesEndTimeStamp)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetNextSession method.
        /// </summary>
        /// <param name="timeLocal">System.DateTime</param>
        /// <param name="includesEndTimeStamp">bool</param>
        /// <returns>bool</returns>
        public bool GetNextSession(System.DateTime timeLocal, bool includesEndTimeStamp)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetTradingDay method.
        /// </summary>
        /// <param name="timeLocal">System.DateTime</param>
        /// <returns>System.DateTime</returns>
        public System.DateTime GetTradingDay(System.DateTime timeLocal)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetTradingDayBeginLocal method.
        /// </summary>
        /// <param name="tradingDayExchange">System.DateTime</param>
        /// <returns>System.DateTime</returns>
        public System.DateTime GetTradingDayBeginLocal(System.DateTime tradingDayExchange)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// GetTradingDayEndLocal method.
        /// </summary>
        /// <param name="tradingDayExchange">System.DateTime</param>
        /// <returns>System.DateTime</returns>
        public System.DateTime GetTradingDayEndLocal(System.DateTime tradingDayExchange)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// IsInSession method.
        /// </summary>
        /// <param name="timeLocal">System.DateTime</param>
        /// <param name="includesEndTimeStamp">bool</param>
        /// <param name="isIntraday">bool</param>
        /// <returns>bool</returns>
        public bool IsInSession(System.DateTime timeLocal, bool includesEndTimeStamp, bool isIntraday)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// IsNewSession method.
        /// </summary>
        /// <param name="time">System.DateTime</param>
        /// <param name="includesEndTimeStamp">bool</param>
        /// <returns>bool</returns>
        public bool IsNewSession(System.DateTime time, bool includesEndTimeStamp)
        {
            // Method implementation goes here
        }
        /// <summary>
        /// Reset method.
        /// </summary>
        public void Reset()
        {
            // Method implementation goes here
        }
        #endregion
    }
}
