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
        public long AccountId { get; set; }
        /// <summary>
        /// Gets or sets the Amount.
        /// </summary>
        [DataMember]
        public double Amount { get; set; }
        /// <summary>
        /// Gets or sets the CurrencyId.
        /// </summary>
        [DataMember]
        public long CurrencyId { get; set; }
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [DataMember]
        public long Id { get; set; }
        /// <summary>
        /// Gets or sets the RealizedPnL.
        /// </summary>
        [DataMember]
        public double RealizedPnL { get; set; }
        /// <summary>
        /// Gets or sets the Timestamp.
        /// </summary>
        [DataMember]
        public System.DateTime Timestamp { get; set; }
        /// <summary>
        /// Gets or sets the TradeDate.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.TradingServices.TradeDate TradeDate { get; set; }
        /// <summary>
        /// Gets or sets the WeekRealizedPnl.
        /// </summary>
        [DataMember]
        public double WeekRealizedPnl { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
