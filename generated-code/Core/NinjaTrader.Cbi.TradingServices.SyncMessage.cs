[Serializable]
[DataContract]
namespace NinjaTrader.Cbi.TradingServices
{
    public partial class SyncMessage
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Accounts.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.TradingServices.Account[] Accounts { get; set; }
        /// <summary>
        /// Gets or sets the CashBalances.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.TradingServices.CashBalance[] CashBalances { get; set; }
        /// <summary>
        /// Gets or sets the Commands.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.TradingServices.Command[] Commands { get; set; }
        /// <summary>
        /// Gets or sets the Contracts.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.TradingServices.Contract[] Contracts { get; set; }
        /// <summary>
        /// Gets or sets the ExecutionReports.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.TradingServices.ExecutionReport[] ExecutionReports { get; set; }
        /// <summary>
        /// Gets or sets the Fills.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.TradingServices.Fill[] Fills { get; set; }
        /// <summary>
        /// Gets or sets the MarginSnapshots.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.TradingServices.MarginSnapshot[] MarginSnapshots { get; set; }
        /// <summary>
        /// Gets or sets the Positions.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.TradingServices.Position[] Positions { get; set; }
        /// <summary>
        /// Gets or sets the Properties.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.TradingServices.Property[] Properties { get; set; }
        /// <summary>
        /// Gets or sets the Orders.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.TradingServices.Order[] Orders { get; set; }
        /// <summary>
        /// Gets or sets the OrderStrategies.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.TradingServices.OrderStrategyItem[] OrderStrategies { get; set; }
        /// <summary>
        /// Gets or sets the OrderStrategyLinks.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.TradingServices.OrderStrategyLink[] OrderStrategyLinks { get; set; }
        /// <summary>
        /// Gets or sets the OrderVersions.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.TradingServices.OrderVersion[] OrderVersions { get; set; }
        /// <summary>
        /// Gets or sets the UserAccountAutoLiqs.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.TradingServices.UserAccountAutoLiq[] UserAccountAutoLiqs { get; set; }
        /// <summary>
        /// Gets or sets the UserProperties.
        /// </summary>
        [DataMember]
        public NinjaTrader.Cbi.TradingServices.UserProperty[] UserProperties { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
