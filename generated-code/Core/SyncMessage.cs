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
        public Account[] Accounts { get; set; }
        /// <summary>
        /// Gets or sets the CashBalances.
        /// </summary>
        [DataMember]
        public CashBalance[] CashBalances { get; set; }
        /// <summary>
        /// Gets or sets the Commands.
        /// </summary>
        [DataMember]
        public Command[] Commands { get; set; }
        /// <summary>
        /// Gets or sets the Contracts.
        /// </summary>
        [DataMember]
        public Contract[] Contracts { get; set; }
        /// <summary>
        /// Gets or sets the ExecutionReports.
        /// </summary>
        [DataMember]
        public ExecutionReport[] ExecutionReports { get; set; }
        /// <summary>
        /// Gets or sets the Fills.
        /// </summary>
        [DataMember]
        public Fill[] Fills { get; set; }
        /// <summary>
        /// Gets or sets the MarginSnapshots.
        /// </summary>
        [DataMember]
        public MarginSnapshot[] MarginSnapshots { get; set; }
        /// <summary>
        /// Gets or sets the Positions.
        /// </summary>
        [DataMember]
        public Position[] Positions { get; set; }
        /// <summary>
        /// Gets or sets the Properties.
        /// </summary>
        [DataMember]
        public Property[] Properties { get; set; }
        /// <summary>
        /// Gets or sets the Orders.
        /// </summary>
        [DataMember]
        public Order[] Orders { get; set; }
        /// <summary>
        /// Gets or sets the OrderStrategies.
        /// </summary>
        [DataMember]
        public OrderStrategyItem[] OrderStrategies { get; set; }
        /// <summary>
        /// Gets or sets the OrderStrategyLinks.
        /// </summary>
        [DataMember]
        public OrderStrategyLink[] OrderStrategyLinks { get; set; }
        /// <summary>
        /// Gets or sets the OrderVersions.
        /// </summary>
        [DataMember]
        public OrderVersion[] OrderVersions { get; set; }
        /// <summary>
        /// Gets or sets the UserAccountAutoLiqs.
        /// </summary>
        [DataMember]
        public UserAccountAutoLiq[] UserAccountAutoLiqs { get; set; }
        /// <summary>
        /// Gets or sets the UserProperties.
        /// </summary>
        [DataMember]
        public UserProperty[] UserProperties { get; set; }
        #endregion
        #region Methods
        #endregion
    }
}
