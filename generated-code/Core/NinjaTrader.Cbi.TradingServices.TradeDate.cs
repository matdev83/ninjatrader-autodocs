[Serializable]
[DataContract]
namespace NinjaTrader.Cbi.TradingServices
{
    public partial class TradeDate
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Day.
        /// </summary>
        [DataMember]
        public int Day { get; set; }
        /// <summary>
        /// Gets or sets the Month.
        /// </summary>
        [DataMember]
        public int Month { get; set; }
        /// <summary>
        /// Gets or sets the Year.
        /// </summary>
        [DataMember]
        public int Year { get; set; }
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
