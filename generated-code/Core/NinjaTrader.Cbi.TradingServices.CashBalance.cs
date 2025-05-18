[Serializable]
[DataContract]
namespace NinjaTrader.Cbi.TradingServices
{
    public partial class CashBalance
    {
        #region Properties
        /// <summary>
        /// Gets or sets the AccountId.
        /// </summary>
        [DataMember]
        public Int64 AccountId { get; set; }
        /// <summary>
        /// Gets or sets the Amount.
        /// </summary>
        [DataMember]
        public Double Amount { get; set; }
        /// <summary>
        /// Gets or sets the CurrencyId.
        /// </summary>
        [DataMember]
        public Int64 CurrencyId { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public Int64 Id { get; set; }
        /// <summary>
        /// Gets or sets the RealizedPnL.
        /// </summary>
        [DataMember]
        public Double RealizedPnL { get; set; }
        /// <summary>
        /// Gets or sets the Timestamp.
        /// </summary>
        [DataMember]
        public DateTime Timestamp { get; set; }
        /// <summary>
        /// Gets or sets the TradeDate.
        /// </summary>
        [DataMember]
        public TradeDate TradeDate { get; set; }
        /// <summary>
        /// Gets or sets the WeekRealizedPnl.
        /// </summary>
        [DataMember]
        public Double WeekRealizedPnl { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
