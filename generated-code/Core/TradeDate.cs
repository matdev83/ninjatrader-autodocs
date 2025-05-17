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
        public Int32 Day { get; set; }
        /// <summary>
        /// Gets or sets the Month.
        /// </summary>
        [DataMember]
        public Int32 Month { get; set; }
        /// <summary>
        /// Gets or sets the Year.
        /// </summary>
        [DataMember]
        public Int32 Year { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// ToString method.
        /// </summary>
        /// <returns>String</returns>
        public String ToString();
        #endregion
    }
}
