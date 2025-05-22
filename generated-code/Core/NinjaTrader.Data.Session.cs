[Serializable]
[DataContract]
namespace NinjaTrader.Data
{
    public partial class Session
    {
        #region Properties
        /// <summary>
        /// Gets or sets the BeginDay.
        /// </summary>
        [DataMember]
        public DayOfWeek BeginDay { get; set; }
        /// <summary>
        /// Gets or sets the BeginTime.
        /// </summary>
        [DataMember]
        public int BeginTime { get; set; }
        /// <summary>
        /// Gets or sets the EndDay.
        /// </summary>
        [DataMember]
        public DayOfWeek EndDay { get; set; }
        /// <summary>
        /// Gets or sets the EndTime.
        /// </summary>
        [DataMember]
        public int EndTime { get; set; }
        /// <summary>
        /// Gets or sets the TradingDay.
        /// </summary>
        [DataMember]
        public DayOfWeek TradingDay { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>string</returns>
        public string ToString()
        {
            // Method implementation goes here
        }
        #endregion
    }
}
